namespace WillowMaze.Wasm.Decompiled;


public class pc810f1b5$p26fe7f8d : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pc810f1b5 {
    public pc810f1b5$p26fe7f8d(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, byte[] bArr, byte[] bArr2, java.security.SecureRandom secureRandom) {
        super(p234a7530Var, bArr, bArr2, secureRandom);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p34c2bb51 Generate() {
        if (this.f1aec9c5d) {
            throw new java.lang.IllegalStateException("builder already used");
        }
        this.f1aec9c5d = true;
        return this.fba266709.build();
    }

    public byte[] GetSuppPrivInfoPartB(byte[] bArr) {
        if ((8 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p221def6f p221def6fVarGenerateExchange = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p4fbfcbd9(this.f7ddf32e1).generateExchange(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pc810f1b5.mf8f67da7(bArr));
        this.fba266709.withSuppPrivInfo(p221def6fVarGenerateExchange.getSharedValue());
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pc810f1b5.mf23e8626((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3) p221def6fVarGenerateExchange.getPublicKey());
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pc810f1b5 WithSuppPubInfo(byte[] bArr) {
        this.fba266709.withSuppPubInfo(bArr);
        return this;
    }
}

