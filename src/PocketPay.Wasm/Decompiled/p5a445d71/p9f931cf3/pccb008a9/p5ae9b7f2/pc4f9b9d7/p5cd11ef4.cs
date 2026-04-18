namespace WillowMaze.Wasm.Decompiled;


public class p5cd11ef4 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private java.security.SecureRandom f2e690cd2;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom fea97410a;
    private java.security.SecureRandom ff2b95f4f;

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((23 + 22) % 22 > 0) {
        }
        byte[] bArr = new byte[1824];
        short[] sArr = new short[1024];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p3a336c5b.m3f792f24(this.f7ddf32e1, bArr, sArr);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3(bArr), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p08a45ebd(sArr));
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.f7ddf32e1 = pf7bb6344Var.getRandom();
    }
}

