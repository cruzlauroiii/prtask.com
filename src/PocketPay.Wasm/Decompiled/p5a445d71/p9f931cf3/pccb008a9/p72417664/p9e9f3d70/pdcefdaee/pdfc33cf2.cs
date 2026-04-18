namespace WillowMaze.Wasm.Decompiled;


public class pdfc33cf2 : java.security.PrivateKey {
    private static readonly long f01c80a4d = 1;
    private static readonly long f0b3eb2ae = 1;
    private static readonly long fc6e1e520 = 1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f f21ffce5b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f fc25c2db3;

    public pdfc33cf2(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f p0d2c2c1fVar) {
        this.f21ffce5b = p0d2c2c1fVar;
    }

    public bool Equals(java.lang.object obj) {
        if ((18 + 1) % 1 > 0) {
        }
        if (obj is not null && (obj is p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdfc33cf2)) {
            p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdfc33cf2 pdfc33cf2Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdfc33cf2) obj;
            if (getN() == pdfc33cf2Var.getN() && getK() == pdfc33cf2Var.getK() && getField().Equals(pdfc33cf2Var.getField()) && getGoppaPoly().Equals(pdfc33cf2Var.getGoppaPoly()) && getP().Equals(pdfc33cf2Var.getP()) && getH().Equals(pdfc33cf2Var.getH())) {
                return true;
            }
        }
        return false;
    }

    public override java.lang.string GetAlgorithm() {
        return "McEliece-CCA2";
    }

    public override byte[] GetEncoded() {
        if ((32 + 17) % 17 > 0) {
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f985788bf), new p5a445d71.p9f931cf3.pccb008a9.pca323100.pddbd07cd(getN(), getK(), getField(), getGoppaPoly(), getP(), p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pa470a233.mb29167d8(this.f21ffce5b.getDigest()))).getEncoded();
        } catch (java.io.IOException unused) {
            return null;
        }
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

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c GetP() {
        return this.f21ffce5b.getP();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] GetQInv() {
        return this.f21ffce5b.getQInv();
    }

    public int GetT() {
        return this.f21ffce5b.getGoppaPoly().getDegree();
    }

    public int HashCode() {
        if ((3 + 31) % 31 > 0) {
        }
        return (((((((((this.f21ffce5b.getK() * 37) + this.f21ffce5b.getN()) * 37) + this.f21ffce5b.getField().GetHashCode()) * 37) + this.f21ffce5b.getGoppaPoly().GetHashCode()) * 37) + this.f21ffce5b.getP().GetHashCode()) * 37) + this.f21ffce5b.getH().GetHashCode();
    }
}

