namespace WillowMaze.Wasm.Decompiled;


public interface pd1977c1b {
    byte[] generateSignature() throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f;

    void init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var);

    void reset();

    void update(byte b);

    void update(byte[] bArr, int i, int i2);

    bool verifySignature(byte[] bArr);
}

