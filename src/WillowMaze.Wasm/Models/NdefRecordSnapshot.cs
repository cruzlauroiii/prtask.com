using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WillowMaze.Wasm.Models;

public sealed record NdefRecordSnapshot(
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
