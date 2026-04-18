namespace PrTask.Git.Generated;

internal static partial class Strbuf
{
    internal static bool StartsWith(string Str, string Prefix)
        => default;

    internal static bool IstartsWith(string Str, string Prefix)
        => default;

    internal static bool StartsWithMem(string Str, nuint Len, string Prefix)
        => default;

    internal static void StrbufInit(nint Sb, nuint Hint)
    {
    }

    internal static void StrbufRelease(nint Sb)
    {
    }

    internal static void StrbufAttach(nint Sb, nint Buf, nuint Len, nuint Alloc)
    {
    }

    internal static void StrbufGrow(nint Sb, nuint Extra)
    {
    }

    internal static void StrbufTrim(nint Sb)
    {
    }

    internal static void StrbufRtrim(nint Sb)
    {
    }

    internal static void StrbufTrimTrailingDirSep(nint Sb)
    {
    }

    internal static void StrbufTrimTrailingNewline(nint Sb)
    {
    }

    internal static void StrbufLtrim(nint Sb)
    {
    }

    internal static int StrbufReencode(nint Sb, string From, string To)
        => default;

    internal static void StrbufTolower(nint Sb)
    {
    }

    internal static void StrbufListFree(nint Sbs)
    {
    }

    internal static int StrbufCmp(nint A, nint B)
        => default;

    internal static void StrbufInsert(nint Sb, nuint Pos, nint Data, nuint Len)
    {
    }

    internal static void StrbufVinsertf(nint Sb, nuint Pos, string Fmt, VaList Ap)
    {
    }

    internal static void StrbufInsertf(nint Sb, nuint Pos, string Fmt, params object[] VarArgs)
    {
    }

    internal static void StrbufRemove(nint Sb, nuint Pos, nuint Len)
    {
    }

    internal static void StrbufAdd(nint Sb, nint Data, nuint Len)
    {
    }

    internal static void StrbufAddstrings(nint Sb, string S, nuint N)
    {
    }

    internal static void StrbufAddbuf(nint Sb, nint Sb2)
    {
    }

    internal static void StrbufAddchars(nint Sb, int C, nuint N)
    {
    }

    internal static void StrbufAddf(nint Sb, string Fmt, params object[] VarArgs)
    {
    }

    internal static void StrbufVaddf(nint Sb, string Fmt, VaList Ap)
    {
    }

    internal static int StrbufExpandStep(nint Sb, string Formatp)
        => default;

    internal static nuint StrbufExpandLiteral(nint Sb, string Placeholder)
        => default;

    internal static void StrbufExpandBadFormat(string Format, string Command)
    {
    }

    internal static void StrbufAddbufPercentquote(nint Dst, nint Src)
    {
    }

    internal static void StrbufAddPercentencode(nint Dst, string Src, int Flags)
    {
    }

    internal static nuint StrbufFread(nint Sb, nuint Size, nint F)
        => default;

    internal static nint StrbufRead(nint Sb, int Fd, nuint Hint)
        => default;

    internal static nint StrbufReadOnce(nint Sb, int Fd, nuint Hint)
        => default;

    internal static nint StrbufWrite(nint Sb, nint F)
        => default;

    internal static int StrbufReadlink(nint Sb, string Path, nuint Hint)
        => default;

    internal static int StrbufGetcwd(nint Sb)
        => default;

    internal static int StrbufGetwholeline(nint Sb, nint Fp, int Term)
        => default;

    internal static int StrbufGetwholeline(nint Sb, nint Fp, int Term)
        => default;

    internal static int StrbufAppendwholeline(nint Sb, nint Fp, int Term)
        => default;

    internal static int StrbufGetdelim(nint Sb, nint Fp, int Term)
        => default;

    internal static int StrbufGetdelimStripCrlf(nint Sb, nint Fp, int Term)
        => default;

    internal static int StrbufGetline(nint Sb, nint Fp)
        => default;

    internal static int StrbufGetlineLf(nint Sb, nint Fp)
        => default;

    internal static int StrbufGetlineNul(nint Sb, nint Fp)
        => default;

    internal static int StrbufGetwholelineFd(nint Sb, int Fd, int Term)
        => default;

    internal static nint StrbufReadFile(nint Sb, string Path, nuint Hint)
        => default;

    internal static void StrbufAddstrXmlQuoted(nint Buf, string S)
    {
    }

    internal static void HumaniseCount(nuint Count, string Value, string Unit)
    {
    }

    internal static void StrbufHumanise(nint Buf, long Bytes, uint Flags)
    {
    }

    internal static void StrbufHumaniseBytes(nint Buf, long Bytes)
    {
    }

    internal static void StrbufHumaniseRate(nint Buf, long Bytes)
    {
    }

    internal static int PrintfLn(string Fmt, params object[] VarArgs)
        => default;

    internal static int FprintfLn(nint Fp, string Fmt, params object[] VarArgs)
        => default;

    internal static nuint Cleanup(string Line, nuint Len)
        => default;

    internal static void StrbufStripspace(nint Sb, string CommentPrefix)
    {
    }

    internal static void StrbufStripFileFromPath(nint Sb)
    {
    }

}
