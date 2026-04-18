#!/usr/bin/env dotnet-script
#nullable enable
using System.Text.Json;
using System.Xml;

if (Args.Count != 2)
{
    throw new Exception("Usage: dotnet-script scripts/Apply-I18n-Locale-To-Resx.csx <lang> <locale-json-path>");
}

var lang = Args[0];
var localeJsonPath = Path.GetFullPath(Args[1]);
var repoRoot = @"C:\work\prtask.com";
var resxPath = Path.Combine(repoRoot, "src", "PrTask.SharedUI", "Resources", $"SharedResource.{lang}.resx");

if (!File.Exists(localeJsonPath))
{
    throw new FileNotFoundException("Missing locale json", localeJsonPath);
}

if (!File.Exists(resxPath))
{
    throw new FileNotFoundException("Missing target resx", resxPath);
}

var translations = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(localeJsonPath))
    ?? throw new Exception("Failed to parse locale json.");

var xml = new XmlDocument();
xml.Load(resxPath);

var nodes = xml.SelectNodes("/root/data")!
    .Cast<XmlNode>()
    .Where(node => node.Attributes?["name"] != null)
    .ToDictionary(node => node.Attributes!["name"]!.Value, StringComparer.Ordinal);

var updated = 0;
foreach (var (key, value) in translations)
{
    if (string.IsNullOrWhiteSpace(value))
    {
        continue;
    }

    if (!nodes.TryGetValue(key, out var node))
    {
        continue;
    }

    var valueNode = node.SelectSingleNode("value");
    if (valueNode == null)
    {
        continue;
    }

    valueNode.InnerText = value;
    updated++;
}

var settings = new XmlWriterSettings
{
    Indent = true,
    Encoding = new System.Text.UTF8Encoding(false)
};

using (var writer = XmlWriter.Create(resxPath, settings))
{
    xml.Save(writer);
}

Console.WriteLine($"[{lang}] Applied {updated} locale entries from {Path.GetFileName(localeJsonPath)}");
