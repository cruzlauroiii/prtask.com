using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WillowMaze.Wasm.Models;

public sealed record MifareClassicSectorDump(
    int SectorIndex,
    int FirstBlock,
    string KeyUsed,
    IReadOnlyList<MifareClassicBlockDump> Blocks);
