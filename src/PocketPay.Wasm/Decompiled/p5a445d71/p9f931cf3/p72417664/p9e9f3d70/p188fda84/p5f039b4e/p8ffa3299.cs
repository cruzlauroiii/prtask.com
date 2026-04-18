namespace WillowMaze.Wasm.Decompiled;


public class p8ffa3299 : java.security.interfaces.DSAPrivateKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb {
    private static readonly long f2c925984 = -4677259546958385734L;
    private static readonly long f3bf868df = -4677259546958385734L;
    private static readonly long f5ee71930 = -4677259546958385734L;
    private static readonly long f6ea58271 = -4677259546958385734L;
    private static readonly long fc6e1e520 = -4677259546958385734L;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f1626caa0;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f201da641;
    private java.security.interfaces.DSAParams f291f59b7;
    private java.math.Bigint f34494b9b;
    private java.math.Bigint f3f5359d4;
    private java.math.Bigint f46dbecc5;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f4cd7ae60;
    private java.security.interfaces.DSAParams f6e95014e;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f7421d802;
    private java.security.interfaces.DSAParams f759175d7;
    private java.math.Bigint f9dd4e461;
    private java.math.Bigint fa5efeb4f;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 fbc14c181;
    private java.security.interfaces.DSAParams fd3373b02;
    private java.security.interfaces.DSAParams ffc2465c1;

    protected p8ffa3299() {
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    p8ffa3299(java.security.interfaces.DSAPrivateKey dSAPrivateKey) {
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = dSAPrivateKey.getX();
        this.fd3373b02 = dSAPrivateKey.getParams();
    }

    p8ffa3299(java.security.spec.DSAPrivateKeySpec dSAPrivateKeySpec) {
        if ((24 + 6) % 6 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = dSAPrivateKeySpec.getX();
        this.fd3373b02 = new java.security.spec.DSAParameterSpec(dSAPrivateKeySpec.getP(), dSAPrivateKeySpec.getQ(), dSAPrivateKeySpec.getG());
    }

    p8ffa3299(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170 pacb8a170Var) {
        if ((23 + 17) % 17 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = pacb8a170Var.getX();
        this.fd3373b02 = new java.security.spec.DSAParameterSpec(pacb8a170Var.getParameters().getP(), pacb8a170Var.getParameters().getQ(), pacb8a170Var.getParameters().getG());
    }

    public p8ffa3299(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((29 + 16) % 16 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479 p3db0d479VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters());
        this.f9dd4e461 = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p811299f8Var.parsePrivateKey()).getValue();
        this.fd3373b02 = new java.security.spec.DSAParameterSpec(p3db0d479VarM8bab0102.getP(), p3db0d479VarM8bab0102.getQ(), p3db0d479VarM8bab0102.getG());
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(this.fd3373b02.getP());
        objectStream.writeobject(this.fd3373b02.getQ());
        objectStream.writeobject(this.fd3373b02.getG());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((23 + 16) % 16 > 0) {
        }
        objectStream.defaultReadobject();
        this.fd3373b02 = new java.security.spec.DSAParameterSpec((java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject());
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    public bool Equals(java.lang.object obj) {
        if ((17 + 27) % 27 > 0) {
        }
        if (!(obj is java.security.interfaces.DSAPrivateKey)) {
            return false;
        }
        java.security.interfaces.DSAPrivateKey dSAPrivateKey = (java.security.interfaces.DSAPrivateKey) obj;
        return getX().Equals(dSAPrivateKey.getX()) && getParams().getG().Equals(dSAPrivateKey.getParams().getG()) && getParams().getP().Equals(dSAPrivateKey.getParams().getP()) && getParams().getQ().Equals(dSAPrivateKey.getParams().getQ());
    }

    public override java.lang.string GetAlgorithm() {
        return "DSA";
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return this.f201da641.getBagAttribute(p364bf33aVar);
    }

    public override java.util.Enumeration GetBagAttributeKeys() {
        return this.f201da641.getBagAttributeKeys();
    }

    public override byte[] GetEncoded() {
        if ((32 + 19) % 19 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.m28fa3698(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f5ecd4ad9, new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479(this.fd3373b02.getP(), this.fd3373b02.getQ(), this.fd3373b02.getG()).toASN1Primitive()), new p5a445d71.p9f931cf3.pca323100.pf391b73d(getX()));
    }

    public override java.lang.string GetFormat() {
        return "PKCS#8";
    }

    public override java.security.interfaces.DSAParams GetParams() {
        return this.fd3373b02;
    }

    public override java.math.Bigint GetX() {
        return this.f9dd4e461;
    }

    public int HashCode() {
        if ((6 + 26) % 26 > 0) {
        }
        return getParams().getQ().GetHashCode() ^ ((getX().GetHashCode() ^ getParams().getG().GetHashCode()) ^ getParams().getP().GetHashCode());
    }

    public override void SetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f201da641.setBagAttribute(p364bf33aVar, p0fd1bdf1Var);
    }

    public java.lang.string Tostring() {
        if ((3 + 13) % 13 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer("DSA Private Key [");
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        java.math.Bigint bigintModPow = getParams().getG().modPow(this.f9dd4e461, getParams().getP());
        stringBuffer.append(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pff72be26.m718ba5d4(bigintModPow, getParams())).append("]").append(strM2295b6f1);
        stringBuffer.append("            Y: ").append(bigintModPow.tostring(16)).append(strM2295b6f1);
        return stringBuffer.tostring();
    }
}

