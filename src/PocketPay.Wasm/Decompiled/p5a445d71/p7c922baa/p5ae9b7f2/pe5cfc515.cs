namespace WillowMaze.Wasm.Decompiled;


public interface pe5cfc515 {
    int doFinal(byte[] bArr, int i);

    java.lang.string getAlgorithmName();

    int getDigestSize();

    void reset();

    void update(byte b);

    void update(byte[] bArr, int i, int i2);
}

