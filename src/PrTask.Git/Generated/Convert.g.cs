namespace PrTask.Git.Generated;

internal static partial class Convert
{
    internal const int CONVERT_STAT_BITS_TXT_LF = 0x1;
    internal const int CONVERT_STAT_BITS_TXT_CRLF = 0x2;
    internal const int CONVERT_STAT_BITS_BIN = 0x4;
    internal static void GatherStats(string Buf, Unlong Size, nint Stats)
    {
    }

    internal static int ConvertIsBinary(nint Stats)
        => default;

    internal static Unint GatherConvertStats(string Data, Unlong Size)
        => default;

    internal static int TextEolIsCrlf()
        => default;

    internal static Eol OutputEol(ConvertCrlfAction CrlfAction)
        => default;

    internal static int HasCrlfInIndex(nint Istate, string Path)
        => default;

    internal static int CheckRoundtrip(string EncName)
        => default;

    internal static int FilterBufferOrFd(Int in UNUSED, int Out, nint Data)
        => default;

    internal static int StartMultiFileFilterFn(nint Subprocess)
        => default;

    internal static int AsyncQueryAvailableBlobs(string Cmd, nint AvailablePaths)
        => default;

    internal static int CountIdent(string Cp, Unlong Size)
        => default;

    internal static ConvertCrlfAction GitPathCheckCrlf(nint Check)
        => default;

    internal static Eol GitPathCheckEol(nint Check)
        => default;

    internal static int GitPathCheckIdent(nint Check)
        => default;

    internal static void ResetParsedAttributes()
    {
    }

    internal static int WouldConvertToGitFilterFd(nint Istate, string Path)
        => default;

    internal static void NullFreeFn(nint UNUSED)
    {
    }

    internal static int IsNullStreamFilter(nint Filter)
        => default;

    internal static void LfToCrlfFreeFn(nint Filter)
    {
    }

    internal const int FILTER_BUFFER = 1024;
    internal static void CascadeFreeFn(nint Filter)
    {
    }

    internal static int IsForeignIdent(string Str)
        => default;

    internal static void IdentDrain(nint Ident, string OutputP, nint OsizeP)
    {
    }

    internal static void IdentFreeFn(nint Filter)
    {
    }

    internal static void FreeStreamFilter(nint Filter)
    {
    }

    internal static ConvAttrsClassification ClassifyConvAttrs(nint Ca)
        => default;

}
