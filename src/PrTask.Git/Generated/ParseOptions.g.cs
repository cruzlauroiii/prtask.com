namespace PrTask.Git.Generated;

internal static partial class ParseOptions
{
    internal enum OptParsed
    {
        OPT_LONG  = 0,
        OPT_SHORT = 1<<0,
        OPT_UNSET = 1<<1,
    }
    internal static void Optbug(nint Opt, string Reason)
    {
    }

    internal static int DoGetIntValue(nint Value, nuint Precision, nint Ret)
        => default;

    internal static long GetIntValue(nint Opt, OptParsed Flags)
        => default;

    internal static int SignedIntFits(long Value, nuint Precision)
        => default;

    internal static int HasString(string It, string Array)
        => default;

    internal static void CheckTypos(string Arg, nint Options)
    {
    }

    internal static void ParseOptionsCheck(nint Opts)
    {
    }

    internal static void ParseOptionsCheckHarder(nint Opts)
    {
    }

    internal static int HasSubcommands(nint Options)
        => default;

    internal static int ShowGitcomp(nint Opts, int ShowAll)
        => default;

    internal static void FreePreprocessedOptions(nint Options)
    {
    }

    internal const int USAGE_NORMAL = 0;
    internal const int USAGE_FULL = 1;
    internal const int USAGE_TO_STDOUT = 0;
    internal const int USAGE_TO_STDERR = 1;
    internal static int ParseOptionsEnd(nint Ctx)
        => default;

    internal static int UsageArgh(nint Opts, nint Outfile)
        => default;

    internal static int UsageIndent(nint Outfile)
        => default;

    internal const int USAGE_OPTS_WIDTH = 26;
    internal static void UsagePadding(nint Outfile, nuint Pos)
    {
    }

}
