using System.Runtime.InteropServices;

namespace PrTask.Automerge;

internal static unsafe partial class AutomergeNative
{
    [LibraryImport(LibName, EntryPoint = "AMlistDelete")]
    internal static partial nint ListDelete(nint Doc, nint ObjId, nuint Pos);

    [LibraryImport(LibName, EntryPoint = "AMlistGet")]
    internal static partial nint ListGet(nint Doc, nint ObjId, nuint Pos, AMitems* Heads);

    [LibraryImport(LibName, EntryPoint = "AMlistGetAll")]
    internal static partial nint ListGetAll(nint Doc, nint ObjId, nuint Pos, AMitems* Heads);

    [LibraryImport(LibName, EntryPoint = "AMlistIncrement")]
    internal static partial nint ListIncrement(nint Doc, nint ObjId, nuint Pos, long Value);

    [LibraryImport(LibName, EntryPoint = "AMlistPutBool")]
    internal static partial nint ListPutBool(nint Doc, nint ObjId, nuint Pos, [MarshalAs(UnmanagedType.U1)] bool Insert, [MarshalAs(UnmanagedType.U1)] bool Value);

    [LibraryImport(LibName, EntryPoint = "AMlistPutBytes")]
    internal static partial nint ListPutBytes(nint Doc, nint ObjId, nuint Pos, [MarshalAs(UnmanagedType.U1)] bool Insert, AMbyteSpan Value);

    [LibraryImport(LibName, EntryPoint = "AMlistPutCounter")]
    internal static partial nint ListPutCounter(nint Doc, nint ObjId, nuint Pos, [MarshalAs(UnmanagedType.U1)] bool Insert, long Value);

    [LibraryImport(LibName, EntryPoint = "AMlistPutF64")]
    internal static partial nint ListPutF64(nint Doc, nint ObjId, nuint Pos, [MarshalAs(UnmanagedType.U1)] bool Insert, double Value);

    [LibraryImport(LibName, EntryPoint = "AMlistPutInt")]
    internal static partial nint ListPutInt(nint Doc, nint ObjId, nuint Pos, [MarshalAs(UnmanagedType.U1)] bool Insert, long Value);

    [LibraryImport(LibName, EntryPoint = "AMlistPutNull")]
    internal static partial nint ListPutNull(nint Doc, nint ObjId, nuint Pos, [MarshalAs(UnmanagedType.U1)] bool Insert);

    [LibraryImport(LibName, EntryPoint = "AMlistPutObject")]
    internal static partial nint ListPutObject(nint Doc, nint ObjId, nuint Pos, [MarshalAs(UnmanagedType.U1)] bool Insert, AMobjType ObjType);

    [LibraryImport(LibName, EntryPoint = "AMlistPutStr")]
    internal static partial nint ListPutStr(nint Doc, nint ObjId, nuint Pos, [MarshalAs(UnmanagedType.U1)] bool Insert, AMbyteSpan Value);

    [LibraryImport(LibName, EntryPoint = "AMlistPutTimestamp")]
    internal static partial nint ListPutTimestamp(nint Doc, nint ObjId, nuint Pos, [MarshalAs(UnmanagedType.U1)] bool Insert, long Value);

    [LibraryImport(LibName, EntryPoint = "AMlistPutUint")]
    internal static partial nint ListPutUint(nint Doc, nint ObjId, nuint Pos, [MarshalAs(UnmanagedType.U1)] bool Insert, ulong Value);

    [LibraryImport(LibName, EntryPoint = "AMlistRange")]
    internal static partial nint ListRange(nint Doc, nint ObjId, nuint Begin, nuint End, AMitems* Heads);
}
