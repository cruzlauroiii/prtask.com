namespace PrTask.Git.Generated;

internal static partial class Terminal
{
    internal static void RestoreTermOnSignal(int Sig)
    {
    }

    internal const string INPUT_PATH = "/dev/tty";
    internal const string OUTPUT_PATH = "/dev/tty";
    internal static void WriteErr(string Msg)
    {
    }

    internal static void PrintBackgroundResumeMsg(int Signo)
    {
    }

    internal static void RestoreTerminalOnSuspend(int Signo)
    {
    }

    internal static void ResetJobSignals()
    {
    }

    internal static void CloseTermFd()
    {
    }

    internal static void RestoreTerm()
    {
    }

    internal static int SaveTerm(SaveTermFlags Flags)
        => default;

    internal static int DisableBits(SaveTermFlags Flags, TcflagT Bits)
        => default;

    internal static int DisableEcho(SaveTermFlags Flags)
        => default;

    internal static int EnableNonCanonical(SaveTermFlags Flags)
        => default;

    internal static int GetcharWithTimeout(int Timeout)
        => default;

    internal const string INPUT_PATH = "CONIN$";
    internal const string OUTPUT_PATH = "CONOUT$";
    internal const string FORCE_TEXT = "t";
    internal static void RestoreTerm()
    {
    }

    internal static int SaveTerm(SaveTermFlags Flags)
        => default;

    internal static int DisableBits(SaveTermFlags Flags, uint Bits)
        => default;

    internal static int DisableEcho(SaveTermFlags Flags)
        => default;

    internal static int EnableNonCanonical(SaveTermFlags Flags)
        => default;

    internal static int MingwGetchar()
        => default;

    internal static int GetcharWithTimeout(int Timeout)
        => default;

    internal static int IsKnownEscapeSequence(string Sequence)
        => default;

    internal static int ReadKeyWithoutEcho(nint Buf)
        => default;

    internal static int SaveTerm(SaveTermFlags Flags)
        => default;

    internal static void RestoreTerm()
    {
    }

    internal static int ReadKeyWithoutEcho(nint Buf)
        => default;

}
