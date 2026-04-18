using System.Runtime.InteropServices;

namespace PrTask.Whisper;

internal static partial class WhisperNative
{
    [LibraryImport(LibName, EntryPoint = "whisper_full")]
    internal static partial int Full(nint Ctx, nint Params, nint Samples, int NSamples);

    [LibraryImport(LibName, EntryPoint = "whisper_full_with_state")]
    internal static partial int FullWithState(nint Ctx, nint State, nint Params, nint Samples, int NSamples);

    [LibraryImport(LibName, EntryPoint = "whisper_full_parallel")]
    internal static partial int FullParallel(nint Ctx, nint Params, nint Samples, int NSamples, int NProcessors);

    [LibraryImport(LibName, EntryPoint = "whisper_full_n_segments")]
    internal static partial int FullNSegments(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_full_n_segments_from_state")]
    internal static partial int FullNSegmentsFromState(nint State);

    [LibraryImport(LibName, EntryPoint = "whisper_full_lang_id")]
    internal static partial int FullLangId(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_full_lang_id_from_state")]
    internal static partial int FullLangIdFromState(nint State);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_segment_t0")]
    internal static partial long FullGetSegmentT0(nint Ctx, int ISegment);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_segment_t0_from_state")]
    internal static partial long FullGetSegmentT0FromState(nint State, int ISegment);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_segment_t1")]
    internal static partial long FullGetSegmentT1(nint Ctx, int ISegment);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_segment_t1_from_state")]
    internal static partial long FullGetSegmentT1FromState(nint State, int ISegment);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_segment_speaker_turn_next")]
    internal static partial byte FullGetSegmentSpeakerTurnNext(nint Ctx, int ISegment);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_segment_speaker_turn_next_from_state")]
    internal static partial byte FullGetSegmentSpeakerTurnNextFromState(nint State, int ISegment);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_segment_text")]
    internal static partial nint FullGetSegmentText(nint Ctx, int ISegment);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_segment_text_from_state")]
    internal static partial nint FullGetSegmentTextFromState(nint State, int ISegment);

    [LibraryImport(LibName, EntryPoint = "whisper_full_n_tokens")]
    internal static partial int FullNTokens(nint Ctx, int ISegment);

    [LibraryImport(LibName, EntryPoint = "whisper_full_n_tokens_from_state")]
    internal static partial int FullNTokensFromState(nint State, int ISegment);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_token_text")]
    internal static partial nint FullGetTokenText(nint Ctx, int ISegment, int IToken);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_token_text_from_state")]
    internal static partial nint FullGetTokenTextFromState(nint Ctx, nint State, int ISegment, int IToken);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_token_id")]
    internal static partial int FullGetTokenId(nint Ctx, int ISegment, int IToken);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_token_id_from_state")]
    internal static partial int FullGetTokenIdFromState(nint State, int ISegment, int IToken);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_token_data")]
    internal static partial WhisperTokenData FullGetTokenData(nint Ctx, int ISegment, int IToken);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_token_data_from_state")]
    internal static partial WhisperTokenData FullGetTokenDataFromState(nint State, int ISegment, int IToken);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_token_p")]
    internal static partial float FullGetTokenP(nint Ctx, int ISegment, int IToken);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_token_p_from_state")]
    internal static partial float FullGetTokenPFromState(nint State, int ISegment, int IToken);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_segment_no_speech_prob")]
    internal static partial float FullGetSegmentNoSpeechProb(nint Ctx, int ISegment);

    [LibraryImport(LibName, EntryPoint = "whisper_full_get_segment_no_speech_prob_from_state")]
    internal static partial float FullGetSegmentNoSpeechProbFromState(nint State, int ISegment);
}
