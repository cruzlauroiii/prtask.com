using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WillowMaze.Wasm.Decompiled;

public sealed record TransactionResultEventArgs(
    string TransactionId,
    string Status);
