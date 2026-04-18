namespace PrTask.Git.Generated;

internal static partial class Notes
{
    internal enum NotesStripspace
    {
        UNSPECIFIED = -1,
        NO_STRIPSPACE = 0,
        STRIPSPACE = 1,
    }
    internal static void FreeNoteData(nint D)
    {
    }

    internal static void CopyObjToFd(int Fd, nint Oid)
    {
    }

    internal static void WriteCommentedObject(int Fd, nint Object)
    {
    }

    internal static void WriteNoteData(nint D, nint Oid)
    {
    }

    internal static void AppendSeparator(nint Message)
    {
    }

    internal static void ConcatMessages(nint D)
    {
    }

    internal static int ParseMsgArg(nint Opt, string Arg, int Unset)
        => default;

    internal static int ParseFileArg(nint Opt, string Arg, int Unset)
        => default;

    internal static int ParseReuseArg(nint Opt, string Arg, int Unset)
        => default;

    internal static int ParseReeditArg(nint Opt, string Arg, int Unset)
        => default;

    internal static int NotesCopyFromStdin(int Force, string RewriteCmd)
        => default;

    internal static int MergeAbort(nint O)
        => default;

    internal static int MergeCommit(nint O)
        => default;

    internal const int IGNORE_MISSING = 1;
    internal static int RemoveOneNote(nint T, string Name, uint Flag)
        => default;

}
