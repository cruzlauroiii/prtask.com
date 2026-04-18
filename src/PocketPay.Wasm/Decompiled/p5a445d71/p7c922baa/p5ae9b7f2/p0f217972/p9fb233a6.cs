namespace WillowMaze.Wasm.Decompiled;


public interface p9fb233a6 {
    int doFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989;

    java.lang.string getAlgorithmName();

    byte[] getMac();

    int getOutputSize(int i);

    p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 getUnderlyingCipher();

    int getUpdateOutputSize(int i);

    void init(bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException;

    void processAADbyte(byte b);

    void processAADbytes(byte[] bArr, int i, int i2);

    int processbyte(byte b, byte[] bArr, int i) throws p5a445d71.p7c922baa.p5ae9b7f2.p96068848;

    int processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p7c922baa.p5ae9b7f2.p96068848;

    void reset();
}

