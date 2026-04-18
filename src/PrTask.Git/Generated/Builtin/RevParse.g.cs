namespace PrTask.Git.Generated;

internal static partial class RevParse
{
    internal const int DO_REVS = 1;
    internal const int DO_NOREV = 2;
    internal const int DO_FLAGS = 4;
    internal const int DO_NONFLAGS = 8;
    internal const int NORMAL = 0;
    internal const int REVERSED = 1;
    internal const int SHOW_SYMBOLIC_ASIS = 1;
    internal const int SHOW_SYMBOLIC_FULL = 2;
    internal static int IsRevArgument(string Arg)
        => default;

    internal static void Show(string Arg)
    {
    }

    internal static void ShowWithType(int Type, string Arg)
    {
    }

    internal static void ShowRev(int Type, nint Oid, string Name)
    {
    }

    internal static int ShowFlag(string Arg)
        => default;

    internal static int ShowDefault()
        => default;

    internal static int ShowReference(nint Ref, nint UNUSED)
        => default;

    internal static int AntiReference(nint Ref, nint UNUSED)
        => default;

    internal static int ShowAbbrev(nint Oid, nint UNUSED)
        => default;

    internal static void ShowDatestring(string Flag, string Datestr)
    {
    }

    internal static int ShowFile(string Arg, int OutputPrefix)
        => default;

    internal static int TryDifference(string Arg)
        => default;

    internal static int TryParentShorthands(string Arg)
        => default;

    internal static int ParseoptDump(nint O, string Arg, int Unset)
        => default;

    internal static int CmdParseopt(int Argc, string Argv, string Prefix)
        => default;

    internal static int CmdSqQuote(int Argc, string Argv)
        => default;

    internal static void DieNoSingleRev(int Quiet)
    {
    }

    internal static int OptWithValue(string Arg, string Opt, string Value)
        => default;

    internal static void HandleRefOpt(string Pattern, string Prefix)
    {
    }

    internal enum FormatType
    {
        FORMAT_RELATIVE,
        FORMAT_CANONICAL,
        FORMAT_DEFAULT,
    }
    internal enum DefaultType
    {
        DEFAULT_RELATIVE,
        DEFAULT_RELATIVE_IF_SHARED,
        DEFAULT_CANONICAL,
        DEFAULT_UNMODIFIED,
    }
    internal static void PrintPath(string Path, string Prefix, FormatType Format, DefaultType Def)
    {
    }

}
