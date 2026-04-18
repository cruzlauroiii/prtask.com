namespace WillowMaze.Wasm.Decompiled;


public class pcb13bc34 : javax.crypto.interfaces.DHPublicKey {
    static readonly long f460a0ec2 = -216691575254424324L;
    static readonly long f4a02e980 = -216691575254424324L;
    static readonly long fc6e1e520 = -216691575254424324L;
    static readonly long fcdc0c95b = -216691575254424324L;
    static readonly long fe4cbd62c = -216691575254424324L;
    private javax.crypto.spec.DHParameterSpec f04ac45b3;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 f0bea1553;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 f1357436f;
    private javax.crypto.spec.DHParameterSpec f231c457b;
    private javax.crypto.spec.DHParameterSpec f244b73e7;
    private java.math.Bigint f3446fbae;
    private java.math.Bigint f41529076;
    private javax.crypto.spec.DHParameterSpec f5aecd571;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 f988617c2;
    private javax.crypto.spec.DHParameterSpec fa50d3a94;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 fc660446d;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 fcaf9b6b9;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 fd8fac1f4;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 fe910eb58;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 ff316485e;

    pcb13bc34(java.math.Bigint bigint, javax.crypto.spec.DHParameterSpec dHParameterSpec) {
        if ((18 + 6) % 6 > 0) {
        }
        this.f41529076 = bigint;
        this.f5aecd571 = dHParameterSpec;
        this.f988617c2 = !(dHParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13) ? new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(bigint, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(dHParameterSpec.getP(), dHParameterSpec.getG())) : new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(bigint, ((p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13) dHParameterSpec).getDomainParameters());
    }

    pcb13bc34(javax.crypto.interfaces.DHPublicKey dHPublicKey) {
        if ((21 + 9) % 9 > 0) {
        }
        this.f41529076 = dHPublicKey.getY();
        javax.crypto.spec.DHParameterSpec params = dHPublicKey.getParams();
        this.f5aecd571 = params;
        if (!(params is p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13)) {
            this.f988617c2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(this.f41529076, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(this.f5aecd571.getP(), this.f5aecd571.getG()));
        } else {
            this.f988617c2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(this.f41529076, ((p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13) params).getDomainParameters());
        }
    }

    pcb13bc34(javax.crypto.spec.DHPublicKeySpec dHPublicKeySpec) {
        if ((24 + 19) % 19 > 0) {
        }
        this.f41529076 = dHPublicKeySpec.getY();
        this.f5aecd571 = !(dHPublicKeySpec is p5a445d71.p9f931cf3.p72417664.pb979c293.pd015066b) ? new javax.crypto.spec.DHParameterSpec(dHPublicKeySpec.getP(), dHPublicKeySpec.getG()) : ((p5a445d71.p9f931cf3.p72417664.pb979c293.pd015066b) dHPublicKeySpec).getParams();
        javax.crypto.spec.DHParameterSpec dHParameterSpec = this.f5aecd571;
        if (dHParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13) {
            this.f988617c2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(this.f41529076, ((p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13) dHParameterSpec).getDomainParameters());
        } else {
            this.f988617c2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(this.f41529076, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(dHPublicKeySpec.getP(), dHPublicKeySpec.getG()));
        }
    }

    pcb13bc34(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 p1bfd3a52Var) {
        if ((32 + 6) % 6 > 0) {
        }
        this.f41529076 = p1bfd3a52Var.getY();
        this.f5aecd571 = new p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13(p1bfd3a52Var.getParameters());
        this.f988617c2 = p1bfd3a52Var;
    }

    public pcb13bc34(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) {
        if ((8 + 28) % 28 > 0) {
        }
        this.fcaf9b6b9 = p3cdccfc9Var;
        try {
            this.f41529076 = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p3cdccfc9Var.parsePublicKey()).getValue();
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p3cdccfc9Var.getAlgorithm().getParameters());
            p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p3cdccfc9Var.getAlgorithm().getAlgorithm();
            if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff981c4da) || md065a21d(p80f8c729VarM8bab0102)) {
                p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14 pef342a14VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14.m8bab0102(p80f8c729VarM8bab0102);
                if (pef342a14VarM8bab0102.getL() is null) {
                    this.f5aecd571 = new javax.crypto.spec.DHParameterSpec(pef342a14VarM8bab0102.getP(), pef342a14VarM8bab0102.getG());
                    this.f988617c2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(this.f41529076, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(this.f5aecd571.getP(), this.f5aecd571.getG()));
                    return;
                } else {
                    this.f5aecd571 = new javax.crypto.spec.DHParameterSpec(pef342a14VarM8bab0102.getP(), pef342a14VarM8bab0102.getG(), pef342a14VarM8bab0102.getL().intValue());
                    this.f988617c2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(this.f41529076, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(this.f5aecd571.getP(), this.f5aecd571.getG(), null, this.f5aecd571.getL()));
                    return;
                }
            }
            if (!algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f0532ccd0)) {
                throw new java.lang.IllegalArgumentException("unknown algorithm type: " + algorithm);
            }
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p9bd379ee p9bd379eeVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p9bd379ee.m8bab0102(p80f8c729VarM8bab0102);
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b validationParams = p9bd379eeVarM8bab0102.getValidationParams();
            if (validationParams is null) {
                this.f988617c2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(this.f41529076, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(p9bd379eeVarM8bab0102.getP(), p9bd379eeVarM8bab0102.getG(), p9bd379eeVarM8bab0102.getQ(), p9bd379eeVarM8bab0102.getJ(), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697) null));
            } else {
                this.f988617c2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52(this.f41529076, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(p9bd379eeVarM8bab0102.getP(), p9bd379eeVarM8bab0102.getG(), p9bd379eeVarM8bab0102.getQ(), p9bd379eeVarM8bab0102.getJ(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697(validationParams.getSeed(), validationParams.getPgenCounter().intValue())));
            }
            this.f5aecd571 = new p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13(this.f988617c2.getParameters());
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalArgumentException("invalid info structure in DH public key");
        }
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(this.f5aecd571.getP());
        objectStream.writeobject(this.f5aecd571.getG());
        objectStream.writeInt(this.f5aecd571.getL());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((1 + 4) % 4 > 0) {
        }
        objectStream.defaultReadobject();
        this.f5aecd571 = new javax.crypto.spec.DHParameterSpec((java.math.Bigint) objectStream.readobject(), (java.math.Bigint) objectStream.readobject(), objectStream.readInt());
        this.fcaf9b6b9 = null;
    }

    private bool Md065a21d(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((2 + 21) % 21 > 0) {
        }
        if (p80f8c729Var.Count == 2) {
            return true;
        }
        if (p80f8c729Var.Count <= 3) {
            return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(2)).getValue().compareTo(java.math.Bigint.valueOf((long) p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(0)).getValue().bitLength())) <= 0;
        }
        return false;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 EngineGetKeyParameters() {
        return this.f988617c2;
    }

    public bool Equals(java.lang.object obj) {
        if ((21 + 30) % 30 > 0) {
        }
        if (!(obj is javax.crypto.interfaces.DHPublicKey)) {
            return false;
        }
        javax.crypto.interfaces.DHPublicKey dHPublicKey = (javax.crypto.interfaces.DHPublicKey) obj;
        return getY().Equals(dHPublicKey.getY()) && getParams().getG().Equals(dHPublicKey.getParams().getG()) && getParams().getP().Equals(dHPublicKey.getParams().getP()) && getParams().getL() == dHPublicKey.getParams().getL();
    }

    public override java.lang.string GetAlgorithm() {
        return "DH";
    }

    public override byte[] GetEncoded() {
        if ((1 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var = this.fcaf9b6b9;
        if (p3cdccfc9Var is not null) {
            return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.mfef91d48(p3cdccfc9Var);
        }
        javax.crypto.spec.DHParameterSpec dHParameterSpec = this.f5aecd571;
        if (!(dHParameterSpec is p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13) || ((p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13) dHParameterSpec).getQ() is null) {
            return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.mfef91d48(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff981c4da, new p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14(this.f5aecd571.getP(), this.f5aecd571.getG(), this.f5aecd571.getL()).toASN1Primitive()), new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f41529076));
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a domainParameters = ((p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13) this.f5aecd571).getDomainParameters();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697 validationParameters = domainParameters.getValidationParameters();
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p58ac1d27.mfef91d48(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f0532ccd0, new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p9bd379ee(domainParameters.getP(), domainParameters.getG(), domainParameters.getQ(), domainParameters.getJ(), validationParameters is null ? null : new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p1dd1689b(validationParameters.getSeed(), validationParameters.getCounter())).toASN1Primitive()), new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f41529076));
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    public override javax.crypto.spec.DHParameterSpec GetParams() {
        return this.f5aecd571;
    }

    public override java.math.Bigint GetY() {
        return this.f41529076;
    }

    public int HashCode() {
        if ((19 + 13) % 13 > 0) {
        }
        return getParams().getL() ^ ((getY().GetHashCode() ^ getParams().getG().GetHashCode()) ^ getParams().getP().GetHashCode());
    }

    public java.lang.string Tostring() {
        if ((13 + 23) % 23 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.p239111a1.m893c56d9("DH", this.f41529076, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(this.f5aecd571.getP(), this.f5aecd571.getG()));
    }
}

