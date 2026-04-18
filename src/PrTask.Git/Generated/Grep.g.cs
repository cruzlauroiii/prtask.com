namespace PrTask.Git.Generated;

internal static partial class Grep
{
    internal static void StdOutput(nint UNUSED, nint Buf, nuint Size)
    {
    }

    internal static int ParsePatternTypeArg(string Opt, string Arg)
        => default;

    internal static void GrepInit(nint Opt, nint Repo)
    {
    }

    internal static void DoAppendGrepPat(nint Tail, nint P)
    {
    }

    internal static int IsFixed(string S, nuint Len)
        => default;

    internal const int GREP_PCRE2_DEBUG_MALLOC = 0;
    internal static void Pcre2Free(nint Pointer, nint UNUSED)
    {
    }

    internal static int Pcre2JitFunctional()
        => default;

    internal static void CompilePcre2Pattern(nint P, nint Opt)
    {
    }

    internal static void FreePcre2Pattern(nint P)
    {
    }

    internal static void FreePcre2Pattern(nint UNUSED)
    {
    }

    internal static void CompileFixedRegexp(nint P, nint Opt)
    {
    }

    internal static void CompileRegexp(nint P, nint Opt)
    {
    }

    internal static void CompileGrepPatterns(nint Opt)
    {
    }

    internal static void FreePatternExpr(nint X)
    {
    }

    internal static void FreeGrepPat(nint Pattern)
    {
    }

    internal static void FreeGrepPatterns(nint Opt)
    {
    }

    internal static int WordChar(byte Ch)
        => default;

    internal static void OutputSep(nint Opt, byte Sign)
    {
    }

    internal static void ShowName(nint Opt, string Name)
    {
    }

    internal static void StripTimestamp(string Bol, string EolP)
    {
    }

    internal static void GrepAttrLock()
    {
    }

    internal static void GrepAttrUnlock()
    {
    }

    internal static int ShouldLookahead(nint Opt)
        => default;

    internal static int IsEmptyLine(string Bol, string Eol)
        => default;

    internal static int GrepSource1(nint Opt, nint Gs, int CollectHits)
        => default;

    internal static void ClrHitMarker(nint X)
    {
    }

    internal static int ChkHitMarker(nint X)
        => default;

    internal static int GrepSource(nint Opt, nint Gs)
        => default;

    internal static int GrepBuffer(nint Opt, string Buf, Unlong Size)
        => default;

    internal static void GrepSourceClear(nint Gs)
    {
    }

    internal static void GrepSourceClearData(nint Gs)
    {
    }

    internal static int GrepSourceLoadOid(nint Gs)
        => default;

    internal static int GrepSourceLoadFile(nint Gs)
        => default;

    internal static int GrepSourceLoad(nint Gs)
        => default;

}
