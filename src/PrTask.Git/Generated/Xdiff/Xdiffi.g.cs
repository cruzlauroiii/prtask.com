namespace PrTask.Git.Generated;

internal static partial class Xdiffi
{
    internal static nuint GetHash(nint Xdf, long Index)
        => default;

    internal const int XDL_MAX_COST_MIN = 256;
    internal const int XDL_HEUR_MIN_COST = 256;
    internal const int XDL_SNAKE_CNT = 20;
    internal const int XDL_K_HEUR = 4;
    internal static int RecsMatch(nint Rec1, nint Rec2)
        => default;

    internal const int MAX_INDENT = 200;
    internal static int GetIndent(nint Rec)
        => default;

    internal const int MAX_BLANKS = 20;
    internal const int START_OF_FILE_PENALTY = 1;
    internal const int END_OF_FILE_PENALTY = 21;
    internal const int POST_BLANK_WEIGHT = 6;
    internal const int RELATIVE_INDENT_WITH_BLANK_PENALTY = 10;
    internal const int RELATIVE_OUTDENT_PENALTY = 24;
    internal const int RELATIVE_OUTDENT_WITH_BLANK_PENALTY = 17;
    internal const int RELATIVE_DEDENT_PENALTY = 23;
    internal const int RELATIVE_DEDENT_WITH_BLANK_PENALTY = 17;
    internal const int INDENT_WEIGHT = 60;
    internal const int INDENT_HEURISTIC_MAX_SLIDING = 100;
    internal static void ScoreAddSplit(nint M, nint S)
    {
    }

    internal static int ScoreCmp(nint S1, nint S2)
        => default;

    internal static void GroupInit(nint Xdf, nint G)
    {
    }

    internal static int GroupNext(nint Xdf, nint G)
        => default;

    internal static int GroupPrevious(nint Xdf, nint G)
        => default;

    internal static int GroupSlideDown(nint Xdf, nint G)
        => default;

    internal static int GroupSlideUp(nint Xdf, nint G)
        => default;

    internal static int XdlChangeCompact(nint Xdf, nint Xdfo, long Flags)
        => default;

    internal static int XdlBuildScript(nint Xe, nint Xscr)
        => default;

    internal static void XdlFreeScript(nint Xscr)
    {
    }

    internal static void XdlMarkIgnorableLines(nint Xscr, nint Xe, long Flags)
    {
    }

    internal static int RecordMatchesRegex(nint Rec, nint Xpp)
        => default;

}
