using System.Text.Json;
using System.Text.RegularExpressions;
using PrTask.Domain.Constants;

namespace PrTask.Fingerprint;

public static partial class EndpointsReader
{
    [GeneratedRegex(FingerprintConstants.AlreadyFingerprintedPattern)]
    private static partial Regex AlreadyFingerprintedRegex();

    public static IDictionary<string, string> ReadHtmlMap(string EndpointsPath)
    {
        var JsonText = File.ReadAllText(EndpointsPath);
        var Document = JsonDocument.Parse(JsonText);
        var Endpoints = Document.RootElement.GetProperty(FingerprintConstants.EndpointsProperty);
        var Map = new Dictionary<string, string>();

        foreach (var Endpoint in Endpoints.EnumerateArray())
        {
            var Route = Endpoint.GetProperty(FingerprintConstants.RouteProperty).GetString()!;
            var AssetFile = Endpoint.GetProperty(FingerprintConstants.AssetFileProperty).GetString()!;

            if (Route == AssetFile)
            {
                continue;
            }

            if (Route.EndsWith(FingerprintConstants.GzExtension, StringComparison.Ordinal))
            {
                continue;
            }

            if (Route.EndsWith(FingerprintConstants.BrExtension, StringComparison.Ordinal))
            {
                continue;
            }

            if (AlreadyFingerprintedRegex().IsMatch(AssetFile))
            {
                continue;
            }

            if (Route.EndsWith(FingerprintConstants.HtmlExtension, StringComparison.Ordinal)
                || Route.EndsWith(FingerprintConstants.CssExtension, StringComparison.Ordinal)
                || Route.EndsWith(FingerprintConstants.IcoExtension, StringComparison.Ordinal)
                || Route.EndsWith(FingerprintConstants.PngExtension, StringComparison.Ordinal))
            {
                Map[AssetFile] = Route;
            }
        }

        return Map;
    }
}
