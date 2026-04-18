namespace PrTask.Git.Generated;

internal static partial class TransportHelper
{
    internal static void Sendline(nint Helper, nint Buffer)
    {
    }

    internal static int RecvlineFh(nint Helper, nint Buffer)
        => default;

    internal static int Recvline(nint Helper, nint Buffer)
        => default;

    internal static int WriteConstantGently(int Fd, string Str)
        => default;

    internal static void WriteConstant(int Fd, string Str)
    {
    }

    internal static void DoTakeOver(nint Transport)
    {
    }

    internal static int DisconnectHelper(nint Transport)
        => default;

    internal static void StandardOptions(nint T)
    {
    }

    internal static int ReleaseHelper(nint Transport)
        => default;

    internal static int GetImporter(nint Transport, nint Fastimport)
        => default;

    internal static int RunConnect(nint Transport, nint Cmdbuf)
        => default;

    internal static int HasAttribute(string Attrs, string Attr)
        => default;

    internal static int GetBundleUri(nint Transport)
        => default;

    internal static int TransportHelperInit(nint Transport, string Name)
        => default;

    internal const int BUFFERSIZE = 65536;
    internal const int PBUFFERSIZE = 8192;
    internal static void TransferDebug(string Fmt, params object[] VarArgs)
    {
    }

    internal const int SSTATE_TRANSFERRING = 0;
    internal const int SSTATE_FLUSHING = 1;
    internal const int SSTATE_FINISHED = 2;
    internal static void UdtCloseIfFinished(nint T)
    {
    }

    internal static int UdtDoRead(nint T)
        => default;

    internal static int UdtDoWrite(nint T)
        => default;

    internal static int TloopJoin(PthreadT Thread, string Name)
        => default;

    internal static int TloopSpawnwaitTasks(nint S)
        => default;

    internal static void UdtKillTransfer(nint T)
    {
    }

    internal static int TloopJoin(int Pid, string Name)
        => default;

    internal static int TloopSpawnwaitTasks(nint S)
        => default;

    internal static int BidirectionalTransferLoop(int Input, int Output)
        => default;

    internal static void RejectAtomicPush(nint RemoteRefs, int MirrorMode)
    {
    }

}
