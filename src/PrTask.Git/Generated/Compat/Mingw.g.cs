namespace PrTask.Git.Generated;

internal static partial class Mingw
{
    internal static void OpenInGdb()
    {
    }

    internal static int ErrWinToPosix(uint Winerr)
        => default;

    internal static int IsFileInUseError(uint Errcode)
        => default;

    internal static int ReadYesNoAnswer()
        => default;

    internal static int AskYesNoIfPossible(string Format, VaList Args)
        => default;

    internal static int RetryAskYesNo(nint Tries, string Format, params object[] VarArgs)
        => default;

    internal enum HideDotfilesType
    {
        HIDE_DOTFILES_FALSE = 0,
        HIDE_DOTFILES_TRUE,
        HIDE_DOTFILES_DOTGITONLY,
    }
    internal static int IsWdirSep(WcharT Wchar)
        => default;

    internal enum PhantomSymlinkResult
    {
        PHANTOM_SYMLINK_RETRY,
        PHANTOM_SYMLINK_DONE,
        PHANTOM_SYMLINK_DIRECTORY,
    }
    internal static void ProcessPhantomSymlinks()
    {
    }

    internal static int MingwUnlink(string Pathname, int HandleInUseError)
        => default;

    internal static int IsDirEmpty(nint Wpath)
        => default;

    internal static int MingwRmdir(string Pathname)
        => default;

    internal static int NeedsHiding(string Path)
        => default;

    internal static int SetHiddenFlag(nint Path, int Set)
        => default;

    internal static int MingwMkdir(string Path, Int mode UNUSED)
        => default;

    internal static int MingwOpenAppend(nint Wfilename, int Oflags, params object[] VarArgs)
        => default;

    internal static int MingwOpenExisting(nint Filename, int Oflags, params object[] VarArgs)
        => default;

    internal static int IsLocalNamedPipePath(string Filename)
        => default;

    internal static int MingwOpen(string Filename, int Oflags, params object[] VarArgs)
        => default;

    internal static BOOL WINAPI CtrlIgnore(DWORD type UNUSED)
        => default;

    internal static int MingwFgetc(nint Stream)
        => default;

    internal static int MingwFflush(nint Stream)
        => default;

    internal static nint MingwWrite(int Fd, nint Buf, nuint Len)
        => default;

    internal static int MingwAccess(string Filename, int Mode)
        => default;

    internal static int MingwChdir(string Dirname)
        => default;

    internal static int MingwChmod(string Filename, int Mode)
        => default;

    internal static Long long FiletimeToHnsec(nint Ft)
        => default;

    internal static void FiletimeToTimespec(nint Ft, nint Ts)
    {
    }

    internal static int HasValidDirectoryPrefix(nint Wfilename)
        => default;

    internal static int MingwLstat(string FileName, nint Buf)
        => default;

    internal static int GetFileInfoByHandle(nint Hnd, nint Buf)
        => default;

    internal static int MingwStat(string FileName, nint Buf)
        => default;

    internal static int MingwFstat(int Fd, nint Buf)
        => default;

    internal static void TimeTToFiletime(long T, nint Ft)
    {
    }

    internal static int MingwUtime(string FileName, nint Times)
        => default;

    internal static Unint Sleep(Unint Seconds)
        => default;

    internal static int Mkstemp(string Template)
        => default;

    internal static int Gettimeofday(nint Tv, nint UNUSED)
        => default;

    internal static int Pipe(nint Filedes)
        => default;

    internal static int Wenvcmp(nint A, nint B)
        => default;

    internal static void DoUnsetEnvironmentVariables()
    {
    }

    internal static int IsMsys2Sh(string Cmd)
        => default;

    internal static int MingwSpawnv(string Cmd, string Argv, int PrependCmd)
        => default;

    internal static int TryShellExec(string Cmd, string Argv)
        => default;

    internal static int MingwExecv(string Cmd, string Argv)
        => default;

    internal static int MingwExecvp(string Cmd, string Argv)
        => default;

    internal static int MingwKill(int Pid, int Sig)
        => default;

    internal const int GETENV_MAX_RETAIN = 64;
    internal static int MingwPutenv(string Namevalue)
        => default;

    internal static void EnsureSocketInitialization()
    {
    }

    internal static int MingwGethostname(string Name, int Namelen)
        => default;

    internal static int MingwSocket(int Domain, int Type, int Protocol)
        => default;

    internal static int MingwConnect(int Sockfd, nint Sa, nuint Sz)
        => default;

    internal static int MingwBind(int Sockfd, nint Sa, nuint Sz)
        => default;

    internal static int MingwSetsockopt(int Sockfd, int Lvl, int Optname, nint Optval, int Optlen)
        => default;

    internal static int MingwShutdown(int Sockfd, int How)
        => default;

    internal static int MingwListen(int Sockfd, int Backlog)
        => default;

    internal static int MingwAccept(int Sockfd1, nint Sa, nint Sz)
        => default;

    internal static int MingwRename(string Pold, string Pnew)
        => default;

    internal static int MingwGetpagesize()
        => default;

    internal enum EXTENDEDNAMEFORMAT
    {
        NameDisplay = 3,
        NameUserPrincipal = 8,
    }
    internal static UnStdcall Ticktack(nint UNUSED)
        => default;

    internal static int StartTimerThread()
        => default;

    internal static void StopTimerThread()
    {
    }

    internal static int IsTimevalEq(nint I1, nint I2)
        => default;

    internal static int Setitimer(Int type UNUSED, nint In, nint Out)
        => default;

    internal static int Sigaction(int Sig, nint In, nint Out)
        => default;

    internal static SigHandlerT MingwSignal(int Sig, SigHandlerT Handler)
        => default;

    internal static int MingwRaise(int Sig)
        => default;

    internal static int Link(string Oldpath, string Newpath)
        => default;

    internal static int Symlink(string Target, string Link)
        => default;

    internal static int Readlink(string Path, string Buf, nuint Bufsiz)
        => default;

    internal static int Waitpid(int Pid, nint Status, int Options)
        => default;

    internal static int Xutftowcsn(nint Wcs, string Utfs, nuint Wcslen, int Utflen)
        => default;

    internal static int Xwcstoutf(string Utf, nint Wcs, nuint Utflen)
        => default;

    internal static void SetupWindowsEnvironment()
    {
    }

    internal static void GetCurrentUserSid(nint Sid, nint LinkedToken)
    {
    }

    internal static bool UserSidToUserName(PSID Sid, string Str)
        => default;

    internal static int AclsSupported(string Path)
        => default;

    internal static int IsPathOwnedByCurrentSid(string Path, nint Report)
        => default;

    internal static int IsValidWin32Path(string Path, int AllowLiteralNul)
        => default;

    internal static NORETURN void DieStartup()
        => default;

    internal static void MaybeRedirectStdHandles()
    {
    }

    internal static void AdjustSymlinkFlags()
    {
    }

    internal static int Wmain(int Argc, nint Wargv)
        => default;

    internal static int Uname(nint Buf)
        => default;

    internal static int MingwHaveUnixSockets()
        => default;

}
