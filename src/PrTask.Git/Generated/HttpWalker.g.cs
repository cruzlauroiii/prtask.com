namespace PrTask.Git.Generated;

internal static partial class HttpWalker
{
    internal enum ObjectRequestState
    {
        WAITING,
        ABORTED,
        ACTIVE,
        COMPLETE,
    }
    internal static void StartObjectRequest(nint ObjReq)
    {
    }

    internal static void FinishObjectRequest(nint ObjReq)
    {
    }

    internal static void ProcessObjectResponse(nint CallbackData)
    {
    }

    internal static void ReleaseObjectRequest(nint ObjReq)
    {
    }

    internal static int FillActiveSlot(nint UNUSED)
        => default;

    internal static void Prefetch(nint Walker, nint Oid)
    {
    }

    internal static int IsAlternateAllowed(string Url)
        => default;

    internal static void ProcessAlternatesResponse(nint CallbackData)
    {
    }

    internal static void FetchAlternates(nint Walker, string Base)
    {
    }

    internal static int FetchIndices(nint Walker, nint Repo)
        => default;

    internal static void AbortObjectRequest(nint ObjReq)
    {
    }

    internal static int FetchObject(nint Walker, nint Oid)
        => default;

    internal static int Fetch(nint Walker, nint Oid)
        => default;

    internal static int FetchRef(nint Walker, nint Ref)
        => default;

    internal static void Cleanup(nint Walker)
    {
    }

}
