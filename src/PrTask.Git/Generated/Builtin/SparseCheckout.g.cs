namespace PrTask.Git.Generated;

internal static partial class SparseCheckout
{
    internal static void WritePatternsToFile(nint Fp, nint Pl)
    {
    }

    internal static void CleanTrackedSparseDirectories(nint R)
    {
    }

    internal static void WriteConeToFile(nint Fp, nint Pl)
    {
    }

    internal enum SparseCheckoutMode
    {
        MODE_NO_PATTERNS = 0,
        MODE_ALL_PATTERNS = 1,
        MODE_CONE_PATTERNS = 2,
    }
    internal static SparseCheckoutMode UpdateConeMode(nint ConeMode)
        => default;

    internal static int UpdateModes(nint Repo, nint ConeMode, nint SparseIndex)
        => default;

    internal static void InsertRecursivePattern(nint Pl, nint Path)
    {
    }

    internal static void StrbufToConePattern(nint Line, nint Pl)
    {
    }

    internal enum ModifyType
    {
        REPLACE,
        ADD,
    }
    internal static int ListFileIterator(string Path, nint Data)
        => default;

}
