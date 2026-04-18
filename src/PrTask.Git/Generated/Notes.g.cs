namespace PrTask.Git.Generated;

internal static partial class Notes
{
    internal const int PTR_TYPE_NULL = 0;
    internal const int PTR_TYPE_INTERNAL = 1;
    internal const int PTR_TYPE_NOTE = 2;
    internal const int PTR_TYPE_SUBTREE = 3;
    internal static void NoteTreeFree(nint Tree)
    {
    }

    internal static int NonNoteCmp(nint A, nint B)
        => default;

    internal static int TreeWriteStackFinishSubtree(nint Tws)
        => default;

    internal static int StringListAddOneRef(nint Ref, nint Cb)
        => default;

    internal static void StringListAddRefsByGlob(nint List, string Glob)
    {
    }

    internal static void InitDisplayNotes(nint Opt)
    {
    }

    internal static void ReleaseDisplayNotes(nint Opt)
    {
    }

    internal static void EnableDefaultDisplayNotes(nint Opt, nint ShowNotes)
    {
    }

    internal static void DisableDisplayNotes(nint Opt, nint ShowNotes)
    {
    }

    internal static void LoadDisplayNotes(nint Opt)
    {
    }

    internal static int RemoveNote(nint T, nint ObjectSha1)
        => default;

    internal static int WriteNotesTree(nint T, nint Result)
        => default;

    internal static void PruneNotes(nint T, int Flags)
    {
    }

    internal static void FreeNotes(nint T)
    {
    }

    internal static void ExpandNotesRef(nint Sb)
    {
    }

    internal static void ExpandLooseNotesRef(nint Sb)
    {
    }

}
