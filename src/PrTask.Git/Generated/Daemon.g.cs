namespace PrTask.Git.Generated;

internal static partial class Daemon
{
    internal static void Logreport(int Priority, string Err, VaList Params)
    {
    }

    internal static void Logerror(string Err, params object[] VarArgs)
    {
    }

    internal static void Loginfo(string Err, params object[] VarArgs)
    {
    }

    internal static Void NORETURN DaemonDie(string Err, VaList Params)
        => default;

    internal static int DaemonError(string Dir, string Msg)
        => default;

    internal static void CopyToLog(int Fd)
    {
    }

    internal static int RunServiceCommand(nint Cld)
        => default;

    internal static int UploadPack(nint Env)
        => default;

    internal static int UploadArchive(nint Env)
        => default;

    internal static int ReceivePack(nint Env)
        => default;

    internal static void EnableService(string Name, int Ena)
    {
    }

    internal static void MakeServiceOverridable(string Name, int Ena)
    {
    }

    internal static void SanitizeClient(nint Out, string In)
    {
    }

    internal static void CanonicalizeClient(nint Out, string In)
    {
    }

    internal static void LookupHostname(nint Hi)
    {
    }

    internal static void HostinfoClear(nint Hi)
    {
    }

    internal static void SetKeepAlive(int Sockfd)
    {
    }

    internal static int Execute()
        => default;

    internal static void AddChild(nint Cld, nint Addr, SocklenT Addrlen)
    {
    }

    internal static void KillSomeChild()
    {
    }

    internal static void CheckDeadChildren()
    {
    }

    internal static void Handle(int Incoming, nint Addr, SocklenT Addrlen)
    {
    }

    internal static void ChildHandler(Int signo UNUSED)
    {
    }

    internal static int SetReuseAddr(int Sockfd)
        => default;

    internal static int SetupNamedSock(string ListenAddr, int ListenPort, nint Socklist)
        => default;

    internal static int SetupNamedSock(string ListenAddr, int ListenPort, nint Socklist)
        => default;

    internal static void Socksetup(nint ListenAddr, int ListenPort, nint Socklist)
    {
    }

    internal static int ServiceLoop(nint Socklist)
        => default;

    internal static void DropPrivileges(nint UNUSED)
    {
    }

    internal static void DropPrivileges(nint Cred)
    {
    }

    internal static int CmdMain(int Argc, string Argv)
        => default;

}
