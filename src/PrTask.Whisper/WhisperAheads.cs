using System.Runtime.InteropServices;

namespace PrTask.Whisper;

[StructLayout(LayoutKind.Sequential)]
public readonly struct WhisperAheads(nuint NHeads, nint Heads) : IEquatable<WhisperAheads>
{
    public readonly nuint NHeads = NHeads;
    public readonly nint Heads = Heads;
    public bool Equals(WhisperAheads Other) => NHeads == Other.NHeads && Heads == Other.Heads;
    public override bool Equals(object? Obj) => Obj is WhisperAheads Other && Equals(Other);
    public override int GetHashCode() => HashCode.Combine(NHeads, Heads);
    public static bool operator ==(WhisperAheads Left, WhisperAheads Right) => Left.Equals(Right);
    public static bool operator !=(WhisperAheads Left, WhisperAheads Right) => !Left.Equals(Right);
}
