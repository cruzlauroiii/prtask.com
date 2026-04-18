namespace PrTask.Git.Generated;

internal static partial class HttpPush
{
    internal enum XMLStatus
    {
        XML_STATUS_OK = 1,
        XML_STATUS_ERROR = 0,
    }
    internal const int XML_STATUS_OK = 1;
    internal const int XML_STATUS_ERROR = 0;
    internal const int PREV_BUF_SIZE = 4096;
    internal const string DAV_LOCK = "LOCK";
    internal const string DAV_MKCOL = "MKCOL";
    internal const string DAV_MOVE = "MOVE";
    internal const string DAV_PROPFIND = "PROPFIND";
    internal const string DAV_PUT = "PUT";
    internal const string DAV_UNLOCK = "UNLOCK";
    internal const string DAV_DELETE = "DELETE";
    internal const string DAV_CTX_LOCKENTRY = ".multistatus.response.propstat.prop.supportedlock.lockentry";
    internal const string DAV_CTX_LOCKTYPE_WRITE = ".multistatus.response.propstat.prop.supportedlock.lockentry.locktype.write";
    internal const string DAV_CTX_LOCKTYPE_EXCLUSIVE = ".multistatus.response.propstat.prop.supportedlock.lockentry.lockscope.exclusive";
    internal const string DAV_ACTIVELOCK_OWNER = ".prop.lockdiscovery.activelock.owner.href";
    internal const string DAV_ACTIVELOCK_TIMEOUT = ".prop.lockdiscovery.activelock.timeout";
    internal const string DAV_ACTIVELOCK_TOKEN = ".prop.lockdiscovery.activelock.locktoken.href";
    internal const string DAV_PROPFIND_RESP = ".multistatus.response";
    internal const string DAV_PROPFIND_NAME = ".multistatus.response.href";
    internal const string DAV_PROPFIND_COLLECTION = ".multistatus.response.propstat.prop.resourcetype.collection";
    internal const int LOCK_TIME = 600;
    internal const int LOCK_REFRESH = 30;
    internal const int MAXDEPTH = 5;
    internal enum TransferState
    {
        NEED_FETCH,
        RUN_FETCH_LOOSE,
        RUN_FETCH_PACKED,
        NEED_PUSH,
        RUN_MKCOL,
        RUN_PUT,
        RUN_MOVE,
        ABORTED,
        COMPLETE,
    }
    internal enum DavHeaderFlag
    {
        DAV_HEADER_IF = (1u << 0),
        DAV_HEADER_LOCK = (1u << 1),
        DAV_HEADER_TIMEOUT = (1u << 2),
    }
    internal static void ProcessResponse(nint CallbackData)
    {
    }

    internal static void StartFetchLoose(nint Request)
    {
    }

    internal static void StartMkcol(nint Request)
    {
    }

    internal static void StartFetchPacked(nint Request)
    {
    }

    internal static void StartPut(nint Request)
    {
    }

    internal static void StartMove(nint Request)
    {
    }

    internal static int RefreshLock(nint Lock)
        => default;

    internal static void CheckLocks()
    {
    }

    internal static void ReleaseRequest(nint Request)
    {
    }

    internal static void FinishRequest(nint Request)
    {
    }

    internal static int FillActiveSlot(nint UNUSED)
        => default;

    internal static void AddFetchRequest(nint Obj)
    {
    }

    internal static int AddSendRequest(nint Obj, nint Lock)
        => default;

    internal static int FetchIndices()
        => default;

    internal static void OneRemoteObject(nint Oid)
    {
    }

    internal static void HandleLockpropCtx(nint Ctx, int TagClosed)
    {
    }

    internal static void HandleNewLockCtx(nint Ctx, int TagClosed)
    {
    }

    internal static int UnlockRemote(nint Lock)
        => default;

    internal static void RemoveLocks()
    {
    }

    internal static void RemoveLocksOnSignal(int Signo)
    {
    }

    internal static int GetOidHexFromObjpath(string Path, nint Oid)
        => default;

    internal static void ProcessLsObject(nint Ls)
    {
    }

    internal static void ProcessLsRef(nint Ls)
    {
    }

    internal static void HandleRemoteLsCtx(nint Ctx, int TagClosed)
    {
    }

    internal static void GetRemoteObjectList(Unchar Parent)
    {
    }

    internal static int LockingAvailable()
        => default;

    internal static int GetDelta(nint Revs, nint Lock)
        => default;

    internal static int UpdateRemote(nint Oid, nint Lock)
        => default;

    internal static void OneRemoteRef(string Refname)
    {
    }

    internal static void GetDavRemoteHeads()
    {
    }

    internal static void AddRemoteInfoRef(nint Ls)
    {
    }

    internal static void UpdateRemoteInfoRefs(nint Lock)
    {
    }

    internal static int RemoteExists(string Path)
        => default;

    internal static void FetchSymref(string Path, string Symref, nint Oid)
    {
    }

    internal static int VerifyMergeBase(nint HeadOid, nint Remote)
        => default;

    internal static int DeleteRemoteBranch(string Pattern, int Force)
        => default;

    internal static void RunRequestQueue()
    {
    }

    internal static int CmdMain(int Argc, string Argv)
        => default;

}
