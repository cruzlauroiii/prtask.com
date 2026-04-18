namespace PrTask.Git.Generated;

internal static partial class Bisect
{
    internal static void FreeTerms(nint Terms)
    {
    }

    internal static int OneOf(string Term, params object[] VarArgs)
        => default;

    internal static int IsBisectSuccess(BisectError Res)
        => default;

    internal static int WriteInFile(string Path, string Mode, string Format, VaList Args)
        => default;

    internal static int WriteToFile(string Path, string Format, params object[] VarArgs)
        => default;

    internal static int AppendToFile(string Path, string Format, params object[] VarArgs)
        => default;

    internal static int PrintFileToStdout(string Path)
        => default;

    internal static int CheckTermFormat(string Term, string OrigTerm)
        => default;

    internal static int WriteTerms(string Bad, string Good)
        => default;

    internal static int BisectReset(string Commit)
        => default;

    internal static int CheckAndSetTerms(nint Terms, string Cmd)
        => default;

    internal static int IncNr(nint UNUSED, nint CbData)
        => default;

    internal static void BisectLogPrintf(string Fmt, params object[] VarArgs)
    {
    }

    internal static void BisectPrintStatus(nint Terms)
    {
    }

    internal static int GetTerms(nint Terms)
        => default;

    internal static int BisectTerms(nint Terms, string Option)
        => default;

    internal static int BisectAppendLogQuoted(string Argv)
        => default;

    internal static int AddBisectRef(nint Ref, nint Cb)
        => default;

    internal static int PrepareRevs(nint Terms, nint Revs)
        => default;

    internal static int BisectSkippedCommits(nint Terms)
        => default;

    internal static int BisectSuccessful(nint Terms)
        => default;

    internal static BisectError BisectNext(nint Terms, string Prefix)
        => default;

    internal static BisectError BisectAutoNext(nint Terms, string Prefix)
        => default;

    internal static int FileIsNotEmpty(string Path)
        => default;

    internal static int BisectAutostart(nint Terms)
        => default;

    internal static BisectError BisectLog()
        => default;

    internal static int ProcessReplayLine(nint Terms, nint Line)
        => default;

    internal static BisectError BisectReplay(nint Terms, string Filename)
        => default;

    internal static int GetFirstGood(nint Ref, nint CbData)
        => default;

    internal static int DoBisectRun(string Command)
        => default;

    internal static int VerifyGood(nint Terms, string Command)
        => default;

    internal static int BisectRun(nint Terms, int Argc, string Argv)
        => default;

}
