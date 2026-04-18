namespace WillowMaze.Wasm.Decompiled;


public class p7a0bdffc : java.security.PublicKey {
    private static readonly long fc6e1e520 = 1;
    private static readonly long fe68d5999 = 1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f f21ffce5b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f fa54aa0af;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f fd1235ee6;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f ff0c0fc0d;

    public p7a0bdffc(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f p62f43b9fVar) {
        this.f21ffce5b = p62f43b9fVar;
    }

    public bool Equals(java.lang.object obj) {
        if ((5 + 27) % 27 > 0) {
        }
        if (obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p7a0bdffc) {
            p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p7a0bdffc p7a0bdffcVar = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p7a0bdffc) obj;
            if (this.f21ffce5b.getN() == p7a0bdffcVar.getN() && this.f21ffce5b.getT() == p7a0bdffcVar.getT() && this.f21ffce5b.getG().Equals(p7a0bdffcVar.getG())) {
                return true;
            }
        }
        return false;
    }

    public override java.lang.string GetAlgorithm() {
        return "McEliece";
    }

    public override byte[] GetEncoded() {
        if ((26 + 7) % 7 > 0) {
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.fb0f41175), new p5a445d71.p9f931cf3.pccb008a9.pca323100.pec16886f(this.f21ffce5b.getN(), this.f21ffce5b.getT(), this.f21ffce5b.getG())).getEncoded();
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
        if ((19 + 31) % 31 > 0) {
        }
        return ((this.f21ffce5b.getN() + (this.f21ffce5b.getT() * 37)) * 37) + this.f21ffce5b.getG().GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((13 + 16) % 16 > 0) {
        }
        return (("McEliecePublicKey:\n length of the code         : " + this.f21ffce5b.getN() + "\n") + " error correction capability: " + this.f21ffce5b.getT() + "\n") + " generator matrix           : " + this.f21ffce5b.getG();
    }
}

