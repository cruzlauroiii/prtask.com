namespace PrTask.Git.Generated;

internal static partial class UnpackTrees
{
    internal static void ClearUnpackTreesPorcelain(nint Opts)
    {
    }

    internal static void DisplayErrorMsgs(nint O)
    {
    }

    internal static void DisplayWarningMsgs(nint O)
    {
    }

    internal static void ReportCollidedCheckout(nint Index)
    {
    }

    internal static int MustCheckout(nint Ce)
        => default;

    internal static void MarkCeUsed(nint Ce, nint O)
    {
    }

    internal static void MarkAllCeUnused(nint Index)
    {
    }

    internal static void RestoreCacheBottom(nint Info, int Bottom)
    {
    }

    internal static int SwitchCacheBottom(nint Info)
        => default;

    internal static int AreSameOid(nint NameJ, nint NameK)
        => default;

    internal static int CompareEntry(nint Ce, nint Info, nint N)
        => default;

    internal static int UnpackFailed(nint O, string Message)
        => default;

    internal static void DebugPath(nint Info)
    {
    }

    internal static void DebugNameEntry(int I, nint N)
    {
    }

    internal static int UnpackSparseCallback(int N, Unlong Mask, Unlong Dirmask, nint Names, nint Info)
        => default;

    internal static int UnpackCallback(int N, Unlong Mask, Unlong Dirmask, nint Names, nint Info)
        => default;

    internal static int UnpackTrees(uint Len, nint T, nint O)
        => default;

    internal static int Same(nint A, nint B)
        => default;

    internal static int IcaseExists(nint O, string Name, int Len, nint St)
        => default;

    internal enum AbsentCheckingType
    {
        COMPLETELY_ABSENT,
        ABSENT_ANY_DIRECTORY,
    }
}
