namespace PrTask.Git.Generated;

internal static partial class SparseIndex
{
    internal static int SetSparseIndexConfig(nint Repo, int Enable)
        => default;

    internal static int IndexHasUnmergedEntries(nint Istate)
        => default;

    internal static int IsSparseIndexAllowed(nint Istate, int Flags)
        => default;

    internal static int ConvertToSparse(nint Istate, int Flags)
        => default;

    internal static void SetIndexEntry(nint Istate, int Nr, nint Ce)
    {
    }

    internal static void ExpandIndex(nint Istate, nint Pl)
    {
    }

    internal static void EnsureFullIndex(nint Istate)
    {
    }

    internal static void EnsureCorrectSparsity(nint Istate)
    {
    }

    internal static void ClearPathFoundData(nint Data)
    {
    }

    internal static nuint MaxCommonDirPrefix(string Path1, string Path2)
        => default;

    internal static int PathFound(string Path, nint Data)
        => default;

    internal static int ClearSkipWorktreeFromPresentFilesSparse(nint Istate)
        => default;

    internal static void ClearSkipWorktreeFromPresentFilesFull(nint Istate)
    {
    }

    internal static void ClearSkipWorktreeFromPresentFiles(nint Istate)
    {
    }

}
