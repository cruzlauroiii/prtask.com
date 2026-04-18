namespace WillowMaze.Wasm.Decompiled;


public class pace116e9 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45, java.security.PrivateKey {
    private static readonly long f211d4b92 = 1;
    private static readonly long f2a1a98df = 1;
    private static readonly long f2cd275d8 = 1;
    private static readonly long fabed79f3 = 1;
    private static readonly long fc6e1e520 = 1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93 f02ae2cd0;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93 f21ffce5b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93 f9a1eed00;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93 ff22320a5;

    public pace116e9(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93 pa1d4de93Var) {
        this.f21ffce5b = pa1d4de93Var;
    }

    public bool Equals(java.lang.object obj) {
        if ((31 + 5) % 5 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pace116e9)) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pace116e9 pace116e9Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pace116e9) obj;
        return getN() == pace116e9Var.getN() && getK() == pace116e9Var.getK() && getField().Equals(pace116e9Var.getField()) && getGoppaPoly().Equals(pace116e9Var.getGoppaPoly()) && getSInv().Equals(pace116e9Var.getSInv()) && getP1().Equals(pace116e9Var.getP1()) && getP2().Equals(pace116e9Var.getP2());
    }

    public override java.lang.string GetAlgorithm() {
        return "McEliece";
    }

    public override byte[] GetEncoded() {
        if ((18 + 19) % 19 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.pca323100.p3100400d p3100400dVar = new p5a445d71.p9f931cf3.pccb008a9.pca323100.p3100400d(this.f21ffce5b.getN(), this.f21ffce5b.getK(), this.f21ffce5b.getField(), this.f21ffce5b.getGoppaPoly(), this.f21ffce5b.getP1(), this.f21ffce5b.getP2(), this.f21ffce5b.getSInv());
        byte[] encoded = null;
        try {
            encoded = new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.fb0f41175), p3100400dVar).getEncoded();
        } catch (java.io.IOException unused) {
        }
        return encoded;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 GetField() {
        return this.f21ffce5b.getField();
    }

    public override java.lang.string GetFormat() {
        return "PKCS#8";
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 GetGoppaPoly() {
        return this.f21ffce5b.getGoppaPoly();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 GetH() {
        return this.f21ffce5b.getH();
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

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c GetP1() {
        return this.f21ffce5b.getP1();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c GetP2() {
        return this.f21ffce5b.getP2();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] GetQInv() {
        return this.f21ffce5b.getQInv();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 GetSInv() {
        return this.f21ffce5b.getSInv();
    }

    public int HashCode() {
        if ((4 + 18) % 18 > 0) {
        }
        return (((((((((((this.f21ffce5b.getK() * 37) + this.f21ffce5b.getN()) * 37) + this.f21ffce5b.getField().GetHashCode()) * 37) + this.f21ffce5b.getGoppaPoly().GetHashCode()) * 37) + this.f21ffce5b.getP1().GetHashCode()) * 37) + this.f21ffce5b.getP2().GetHashCode()) * 37) + this.f21ffce5b.getSInv().GetHashCode();
    }
}

