using System.Runtime.InteropServices;
using System.Text;

namespace PrTask.Llama;

public sealed class LlamaModel : IDisposable
{
    private nint ModelHandle;

    private LlamaModel(nint Handle)
    {
        ModelHandle = Handle;
    }

    internal nint Handle
    {
        get
        {
            ObjectDisposedException.ThrowIf(ModelHandle == nint.Zero, this);
            return ModelHandle;
        }
    }

    public static LlamaModel LoadFromFile(string Path, int NGpuLayers = 0)
    {
        var ModelParams = NativeMethods.llama_model_default_params();
        ModelParams.NGpuLayers = NGpuLayers;

        var Handle = NativeMethods.llama_model_load_from_file(Path, ModelParams);
        return Handle == nint.Zero
            ? throw new LlamaException(LlamaConstants.ErrorModelLoad)
            : new LlamaModel(Handle);
    }

    public int ContextTrainLength => NativeMethods.llama_model_n_ctx_train(Handle);

    public int EmbeddingDimension => NativeMethods.llama_model_n_embd(Handle);

    public int LayerCount => NativeMethods.llama_model_n_layer(Handle);

    public int HeadCount => NativeMethods.llama_model_n_head(Handle);

    public ulong SizeBytes => NativeMethods.llama_model_size(Handle);

    public ulong ParameterCount => NativeMethods.llama_model_n_params(Handle);

    public bool HasEncoder => NativeMethods.llama_model_has_encoder(Handle);

    public bool HasDecoder => NativeMethods.llama_model_has_decoder(Handle);

    public bool IsRecurrent => NativeMethods.llama_model_is_recurrent(Handle);

    internal nint VocabHandle => NativeMethods.llama_model_get_vocab(Handle);

    public int VocabSize => NativeMethods.llama_vocab_n_tokens(VocabHandle);

    public int BosToken => NativeMethods.llama_vocab_bos(VocabHandle);

    public int EosToken => NativeMethods.llama_vocab_eos(VocabHandle);

    public unsafe string GetDescription()
    {
        var Buf = stackalloc byte[LlamaConstants.ModelDescBufferSize];
        var Len = NativeMethods.llama_model_desc(Handle, (nint)Buf, (nuint)LlamaConstants.ModelDescBufferSize);
        return Len > 0 ? Encoding.UTF8.GetString(Buf, Len) : string.Empty;
    }

    public string? GetChatTemplate()
    {
        var Ptr = NativeMethods.llama_model_chat_template(Handle, null);
        return Ptr == nint.Zero ? null : Marshal.PtrToStringUTF8(Ptr);
    }

    public unsafe string? GetMetadata(string Key)
    {
        var Buf = stackalloc byte[LlamaConstants.MetadataBufferSize];
        var Len = NativeMethods.llama_model_meta_val_str(Handle, Key, (nint)Buf, (nuint)LlamaConstants.MetadataBufferSize);
        return Len >= 0 ? Encoding.UTF8.GetString(Buf, Len) : null;
    }

    public unsafe int[] Tokenize(string Text, bool AddSpecial = true, bool ParseSpecial = false)
    {
        var Vocab = VocabHandle;

        var NTokens = NativeMethods.llama_tokenize(Vocab, Text, Text.Length, nint.Zero, 0, AddSpecial, ParseSpecial);
        NTokens = Math.Abs(NTokens);

        var Tokens = new int[NTokens];
        fixed (int* Ptr = Tokens)
        {
            var Actual = NativeMethods.llama_tokenize(Vocab, Text, Text.Length, (nint)Ptr, NTokens, AddSpecial, ParseSpecial);
            if (Actual < 0)
            {
                throw new LlamaException(LlamaConstants.ErrorTokenization);
            }

            if (Actual < NTokens)
            {
                Array.Resize(ref Tokens, Actual);
            }
        }

        return Tokens;
    }

    public unsafe string TokenToText(int Token, bool Special = false)
    {
        var Vocab = VocabHandle;
        var Buf = stackalloc byte[LlamaConstants.TokenTextBufferSize];
        var Len = NativeMethods.llama_token_to_piece(Vocab, Token, (nint)Buf, LlamaConstants.TokenTextBufferSize, 0, Special);
        return Len > 0 ? Encoding.UTF8.GetString(Buf, Len) : string.Empty;
    }

    public bool IsEndOfGeneration(int Token)
    {
        return NativeMethods.llama_vocab_is_eog(VocabHandle, Token);
    }

    public void Dispose()
    {
        if (ModelHandle != nint.Zero)
        {
            NativeMethods.llama_model_free(ModelHandle);
            ModelHandle = nint.Zero;
        }
    }
}
