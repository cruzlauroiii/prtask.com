namespace PrTask.Git;

#pragma warning disable SA1600
public static partial class GitPack
{
    internal static uint ReadUInt32BE(byte[] Data, int Offset) =>
        ((uint)Data[Offset] << GitConstants.BitShift24) | ((uint)Data[Offset + 1] << GitConstants.BitShift16) |
        ((uint)Data[Offset + 2] << GitConstants.BitShift8) | Data[Offset + GitConstants.Byte3Offset];

    internal static int ReadInt32BE(byte[] Data, int Offset) =>
        (Data[Offset] << GitConstants.BitShift24) | (Data[Offset + 1] << GitConstants.BitShift16) |
        (Data[Offset + 2] << GitConstants.BitShift8) | Data[Offset + GitConstants.Byte3Offset];

    internal static void WriteUInt32BE(Stream Stream, uint Value)
    {
        Stream.WriteByte((byte)(Value >> GitConstants.BitShift24));
        Stream.WriteByte((byte)(Value >> GitConstants.BitShift16));
        Stream.WriteByte((byte)(Value >> GitConstants.BitShift8));
        Stream.WriteByte((byte)Value);
    }

    internal static void WriteInt32BE(Stream Stream, int Value)
    {
        Stream.WriteByte((byte)((Value >> GitConstants.BitShift24) & GitConstants.ByteMask));
        Stream.WriteByte((byte)((Value >> GitConstants.BitShift16) & GitConstants.ByteMask));
        Stream.WriteByte((byte)((Value >> GitConstants.BitShift8) & GitConstants.ByteMask));
        Stream.WriteByte((byte)(Value & GitConstants.ByteMask));
    }
}
#pragma warning restore SA1600
