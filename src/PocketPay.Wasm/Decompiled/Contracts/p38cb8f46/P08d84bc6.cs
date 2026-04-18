namespace WillowMaze.Wasm.Decompiled;

public interface P08d84bc6
{
    p7e62bc34 Buffer();
    p08d84bc6 Emit();
    p08d84bc6 EmitCompleteSegments();
    void Flush();
    p7e62bc34 GetBuffer();
    Stream OutputStream();
    p08d84bc6 Write(p58efa9e8 P0);
    p08d84bc6 Write(p58efa9e8 P0, int P1, int P2);
    p08d84bc6 Write(pf31bbdd1 P0, long P1);
    p08d84bc6 Write(byte[] P0);
    p08d84bc6 Write(byte[] P0, int P1, int P2);
    long WriteAll(pf31bbdd1 P0);
    p08d84bc6 WriteByte(int P0);
    p08d84bc6 WriteDecimalLong(long P0);
    p08d84bc6 WriteHexadecimalUnsignedLong(long P0);
    p08d84bc6 WriteInt(int P0);
    p08d84bc6 WriteIntLe(int P0);
    p08d84bc6 WriteLong(long P0);
    p08d84bc6 WriteLongLe(long P0);
    p08d84bc6 WriteShort(int P0);
    p08d84bc6 WriteShortLe(int P0);
    p08d84bc6 WriteString(string P0, int P1, int P2, System.Text.Encoding P3);
    p08d84bc6 WriteString(string P0, System.Text.Encoding P1);
    p08d84bc6 WriteUtf8(string P0);
    p08d84bc6 WriteUtf8(string P0, int P1, int P2);
    p08d84bc6 WriteUtf8CodePoint(int P0);
}
