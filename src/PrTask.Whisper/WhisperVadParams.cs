using System.Runtime.InteropServices;

namespace PrTask.Whisper;

[StructLayout(LayoutKind.Sequential)]
public struct WhisperVadParams : IEquatable<WhisperVadParams>
{
    public float Threshold;
    public int MinSpeechDurationMs;
    public int MinSilenceDurationMs;
    public float MaxSpeechDurationS;
    public int SpeechPadMs;
    public float SamplesOverlap;
    public readonly bool Equals(WhisperVadParams Other) =>
        BitConverter.SingleToInt32Bits(Threshold) == BitConverter.SingleToInt32Bits(Other.Threshold) &&
        MinSpeechDurationMs == Other.MinSpeechDurationMs &&
        MinSilenceDurationMs == Other.MinSilenceDurationMs &&
        BitConverter.SingleToInt32Bits(MaxSpeechDurationS) == BitConverter.SingleToInt32Bits(Other.MaxSpeechDurationS) &&
        SpeechPadMs == Other.SpeechPadMs &&
        BitConverter.SingleToInt32Bits(SamplesOverlap) == BitConverter.SingleToInt32Bits(Other.SamplesOverlap);
    public override readonly bool Equals(object? Obj) => Obj is WhisperVadParams Other && Equals(Other);
    public override readonly int GetHashCode() =>
        HashCode.Combine(Threshold, MinSpeechDurationMs, MinSilenceDurationMs, MaxSpeechDurationS, SpeechPadMs, SamplesOverlap);
    public static bool operator ==(WhisperVadParams Left, WhisperVadParams Right) => Left.Equals(Right);
    public static bool operator !=(WhisperVadParams Left, WhisperVadParams Right) => !Left.Equals(Right);
}
