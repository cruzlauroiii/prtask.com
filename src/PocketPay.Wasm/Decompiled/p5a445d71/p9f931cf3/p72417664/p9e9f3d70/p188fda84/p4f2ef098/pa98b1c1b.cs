namespace WillowMaze.Wasm.Decompiled;


public class pa98b1c1b : java.security.interfaces.ECPrivateKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5eff85bc, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pb45a567f {
    static readonly long f018bc8e7 = 7245981689601667138L;
    static readonly long fa535f88b = 7245981689601667138L;
    static readonly long fbf3859be = 7245981689601667138L;
    static readonly long fc6e1e520 = 7245981689601667138L;
    static readonly long ff7dbd904 = 7245981689601667138L;
    private java.math.Bigint f0a748a7b;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f201da641;
    private java.security.spec.ECParameterSpec f33c0f968;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f5404f7d1;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 f572d1488;
    private java.math.Bigint f8277e091;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f8a3cc8e0;
    private bool fa04a9104;
    private java.security.spec.ECParameterSpec fac16015d;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 fc36853ea;
    private java.security.spec.ECParameterSpec fd5a34115;
    private bool fdd0becbf;
    private java.lang.string fe0d74e7a;
    private bool fe180b073;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 fe264b8ba;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 fed38925d;
    private java.lang.string fed469618;
    private java.math.Bigint ff26a844d;
    private java.math.Bigint ff67590f4;

    protected pa98b1c1b() {
        this.fed469618 = "DSTU4145";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    public pa98b1c1b(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar) {
        this.fed469618 = "DSTU4145";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = p06022b5aVar.getD();
        this.f33c0f968 = null;
    }

    public pa98b1c1b(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p75258f69 p75258f69Var, java.security.spec.ECParameterSpec eCParameterSpec) {
        if ((30 + 23) % 23 > 0) {
        }
        this.fed469618 = "DSTU4145";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = p06022b5aVar.getParameters();
        this.fed469618 = str;
        this.f8277e091 = p06022b5aVar.getD();
        if (eCParameterSpec is not null) {
            this.f33c0f968 = eCParameterSpec;
        } else {
            this.f33c0f968 = new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(parameters.getG()), parameters.getN(), parameters.getH().intValue());
        }
        this.fc36853ea = mf2f0750f(p75258f69Var);
    }

    public pa98b1c1b(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p75258f69 p75258f69Var, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var) {
        if ((12 + 28) % 28 > 0) {
        }
        this.fed469618 = "DSTU4145";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = p06022b5aVar.getParameters();
        this.fed469618 = str;
        this.f8277e091 = p06022b5aVar.getD();
        this.f33c0f968 = p835df581Var is not null ? new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p835df581Var.getCurve(), p835df581Var.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p835df581Var.getG()), p835df581Var.getN(), p835df581Var.getH().intValue()) : new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(parameters.getG()), parameters.getN(), parameters.getH().intValue());
        this.fc36853ea = mf2f0750f(p75258f69Var);
    }

    public pa98b1c1b(java.security.interfaces.ECPrivateKey eCPrivateKey) {
        this.fed469618 = "DSTU4145";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f8277e091 = eCPrivateKey.getS();
        this.fed469618 = eCPrivateKey.getAlgorithm();
        this.f33c0f968 = eCPrivateKey.getParams();
    }

    public pa98b1c1b(java.security.spec.ECPrivateKeySpec eCPrivateKeySpec) {
        this.fed469618 = "DSTU4145";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f8277e091 = eCPrivateKeySpec.getS();
        this.f33c0f968 = eCPrivateKeySpec.getParams();
    }

    public pa98b1c1b(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p7ae61a0e p7ae61a0eVar) {
        if ((12 + 20) % 20 > 0) {
        }
        this.fed469618 = "DSTU4145";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f8277e091 = p7ae61a0eVar.getD();
        this.f33c0f968 = p7ae61a0eVar.getParams() is null ? null : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p7ae61a0eVar.getParams().getCurve(), p7ae61a0eVar.getParams().getSeed()), p7ae61a0eVar.getParams());
    }

    public pa98b1c1b(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.pa98b1c1b pa98b1c1bVar) {
        this.fed469618 = "DSTU4145";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f8277e091 = pa98b1c1bVar.f8277e091;
        this.f33c0f968 = pa98b1c1bVar.f33c0f968;
        this.fa04a9104 = pa98b1c1bVar.fa04a9104;
        this.f201da641 = pa98b1c1bVar.f201da641;
        this.fc36853ea = pa98b1c1bVar.fc36853ea;
    }

    pa98b1c1b(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        this.fed469618 = "DSTU4145";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        m14800f1c(p811299f8Var);
    }

    private void M14800f1c(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var;
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d p698f972dVar;
        if ((23 + 1) % 1 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters());
        if (p15be22c4VarM8bab0102.isNamedCurve()) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(p15be22c4VarM8bab0102.getParameters());
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMf7b916f7 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mf7b916f7(p364bf33aVarM8bab0102);
            if (p35e46fcbVarMf7b916f7 is not null) {
                p698f972dVar = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m6720e003(p364bf33aVarM8bab0102), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p35e46fcbVarMf7b916f7.getCurve(), p35e46fcbVarMf7b916f7.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p35e46fcbVarMf7b916f7.getG()), p35e46fcbVarMf7b916f7.getN(), p35e46fcbVarMf7b916f7.getH());
            } else {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74VarMd0402605 = p5a445d71.p9f931cf3.pca323100.p5269f4d7.p7eca5bf5.md0402605(p364bf33aVarM8bab0102);
                p698f972dVar = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(p364bf33aVarM8bab0102.getId(), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p21c2eb74VarMd0402605.getCurve(), p21c2eb74VarMd0402605.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p21c2eb74VarMd0402605.getG()), p21c2eb74VarMd0402605.getN(), p21c2eb74VarMd0402605.getH());
            }
            this.f33c0f968 = p698f972dVar;
        } else if (p15be22c4VarM8bab0102.isImplicitlyCA()) {
            this.f33c0f968 = null;
        } else {
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p15be22c4VarM8bab0102.getParameters());
            if (p80f8c729VarM8bab0102.getobjectAt(0) instanceof p5a445d71.p9f931cf3.pca323100.pf391b73d) {
                p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb.m8bab0102(p15be22c4VarM8bab0102.getParameters());
                this.f33c0f968 = new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p35e46fcbVarM8bab0102.getCurve(), p35e46fcbVarM8bab0102.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p35e46fcbVarM8bab0102.getG()), p35e46fcbVarM8bab0102.getN(), p35e46fcbVarM8bab0102.getH().intValue());
            } else {
                p5a445d71.p9f931cf3.pca323100.p5269f4d7.pd0c474c0 pd0c474c0VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p5269f4d7.pd0c474c0.m8bab0102(p80f8c729VarM8bab0102);
                if (pd0c474c0VarM8bab0102.isNamedCurve()) {
                    p5a445d71.p9f931cf3.pca323100.p364bf33a namedCurve = pd0c474c0VarM8bab0102.getNamedCurve();
                    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74VarMd04026052 = p5a445d71.p9f931cf3.pca323100.p5269f4d7.p7eca5bf5.md0402605(namedCurve);
                    p835df581Var = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f(namedCurve.getId(), p21c2eb74VarMd04026052.getCurve(), p21c2eb74VarMd04026052.getG(), p21c2eb74VarMd04026052.getN(), p21c2eb74VarMd04026052.getH(), p21c2eb74VarMd04026052.getSeed());
                } else {
                    p5a445d71.p9f931cf3.pca323100.p5269f4d7.p9809e203 eCBinary = pd0c474c0VarM8bab0102.getECBinary();
                    byte[] b = eCBinary.getB();
                    if (p811299f8Var.getPrivateKeyAlgorithm().getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.febfd0a5a)) {
                        m5b145bd6(b);
                    }
                    p5a445d71.p9f931cf3.pca323100.p5269f4d7.p1ce9a908 field = eCBinary.getField();
                    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p73b12670 pa827ecfa_p73b12670 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p73b12670(field.getM(), field.getK1(), field.getK2(), field.getK3(), eCBinary.getA(), new java.math.Bigint(1, b));
                    byte[] g = eCBinary.getG();
                    if (p811299f8Var.getPrivateKeyAlgorithm().getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.febfd0a5a)) {
                        m5b145bd6(g);
                    }
                    p835df581Var = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581(pa827ecfa_p73b12670, p5a445d71.p9f931cf3.pca323100.p5269f4d7.p7e77a2b9.me32531cf(pa827ecfa_p73b12670, g), eCBinary.getN());
                }
                this.f33c0f968 = new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p835df581Var.getCurve(), p835df581Var.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p835df581Var.getG()), p835df581Var.getN(), p835df581Var.getH().intValue());
            }
        }
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 privateKey = p811299f8Var.parsePrivateKey();
        if (privateKey is p5a445d71.p9f931cf3.pca323100.pf391b73d) {
            this.f8277e091 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(privateKey).getValue();
            return;
        }
        p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc p5eff85bcVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc.m8bab0102(privateKey);
        this.f8277e091 = p5eff85bcVarM8bab0102.getKey();
        this.fc36853ea = p5eff85bcVarM8bab0102.getPublicKey();
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(getEncoded());
    }

    private void M5b145bd6(byte[] bArr) {
        if ((27 + 22) % 22 > 0) {
        }
        for (int i = 0; i < bArr.length / 2; i++) {
            byte b = bArr[i];
            bArr[i] = bArr[(bArr.length - 1) - i];
            bArr[(bArr.length - 1) - i] = b;
        }
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        m14800f1c(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46((byte[]) objectStream.readobject())));
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    private p5a445d71.p9f931cf3.pca323100.p29d19857 Mf2f0750f(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.p75258f69 p75258f69Var) {
        try {
            return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(p75258f69Var.getEncoded())).getPublicKeyData();
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 engineGetSpec() {
        java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
        return eCParameterSpec is null ? p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa() : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(eCParameterSpec);
    }

    public bool Equals(java.lang.object obj) {
        if ((21 + 1) % 1 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.pa98b1c1b)) {
            return false;
        }
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.pa98b1c1b pa98b1c1bVar = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p4f2ef098.pa98b1c1b) obj;
        return getD().Equals(pa98b1c1bVar.getD()) && engineGetSpec().Equals(pa98b1c1bVar.engineGetSpec());
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
        int iM20664f91;
        if ((32 + 20) % 20 > 0) {
        }
        java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
        try {
            if (!(eCParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d)) {
                if (eCParameterSpec is not null) {
                    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarM2ace2977 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(eCParameterSpec.getCurve());
                    p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb(pa827ecfaVarM2ace2977, new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(pa827ecfaVarM2ace2977, this.f33c0f968.getGenerator()), this.fa04a9104), this.f33c0f968.getOrder(), java.math.Bigint.valueOf(this.f33c0f968.getCofactor()), this.f33c0f968.getCurve().getSeed()));
                } else {
                    p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4((p5a445d71.p9f931cf3.pca323100.pb9fa8367) p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17);
                    iM20664f91 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m20664f91(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea, null, getS());
                }
                p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc p5eff85bcVar = this.fc36853ea is null ? new p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc(iM20664f91, getS(), p15be22c4Var) : new p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc(iM20664f91, getS(), this.fc36853ea, p15be22c4Var);
                return (this.fed469618.Equals("DSTU4145") ? new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f88f12a25, p15be22c4Var.toASN1Primitive()), p5eff85bcVar.toASN1Primitive()) : new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f070fb7e3, p15be22c4Var.toASN1Primitive()), p5eff85bcVar.toASN1Primitive())).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("3a6fb68b90bde035873a1a2d6278d4a32ef44537deda0fafdb8b7796f2fd69"));
            }
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM9a2b7f82 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m9a2b7f82(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) eCParameterSpec).getName());
            if (p364bf33aVarM9a2b7f82 is null) {
                p364bf33aVarM9a2b7f82 = new p5a445d71.p9f931cf3.pca323100.p364bf33a(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) this.f33c0f968).getName());
            }
            p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(p364bf33aVarM9a2b7f82);
            return (this.fed469618.Equals("DSTU4145") ? new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.f88f12a25, p15be22c4Var.toASN1Primitive()), p5eff85bcVar.toASN1Primitive()) : new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f070fb7e3, p15be22c4Var.toASN1Primitive()), p5eff85bcVar.toASN1Primitive())).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("3a6fb68b90bde035873a1a2d6278d4a32ef44537deda0fafdb8b7796f2fd69"));
        } catch (java.io.IOException unused) {
            return null;
        }
        iM20664f91 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m20664f91(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea, this.f33c0f968.getOrder(), getS());
        if (this.fc36853ea is null) {
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
        if ((27 + 2) % 2 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mcd18c471(this.fed469618, this.f8277e091, engineGetSpec());
    }
}

