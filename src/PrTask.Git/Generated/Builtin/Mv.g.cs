namespace PrTask.Git.Generated;

internal static partial class Mv
{
    internal enum UpdateMode
    {
        WORKING_DIRECTORY = (1 << 1),
        INDEX = (1 << 2),
        SPARSE = (1 << 3),
        SKIP_WORKTREE_DIR = (1 << 4),
        MOVE_VIA_PARENT_DIR = (1 << 5),
    }
    internal const int DUP_BASENAME = 1;
    internal const int KEEP_TRAILING_SLASH = 2;
    internal static int EmptyDirHasSparseContents(string Name)
        => default;

    internal static void RemoveEmptySrcDirs(string SrcDir, nuint SrcDirNr)
    {
    }

}
