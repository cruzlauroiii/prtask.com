#!/usr/bin/env dotnet-script
// Usage: dotnet-script apply-lang-batches.csx <lang>
// Merges all <lang>-NN-done.json batch files and patches the resx
using System.Xml;
using System.Text.Json;

var lang = Args.FirstOrDefault() ?? throw new Exception("Pass language code as argument");
var batchDir = @"C:\work\prtask.com\scripts\missing-translations\batches";
var resxPath = $@"C:\work\prtask.com\src\PrTask.SharedUI\Resources\SharedResource.{lang}.resx";

// Merge all done batches
var merged = new Dictionary<string, string>();
var batches = Directory.GetFiles(batchDir, $"{lang}-*-done.json").OrderBy(f => f).ToList();
if (batches.Count == 0) { Console.WriteLine($"No done batches found for {lang}"); return; }

foreach (var batchFile in batches)
{
    var json = File.ReadAllText(batchFile);
    var batch = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
    if (batch == null) { Console.WriteLine($"  WARN: failed to parse {Path.GetFileName(batchFile)}"); continue; }
    foreach (var (k, v) in batch) merged[k] = v;
    Console.WriteLine($"  Loaded {Path.GetFileName(batchFile)}: {batch.Count} keys");
}

Console.WriteLine($"Total merged: {merged.Count} keys");

// Patch resx
var xml = new XmlDocument(); xml.Load(resxPath);
var existing = new Dictionary<string, XmlNode>();
foreach (XmlNode n in xml.SelectNodes("/root/data")!)
{
    var name = n.Attributes?["name"]?.Value;
    if (name != null) existing[name] = n;
}
var root = xml.SelectSingleNode("/root")!;
int added = 0, updated = 0;
foreach (var (key, value) in merged)
{
    if (existing.TryGetValue(key, out var node))
    {
        var v = node.SelectSingleNode("value"); if (v != null) { v.InnerText = value; updated++; }
    }
    else
    {
        var newNode = xml.CreateElement("data");
        var na = xml.CreateAttribute("name"); na.Value = key; newNode.Attributes!.Append(na);
        var sa = xml.CreateAttribute("xml:space"); sa.Value = "preserve"; newNode.Attributes!.Append(sa);
        var ve = xml.CreateElement("value"); ve.InnerText = value; newNode.AppendChild(ve);
        root.AppendChild(newNode);
        added++;
    }
}
var settings = new XmlWriterSettings { Indent = true, Encoding = new System.Text.UTF8Encoding(false) };
using (var writer = XmlWriter.Create(resxPath, settings)) { xml.Save(writer); }
Console.WriteLine($"[{lang}] Saved: {updated} updated, {added} added");
