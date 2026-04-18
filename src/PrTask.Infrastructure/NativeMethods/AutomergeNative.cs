using System.Runtime.InteropServices;
namespace PrTask.Infrastructure.NativeMethods;

#pragma warning disable CA5392
internal static partial class AutomergeNative
{
    private const string LibName = "automerge";

    [LibraryImport(LibName, EntryPoint = "AMcreate")]
    internal static partial nint Create(nint Options);

    [LibraryImport(LibName, EntryPoint = "AMresultFree")]
    internal static partial void ResultFree(nint Result);

    [LibraryImport(LibName, EntryPoint = "AMresultStatus")]
    internal static partial int ResultStatus(nint Result);

    [LibraryImport(LibName, EntryPoint = "AMitemToDoc")]
    internal static partial nint ItemToDoc(nint Item);

    [LibraryImport(LibName, EntryPoint = "AMmapPutStr")]
    internal static partial nint MapPutStr(nint Doc, nint Obj, nint Key, int KeyLen, nint Value, int ValueLen);

    [LibraryImport(LibName, EntryPoint = "AMmapGet")]
    internal static partial nint MapGet(nint Doc, nint Obj, nint Key, int KeyLen, nint Heads);

    [LibraryImport(LibName, EntryPoint = "AMsave")]
    internal static partial nint Save(nint Doc);

    [LibraryImport(LibName, EntryPoint = "AMload")]
    internal static partial nint Load(nint Data, int Len);

    [LibraryImport(LibName, EntryPoint = "AMmerge")]
    internal static partial nint Merge(nint Doc, nint Other);

    [LibraryImport(LibName, EntryPoint = "AMfree")]
    internal static partial void Free(nint Doc);
}
#pragma warning restore CA5392
