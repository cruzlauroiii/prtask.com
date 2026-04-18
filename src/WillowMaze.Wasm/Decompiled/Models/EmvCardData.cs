using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WillowMaze.Wasm.Decompiled;

public sealed record EmvCardData(
    string Pan,
    string MaskedPan,
    string Last4,
    string Expiry,
    string CardholderName,
    string CardBrand,
    string AidHex,
    string AidLabel,
    string PpseResponseHex,
    string GpoResponseHex,
    List<string> RecordHexes,
    List<string> Log,
    bool Success,
    string Error);
