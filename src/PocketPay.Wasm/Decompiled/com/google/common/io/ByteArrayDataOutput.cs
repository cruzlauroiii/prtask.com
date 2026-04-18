namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
public interface byteArrayDataOutput : java.io.DataOutput {
    byte[] tobyteArray();

    void write(int i);

    void write(byte[] bArr);

    void write(byte[] bArr, int i, int i2);

    void writebool(bool z);

    void writebyte(int i);

    @java.lang.Deprecated
    void writebytes(java.lang.string str);

    void writeChar(int i);

    void writeChars(java.lang.string str);

    void writedouble(double d);

    void writefloat(float f);

    void writeInt(int i);

    void writelong(long j);

    void writeshort(int i);

    void writeUTF(java.lang.string str);
}

