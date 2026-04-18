namespace PrTask.Git.Generated;

internal static partial class ExecCmd
{
    internal const int MAX_ARGS = 32;
    internal static int GitGetExecPathFromArgv0(nint Buf, string Argv0)
        => default;

    internal static int GitGetExecPathProcfs(nint Buf)
        => default;

    internal static int GitGetExecPathBsdSysctl(nint Buf)
        => default;

    internal static int GitGetExecPathDarwin(nint Buf)
        => default;

    internal static int GitGetExecPathZos(nint Buf)
        => default;

    internal static int GitGetExecPathWpgmptr(nint Buf)
        => default;

    internal static int GitGetExecPath(nint Buf, string Argv0)
        => default;

    internal static void GitResolveExecutableDir(string Argv0)
    {
    }

    internal static void GitResolveExecutableDir(nint UNUSED)
    {
    }

    internal static void GitSetExecPath(string ExecPath)
    {
    }

    internal static void AddPath(nint Out, string Path)
    {
    }

    internal static void SetupPath()
    {
    }

    internal static int ExecvGitCmd(string Argv)
        => default;

    internal static int ExeclGitCmd(string Cmd, params object[] VarArgs)
        => default;

}
