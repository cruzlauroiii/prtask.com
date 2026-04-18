using System.Runtime.InteropServices;

namespace PrTask.Automerge;

internal static unsafe partial class AutomergeNative
{
    [LibraryImport(LibName, EntryPoint = "AMitemToActorId")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToActorId(nint Item, nint* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToBool")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToBool(nint Item, byte* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToBytes")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToBytes(nint Item, AMbyteSpan* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToChange")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToChange(nint Item, nint* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToChangeHash")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToChangeHash(nint Item, AMbyteSpan* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToCounter")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToCounter(nint Item, long* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToCursor")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToCursor(nint Item, nint* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToDoc")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToDoc(nint Item, nint* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToF64")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToF64(nint Item, double* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToInt")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToInt(nint Item, long* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToMark")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToMark(nint Item, nint* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToStr")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToStr(nint Item, AMbyteSpan* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToSyncHave")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToSyncHave(nint Item, nint* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToSyncMessage")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToSyncMessage(nint Item, nint* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToSyncState")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToSyncState(nint Item, nint* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToTimestamp")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToTimestamp(nint Item, long* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToUint")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToUint(nint Item, ulong* Value);

    [LibraryImport(LibName, EntryPoint = "AMitemToUnknown")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemToUnknown(nint Item, AMunknownValue* Value);
}
