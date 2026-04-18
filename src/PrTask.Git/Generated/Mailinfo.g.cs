namespace PrTask.Git.Generated;

internal static partial class Mailinfo
{
    internal static void CleanupSpace(nint Sb)
    {
    }

    internal static void GetSaneName(nint Out, nint Name, nint Email)
    {
    }

    internal static void ParseBogusFrom(nint Mi, nint Line)
    {
    }

    internal static void UnquoteQuotedPair(nint Line)
    {
    }

    internal static void HandleFrom(nint Mi, nint From)
    {
    }

    internal static void HandleHeader(nint Out, nint Line)
    {
    }

    internal static int SlurpAttr(string Line, string Name, nint Attr)
        => default;

    internal static int HasAttrValue(string Line, string Name, string Value)
        => default;

    internal static void HandleContentType(nint Mi, nint Line)
    {
    }

    internal static int IsMultipartBoundary(nint Mi, nint Line)
        => default;

    internal static void CleanupSubject(nint Mi, nint Subject)
    {
    }

    internal static int IsFormatPatchSeparator(string Line, int Len)
        => default;

    internal static int DecodeBSegment(nint Out, nint BSeg)
        => default;

    internal static void DecodeHeader(nint Mi, nint It)
    {
    }

    internal static void DecodeTransferEncoding(nint Mi, nint Line)
    {
    }

    internal static int Patchbreak(nint Line)
        => default;

    internal static int IsScissorsLine(string Line)
        => default;

    internal static void FlushInbodyHeaderAccum(nint Mi)
    {
    }

    internal static int CheckInbodyHeader(nint Mi, nint Line)
        => default;

    internal static int HandleCommitMsg(nint Mi, nint Line)
        => default;

    internal static void HandlePatch(nint Mi, nint Line)
    {
    }

    internal static void HandleFilter(nint Mi, nint Line)
    {
    }

    internal static int IsRfc2822Header(nint Line)
        => default;

    internal static int ReadOneHeaderLine(nint Line, nint In)
        => default;

    internal static int FindBoundary(nint Mi, nint Line)
        => default;

    internal static int HandleBoundary(nint Mi, nint Line)
        => default;

    internal static void SummarizeQuotedCr(nint Mi)
    {
    }

    internal static void HandleBody(nint Mi, nint Line)
    {
    }

    internal static void OutputHeaderLines(nint Fout, string Hdr, nint Data)
    {
    }

    internal static void HandleInfo(nint Mi)
    {
    }

    internal static int Mailinfo(nint Mi, string Msg, string Patch)
        => default;

    internal static int MailinfoParseQuotedCrAction(string Actionstr, nint Action)
        => default;

    internal static void SetupMailinfo(nint R, nint Mi)
    {
    }

    internal static void ClearMailinfo(nint Mi)
    {
    }

}
