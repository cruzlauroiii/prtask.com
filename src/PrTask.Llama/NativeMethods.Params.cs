using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace PrTask.Llama;

[SuppressMessage("CA1815", "CA1815", Justification = "Interop struct, not used for equality")]
[StructLayout(LayoutKind.Sequential)]
internal struct LlamaModelParams
{
    public nint Devices;
    public nint TensorBuftOverrides;
    public int NGpuLayers;
    public LlamaSplitMode SplitMode;
    public int MainGpu;
    public nint TensorSplit;
    public nint ProgressCallback;
    public nint ProgressCallbackUserData;
    public nint KvOverrides;
    public bool VocabOnly;
    public bool UseMmap;
    public bool UseDirectIo;
    public bool UseMlock;
    public bool CheckTensors;
    public bool UseExtraBufferTypes;
    public bool NoHost;
    public bool NoAlloc;
}

[SuppressMessage("CA1815", "CA1815", Justification = "Interop struct, not used for equality")]
[StructLayout(LayoutKind.Sequential)]
internal struct LlamaContextParams
{
    public uint NCtx;
    public uint NBatch;
    public uint NUbatch;
    public uint NSeqMax;
    public int NThreads;
    public int NThreadsBatch;
    public LlamaRopeScalingType RopeScalingType;
    public LlamaPoolingType PoolingType;
    public LlamaAttentionType AttentionType;
    public LlamaFlashAttnType FlashAttnType;
    public float RopeFreqBase;
    public float RopeFreqScale;
    public float YarnExtFactor;
    public float YarnAttnFactor;
    public float YarnBetaFast;
    public float YarnBetaSlow;
    public uint YarnOrigCtx;
    public float DefragThreshold;
    public nint CbEval;
    public nint CbEvalUserData;
    public int TypeK;
    public int TypeV;
    public nint AbortCallback;
    public nint AbortCallbackData;
    public bool Embeddings;
    public bool OffloadKqv;
    public bool NoPerf;
    public bool OpOffload;
    public bool SwaFull;
    public bool KvUnified;
    public nint Samplers;
    public nuint NSamplers;
}
