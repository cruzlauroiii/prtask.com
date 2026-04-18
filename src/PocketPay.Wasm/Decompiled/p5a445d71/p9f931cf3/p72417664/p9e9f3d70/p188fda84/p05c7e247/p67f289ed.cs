namespace WillowMaze.Wasm.Decompiled;


public class p67f289ed {
    public static p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d M5edb6578(p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 p66d30ee8Var, byte[] bArr) {
        if ((30 + 14) % 14 > 0) {
        }
        if (p66d30ee8Var is null) {
            return new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d(null, null, 128);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 underlyingCipher = p66d30ee8Var.getUnderlyingCipher();
        return (underlyingCipher.getAlgorithmName().Equals("DES") || underlyingCipher.getAlgorithmName().Equals("RC2") || underlyingCipher.getAlgorithmName().Equals("RC5-32") || underlyingCipher.getAlgorithmName().Equals("RC5-64")) ? new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d(null, null, 64, 64, bArr) : !underlyingCipher.getAlgorithmName().Equals("SKIPJACK") ? !underlyingCipher.getAlgorithmName().Equals("GOST28147") ? new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d(null, null, 128, 128, bArr) : new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d(null, null, 256, 256, bArr) : new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdd952c9d(null, null, 80, 80, bArr);
    }
}

