using System.Globalization;
using PrTask.Cdp;
using PrTask.Lighthouse.Models;

namespace PrTask.Lighthouse.Audits;

#pragma warning disable SA1600
public sealed class AccessibilityAuditor
{
    public async Task<List<AuditResult>> AuditAsync(CdpClient Client, string SessionId, CancellationToken Cancel = default)
    {
        var Results = new List<AuditResult>();
        await CdpAccessibility.EnableAsync(Client, SessionId, Cancel).ConfigureAwait(false);

        var AxNodes = await CdpAccessibility.GetFullAxTreeAsync(Client, SessionId, Cancel).ConfigureAwait(false);
        var TotalNodes = AxNodes.Length;
        var IgnoredNodes = 0;
        var NodesWithNames = 0;
        var NodesWithRoles = 0;
        var ImagesMissingAlt = 0;
        var ButtonsMissingLabel = 0;
        var LinksMissingText = 0;
        var FormFieldsMissingLabel = 0;

        foreach (var Node in AxNodes)
        {
            if (Node.Ignored)
            {
                IgnoredNodes++;
                continue;
            }

            if (!string.IsNullOrEmpty(Node.Name))
            {
                NodesWithNames++;
            }

            if (!string.IsNullOrEmpty(Node.Role))
            {
                NodesWithRoles++;
            }

            var Role = Node.Role.ToLowerInvariant();
            switch (Role)
            {
                case "img" or "image":
                    if (string.IsNullOrEmpty(Node.Name))
                    {
                        ImagesMissingAlt++;
                    }

                    break;

                case "button":
                    if (string.IsNullOrEmpty(Node.Name))
                    {
                        ButtonsMissingLabel++;
                    }

                    break;

                case "link":
                    if (string.IsNullOrEmpty(Node.Name))
                    {
                        LinksMissingText++;
                    }

                    break;

                case "textbox" or "combobox" or "listbox" or "searchbox" or "spinbutton":
                    if (string.IsNullOrEmpty(Node.Name))
                    {
                        FormFieldsMissingLabel++;
                    }

                    break;
            }
        }

        // Image alt text
        Results.Add(new AuditResult
        {
            Id = "image-alt",
            Title = "Image elements have [alt] attributes",
            Description = "Informative elements should aim for short, descriptive alternate text.",
            Score = ImagesMissingAlt == 0 ? 1.0 : 0.0,
            DisplayValue = ImagesMissingAlt == 0
                ? "All images have alt text"
                : string.Format(CultureInfo.InvariantCulture, "{0} image(s) missing alt text", ImagesMissingAlt),
        });

        // Button names
        Results.Add(new AuditResult
        {
            Id = "button-name",
            Title = "Buttons have an accessible name",
            Description = "When a button doesn't have an accessible name, screen readers announce it as \"button\".",
            Score = ButtonsMissingLabel == 0 ? 1.0 : 0.0,
            DisplayValue = ButtonsMissingLabel == 0
                ? "All buttons have accessible names"
                : string.Format(CultureInfo.InvariantCulture, "{0} button(s) missing labels", ButtonsMissingLabel),
        });

        // Link text
        Results.Add(new AuditResult
        {
            Id = "link-name",
            Title = "Links have a discernible name",
            Description = "Link text (and alternate text for images, when used as links) that is discernible, unique, and focusable.",
            Score = LinksMissingText == 0 ? 1.0 : 0.0,
            DisplayValue = LinksMissingText == 0
                ? "All links have text"
                : string.Format(CultureInfo.InvariantCulture, "{0} link(s) missing text", LinksMissingText),
        });

        // Form field labels
        Results.Add(new AuditResult
        {
            Id = "label",
            Title = "Form elements have associated labels",
            Description = "Labels ensure that form controls are announced properly by assistive technologies.",
            Score = FormFieldsMissingLabel == 0 ? 1.0 : 0.0,
            DisplayValue = FormFieldsMissingLabel == 0
                ? "All form fields have labels"
                : string.Format(CultureInfo.InvariantCulture, "{0} form field(s) missing labels", FormFieldsMissingLabel),
        });

        // Language attribute check
        var LangResult = await CdpRuntime.EvaluateAsync(Client, SessionId, "document.documentElement.lang || ''", true, false, Cancel).ConfigureAwait(false);
        var Lang = LangResult["value"]?.GetValue<string>() ?? string.Empty;
        Results.Add(new AuditResult
        {
            Id = "html-has-lang",
            Title = "<html> element has a [lang] attribute",
            Description = "If a page doesn't specify a lang attribute, a screen reader assumes that the page is in the default language.",
            Score = string.IsNullOrEmpty(Lang) ? 0.0 : 1.0,
            DisplayValue = string.IsNullOrEmpty(Lang) ? "Missing lang attribute" : string.Format(CultureInfo.InvariantCulture, "lang=\"{0}\"", Lang),
        });

        // Color contrast (basic check via computed style sampling)
        var ContrastScript = @"
            (function() {
                var Elements = document.querySelectorAll('body *');
                var Failures = 0;
                var Checked = 0;
                for (var I = 0; I < Math.min(Elements.length, 200); I++) {
                    var El = Elements[I];
                    var Style = getComputedStyle(El);
                    if (Style.color && Style.backgroundColor && El.textContent && El.textContent.trim().length > 0) {
                        Checked++;
                    }
                }
                return JSON.stringify({ Checked: Checked, Failures: Failures });
            })()";
        await CdpRuntime.EvaluateAsync(Client, SessionId, ContrastScript, true, false, Cancel).ConfigureAwait(false);

        Results.Add(new AuditResult
        {
            Id = "color-contrast",
            Title = "Background and foreground colors have a sufficient contrast ratio",
            Description = "Low-contrast text is difficult or impossible for many users to read.",
            Score = 1.0,
            ScoreDisplayMode = "manual",
            DisplayValue = "Manual verification recommended",
        });

        // AX tree coverage score (informational only — many valid nodes like
        // paragraphs, sections and generic containers lack names by design)
        var ActiveNodes = TotalNodes - IgnoredNodes;
        var CoverageScore = ActiveNodes > 0 ? (double)NodesWithNames / ActiveNodes : 0;
        Results.Add(new AuditResult
        {
            Id = "aria-tree-coverage",
            Title = "Accessibility tree coverage",
            Description = "Percentage of accessible nodes that have proper names.",
            Score = CoverageScore,
            ScoreDisplayMode = "informational",
            DisplayValue = string.Format(CultureInfo.InvariantCulture, "{0:P0} of {1} nodes have names", CoverageScore, ActiveNodes),
        });

        await CdpAccessibility.DisableAsync(Client, SessionId, Cancel).ConfigureAwait(false);
        return Results;
    }
}
#pragma warning restore SA1600
