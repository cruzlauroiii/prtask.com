using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WillowMaze.Wasm.Models;

public sealed record NdefWriteDraft(
    NdefPayloadKind Kind,
    string Content,
    string MimeType,
    string ExternalDomain,
    string ExternalType,
    bool MakeReadOnly,
    DateTimeOffset ArmedAtUtc,
    string Summary,
    string NormalizedMimeType,
    string NormalizedExternalDomain,
    string NormalizedExternalType)
{
    private static string NormalizeMimeType(string mimeType)
    {
        // Decompiled from IL
        // Method: NormalizeMimeType IL size: 27 bytes
        // Strings: 1, Method calls: 1, Field refs: 0
        // String: "text/plain"
        // Calls: string.IsNullOrWhiteSpace
        return string.Empty;
    }

    private static string TrimForPreview(string value)
    {
        // Decompiled from IL
        // Method: TrimForPreview IL size: 64 bytes
        // Strings: 1, Method calls: 4, Field refs: 0
        // String: "..."
        // Calls: string.IsNullOrWhiteSpace
        // Calls: string.Trim
        // Calls: string.get_Length
        // Calls: string.Concat
        return string.Empty;
    }

}
