namespace WillowMaze.Wasm.Decompiled;


public class p5cd11ef4 : p5a445d71.p7c922baa.p5ae9b7f2.pb0af1c58 {
    private java.security.SecureRandom f033f67fe;
    private java.security.SecureRandom f7d91250a;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom faa28b522;
    private java.security.SecureRandom fc7e2d9da;

    public static void GoParVjiVylHiJMs(java.security.SecureRandom secureRandom, byte[] bArr, short[] sArr) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.p3a336c5b.m3f792f24(secureRandom, bArr, sArr);
    }

    public static java.security.SecureRandom UYZxJnsRhoYSOcHz(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        return pf7bb6344Var.getRandom();
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((28 + 10) % 10 > 0) {
        }
        byte[] bArr = new byte[1824];
        short[] sArr = new short[1024];
        GoParVjiVylHiJMs(this.f7ddf32e1, bArr, sArr);
        return new p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3(bArr), (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.p08a45ebd(sArr));
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.f7ddf32e1 = UYZxJnsRhoYSOcHz(pf7bb6344Var);
    }
}

