using System.Runtime.InteropServices;

namespace PrTask.Automerge;

internal static unsafe partial class AutomergeNative
{
    private const string LibName = "automerge_core";

    [LibraryImport(LibName, EntryPoint = "AMactorIdBytes")]
    internal static partial AMbyteSpan ActorIdBytes(nint ActorId);

    [LibraryImport(LibName, EntryPoint = "AMactorIdCmp")]
    internal static partial int ActorIdCmp(nint ActorId1, nint ActorId2);

    [LibraryImport(LibName, EntryPoint = "AMactorIdInit")]
    internal static partial nint ActorIdInit();

    [LibraryImport(LibName, EntryPoint = "AMactorIdFromBytes")]
    internal static partial nint ActorIdFromBytes(byte* Src, nuint Count);

    [LibraryImport(LibName, EntryPoint = "AMactorIdFromStr")]
    internal static partial nint ActorIdFromStr(AMbyteSpan Value);

    [LibraryImport(LibName, EntryPoint = "AMactorIdStr")]
    internal static partial AMbyteSpan ActorIdStr(nint ActorId);

    [LibraryImport(LibName, EntryPoint = "AMbytes")]
    internal static partial AMbyteSpan Bytes(byte* Src, nuint Count);

    [LibraryImport(LibName, EntryPoint = "AMstr")]
    internal static partial AMbyteSpan Str(byte* CStr);

    [LibraryImport(LibName, EntryPoint = "AMstrCmp")]
    internal static partial int StrCmp(AMbyteSpan Lhs, AMbyteSpan Rhs);

    [LibraryImport(LibName, EntryPoint = "AMchangeActorId")]
    internal static partial nint ChangeActorId(nint Change);

    [LibraryImport(LibName, EntryPoint = "AMchangeCompress")]
    internal static partial void ChangeCompress(nint Change);

    [LibraryImport(LibName, EntryPoint = "AMchangeDeps")]
    internal static partial nint ChangeDeps(nint Change);

    [LibraryImport(LibName, EntryPoint = "AMchangeExtraBytes")]
    internal static partial AMbyteSpan ChangeExtraBytes(nint Change);

    [LibraryImport(LibName, EntryPoint = "AMchangeFromBytes")]
    internal static partial nint ChangeFromBytes(byte* Src, nuint Count);

    [LibraryImport(LibName, EntryPoint = "AMchangeHash")]
    internal static partial AMbyteSpan ChangeHash(nint Change);

    [LibraryImport(LibName, EntryPoint = "AMchangeIsEmpty")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool ChangeIsEmpty(nint Change);

    [LibraryImport(LibName, EntryPoint = "AMchangeLoadDocument")]
    internal static partial nint ChangeLoadDocument(byte* Src, nuint Count);

    [LibraryImport(LibName, EntryPoint = "AMchangeMaxOp")]
    internal static partial ulong ChangeMaxOp(nint Change);

    [LibraryImport(LibName, EntryPoint = "AMchangeMessage")]
    internal static partial AMbyteSpan ChangeMessage(nint Change);

    [LibraryImport(LibName, EntryPoint = "AMchangeSeq")]
    internal static partial ulong ChangeSeq(nint Change);

    [LibraryImport(LibName, EntryPoint = "AMchangeSize")]
    internal static partial nuint ChangeSize(nint Change);

    [LibraryImport(LibName, EntryPoint = "AMchangeStartOp")]
    internal static partial ulong ChangeStartOp(nint Change);

    [LibraryImport(LibName, EntryPoint = "AMchangeTime")]
    internal static partial long ChangeTime(nint Change);

    [LibraryImport(LibName, EntryPoint = "AMchangeRawBytes")]
    internal static partial AMbyteSpan ChangeRawBytes(nint Change);

    [LibraryImport(LibName, EntryPoint = "AMcursorBytes")]
    internal static partial AMbyteSpan CursorBytes(nint Cursor);

    [LibraryImport(LibName, EntryPoint = "AMcursorEqual")]
    [return: MarshalAs(UnmanagedType.U1)]
    internal static partial bool CursorEqual(nint Cursor1, nint Cursor2);

    [LibraryImport(LibName, EntryPoint = "AMcursorFromBytes")]
    internal static partial nint CursorFromBytes(byte* Src, nuint Count);

    [LibraryImport(LibName, EntryPoint = "AMcursorFromStr")]
    internal static partial nint CursorFromStr(AMbyteSpan Value);

    [LibraryImport(LibName, EntryPoint = "AMcursorStr")]
    internal static partial AMbyteSpan CursorStr(nint Cursor);
}
