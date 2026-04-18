using System.Runtime.InteropServices;

namespace PrTask.Whisper;

[StructLayout(LayoutKind.Sequential)]
public struct WhisperContextParams : IEquatable<WhisperContextParams>
{
    public bool UseGpu;
    public bool FlashAttn;
    public int GpuDevice;
    public bool DtwTokenTimestamps;
    public WhisperAlignmentHeadsPreset DtwAheadsPreset;
    public int DtwNTop;
    public WhisperAheads DtwAheads;
    public nuint DtwMemSize;
    public readonly bool Equals(WhisperContextParams Other) =>
        UseGpu == Other.UseGpu && FlashAttn == Other.FlashAttn &&
        GpuDevice == Other.GpuDevice && DtwTokenTimestamps == Other.DtwTokenTimestamps &&
        DtwAheadsPreset == Other.DtwAheadsPreset && DtwNTop == Other.DtwNTop &&
        DtwAheads == Other.DtwAheads && DtwMemSize == Other.DtwMemSize;
    public override readonly bool Equals(object? Obj) => Obj is WhisperContextParams Other && Equals(Other);
    public override readonly int GetHashCode() =>
        HashCode.Combine(UseGpu, FlashAttn, GpuDevice, DtwTokenTimestamps, DtwAheadsPreset, DtwNTop, DtwAheads, DtwMemSize);
    public static bool operator ==(WhisperContextParams Left, WhisperContextParams Right) => Left.Equals(Right);
    public static bool operator !=(WhisperContextParams Left, WhisperContextParams Right) => !Left.Equals(Right);
}
