using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

var argsList = Environment.GetCommandLineArgs().Skip(1).ToList();
if (argsList.Count == 0)
{
    Console.Error.WriteLine("Usage: dotnet script scripts/extract-resx-values.csx Key1 [Key2 ...]");
    return;
}

var baseDir = Path.Combine(Directory.GetCurrentDirectory(), "src", "PrTask.SharedUI", "Resources");
var files = new Dictionary<string, string>
{
    ["en"] = Path.Combine(baseDir, "SharedResource.resx"),
    ["zh"] = Path.Combine(baseDir, "SharedResource.zh.resx")
};

var docs = files.ToDictionary(
    kvp => kvp.Key,
    kvp => XDocument.Load(kvp.Value));

foreach (var key in argsList)
{
    Console.WriteLine($"[{key}]");
    foreach (var lang in new[] { "en", "zh" })
    {
        var value = docs[lang]
            .Root
            ?.Elements("data")
            .FirstOrDefault(x => string.Equals((string)x.Attribute("name"), key, StringComparison.Ordinal))
            ?.Element("value")
            ?.Value;
        Console.WriteLine($"{lang}: {value ?? "<missing>"}");
    }

    Console.WriteLine();
}
