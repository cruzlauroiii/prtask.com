#!/usr/bin/env dotnet-script
// Usage: dotnet-script auto-translate-missing.csx
// Requires: ANTHROPIC_API_KEY environment variable
#r "nuget: Anthropic.SDK, 3.9.2"

using System.Xml;
using System.Text.Json;
using Anthropic.SDK;
using Anthropic.SDK.Messaging;

var resxDir = @"C:\work\prtask.com\src\PrTask.SharedUI\Resources";
var apiKey = Environment.GetEnvironmentVariable("ANTHROPIC_API_KEY")
    ?? throw new Exception("Set ANTHROPIC_API_KEY environment variable first");

var enMap = LoadResx(Path.Combine(resxDir, "SharedResource.resx"));
var zhMap = LoadResx(Path.Combine(resxDir, "SharedResource.zh.resx"));

var translatedKeys = zhMap.Keys
    .Where(k => enMap.ContainsKey(k) && zhMap[k] != enMap[k])
    .ToList();

Console.WriteLine($"zh has {translatedKeys.Count} translated keys (baseline for other langs)");

var langs = new Dictionary<string, string>
{
    ["ar"]  = "Arabic",
    ["de"]  = "German",
    ["es"]  = "Spanish",
    ["fil"] = "Filipino (Tagalog)",
    ["fr"]  = "French",
    ["hi"]  = "Hindi",
    ["id"]  = "Indonesian",
    ["it"]  = "Italian",
    ["ja"]  = "Japanese",
    ["ko"]  = "Korean",
    ["nl"]  = "Dutch",
    ["pt"]  = "Portuguese (Brazilian)",
    ["ru"]  = "Russian",
    ["tr"]  = "Turkish",
};

var client = new AnthropicClient(apiKey);
var jsonOpts = new JsonSerializerOptions { WriteIndented = false };

foreach (var (langCode, langName) in langs)
{
    var langMap = LoadResx(Path.Combine(resxDir, $"SharedResource.{langCode}.resx"));

    var missing = translatedKeys
        .Where(k => !langMap.ContainsKey(k) || langMap[k] == enMap[k])
        .ToList();

    if (missing.Count == 0) { Console.WriteLine($"[{langCode}] already complete"); continue; }
    Console.WriteLine($"[{langCode}] translating {missing.Count} keys...");

    const int batchSize = 50;
    var allNew = new Dictionary<string, string>();

    foreach (var batch in missing.Chunk(batchSize).Select((b, i) => (b, i)))
    {
        Console.Write($"  batch {batch.i + 1}/{(int)Math.Ceiling(missing.Count / (double)batchSize)}... ");

        var inputObj = batch.b.ToDictionary(k => k, k => enMap[k]);
        var inputJson = JsonSerializer.Serialize(inputObj, jsonOpts);

        var prompt = $"Translate these English UI strings for a developer task marketplace to {langName}.\n" +
            "Rules:\n" +
            "- Keep brand names unchanged: PrTask, GitHub, Cloudflare, Okta, Maya, GCash, GrabPay, Didit, Stripe, Blazor, MudBlazor, NuGet, Apache, PayPal, Mastercard, Visa\n" +
            "- Keep unchanged: URLs, email addresses, version numbers, cookie names (prtask-*), technical acronyms used globally (GDPR, PDF, CSV, API, etc.)\n" +
            "- Use natural professional phrasing for a software developer marketplace\n" +
            "- Return ONLY a valid JSON object, no markdown fences, no explanation\n\n" +
            $"Input:\n{inputJson}";

        string responseText = "";
        try
        {
            var response = await client.Messages.GetClaudeMessageAsync(new MessageParameters
            {
                Model = "claude-haiku-4-5-20251001",
                MaxTokens = 8192,
                Messages = [new Message(RoleType.User, prompt)]
            });
            responseText = response.Content.OfType<TextContent>().FirstOrDefault()?.Text ?? "";
            // Strip markdown fences
            responseText = System.Text.RegularExpressions.Regex.Replace(
                responseText.Trim(), @"^```[a-z]*\r?\n?|```$", "",
                System.Text.RegularExpressions.RegexOptions.Multiline).Trim();

            var parsed = JsonSerializer.Deserialize<Dictionary<string, string>>(responseText);
            if (parsed != null)
            {
                foreach (var (k, v) in parsed) allNew[k] = v;
                Console.WriteLine($"ok ({parsed.Count})");
            }
            else Console.WriteLine("parse failed");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
            if (responseText.Length > 0) Console.WriteLine($"  Response: {responseText[..Math.Min(200, responseText.Length)]}");
        }
        await Task.Delay(300);
    }

    foreach (var (k, v) in allNew) langMap[k] = v;
    SaveResx(Path.Combine(resxDir, $"SharedResource.{langCode}.resx"), langMap);
    Console.WriteLine($"[{langCode}] saved {allNew.Count} translations");
}

Console.WriteLine("All done.");

static Dictionary<string, string> LoadResx(string path)
{
    var xml = new XmlDocument();
    xml.Load(path);
    var map = new Dictionary<string, string>();
    foreach (XmlNode node in xml.SelectNodes("/root/data")!)
    {
        var name = node.Attributes?["name"]?.Value;
        var value = node.SelectSingleNode("value")?.InnerText;
        if (name != null && value != null) map[name] = value;
    }
    return map;
}

static void SaveResx(string path, Dictionary<string, string> map)
{
    var xml = new XmlDocument();
    xml.Load(path);
    var existing = new Dictionary<string, XmlNode>();
    foreach (XmlNode node in xml.SelectNodes("/root/data")!)
    {
        var name = node.Attributes?["name"]?.Value;
        if (name != null) existing[name] = node;
    }
    var root = xml.SelectSingleNode("/root")!;
    foreach (var (key, value) in map)
    {
        if (existing.TryGetValue(key, out var node))
        {
            var valNode = node.SelectSingleNode("value");
            if (valNode != null) valNode.InnerText = value;
        }
        else
        {
            var newNode = xml.CreateElement("data");
            var nameAttr = xml.CreateAttribute("name"); nameAttr.Value = key;
            newNode.Attributes!.Append(nameAttr);
            var spaceAttr = xml.CreateAttribute("xml:space"); spaceAttr.Value = "preserve";
            newNode.Attributes!.Append(spaceAttr);
            var valElem = xml.CreateElement("value"); valElem.InnerText = value;
            newNode.AppendChild(valElem);
            root.AppendChild(newNode);
        }
    }
    var settings = new XmlWriterSettings { Indent = true, Encoding = new System.Text.UTF8Encoding(false) };
    using var writer = XmlWriter.Create(path, settings);
    xml.Save(writer);
}
