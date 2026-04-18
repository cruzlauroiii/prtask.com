using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace PrTask.Llama;

public enum LlamaVocabType
{
    None = 0,
    Spm = 1,
    Bpe = 2,
    Wpm = 3,
    Ugm = 4,
    Rwkv = 5,
    Plamo2 = 6,
}

public enum LlamaTokenType
{
    Undefined = 0,
    Normal = 1,
    Unknown = 2,
    Control = 3,
    UserDefined = 4,
    Unused = 5,
    Byte = 6,
}

public enum LlamaFType
{
    AllF32 = 0,
    MostlyF16 = 1,
    MostlyQ40 = 2,
    MostlyQ41 = 3,
    MostlyQ80 = 7,
    MostlyQ50 = 8,
    MostlyQ51 = 9,
    MostlyQ2K = 10,
    MostlyQ3KS = 11,
    MostlyQ3KM = 12,
    MostlyQ3KL = 13,
    MostlyQ4KS = 14,
    MostlyQ4KM = 15,
    MostlyQ5KS = 16,
    MostlyQ5KM = 17,
    MostlyQ6K = 18,
    MostlyBF16 = 32,
    Guessed = 1024,
}

public enum LlamaRopeScalingType
{
    Unspecified = -1,
    None = 0,
    Linear = 1,
    Yarn = 2,
    LongRope = 3,
}

public enum LlamaPoolingType
{
    Unspecified = -1,
    None = 0,
    Mean = 1,
    Cls = 2,
    Last = 3,
    Rank = 4,
}

public enum LlamaAttentionType
{
    Unspecified = -1,
    Causal = 0,
    NonCausal = 1,
}

public enum LlamaFlashAttnType
{
    Auto = -1,
    Disabled = 0,
    Enabled = 1,
}

public enum LlamaSplitMode
{
    None = 0,
    Layer = 1,
    Row = 2,
}

[SuppressMessage("CA1815", "CA1815", Justification = "Interop struct, not used for equality")]
[StructLayout(LayoutKind.Sequential)]
public struct LlamaTokenData
{
    public int Id;
    public float Logit;
    public float P;
}

[SuppressMessage("CA1815", "CA1815", Justification = "Interop struct, not used for equality")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct LlamaBatch
{
    public int NTokens;
    public int* Token;
    public float* Embd;
    public int* Pos;
    public int* NSeqId;
    public int** SeqId;
    public sbyte* Logits;
}

[SuppressMessage("CA1815", "CA1815", Justification = "Interop struct, not used for equality")]
[StructLayout(LayoutKind.Sequential)]
public struct LlamaChatMessage
{
    public nint Role;
    public nint Content;
}

[SuppressMessage("CA1815", "CA1815", Justification = "Interop struct, not used for equality")]
[StructLayout(LayoutKind.Sequential)]
public struct LlamaSamplerChainParams
{
    public bool NoPerf;
}
