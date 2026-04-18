namespace PrTask.Git.Generated;

internal static partial class Refspec
{
    internal static int ParseRefspec(nint Item, string Refspec, int Fetch)
        => default;

    internal static int RefspecItemInitFetch(nint Item, string Refspec)
        => default;

    internal static int RefspecItemInitPush(nint Item, string Refspec)
        => default;

    internal static void RefspecItemClear(nint Item)
    {
    }

    internal static void RefspecInitFetch(nint Rs)
    {
    }

    internal static void RefspecInitPush(nint Rs)
    {
    }

    internal static void RefspecAppend(nint Rs, string Refspec)
    {
    }

    internal static void RefspecAppendf(nint Rs, string Fmt, params object[] VarArgs)
    {
    }

    internal static void RefspecAppendn(nint Rs, string Refspecs, int Nr)
    {
    }

    internal static void RefspecClear(nint Rs)
    {
    }

    internal static int ValidFetchRefspec(string FetchRefspecStr)
        => default;

    internal static int RefnameMatchesNegativeRefspecItem(string Refname, nint Rs)
        => default;

    internal static int RefspecFindNegativeMatch(nint Rs, nint Query)
        => default;

    internal static int RefspecFindMatch(nint Rs, nint Query)
        => default;

}
