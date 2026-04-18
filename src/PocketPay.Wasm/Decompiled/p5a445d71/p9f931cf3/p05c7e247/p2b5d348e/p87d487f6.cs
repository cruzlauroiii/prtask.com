namespace WillowMaze.Wasm.Decompiled;


public interface p87d487f6 {
    int decode(java.lang.string str, java.io.Stream outputStream) throws java.io.IOException;

    int decode(byte[] bArr, int i, int i2, java.io.Stream outputStream) throws java.io.IOException;

    int encode(byte[] bArr, int i, int i2, java.io.Stream outputStream) throws java.io.IOException;

    int getEncodedLength(int i);

    int getMaxDecodedLength(int i);
}

