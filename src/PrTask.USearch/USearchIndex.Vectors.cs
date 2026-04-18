namespace PrTask.USearch;

public sealed partial class USearchIndex
{
    public void Add(ulong Key, ReadOnlySpan<float> Vector)
    {
        EnsureCapacity(1);
        unsafe
        {
            fixed (float* Ptr = Vector)
            {
                NativeMethods.usearch_add(
                    IndexHandle, Key, (nint)Ptr, ScalarKind.Float32, out var Error);
                ThrowIfError(Error);
            }
        }
    }

    public void Add(ulong Key, ReadOnlySpan<double> Vector)
    {
        EnsureCapacity(1);
        unsafe
        {
            fixed (double* Ptr = Vector)
            {
                NativeMethods.usearch_add(
                    IndexHandle, Key, (nint)Ptr, ScalarKind.Float64, out var Error);
                ThrowIfError(Error);
            }
        }
    }

    public void AddBatch(ReadOnlySpan<ulong> Keys, ReadOnlySpan<float> Vectors)
    {
        var Dims = (int)(uint)CachedDimensions;
        EnsureCapacity((nuint)(uint)Keys.Length);
        unsafe
        {
            fixed (float* BasePtr = Vectors)
            {
                for (var I = 0; I < Keys.Length; I++)
                {
                    var VecPtr = (nint)(BasePtr + (I * Dims));
                    NativeMethods.usearch_add(
                        IndexHandle, Keys[I], VecPtr, ScalarKind.Float32, out var Error);
                    ThrowIfError(Error);
                }
            }
        }
    }

    public int Get(ulong Key, Span<float> Vector)
    {
        unsafe
        {
            fixed (float* Ptr = Vector)
            {
                var Found = NativeMethods.usearch_get(
                    IndexHandle, Key, 1, (nint)Ptr, ScalarKind.Float32, out var Error);
                ThrowIfError(Error);
                return (int)(uint)Found;
            }
        }
    }

    public int Get(ulong Key, Span<double> Vector)
    {
        unsafe
        {
            fixed (double* Ptr = Vector)
            {
                var Found = NativeMethods.usearch_get(
                    IndexHandle, Key, 1, (nint)Ptr, ScalarKind.Float64, out var Error);
                ThrowIfError(Error);
                return (int)(uint)Found;
            }
        }
    }

    public int Search(
        ReadOnlySpan<float> QueryVector, int Count,
        Span<ulong> Keys, Span<float> Distances)
    {
        unsafe
        {
            fixed (float* QPtr = QueryVector)
            {
                fixed (ulong* KPtr = Keys)
                {
                    fixed (float* DPtr = Distances)
                    {
                        var Matches = NativeMethods.usearch_search(
                            IndexHandle, (nint)QPtr, ScalarKind.Float32,
                            (nuint)(uint)Count, (nint)KPtr, (nint)DPtr, out var Error);
                        ThrowIfError(Error);
                        return (int)(uint)Matches;
                    }
                }
            }
        }
    }

    public int Search(
        ReadOnlySpan<double> QueryVector, int Count,
        Span<ulong> Keys, Span<float> Distances)
    {
        unsafe
        {
            fixed (double* QPtr = QueryVector)
            {
                fixed (ulong* KPtr = Keys)
                {
                    fixed (float* DPtr = Distances)
                    {
                        var Matches = NativeMethods.usearch_search(
                            IndexHandle, (nint)QPtr, ScalarKind.Float64,
                            (nuint)(uint)Count, (nint)KPtr, (nint)DPtr, out var Error);
                        ThrowIfError(Error);
                        return (int)(uint)Matches;
                    }
                }
            }
        }
    }

    public int Remove(ulong Key)
    {
        var Removed = NativeMethods.usearch_remove(IndexHandle, Key, out var Error);
        ThrowIfError(Error);
        return (int)(uint)Removed;
    }

    public int Rename(ulong KeyFrom, ulong KeyTo)
    {
        var Renamed = NativeMethods.usearch_rename(
            IndexHandle, KeyFrom, KeyTo, out var Error);
        ThrowIfError(Error);
        return (int)(uint)Renamed;
    }

    public void Clear()
    {
        NativeMethods.usearch_clear(IndexHandle, out var Error);
        ThrowIfError(Error);
    }
}
