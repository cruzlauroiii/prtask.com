namespace PrTask.Git.Generated;

internal static partial class AddPatch
{
    internal enum PromptModeType
    {
        PROMPT_MODE_CHANGE = 0, PROMPT_DELETION, PROMPT_ADDITION, PROMPT_HUNK,
        PROMPT_MODE_MAX,
    }
    internal static void AddPStateClear(nint S)
    {
    }

    internal static void Err(nint S, string Fmt, params object[] VarArgs)
    {
    }

    internal static int ParseHunkHeader(nint S, nint Hunk)
        => default;

    internal static int IsOctal(string P, nuint Len)
        => default;

    internal static void CompleteFile(byte Marker, nint Hunk)
    {
    }

    internal static int NormalizeMarker(string P)
        => default;

    internal static int ParseDiff(nint S, nint Ps)
        => default;

    internal static nuint FindNextLine(nint Sb, nuint Offset)
        => default;

    internal static void RecolorHunk(nint S, nint Hunk)
    {
    }

    internal static int EditHunkManually(nint S, nint Hunk)
        => default;

    internal static int ReadSingleCharacter(nint S)
        => default;

    internal static int PromptYesno(nint S, string Prompt)
        => default;

    internal const int SUMMARY_HEADER_WIDTH = 20;
    internal const int SUMMARY_LINE_WIDTH = 80;
    internal const int DISPLAY_HUNKS_LINES = 20;
    internal static void ApplyPatch(nint S, nint FileDiff)
    {
    }

    internal static nuint DecMod(nuint A, nuint M)
        => default;

    internal static nuint IncMod(nuint A, nuint M)
        => default;

    internal static bool GetFirstUndecided(nint FileDiff, nint Idx)
        => default;

    internal static nuint PatchUpdateFile(nint S, nuint Idx)
        => default;

}
