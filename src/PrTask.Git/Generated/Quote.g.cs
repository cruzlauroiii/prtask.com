namespace PrTask.Git.Generated;

internal static partial class Quote
{
    internal static int NeedBsQuote(byte C)
        => default;

    internal static void SqQuoteBuf(nint Dst, string Src)
    {
    }

    internal static void SqQuoteBufPretty(nint Dst, string Src)
    {
    }

    internal static void SqQuotef(nint Dst, string Fmt, params object[] VarArgs)
    {
    }

    internal static void SqQuoteArgv(nint Dst, string Argv)
    {
    }

    internal static void SqQuoteArgvPretty(nint Dst, string Argv)
    {
    }

    internal static void SqAppendQuoteArgvPretty(nint Dst, string Argv)
    {
    }

    internal static int SqDequoteToArgv(string Arg, string Argv, nint Nr, nint Alloc)
        => default;

    internal static int SqDequoteToStrvec(string Arg, nint Array)
        => default;

    internal static int CqMustQuote(byte C)
        => default;

    internal static nuint NextQuotePos(string S, nint Maxlen)
        => default;

    internal static nuint QuoteCStyle(string Name, nint Sb, nint Fp, uint Flags)
        => default;

    internal static void WriteNameQuoted(string Name, nint Fp, int Terminator)
    {
    }

    internal static int UnquoteCStyle(nint Sb, string Quoted, string Endp)
        => default;

    internal static void PerlQuoteBuf(nint Sb, string Src)
    {
    }

    internal static void PerlQuoteBufWithLen(nint Sb, string Src, nuint Len)
    {
    }

    internal static void PythonQuoteBuf(nint Sb, string Src)
    {
    }

    internal static void TclQuoteBuf(nint Sb, string Src)
    {
    }

    internal static void BasicRegexQuoteBuf(nint Sb, string Src)
    {
    }

}
