namespace WillowMaze.Wasm.Decompiled;


public class p05dbacfe : p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.ped942c55, javax.crypto.interfaces.DHPrivateKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb {
    static readonly long f563a3ddd = 4819350091141529678L;
    static readonly long f6a526eb9 = 4819350091141529678L;
    static readonly long f98b571c3 = 4819350091141529678L;
    static readonly long fc6e1e520 = 4819350091141529678L;
    static readonly long fff3a8e73 = 4819350091141529678L;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f02c98e89;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f201da641;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f f486a9c67;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f f808ee163;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f f8491d34a;
    java.math.Bigint f980c4ab0;
    java.math.Bigint f9d3a4837;
    java.math.Bigint f9dd4e461;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f fa23374fc;
    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f faf7f82ed;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 fc29bcd7d;
    java.math.Bigint fc52ee7e2;
    java.math.Bigint fc7a0f7d6;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 ffd26d290;

    protected p05dbacfe() {
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    p05dbacfe(javax.crypto.interfaces.DHPrivateKey dHPrivateKey) {
        if ((17 + 12) % 12 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = dHPrivateKey.getX();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(dHPrivateKey.getParams().getP(), dHPrivateKey.getParams().getG());
    }

    p05dbacfe(javax.crypto.spec.DHPrivateKeySpec dHPrivateKeySpec) {
        if ((6 + 10) % 10 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = dHPrivateKeySpec.getX();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(dHPrivateKeySpec.getP(), dHPrivateKeySpec.getG());
    }

    p05dbacfe(p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.ped942c55 ped942c55Var) {
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = ped942c55Var.getX();
        this.f808ee163 = ped942c55Var.getParameters();
    }

    p05dbacfe(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pfac79d82 pfac79d82Var) {
        if ((15 + 9) % 9 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = pfac79d82Var.getX();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(pfac79d82Var.getParams().getP(), pfac79d82Var.getParams().getG());
    }

    p05dbacfe(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8d0590d4 p8d0590d4Var) {
        if ((8 + 18) % 18 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = p8d0590d4Var.getX();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(p8d0590d4Var.getParameters().getP(), p8d0590d4Var.getParameters().getG());
    }

    p05dbacfe(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((8 + 21) % 21 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f p524aa06fVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters());
        this.f9dd4e461 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p811299f8Var.parsePrivateKey()).getValue();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f(p524aa06fVarM8bab0102.getP(), p524aa06fVarM8bab0102.getG());
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.writeobject(getX());
        objectStream.writeobject(this.f808ee163.getP());
        objectStream.writeobject(this.f808ee163.getG());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.io.IOException, java.lang.ClassNotFoundException {
        if ((7 + 17) % 17 > 0) {
        }
        this.f9dd4e461 = (java.math.Bigint) objectStream.readobject();
        this.f808ee163 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f((java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject());
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
        if ((19 + 18) % 18 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.m28fa3698(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f4d65be17, new p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f(this.f808ee163.getP(), this.f808ee163.getG())), new p5a445d71.p9f931cf3.pca323100.pf391b73d(getX()));
    }

    public override java.lang.string GetFormat() {
        return "PKCS#8";
    }

    public override p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pdcabce2f GetParameters() {
        return this.f808ee163;
    }

    public override javax.crypto.spec.DHParameterSpec GetParams() {
        if ((11 + 30) % 30 > 0) {
        }
        return new javax.crypto.spec.DHParameterSpec(this.f808ee163.getP(), this.f808ee163.getG());
    }

    public override java.math.Bigint GetX() {
        return this.f9dd4e461;
    }

    public override void SetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f201da641.setBagAttribute(p364bf33aVar, p0fd1bdf1Var);
    }
}

