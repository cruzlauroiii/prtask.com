namespace WillowMaze.Wasm.Decompiled;


interface p7264d28b$pd185725f {
    int doFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, javax.crypto.BadPaddingException;

    java.lang.string getAlgorithmName();

    int getOutputSize(int i);

    p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 getUnderlyingCipher();

    int getUpdateOutputSize(int i);

    void init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException;

    int processbyte(byte b, byte[] bArr, int i) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848;

    int processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848;

    void updateAAD(byte[] bArr, int i, int i2);

    bool wrapOnNoPadding();
}

