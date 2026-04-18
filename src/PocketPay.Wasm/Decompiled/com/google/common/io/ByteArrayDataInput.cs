namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
public interface byteArrayDataInput : java.io.DataInput {
    bool readbool();

    byte readbyte();

    char readChar();

    double readdouble();

    float readfloat();

    void readFully(byte[] bArr);

    void readFully(byte[] bArr, int i, int i2);

    int readInt();

    @javax.annotation.CheckForNull
    java.lang.string readLine();

    long readlong();

    short readshort();

    java.lang.string readUTF();

    int readUnsignedbyte();

    int readUnsignedshort();

    int skipbytes(int i);
}

