using System.Text;

namespace PrTask.Automerge;

public sealed partial class AutomergeDocument : IDisposable, IEquatable<AutomergeDocument>
{
    private nint DocHandle;
    private bool Disposed;

    public AutomergeDocument()
    {
        var Result = AutomergeNative.Create(0);
        DocHandle = ExtractDoc(Result);
    }

    private AutomergeDocument(nint Doc)
    {
        DocHandle = Doc;
    }

    public static unsafe AutomergeDocument Load(ReadOnlySpan<byte> Data)
    {
        fixed (byte* Ptr = Data)
        {
            var Result = AutomergeNative.Load(Ptr, (nuint)Data.Length);
            return new AutomergeDocument(ExtractDoc(Result));
        }
    }

    public AutomergeDocument Clone()
    {
        ThrowIfDisposed();
        var Result = AutomergeNative.Clone(DocHandle);
        return new AutomergeDocument(ExtractDoc(Result));
    }

    public unsafe AutomergeDocument Fork()
    {
        ThrowIfDisposed();
        var Result = AutomergeNative.Fork(DocHandle, null);
        return new AutomergeDocument(ExtractDoc(Result));
    }

    public void Merge(AutomergeDocument Other)
    {
        ArgumentNullException.ThrowIfNull(Other);
        ThrowIfDisposed();
        Other.ThrowIfDisposed();
        var Result = AutomergeNative.Merge(DocHandle, Other.DocHandle);
        CheckAndFree(Result);
    }

    public unsafe void Commit(string? Message = null)
    {
        ThrowIfDisposed();
        var MsgSpan = ToByteSpan(Message);
        var Result = AutomergeNative.Commit(DocHandle, MsgSpan, null);
        CheckAndFree(Result);
    }

    public unsafe byte[] Save()
    {
        ThrowIfDisposed();
        var Result = AutomergeNative.Save(DocHandle);
        CheckResult(Result);
        try
        {
            var Item = AutomergeNative.ResultItem(Result);
            AMbyteSpan Span;
            if (!AutomergeNative.ItemToBytes(Item, &Span))
            {
                throw new InvalidOperationException(AutomergeConstants.FailedToExtractBytes);
            }

            var Bytes = new byte[Span.Count];
            new ReadOnlySpan<byte>(Span.Src, (int)Span.Count).CopyTo(Bytes);
            return Bytes;
        }
        finally
        {
            AutomergeNative.ResultFree(Result);
        }
    }

    public void MapPutStr(string Key, string Value) => MapPutStr(0, Key, Value);

    public void MapPutStr(nint ObjId, string Key, string Value)
    {
        ThrowIfDisposed();
        var Result = AutomergeNative.MapPutStr(DocHandle, ObjId, ToByteSpan(Key), ToByteSpan(Value));
        CheckAndFree(Result);
    }

    public void MapPutInt(string Key, long Value) => MapPutInt(0, Key, Value);

    public void MapPutInt(nint ObjId, string Key, long Value)
    {
        ThrowIfDisposed();
        var Result = AutomergeNative.MapPutInt(DocHandle, ObjId, ToByteSpan(Key), Value);
        CheckAndFree(Result);
    }

    public void MapPutF64(string Key, double Value) => MapPutF64(0, Key, Value);

    public void MapPutF64(nint ObjId, string Key, double Value)
    {
        ThrowIfDisposed();
        var Result = AutomergeNative.MapPutF64(DocHandle, ObjId, ToByteSpan(Key), Value);
        CheckAndFree(Result);
    }

    public void MapPutBool(string Key, bool Value) => MapPutBool(0, Key, Value);

    public void MapPutBool(nint ObjId, string Key, bool Value)
    {
        ThrowIfDisposed();
        var Result = AutomergeNative.MapPutBool(DocHandle, ObjId, ToByteSpan(Key), Value);
        CheckAndFree(Result);
    }

    public nint MapPutObject(string Key, AMobjType ObjType) => MapPutObject(0, Key, ObjType);

    public nint MapPutObject(nint ObjId, string Key, AMobjType ObjType)
    {
        ThrowIfDisposed();
        var Result = AutomergeNative.MapPutObject(DocHandle, ObjId, ToByteSpan(Key), ObjType);
        CheckResult(Result);
        try
        {
            var Item = AutomergeNative.ResultItem(Result);
            return AutomergeNative.ItemObjId(Item);
        }
        finally
        {
            AutomergeNative.ResultFree(Result);
        }
    }

    public void MapDelete(string Key) => MapDelete(0, Key);

    public void MapDelete(nint ObjId, string Key)
    {
        ThrowIfDisposed();
        var Result = AutomergeNative.MapDelete(DocHandle, ObjId, ToByteSpan(Key));
        CheckAndFree(Result);
    }
}
