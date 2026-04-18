namespace WillowMaze.Wasm.Decompiled;


public interface p835b5e86 {
    int doFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989;

    java.lang.string getAlgorithmName();

    byte[] getMac();

    int getOutputSize(int i);

    int getUpdateOutputSize(int i);

    void init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException;

    void processAADbyte(byte b);

    void processAADbytes(byte[] bArr, int i, int i2);

    int processbyte(byte b, byte[] bArr, int i) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848;

    int processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848;

    void reset();
}

