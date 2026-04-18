namespace WillowMaze.App.Models;

internal enum NdefPayloadKind
{
    Text,
    Uri,
    Mime,
    External,
    Aar,
    SmartPoster,
    Handover
}

internal sealed record NdefWriteDraft(
    NdefPayloadKind Kind,
    string Content,
    string MimeType,
    string ExternalDomain,
    string ExternalType,
    bool MakeReadOnly,
    DateTimeOffset ArmedAtUtc)
{
    public string Summary =>
        Kind switch
        {
            NdefPayloadKind.Text => $"text | {TrimForPreview(Content)}",
            NdefPayloadKind.Uri => $"uri | {TrimForPreview(Content)}",
            NdefPayloadKind.Mime => $"{NormalizeMimeType(MimeType)} | {TrimForPreview(Content)}",
            NdefPayloadKind.External => $"ext:{NormalizedExternalDomain}:{NormalizedExternalType} | {TrimForPreview(Content)}",
            NdefPayloadKind.Aar => $"aar | {TrimForPreview(Content)}",
            NdefPayloadKind.SmartPoster => $"sp | {TrimForPreview(Content)}",
            NdefPayloadKind.Handover => $"hs | {TrimForPreview(Content)}",
            _ => TrimForPreview(Content)
        };

    public string NormalizedMimeType => NormalizeMimeType(MimeType);

    public string NormalizedExternalDomain => string.IsNullOrWhiteSpace(ExternalDomain) ? "example.com" : ExternalDomain.Trim().ToLowerInvariant();

    public string NormalizedExternalType => string.IsNullOrWhiteSpace(ExternalType) ? "data" : ExternalType.Trim().ToLowerInvariant();

    private static string NormalizeMimeType(string mimeType)
    {
        return string.IsNullOrWhiteSpace(mimeType) ? "text/plain" : mimeType.Trim();
    }

    private static string TrimForPreview(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return "(empty)";
        }

        var trimmed = value.Trim();
        return trimmed.Length <= 64 ? trimmed : $"{trimmed[..61]}...";
    }
}
