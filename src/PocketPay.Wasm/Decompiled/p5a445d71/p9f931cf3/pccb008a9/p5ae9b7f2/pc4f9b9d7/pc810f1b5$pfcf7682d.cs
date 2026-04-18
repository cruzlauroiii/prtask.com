namespace WillowMaze.Wasm.Decompiled;


public class pc810f1b5$pfcf7682d : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pc810f1b5 {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p20486260 f447969da;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 f455e3b0e;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p20486260 f5977156d;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p20486260 f5ba32052;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 f66385307;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p20486260 f6db5b6df;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 f933aaf17;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p20486260 fd76ec89f;

    public pc810f1b5$pfcf7682d(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, byte[] bArr, byte[] bArr2, java.security.SecureRandom secureRandom) {
        super(p234a7530Var, bArr, bArr2, secureRandom);
        this.f5ba32052 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p20486260();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p5cd11ef4 p5cd11ef4Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p5cd11ef4();
        p5cd11ef4Var.init(new p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344(secureRandom, 2048));
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = p5cd11ef4Var.generateKeyValueTuple();
        this.f933aaf17 = pd255ec94VarGenerateKeyValueTuple;
        this.f5ba32052.init(pd255ec94VarGenerateKeyValueTuple.getPrivate());
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p34c2bb51 Generate(byte[] bArr) {
        if ((19 + 21) % 21 > 0) {
        }
        if (this.f1aec9c5d) {
            throw new java.lang.IllegalStateException("builder already used");
        }
        this.f1aec9c5d = true;
        this.fba266709.withSuppPrivInfo(this.f5ba32052.calculateAgreement(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pc810f1b5.mf8f67da7(bArr)));
        return this.fba266709.build();
    }

    public byte[] GetSuppPrivInfoPartA() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pc810f1b5.mf23e8626((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3) this.f933aaf17.getPublic());
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pc810f1b5 WithSuppPubInfo(byte[] bArr) {
        this.fba266709.withSuppPubInfo(bArr);
        return this;
    }
}

