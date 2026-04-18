namespace PrTask.Git.Generated;

internal static partial class Fsck
{
    internal static void PrepareMsgIds()
    {
    }

    internal static int ParseMsgId(string Text)
        => default;

    internal static void ListConfigFsckMsgIds(nint List, string Prefix)
    {
    }

    internal static FsckMsgType ParseMsgType(string Str)
        => default;

    internal static int IsValidMsgType(string MsgId, string MsgType)
        => default;

    internal static void FsckSetMsgTypes(nint Options, string Values)
    {
    }

    internal static void FsckEnableObjectNames(nint Options)
    {
    }

    internal static int FsckWalkTree(nint Tree, nint Data, nint Options)
        => default;

    internal static int FsckWalkCommit(nint Commit, nint Data, nint Options)
        => default;

    internal static int FsckWalkTag(nint Tag, nint Data, nint Options)
        => default;

    internal static int FsckWalk(nint Obj, nint Data, nint Options)
        => default;

    internal static void NameStackPush(nint Stack, string Name)
    {
    }

    internal static void NameStackClear(nint Stack)
    {
    }

    internal static int IsLessThanSlash(Unchar C)
        => default;

    internal static TimestampT ParseTimestampFromBuf(string Start, string End)
        => default;

    internal static int FsckFinish(nint Options)
        => default;

    internal static bool FsckHasQueuedChecks(nint Options)
        => default;

    internal static void FsckOptionsClear(nint Options)
    {
    }

}
