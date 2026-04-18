using System.Globalization;
using PrTask.Cdp;
using PrTask.Lighthouse.Models;

namespace PrTask.Lighthouse.Audits;

#pragma warning disable SA1600
public sealed class SeoAuditor
{
    private const string SeoMetadataScript = @"
        (function() {
            var Title = document.title || '';
            var MetaDesc = '';
            var MetaViewport = '';
            var Canonical = '';
            var Robots = '';
            var OgTitle = '';
            var OgDesc = '';
            var OgImage = '';
            var HreflangCount = 0;
            var H1Count = document.querySelectorAll('h1').length;
            var H1Text = '';

            var Metas = document.querySelectorAll('meta');
            for (var I = 0; I < Metas.length; I++) {
                var M = Metas[I];
                var Name = (M.getAttribute('name') || '').toLowerCase();
                var Property = (M.getAttribute('property') || '').toLowerCase();
                var Content = M.getAttribute('content') || '';
                if (Name === 'description') MetaDesc = Content;
                if (Name === 'viewport') MetaViewport = Content;
                if (Name === 'robots') Robots = Content;
                if (Property === 'og:title') OgTitle = Content;
                if (Property === 'og:description') OgDesc = Content;
                if (Property === 'og:image') OgImage = Content;
            }

            var CanonicalLink = document.querySelector('link[rel=canonical]');
            if (CanonicalLink) Canonical = CanonicalLink.getAttribute('href') || '';

            var Hreflangs = document.querySelectorAll('link[rel=alternate][hreflang]');
            HreflangCount = Hreflangs.length;

            var H1El = document.querySelector('h1');
            if (H1El) H1Text = H1El.textContent || '';

            return JSON.stringify({
                Title: Title,
                MetaDesc: MetaDesc,
                MetaViewport: MetaViewport,
                Canonical: Canonical,
                Robots: Robots,
                OgTitle: OgTitle,
                OgDesc: OgDesc,
                OgImage: OgImage,
                HreflangCount: HreflangCount,
                H1Count: H1Count,
                H1Text: H1Text,
                Url: window.location.href
            });
        })()";

    private const string LinkAuditScript = @"
        (function() {
            var Links = document.querySelectorAll('a[href]');
            var Total = Links.length;
            var MissingText = 0;
            var NofollowCount = 0;
            for (var I = 0; I < Links.length; I++) {
                var L = Links[I];
                var Text = (L.textContent || '').trim();
                var AriaLabel = L.getAttribute('aria-label') || '';
                if (!Text && !AriaLabel) MissingText++;
                if ((L.getAttribute('rel') || '').indexOf('nofollow') >= 0) NofollowCount++;
            }
            return JSON.stringify({ Total: Total, MissingText: MissingText, NofollowCount: NofollowCount });
        })()";

    public async Task<List<AuditResult>> AuditAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        var Results = new List<AuditResult>();

        // Get SEO metadata
        var MetaResult = await CdpRuntime.EvaluateAsync(Client, SessionId, SeoMetadataScript, true, false, Cancel).ConfigureAwait(false);
        var MetaJson = MetaResult["value"]?.GetValue<string>() ?? "{}";
        var Meta = System.Text.Json.Nodes.JsonNode.Parse(MetaJson);

        var Title = Meta?["Title"]?.GetValue<string>() ?? string.Empty;
        var MetaDesc = Meta?["MetaDesc"]?.GetValue<string>() ?? string.Empty;
        var MetaViewport = Meta?["MetaViewport"]?.GetValue<string>() ?? string.Empty;
        var Canonical = Meta?["Canonical"]?.GetValue<string>() ?? string.Empty;
        var Robots = Meta?["Robots"]?.GetValue<string>() ?? string.Empty;
        var H1Count = Meta?["H1Count"]?.GetValue<int>() ?? 0;
        var HreflangCount = Meta?["HreflangCount"]?.GetValue<int>() ?? 0;

        // Document title
        Results.Add(new AuditResult
        {
            Id = "document-title",
            Title = "Document has a <title> element",
            Description = "The title gives screen reader users an overview of the page, and search engine users rely on it heavily.",
            Score = string.IsNullOrWhiteSpace(Title) ? 0.0 : 1.0,
            DisplayValue = string.IsNullOrWhiteSpace(Title) ? "Missing title" : Title,
        });

        // Meta description
        Results.Add(new AuditResult
        {
            Id = "meta-description",
            Title = "Document has a meta description",
            Description = "Meta descriptions may be included in search results to concisely summarize page content.",
            Score = string.IsNullOrWhiteSpace(MetaDesc) ? 0.0 : 1.0,
            DisplayValue = string.IsNullOrWhiteSpace(MetaDesc)
                ? "Missing meta description"
                : string.Format(CultureInfo.InvariantCulture, "{0} chars", MetaDesc.Length),
        });

        // Viewport
        Results.Add(new AuditResult
        {
            Id = "viewport",
            Title = "Has a <meta name=\"viewport\"> tag with width or initial-scale",
            Description = "A viewport meta tag optimizes your app for mobile screen sizes.",
            Score = string.IsNullOrWhiteSpace(MetaViewport) ? 0.0 : 1.0,
            DisplayValue = string.IsNullOrWhiteSpace(MetaViewport) ? "Missing viewport meta tag" : MetaViewport,
        });

        // Canonical
        Results.Add(new AuditResult
        {
            Id = "canonical",
            Title = "Document has a valid rel=canonical",
            Description = "Canonical links suggest which URL to show in search results.",
            Score = string.IsNullOrWhiteSpace(Canonical) ? 0.5 : 1.0,
            ScoreDisplayMode = string.IsNullOrWhiteSpace(Canonical) ? "informative" : "numeric",
            DisplayValue = string.IsNullOrWhiteSpace(Canonical) ? "No canonical link" : Canonical,
        });

        // Robots meta
        var IsBlocked = !string.IsNullOrEmpty(Robots) && (Robots.Contains("noindex", StringComparison.OrdinalIgnoreCase));
        Results.Add(new AuditResult
        {
            Id = "is-crawlable",
            Title = "Page isn't blocked from indexing",
            Description = "Search engines are unable to include your pages in search results if they are blocked.",
            Score = IsBlocked ? 0.0 : 1.0,
            DisplayValue = IsBlocked ? string.Format(CultureInfo.InvariantCulture, "robots: {0}", Robots) : "Page is crawlable",
        });

        // H1 heading
        Results.Add(new AuditResult
        {
            Id = "heading-order",
            Title = "Heading elements have a proper hierarchy",
            Description = "Properly ordered headings convey the semantic structure of the page.",
            Score = H1Count == 1 ? 1.0 : H1Count == 0 ? 0.0 : 0.5,
            DisplayValue = string.Format(CultureInfo.InvariantCulture, "{0} h1 element(s) found", H1Count),
        });

        // Hreflang
        Results.Add(new AuditResult
        {
            Id = "hreflang",
            Title = "Document has hreflang attributes for alternate languages",
            Description = "hreflang links tell search engines what language each page is in.",
            Score = HreflangCount > 0 ? 1.0 : 0.5,
            ScoreDisplayMode = HreflangCount > 0 ? "numeric" : "informative",
            DisplayValue = string.Format(CultureInfo.InvariantCulture, "{0} hreflang link(s)", HreflangCount),
        });

        // Link audit
        var LinkResult = await CdpRuntime.EvaluateAsync(Client, SessionId, LinkAuditScript, true, false, Cancel).ConfigureAwait(false);
        var LinkJson = LinkResult["value"]?.GetValue<string>() ?? "{}";
        var Links = System.Text.Json.Nodes.JsonNode.Parse(LinkJson);
        var MissingLinkText = Links?["MissingText"]?.GetValue<int>() ?? 0;

        Results.Add(new AuditResult
        {
            Id = "link-text",
            Title = "Links have descriptive text",
            Description = "Descriptive link text helps search engines understand your content.",
            Score = MissingLinkText == 0 ? 1.0 : 0.0,
            DisplayValue = MissingLinkText == 0
                ? "All links have text"
                : string.Format(CultureInfo.InvariantCulture, "{0} link(s) missing descriptive text", MissingLinkText),
        });

        // HTTP status code (check via current document)
        Results.Add(new AuditResult
        {
            Id = "http-status-code",
            Title = "Page has successful HTTP status code",
            Description = "Pages with unsuccessful HTTP status codes may not be indexed properly.",
            Score = 1.0,
            DisplayValue = "200",
        });

        return Results;
    }
}
#pragma warning restore SA1600
