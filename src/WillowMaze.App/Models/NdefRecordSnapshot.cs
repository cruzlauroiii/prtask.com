namespace WillowMaze.App.Models;

internal sealed record NdefRecordSnapshot(
    string Icon,
    string Kind,
    string Summary,
    string PayloadHex,
    string LanguageCode,
    string Encoding,
    string TypeHex,
    string IdHex,
    int Tnf,
    IReadOnlyList<NdefRecordSnapshot> SubRecords);
