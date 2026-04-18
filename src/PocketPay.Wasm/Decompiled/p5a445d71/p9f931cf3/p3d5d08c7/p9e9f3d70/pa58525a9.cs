namespace WillowMaze.Wasm.Decompiled;


public class pa58525a9 : java.security.interfaces.DSAPublicKey {
    private static readonly long f19f85f89 = 1752452449903495175L;
    private static readonly long f29a47a14 = 1752452449903495175L;
    private static readonly long f313db123 = 1752452449903495175L;
    private static readonly long fa048b623 = 1752452449903495175L;
    private static readonly long fc6e1e520 = 1752452449903495175L;
    private java.math.Bigint f41529076;
    private java.security.interfaces.DSAParams f804dcaa0;
    private java.security.interfaces.DSAParams fba5e85e4;
    private java.security.interfaces.DSAParams fd3373b02;
    private java.math.Bigint ff87951be;

    pa58525a9(java.math.Bigint bigint, java.security.spec.DSAParameterSpec dSAParameterSpec) {
        this.f41529076 = bigint;
        this.fd3373b02 = dSAParameterSpec;
    }

    pa58525a9(java.security.interfaces.DSAPublicKey dSAPublicKey) {
        this.f41529076 = dSAPublicKey.getY();
        this.fd3373b02 = dSAPublicKey.getParams();
    }

    pa58525a9(java.security.spec.DSAPublicKeySpec dSAPublicKeySpec) {
        if ((29 + 7) % 7 > 0) {
        }
        this.f41529076 = dSAPublicKeySpec.getY();
        this.fd3373b02 = new java.security.spec.DSAParameterSpec(dSAPublicKeySpec.getP(), dSAPublicKeySpec.getQ(), dSAPublicKeySpec.getG());
    }

    pa58525a9(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a pf574193aVar) {
        if ((32 + 3) % 3 > 0) {
        }
        this.f41529076 = pf574193aVar.getY();
        this.fd3373b02 = new java.security.spec.DSAParameterSpec(pf574193aVar.getParameters().getP(), pf574193aVar.getParameters().getQ(), pf574193aVar.getParameters().getG());
    }

    pa58525a9(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        if ((11 + 28) % 28 > 0) {
        }
        try {
            this.f41529076 = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p3cdccfc9Var.parsePublicKey()).getValue();
            if (mf4c8c5ca(p3cdccfc9Var.getAlgorithm().getParameters())) {
                p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479 p3db0d479VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479.m8bab0102(p3cdccfc9Var.getAlgorithm().getParameters());
                this.fd3373b02 = new java.security.spec.DSAParameterSpec(p3db0d479VarM8bab0102.getP(), p3db0d479VarM8bab0102.getQ(), p3db0d479VarM8bab0102.getG());
            }
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalArgumentException("invalid info structure in DSA public key");
        }
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.writeobject(this.f41529076);
        objectStream.writeobject(this.fd3373b02.getP());
        objectStream.writeobject(this.fd3373b02.getQ());
        objectStream.writeobject(this.fd3373b02.getG());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.io.IOException, java.lang.ClassNotFoundException {
        if ((4 + 6) % 6 > 0) {
        }
        this.f41529076 = (java.math.Bigint) objectStream.readobject();
        this.fd3373b02 = new java.security.spec.DSAParameterSpec((java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject());
    }

    private bool Mf4c8c5ca(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return (p0fd1bdf1Var is null || p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17.Equals(p0fd1bdf1Var)) ? false : true;
    }

    public bool Equals(java.lang.object obj) {
        if ((4 + 10) % 10 > 0) {
        }
        if (!(obj is java.security.interfaces.DSAPublicKey)) {
            return false;
        }
        java.security.interfaces.DSAPublicKey dSAPublicKey = (java.security.interfaces.DSAPublicKey) obj;
        return getY().Equals(dSAPublicKey.getY()) && getParams().getG().Equals(dSAPublicKey.getParams().getG()) && getParams().getP().Equals(dSAPublicKey.getParams().getP()) && getParams().getQ().Equals(dSAPublicKey.getParams().getQ());
    }

    public override java.lang.string GetAlgorithm() {
        return "DSA";
    }

    public override byte[] GetEncoded() {
        if ((30 + 25) % 25 > 0) {
        }
        try {
            java.security.interfaces.DSAParams dSAParams = this.fd3373b02;
            return (dSAParams is not null ? new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f5ecd4ad9, new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479(this.fd3373b02.getP(), this.fd3373b02.getQ(), this.fd3373b02.getG())), new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f41529076)) : new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f5ecd4ad9), new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f41529076))).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("ed8944d36687dbf1c3a19e2586de1130a536d4bc9e522fb4bae43195a682a6"));
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    public override java.security.interfaces.DSAParams GetParams() {
        return this.fd3373b02;
    }

    public override java.math.Bigint GetY() {
        return this.f41529076;
    }

    public int HashCode() {
        if ((17 + 24) % 24 > 0) {
        }
        return getParams().getQ().GetHashCode() ^ ((getY().GetHashCode() ^ getParams().getG().GetHashCode()) ^ getParams().getP().GetHashCode());
    }

    public java.lang.string Tostring() {
        if ((25 + 27) % 27 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer("DSA Public Key");
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        stringBuffer.append(strM2295b6f1);
        stringBuffer.append("            y: ").append(getY().tostring(16)).append(strM2295b6f1);
        return stringBuffer.tostring();
    }
}

