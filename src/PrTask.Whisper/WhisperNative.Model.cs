using System.Runtime.InteropServices;

namespace PrTask.Whisper;

internal static partial class WhisperNative
{
    [LibraryImport(LibName, EntryPoint = "whisper_model_n_vocab")]
    internal static partial int ModelNVocab(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_model_n_audio_ctx")]
    internal static partial int ModelNAudioCtx(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_model_n_audio_state")]
    internal static partial int ModelNAudioState(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_model_n_audio_head")]
    internal static partial int ModelNAudioHead(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_model_n_audio_layer")]
    internal static partial int ModelNAudioLayer(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_model_n_text_ctx")]
    internal static partial int ModelNTextCtx(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_model_n_text_state")]
    internal static partial int ModelNTextState(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_model_n_text_head")]
    internal static partial int ModelNTextHead(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_model_n_text_layer")]
    internal static partial int ModelNTextLayer(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_model_n_mels")]
    internal static partial int ModelNMels(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_model_ftype")]
    internal static partial int ModelFtype(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_model_type")]
    internal static partial int ModelType(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_get_logits")]
    internal static partial nint GetLogits(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_get_logits_from_state")]
    internal static partial nint GetLogitsFromState(nint State);

    [LibraryImport(LibName, EntryPoint = "whisper_token_to_str")]
    internal static partial nint TokenToStr(nint Ctx, int Token);

    [LibraryImport(LibName, EntryPoint = "whisper_model_type_readable")]
    internal static partial nint ModelTypeReadable(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_token_eot")]
    internal static partial int TokenEot(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_token_sot")]
    internal static partial int TokenSot(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_token_solm")]
    internal static partial int TokenSolm(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_token_prev")]
    internal static partial int TokenPrev(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_token_nosp")]
    internal static partial int TokenNosp(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_token_not")]
    internal static partial int TokenNot(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_token_beg")]
    internal static partial int TokenBeg(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_token_lang")]
    internal static partial int TokenLang(nint Ctx, int LangId);

    [LibraryImport(LibName, EntryPoint = "whisper_token_translate")]
    internal static partial int TokenTranslate(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_token_transcribe")]
    internal static partial int TokenTranscribe(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_get_timings")]
    internal static partial nint GetTimings(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_print_timings")]
    internal static partial void PrintTimings(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_reset_timings")]
    internal static partial void ResetTimings(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_print_system_info")]
    internal static partial nint PrintSystemInfo();

    [LibraryImport(LibName, EntryPoint = "whisper_context_default_params_by_ref")]
    internal static partial nint ContextDefaultParamsByRef();

    [LibraryImport(LibName, EntryPoint = "whisper_context_default_params")]
    internal static partial WhisperContextParams ContextDefaultParams();

    [LibraryImport(LibName, EntryPoint = "whisper_full_default_params_by_ref")]
    internal static partial nint FullDefaultParamsByRef(WhisperSamplingStrategy Strategy);
}
