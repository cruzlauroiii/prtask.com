using System.Runtime.InteropServices;

namespace PrTask.Whisper;

internal static partial class WhisperNative
{
    private const string LibName = "whisper";

    [LibraryImport(LibName, EntryPoint = "whisper_version")]
    internal static partial nint Version();

    [LibraryImport(LibName, EntryPoint = "whisper_init_from_file_with_params", StringMarshalling = StringMarshalling.Utf8)]
    internal static partial nint InitFromFileWithParams(string PathModel, WhisperContextParams Params);

    [LibraryImport(LibName, EntryPoint = "whisper_init_from_buffer_with_params")]
    internal static partial nint InitFromBufferWithParams(nint Buffer, nuint BufferSize, WhisperContextParams Params);

    [LibraryImport(LibName, EntryPoint = "whisper_init_with_params")]
    internal static partial nint InitWithParams(nint Loader, WhisperContextParams Params);

    [LibraryImport(LibName, EntryPoint = "whisper_init_from_file_with_params_no_state", StringMarshalling = StringMarshalling.Utf8)]
    internal static partial nint InitFromFileWithParamsNoState(string PathModel, WhisperContextParams Params);

    [LibraryImport(LibName, EntryPoint = "whisper_init_from_buffer_with_params_no_state")]
    internal static partial nint InitFromBufferWithParamsNoState(nint Buffer, nuint BufferSize, WhisperContextParams Params);

    [LibraryImport(LibName, EntryPoint = "whisper_init_with_params_no_state")]
    internal static partial nint InitWithParamsNoState(nint Loader, WhisperContextParams Params);

    [LibraryImport(LibName, EntryPoint = "whisper_init_state")]
    internal static partial nint InitState(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_ctx_init_openvino_encoder_with_state", StringMarshalling = StringMarshalling.Utf8)]
    internal static partial int CtxInitOpenvinoEncoderWithState(nint Ctx, nint State, string? ModelPath, string? Device, string? CacheDir);

    [LibraryImport(LibName, EntryPoint = "whisper_ctx_init_openvino_encoder", StringMarshalling = StringMarshalling.Utf8)]
    internal static partial int CtxInitOpenvinoEncoder(nint Ctx, string? ModelPath, string? Device, string? CacheDir);

    [LibraryImport(LibName, EntryPoint = "whisper_free")]
    internal static partial void Free(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_free_state")]
    internal static partial void FreeState(nint State);

    [LibraryImport(LibName, EntryPoint = "whisper_free_params")]
    internal static partial void FreeParams(nint Params);

    [LibraryImport(LibName, EntryPoint = "whisper_free_context_params")]
    internal static partial void FreeContextParams(nint Params);

    [LibraryImport(LibName, EntryPoint = "whisper_pcm_to_mel")]
    internal static partial int PcmToMel(nint Ctx, nint Samples, int NSamples, int NThreads);

    [LibraryImport(LibName, EntryPoint = "whisper_pcm_to_mel_with_state")]
    internal static partial int PcmToMelWithState(nint Ctx, nint State, nint Samples, int NSamples, int NThreads);

    [LibraryImport(LibName, EntryPoint = "whisper_set_mel")]
    internal static partial int SetMel(nint Ctx, nint Data, int NLen, int NMel);

    [LibraryImport(LibName, EntryPoint = "whisper_set_mel_with_state")]
    internal static partial int SetMelWithState(nint Ctx, nint State, nint Data, int NLen, int NMel);

    [LibraryImport(LibName, EntryPoint = "whisper_encode")]
    internal static partial int Encode(nint Ctx, int Offset, int NThreads);

    [LibraryImport(LibName, EntryPoint = "whisper_encode_with_state")]
    internal static partial int EncodeWithState(nint Ctx, nint State, int Offset, int NThreads);

    [LibraryImport(LibName, EntryPoint = "whisper_decode")]
    internal static partial int Decode(nint Ctx, nint Tokens, int NTokens, int NPast, int NThreads);

    [LibraryImport(LibName, EntryPoint = "whisper_decode_with_state")]
    internal static partial int DecodeWithState(nint Ctx, nint State, nint Tokens, int NTokens, int NPast, int NThreads);

    [LibraryImport(LibName, EntryPoint = "whisper_tokenize", StringMarshalling = StringMarshalling.Utf8)]
    internal static partial int Tokenize(nint Ctx, string Text, nint Tokens, int NMaxTokens);

    [LibraryImport(LibName, EntryPoint = "whisper_token_count", StringMarshalling = StringMarshalling.Utf8)]
    internal static partial int TokenCount(nint Ctx, string Text);

    [LibraryImport(LibName, EntryPoint = "whisper_lang_max_id")]
    internal static partial int LangMaxId();

    [LibraryImport(LibName, EntryPoint = "whisper_lang_id", StringMarshalling = StringMarshalling.Utf8)]
    internal static partial int LangId(string Lang);

    [LibraryImport(LibName, EntryPoint = "whisper_lang_str")]
    internal static partial nint LangStr(int Id);

    [LibraryImport(LibName, EntryPoint = "whisper_lang_str_full")]
    internal static partial nint LangStrFull(int Id);

    [LibraryImport(LibName, EntryPoint = "whisper_lang_auto_detect")]
    internal static partial int LangAutoDetect(nint Ctx, int OffsetMs, int NThreads, nint LangProbs);

    [LibraryImport(LibName, EntryPoint = "whisper_lang_auto_detect_with_state")]
    internal static partial int LangAutoDetectWithState(nint Ctx, nint State, int OffsetMs, int NThreads, nint LangProbs);

    [LibraryImport(LibName, EntryPoint = "whisper_n_len")]
    internal static partial int NLen(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_n_len_from_state")]
    internal static partial int NLenFromState(nint State);

    [LibraryImport(LibName, EntryPoint = "whisper_n_vocab")]
    internal static partial int NVocab(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_n_text_ctx")]
    internal static partial int NTextCtx(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_n_audio_ctx")]
    internal static partial int NAudioCtx(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_is_multilingual")]
    internal static partial int IsMultilingual(nint Ctx);
}
