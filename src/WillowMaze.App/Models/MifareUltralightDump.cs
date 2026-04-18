namespace WillowMaze.App.Models;

internal sealed record MifareUltralightPageDump(
    int PageIndex,
    string DataHex,
    string Plaintext,
    string PageType);
