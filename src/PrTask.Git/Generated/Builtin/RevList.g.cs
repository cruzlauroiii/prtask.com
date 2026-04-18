namespace PrTask.Git.Generated;

internal static partial class RevList
{
    internal static void MissingObjectsMapEntryFree(nint E)
    {
    }

    internal enum MissingAction
    {
        MA_ERROR = 0,
        MA_ALLOW_ANY,
        MA_PRINT,
        MA_PRINT_INFO,
        MA_ALLOW_PROMISOR,
    }
    internal static long GetObjectDiskUsage(nint Obj)
        => default;

    internal static void FinishObjectMa(nint Obj, string Name)
    {
    }

    internal static void FinishCommit(nint Commit)
    {
    }

    internal static void ShowCommit(nint Commit, nint Data)
    {
    }

    internal static int FinishObject(nint Obj, string Name, nint CbData)
        => default;

    internal static void ShowObject(nint Obj, string Name, nint CbData)
    {
    }

    internal static void ShowEdge(nint Commit)
    {
    }

    internal static void PrintVarStr(string Var, string Val)
    {
    }

    internal static void PrintVarInt(string Var, int Val)
    {
    }

    internal static int ShowBisectVars(nint Info, int Reaches, int All)
        => default;

    internal static void PrintDiskUsage(long Size)
    {
    }

    internal static int ParseMissingActionValue(string Value)
        => default;

}
