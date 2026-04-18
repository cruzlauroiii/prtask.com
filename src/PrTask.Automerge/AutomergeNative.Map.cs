using System.Runtime.InteropServices;

namespace PrTask.Automerge;

internal static unsafe partial class AutomergeNative
{
    [LibraryImport(LibName, EntryPoint = "AMmapDelete")]
    internal static partial nint MapDelete(nint Doc, nint ObjId, AMbyteSpan Key);

    [LibraryImport(LibName, EntryPoint = "AMmapGet")]
    internal static partial nint MapGet(nint Doc, nint ObjId, AMbyteSpan Key, AMitems* Heads);

    [LibraryImport(LibName, EntryPoint = "AMmapGetAll")]
    internal static partial nint MapGetAll(nint Doc, nint ObjId, AMbyteSpan Key, AMitems* Heads);

    [LibraryImport(LibName, EntryPoint = "AMmapIncrement")]
    internal static partial nint MapIncrement(nint Doc, nint ObjId, AMbyteSpan Key, long Value);

    [LibraryImport(LibName, EntryPoint = "AMmapPutBool")]
    internal static partial nint MapPutBool(nint Doc, nint ObjId, AMbyteSpan Key, [MarshalAs(UnmanagedType.U1)] bool Value);

    [LibraryImport(LibName, EntryPoint = "AMmapPutBytes")]
    internal static partial nint MapPutBytes(nint Doc, nint ObjId, AMbyteSpan Key, AMbyteSpan Value);

    [LibraryImport(LibName, EntryPoint = "AMmapPutCounter")]
    internal static partial nint MapPutCounter(nint Doc, nint ObjId, AMbyteSpan Key, long Value);

    [LibraryImport(LibName, EntryPoint = "AMmapPutNull")]
    internal static partial nint MapPutNull(nint Doc, nint ObjId, AMbyteSpan Key);

    [LibraryImport(LibName, EntryPoint = "AMmapPutObject")]
    internal static partial nint MapPutObject(nint Doc, nint ObjId, AMbyteSpan Key, AMobjType ObjType);

    [LibraryImport(LibName, EntryPoint = "AMmapPutF64")]
    internal static partial nint MapPutF64(nint Doc, nint ObjId, AMbyteSpan Key, double Value);

    [LibraryImport(LibName, EntryPoint = "AMmapPutInt")]
    internal static partial nint MapPutInt(nint Doc, nint ObjId, AMbyteSpan Key, long Value);

    [LibraryImport(LibName, EntryPoint = "AMmapPutStr")]
    internal static partial nint MapPutStr(nint Doc, nint ObjId, AMbyteSpan Key, AMbyteSpan Value);

    [LibraryImport(LibName, EntryPoint = "AMmapPutTimestamp")]
    internal static partial nint MapPutTimestamp(nint Doc, nint ObjId, AMbyteSpan Key, long Value);

    [LibraryImport(LibName, EntryPoint = "AMmapPutUint")]
    internal static partial nint MapPutUint(nint Doc, nint ObjId, AMbyteSpan Key, ulong Value);

    [LibraryImport(LibName, EntryPoint = "AMmapRange")]
    internal static partial nint MapRange(nint Doc, nint ObjId, AMbyteSpan Begin, AMbyteSpan End, AMitems* Heads);
}
