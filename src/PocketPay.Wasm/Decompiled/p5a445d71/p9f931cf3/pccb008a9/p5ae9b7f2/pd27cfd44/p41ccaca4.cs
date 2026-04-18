namespace WillowMaze.Wasm.Decompiled;


public class p41ccaca4 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p240d858d {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b f28c326cd;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 f4aa2361b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b f5bd84bb2;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 f5f275e6d;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b f681db5aa;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 f84ceda2c;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b fab12b505;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 fb73df704;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b ff84e397b;

    public override byte[] GenerateSignature(byte[] bArr) {
        if ((28 + 27) % 27 > 0) {
        }
        try {
            return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pa356c796.m42750aa6(this.f4aa2361b, bArr).getEncoded();
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException("unable to encode signature: " + e.getMessage());
        }
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (z) {
            this.f4aa2361b = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594) pc9ef6b45Var;
        } else {
            this.f28c326cd = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b) pc9ef6b45Var;
        }
    }

    public override bool VerifySignature(byte[] bArr, byte[] bArr2) {
        try {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b pe32c2c6bVar = this.f28c326cd;
            return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pa356c796.m34a82b06(pe32c2c6bVar, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7.m8bab0102(bArr2, pe32c2c6bVar.getL()), bArr);
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException("unable to decode signature: " + e.getMessage());
        }
    }
}

