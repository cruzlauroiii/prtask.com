using System.Runtime.InteropServices;

namespace PrTask.Automerge;

internal static unsafe partial class AutomergeNative
{
    [LibraryImport(LibName, EntryPoint = "AMmarkName")]
    internal static partial AMbyteSpan MarkName(nint Mark);

    [LibraryImport(LibName, EntryPoint = "AMmarkValue")]
    internal static partial nint MarkValue(nint Mark);

    [LibraryImport(LibName, EntryPoint = "AMmarkStart")]
    internal static partial nuint MarkStart(nint Mark);

    [LibraryImport(LibName, EntryPoint = "AMmarkEnd")]
    internal static partial nuint MarkEnd(nint Mark);

    [LibraryImport(LibName, EntryPoint = "AMmarks")]
    internal static partial nint Marks(nint Doc, nint ObjId, AMitems* Heads);

    [LibraryImport(LibName, EntryPoint = "AMmarkCreate")]
    internal static partial nint MarkCreate(nint Doc, nint ObjId, nuint Start, nuint End, AMmarkExpand Expand, AMbyteSpan Name, AMitems Value);

    [LibraryImport(LibName, EntryPoint = "AMmarkClear")]
    internal static partial nint MarkClear(nint Doc, nint ObjId, nuint Start, nuint End, AMmarkExpand Expand, AMbyteSpan Name);

    [LibraryImport(LibName, EntryPoint = "AMitemFromBool")]
    internal static partial nint ItemFromBool([MarshalAs(UnmanagedType.U1)] bool Value);

    [LibraryImport(LibName, EntryPoint = "AMitemFromBytes")]
    internal static partial nint ItemFromBytes(byte* Src, nuint Count);

    [LibraryImport(LibName, EntryPoint = "AMitemFromChangeHash")]
    internal static partial nint ItemFromChangeHash(AMbyteSpan Value);

    [LibraryImport(LibName, EntryPoint = "AMitemFromCounter")]
    internal static partial nint ItemFromCounter(long Value);

    [LibraryImport(LibName, EntryPoint = "AMitemFromF64")]
    internal static partial nint ItemFromF64(double Value);

    [LibraryImport(LibName, EntryPoint = "AMitemFromInt")]
    internal static partial nint ItemFromInt(long Value);

    [LibraryImport(LibName, EntryPoint = "AMitemFromNull")]
    internal static partial nint ItemFromNull();

    [LibraryImport(LibName, EntryPoint = "AMitemFromStr")]
    internal static partial nint ItemFromStr(AMbyteSpan Value);

    [LibraryImport(LibName, EntryPoint = "AMitemFromTimestamp")]
    internal static partial nint ItemFromTimestamp(long Value);

    [LibraryImport(LibName, EntryPoint = "AMitemFromUint")]
    internal static partial nint ItemFromUint(ulong Value);

    [LibraryImport(LibName, EntryPoint = "AMitemEqual")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemEqual(nint Item1, nint Item2);

    [LibraryImport(LibName, EntryPoint = "AMitemIdxType")]
    internal static partial AMidxType ItemIdxType(nint Item);

    [LibraryImport(LibName, EntryPoint = "AMitemObjId")]
    internal static partial nint ItemObjId(nint Item);

    [LibraryImport(LibName, EntryPoint = "AMitemKey")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemKey(nint Item, AMbyteSpan* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemPos")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemPos(nint Item, nuint* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemRefCount")]
    internal static partial nuint ItemRefCount(nint Item);

    [LibraryImport(LibName, EntryPoint = "AMitemResult")]
    internal static partial nint ItemResult(nint Item);

    [LibraryImport(LibName, EntryPoint = "AMitemValType")]
    internal static partial AMvalType ItemValType(nint Item);
}
