namespace WillowMaze.App.Models;

internal sealed record MifareClassicSectorDump(
    int SectorIndex,
    int FirstBlock,
    string KeyUsed,
    IReadOnlyList<MifareClassicBlockDump> Blocks);

internal sealed record MifareClassicBlockDump(
    int BlockIndex,
    string DataHex,
    string Plaintext,
    string BlockType);
