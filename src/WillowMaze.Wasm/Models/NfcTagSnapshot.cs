using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WillowMaze.Wasm.Models;

public sealed record NfcTagSnapshot(
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
