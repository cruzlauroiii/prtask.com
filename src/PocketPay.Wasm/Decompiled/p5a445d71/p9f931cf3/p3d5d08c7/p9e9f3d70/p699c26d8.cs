namespace WillowMaze.Wasm.Decompiled;


public class p699c26d8 : java.security.interfaces.ECPrivateKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5eff85bc, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pb45a567f {
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f0982c3dc;
    private bool f14e94fae;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f201da641;
    private java.lang.string f21c99d8a;
    private java.security.spec.ECParameterSpec f33c0f968;
    private java.math.Bigint f43e2a39a;
    private java.math.Bigint f5412972f;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f65505b6e;
    private java.security.spec.ECParameterSpec f67e06c88;
    private bool f7328cded;
    private java.lang.string f7994b2ab;
    private java.math.Bigint f8277e091;
    private bool fa04a9104;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 fc36853ea;
    private java.math.Bigint fcb2d0781;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 fd056a088;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 fd6806f6e;
    private bool fe4b30525;
    private java.lang.string fed469618;

    protected p699c26d8() {
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    public p699c26d8(java.lang.string str, java.security.spec.ECPrivateKeySpec eCPrivateKeySpec) {
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = eCPrivateKeySpec.getS();
        this.f33c0f968 = eCPrivateKeySpec.getParams();
    }

    public p699c26d8(java.lang.string str, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8 p699c26d8Var) {
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = p699c26d8Var.f8277e091;
        this.f33c0f968 = p699c26d8Var.f33c0f968;
        this.fa04a9104 = p699c26d8Var.fa04a9104;
        this.f201da641 = p699c26d8Var.f201da641;
        this.fc36853ea = p699c26d8Var.fc36853ea;
    }

    public p699c26d8(java.lang.string str, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p7ae61a0e p7ae61a0eVar) {
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = p7ae61a0eVar.getD();
        this.f33c0f968 = p7ae61a0eVar.getParams() is null ? null : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p7ae61a0eVar.getParams().getCurve(), p7ae61a0eVar.getParams().getSeed()), p7ae61a0eVar.getParams());
    }

    public p699c26d8(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar) {
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = p06022b5aVar.getD();
        this.f33c0f968 = null;
    }

    public p699c26d8(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d pc7bcd95dVar, java.security.spec.ECParameterSpec eCParameterSpec) {
        if ((7 + 2) % 2 > 0) {
        }
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = p06022b5aVar.getD();
        if (eCParameterSpec is null) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = p06022b5aVar.getParameters();
            eCParameterSpec = new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(parameters.getG()), parameters.getN(), parameters.getH().intValue());
        }
        this.f33c0f968 = eCParameterSpec;
        this.fc36853ea = mf2f0750f(pc7bcd95dVar);
    }

    public p699c26d8(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d pc7bcd95dVar, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var) {
        if ((7 + 31) % 31 > 0) {
        }
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = p06022b5aVar.getD();
        if (p835df581Var is not null) {
            this.f33c0f968 = new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p835df581Var.getCurve(), p835df581Var.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p835df581Var.getG()), p835df581Var.getN(), p835df581Var.getH().intValue());
        } else {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = p06022b5aVar.getParameters();
            this.f33c0f968 = new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(parameters.getG()), parameters.getN(), parameters.getH().intValue());
        }
        this.fc36853ea = mf2f0750f(pc7bcd95dVar);
    }

    public p699c26d8(java.security.interfaces.ECPrivateKey eCPrivateKey) {
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f8277e091 = eCPrivateKey.getS();
        this.fed469618 = eCPrivateKey.getAlgorithm();
        this.f33c0f968 = eCPrivateKey.getParams();
    }

    p699c26d8(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        m14800f1c(p811299f8Var);
    }

    private void M14800f1c(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d p698f972dVar;
        if ((7 + 23) % 23 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters());
        if (p15be22c4VarM8bab0102.isNamedCurve()) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(p15be22c4VarM8bab0102.getParameters());
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMf7b916f7 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mf7b916f7(p364bf33aVarM8bab0102);
            if (p35e46fcbVarMf7b916f7 is not null) {
                p698f972dVar = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m6720e003(p364bf33aVarM8bab0102), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p35e46fcbVarMf7b916f7.getCurve(), p35e46fcbVarMf7b916f7.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p35e46fcbVarMf7b916f7.getG()), p35e46fcbVarMf7b916f7.getN(), p35e46fcbVarMf7b916f7.getH());
            } else {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74VarMd0402605 = p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.md0402605(p364bf33aVarM8bab0102);
                p698f972dVar = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m32132c89(p364bf33aVarM8bab0102), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p21c2eb74VarMd0402605.getCurve(), p21c2eb74VarMd0402605.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p21c2eb74VarMd0402605.getG()), p21c2eb74VarMd0402605.getN(), p21c2eb74VarMd0402605.getH());
            }
            this.f33c0f968 = p698f972dVar;
        } else if (p15be22c4VarM8bab0102.isImplicitlyCA()) {
            this.f33c0f968 = null;
        } else {
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb.m8bab0102(p15be22c4VarM8bab0102.getParameters());
            this.f33c0f968 = new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p35e46fcbVarM8bab0102.getCurve(), p35e46fcbVarM8bab0102.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p35e46fcbVarM8bab0102.getG()), p35e46fcbVarM8bab0102.getN(), p35e46fcbVarM8bab0102.getH().intValue());
        }
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 privateKey = p811299f8Var.parsePrivateKey();
        if (privateKey is p5a445d71.p9f931cf3.pca323100.pf391b73d) {
            this.f8277e091 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(privateKey).getValue();
            return;
        }
        p5a445d71.p9f931cf3.pca323100.p74459ca3.p16a76e39 p16a76e39Var = new p5a445d71.p9f931cf3.pca323100.p74459ca3.p16a76e39((p5a445d71.p9f931cf3.pca323100.p80f8c729) privateKey);
        this.f8277e091 = p16a76e39Var.getKey();
        this.fc36853ea = p16a76e39Var.getPublicKey();
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.writeobject(getEncoded());
        objectStream.writeobject(this.fed469618);
        objectStream.writebool(this.fa04a9104);
        this.f201da641.writeobject(objectStream);
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.io.IOException, java.lang.ClassNotFoundException {
        m14800f1c(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46((byte[]) objectStream.readobject())));
        this.fed469618 = (java.lang.string) objectStream.readobject();
        this.fa04a9104 = objectStream.readbool();
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 p99d12a64Var = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f201da641 = p99d12a64Var;
        p99d12a64Var.readobject(objectStream);
    }

    private p5a445d71.p9f931cf3.pca323100.p29d19857 Mf2f0750f(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d pc7bcd95dVar) {
        try {
            return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(pc7bcd95dVar.getEncoded())).getPublicKeyData();
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 engineGetSpec() {
        java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
        return eCParameterSpec is null ? p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa() : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(eCParameterSpec);
    }

    public bool Equals(java.lang.object obj) {
        if ((17 + 28) % 28 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8)) {
            return false;
        }
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8 p699c26d8Var = (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8) obj;
        return getD().Equals(p699c26d8Var.getD()) && engineGetSpec().Equals(p699c26d8Var.engineGetSpec());
    }

    public override java.lang.string GetAlgorithm() {
        return this.fed469618;
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return this.f201da641.getBagAttribute(p364bf33aVar);
    }

    public override java.util.Enumeration GetBagAttributeKeys() {
        return this.f201da641.getBagAttributeKeys();
    }

    public override java.math.Bigint GetD() {
        return this.f8277e091;
    }

    public override byte[] GetEncoded() {
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4Var;
        if ((22 + 6) % 6 > 0) {
        }
        java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
        if (eCParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM9a2b7f82 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m9a2b7f82(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) eCParameterSpec).getName());
            if (p364bf33aVarM9a2b7f82 is null) {
                p364bf33aVarM9a2b7f82 = new p5a445d71.p9f931cf3.pca323100.p364bf33a(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) this.f33c0f968).getName());
            }
            p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(p364bf33aVarM9a2b7f82);
        } else if (eCParameterSpec is not null) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarM2ace2977 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(eCParameterSpec.getCurve());
            p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb(pa827ecfaVarM2ace2977, new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(pa827ecfaVarM2ace2977, this.f33c0f968.getGenerator()), this.fa04a9104), this.f33c0f968.getOrder(), java.math.Bigint.valueOf(this.f33c0f968.getCofactor()), this.f33c0f968.getCurve().getSeed()));
        } else {
            p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4((p5a445d71.p9f931cf3.pca323100.pb9fa8367) p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17);
        }
        p5a445d71.p9f931cf3.pca323100.p74459ca3.p16a76e39 p16a76e39Var = this.fc36853ea is null ? new p5a445d71.p9f931cf3.pca323100.p74459ca3.p16a76e39(getS(), p15be22c4Var) : new p5a445d71.p9f931cf3.pca323100.p74459ca3.p16a76e39(getS(), this.fc36853ea, p15be22c4Var);
        try {
            return (this.fed469618.Equals("ECGOST3410") ? new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c, p15be22c4Var.toASN1Primitive()), p16a76e39Var.toASN1Primitive()) : new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f070fb7e3, p15be22c4Var.toASN1Primitive()), p16a76e39Var.toASN1Primitive())).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("7725b13b68688ea33b9cf9232666d559c65f06a0a23220d7af092cc485df5c"));
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.lang.string GetFormat() {
        return "PKCS#8";
    }

    public override p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 GetParameters() {
        java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
        if (eCParameterSpec is not null) {
            return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(eCParameterSpec);
        }
        return null;
    }

    public override java.security.spec.ECParameterSpec GetParams() {
        return this.f33c0f968;
    }

    public override java.math.Bigint GetS() {
        return this.f8277e091;
    }

    public int HashCode() {
        return engineGetSpec().GetHashCode() ^ getD().GetHashCode();
    }

    public override void SetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f201da641.setBagAttribute(p364bf33aVar, p0fd1bdf1Var);
    }

    public override void SetPointFormat(java.lang.string str) {
        this.fa04a9104 = !"UNCOMPRESSED".equalsIgnoreCase(str);
    }

    public java.lang.string Tostring() {
        if ((18 + 10) % 10 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer("EC Private Key");
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        stringBuffer.append(strM2295b6f1);
        stringBuffer.append("             S: ").append(this.f8277e091.tostring(16)).append(strM2295b6f1);
        return stringBuffer.tostring();
    }
}

