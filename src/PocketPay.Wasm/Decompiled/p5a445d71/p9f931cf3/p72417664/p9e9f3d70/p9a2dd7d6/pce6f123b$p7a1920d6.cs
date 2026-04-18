namespace WillowMaze.Wasm.Decompiled;


public class pce6f123b$p7a1920d6 : java.security.SecureRandomSpi {
    private static readonly java.security.SecureRandom f2d0bdfb1 = null;
    private static readonly java.security.SecureRandom f7ddf32e1 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b.mf8f67da7(true);

    protected override byte[] EngineGenerateSeed(int i) {
        return f7ddf32e1.generateSeed(i);
    }

    protected override void EngineNextbytes(byte[] bArr) {
        f7ddf32e1.nextbytes(bArr);
    }

    protected override void EngineHashSetSeed(byte[] bArr) {
        f7ddf32e1.setSeed(bArr);
    }
}

