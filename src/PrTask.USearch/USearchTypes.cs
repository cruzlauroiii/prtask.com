// Licensed to PrTask under the MIT License.

using System.Runtime.InteropServices;

namespace PrTask.USearch;

/// <summary>
/// Specifies the kind of metric used for distance calculation between vectors.
/// </summary>
public enum MetricKind : uint
{
    /// <summary>Unknown metric kind.</summary>
    Unknown = 0,

    /// <summary>Cosine similarity.</summary>
    Cos = 1,

    /// <summary>Inner product.</summary>
    InnerProduct = 2,

    /// <summary>Squared Euclidean distance.</summary>
    L2Squared = 3,

    /// <summary>Haversine distance.</summary>
    Haversine = 4,

    /// <summary>Kullback-Leibler divergence.</summary>
    Divergence = 5,

    /// <summary>Pearson correlation.</summary>
    Pearson = 6,

    /// <summary>Jaccard index.</summary>
    Jaccard = 7,

    /// <summary>Hamming distance.</summary>
    Hamming = 8,

    /// <summary>Tanimoto coefficient.</summary>
    Tanimoto = 9,

    /// <summary>Sorensen-Dice coefficient.</summary>
    Sorensen = 10,
}

/// <summary>
/// Specifies the scalar kind used for quantization of vector data during indexing.
/// </summary>
public enum ScalarKind : uint
{
    /// <summary>Unknown scalar kind.</summary>
    Unknown = 0,

    /// <summary>32-bit floating point.</summary>
    Float32 = 1,

    /// <summary>64-bit floating point.</summary>
    Float64 = 2,

    /// <summary>16-bit floating point.</summary>
    Float16 = 3,

    /// <summary>8-bit signed integer.</summary>
    Int8 = 4,

    /// <summary>1-bit binary.</summary>
    Bits1 = 5,

    /// <summary>16-bit brain floating point.</summary>
    BFloat16 = 6,
}

/// <summary>
/// Initialization options for creating a USearch index.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct IndexOptions
{
    /// <summary>The metric kind used for distance calculation between vectors.</summary>
    public MetricKind MetricKind;

    /// <summary>Optional custom metric function pointer (not currently supported in managed code).</summary>
    public nint Metric;

    /// <summary>The scalar kind used for quantization of vector data during indexing.</summary>
    public ScalarKind Quantization;

    /// <summary>The number of dimensions in the vectors to be indexed.</summary>
    public nuint Dimensions;

    /// <summary>Optional connectivity parameter that limits connections-per-node in the graph.</summary>
    public nuint Connectivity;

    /// <summary>Optional expansion factor used for index construction when adding vectors.</summary>
    public nuint ExpansionAdd;

    /// <summary>Optional expansion factor used during search operations.</summary>
    public nuint ExpansionSearch;

    /// <summary>When set, allows multiple vectors to map to the same key.</summary>
    [MarshalAs(UnmanagedType.I1)]
    public bool Multi;
}
