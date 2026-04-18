namespace PrTask.Git.Generated;

internal static partial class Bundle
{
    internal static void BundleHeaderInit(nint Header)
    {
    }

    internal static void BundleHeaderRelease(nint Header)
    {
    }

    internal static int ParseCapability(nint Header, string Capability)
        => default;

    internal static int ParseBundleSignature(nint Header, string Line)
        => default;

    internal static int ReadBundleHeader(string Path, nint Header)
        => default;

    internal static int IsBundle(string Path, int Quiet)
        => default;

    internal static int ListRefs(nint R, int Argc, string Argv)
        => default;

    internal static int ListBundleRefs(nint Header, int Argc, string Argv)
        => default;

    internal static int IsTagInDateRange(nint Tag, nint Revs)
        => default;

    internal static int WritePackData(int BundleFd, nint Revs, nint PackOptions)
        => default;

    internal static int WriteBundleRefs(int BundleFd, nint Revs)
        => default;

    internal static void WriteBundlePrerequisites(nint Commit, nint Data)
    {
    }

}
