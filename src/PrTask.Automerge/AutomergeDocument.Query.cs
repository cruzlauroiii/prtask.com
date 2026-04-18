using System.Text;

namespace PrTask.Automerge;

public sealed partial class AutomergeDocument
{
    public unsafe string? MapGetStr(string Key) => MapGetStr(0, Key);

    public unsafe string? MapGetStr(nint ObjId, string Key)
    {
        ThrowIfDisposed();
        var Result = AutomergeNative.MapGet(DocHandle, ObjId, ToByteSpan(Key), null);
        if (AutomergeNative.ResultStatus(Result) != AMstatus.Ok ||
            AutomergeNative.ResultSize(Result) == 0)
        {
            AutomergeNative.ResultFree(Result);
            return null;
        }

        try
        {
            var Item = AutomergeNative.ResultItem(Result);
            AMbyteSpan Span;
            return AutomergeNative.ItemToStr(Item, &Span)
                ? Encoding.UTF8.GetString(Span.Src, (int)Span.Count)
                : null;
        }
        finally
        {
            AutomergeNative.ResultFree(Result);
        }
    }

    public unsafe long? MapGetInt(string Key) => MapGetInt(0, Key);

    public unsafe long? MapGetInt(nint ObjId, string Key)
    {
        ThrowIfDisposed();
        var Result = AutomergeNative.MapGet(DocHandle, ObjId, ToByteSpan(Key), null);
        if (AutomergeNative.ResultStatus(Result) != AMstatus.Ok ||
            AutomergeNative.ResultSize(Result) == 0)
        {
            AutomergeNative.ResultFree(Result);
            return null;
        }

        try
        {
            var Item = AutomergeNative.ResultItem(Result);
            long Value;
            return AutomergeNative.ItemToInt(Item, &Value) ? Value : null;
        }
        finally
        {
            AutomergeNative.ResultFree(Result);
        }
    }

    public unsafe nuint ObjSize(nint ObjId = 0)
    {
        ThrowIfDisposed();
        return AutomergeNative.ObjSize(DocHandle, ObjId, null);
    }

    public nuint PendingOps()
    {
        ThrowIfDisposed();
        return AutomergeNative.PendingOps(DocHandle);
    }

    public nuint Rollback()
    {
        ThrowIfDisposed();
        return AutomergeNative.Rollback(DocHandle);
    }

    public bool Equals(AutomergeDocument? Other)
    {
        if (Other is null)
        {
            return false;
        }

        ThrowIfDisposed();
        Other.ThrowIfDisposed();
        return AutomergeNative.Equal(DocHandle, Other.DocHandle);
    }

    public override bool Equals(object? Obj) => Obj is AutomergeDocument Other && Equals(Other);

    public override int GetHashCode() => 0;

    internal nint Handle
    {
        get
        {
            ThrowIfDisposed();
            return DocHandle;
        }
    }

    public void Dispose()
    {
        if (!Disposed)
        {
            Disposed = true;
            DocHandle = 0;
        }
    }

    private static unsafe AMbyteSpan ToByteSpan(string? Value)
    {
        if (Value is null)
        {
            return default;
        }

        var Utf8 = Encoding.UTF8.GetBytes(Value + '\0');
        fixed (byte* Ptr = Utf8)
        {
            return AutomergeNative.Str(Ptr);
        }
    }

    private static unsafe nint ExtractDoc(nint Result)
    {
        CheckResult(Result);
        var Item = AutomergeNative.ResultItem(Result);
        nint Doc;
        if (!AutomergeNative.ItemToDoc(Item, &Doc))
        {
            AutomergeNative.ResultFree(Result);
            throw new InvalidOperationException(AutomergeConstants.FailedToExtractDoc);
        }

        AutomergeNative.ResultFree(Result);
        return Doc;
    }

    private static unsafe void CheckResult(nint Result)
    {
        if (Result == 0)
        {
            throw new InvalidOperationException(AutomergeConstants.NullResult);
        }

        var Status = AutomergeNative.ResultStatus(Result);
        if (Status != AMstatus.Ok)
        {
            var ErrSpan = AutomergeNative.ResultError(Result);
            var Error = ErrSpan.Count > 0
                ? Encoding.UTF8.GetString(ErrSpan.Src, (int)ErrSpan.Count)
                : AutomergeConstants.UnknownError;
            AutomergeNative.ResultFree(Result);
            throw new InvalidOperationException(Error);
        }
    }

    private static void CheckAndFree(nint Result)
    {
        CheckResult(Result);
        AutomergeNative.ResultFree(Result);
    }

    private void ThrowIfDisposed() => ObjectDisposedException.ThrowIf(Disposed, this);
}
