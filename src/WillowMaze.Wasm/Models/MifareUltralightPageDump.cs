using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WillowMaze.Wasm.Models;

public sealed record MifareUltralightPageDump(
    int PageIndex,
    string DataHex,
    string Plaintext,
    string PageType);
