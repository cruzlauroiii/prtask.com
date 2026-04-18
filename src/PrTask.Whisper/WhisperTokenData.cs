using System.Runtime.InteropServices;

namespace PrTask.Whisper;

[StructLayout(LayoutKind.Sequential)]
public readonly struct WhisperTokenData : IEquatable<WhisperTokenData>
{
    public readonly int Id;
    public readonly int Tid;
    public readonly float P;
    public readonly float Plog;
    public readonly float Pt;
    public readonly float Ptsum;
    public readonly long T0;
    public readonly long T1;
    public readonly long TDtw;
    public readonly float Vlen;
    public bool Equals(WhisperTokenData Other) =>
        Id == Other.Id && Tid == Other.Tid &&
        BitConverter.SingleToInt32Bits(P) == BitConverter.SingleToInt32Bits(Other.P) &&
        BitConverter.SingleToInt32Bits(Plog) == BitConverter.SingleToInt32Bits(Other.Plog) &&
        BitConverter.SingleToInt32Bits(Pt) == BitConverter.SingleToInt32Bits(Other.Pt) &&
        BitConverter.SingleToInt32Bits(Ptsum) == BitConverter.SingleToInt32Bits(Other.Ptsum) &&
        T0 == Other.T0 && T1 == Other.T1 && TDtw == Other.TDtw &&
        BitConverter.SingleToInt32Bits(Vlen) == BitConverter.SingleToInt32Bits(Other.Vlen);
    public override bool Equals(object? Obj) => Obj is WhisperTokenData Other && Equals(Other);
    public override int GetHashCode()
    {
        var Hash = default(HashCode);
        Hash.Add(Id);
        Hash.Add(Tid);
        Hash.Add(P);
        Hash.Add(Plog);
        Hash.Add(Pt);
        Hash.Add(Ptsum);
        Hash.Add(T0);
        Hash.Add(T1);
        Hash.Add(TDtw);
        Hash.Add(Vlen);
        return Hash.ToHashCode();
    }
    public static bool operator ==(WhisperTokenData Left, WhisperTokenData Right) => Left.Equals(Right);
    public static bool operator !=(WhisperTokenData Left, WhisperTokenData Right) => !Left.Equals(Right);
}
