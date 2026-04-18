namespace WillowMaze.Wasm.Decompiled;


public class paebb5c49 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p240d858d {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d f0b349a69;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 f28c326cd;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 f31e9cdfb;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d f4aa2361b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 f70415950;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 fa90c4b0c;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d fac300a15;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 fd247ac5b;

    public override byte[] GenerateSignature(byte[] bArr) {
        if ((24 + 4) % 4 > 0) {
        }
        try {
            return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p66a8f281.m828114c8(this.f4aa2361b, bArr).getEncoded();
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException("unable to encode signature: " + e.getMessage());
        }
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (z) {
            this.f4aa2361b = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) pc9ef6b45Var;
        } else {
            this.f28c326cd = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6) pc9ef6b45Var;
        }
    }

    public override bool VerifySignature(byte[] bArr, byte[] bArr2) {
        try {
            return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p66a8f281.m34a82b06(this.f28c326cd, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f.m8bab0102(bArr2), bArr);
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalStateException("unable to decode signature: " + e.getMessage());
        }
    }
}

