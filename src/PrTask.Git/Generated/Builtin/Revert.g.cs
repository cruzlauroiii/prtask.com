namespace PrTask.Git.Generated;

internal static partial class Revert
{
    internal enum EmptyAction
    {
        EMPTY_COMMIT_UNSPECIFIED = -1,
        STOP_ON_EMPTY_COMMIT,
        DROP_EMPTY_COMMIT,
        KEEP_EMPTY_COMMIT,
    }
    internal static int ParseOptEmpty(nint Opt, string Arg, int Unset)
        => default;

    internal static void VerifyOptCompatible(string Me, string BaseOpt, params object[] VarArgs)
    {
    }

}
