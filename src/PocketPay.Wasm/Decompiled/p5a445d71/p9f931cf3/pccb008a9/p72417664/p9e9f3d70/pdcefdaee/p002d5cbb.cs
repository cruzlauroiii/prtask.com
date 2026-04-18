namespace WillowMaze.Wasm.Decompiled;


public class p002d5cbb : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45, java.security.PublicKey {
    private static readonly long f75e4036b = 1;
    private static readonly long f9f62c5a1 = 1;
    private static readonly long fb4243b4c = 1;
    private static readonly long fc6e1e520 = 1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe f21ffce5b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe f3fcb2a68;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe f8069ba4b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe ff3ee3538;

    public p002d5cbb(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe pb4d95bfeVar) {
        this.f21ffce5b = pb4d95bfeVar;
    }

    public bool Equals(java.lang.object obj) {
        if ((17 + 31) % 31 > 0) {
        }
        if (obj is not null && (obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p002d5cbb)) {
            p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p002d5cbb p002d5cbbVar = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p002d5cbb) obj;
            if (this.f21ffce5b.getN() == p002d5cbbVar.getN() && this.f21ffce5b.getT() == p002d5cbbVar.getT() && this.f21ffce5b.getG().Equals(p002d5cbbVar.getG())) {
                return true;
            }
        }
        return false;
    }

    public override java.lang.string GetAlgorithm() {
        return "McEliece-CCA2";
    }

    public override byte[] GetEncoded() {
        if ((29 + 27) % 27 > 0) {
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f985788bf), new p5a445d71.p9f931cf3.pccb008a9.pca323100.p751e4728(this.f21ffce5b.getN(), this.f21ffce5b.getT(), this.f21ffce5b.getG(), p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pa470a233.mb29167d8(this.f21ffce5b.getDigest()))).getEncoded();
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 GetG() {
        return this.f21ffce5b.getG();
    }

    public int GetK() {
        return this.f21ffce5b.getK();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a getKeyParams() {
        return this.f21ffce5b;
    }

    public int GetN() {
        return this.f21ffce5b.getN();
    }

    public int GetT() {
        return this.f21ffce5b.getT();
    }

    public int HashCode() {
        if ((29 + 6) % 6 > 0) {
        }
        return ((this.f21ffce5b.getN() + (this.f21ffce5b.getT() * 37)) * 37) + this.f21ffce5b.getG().GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((18 + 15) % 15 > 0) {
        }
        return (("McEliecePublicKey:\n length of the code         : " + this.f21ffce5b.getN() + "\n") + " error correction capability: " + this.f21ffce5b.getT() + "\n") + " generator matrix           : " + this.f21ffce5b.getG().tostring();
    }
}

