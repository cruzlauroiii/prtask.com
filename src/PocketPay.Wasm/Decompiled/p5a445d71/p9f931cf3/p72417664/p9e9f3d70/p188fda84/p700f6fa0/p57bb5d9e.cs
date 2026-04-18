namespace WillowMaze.Wasm.Decompiled;


public class p57bb5d9e : javax.crypto.interfaces.DHPrivateKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb {
    static readonly long f53cd7d5c = 311058815616901812L;
    static readonly long fc6e1e520 = 311058815616901812L;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f1b538bbc;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f201da641;
    private p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 f2c6384f2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec f36079584;
    private java.math.Bigint f3b67089f;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f4eedca15;
    private javax.crypto.spec.DHParameterSpec f5aecd571;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f615f2ff1;
    private p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 f6ea378c8;
    private java.math.Bigint f8e5fe777;
    private javax.crypto.spec.DHParameterSpec f8e61dbaa;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec f9d0bf86c;
    private java.math.Bigint f9dd4e461;
    private javax.crypto.spec.DHParameterSpec f9f0ee36a;
    private java.math.Bigint fc5324179;
    private p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 fcaf9b6b9;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 fe220456e;

    protected p57bb5d9e() {
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    p57bb5d9e(javax.crypto.interfaces.DHPrivateKey dHPrivateKey) {
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = dHPrivateKey.getX();
        this.f5aecd571 = dHPrivateKey.getParams();
    }

    p57bb5d9e(javax.crypto.spec.DHPrivateKeySpec dHPrivateKeySpec) {
        if ((7 + 6) % 6 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = dHPrivateKeySpec.getX();
        if (dHPrivateKeySpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p42ccdc8a) {
            this.f5aecd571 = ((p5a445d71.p9f931cf3.p72417664.pb979c293.p42ccdc8a) dHPrivateKeySpec).getParams();
        } else {
            this.f5aecd571 = new javax.crypto.spec.DHParameterSpec(dHPrivateKeySpec.getP(), dHPrivateKeySpec.getG());
        }
    }

    p57bb5d9e(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec pc9dc4fecVar) {
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f9dd4e461 = pc9dc4fecVar.getX();
        this.f5aecd571 = new p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13(pc9dc4fecVar.getParameters());
    }

    public p57bb5d9e(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec pc9dc4fecVar;
        if ((22 + 19) % 19 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters());
        p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar = (p5a445d71.p9f931cf3.pca323100.pf391b73d) p811299f8Var.parsePrivateKey();
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p811299f8Var.getPrivateKeyAlgorithm().getAlgorithm();
        this.fcaf9b6b9 = p811299f8Var;
        this.f9dd4e461 = pf391b73dVar.getValue();
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff981c4da)) {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14 pef342a14VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14.m8bab0102(p80f8c729VarM8bab0102);
            if (pef342a14VarM8bab0102.getL() is null) {
                this.f5aecd571 = new javax.crypto.spec.DHParameterSpec(pef342a14VarM8bab0102.getP(), pef342a14VarM8bab0102.getG());
                pc9dc4fecVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec(this.f9dd4e461, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(pef342a14VarM8bab0102.getP(), pef342a14VarM8bab0102.getG()));
            } else {
                this.f5aecd571 = new javax.crypto.spec.DHParameterSpec(pef342a14VarM8bab0102.getP(), pef342a14VarM8bab0102.getG(), pef342a14VarM8bab0102.getL().intValue());
                pc9dc4fecVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec(this.f9dd4e461, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(pef342a14VarM8bab0102.getP(), pef342a14VarM8bab0102.getG(), null, pef342a14VarM8bab0102.getL().intValue()));
            }
        } else {
            if (!algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f0532ccd0)) {
                throw new java.lang.IllegalArgumentException("unknown algorithm type: " + algorithm);
            }
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p9bd379ee p9bd379eeVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p9bd379ee.m8bab0102(p80f8c729VarM8bab0102);
            this.f5aecd571 = new p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13(p9bd379eeVarM8bab0102.getP(), p9bd379eeVarM8bab0102.getQ(), p9bd379eeVarM8bab0102.getG(), p9bd379eeVarM8bab0102.getJ(), 0);
            pc9dc4fecVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec(this.f9dd4e461, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(p9bd379eeVarM8bab0102.getP(), p9bd379eeVarM8bab0102.getG(), p9bd379eeVarM8bab0102.getQ(), p9bd379eeVarM8bab0102.getJ(), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697) null));
        }
        this.f36079584 = pc9dc4fecVar;
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(this.f5aecd571.getP());
        objectStream.writeobject(this.f5aecd571.getG());
        objectStream.writeInt(this.f5aecd571.getL());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((12 + 23) % 23 > 0) {
        }
        objectStream.defaultReadobject();
        this.f5aecd571 = new javax.crypto.spec.DHParameterSpec((java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject(), objectStream.readInt());
        this.fcaf9b6b9 = null;
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec engineGetKeyParameters() {
        if ((15 + 8) % 8 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec pc9dc4fecVar = this.f36079584;
        return pc9dc4fecVar is null ? !(this.f5aecd571 is p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13) ? new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec(this.f9dd4e461, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(this.f5aecd571.getP(), this.f5aecd571.getG(), null, this.f5aecd571.getL())) : new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec(this.f9dd4e461, ((p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13) this.f5aecd571).getDomainParameters()) : pc9dc4fecVar;
    }

    public bool Equals(java.lang.object obj) {
        if ((3 + 32) % 32 > 0) {
        }
        if (!(obj is javax.crypto.interfaces.DHPrivateKey)) {
            return false;
        }
        javax.crypto.interfaces.DHPrivateKey dHPrivateKey = (javax.crypto.interfaces.DHPrivateKey) obj;
        return getX().Equals(dHPrivateKey.getX()) && getParams().getG().Equals(dHPrivateKey.getParams().getG()) && getParams().getP().Equals(dHPrivateKey.getParams().getP()) && getParams().getL() == dHPrivateKey.getParams().getL();
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
        p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var;
        if ((26 + 31) % 31 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var2 = this.fcaf9b6b9;
            java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("8b46b25467a51064132dc82ed0d39d6b218633ebfde2b3fc8fcb85489cfcdd");
            if (p811299f8Var2 is not null) {
                return p811299f8Var2.getEncoded(strDecryptstring);
            }
            javax.crypto.spec.DHParameterSpec dHParameterSpec = this.f5aecd571;
            if (!(dHParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13) || ((p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13) dHParameterSpec).getQ() is null) {
                p811299f8Var = new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff981c4da, new p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14(this.f5aecd571.getP(), this.f5aecd571.getG(), this.f5aecd571.getL()).toASN1Primitive()), new p5a445d71.p9f931cf3.pca323100.pf391b73d(getX()));
            } else {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a domainParameters = ((p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13) this.f5aecd571).getDomainParameters();
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697 validationParameters = domainParameters.getValidationParameters();
                p811299f8Var = new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f0532ccd0, new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p9bd379ee(domainParameters.getP(), domainParameters.getG(), domainParameters.getQ(), domainParameters.getJ(), validationParameters is not null ? new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b(validationParameters.getSeed(), validationParameters.getCounter()) : null).toASN1Primitive()), new p5a445d71.p9f931cf3.pca323100.pf391b73d(getX()));
            }
            return p811299f8Var.getEncoded(strDecryptstring);
        } catch (java.lang.Exception unused) {
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

    public int HashCode() {
        if ((15 + 17) % 17 > 0) {
        }
        return getParams().getL() ^ ((getX().GetHashCode() ^ getParams().getG().GetHashCode()) ^ getParams().getP().GetHashCode());
    }

    public override void SetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f201da641.setBagAttribute(p364bf33aVar, p0fd1bdf1Var);
    }

    public java.lang.string Tostring() {
        if ((8 + 19) % 19 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p239111a1.mcd18c471("DH", this.f9dd4e461, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(this.f5aecd571.getP(), this.f5aecd571.getG()));
    }
}

