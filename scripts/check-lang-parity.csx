#!/usr/bin/env dotnet-script
// Reports keys translated in zh but missing/untranslated in other languages.
// Usage: dotnet-script check-lang-parity.csx

using System.Xml;

var resxDir = @"C:\work\prtask.com\src\PrTask.SharedUI\Resources";

var enMap = LoadResx(Path.Combine(resxDir, "SharedResource.resx"));
var zhMap = LoadResx(Path.Combine(resxDir, "SharedResource.zh.resx"));

var langs = new[] { "ar","de","es","fil","fr","hi","id","it","ja","ko","nl","pt","ru","tr" };

var langMaps = langs.ToDictionary(l => l,
    l => LoadResx(Path.Combine(resxDir, $"SharedResource.{l}.resx")));

var results = new SortedDictionary<string, List<string>>();
foreach (var key in zhMap.Keys)
{
    if (!enMap.TryGetValue(key, out var enVal) || zhMap[key] == enVal) continue;
    var missingLangs = langs.Where(l =>
        !langMaps[l].ContainsKey(key) || langMaps[l][key] == enVal).ToList();
    if (missingLangs.Count > 0)
        results[key] = missingLangs;
}

Console.WriteLine($"Total keys needing translation in other langs: {results.Count}");

var allMissing   = results.Where(kv => kv.Value.Count == 14).ToList();
var partialMissing = results.Where(kv => kv.Value.Count < 14).ToList();

Console.WriteLine($"\n=== Missing in ALL 14 languages: {allMissing.Count} keys ===");
foreach (var (key, _) in allMissing)
    Console.WriteLine($"  {key} | EN: {enMap[key][..Math.Min(80, enMap[key].Length)]}");

Console.WriteLine($"\n=== Missing in SOME languages: {partialMissing.Count} keys ===");
foreach (var (key, missing) in partialMissing)
    Console.WriteLine($"  {key} [missing: {string.Join(",", missing)}]");

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
