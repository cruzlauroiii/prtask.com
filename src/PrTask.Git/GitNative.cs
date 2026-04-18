using System.Runtime.InteropServices;

namespace PrTask.Git;

internal static class GitNative
{
    private const string LibName = "PrtaskGitShim";
    private const int DefaultBufferSize = 4096;

    [DllImport(LibName, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
    private static extern int PrtaskGitCloneNative(
        [MarshalAs(UnmanagedType.LPStr)] string Url,
        [MarshalAs(UnmanagedType.LPStr)] string Dir,
        int Depth);

    [DllImport(LibName, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
    private static extern int PrtaskGitFetchNative(
        [MarshalAs(UnmanagedType.LPStr)] string Dir,
        [MarshalAs(UnmanagedType.LPStr)] string Remote);

    [DllImport(LibName, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
    private static extern int PrtaskGitResetHardNative(
        [MarshalAs(UnmanagedType.LPStr)] string Dir,
        [MarshalAs(UnmanagedType.LPStr)] string Ref);

    [DllImport(LibName, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
    private static extern int PrtaskGitDiffNative(
        [MarshalAs(UnmanagedType.LPStr)] string Dir,
        [MarshalAs(UnmanagedType.LPStr)] string OutBuffer,
        int BufSize);

    [DllImport(LibName, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
    private static extern int PrtaskGitCommitNative(
        [MarshalAs(UnmanagedType.LPStr)] string Dir,
        [MarshalAs(UnmanagedType.LPStr)] string Message);

    [DllImport(LibName, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
    private static extern int PrtaskGitPushNative(
        [MarshalAs(UnmanagedType.LPStr)] string Dir,
        [MarshalAs(UnmanagedType.LPStr)] string Remote,
        [MarshalAs(UnmanagedType.LPStr)] string Branch);

    [DllImport(LibName, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
    private static extern IntPtr PrtaskGitHeadShaNative(
        [MarshalAs(UnmanagedType.LPStr)] string Dir);

    [DllImport(LibName, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
    private static extern int PrtaskGitCheckoutNative(
        [MarshalAs(UnmanagedType.LPStr)] string Dir,
        [MarshalAs(UnmanagedType.LPStr)] string Branch);

    [DllImport(LibName, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
    private static extern int PrtaskGitStatusNative(
        [MarshalAs(UnmanagedType.LPStr)] string Dir,
        [MarshalAs(UnmanagedType.LPStr)] string OutBuffer,
        int BufSize);

    internal static int PrtaskGitClone(string Url, string Dir, int Depth) =>
        PrtaskGitCloneNative(Url ?? string.Empty, Dir ?? string.Empty, Depth);

    internal static int PrtaskGitFetch(string Dir, string Remote) =>
        PrtaskGitFetchNative(Dir ?? string.Empty, Remote ?? string.Empty);

    internal static int PrtaskGitResetHard(string Dir, string Ref) =>
        PrtaskGitResetHardNative(Dir ?? string.Empty, Ref ?? string.Empty);

    internal static int PrtaskGitCommit(string Dir, string Message) =>
        PrtaskGitCommitNative(Dir ?? string.Empty, Message ?? string.Empty);

    internal static int PrtaskGitPush(string Dir, string Remote, string Branch) =>
        PrtaskGitPushNative(Dir ?? string.Empty, Remote ?? string.Empty, Branch ?? string.Empty);

    internal static int PrtaskGitCheckout(string Dir, string Branch) =>
        PrtaskGitCheckoutNative(Dir ?? string.Empty, Branch ?? string.Empty);

    internal static string? GetHeadSha(string Dir)
    {
        var Ptr = PrtaskGitHeadShaNative(Dir ?? string.Empty);
        return Ptr == IntPtr.Zero ? null : Marshal.PtrToStringAnsi(Ptr);
    }

    internal static (int Result, string Output) PrtaskGitDiff(string Dir)
    {
        var Buffer = new string('\0', DefaultBufferSize);
        var Result = PrtaskGitDiffNative(Dir ?? string.Empty, Buffer, DefaultBufferSize);
        return (Result, Buffer.TrimEnd('\0'));
    }

    internal static (int Result, string Output) PrtaskGitStatus(string Dir)
    {
        var Buffer = new string('\0', DefaultBufferSize);
        var Result = PrtaskGitStatusNative(Dir ?? string.Empty, Buffer, DefaultBufferSize);
        return (Result, Buffer.TrimEnd('\0'));
    }
}
