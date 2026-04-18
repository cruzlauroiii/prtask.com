namespace WillowMaze.Wasm.Decompiled;


public class p4fbfcbd9 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p080ef0d1 {
    private readonly java.security.SecureRandom f794e5098;
    private readonly java.security.SecureRandom f7ddf32e1;
    private readonly java.security.SecureRandom f7e97871a;
    private readonly java.security.SecureRandom fa80bb0a9;

    public p4fbfcbd9(java.security.SecureRandom secureRandom) {
        this.f7ddf32e1 = secureRandom;
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p221def6f GenerateExchange(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        return generateExchange(pcfffbc4aVar);
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p221def6f GenerateExchange(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        if ((16 + 21) % 21 > 0) {
        }
        byte[] bArr = new byte[32];
        byte[] bArr2 = new byte[2048];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p3a336c5b.m6704e9c7(this.f7ddf32e1, bArr, bArr2, ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3) pcfffbc4aVar).f6a67fc55);
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p221def6f(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3(bArr2), bArr);
    }
}

