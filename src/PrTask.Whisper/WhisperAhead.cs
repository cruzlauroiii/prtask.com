using System.Runtime.InteropServices;

namespace PrTask.Whisper;

[StructLayout(LayoutKind.Sequential)]
public readonly struct WhisperAhead(int NTextLayer, int NHead) : IEquatable<WhisperAhead>
{
    public readonly int NTextLayer = NTextLayer;
    public readonly int NHead = NHead;
    public bool Equals(WhisperAhead Other) => NTextLayer == Other.NTextLayer && NHead == Other.NHead;
    public override bool Equals(object? Obj) => Obj is WhisperAhead Other && Equals(Other);
    public override int GetHashCode() => HashCode.Combine(NTextLayer, NHead);
    public static bool operator ==(WhisperAhead Left, WhisperAhead Right) => Left.Equals(Right);
    public static bool operator !=(WhisperAhead Left, WhisperAhead Right) => !Left.Equals(Right);
}
