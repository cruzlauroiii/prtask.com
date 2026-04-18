namespace PrTask.Git.Generated;

internal static partial class Walker
{
    internal static void WalkerSay(nint Walker, string Fmt, params object[] VarArgs)
    {
    }

    internal static void ReportMissing(nint Obj)
    {
    }

    internal static int ProcessTree(nint Walker, nint Tree)
        => default;

    internal static int ProcessCommit(nint Walker, nint Commit)
        => default;

    internal static int ProcessTag(nint Walker, nint Tag)
        => default;

    internal static int ProcessObject(nint Walker, nint Obj)
        => default;

    internal static int Process(nint Walker, nint Obj)
        => default;

    internal static int Loop(nint Walker)
        => default;

    internal static int InterpretTarget(nint Walker, string Target, nint Oid)
        => default;

    internal static int MarkComplete(nint Ref, nint UNUSED)
        => default;

    internal static int WalkerTargetsStdin(string Target, string WriteRef)
        => default;

    internal static void WalkerTargetsFree(int Targets, string Target, string WriteRef)
    {
    }

    internal static void WalkerFree(nint Walker)
    {
    }

}
