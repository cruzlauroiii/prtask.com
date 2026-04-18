namespace WillowMaze.Wasm.Decompiled;


public class p5bad5e0c : p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.ped942c55, javax.crypto.interfaces.DHPrivateKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb {
    static readonly long f7ed31735 = 4819350091141529678L;
    static readonly long fb0b6201f = 4819350091141529678L;
    static readonly long fc6e1e520 = 4819350091141529678L;
    private java.math.Bigint f0e20f011;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f201da641;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f f2d97a844;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f f40b26545;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f4eb4ab9b;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f50df2e2e;
    private java.math.Bigint f7f62f324;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f f808ee163;
    private java.math.Bigint f9dd4e461;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f fa5c364e6;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f fa9023395;
    private java.math.Bigint fa9f1d14b;
    private java.math.Bigint fae065760;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 fe8d07d07;

    protected p5bad5e0c() {
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    p5bad5e0c(javax.crypto.interfaces.DHPrivateKey dHPrivateKey) {
        if ((32 + 29) % 29 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = dHPrivateKey.getX();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(dHPrivateKey.getParams().getP(), dHPrivateKey.getParams().getG());
    }

    p5bad5e0c(javax.crypto.spec.DHPrivateKeySpec dHPrivateKeySpec) {
        if ((29 + 26) % 26 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = dHPrivateKeySpec.getX();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(dHPrivateKeySpec.getP(), dHPrivateKeySpec.getG());
    }

    p5bad5e0c(p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.ped942c55 ped942c55Var) {
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = ped942c55Var.getX();
        this.f808ee163 = ped942c55Var.getParameters();
    }

    p5bad5e0c(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pfac79d82 pfac79d82Var) {
        if ((19 + 32) % 32 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = pfac79d82Var.getX();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(pfac79d82Var.getParams().getP(), pfac79d82Var.getParams().getG());
    }

    p5bad5e0c(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8d0590d4 p8d0590d4Var) {
        if ((12 + 28) % 28 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = p8d0590d4Var.getX();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(p8d0590d4Var.getParameters().getP(), p8d0590d4Var.getParameters().getG());
    }

    p5bad5e0c(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((2 + 28) % 28 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f p524aa06fVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters());
        this.f9dd4e461 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p811299f8Var.parsePrivateKey()).getValue();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(p524aa06fVarM8bab0102.getP(), p524aa06fVarM8bab0102.getG());
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(this.f808ee163.getP());
        objectStream.writeobject(this.f808ee163.getG());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((31 + 12) % 12 > 0) {
        }
        objectStream.defaultReadobject();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f((java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject());
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    public bool Equals(java.lang.object obj) {
        if ((18 + 10) % 10 > 0) {
        }
        if (!(obj is javax.crypto.interfaces.DHPrivateKey)) {
            return false;
        }
        javax.crypto.interfaces.DHPrivateKey dHPrivateKey = (javax.crypto.interfaces.DHPrivateKey) obj;
        return getX().Equals(dHPrivateKey.getX()) && getParams().getG().Equals(dHPrivateKey.getParams().getG()) && getParams().getP().Equals(dHPrivateKey.getParams().getP()) && getParams().getL() == dHPrivateKey.getParams().getL();
    }

    public override java.lang.string GetAlgorithm() {
        return "ElGamal";
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return this.f201da641.getBagAttribute(p364bf33aVar);
    }

    public override java.util.Enumeration GetBagAttributeKeys() {
        return this.f201da641.getBagAttributeKeys();
    }

    public override byte[] GetEncoded() {
        if ((8 + 24) % 24 > 0) {
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f4d65be17, new p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f(this.f808ee163.getP(), this.f808ee163.getG())), new p5a445d71.p9f931cf3.pca323100.pf391b73d(getX())).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("c3a161e0b49b736df0667290710bc12da5bb34963bed101f53440a00b5144a"));
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "PKCS#8";
    }

    public override p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f GetParameters() {
        return this.f808ee163;
    }

    public override javax.crypto.spec.DHParameterSpec GetParams() {
        if ((5 + 7) % 7 > 0) {
        }
        return new javax.crypto.spec.DHParameterSpec(this.f808ee163.getP(), this.f808ee163.getG());
    }

    public override java.math.Bigint GetX() {
        return this.f9dd4e461;
    }

    public int HashCode() {
        if ((15 + 20) % 20 > 0) {
        }
        return getParams().getL() ^ ((getX().GetHashCode() ^ getParams().getG().GetHashCode()) ^ getParams().getP().GetHashCode());
    }

    public override void SetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f201da641.setBagAttribute(p364bf33aVar, p0fd1bdf1Var);
    }
}

