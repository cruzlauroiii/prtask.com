namespace WillowMaze.App.Models;

internal sealed record NfcTagSnapshot(
    string Summary,
    string IdentifierHex,
    string CardType,
    string Manufacturer,
    IReadOnlyList<string> Technologies,
    IReadOnlyList<string> HeadlineFacts,
    IReadOnlyList<NdefRecordSnapshot> Records,
    IReadOnlyList<string> Details,
    IReadOnlyList<MifareClassicSectorDump> MifareClassicSectors,
    IReadOnlyList<MifareUltralightPageDump> MifareUltralightPages,
    string WriteOutcome,
    DateTimeOffset CapturedAtUtc);
