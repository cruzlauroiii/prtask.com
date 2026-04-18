namespace WillowMaze.Wasm.Decompiled;


public class pd340241f : p5a445d71.p7c922baa.p5ae9b7f2.pb0af1c58 {
    private java.security.SecureRandom f1d31387f;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f27f28058;
    private java.security.SecureRandom f2ab73e75;
    private java.security.SecureRandom f2c6631bb;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f42c28003;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f54028bf5;
    private java.security.SecureRandom f7ddf32e1;

    public static p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 JRyfJTsfcKpbVTCu(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.p0f98a1ed p0f98a1edVar) {
        return p0f98a1edVar.getTreeDigest();
    }

    public static void OpvOcfyiqRUhZcFv(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, int i2, byte[] bArr2, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4 p3b0c1477_p4e9e06a4, byte[] bArr3, int i3) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477.m42339e1e(paa3a1111Var, bArr, i, i2, bArr2, p3b0c1477_p4e9e06a4, bArr3, i3);
    }

    public static void GZWiYjDAIAxCWKVw(java.security.SecureRandom secureRandom, byte[] bArr) {
        secureRandom.nextbytes(bArr);
    }

    public static void IYSzmNSbExLKWSIG(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.security.SecureRandom NjFOXMmvcDxAmVXL(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        return pf7bb6344Var.getRandom();
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((23 + 3) % 3 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4 p3b0c1477_p4e9e06a4 = new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4();
        byte[] bArr = new byte[1088];
        gZWiYjDAIAxCWKVw(this.f7ddf32e1, bArr);
        byte[] bArr2 = new byte[1056];
        iYSzmNSbExLKWSIG(bArr, 32, bArr2, 0, 1024);
        p3b0c1477_p4e9e06a4.fc9e9a848 = 11;
        p3b0c1477_p4e9e06a4.f12f1774e = 0L;
        p3b0c1477_p4e9e06a4.f0aae9c6b = 0L;
        OpvOcfyiqRUhZcFv(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111(this.f42c28003), bArr2, 1024, 5, bArr, p3b0c1477_p4e9e06a4, bArr2, 0);
        return new p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.p07661f3a(bArr2), (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.pa01d96fa(bArr));
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.f7ddf32e1 = njFOXMmvcDxAmVXL(pf7bb6344Var);
        this.f42c28003 = JRyfJTsfcKpbVTCu((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.p0f98a1ed) pf7bb6344Var);
    }
}

