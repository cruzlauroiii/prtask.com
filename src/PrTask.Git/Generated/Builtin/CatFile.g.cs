namespace PrTask.Git.Generated;

internal static partial class CatFile
{
    internal enum BatchMode
    {
        BATCH_MODE_CONTENTS,
        BATCH_MODE_INFO,
        BATCH_MODE_QUEUE_AND_DISPATCH,
    }
    internal static int StreamBlob(nint Oid)
        => default;

    internal static int CatOneFile(int Opt, string ExpType, string ObjName)
        => default;

    internal static int IsAtom(string Atom, string S, int Slen)
        => default;

    internal static void BatchWrite(nint Opt, nint Data, int Len)
    {
    }

    internal static void PrintObjectOrDie(nint Opt, nint Data)
    {
    }

    internal static int BatchObjectCb(nint Oid, nint Vdata)
        => default;

    internal static void FreeCmds(nint Cmd, nint Nr)
    {
    }

    internal static int BatchObjects(nint Opt)
        => default;

}
