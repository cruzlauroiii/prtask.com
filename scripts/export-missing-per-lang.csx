#!/usr/bin/env dotnet-script
// Exports missing keys per language to JSON files for manual/AI translation
using System.Xml;
using System.Text.Json;

var resxDir = @"C:\work\prtask.com\src\PrTask.SharedUI\Resources";
var outDir = @"C:\work\prtask.com\scripts\missing-translations";
Directory.CreateDirectory(outDir);

var enMap = LoadResx(Path.Combine(resxDir, "SharedResource.resx"));
var zhMap = LoadResx(Path.Combine(resxDir, "SharedResource.zh.resx"));

var translatedKeys = zhMap.Keys
    .Where(k => enMap.ContainsKey(k) && zhMap[k] != enMap[k])
    .ToList();

var langs = new[] { "ar","de","es","fil","fr","hi","id","it","ja","ko","nl","pt","ru","tr" };

foreach (var lang in langs)
{
    var langMap = LoadResx(Path.Combine(resxDir, $"SharedResource.{lang}.resx"));
    var missing = translatedKeys
        .Where(k => !langMap.ContainsKey(k) || langMap[k] == enMap[k])
        .ToDictionary(k => k, k => enMap[k]);

    var json = JsonSerializer.Serialize(missing, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText(Path.Combine(outDir, $"{lang}.json"), json);
    Console.WriteLine($"{lang}: {missing.Count} missing -> {lang}.json");
}

static Dictionary<string, string> LoadResx(string path)
{
    var xml = new XmlDocument(); xml.Load(path);
    var map = new Dictionary<string, string>();
    foreach (XmlNode node in xml.SelectNodes("/root/data")!)
    {
        var name = node.Attributes?["name"]?.Value;
        var value = node.SelectSingleNode("value")?.InnerText;
        if (name != null && value != null) map[name] = value;
    }
    return map;
}
