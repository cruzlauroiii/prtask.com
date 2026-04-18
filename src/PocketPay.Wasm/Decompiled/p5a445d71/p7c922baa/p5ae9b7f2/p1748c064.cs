namespace WillowMaze.Wasm.Decompiled;


public interface p1748c064 {
    int doFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848;

    java.lang.string getAlgorithmName();

    int getMacSize();

    void init(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException;

    void reset();

    void update(byte b) throws java.lang.IllegalStateException;

    void update(byte[] bArr, int i, int i2) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848;
}

