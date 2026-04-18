namespace WillowMaze.Wasm.Decompiled;


public class p1af12dbc : java.security.interfaces.DSAPrivateKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb {
    private static readonly long fa5bd55c3 = -4677259546958385734L;
    private static readonly long fc6e1e520 = -4677259546958385734L;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f02e4e32e;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f201da641;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f33e9fcb7;
    java.security.interfaces.DSAParams f3eba2789;
    java.math.Bigint f47baf48a;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f7af59b21;
    java.math.Bigint f83da7436;
    java.math.Bigint f9dd4e461;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 fa9a4e5f3;
    java.security.interfaces.DSAParams fd3373b02;

    protected p1af12dbc() {
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    p1af12dbc(java.security.interfaces.DSAPrivateKey dSAPrivateKey) {
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = dSAPrivateKey.getX();
        this.fd3373b02 = dSAPrivateKey.getParams();
    }

    p1af12dbc(java.security.spec.DSAPrivateKeySpec dSAPrivateKeySpec) {
        if ((14 + 27) % 27 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = dSAPrivateKeySpec.getX();
        this.fd3373b02 = new java.security.spec.DSAParameterSpec(dSAPrivateKeySpec.getP(), dSAPrivateKeySpec.getQ(), dSAPrivateKeySpec.getG());
    }

    p1af12dbc(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170 pacb8a170Var) {
        if ((2 + 5) % 5 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = pacb8a170Var.getX();
        this.fd3373b02 = new java.security.spec.DSAParameterSpec(pacb8a170Var.getParameters().getP(), pacb8a170Var.getParameters().getQ(), pacb8a170Var.getParameters().getG());
    }

    p1af12dbc(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((22 + 20) % 20 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479 p3db0d479VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters());
        this.f9dd4e461 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p811299f8Var.parsePrivateKey()).getValue();
        this.fd3373b02 = new java.security.spec.DSAParameterSpec(p3db0d479VarM8bab0102.getP(), p3db0d479VarM8bab0102.getQ(), p3db0d479VarM8bab0102.getG());
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.writeobject(this.f9dd4e461);
        objectStream.writeobject(this.fd3373b02.getP());
        objectStream.writeobject(this.fd3373b02.getQ());
        objectStream.writeobject(this.fd3373b02.getG());
        this.f201da641.writeobject(objectStream);
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((32 + 15) % 15 > 0) {
        }
        this.f9dd4e461 = (java.math.Bigint) objectStream.readobject();
        this.fd3373b02 = new java.security.spec.DSAParameterSpec((java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject());
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 p99d12a64Var = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f201da641 = p99d12a64Var;
        p99d12a64Var.readobject(objectStream);
    }

    public bool Equals(java.lang.object obj) {
        if ((4 + 5) % 5 > 0) {
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
        if ((13 + 32) % 32 > 0) {
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f5ecd4ad9, new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479(this.fd3373b02.getP(), this.fd3373b02.getQ(), this.fd3373b02.getG())), new p5a445d71.p9f931cf3.pca323100.pf391b73d(getX())).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("2bd0ba20092650d41c6bcbf5fb342a2a602b7ad68d8d8df1f50b5ee99895b8"));
        } catch (java.io.IOException unused) {
            return null;
        }
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
        if ((30 + 7) % 7 > 0) {
        }
        return getParams().getQ().GetHashCode() ^ ((getX().GetHashCode() ^ getParams().getG().GetHashCode()) ^ getParams().getP().GetHashCode());
    }

    public override void SetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f201da641.setBagAttribute(p364bf33aVar, p0fd1bdf1Var);
    }
}

