using System.Globalization;
using System.Text.Json.Nodes;
using PrTask.Cdp;
using PrTask.Lighthouse.Models;

namespace PrTask.Lighthouse.Audits;

#pragma warning disable SA1600
public sealed class PerformanceAuditor
{
    private const string PerformanceTimingScript = @"
        (function() {
            var Perf = performance.getEntriesByType('navigation')[0] || {};
            var Paint = performance.getEntriesByType('paint') || [];
            var Fcp = Paint.find(function(E) { return E.name === 'first-contentful-paint'; });
            var Lcp = null;
            try {
                var LcpEntries = performance.getEntriesByType('largest-contentful-paint');
                Lcp = LcpEntries.length > 0 ? LcpEntries[LcpEntries.length - 1] : null;
            } catch(e) {}
            return JSON.stringify({
                NavigationStart: Perf.startTime || 0,
                DomContentLoaded: Perf.domContentLoadedEventEnd || 0,
                LoadEvent: Perf.loadEventEnd || 0,
                DomInteractive: Perf.domInteractive || 0,
                ResponseStart: Perf.responseStart || 0,
                ResponseEnd: Perf.responseEnd || 0,
                Ttfb: Perf.responseStart || 0,
                Fcp: Fcp ? Fcp.startTime : 0,
                Lcp: Lcp ? Lcp.startTime : 0,
                TransferSize: Perf.transferSize || 0,
                EncodedBodySize: Perf.encodedBodySize || 0,
                DecodedBodySize: Perf.decodedBodySize || 0
            });
        })()";

    private const string ClsScript = @"
        new Promise(function(Resolve) {
            var ClsValue = 0;
            var SessionValue = 0;
            var SessionEntries = [];
            var Observer = new PerformanceObserver(function(List) {
                for (var Entry of List.getEntries()) {
                    if (!Entry.hadRecentInput) {
                        var FirstTs = SessionEntries.length > 0 ? SessionEntries[0].startTime : 0;
                        if (SessionEntries.length > 0 && Entry.startTime - SessionEntries[sessionEntries.length - 1].startTime < 1000 && Entry.startTime - FirstTs < 5000) {
                            SessionValue += Entry.value;
                        } else {
                            SessionValue = Entry.value;
                            SessionEntries = [];
                        }
                        SessionEntries.push(Entry);
                        ClsValue = Math.max(ClsValue, SessionValue);
                    }
                }
            });
            Observer.observe({ type: 'layout-shift', buffered: true });
            setTimeout(function() { Observer.disconnect(); Resolve(ClsValue.toString()); }, 3000);
        })";

    private const string TbtScript = @"
        (function() {
            var Entries = performance.getEntriesByType('longtask') || [];
            var Tbt = 0;
            for (var I = 0; I < Entries.length; I++) {
                var BlockingTime = Entries[I].duration - 50;
                if (BlockingTime > 0) Tbt += BlockingTime;
            }
            return Tbt.toString();
        })()";

    public async Task<List<AuditResult>> AuditAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        var Results = new List<AuditResult>();

        // Get performance timing metrics
        var TimingResult = await CdpRuntime.EvaluateAsync(Client, SessionId, PerformanceTimingScript, true, true, Cancel).ConfigureAwait(false);
        var TimingJson = TimingResult["value"]?.GetValue<string>() ?? "{}";
        var Timing = JsonNode.Parse(TimingJson);

        var Fcp = Timing?["Fcp"]?.GetValue<double>() ?? 0;
        var Lcp = Timing?["Lcp"]?.GetValue<double>() ?? 0;
        var Ttfb = Timing?["Ttfb"]?.GetValue<double>() ?? 0;
        var DomContentLoaded = Timing?["DomContentLoaded"]?.GetValue<double>() ?? 0;
        var LoadEvent = Timing?["LoadEvent"]?.GetValue<double>() ?? 0;
        var DomInteractive = Timing?["DomInteractive"]?.GetValue<double>() ?? 0;

        // FCP audit
        Results.Add(new AuditResult
        {
            Id = "first-contentful-paint",
            Title = "First Contentful Paint",
            Description = "First Contentful Paint marks the time at which the first text or image is painted.",
            Score = ScoreFcp(Fcp),
            DisplayValue = string.Format(CultureInfo.InvariantCulture, "{0:F1} s", Fcp / 1000.0),
        });

        // LCP audit
        Results.Add(new AuditResult
        {
            Id = "largest-contentful-paint",
            Title = "Largest Contentful Paint",
            Description = "Largest Contentful Paint marks the time at which the largest text or image is painted.",
            Score = ScoreLcp(Lcp),
            DisplayValue = string.Format(CultureInfo.InvariantCulture, "{0:F1} s", Lcp / 1000.0),
        });

        // TTFB audit
        Results.Add(new AuditResult
        {
            Id = "server-response-time",
            Title = "Initial server response time was short",
            Description = "Keep the server response time for the main document short because all other requests depend on it.",
            Score = Ttfb < 600 ? 1.0 : Ttfb < 1800 ? 0.5 : 0.0,
            DisplayValue = string.Format(CultureInfo.InvariantCulture, "Root document took {0:F0} ms", Ttfb),
        });

        // TBT audit
        var TbtResult = await CdpRuntime.EvaluateAsync(Client, SessionId, TbtScript, true, false, Cancel).ConfigureAwait(false);
        var TbtValue = double.TryParse(TbtResult["value"]?.GetValue<string>(), CultureInfo.InvariantCulture, out var TbtParsed) ? TbtParsed : 0;

        Results.Add(new AuditResult
        {
            Id = "total-blocking-time",
            Title = "Total Blocking Time",
            Description = "Sum of all time periods between FCP and Time to Interactive, when task length exceeded 50ms.",
            Score = TbtValue < 200 ? 1.0 : TbtValue < 600 ? 0.5 : 0.0,
            DisplayValue = string.Format(CultureInfo.InvariantCulture, "{0:F0} ms", TbtValue),
        });

        // CLS audit (async with timeout)
        try
        {
            var ClsResult = await CdpRuntime.EvaluateAsync(Client, SessionId, ClsScript, true, true, Cancel).ConfigureAwait(false);
            var ClsValue = double.TryParse(ClsResult["value"]?.GetValue<string>(), CultureInfo.InvariantCulture, out var ClsParsed) ? ClsParsed : 0;

            Results.Add(new AuditResult
            {
                Id = "cumulative-layout-shift",
                Title = "Cumulative Layout Shift",
                Description = "Cumulative Layout Shift measures the movement of visible elements within the viewport.",
                Score = ClsValue < 0.1 ? 1.0 : ClsValue < 0.25 ? 0.5 : 0.0,
                DisplayValue = string.Format(CultureInfo.InvariantCulture, "{0:F3}", ClsValue),
            });
        }
        catch
        {
            Results.Add(new AuditResult
            {
                Id = "cumulative-layout-shift",
                Title = "Cumulative Layout Shift",
                Description = "Could not measure CLS",
                Score = 0.5,
                DisplayValue = "N/A",
            });
        }

        // Speed Index (approximate from FCP and load)
        var Si = (Fcp + LoadEvent) / 2.0;
        Results.Add(new AuditResult
        {
            Id = "speed-index",
            Title = "Speed Index",
            Description = "Speed Index shows how quickly the contents of a page are visibly populated.",
            Score = Si < 3400 ? 1.0 : Si < 5800 ? 0.5 : 0.0,
            DisplayValue = string.Format(CultureInfo.InvariantCulture, "{0:F1} s", Si / 1000.0),
        });

        // DOM Interactive
        Results.Add(new AuditResult
        {
            Id = "interactive",
            Title = "Time to Interactive",
            Description = "Time to interactive is the amount of time it takes for the page to become fully interactive.",
            Score = DomInteractive < 3800 ? 1.0 : DomInteractive < 7300 ? 0.5 : 0.0,
            DisplayValue = string.Format(CultureInfo.InvariantCulture, "{0:F1} s", DomInteractive / 1000.0),
        });

        return Results;
    }

    private static double ScoreFcp(double Ms) => Ms switch
    {
        < 1800 => 1.0,
        < 3000 => 0.75,
        < 4500 => 0.5,
        _ => 0.0,
    };

    private static double ScoreLcp(double Ms) => Ms switch
    {
        < 2500 => 1.0,
        < 4000 => 0.5,
        _ => 0.0,
    };
}
#pragma warning restore SA1600
