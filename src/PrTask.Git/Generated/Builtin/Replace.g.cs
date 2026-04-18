namespace PrTask.Git.Generated;

internal static partial class Replace
{
    internal enum ReplaceFormat
    {
        REPLACE_FORMAT_SHORT,
        REPLACE_FORMAT_MEDIUM,
        REPLACE_FORMAT_LONG,
    }
    internal static int ShowReference(nint Ref, nint CbData)
        => default;

    internal static int ListReplaceRefs(string Pattern, string Format)
        => default;

    internal static int ForEachReplaceName(string Argv, EachReplaceNameFn Fn)
        => default;

    internal static int ReplaceObject(string ObjectRef, string ReplaceRef, int Force)
        => default;

    internal static int EditAndReplace(string ObjectRef, int Force, int Raw)
        => default;

    internal static int ReplaceParents(nint Buf, int Argc, string Argv)
        => default;

    internal static int CheckMergetags(nint Commit, int Argc, string Argv)
        => default;

    internal static int CreateGraft(int Argc, string Argv, int Force, int Gentle)
        => default;

    internal static int ConvertGraftFile(int Force)
        => default;

}
