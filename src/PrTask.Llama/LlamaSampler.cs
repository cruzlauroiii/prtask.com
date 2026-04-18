namespace PrTask.Llama;

public sealed class LlamaSampler : IDisposable
{
    private nint SamplerHandle;

    private LlamaSampler(nint Handle)
    {
        SamplerHandle = Handle;
    }

    internal nint Handle
    {
        get
        {
            ObjectDisposedException.ThrowIf(SamplerHandle == nint.Zero, this);
            return SamplerHandle;
        }
    }

    public static LlamaSampler CreateChain()
    {
        var ChainParams = NativeMethods.llama_sampler_chain_default_params();
        var Handle = NativeMethods.llama_sampler_chain_init(ChainParams);
        return Handle == nint.Zero
            ? throw new LlamaException(LlamaConstants.ErrorSamplerChainCreate)
            : new LlamaSampler(Handle);
    }

    public LlamaSampler AddGreedy()
    {
        NativeMethods.llama_sampler_chain_add(Handle, NativeMethods.llama_sampler_init_greedy());
        return this;
    }

    public LlamaSampler AddDist(uint Seed = LlamaConstants.DefaultSeed)
    {
        NativeMethods.llama_sampler_chain_add(Handle, NativeMethods.llama_sampler_init_dist(Seed));
        return this;
    }

    public LlamaSampler AddTopK(int K)
    {
        NativeMethods.llama_sampler_chain_add(Handle, NativeMethods.llama_sampler_init_top_k(K));
        return this;
    }

    public LlamaSampler AddTopP(float P, nuint MinKeep = 1)
    {
        NativeMethods.llama_sampler_chain_add(Handle, NativeMethods.llama_sampler_init_top_p(P, MinKeep));
        return this;
    }

    public LlamaSampler AddMinP(float P, nuint MinKeep = 1)
    {
        NativeMethods.llama_sampler_chain_add(Handle, NativeMethods.llama_sampler_init_min_p(P, MinKeep));
        return this;
    }

    public LlamaSampler AddTemperature(float Temperature)
    {
        NativeMethods.llama_sampler_chain_add(Handle, NativeMethods.llama_sampler_init_temp(Temperature));
        return this;
    }

    public LlamaSampler AddPenalties(
        int LastN = LlamaConstants.DefaultPenaltyLastN,
        float Repeat = LlamaConstants.DefaultRepeatPenalty,
        float Frequency = 0.0f,
        float Presence = 0.0f)
    {
        NativeMethods.llama_sampler_chain_add(Handle, NativeMethods.llama_sampler_init_penalties(LastN, Repeat, Frequency, Presence));
        return this;
    }

    public int Sample(LlamaContext Context, int Index = LlamaConstants.LastOutput)
    {
        return NativeMethods.llama_sampler_sample(Handle, Context.Handle, Index);
    }

    public void Accept(int Token)
    {
        NativeMethods.llama_sampler_accept(Handle, Token);
    }

    public void Reset()
    {
        NativeMethods.llama_sampler_reset(Handle);
    }

    public void Dispose()
    {
        if (SamplerHandle != nint.Zero)
        {
            NativeMethods.llama_sampler_free(SamplerHandle);
            SamplerHandle = nint.Zero;
        }
    }
}
