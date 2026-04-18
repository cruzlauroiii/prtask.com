namespace PrTask.Git.Generated;

internal static partial class Winansi
{
    internal const int FD_CONSOLE = 0x1;
    internal const int FD_SWAPPED = 0x2;
    internal const int FD_MSYS = 0x4;
    internal static void WarnIfRasterFont()
    {
    }

    internal static int IsConsole(int Fd)
        => default;

    internal const int BUFFER_SIZE = 4096;
    internal const int MAX_PARAMS = 16;
    internal static void WriteConsole(nint Str, nuint Len)
    {
    }

    internal static void SetConsoleAttr()
    {
    }

    internal static void EraseInLine()
    {
    }

    internal static void SetAttr(byte Func, nint Params, int Paramlen)
    {
    }

    internal static DWORD WINAPI ConsoleThread(LPVOID data UNUSED)
        => default;

    internal static void WinansiExit()
    {
    }

    internal static void DieLasterr(string Fmt, params object[] VarArgs)
    {
    }

    internal static int WinansiDup2(int Oldfd, int Newfd)
        => default;

    internal static nint DuplicateHandle(nint Hnd)
        => default;

    internal static nint SwapOsfhnd(int Fd, nint NewHandle)
        => default;

    internal static void DetectMsysTty(int Fd)
    {
    }

    internal static int WinansiIsatty(int Fd)
        => default;

    internal static void WinansiInit()
    {
    }

    internal static nint WinansiGetOsfhandle(int Fd)
        => default;

}
