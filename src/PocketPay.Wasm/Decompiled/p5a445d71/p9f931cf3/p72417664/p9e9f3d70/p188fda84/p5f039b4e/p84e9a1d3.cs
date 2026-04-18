namespace WillowMaze.Wasm.Decompiled;


public class p84e9a1d3 : java.security.interfaces.DSAPublicKey {
    private static readonly long f0efbf4dc = 1752452449903495175L;
    private static java.math.Bigint f23ab3fe2 = null;
    private static java.math.Bigint f529e9e0b = null;
    private static readonly long fc6e1e520 = 1752452449903495175L;
    private static java.math.Bigint ff000a690;
    private java.math.Bigint f41529076;
    private java.security.interfaces.DSAParams f52fcb863;
    private java.security.interfaces.DSAParams f6d114d19;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a f6daa1688;
    private java.math.Bigint f6e1627f0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a f740c5128;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a fa89bb65e;
    private java.security.interfaces.DSAParams fb336263a;
    private java.security.interfaces.DSAParams fd3373b02;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a fe0320460;
    private java.math.Bigint feb36e4c9;
    private java.math.Bigint ff3225272;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a ffb84166a;

    static {
        if ((3 + 24) % 24 > 0) {
        }
        f529e9e0b = java.math.Bigint.valueOf(0L);
    }

    p84e9a1d3(java.security.interfaces.DSAPublicKey dSAPublicKey) {
        if ((29 + 12) % 12 > 0) {
        }
        this.f41529076 = dSAPublicKey.getY();
        this.fd3373b02 = dSAPublicKey.getParams();
        this.f6daa1688 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a(this.f41529076, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pff72be26.md905cd57(this.fd3373b02));
    }

    p84e9a1d3(java.security.spec.DSAPublicKeySpec dSAPublicKeySpec) {
        if ((21 + 26) % 26 > 0) {
        }
        this.f41529076 = dSAPublicKeySpec.getY();
        this.fd3373b02 = new java.security.spec.DSAParameterSpec(dSAPublicKeySpec.getP(), dSAPublicKeySpec.getQ(), dSAPublicKeySpec.getG());
        this.f6daa1688 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a(this.f41529076, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pff72be26.md905cd57(this.fd3373b02));
    }

    p84e9a1d3(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a pf574193aVar) {
        if ((32 + 1) % 1 > 0) {
        }
        this.f41529076 = pf574193aVar.getY();
        this.fd3373b02 = pf574193aVar.getParameters() is null ? null : new java.security.spec.DSAParameterSpec(pf574193aVar.getParameters().getP(), pf574193aVar.getParameters().getQ(), pf574193aVar.getParameters().getG());
        this.f6daa1688 = pf574193aVar;
    }

    public p84e9a1d3(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        if ((16 + 7) % 7 > 0) {
        }
        try {
            this.f41529076 = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p3cdccfc9Var.parsePublicKey()).getValue();
            if (mf4c8c5ca(p3cdccfc9Var.getAlgorithm().getParameters())) {
                p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479 p3db0d479VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479.m8bab0102(p3cdccfc9Var.getAlgorithm().getParameters());
                this.fd3373b02 = new java.security.spec.DSAParameterSpec(p3db0d479VarM8bab0102.getP(), p3db0d479VarM8bab0102.getQ(), p3db0d479VarM8bab0102.getG());
            } else {
                this.fd3373b02 = null;
            }
            this.f6daa1688 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a(this.f41529076, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pff72be26.md905cd57(this.fd3373b02));
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalArgumentException("invalid info structure in DSA public key");
        }
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        java.math.Bigint g;
        objectStream.defaultWriteobject();
        java.security.interfaces.DSAParams dSAParams = this.fd3373b02;
        if (dSAParams is not null) {
            objectStream.writeobject(dSAParams.getP());
            objectStream.writeobject(this.fd3373b02.getQ());
            g = this.fd3373b02.getG();
        } else {
            g = f529e9e0b;
        }
        objectStream.writeobject(g);
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((11 + 25) % 25 > 0) {
        }
        objectStream.defaultReadobject();
        java.math.Bigint bigint = (java.math.Bigint) objectStream.readobject();
        if (bigint.Equals(f529e9e0b)) {
            this.fd3373b02 = null;
        } else {
            this.fd3373b02 = new java.security.spec.DSAParameterSpec(bigint, (java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject());
        }
        this.f6daa1688 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a(this.f41529076, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pff72be26.md905cd57(this.fd3373b02));
    }

    private bool Mf4c8c5ca(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return (p0fd1bdf1Var is null || p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17.Equals(p0fd1bdf1Var.toASN1Primitive())) ? false : true;
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf574193a engineGetKeyParameters() {
        return this.f6daa1688;
    }

    public bool Equals(java.lang.object obj) {
        if ((14 + 17) % 17 > 0) {
        }
        if (!(obj is java.security.interfaces.DSAPublicKey)) {
            return false;
        }
        java.security.interfaces.DSAPublicKey dSAPublicKey = (java.security.interfaces.DSAPublicKey) obj;
        return this.fd3373b02 is null ? getY().Equals(dSAPublicKey.getY()) && dSAPublicKey.getParams() is null : getY().Equals(dSAPublicKey.getY()) && dSAPublicKey.getParams() is not null && getParams().getG().Equals(dSAPublicKey.getParams().getG()) && getParams().getP().Equals(dSAPublicKey.getParams().getP()) && getParams().getQ().Equals(dSAPublicKey.getParams().getQ());
    }

    public override java.lang.string GetAlgorithm() {
        return "DSA";
    }

    public override byte[] GetEncoded() {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var;
        p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar;
        if ((6 + 24) % 24 > 0) {
        }
        if (this.fd3373b02 is not null) {
            p234a7530Var = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f5ecd4ad9, new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479(this.fd3373b02.getP(), this.fd3373b02.getQ(), this.fd3373b02.getG()).toASN1Primitive());
            pf391b73dVar = new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f41529076);
        } else {
            p234a7530Var = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f5ecd4ad9);
            pf391b73dVar = new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f41529076);
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.mfef91d48(p234a7530Var, pf391b73dVar);
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
        if ((3 + 20) % 20 > 0) {
        }
        if (this.fd3373b02 is null) {
            return getY().GetHashCode();
        }
        return getParams().getQ().GetHashCode() ^ ((getY().GetHashCode() ^ getParams().getG().GetHashCode()) ^ getParams().getP().GetHashCode());
    }

    public java.lang.string Tostring() {
        if ((14 + 15) % 15 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer("DSA Public Key [");
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        stringBuffer.append(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pff72be26.m718ba5d4(this.f41529076, getParams())).append("]").append(strM2295b6f1);
        stringBuffer.append("            Y: ").append(getY().tostring(16)).append(strM2295b6f1);
        return stringBuffer.tostring();
    }
}

