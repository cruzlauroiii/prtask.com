namespace PrTask.Git.Generated;

internal static partial class Pretty
{
    internal static int CommitFormatIsEmpty(CmitFmt Fmt)
        => default;

    internal static void SaveUserFormat(nint Rev, string Cp, int IsTformat)
    {
    }

    internal static void SetupCommitFormats()
    {
    }

    internal static void GetCommitFormat(string Arg, nint Rev)
    {
    }

    internal static int GetOneLine(string Msg)
        => default;

    internal static int NonAscii(int Ch)
        => default;

    internal static int HasNonAscii(string S)
        => default;

    internal static int IsRfc822Special(byte Ch)
        => default;

    internal static int NeedsRfc822Quoting(string S, int Len)
        => default;

    internal static int LastLineLength(nint Sb)
        => default;

    internal static void AddRfc822Quoted(nint Out, string S, int Len)
    {
    }

    internal enum Rfc2047Type
    {
        RFC2047_SUBJECT,
        RFC2047_ADDRESS,
    }
    internal static int IsRfc2047Special(byte Ch, Rfc2047Type Type)
        => default;

    internal static int NeedsRfc2047Encoding(string Line, int Len)
        => default;

    internal static int IsBlankLine(string Line, nint LenP)
        => default;

    internal enum FlushType
    {
        no_flush,
        flush_right,
        flush_left,
        flush_left_and_steal,
        flush_both,
    }
    internal enum TruncType
    {
        trunc_none,
        trunc_left,
        trunc_middle,
        trunc_right,
    }
    internal static void ParseCommitHeader(nint Context)
    {
    }

    internal static int Istitlechar(byte C)
        => default;

    internal static void FormatSanitizedSubject(nint Sb, string Msg, nuint Len)
    {
    }

    internal static void ParseCommitMessage(nint C)
    {
    }

    internal static int FormatTrailerMatchCb(nint Key, nint Ud)
        => default;

    internal static nuint ParseDescribeArgs(string Start, nint Args)
        => default;

    internal static void FreeDecorationOptions(nint Opts)
    {
    }

    internal static void UserformatFindRequirements(string Fmt, nint W)
    {
    }

    internal static int PpUtf8Width(string Start, string End)
        => default;

    internal static int IsMboxrdFrom(string Line, int Len)
        => default;

}
