using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WillowMaze.Wasm.Models;

public sealed record MifareClassicBlockDump(
    int BlockIndex,
    string DataHex,
    string Plaintext,
    string BlockType);
