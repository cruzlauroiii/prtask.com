#!/usr/bin/env dotnet-script
#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

var repoRoot = @"C:\work\prtask.com";
var resxDir = Path.Combine(repoRoot, "src", "PrTask.SharedUI", "Resources");
var enMap = LoadResx(Path.Combine(resxDir, "SharedResource.resx"));
var zhMap = LoadResx(Path.Combine(resxDir, "SharedResource.zh.resx"));
var languages = new[] { "ar", "de", "es", "fil", "fr", "hi", "id", "it", "ja", "ko", "nl", "pt", "ru", "tr" };
var languageMaps = languages.ToDictionary(lang => lang, lang => LoadResx(Path.Combine(resxDir, $"SharedResource.{lang}.resx")));

var rows = new List<(int Count, string Key, string Missing, string English)>();
foreach (var key in zhMap.Keys.OrderBy(k => k, StringComparer.Ordinal))
{
    if (!enMap.TryGetValue(key, out var enValue))
    {
        continue;
    }

    var zhValue = zhMap[key];
    if (zhValue == enValue || !HasMeaningfulEnglish(enValue))
    {
        continue;
    }

    var missingLangs = languages
        .Where(lang => !languageMaps[lang].TryGetValue(key, out var langValue) || langValue == enValue)
        .ToArray();

    if (missingLangs.Length > 0)
    {
        rows.Add((missingLangs.Length, key, string.Join(",", missingLangs), Clip(enValue)));
    }
}

foreach (var row in rows.OrderBy(r => r.Count).ThenBy(r => r.Key, StringComparer.Ordinal).Take(120))
{
    Console.WriteLine($"{row.Count}\t{row.Key}\t[{row.Missing}]\t{row.English}");
}

static Dictionary<string, string> LoadResx(string path)
{
    var xml = new XmlDocument();
    xml.Load(path);
    var map = new Dictionary<string, string>(StringComparer.Ordinal);
    foreach (XmlNode node in xml.SelectNodes("/root/data")!)
    {
        var name = node.Attributes?["name"]?.Value;
        var value = node.SelectSingleNode("value")?.InnerText;
        if (name != null && value != null)
        {
            map[name] = value;
        }
    }

    return map;
}

static bool HasMeaningfulEnglish(string text)
{
    var trimmed = text.Trim();
    if (trimmed.Length == 0 ||
        Regex.IsMatch(trimmed, @"^https?://", RegexOptions.CultureInvariant) ||
        Regex.IsMatch(trimmed, @"^[\w.+-]+@[\w.-]+\.\w+$", RegexOptions.CultureInvariant))
    {
        return false;
    }

    return Regex.Matches(trimmed, @"\b[A-Za-z]{3,}\b", RegexOptions.CultureInvariant).Count >= 2;
}

static string Clip(string value)
{
    var normalized = Regex.Replace(value, @"\s+", " ").Trim();
    return normalized.Length <= 90 ? normalized : normalized[..90];
}
