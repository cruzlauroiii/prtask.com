using System.Text.RegularExpressions;
namespace PrTask.E2E;
public static partial class DeployHelper
{
    [GeneratedRegex(@">\s+<")]
    private static partial Regex HtmlWhitespaceRegex();

    [GeneratedRegex(@"\s{2,}")]
    private static partial Regex MultiSpaceRegex();

    [GeneratedRegex(@"<!--(?!\[).*?-->", RegexOptions.Singleline)]
    private static partial Regex HtmlCommentRegex();

    private static void ReplaceNavLinksWithFingerprinted(string DeployDir)
    {
        var ManifestPath = Path.Combine(DeployDir, HtmlManifestFile);
        if (!File.Exists(ManifestPath))
        {
            return;
        }

        var Manifest = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(
            File.ReadAllText(ManifestPath));
        if (Manifest is null)
        {
            return;
        }

        foreach (var HtmlFile in Directory.EnumerateFiles(DeployDir, "*.html", SearchOption.AllDirectories))
        {
            var Content = File.ReadAllText(HtmlFile);
            var Changed = false;
            foreach (var (RouteKey, FpName) in Manifest)
            {
                var OldHref = $"href=\"{RouteKey}\"";
                var NewHref = $"href=\"{FpName}\"";
                if (Content.Contains(OldHref))
                {
                    Content = Content.Replace(OldHref, NewHref);
                    Changed = true;
                }
            }

            if (Changed)
            {
                File.WriteAllText(HtmlFile, Content);
            }
        }
    }

    private static void ReplaceNavLinksWithFingerprinted(string DeployDir)
    {
        var ManifestPath = Path.Combine(DeployDir, HtmlManifestFile);
        if (!File.Exists(ManifestPath))
        {
            return;
        }

        var Manifest = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(
            File.ReadAllText(ManifestPath));
        if (Manifest is null)
        {
            return;
        }

        foreach (var HtmlFile in Directory.EnumerateFiles(DeployDir, "*.html", SearchOption.AllDirectories))
        {
            var Content = File.ReadAllText(HtmlFile);
            var Changed = false;
            foreach (var (RouteKey, FpName) in Manifest)
            {
                var OldHref = $"href=\"{RouteKey}\"";
                var NewHref = $"href=\"{FpName}\"";
                if (Content.Contains(OldHref))
                {
                    Content = Content.Replace(OldHref, NewHref);
                    Changed = true;
                }
            }

            if (Changed)
            {
                File.WriteAllText(HtmlFile, Content);
            }
        }
    }

    private static void ReplaceNavLinksWithFingerprinted(string DeployDir)
    {
        var ManifestPath = Path.Combine(DeployDir, HtmlManifestFile);
        if (!File.Exists(ManifestPath))
        {
            return;
        }

        var Manifest = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(
            File.ReadAllText(ManifestPath));
        if (Manifest is null)
        {
            return;
        }

        foreach (var HtmlFile in Directory.EnumerateFiles(DeployDir, "*.html", SearchOption.AllDirectories))
        {
            var Content = File.ReadAllText(HtmlFile);
            var Changed = false;
            foreach (var (RouteKey, FpName) in Manifest)
            {
                var OldHref = $"href=\"{RouteKey}\"";
                var NewHref = $"href=\"{FpName}\"";
                if (Content.Contains(OldHref))
                {
                    Content = Content.Replace(OldHref, NewHref);
                    Changed = true;
                }
            }

            if (Changed)
            {
                File.WriteAllText(HtmlFile, Content);
            }
        }
    }

    private static void ReplaceNavLinksWithFingerprinted(string DeployDir)
    {
        var ManifestPath = Path.Combine(DeployDir, HtmlManifestFile);
        if (!File.Exists(ManifestPath))
        {
            return;
        }

        var Manifest = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(
            File.ReadAllText(ManifestPath));
        if (Manifest is null)
        {
            return;
        }

        foreach (var HtmlFile in Directory.EnumerateFiles(DeployDir, "*.html", SearchOption.AllDirectories))
        {
            var Content = File.ReadAllText(HtmlFile);
            var Changed = false;
            foreach (var (RouteKey, FpName) in Manifest)
            {
                var OldHref = $"href=\"{RouteKey}\"";
                var NewHref = $"href=\"{FpName}\"";
                if (Content.Contains(OldHref))
                {
                    Content = Content.Replace(OldHref, NewHref);
                    Changed = true;
                }
            }

            if (Changed)
            {
                File.WriteAllText(HtmlFile, Content);
            }
        }
    }

    private static void ReplaceNavLinksWithFingerprinted(string DeployDir)
    {
        var ManifestPath = Path.Combine(DeployDir, HtmlManifestFile);
        if (!File.Exists(ManifestPath))
        {
            return;
        }

        var Manifest = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(
            File.ReadAllText(ManifestPath));
        if (Manifest is null)
        {
            return;
        }

        foreach (var HtmlFile in Directory.EnumerateFiles(DeployDir, "*.html", SearchOption.AllDirectories))
        {
            var Content = File.ReadAllText(HtmlFile);
            var Changed = false;
            foreach (var (RouteKey, FpName) in Manifest)
            {
                var OldHref = $"href=\"{RouteKey}\"";
                var NewHref = $"href=\"{FpName}\"";
                if (Content.Contains(OldHref))
                {
                    Content = Content.Replace(OldHref, NewHref);
                    Changed = true;
                }
            }

            if (Changed)
            {
                File.WriteAllText(HtmlFile, Content);
            }
        }
    }

    private static void MinifyAllHtml(string DeployDir)
    {
        foreach (var HtmlFile in GetAllHtml(DeployDir))
        {
            var Content = File.ReadAllText(HtmlFile);
            Content = HtmlCommentRegex().Replace(Content, string.Empty);
            Content = HtmlWhitespaceRegex().Replace(Content, "><");
            Content = MultiSpaceRegex().Replace(Content, " ");
            Content = Content
                .Replace("\r\n", string.Empty)
                .Replace("\n", string.Empty)
                .Trim();
            File.WriteAllText(HtmlFile, Content);
        }
    }
}
