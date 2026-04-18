using System.Runtime.InteropServices;

namespace PrTask.Automerge;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct AMbyteSpan : IEquatable<AMbyteSpan>
{
    public byte* Src;
    public nuint Count;
    public override readonly bool Equals(object? Obj) => Obj is AMbyteSpan Other && Equals(Other);
    public readonly bool Equals(AMbyteSpan Other) => Src == Other.Src && Count == Other.Count;
    public override readonly int GetHashCode() => HashCode.Combine((nint)Src, Count);
    public static bool operator ==(AMbyteSpan Left, AMbyteSpan Right) => Left.Equals(Right);
    public static bool operator !=(AMbyteSpan Left, AMbyteSpan Right) => !Left.Equals(Right);
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct AMitems : IEquatable<AMitems>
{
    public fixed byte Detail[AutomergeConstants.ItemsDetailSize];

    public override readonly bool Equals(object? Obj) => Obj is AMitems Other && Equals(Other);

    public readonly bool Equals(AMitems Other)
    {
        for (var I = 0; I < AutomergeConstants.ItemsDetailSize; I++)
        {
            if (Detail[I] != Other.Detail[I])
            {
                return false;
            }
        }

        return true;
    }

    public override readonly int GetHashCode()
    {
        var Hash = default(HashCode);
        for (var I = 0; I < AutomergeConstants.ItemsDetailSize; I++)
        {
            Hash.Add(Detail[I]);
        }

        return Hash.ToHashCode();
    }

    public static bool operator ==(AMitems Left, AMitems Right) => Left.Equals(Right);
    public static bool operator !=(AMitems Left, AMitems Right) => !Left.Equals(Right);
}

[StructLayout(LayoutKind.Sequential)]
public struct AMunknownValue : IEquatable<AMunknownValue>
{
    public AMbyteSpan Bytes;
    public byte TypeCode;
    public override readonly bool Equals(object? Obj) => Obj is AMunknownValue Other && Equals(Other);
    public readonly bool Equals(AMunknownValue Other) => Bytes == Other.Bytes && TypeCode == Other.TypeCode;
    public override readonly int GetHashCode() => HashCode.Combine(Bytes, TypeCode);
    public static bool operator ==(AMunknownValue Left, AMunknownValue Right) => Left.Equals(Right);
    public static bool operator !=(AMunknownValue Left, AMunknownValue Right) => !Left.Equals(Right);
}
