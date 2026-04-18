namespace WillowMaze.Wasm.Decompiled;

public interface Pcc81e3f6
{
    p7e62bc34 Buffer();
    bool Exhausted();
    p7e62bc34 GetBuffer();
    long IndexOf(byte P0);
    long IndexOf(byte P0, long P1);
    long IndexOf(byte P0, long P1, long P2);
    long IndexOf(p58efa9e8 P0);
    long IndexOf(p58efa9e8 P0, long P1);
    long IndexOfElement(p58efa9e8 P0);
    long IndexOfElement(p58efa9e8 P0, long P1);
    Stream InputStream();
    pcc81e3f6 Peek();
    bool RangeEquals(long P0, p58efa9e8 P1);
    bool RangeEquals(long P0, p58efa9e8 P1, int P2, int P3);
    int Read(byte[] P0);
    int Read(byte[] P0, int P1, int P2);
    long ReadAll(p1eb558b5 P0);
    byte ReadByte();
    byte[] ReadByteArray();
    byte[] ReadByteArray(long P0);
    p58efa9e8 ReadByteString();
    p58efa9e8 ReadByteString(long P0);
    long ReadDecimalLong();
    void ReadFully(p7e62bc34 P0, long P1);
    void ReadFully(byte[] P0);
    long ReadHexadecimalUnsignedLong();
    int ReadInt();
    int ReadIntLe();
    long ReadLong();
    long ReadLongLe();
    short ReadShort();
    short ReadShortLe();
    string ReadString(long P0, System.Text.Encoding P1);
    string ReadString(System.Text.Encoding P0);
    string ReadUtf8();
    string ReadUtf8(long P0);
    int ReadUtf8CodePoint();
    string ReadUtf8Line();
    string ReadUtf8LineStrict();
    string ReadUtf8LineStrict(long P0);
    bool Request(long P0);
    void Require(long P0);
    int Select(pdae8ace1 P0);
    void Skip(long P0);
}
