// Licensed to PrTask under the MIT License.

using System.Runtime.InteropServices;

namespace PrTask.USearch;

/// <summary>
/// Managed wrapper for the USearch HNSW vector search index.
/// Provides thread-safe nearest-neighbor search over high-dimensional vectors.
/// </summary>
public sealed class USearchIndex : IDisposable
{
    private nint _index;
    private readonly nuint _cachedDimensions;

    /// <summary>
    /// Initializes a new index with the specified parameters.
    /// </summary>
    /// <param name="metricKind">Distance metric for vector comparison.</param>
    /// <param name="quantization">Scalar quantization kind for stored vectors.</param>
    /// <param name="dimensions">Number of dimensions per vector.</param>
    /// <param name="connectivity">Max connections per node in the HNSW graph (0 = default).</param>
    /// <param name="expansionAdd">Expansion factor during insertion (0 = default).</param>
    /// <param name="expansionSearch">Expansion factor during search (0 = default).</param>
    /// <param name="multi">Allow multiple vectors per key.</param>
    public USearchIndex(
        MetricKind metricKind,
        ScalarKind quantization,
        nuint dimensions,
        nuint connectivity = 0,
        nuint expansionAdd = 0,
        nuint expansionSearch = 0,
        bool multi = false)
    {
        var options = new IndexOptions
        {
            MetricKind = metricKind,
            Quantization = quantization,
            Dimensions = dimensions,
            Connectivity = connectivity,
            ExpansionAdd = expansionAdd,
            ExpansionSearch = expansionSearch,
            Multi = multi,
        };

        _index = NativeMethods.usearch_init(ref options, out nint error);
        ThrowIfError(error);
        _cachedDimensions = dimensions;
    }

    /// <summary>
    /// Initializes a new index from a previously saved file.
    /// </summary>
    /// <param name="path">File path to load from.</param>
    /// <param name="viewOnly">If true, memory-maps without copying; the file must remain accessible.</param>
    public USearchIndex(string path, bool viewOnly = false)
    {
        var options = new IndexOptions();
        _index = NativeMethods.usearch_init(ref options, out nint error);
        ThrowIfError(error);

        if (viewOnly)
        {
            NativeMethods.usearch_view(_index, path, out error);
        }
        else
        {
            NativeMethods.usearch_load(_index, path, out error);
        }

        ThrowIfError(error);
        _cachedDimensions = NativeMethods.usearch_dimensions(_index, out error);
        ThrowIfError(error);
    }

    /// <summary>Gets the number of vectors currently in the index.</summary>
    public nuint Size
    {
        get
        {
            nuint size = NativeMethods.usearch_size(_index, out nint error);
            ThrowIfError(error);
            return size;
        }
    }

    /// <summary>Gets the current capacity of the index.</summary>
    public nuint Capacity
    {
        get
        {
            nuint cap = NativeMethods.usearch_capacity(_index, out nint error);
            ThrowIfError(error);
            return cap;
        }
    }

    /// <summary>Gets the number of dimensions per vector.</summary>
    public nuint Dimensions
    {
        get
        {
            nuint dims = NativeMethods.usearch_dimensions(_index, out nint error);
            ThrowIfError(error);
            return dims;
        }
    }

    /// <summary>Gets the connectivity parameter of the HNSW graph.</summary>
    public nuint Connectivity
    {
        get
        {
            nuint conn = NativeMethods.usearch_connectivity(_index, out nint error);
            ThrowIfError(error);
            return conn;
        }
    }

    /// <summary>Gets the memory usage of the index in bytes.</summary>
    public nuint MemoryUsage
    {
        get
        {
            nuint usage = NativeMethods.usearch_memory_usage(_index, out nint error);
            ThrowIfError(error);
            return usage;
        }
    }

    /// <summary>Saves the index to a file.</summary>
    /// <param name="path">Destination file path.</param>
    public void Save(string path)
    {
        NativeMethods.usearch_save(_index, path, out nint error);
        ThrowIfError(error);
    }

    /// <summary>Checks whether the index contains a vector with the given key.</summary>
    /// <param name="key">The key to look up.</param>
    /// <returns>True if the key exists in the index.</returns>
    public bool Contains(ulong key)
    {
        bool result = NativeMethods.usearch_contains(_index, key, out nint error);
        ThrowIfError(error);
        return result;
    }

    /// <summary>Counts the number of vectors stored under a specific key.</summary>
    /// <param name="key">The key to count.</param>
    /// <returns>Number of vectors under the key.</returns>
    public nuint Count(ulong key)
    {
        nuint count = NativeMethods.usearch_count(_index, key, out nint error);
        ThrowIfError(error);
        return count;
    }

    /// <summary>Adds a float32 vector with the given key.</summary>
    /// <param name="key">Unique key for the vector.</param>
    /// <param name="vector">Vector data (must match index dimensions).</param>
    public void Add(ulong key, ReadOnlySpan<float> vector)
    {
        EnsureCapacity(1);
        unsafe
        {
            fixed (float* ptr = vector)
            {
                NativeMethods.usearch_add(_index, key, (nint)ptr, ScalarKind.Float32, out nint error);
                ThrowIfError(error);
            }
        }
    }

    /// <summary>Adds a float64 vector with the given key.</summary>
    /// <param name="key">Unique key for the vector.</param>
    /// <param name="vector">Vector data (must match index dimensions).</param>
    public void Add(ulong key, ReadOnlySpan<double> vector)
    {
        EnsureCapacity(1);
        unsafe
        {
            fixed (double* ptr = vector)
            {
                NativeMethods.usearch_add(_index, key, (nint)ptr, ScalarKind.Float64, out nint error);
                ThrowIfError(error);
            }
        }
    }

    /// <summary>Adds a batch of float32 vectors with the given keys.</summary>
    /// <param name="keys">Keys for each vector.</param>
    /// <param name="vectors">Flat array of concatenated vector data.</param>
    public void AddBatch(ReadOnlySpan<ulong> keys, ReadOnlySpan<float> vectors)
    {
        int dims = (int)(uint)_cachedDimensions;
        EnsureCapacity((nuint)(uint)keys.Length);
        unsafe
        {
            fixed (float* basePtr = vectors)
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    nint vecPtr = (nint)(basePtr + (i * dims));
                    NativeMethods.usearch_add(_index, keys[i], vecPtr, ScalarKind.Float32, out nint error);
                    ThrowIfError(error);
                }
            }
        }
    }

    /// <summary>Retrieves the float32 vector for a given key.</summary>
    /// <param name="key">The key to retrieve.</param>
    /// <param name="vector">Buffer to receive the vector (must be at least Dimensions in length).</param>
    /// <returns>Number of vectors found (0 or 1, or more for multi-key indexes).</returns>
    public int Get(ulong key, Span<float> vector)
    {
        unsafe
        {
            fixed (float* ptr = vector)
            {
                nuint found = NativeMethods.usearch_get(_index, key, 1, (nint)ptr, ScalarKind.Float32, out nint error);
                ThrowIfError(error);
                return (int)(uint)found;
            }
        }
    }

    /// <summary>Retrieves the float64 vector for a given key.</summary>
    /// <param name="key">The key to retrieve.</param>
    /// <param name="vector">Buffer to receive the vector (must be at least Dimensions in length).</param>
    /// <returns>Number of vectors found.</returns>
    public int Get(ulong key, Span<double> vector)
    {
        unsafe
        {
            fixed (double* ptr = vector)
            {
                nuint found = NativeMethods.usearch_get(_index, key, 1, (nint)ptr, ScalarKind.Float64, out nint error);
                ThrowIfError(error);
                return (int)(uint)found;
            }
        }
    }

    /// <summary>Searches for the k nearest neighbors to a float32 query vector.</summary>
    /// <param name="queryVector">The query vector.</param>
    /// <param name="count">Maximum number of results.</param>
    /// <param name="keys">Buffer to receive result keys.</param>
    /// <param name="distances">Buffer to receive result distances.</param>
    /// <returns>Actual number of matches found.</returns>
    public int Search(ReadOnlySpan<float> queryVector, int count, Span<ulong> keys, Span<float> distances)
    {
        unsafe
        {
            fixed (float* qPtr = queryVector)
            fixed (ulong* kPtr = keys)
            fixed (float* dPtr = distances)
            {
                nuint matches = NativeMethods.usearch_search(
                    _index,
                    (nint)qPtr,
                    ScalarKind.Float32,
                    (nuint)(uint)count,
                    (nint)kPtr,
                    (nint)dPtr,
                    out nint error);
                ThrowIfError(error);
                return (int)(uint)matches;
            }
        }
    }

    /// <summary>Searches for the k nearest neighbors to a float64 query vector.</summary>
    /// <param name="queryVector">The query vector.</param>
    /// <param name="count">Maximum number of results.</param>
    /// <param name="keys">Buffer to receive result keys.</param>
    /// <param name="distances">Buffer to receive result distances.</param>
    /// <returns>Actual number of matches found.</returns>
    public int Search(ReadOnlySpan<double> queryVector, int count, Span<ulong> keys, Span<float> distances)
    {
        unsafe
        {
            fixed (double* qPtr = queryVector)
            fixed (ulong* kPtr = keys)
            fixed (float* dPtr = distances)
            {
                nuint matches = NativeMethods.usearch_search(
                    _index,
                    (nint)qPtr,
                    ScalarKind.Float64,
                    (nuint)(uint)count,
                    (nint)kPtr,
                    (nint)dPtr,
                    out nint error);
                ThrowIfError(error);
                return (int)(uint)matches;
            }
        }
    }

    /// <summary>Removes the vector(s) associated with the given key.</summary>
    /// <param name="key">Key to remove.</param>
    /// <returns>Number of vectors removed.</returns>
    public int Remove(ulong key)
    {
        nuint removed = NativeMethods.usearch_remove(_index, key, out nint error);
        ThrowIfError(error);
        return (int)(uint)removed;
    }

    /// <summary>Renames a vector from one key to another.</summary>
    /// <param name="keyFrom">Current key.</param>
    /// <param name="keyTo">New key.</param>
    /// <returns>Number of vectors renamed.</returns>
    public int Rename(ulong keyFrom, ulong keyTo)
    {
        nuint renamed = NativeMethods.usearch_rename(_index, keyFrom, keyTo, out nint error);
        ThrowIfError(error);
        return (int)(uint)renamed;
    }

    /// <summary>Erases all vectors from the index.</summary>
    public void Clear()
    {
        NativeMethods.usearch_clear(_index, out nint error);
        ThrowIfError(error);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        if (_index != 0)
        {
            NativeMethods.usearch_free(_index, out _);
            _index = 0;
        }
    }

    private void EnsureCapacity(nuint additional)
    {
        nuint needed = Size + additional;
        if (Capacity < needed)
        {
            NativeMethods.usearch_reserve(_index, needed, out nint error);
            ThrowIfError(error);
        }
    }

    private static void ThrowIfError(nint error)
    {
        if (error != 0)
        {
            string? message = Marshal.PtrToStringAnsi(error);
            throw new USearchException($"USearch operation failed: {message}");
        }
    }
}
