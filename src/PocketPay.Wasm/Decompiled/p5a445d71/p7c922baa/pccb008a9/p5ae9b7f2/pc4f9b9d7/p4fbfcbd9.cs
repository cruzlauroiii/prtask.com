namespace WillowMaze.Wasm.Decompiled;


public class p4fbfcbd9 : p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p080ef0d1 {
    private readonly java.security.SecureRandom f41d876fa;
    private readonly java.security.SecureRandom f7ddf32e1;
    private readonly java.security.SecureRandom fa37f3748;
    private readonly java.security.SecureRandom fe2cebbab;

    public p4fbfcbd9(java.security.SecureRandom secureRandom) {
        this.f7ddf32e1 = secureRandom;
    }

    public static void OgNntSpHHhaWuYFU(java.security.SecureRandom secureRandom, byte[] bArr, byte[] bArr2, byte[] bArr3) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.p3a336c5b.m6704e9c7(secureRandom, bArr, bArr2, bArr3);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p221def6f TRNdMvZcltMNRAWi(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.p4fbfcbd9 p4fbfcbd9Var, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        return p4fbfcbd9Var.generateExchange(pcfffbc4aVar);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p221def6f GenerateExchange(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        return tRNdMvZcltMNRAWi(this, pcfffbc4aVar);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p221def6f GenerateExchange(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        if ((22 + 3) % 3 > 0) {
        }
        byte[] bArr = new byte[32];
        byte[] bArr2 = new byte[2048];
        ogNntSpHHhaWuYFU(this.f7ddf32e1, bArr, bArr2, ((p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3) pcfffbc4aVar).f6a67fc55);
        return new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p221def6f(new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3(bArr2), bArr);
    }
}

