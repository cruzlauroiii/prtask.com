using PrTask.Cdp;
using PrTask.Lighthouse.Audits;
using PrTask.Lighthouse.Models;

namespace PrTask.Lighthouse;

#pragma warning disable SA1600
public sealed class LighthouseAuditor
{
    private readonly PerformanceAuditor PerfAuditor = new();
    private readonly AccessibilityAuditor A11YAuditor = new();
    private readonly SeoAuditor SeoAuditorInstance = new();
    private readonly BestPracticesAuditor BpAuditor = new();

    public async Task<LighthouseReport> AuditAsync(CdpClient Client, string SessionId, string Url, CancellationToken Cancel = default)
    {
        var Report = new LighthouseReport
        {
            Url = Url,
            AuditedAt = DateTime.UtcNow,
        };

        // Enable console and runtime to collect errors during audit
        var ConsoleMessages = new List<ConsoleMessage>();
        var RuntimeExceptions = new List<RuntimeException>();

        CdpConsole.OnMessageAdded(Client, Msg => ConsoleMessages.Add(Msg));
        CdpConsole.OnRuntimeExceptionThrown(Client, Ex => RuntimeExceptions.Add(Ex));
        await CdpConsole.EnableAsync(Client, SessionId, Cancel).ConfigureAwait(false);
        await CdpRuntime.EnableAsync(Client, SessionId, Cancel).ConfigureAwait(false);

        // Performance audit
        var PerfResults = await PerfAuditor.AuditAsync(Client, SessionId, Cancel).ConfigureAwait(false);
        Report.Performance = new CategoryScore
        {
            Id = "performance",
            Title = "Performance",
            Score = CalculateCategoryScore(PerfResults),
            Audits = PerfResults,
        };

        // Accessibility audit
        var A11YResults = await A11YAuditor.AuditAsync(Client, SessionId, Cancel).ConfigureAwait(false);
        Report.Accessibility = new CategoryScore
        {
            Id = "accessibility",
            Title = "Accessibility",
            Score = CalculateCategoryScore(A11YResults),
            Audits = A11YResults,
        };

        // SEO audit
        var SeoResults = await SeoAuditorInstance.AuditAsync(Client, SessionId, Cancel).ConfigureAwait(false);
        Report.Seo = new CategoryScore
        {
            Id = "seo",
            Title = "SEO",
            Score = CalculateCategoryScore(SeoResults),
            Audits = SeoResults,
        };

        // Best practices audit
        var BpResults = await BpAuditor.AuditAsync(Client, SessionId, ConsoleMessages, RuntimeExceptions, Cancel).ConfigureAwait(false);
        Report.BestPractices = new CategoryScore
        {
            Id = "best-practices",
            Title = "Best Practices",
            Score = CalculateCategoryScore(BpResults),
            Audits = BpResults,
        };

        // Aggregate all audits
        Report.Audits.AddRange(PerfResults);
        Report.Audits.AddRange(A11YResults);
        Report.Audits.AddRange(SeoResults);
        Report.Audits.AddRange(BpResults);

        // Cleanup event handlers
        Client.Off("Console.messageAdded");
        Client.Off("Runtime.exceptionThrown");

        return Report;
    }

    public async Task<LighthouseReport> AuditUrlAsync(CdpBrowser Browser, string Url, CancellationToken Cancel = default)
    {
        await using var Page = await Browser.NewPageAsync(null, Cancel).ConfigureAwait(false);

        // Set viewport to standard desktop
        await Page.SetViewportAsync(1350, 940, 1.0, Cancel).ConfigureAwait(false);

        // Navigate and wait for load
        await Page.NavigateAsync(Url, Cancel).ConfigureAwait(false);
        await Page.WaitForLoadAsync(Cancel).ConfigureAwait(false);

        // Allow time for paint timing entries to settle
        await Task.Delay(2000, Cancel).ConfigureAwait(false);

        return await AuditAsync(Browser.Transport, Page.SessionId, Url, Cancel).ConfigureAwait(false);
    }

    private static double CalculateCategoryScore(List<AuditResult> Audits)
    {
        if (Audits.Count == 0)
        {
            return 0;
        }

        var NumericAudits = Audits.Where(A => A.ScoreDisplayMode == "numeric").ToList();
        if (NumericAudits.Count == 0)
        {
            return Audits.Average(A => A.Score);
        }

        return NumericAudits.Average(A => A.Score);
    }
}
#pragma warning restore SA1600
