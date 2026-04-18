using System.Runtime.InteropServices;

namespace PrTask.Automerge;

internal static unsafe partial class AutomergeNative
{
    [LibraryImport(LibName, EntryPoint = "AMsyncStateDecode")]
    internal static partial nint SyncStateDecode(byte* Src, nuint Count);

    [LibraryImport(LibName, EntryPoint = "AMsyncStateEncode")]
    internal static partial nint SyncStateEncode(nint SyncState);

    [LibraryImport(LibName, EntryPoint = "AMsyncStateEqual")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool SyncStateEqual(nint SyncState1, nint SyncState2);

    [LibraryImport(LibName, EntryPoint = "AMsyncStateInit")]
    internal static partial nint SyncStateInit();

    [LibraryImport(LibName, EntryPoint = "AMsyncStateSharedHeads")]
    internal static partial nint SyncStateSharedHeads(nint SyncState);

    [LibraryImport(LibName, EntryPoint = "AMsyncStateLastSentHeads")]
    internal static partial nint SyncStateLastSentHeads(nint SyncState);

    [LibraryImport(LibName, EntryPoint = "AMsyncStateTheirHaves")]
    internal static partial nint SyncStateTheirHaves(nint SyncState, byte* HasValue);

    [LibraryImport(LibName, EntryPoint = "AMsyncStateTheirHeads")]
    internal static partial nint SyncStateTheirHeads(nint SyncState, byte* HasValue);

    [LibraryImport(LibName, EntryPoint = "AMsyncStateTheirNeeds")]
    internal static partial nint SyncStateTheirNeeds(nint SyncState, byte* HasValue);

    [LibraryImport(LibName, EntryPoint = "AMsyncMessageDecode")]
    internal static partial nint SyncMessageDecode(byte* Src, nuint Count);

    [LibraryImport(LibName, EntryPoint = "AMsyncMessageEncode")]
    internal static partial nint SyncMessageEncode(nint SyncMessage);

    [LibraryImport(LibName, EntryPoint = "AMsyncMessageHaves")]
    internal static partial nint SyncMessageHaves(nint SyncMessage);

    [LibraryImport(LibName, EntryPoint = "AMsyncMessageHeads")]
    internal static partial nint SyncMessageHeads(nint SyncMessage);

    [LibraryImport(LibName, EntryPoint = "AMsyncMessageNeeds")]
    internal static partial nint SyncMessageNeeds(nint SyncMessage);

    [LibraryImport(LibName, EntryPoint = "AMsyncHaveLastSync")]
    internal static partial nint SyncHaveLastSync(nint SyncHave);
}
