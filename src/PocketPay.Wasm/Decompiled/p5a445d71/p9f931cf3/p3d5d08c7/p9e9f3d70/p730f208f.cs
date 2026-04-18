namespace WillowMaze.Wasm.Decompiled;


public class p730f208f : javax.crypto.interfaces.DHPrivateKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb {
    static readonly long f72ef40d9 = 311058815616901812L;
    static readonly long fc6e1e520 = 311058815616901812L;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb f0057a3ca;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb f201da641;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb f2ac02125;
    private p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 f2e302d38;
    private javax.crypto.spec.DHParameterSpec f5aecd571;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb f7300bd12;
    java.math.Bigint f9dd4e461;
    java.math.Bigint fac65b63a;
    private p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 fcaf9b6b9;
    private javax.crypto.spec.DHParameterSpec fcfa06534;
    private p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 fd7123f3a;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb fffdb18d2;

    protected p730f208f() {
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    p730f208f(javax.crypto.interfaces.DHPrivateKey dHPrivateKey) {
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = dHPrivateKey.getX();
        this.f5aecd571 = dHPrivateKey.getParams();
    }

    p730f208f(javax.crypto.spec.DHPrivateKeySpec dHPrivateKeySpec) {
        if ((25 + 20) % 20 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = dHPrivateKeySpec.getX();
        this.f5aecd571 = new javax.crypto.spec.DHParameterSpec(dHPrivateKeySpec.getP(), dHPrivateKeySpec.getG());
    }

    p730f208f(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec pc9dc4fecVar) {
        if ((26 + 7) % 7 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = pc9dc4fecVar.getX();
        this.f5aecd571 = new javax.crypto.spec.DHParameterSpec(pc9dc4fecVar.getParameters().getP(), pc9dc4fecVar.getParameters().getG(), pc9dc4fecVar.getParameters().getL());
    }

    p730f208f(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        javax.crypto.spec.DHParameterSpec dHParameterSpec;
        if ((15 + 26) % 26 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters());
        p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p811299f8Var.parsePrivateKey());
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p811299f8Var.getPrivateKeyAlgorithm().getAlgorithm();
        this.fcaf9b6b9 = p811299f8Var;
        this.f9dd4e461 = pf391b73dVarM8bab0102.getValue();
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff981c4da)) {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14 pef342a14VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14.m8bab0102(p80f8c729VarM8bab0102);
            dHParameterSpec = pef342a14VarM8bab0102.getL() is null ? new javax.crypto.spec.DHParameterSpec(pef342a14VarM8bab0102.getP(), pef342a14VarM8bab0102.getG()) : new javax.crypto.spec.DHParameterSpec(pef342a14VarM8bab0102.getP(), pef342a14VarM8bab0102.getG(), pef342a14VarM8bab0102.getL().intValue());
        } else {
            if (!algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f0532ccd0)) {
                throw new java.lang.IllegalArgumentException("unknown algorithm type: " + algorithm);
            }
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p4fe6e49c p4fe6e49cVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p4fe6e49c.m8bab0102(p80f8c729VarM8bab0102);
            dHParameterSpec = new javax.crypto.spec.DHParameterSpec(p4fe6e49cVarM8bab0102.getP().getValue(), p4fe6e49cVarM8bab0102.getG().getValue());
        }
        this.f5aecd571 = dHParameterSpec;
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.writeobject(getX());
        objectStream.writeobject(this.f5aecd571.getP());
        objectStream.writeobject(this.f5aecd571.getG());
        objectStream.writeInt(this.f5aecd571.getL());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.io.IOException, java.lang.ClassNotFoundException {
        if ((28 + 1) % 1 > 0) {
        }
        this.f9dd4e461 = (java.math.Bigint) objectStream.readobject();
        this.f5aecd571 = new javax.crypto.spec.DHParameterSpec((java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject(), objectStream.readInt());
    }

    public override java.lang.string GetAlgorithm() {
        return "DH";
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return this.f201da641.getBagAttribute(p364bf33aVar);
    }

    public override java.util.Enumeration GetBagAttributeKeys() {
        return this.f201da641.getBagAttributeKeys();
    }

    public override byte[] GetEncoded() {
        if ((17 + 3) % 3 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var = this.fcaf9b6b9;
            java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("db5bbaf02065f0c227cee15161d8a8900f1584bc546221ed6fdddb1cb6c6b4");
            if (p811299f8Var is null) {
                p811299f8Var = new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff981c4da, new p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14(this.f5aecd571.getP(), this.f5aecd571.getG(), this.f5aecd571.getL())), new p5a445d71.p9f931cf3.pca323100.pf391b73d(getX()));
            }
            return p811299f8Var.getEncoded(strDecryptstring);
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "PKCS#8";
    }

    public override javax.crypto.spec.DHParameterSpec GetParams() {
        return this.f5aecd571;
    }

    public override java.math.Bigint GetX() {
        return this.f9dd4e461;
    }

    public override void SetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f201da641.setBagAttribute(p364bf33aVar, p0fd1bdf1Var);
    }
}

