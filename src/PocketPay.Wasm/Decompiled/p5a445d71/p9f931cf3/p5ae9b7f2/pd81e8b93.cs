namespace WillowMaze.Wasm.Decompiled;


public interface pd81e8b93 {
    java.lang.string getAlgorithmName();

    int getBlockSize();

    void init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException;

    int processBlock(byte[] bArr, int i, byte[] bArr2, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848;

    void reset();
}

