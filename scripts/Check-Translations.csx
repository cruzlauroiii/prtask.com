#!/usr/bin/env dotnet-script
#nullable enable
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;

var argsList = Args.ToList();
var wwwroot = GetArgValue(argsList, "--wwwroot")
    ?? @"C:\work\prtask.com\src\PrTask.Client\bin\Release\net11.0\wwwroot";
var repoRoot = GetArgValue(argsList, "--repo-root")
    ?? @"C:\work\prtask.com";
var resxDir = Path.Combine(repoRoot, "src", "PrTask.SharedUI", "Resources");

var enPath = Path.Combine(resxDir, "SharedResource.resx");
var zhPath = Path.Combine(resxDir, "SharedResource.zh.resx");
var enMap = LoadResx(enPath);
var zhMap = LoadResx(zhPath);
var languages = new[]
{
    "ar", "de", "es", "fil", "fr", "hi", "id", "it", "ja", "ko", "nl", "pt", "ru", "tr"
};
var languageMaps = languages.ToDictionary(
    lang => lang,
    lang => LoadResx(Path.Combine(resxDir, $"SharedResource.{lang}.resx")));

var technicalWhitelist = new HashSet<string>(StringComparer.Ordinal)
{
    "macOS", "GitHub", "Google", "Okta", "Maya", "GCash", "MAUI", "Blazor",
    "APK", "EXE", "DMG", "x64", "ARM", "GDPR", "CCPA", "DMCA", "PCI", "DSS", "AMLA", "AMLC", "AML",
    "VAT", "BIR", "IRS", "DAC7", "OIDC", "PKCE", "OAuth", "API", "URL", "CDN", "RAM",
    "UTC", "GMT", "PDF", "CSV", "JSON", "XML", "HTTP", "HTTPS", "SQL", "NoSQL", "SDK", "IDE",
    "prtask.com", "prtask-session", "prtask-csrf", "prtask-cookie-consent", "prtask-language", "prtask-theme",
    "_ga", "_gid", "_gat", "fbp", "fbc", "RA", "W-9", "W-8BEN",
    "Cloudflare", "Stripe", "PayPal", "Maya Business", "Didit", "GrabPay", "QR Ph",
    "legal@prtask.com", "support@prtask.com", "abuse@prtask.com", "privacy@prtask.com",
    "accessibility@prtask.com", "compliance@prtask.com", "dmca@prtask.com", "dpo@prtask.com",
    "security@prtask.com", "ico.org.uk"
};

var missingZhKeys = new List<string>();
foreach (var key in enMap.Keys.OrderBy(k => k, StringComparer.Ordinal))
{
    var enValue = enMap[key];
    if (!zhMap.TryGetValue(key, out var zhValue) || zhValue == enValue)
    {
        if (HasMeaningfulEnglish(enValue))
        {
            missingZhKeys.Add($"  {key} = {enValue}");
        }
    }
}

var abbreviationPatterns = new (Regex Pattern, string Label)[]
{
    (NewRegex(@"(?<![A-Za-z\d])PR(?![A-Za-z\d])"), "PR -> 拉取请求"),
    (NewRegex(@"(?<![A-Za-z\d])PRs(?![A-Za-z\d])"), "PRs -> 拉取请求"),
    (NewRegex(@"(?<![A-Za-z\d])ID(?![A-Za-z\d])"), "ID -> 编号"),
    (NewRegex(@"(?<![A-Za-z\d])Epic(?![A-Za-z\d])"), "Epic -> 史诗"),
    (NewRegex(@"(?<![A-Za-z\d])Feature(?![A-Za-z\d])"), "Feature -> 功能"),
    (NewRegex(@"(?<![A-Za-z\d])Story(?![A-Za-z\d])"), "Story -> 用户故事"),
    (NewRegex(@"(?<![A-Za-z\d])Task(?![A-Za-z\d])"), "Task -> 任务"),
    (NewRegex(@"(?<![A-Za-z\d])Bug(?![A-Za-z\d])"), "Bug -> 漏洞"),
    (NewRegex(@"(?<![A-Za-z\d])Trivial(?![A-Za-z\d])"), "Trivial -> 极简"),
    (NewRegex(@"(?<![A-Za-z\d])Simple(?![A-Za-z\d])"), "Simple -> 简单"),
    (NewRegex(@"(?<![A-Za-z\d])Medium(?![A-Za-z\d])"), "Medium -> 中等"),
    (NewRegex(@"(?<![A-Za-z\d])Complex(?![A-Za-z\d])"), "Complex -> 复杂"),
    (NewRegex(@"(?<![A-Za-z\d])Expert(?![A-Za-z\d])"), "Expert -> 专家"),
    (NewRegex(@"(?<![A-Za-z\d])SSO(?![A-Za-z\d])"), "SSO -> 单点登录"),
    (NewRegex(@"(?<![A-Za-z\d])2FA(?![A-Za-z\d])"), "2FA -> 双因素认证"),
    (NewRegex(@"(?<![A-Za-z\d])KYC(?![A-Za-z\d@])"), "KYC -> 了解您的客户"),
    (NewRegex(@"(?<![A-Za-z\d])USD(?![A-Za-z\d])"), "USD -> 美元"),
};

var zhAcronymViolations = new List<string>();
foreach (var (key, zhValue) in zhMap.OrderBy(kv => kv.Key, StringComparer.Ordinal))
{
    foreach (var (pattern, label) in abbreviationPatterns)
    {
        if (pattern.IsMatch(zhValue))
        {
            zhAcronymViolations.Add($"  [{label}] {key} = {Clip(zhValue)}");
            break;
        }
    }
}

var htmlViolations = new List<string>();
var zhDir = Path.Combine(wwwroot, "zh");
if (Directory.Exists(zhDir))
{
    foreach (var htmlFile in Directory.EnumerateFiles(zhDir, "*.html", SearchOption.AllDirectories))
    {
        var name = Path.GetFileName(htmlFile);
        if (!Regex.IsMatch(name, @"\.[0-9a-f]{10,}\.", RegexOptions.CultureInvariant))
        {
            continue;
        }

        var content = WebUtility.HtmlDecode(File.ReadAllText(htmlFile));
        var withoutScript = Regex.Replace(content, @"(?si)<script[^>]*>.*?</script>", "");
        var withoutStyle = Regex.Replace(withoutScript, @"(?si)<style[^>]*>.*?</style>", "");
        var texts = Regex.Matches(withoutStyle, @"(?<=>)([^<]+)(?=<)")
            .Select(match => match.Groups[1].Value.Trim())
            .Where(value => value.Length > 0);

        foreach (var text in texts)
        {
            if (IsEnglishOnly(text, technicalWhitelist))
            {
                htmlViolations.Add($"  [{name}] {text}");
            }
        }
    }
}

var parityViolations = new List<string>();
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
        .Where(lang =>
        {
            var langMap = languageMaps[lang];
            return !langMap.TryGetValue(key, out var langValue) || langValue == enValue;
        })
        .ToArray();

    if (missingLangs.Length > 0)
    {
        parityViolations.Add($"  {key} [{string.Join(", ", missingLangs)}] = {Clip(enValue)}");
    }
}

var failed = false;
WriteSection("ERROR: Untranslated zh resource keys", missingZhKeys, ref failed);
WriteSection("ERROR: Acronyms left in zh resources", zhAcronymViolations, ref failed);
WriteSection("ERROR: English text in fingerprinted zh HTML", htmlViolations.Distinct(StringComparer.Ordinal).ToList(), ref failed);
WriteSection("ERROR: Missing translated counterparts for zh-translated keys", parityViolations, ref failed);

if (failed)
{
    Console.WriteLine();
    Console.WriteLine("Build failed: complete SharedUI translations before building.");
    Environment.Exit(1);
}

Console.WriteLine("Check-Translations: OK");

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

static bool IsEnglishOnly(string text, HashSet<string> whitelist)
{
    var trimmed = text.Trim();
    if (trimmed.Length == 0 || Regex.IsMatch(trimmed, @"[^\x00-\x7F]"))
    {
        return false;
    }

    if (Regex.IsMatch(trimmed, @"^https?://", RegexOptions.CultureInvariant) ||
        Regex.IsMatch(trimmed, @"^[\w.+-]+@[\w.-]+\.\w+$", RegexOptions.CultureInvariant) ||
        Regex.IsMatch(trimmed, @"^[\d\s\.,\-\+\$%/\(\)\[\]#\:;!?]+$", RegexOptions.CultureInvariant) ||
        whitelist.Contains(trimmed))
    {
        return false;
    }

    return Regex.IsMatch(trimmed, @"[A-Za-z]{2,}", RegexOptions.CultureInvariant);
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
    return value.Length <= 80 ? value : value[..80];
}

static Regex NewRegex(string pattern) => new(pattern, RegexOptions.CultureInvariant);

static void WriteSection(string title, List<string> lines, ref bool failed)
{
    if (lines.Count == 0)
    {
        return;
    }

    Console.WriteLine();
    Console.WriteLine($"{title} ({lines.Count}):");
    foreach (var line in lines)
    {
        Console.WriteLine(line);
    }

    failed = true;
}
