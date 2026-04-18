using System.Runtime.InteropServices;

namespace PrTask.Whisper;

[StructLayout(LayoutKind.Sequential)]
public struct WhisperVadContextParams : IEquatable<WhisperVadContextParams>
{
    public int NThreads;
    public bool UseGpu;
    public int GpuDevice;
    public readonly bool Equals(WhisperVadContextParams Other) =>
        NThreads == Other.NThreads && UseGpu == Other.UseGpu && GpuDevice == Other.GpuDevice;
    public override readonly bool Equals(object? Obj) => Obj is WhisperVadContextParams Other && Equals(Other);
    public override readonly int GetHashCode() => HashCode.Combine(NThreads, UseGpu, GpuDevice);
    public static bool operator ==(WhisperVadContextParams Left, WhisperVadContextParams Right) => Left.Equals(Right);
    public static bool operator !=(WhisperVadContextParams Left, WhisperVadContextParams Right) => !Left.Equals(Right);
}
