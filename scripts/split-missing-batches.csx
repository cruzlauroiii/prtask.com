#!/usr/bin/env dotnet-script
// Splits each language's missing-translations JSON into batches of 100 keys
using System.Text.Json;

var inDir  = @"C:\work\prtask.com\scripts\missing-translations";
var outDir = @"C:\work\prtask.com\scripts\missing-translations\batches";
Directory.CreateDirectory(outDir);

var langs = new[] { "ar","de","es","fil","fr","hi","id","it","ja","ko","nl","pt","ru","tr" };
const int batchSize = 100;

foreach (var lang in langs)
{
    var json = File.ReadAllText(Path.Combine(inDir, $"{lang}.json"));
    var all = JsonSerializer.Deserialize<Dictionary<string,string>>(json)!;
    var keys = all.Keys.ToList();
    int batchNum = 0;
    for (int i = 0; i < keys.Count; i += batchSize)
    {
        batchNum++;
        var batch = keys.Skip(i).Take(batchSize).ToDictionary(k => k, k => all[k]);
        var batchJson = JsonSerializer.Serialize(batch, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(Path.Combine(outDir, $"{lang}-{batchNum:D2}.json"), batchJson);
    }
    Console.WriteLine($"{lang}: {keys.Count} keys -> {batchNum} batches");
}
