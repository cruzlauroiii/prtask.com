using System.Runtime.InteropServices;

namespace PrTask.Whisper;

[StructLayout(LayoutKind.Sequential)]
public readonly struct WhisperTimings : IEquatable<WhisperTimings>
{
    public readonly float SampleMs;
    public readonly float EncodeMs;
    public readonly float DecodeMs;
    public readonly float BatchdMs;
    public readonly float PromptMs;
    public bool Equals(WhisperTimings Other) =>
        BitConverter.SingleToInt32Bits(SampleMs) == BitConverter.SingleToInt32Bits(Other.SampleMs) &&
        BitConverter.SingleToInt32Bits(EncodeMs) == BitConverter.SingleToInt32Bits(Other.EncodeMs) &&
        BitConverter.SingleToInt32Bits(DecodeMs) == BitConverter.SingleToInt32Bits(Other.DecodeMs) &&
        BitConverter.SingleToInt32Bits(BatchdMs) == BitConverter.SingleToInt32Bits(Other.BatchdMs) &&
        BitConverter.SingleToInt32Bits(PromptMs) == BitConverter.SingleToInt32Bits(Other.PromptMs);
    public override bool Equals(object? Obj) => Obj is WhisperTimings Other && Equals(Other);
    public override int GetHashCode() => HashCode.Combine(SampleMs, EncodeMs, DecodeMs, BatchdMs, PromptMs);
    public static bool operator ==(WhisperTimings Left, WhisperTimings Right) => Left.Equals(Right);
    public static bool operator !=(WhisperTimings Left, WhisperTimings Right) => !Left.Equals(Right);
}
