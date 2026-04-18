using System.Runtime.InteropServices;

namespace PrTask.Whisper;

internal static partial class WhisperNative
{
    [LibraryImport(LibName, EntryPoint = "whisper_vad_default_params")]
    internal static partial WhisperVadParams VadDefaultParams();

    [LibraryImport(LibName, EntryPoint = "whisper_vad_default_context_params")]
    internal static partial WhisperVadContextParams VadDefaultContextParams();

    [LibraryImport(LibName, EntryPoint = "whisper_vad_init_from_file_with_params", StringMarshalling = StringMarshalling.Utf8)]
    internal static partial nint VadInitFromFileWithParams(string PathModel, WhisperVadContextParams Params);

    [LibraryImport(LibName, EntryPoint = "whisper_vad_init_with_params")]
    internal static partial nint VadInitWithParams(nint Loader, WhisperVadContextParams Params);

    [LibraryImport(LibName, EntryPoint = "whisper_vad_detect_speech")]
    internal static partial byte VadDetectSpeech(nint Vctx, nint Samples, int NSamples);

    [LibraryImport(LibName, EntryPoint = "whisper_vad_n_probs")]
    internal static partial int VadNProbs(nint Vctx);

    [LibraryImport(LibName, EntryPoint = "whisper_vad_probs")]
    internal static partial nint VadProbs(nint Vctx);

    [LibraryImport(LibName, EntryPoint = "whisper_vad_segments_from_probs")]
    internal static partial nint VadSegmentsFromProbs(nint Vctx, WhisperVadParams Params);

    [LibraryImport(LibName, EntryPoint = "whisper_vad_segments_from_samples")]
    internal static partial nint VadSegmentsFromSamples(nint Vctx, WhisperVadParams Params, nint Samples, int NSamples);

    [LibraryImport(LibName, EntryPoint = "whisper_vad_segments_n_segments")]
    internal static partial int VadSegmentsNSegments(nint Segments);

    [LibraryImport(LibName, EntryPoint = "whisper_vad_segments_get_segment_t0")]
    internal static partial float VadSegmentsGetSegmentT0(nint Segments, int ISegment);

    [LibraryImport(LibName, EntryPoint = "whisper_vad_segments_get_segment_t1")]
    internal static partial float VadSegmentsGetSegmentT1(nint Segments, int ISegment);

    [LibraryImport(LibName, EntryPoint = "whisper_vad_free_segments")]
    internal static partial void VadFreeSegments(nint Segments);

    [LibraryImport(LibName, EntryPoint = "whisper_vad_free")]
    internal static partial void VadFree(nint Ctx);

    [LibraryImport(LibName, EntryPoint = "whisper_bench_memcpy")]
    internal static partial int BenchMemcpy(int NThreads);

    [LibraryImport(LibName, EntryPoint = "whisper_bench_memcpy_str")]
    internal static partial nint BenchMemcpyStr(int NThreads);

    [LibraryImport(LibName, EntryPoint = "whisper_bench_ggml_mul_mat")]
    internal static partial int BenchGgmlMulMat(int NThreads);

    [LibraryImport(LibName, EntryPoint = "whisper_bench_ggml_mul_mat_str")]
    internal static partial nint BenchGgmlMulMatStr(int NThreads);

    [LibraryImport(LibName, EntryPoint = "whisper_log_set")]
    internal static partial void LogSet(nint LogCallback, nint UserData);
}
