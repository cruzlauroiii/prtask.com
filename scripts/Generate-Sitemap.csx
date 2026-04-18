#!/usr/bin/env dotnet-script
#nullable enable
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

var argsList = Args.ToList();
var wwwroot = GetRequiredArg(argsList, "--wwwroot");
var baseUrl = GetArgValue(argsList, "--base-url") ?? string.Empty;
var robotsFile = GetArgValue(argsList, "--robots-file");
var outputFile = GetArgValue(argsList, "--output-file");
var sourceFile = GetArgValue(argsList, "--source-file");
var updateSource = HasArg(argsList, "--update-source");

var normalizedWwwroot = Path.GetFullPath(wwwroot);
outputFile ??= Path.Combine(normalizedWwwroot, "sitemap.xml");

if (string.IsNullOrWhiteSpace(baseUrl) && string.IsNullOrWhiteSpace(robotsFile))
{
    robotsFile = Path.Combine(normalizedWwwroot, "robots.txt");
}

if (string.IsNullOrWhiteSpace(baseUrl) && !string.IsNullOrWhiteSpace(robotsFile) && File.Exists(robotsFile))
{
    foreach (var line in File.ReadLines(robotsFile))
    {
        var match = Regex.Match(line, @"^\s*Sitemap:\s*(\S+)", RegexOptions.IgnoreCase);
        if (!match.Success)
        {
            continue;
        }

        var candidate = match.Groups[1].Value;
        if (!candidate.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
            !candidate.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
        {
            continue;
        }

        baseUrl = candidate.EndsWith("/sitemap.xml", StringComparison.OrdinalIgnoreCase)
            ? candidate[..^"/sitemap.xml".Length]
            : candidate.TrimEnd('/');
        break;
    }
}

if (baseUrl.EndsWith("/", StringComparison.Ordinal))
{
    baseUrl = baseUrl.TrimEnd('/');
}

if (string.IsNullOrWhiteSpace(baseUrl))
{
    baseUrl = "https://prtask.com";
}

var excludedDirs = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
{
    "_content",
    "_framework"
};
var hashPattern = new Regex(@"\.[a-z0-9]{6,}\.html$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
var paths = new HashSet<string>(StringComparer.Ordinal);

foreach (var page in Directory.EnumerateFiles(normalizedWwwroot, "*.html", SearchOption.AllDirectories))
{
    var relative = Path.GetRelativePath(normalizedWwwroot, page);
    var segments = relative.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
    if (segments.Any(excludedDirs.Contains))
    {
        continue;
    }

    if (hashPattern.IsMatch(relative) ||
        relative.EndsWith("404.html", StringComparison.OrdinalIgnoreCase))
    {
        continue;
    }

    var urlPath = "/" + relative.Replace('\\', '/');
    if (urlPath.EndsWith(".html", StringComparison.OrdinalIgnoreCase))
    {
        urlPath = urlPath[..^5];
    }

    if (urlPath.EndsWith("/index", StringComparison.OrdinalIgnoreCase))
    {
        urlPath = urlPath[..^6];
    }

    if (string.IsNullOrEmpty(urlPath) || string.Equals(urlPath, "/index", StringComparison.OrdinalIgnoreCase))
    {
        urlPath = "/";
    }

    paths.Add(urlPath);
}

var orderedPaths = paths.OrderBy(path => path, StringComparer.Ordinal).ToList();
if (orderedPaths.Remove("/"))
{
    orderedPaths.Insert(0, "/");
}

Directory.CreateDirectory(Path.GetDirectoryName(outputFile)!);
var settings = new XmlWriterSettings
{
    Encoding = new UTF8Encoding(false),
    Indent = true
};

using (var writer = XmlWriter.Create(outputFile, settings))
{
    writer.WriteStartDocument();
    writer.WriteStartElement("urlset", "http://www.sitemaps.org/schemas/sitemap/0.9");

    foreach (var path in orderedPaths)
    {
        writer.WriteStartElement("url");
        writer.WriteElementString("loc", FormatLocation(path, baseUrl));
        writer.WriteEndElement();
    }

    writer.WriteEndElement();
    writer.WriteEndDocument();
}

if (updateSource && !string.IsNullOrWhiteSpace(sourceFile))
{
    Directory.CreateDirectory(Path.GetDirectoryName(sourceFile)!);
    File.Copy(outputFile, sourceFile, overwrite: true);
}

static string FormatLocation(string path, string baseUrl)
{
    return string.IsNullOrWhiteSpace(baseUrl)
        ? path == "/" ? "./" : "./" + path.TrimStart('/')
        : baseUrl + path;
}

static string GetRequiredArg(IReadOnlyList<string> args, string name)
{
    return GetArgValue(args, name)
        ?? throw new Exception($"Missing required argument: {name}");
}

static string? GetArgValue(IReadOnlyList<string> args, string name)
{
    for (var i = 0; i < args.Count - 1; i++)
    {
        if (string.Equals(args[i], name, StringComparison.OrdinalIgnoreCase))
        {
            return args[i + 1];
        }
    }

    return null;
}

static bool HasArg(IReadOnlyList<string> args, string name) =>
    args.Any(arg => string.Equals(arg, name, StringComparison.OrdinalIgnoreCase));
