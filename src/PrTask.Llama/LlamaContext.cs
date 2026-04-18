namespace PrTask.Llama;

public sealed class LlamaContext : IDisposable
{
    private nint ContextHandle;

    private LlamaContext(nint Handle, LlamaModel Model)
    {
        ContextHandle = Handle;
        this.Model = Model;
    }

    public LlamaModel Model { get; }

    internal nint Handle
    {
        get
        {
            ObjectDisposedException.ThrowIf(ContextHandle == nint.Zero, this);
            return ContextHandle;
        }
    }

    public static LlamaContext Create(
        LlamaModel Model,
        uint ContextSize = 0,
        uint BatchSize = LlamaConstants.DefaultBatchSize,
        int Threads = LlamaConstants.AutoThreads,
        bool FlashAttn = false)
    {
        var CtxParams = NativeMethods.llama_context_default_params();
        CtxParams.NCtx = ContextSize;
        CtxParams.NBatch = BatchSize;
        CtxParams.NUbatch = BatchSize;

        if (Threads > 0)
        {
            CtxParams.NThreads = Threads;
            CtxParams.NThreadsBatch = Threads;
        }

        if (FlashAttn)
        {
            CtxParams.FlashAttnType = LlamaFlashAttnType.Enabled;
        }

        var Handle = NativeMethods.llama_init_from_model(Model.Handle, CtxParams);
        return Handle == nint.Zero
            ? throw new LlamaException(LlamaConstants.ErrorContextCreate)
            : new LlamaContext(Handle, Model);
    }

    public uint NCtx => NativeMethods.llama_n_ctx(Handle);

    public uint NBatch => NativeMethods.llama_n_batch(Handle);

    public unsafe int Decode(ReadOnlySpan<int> Tokens)
    {
        fixed (int* Ptr = Tokens)
        {
            var Batch = NativeMethods.llama_batch_get_one((nint)Ptr, Tokens.Length);
            return NativeMethods.llama_decode(Handle, Batch);
        }
    }

    public unsafe ReadOnlySpan<float> GetLogits(int Index = LlamaConstants.LastOutput)
    {
        var Ptr = NativeMethods.llama_get_logits_ith(Handle, Index);
        if (Ptr == nint.Zero)
        {
            return [];
        }

        var NVocab = Model.VocabSize;
        return new ReadOnlySpan<float>((void*)Ptr, NVocab);
    }

    public unsafe ReadOnlySpan<float> GetEmbeddings(int Index = LlamaConstants.LastOutput)
    {
        var Ptr = NativeMethods.llama_get_embeddings_ith(Handle, Index);
        if (Ptr == nint.Zero)
        {
            return [];
        }

        var NEmbd = Model.EmbeddingDimension;
        return new ReadOnlySpan<float>((void*)Ptr, NEmbd);
    }

    public void ClearMemory(bool ClearData = false)
    {
        var Mem = NativeMethods.llama_get_memory(Handle);
        if (Mem != nint.Zero)
        {
            NativeMethods.llama_memory_clear(Mem, ClearData);
        }
    }

    public void SetThreads(int Threads, int BatchThreads)
    {
        NativeMethods.llama_set_n_threads(Handle, Threads, BatchThreads);
    }

    public void Dispose()
    {
        if (ContextHandle != nint.Zero)
        {
            NativeMethods.llama_free(ContextHandle);
            ContextHandle = nint.Zero;
        }
    }
}
