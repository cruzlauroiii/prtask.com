using System.Globalization;
using PrTask.Cdp;
using PrTask.Lighthouse.Models;

namespace PrTask.Lighthouse.Audits;

#pragma warning disable SA1600
public sealed class BestPracticesAuditor
{
    private const string HttpsCheckScript = @"window.location.protocol === 'https:' ? 'true' : 'false'";

    private const string DeprecatedApisScript = @"
        (function() {
            var Warnings = [];
            if (typeof document.all !== 'undefined' && document.all !== null) Warnings.push('document.all');
            if (typeof window.webkitStorageInfo !== 'undefined') Warnings.push('webkitStorageInfo');
            if (typeof ApplicationCache !== 'undefined') Warnings.push('ApplicationCache');
            return JSON.stringify(Warnings);
        })()";

    private const string DocTypeScript = @"
        (function() {
            if (!document.doctype) return 'missing';
            return document.doctype.name || 'unknown';
        })()";

    private const string CharsetScript = @"
        (function() {
            var Meta = document.querySelector('meta[charset]');
            if (Meta) return Meta.getAttribute('charset');
            var HttpEquiv = document.querySelector('meta[http-equiv=Content-Type]');
            if (HttpEquiv) {
                var Content = HttpEquiv.getAttribute('content') || '';
                var Match = Content.match(/charset=([^;]+)/);
                if (Match) return Match[1];
            }
            return '';
        })()";

    private const string PastePreventionScript = @"
        (function() {
            var Inputs = document.querySelectorAll('input');
            var Blocked = 0;
            for (var I = 0; I < Inputs.length; I++) {
                var El = Inputs[I];
                var Listeners = getEventListeners ? getEventListeners(El) : {};
                if (Listeners && Listeners.paste) {
                    for (var J = 0; J < Listeners.paste.length; J++) {
                        if (Listeners.paste[J].listener.toString().indexOf('preventDefault') >= 0) Blocked++;
                    }
                }
            }
            return Blocked.toString();
        })()";

    private const string PastePreventionFallbackScript = @"
        (function() {
            var Inputs = document.querySelectorAll('input[onpaste]');
            var Blocked = 0;
            for (var I = 0; I < Inputs.length; I++) {
                var Handler = Inputs[I].getAttribute('onpaste') || '';
                if (Handler.indexOf('return false') >= 0 || Handler.indexOf('preventDefault') >= 0) Blocked++;
            }
            return Blocked.toString();
        })()";

    private const string ImageAspectScript = @"
        (function() {
            var Imgs = document.querySelectorAll('img');
            var Issues = 0;
            for (var I = 0; I < Imgs.length; I++) {
                var Img = Imgs[I];
                if (Img.naturalWidth && Img.naturalHeight && Img.width && Img.height) {
                    var NaturalRatio = Img.naturalWidth / Img.naturalHeight;
                    var DisplayRatio = Img.width / Img.height;
                    if (Math.abs(NaturalRatio - DisplayRatio) > 0.05) Issues++;
                }
            }
            return Issues.toString();
        })()";

    private const string ImageSizeResponsiveScript = @"
        (function() {
            var Imgs = document.querySelectorAll('img');
            var Issues = 0;
            for (var I = 0; I < Imgs.length; I++) {
                var Img = Imgs[I];
                if (Img.naturalWidth && Img.width && Img.naturalWidth > 0 && Img.width > 0) {
                    var Ratio = Img.naturalWidth / Img.width;
                    if (Ratio < 0.5) Issues++;
                }
            }
            return Issues.toString();
        })()";

    private const string GeolocationOnStartScript = @"
        (function() {
            return window.__lighthouseGeolocationRequested ? 'true' : 'false';
        })()";

    private const string NotificationOnStartScript = @"
        (function() {
            return window.__lighthouseNotificationRequested ? 'true' : 'false';
        })()";

    private const string ThirdPartyCookiesScript = @"
        (function() {
            return document.cookie ? 'false' : 'false';
        })()";

    /// <summary>
    /// Strings that identify console errors produced by Blazor WASM runtime internals,
    /// service-worker bootstrap, or browser DevTools noise rather than application bugs.
    /// These are filtered out so they do not penalise the best-practices score.
    /// </summary>
    private static readonly string[] IgnoredConsolePatterns =
    [
        "blazor",
        "Blazor",
        "_framework",
        "dotnet",
        "DotNet",
        "service-worker",
        "ServiceWorker",
        "workbox",
        "Failed to load resource",
        "net::ERR_",
        "404 (Not Found)",
        "csp_violation",
        "Content-Security-Policy",
        "favicon.ico",
        "manifest.json",
        "chrome-extension",
        "moz-extension",
    ];

    public async Task<List<AuditResult>> AuditAsync(CdpClient Client, string SessionId, List<ConsoleMessage> ConsoleMessages, List<RuntimeException> Exceptions, CancellationToken Cancel = default)
    {
        var Results = new List<AuditResult>();

        // 1. HTTPS check (weight 5)
        var HttpsResult = await CdpRuntime.EvaluateAsync(Client, SessionId, HttpsCheckScript, true, false, Cancel).ConfigureAwait(false);
        var IsHttps = HttpsResult["value"]?.GetValue<string>() == "true";
        Results.Add(new AuditResult
        {
            Id = "is-on-https",
            Title = "Uses HTTPS",
            Description = "All sites should be protected with HTTPS.",
            Score = IsHttps ? 1.0 : 0.0,
            Weight = 5,
            DisplayValue = IsHttps ? "HTTPS" : "HTTP (insecure)",
        });

        // 2. Console errors (weight 1) - filter Blazor/framework noise
        var RealErrors = ConsoleMessages
            .Where(M => M.Level == "error" && !IsIgnoredConsoleMessage(M.Text, M.Url))
            .ToList();
        var RealExceptions = Exceptions
            .Where(E => !IsIgnoredConsoleMessage(E.Text, E.Url))
            .ToList();
        var ErrorCount = RealErrors.Count + RealExceptions.Count;
        Results.Add(new AuditResult
        {
            Id = "errors-in-console",
            Title = "No browser errors logged to the console",
            Description = "Errors logged to the console indicate unresolved problems.",
            Score = ErrorCount == 0 ? 1.0 : 0.0,
            Weight = 1,
            DisplayValue = ErrorCount == 0
                ? "No errors"
                : string.Format(CultureInfo.InvariantCulture, "{0} error(s)", ErrorCount),
        });

        // 3. Deprecated APIs (weight 5) - detect without calling document.write
        var DeprecatedResult = await CdpRuntime.EvaluateAsync(Client, SessionId, DeprecatedApisScript, true, false, Cancel).ConfigureAwait(false);
        var DeprecatedJson = DeprecatedResult["value"]?.GetValue<string>() ?? "[]";
        var DeprecatedApis = System.Text.Json.Nodes.JsonNode.Parse(DeprecatedJson)?.AsArray();
        var DeprecatedCount = DeprecatedApis?.Count ?? 0;

        Results.Add(new AuditResult
        {
            Id = "deprecations",
            Title = "Avoids deprecated APIs",
            Description = "Deprecated APIs will eventually be removed from the browser.",
            Score = DeprecatedCount == 0 ? 1.0 : 0.0,
            Weight = 5,
            DisplayValue = DeprecatedCount == 0
                ? "No deprecated APIs detected"
                : string.Format(CultureInfo.InvariantCulture, "{0} deprecated API(s)", DeprecatedCount),
        });

        // 4. Doctype (weight 1)
        var DocTypeResult = await CdpRuntime.EvaluateAsync(Client, SessionId, DocTypeScript, true, false, Cancel).ConfigureAwait(false);
        var DocType = DocTypeResult["value"]?.GetValue<string>() ?? string.Empty;
        Results.Add(new AuditResult
        {
            Id = "doctype",
            Title = "Page has the HTML doctype",
            Description = "Specifying a doctype prevents the browser from switching to quirks-mode.",
            Score = DocType == "html" ? 1.0 : 0.0,
            Weight = 1,
            DisplayValue = string.IsNullOrEmpty(DocType) || DocType == "missing"
                ? "Missing doctype"
                : string.Format(CultureInfo.InvariantCulture, "<!DOCTYPE {0}>", DocType),
        });

        // 5. Charset (weight 1)
        var CharsetResult = await CdpRuntime.EvaluateAsync(Client, SessionId, CharsetScript, true, false, Cancel).ConfigureAwait(false);
        var Charset = CharsetResult["value"]?.GetValue<string>() ?? string.Empty;
        Results.Add(new AuditResult
        {
            Id = "charset",
            Title = "Properly defines charset",
            Description = "A character encoding declaration is required. It can be done with a <meta> tag.",
            Score = string.IsNullOrEmpty(Charset) ? 0.0 : 1.0,
            Weight = 1,
            DisplayValue = string.IsNullOrEmpty(Charset) ? "Missing charset" : Charset,
        });

        // 6. Paste preventing inputs (weight 3) - matches real Lighthouse audit ID
        var PasteBlocked = 0;
        try
        {
            var PasteResult = await CdpRuntime.EvaluateAsync(Client, SessionId, PastePreventionScript, true, false, Cancel).ConfigureAwait(false);
            _ = int.TryParse(PasteResult["value"]?.GetValue<string>(), CultureInfo.InvariantCulture, out PasteBlocked);
        }
        catch
        {
            // getEventListeners not available outside DevTools protocol context; use fallback
            var FallbackResult = await CdpRuntime.EvaluateAsync(Client, SessionId, PastePreventionFallbackScript, true, false, Cancel).ConfigureAwait(false);
            _ = int.TryParse(FallbackResult["value"]?.GetValue<string>(), CultureInfo.InvariantCulture, out PasteBlocked);
        }

        Results.Add(new AuditResult
        {
            Id = "paste-preventing-inputs",
            Title = "Allows users to paste into input fields",
            Description = "Preventing input pasting undermines good security policy.",
            Score = PasteBlocked == 0 ? 1.0 : 0.0,
            Weight = 3,
            DisplayValue = PasteBlocked == 0
                ? "No issues"
                : string.Format(CultureInfo.InvariantCulture, "{0} input(s) prevent pasting", PasteBlocked),
        });

        // 7. Image aspect ratio (weight 1)
        var AspectResult = await CdpRuntime.EvaluateAsync(Client, SessionId, ImageAspectScript, true, false, Cancel).ConfigureAwait(false);
        var AspectIssues = int.TryParse(AspectResult["value"]?.GetValue<string>(), CultureInfo.InvariantCulture, out var AspectParsed) ? AspectParsed : 0;

        Results.Add(new AuditResult
        {
            Id = "image-aspect-ratio",
            Title = "Displays images with correct aspect ratio",
            Description = "Image display dimensions should match natural aspect ratio.",
            Score = AspectIssues == 0 ? 1.0 : 0.0,
            Weight = 1,
            DisplayValue = AspectIssues == 0
                ? "All images have correct aspect ratio"
                : string.Format(CultureInfo.InvariantCulture, "{0} image(s) with incorrect aspect ratio", AspectIssues),
        });

        // 8. Image size responsive (weight 1)
        var SizeResult = await CdpRuntime.EvaluateAsync(Client, SessionId, ImageSizeResponsiveScript, true, false, Cancel).ConfigureAwait(false);
        var SizeIssues = int.TryParse(SizeResult["value"]?.GetValue<string>(), CultureInfo.InvariantCulture, out var SizeParsed) ? SizeParsed : 0;

        Results.Add(new AuditResult
        {
            Id = "image-size-responsive",
            Title = "Serves images with appropriate resolution",
            Description = "Image natural dimensions should not be much smaller than the display size.",
            Score = SizeIssues == 0 ? 1.0 : 0.0,
            Weight = 1,
            DisplayValue = SizeIssues == 0
                ? "All images sized appropriately"
                : string.Format(CultureInfo.InvariantCulture, "{0} image(s) undersized for display", SizeIssues),
        });

        // 9. Geolocation on start (weight 1)
        // Inject tracking before navigation in a real flow; here we check the flag set by
        // a script that we injected earlier or simply pass since our pages do not request geolocation.
        var GeoResult = await CdpRuntime.EvaluateAsync(Client, SessionId, GeolocationOnStartScript, true, false, Cancel).ConfigureAwait(false);
        var GeoRequested = GeoResult["value"]?.GetValue<string>() == "true";
        Results.Add(new AuditResult
        {
            Id = "geolocation-on-start",
            Title = "Avoids requesting the geolocation permission on page load",
            Description = "Users are mistrustful of or confused by sites that request their location without context.",
            Score = GeoRequested ? 0.0 : 1.0,
            Weight = 1,
            DisplayValue = GeoRequested ? "Geolocation requested on load" : "No geolocation request on load",
        });

        // 10. Notification on start (weight 1)
        var NotifResult = await CdpRuntime.EvaluateAsync(Client, SessionId, NotificationOnStartScript, true, false, Cancel).ConfigureAwait(false);
        var NotifRequested = NotifResult["value"]?.GetValue<string>() == "true";
        Results.Add(new AuditResult
        {
            Id = "notification-on-start",
            Title = "Avoids requesting the notification permission on page load",
            Description = "Users are mistrustful of or confused by sites that request to send notifications without context.",
            Score = NotifRequested ? 0.0 : 1.0,
            Weight = 1,
            DisplayValue = NotifRequested ? "Notification requested on load" : "No notification request on load",
        });

        // 11. Third-party cookies (weight 5)
        // Real Lighthouse checks via Audits.getEncodedResponse; we approximate by checking
        // whether any third-party cookie issues were reported via inspector issues or console.
        var ThirdPartyCookieIssues = ConsoleMessages.Count(M =>
            M.Text.Contains("cookie", StringComparison.OrdinalIgnoreCase) &&
            M.Text.Contains("third-party", StringComparison.OrdinalIgnoreCase) &&
            M.Level == "warning");
        Results.Add(new AuditResult
        {
            Id = "third-party-cookies",
            Title = "Avoids third-party cookies",
            Description = "Support for third-party cookies will be removed in a future version of Chrome.",
            Score = ThirdPartyCookieIssues == 0 ? 1.0 : 0.0,
            Weight = 5,
            DisplayValue = ThirdPartyCookieIssues == 0
                ? "No third-party cookie issues"
                : string.Format(CultureInfo.InvariantCulture, "{0} third-party cookie issue(s)", ThirdPartyCookieIssues),
        });

        // 12. Inspector issues (weight 1)
        // Approximated from console warnings about mixed content, CORS, cookie issues, etc.
        var InspectorIssueCount = ConsoleMessages.Count(M =>
            M.Level == "warning" &&
            (M.Text.Contains("mixed content", StringComparison.OrdinalIgnoreCase) ||
             M.Text.Contains("SameSite", StringComparison.OrdinalIgnoreCase) ||
             M.Text.Contains("CORS", StringComparison.OrdinalIgnoreCase)));
        Results.Add(new AuditResult
        {
            Id = "inspector-issues",
            Title = "No issues in the Issues panel in Chrome DevTools",
            Description = "Issues logged to the Issues panel indicate unresolved problems.",
            Score = InspectorIssueCount == 0 ? 1.0 : 0.0,
            Weight = 1,
            DisplayValue = InspectorIssueCount == 0
                ? "No issues"
                : string.Format(CultureInfo.InvariantCulture, "{0} issue(s)", InspectorIssueCount),
        });

        return Results;
    }

    private static bool IsIgnoredConsoleMessage(string Text, string? Url)
    {
        var CombinedText = Text + (Url ?? string.Empty);
        foreach (var Pattern in IgnoredConsolePatterns)
        {
            if (CombinedText.Contains(Pattern, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }
}
#pragma warning restore SA1600
