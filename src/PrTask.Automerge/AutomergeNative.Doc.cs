using System.Runtime.InteropServices;

namespace PrTask.Automerge;

internal static unsafe partial class AutomergeNative
{
    [LibraryImport(LibName, EntryPoint = "AMapplyChanges")]
    internal static partial nint ApplyChanges(nint Doc, AMitems* Items);

    [LibraryImport(LibName, EntryPoint = "AMclone")]
    internal static partial nint Clone(nint Doc);

    [LibraryImport(LibName, EntryPoint = "AMcreate")]
    internal static partial nint Create(nint ActorId);

    [LibraryImport(LibName, EntryPoint = "AMcommit")]
    internal static partial nint Commit(nint Doc, AMbyteSpan Message, long* Timestamp);

    [LibraryImport(LibName, EntryPoint = "AMemptyChange")]
    internal static partial nint EmptyChange(nint Doc, AMbyteSpan Message, long* Timestamp);

    [LibraryImport(LibName, EntryPoint = "AMequal")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool Equal(nint Doc1, nint Doc2);

    [LibraryImport(LibName, EntryPoint = "AMfork")]
    internal static partial nint Fork(nint Doc, AMitems* Heads);

    [LibraryImport(LibName, EntryPoint = "AMgenerateSyncMessage")]
    internal static partial nint GenerateSyncMessage(nint Doc, nint SyncState);

    [LibraryImport(LibName, EntryPoint = "AMgetActorId")]
    internal static partial nint GetActorId(nint Doc);

    [LibraryImport(LibName, EntryPoint = "AMgetChangeByHash")]
    internal static partial nint GetChangeByHash(nint Doc, byte* Src, nuint Count);

    [LibraryImport(LibName, EntryPoint = "AMgetChanges")]
    internal static partial nint GetChanges(nint Doc, AMitems* HaveDeps);

    [LibraryImport(LibName, EntryPoint = "AMgetChangesAdded")]
    internal static partial nint GetChangesAdded(nint Doc1, nint Doc2);

    [LibraryImport(LibName, EntryPoint = "AMgetCursor")]
    internal static partial nint GetCursor(nint Doc, nint ObjId, nuint Position, AMitems* Heads);

    [LibraryImport(LibName, EntryPoint = "AMgetCursorPosition")]
    internal static partial nint GetCursorPosition(nint Doc, nint ObjId, nint Cursor, AMitems* Heads);

    [LibraryImport(LibName, EntryPoint = "AMgetHeads")]
    internal static partial nint GetHeads(nint Doc);

    [LibraryImport(LibName, EntryPoint = "AMgetMissingDeps")]
    internal static partial nint GetMissingDeps(nint Doc, AMitems* Heads);

    [LibraryImport(LibName, EntryPoint = "AMgetLastLocalChange")]
    internal static partial nint GetLastLocalChange(nint Doc);

    [LibraryImport(LibName, EntryPoint = "AMkeys")]
    internal static partial nint Keys(nint Doc, nint ObjId, AMitems* Heads);

    [LibraryImport(LibName, EntryPoint = "AMload")]
    internal static partial nint Load(byte* Src, nuint Count);

    [LibraryImport(LibName, EntryPoint = "AMloadIncremental")]
    internal static partial nint LoadIncremental(nint Doc, byte* Src, nuint Count);

    [LibraryImport(LibName, EntryPoint = "AMmerge")]
    internal static partial nint Merge(nint Dest, nint Src);

    [LibraryImport(LibName, EntryPoint = "AMobjSize")]
    internal static partial nuint ObjSize(nint Doc, nint ObjId, AMitems* Heads);

    [LibraryImport(LibName, EntryPoint = "AMobjObjType")]
    internal static partial AMobjType ObjObjType(nint Doc, nint ObjId);

    [LibraryImport(LibName, EntryPoint = "AMobjItems")]
    internal static partial nint ObjItems(nint Doc, nint ObjId, AMitems* Heads);

    [LibraryImport(LibName, EntryPoint = "AMpendingOps")]
    internal static partial nuint PendingOps(nint Doc);

    [LibraryImport(LibName, EntryPoint = "AMreceiveSyncMessage")]
    internal static partial nint ReceiveSyncMessage(nint Doc, nint SyncState, nint SyncMessage);

    [LibraryImport(LibName, EntryPoint = "AMrollback")]
    internal static partial nuint Rollback(nint Doc);

    [LibraryImport(LibName, EntryPoint = "AMsave")]
    internal static partial nint Save(nint Doc);

    [LibraryImport(LibName, EntryPoint = "AMsaveIncremental")]
    internal static partial nint SaveIncremental(nint Doc);

    [LibraryImport(LibName, EntryPoint = "AMsetActorId")]
    internal static partial nint SetActorId(nint Doc, nint ActorId);

    [LibraryImport(LibName, EntryPoint = "AMsplice")]
    internal static partial nint Splice(nint Doc, nint ObjId, nuint Pos, nint Del, AMitems Values);

    [LibraryImport(LibName, EntryPoint = "AMspliceText")]
    internal static partial nint SpliceText(nint Doc, nint ObjId, nuint Pos, nint Del, AMbyteSpan Text);

    [LibraryImport(LibName, EntryPoint = "AMtext")]
    internal static partial nint Text(nint Doc, nint ObjId, AMitems* Heads);
}
