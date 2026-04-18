using System.Runtime.InteropServices;

namespace PrTask.Automerge;

internal static unsafe partial class AutomergeNative
{
    [LibraryImport(LibName, EntryPoint = "AMitemsAdvance")]
    internal static partial void ItemsAdvance(AMitems* Items, nint N);

    [LibraryImport(LibName, EntryPoint = "AMitemsEqual")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ItemsEqual(AMitems* Items1, AMitems* Items2);

    [LibraryImport(LibName, EntryPoint = "AMitemsNext")]
    internal static partial nint ItemsNext(AMitems* Items, nint N);

    [LibraryImport(LibName, EntryPoint = "AMitemsPrev")]
    internal static partial nint ItemsPrev(AMitems* Items, nint N);

    [LibraryImport(LibName, EntryPoint = "AMitemsReversed")]
    internal static partial AMitems ItemsReversed(AMitems* Items);

    [LibraryImport(LibName, EntryPoint = "AMitemsRewound")]
    internal static partial AMitems ItemsRewound(AMitems* Items);

    [LibraryImport(LibName, EntryPoint = "AMitemsSize")]
    internal static partial nuint ItemsSize(AMitems* Items);

    [LibraryImport(LibName, EntryPoint = "AMobjIdActorId")]
    internal static partial nint ObjIdActorId(nint ObjId);

    [LibraryImport(LibName, EntryPoint = "AMobjIdCounter")]
    internal static partial ulong ObjIdCounter(nint ObjId);

    [LibraryImport(LibName, EntryPoint = "AMobjIdEqual")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ObjIdEqual(nint ObjId1, nint ObjId2);

    [LibraryImport(LibName, EntryPoint = "AMobjIdIndex")]
    internal static partial nuint ObjIdIndex(nint ObjId);

    [LibraryImport(LibName, EntryPoint = "AMresultCat")]
    internal static partial nint ResultCat(nint Dest, nint Src);

    [LibraryImport(LibName, EntryPoint = "AMresultError")]
    internal static partial AMbyteSpan ResultError(nint Result);

    [LibraryImport(LibName, EntryPoint = "AMresultFree")]
    internal static partial void ResultFree(nint Result);

    [LibraryImport(LibName, EntryPoint = "AMresultItem")]
    internal static partial nint ResultItem(nint Result);

    [LibraryImport(LibName, EntryPoint = "AMresultItems")]
    internal static partial AMitems ResultItems(nint Result);

    [LibraryImport(LibName, EntryPoint = "AMresultSize")]
    internal static partial nuint ResultSize(nint Result);

    [LibraryImport(LibName, EntryPoint = "AMresultStatus")]
    internal static partial AMstatus ResultStatus(nint Result);
}
