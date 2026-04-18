using System.Runtime.InteropServices;

namespace PrTask.Whisper;

[StructLayout(LayoutKind.Sequential)]
public readonly struct WhisperGrammarElement(WhisperGreType Type, uint Value) : IEquatable<WhisperGrammarElement>
{
    public readonly WhisperGreType Type = Type;
    public readonly uint Value = Value;
    public bool Equals(WhisperGrammarElement Other) => Type == Other.Type && Value == Other.Value;
    public override bool Equals(object? Obj) => Obj is WhisperGrammarElement Other && Equals(Other);
    public override int GetHashCode() => HashCode.Combine(Type, Value);
    public static bool operator ==(WhisperGrammarElement Left, WhisperGrammarElement Right) => Left.Equals(Right);
    public static bool operator !=(WhisperGrammarElement Left, WhisperGrammarElement Right) => !Left.Equals(Right);
}
