#!/usr/bin/env dotnet-script
#nullable enable
using System.Text;
using System.Text.Json;
using System.Xml;

if (Args.Count == 0)
{
    throw new Exception("Usage: dotnet-script apply-translation-json.csx <json-file>");
}

var jsonPath = Path.GetFullPath(Args[0]);
var repoRoot = @"C:\work\prtask.com";
var resxDir = Path.Combine(repoRoot, "src", "PrTask.SharedUI", "Resources");

var payload = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(
    File.ReadAllText(jsonPath))
    ?? throw new Exception("Failed to parse translation JSON.");

foreach (var (lang, entries) in payload)
{
    var resxPath = Path.Combine(resxDir, $"SharedResource.{lang}.resx");
    if (!File.Exists(resxPath))
    {
        throw new FileNotFoundException($"Missing resx for locale '{lang}'", resxPath);
    }

    var xml = new XmlDocument();
    xml.Load(resxPath);
    var nodes = xml.SelectNodes("/root/data")!
        .Cast<XmlNode>()
        .Where(node => node.Attributes?["name"] != null)
        .ToDictionary(node => node.Attributes!["name"]!.Value, StringComparer.Ordinal);

    foreach (var (key, value) in entries)
    {
        if (!nodes.TryGetValue(key, out var node))
        {
            node = xml.CreateElement("data");

            var nameAttribute = xml.CreateAttribute("name");
            nameAttribute.Value = key;
            node.Attributes!.Append(nameAttribute);

            var spaceAttribute = xml.CreateAttribute("xml", "space", "http://www.w3.org/XML/1998/namespace");
            spaceAttribute.Value = "preserve";
            node.Attributes.Append(spaceAttribute);

            var newValueNode = xml.CreateElement("value");
            node.AppendChild(newValueNode);
            xml.DocumentElement!.AppendChild(node);
            nodes[key] = node;
        }

        var valueNode = node.SelectSingleNode("value");
        if (valueNode != null)
        {
            valueNode.InnerText = value;
        }
    }

    var settings = new XmlWriterSettings
    {
        Indent = true,
        Encoding = new UTF8Encoding(false)
    };
    using var writer = XmlWriter.Create(resxPath, settings);
    xml.Save(writer);
}
