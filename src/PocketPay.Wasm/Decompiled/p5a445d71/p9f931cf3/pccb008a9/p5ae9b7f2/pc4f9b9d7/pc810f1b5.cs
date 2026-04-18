namespace WillowMaze.Wasm.Decompiled;


public class pc810f1b5 {
    protected readonly java.security.SecureRandom f1745fa63;
    protected bool f1aec9c5d = false;
    protected readonly p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p34c2bb51$p2bd4a59b f229a347c;
    protected bool f3e983b4e;
    protected readonly java.security.SecureRandom f668287f7;
    protected readonly java.security.SecureRandom f66dad5c9;
    protected readonly java.security.SecureRandom f7ddf32e1;
    protected readonly p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p34c2bb51$p2bd4a59b f81d37d68;
    protected readonly p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p34c2bb51$p2bd4a59b f836e11e4;
    protected readonly p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p34c2bb51$p2bd4a59b fba266709;
    protected readonly p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p34c2bb51$p2bd4a59b fdbd60a03;
    protected bool ff301cab8;

    public pc810f1b5(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, byte[] bArr, byte[] bArr2, java.security.SecureRandom secureRandom) {
        this.fba266709 = new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p34c2bb51$p2bd4a59b(p234a7530Var, bArr, bArr2);
        this.f7ddf32e1 = secureRandom;
    }

    private static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3 M1367c17c(byte[] bArr) {
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(bArr).getPublicKeyData().getOctets());
    }

    private static byte[] M1c04e86a(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3 p6c7d76f3Var) {
        if ((1 + 15) % 15 > 0) {
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f054b782d), p6c7d76f3Var.getPubData()).getEncoded();
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    static byte[] Mf23e8626(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3 p6c7d76f3Var) {
        return m1c04e86a(p6c7d76f3Var);
    }

    static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3 Mf8f67da7(byte[] bArr) {
        return m1367c17c(bArr);
    }
}

