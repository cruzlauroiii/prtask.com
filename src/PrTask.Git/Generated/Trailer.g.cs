namespace PrTask.Git.Generated;

internal static partial class Trailer
{
    internal const string TRAILER_ARG_STRING = "$ARG";
    internal static int AfterOrEnd(TrailerWhere Where)
        => default;

    internal static nuint TokenLenWithoutSeparator(string Token, nuint Len)
        => default;

    internal static int SameToken(nint A, nint B)
        => default;

    internal static int SameValue(nint A, nint B)
        => default;

    internal static int SameTrailer(nint A, nint B)
        => default;

    internal static int IsBlankLine(string Str)
        => default;

    internal static void StrbufReplace(nint Sb, string A, string B)
    {
    }

    internal static void FreeTrailerItem(nint Item)
    {
    }

    internal static void FreeArgItem(nint Item)
    {
    }

    internal static byte LastNonSpaceChar(string S)
        => default;

    internal static void ApplyItemCommand(nint InTok, nint ArgTok)
    {
    }

    internal static int TrailerSetWhere(nint Item, string Value)
        => default;

    internal static int TrailerSetIfExists(nint Item, string Value)
        => default;

    internal static int TrailerSetIfMissing(nint Item, string Value)
        => default;

    internal static void DuplicateConf(nint Dst, nint Src)
    {
    }

    internal enum TrailerInfoType
    {
        TRAILER_WHERE, TRAILER_IF_EXISTS, TRAILER_IF_MISSING };,
        static struct {,
        const char *name;,
        enum trailer_info_type type;,
    }
    internal static void TrailerConfigInit()
    {
    }

    internal static int TokenMatchesItem(string Tok, nint Item, nuint TokLen)
        => default;

    internal static nint FindSeparator(string Line, string Separators)
        => default;

    internal static void ParseTrailersFromConfig(nint ConfigHead)
    {
    }

    internal static int ValidateTrailerArgs(nint CliArgs)
        => default;

    internal static nint LastLine(string Buf, nuint Len)
        => default;

    internal static nuint FindEndOfLogMessage(string Input, int NoDivider)
        => default;

    internal static nuint FindTrailerBlockStart(string Buf, nuint Len)
        => default;

    internal static int EndsWithBlankLine(string Buf, nuint Len)
        => default;

    internal static void UnfoldValue(nint Val)
    {
    }

    internal static void FreeTrailers(nint Trailers)
    {
    }

    internal static nuint TrailerBlockStart(nint TrailerBlock)
        => default;

    internal static nuint TrailerBlockEnd(nint TrailerBlock)
        => default;

    internal static int BlankLineBeforeTrailerBlock(nint TrailerBlock)
        => default;

    internal static void TrailerBlockRelease(nint TrailerBlock)
    {
    }

    internal static void TrailerIteratorInit(nint Iter, string Msg)
    {
    }

    internal static int TrailerIteratorAdvance(nint Iter)
        => default;

    internal static void TrailerIteratorRelease(nint Iter)
    {
    }

    internal static int WriteFileInPlace(string Path, nint Buf)
        => default;

}
