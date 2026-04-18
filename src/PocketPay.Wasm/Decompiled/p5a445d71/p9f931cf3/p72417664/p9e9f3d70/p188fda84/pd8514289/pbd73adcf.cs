namespace WillowMaze.Wasm.Decompiled;


public class pbd73adcf : java.security.interfaces.ECPrivateKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5eff85bc, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pb45a567f {
    static readonly long fc6e1e520 = 7245981689601667138L;
    static readonly long fce8a17fc = 7245981689601667138L;
    private java.security.spec.ECParameterSpec f0c4d5977;
    private java.math.Bigint f14ca1d76;
    private p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 f1a8786a3;
    private java.lang.string f1b612d6b;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f201da641;
    private java.security.spec.ECParameterSpec f33c0f968;
    private java.security.spec.ECParameterSpec f34e986de;
    private java.security.spec.ECParameterSpec f4b9cde78;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f54d5709b;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 f5ac880fa;
    private p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 f62f6f98d;
    private p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 f6849c881;
    private bool f69e8f717;
    private bool f72b420fa;
    private java.math.Bigint f8277e091;
    private bool f8b006a59;
    private bool fa04a9104;
    private java.lang.string fa480f0bd;
    private p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 fa7e0d566;
    private java.security.spec.ECParameterSpec fbbc5816f;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 fc36853ea;
    private java.math.Bigint fc43af8a4;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 fc587e8d3;
    private java.lang.string fed469618;
    private p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 ff1f96599;

    protected pbd73adcf() {
        this.fed469618 = "ECGOST3410-2012";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    public pbd73adcf(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar) {
        this.fed469618 = "ECGOST3410-2012";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = p06022b5aVar.getD();
        this.f33c0f968 = null;
    }

    public pbd73adcf(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed p5d6836edVar, java.security.spec.ECParameterSpec eCParameterSpec) {
        if ((23 + 8) % 8 > 0) {
        }
        this.fed469618 = "ECGOST3410-2012";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = p06022b5aVar.getParameters();
        this.fed469618 = str;
        this.f8277e091 = p06022b5aVar.getD();
        if (eCParameterSpec is not null) {
            this.f33c0f968 = eCParameterSpec;
        } else {
            this.f33c0f968 = new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(parameters.getG()), parameters.getN(), parameters.getH().intValue());
        }
        this.f62f6f98d = p5d6836edVar.getGostParams();
        this.fc36853ea = mf2f0750f(p5d6836edVar);
    }

    public pbd73adcf(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed p5d6836edVar, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var) {
        if ((21 + 30) % 30 > 0) {
        }
        this.fed469618 = "ECGOST3410-2012";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = p06022b5aVar.getParameters();
        this.fed469618 = str;
        this.f8277e091 = p06022b5aVar.getD();
        this.f33c0f968 = p835df581Var is not null ? new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p835df581Var.getCurve(), p835df581Var.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p835df581Var.getG()), p835df581Var.getN(), p835df581Var.getH().intValue()) : new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(parameters.getG()), parameters.getN(), parameters.getH().intValue());
        this.f62f6f98d = p5d6836edVar.getGostParams();
        this.fc36853ea = mf2f0750f(p5d6836edVar);
    }

    public pbd73adcf(java.security.interfaces.ECPrivateKey eCPrivateKey) {
        this.fed469618 = "ECGOST3410-2012";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f8277e091 = eCPrivateKey.getS();
        this.fed469618 = eCPrivateKey.getAlgorithm();
        this.f33c0f968 = eCPrivateKey.getParams();
    }

    public pbd73adcf(java.security.spec.ECPrivateKeySpec eCPrivateKeySpec) {
        this.fed469618 = "ECGOST3410-2012";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f8277e091 = eCPrivateKeySpec.getS();
        this.f33c0f968 = eCPrivateKeySpec.getParams();
    }

    public pbd73adcf(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p7ae61a0e p7ae61a0eVar) {
        if ((1 + 1) % 1 > 0) {
        }
        this.fed469618 = "ECGOST3410-2012";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f8277e091 = p7ae61a0eVar.getD();
        this.f33c0f968 = p7ae61a0eVar.getParams() is null ? null : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p7ae61a0eVar.getParams().getCurve(), p7ae61a0eVar.getParams().getSeed()), p7ae61a0eVar.getParams());
    }

    public pbd73adcf(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.pbd73adcf pbd73adcfVar) {
        this.fed469618 = "ECGOST3410-2012";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f8277e091 = pbd73adcfVar.f8277e091;
        this.f33c0f968 = pbd73adcfVar.f33c0f968;
        this.fa04a9104 = pbd73adcfVar.fa04a9104;
        this.f201da641 = pbd73adcfVar.f201da641;
        this.fc36853ea = pbd73adcfVar.fc36853ea;
        this.f62f6f98d = pbd73adcfVar.f62f6f98d;
    }

    pbd73adcf(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        this.fed469618 = "ECGOST3410-2012";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        m14800f1c(p811299f8Var);
    }

    private void M14800f1c(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d p698f972dVar;
        if ((31 + 16) % 16 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 aSN1Primitive = p811299f8Var.getPrivateKeyAlgorithm().getParameters().toASN1Primitive();
        if ((aSN1Primitive is p5a445d71.p9f931cf3.pca323100.p80f8c729) && (p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(aSN1Primitive).Count == 2 || p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(aSN1Primitive).Count == 3)) {
            p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 p3d5f6347VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters());
            this.f62f6f98d = p3d5f6347VarM8bab0102;
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f p8226e45fVarM141cb7b2 = p5a445d71.p9f931cf3.p3d5d08c7.p6bf26786.m141cb7b2(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m32132c89(p3d5f6347VarM8bab0102.getPublicKeyParamHashSet()));
            this.f33c0f968 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m32132c89(this.f62f6f98d.getPublicKeyParamHashSet()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p8226e45fVarM141cb7b2.getCurve(), p8226e45fVarM141cb7b2.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p8226e45fVarM141cb7b2.getG()), p8226e45fVarM141cb7b2.getN(), p8226e45fVarM141cb7b2.getH());
            p5a445d71.p9f931cf3.pca323100.p11b04310 privateKey = p811299f8Var.getPrivateKey();
            if (privateKey.getOctets().length == 32 || privateKey.getOctets().length == 64) {
                this.f8277e091 = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m4d9c2073(privateKey.getOctets()));
                return;
            }
            p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 privateKey2 = p811299f8Var.parsePrivateKey();
            if (privateKey2 is p5a445d71.p9f931cf3.pca323100.pf391b73d) {
                this.f8277e091 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(privateKey2).getPositiveValue();
                return;
            } else {
                this.f8277e091 = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m4d9c2073(p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(privateKey2).getOctets()));
                return;
            }
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters());
        if (p15be22c4VarM8bab0102.isNamedCurve()) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(p15be22c4VarM8bab0102.getParameters());
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMf7b916f7 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mf7b916f7(p364bf33aVarM8bab0102);
            if (p35e46fcbVarMf7b916f7 is not null) {
                p698f972dVar = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m6720e003(p364bf33aVarM8bab0102), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p35e46fcbVarMf7b916f7.getCurve(), p35e46fcbVarMf7b916f7.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p35e46fcbVarMf7b916f7.getG()), p35e46fcbVarMf7b916f7.getN(), p35e46fcbVarMf7b916f7.getH());
            } else {
                p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarM00471973 = p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m00471973(p364bf33aVarM8bab0102);
                p698f972dVar = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m32132c89(p364bf33aVarM8bab0102), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p35e46fcbVarM00471973.getCurve(), p35e46fcbVarM00471973.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p35e46fcbVarM00471973.getG()), p35e46fcbVarM00471973.getN(), p35e46fcbVarM00471973.getH());
            }
            this.f33c0f968 = p698f972dVar;
        } else if (p15be22c4VarM8bab0102.isImplicitlyCA()) {
            this.f33c0f968 = null;
        } else {
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb.m8bab0102(p15be22c4VarM8bab0102.getParameters());
            this.f33c0f968 = new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p35e46fcbVarM8bab0102.getCurve(), p35e46fcbVarM8bab0102.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p35e46fcbVarM8bab0102.getG()), p35e46fcbVarM8bab0102.getN(), p35e46fcbVarM8bab0102.getH().intValue());
        }
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 privateKey3 = p811299f8Var.parsePrivateKey();
        if (privateKey3 is p5a445d71.p9f931cf3.pca323100.pf391b73d) {
            this.f8277e091 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(privateKey3).getValue();
            return;
        }
        p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc p5eff85bcVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc.m8bab0102(privateKey3);
        this.f8277e091 = p5eff85bcVarM8bab0102.getKey();
        this.fc36853ea = p5eff85bcVarM8bab0102.getPublicKey();
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(getEncoded());
    }

    private void M97d9d39a(byte[] bArr, int i, int i2, java.math.Bigint bigint) {
        if ((29 + 23) % 23 > 0) {
        }
        byte[] byteArray = bigint.tobyteArray();
        if (byteArray.length < i) {
            byte[] bArr2 = new byte[i];
            java.lang.System.arraycopy(byteArray, 0, bArr2, i - byteArray.length, byteArray.length);
            byteArray = bArr2;
        }
        for (int i3 = 0; i3 != i; i3++) {
            bArr[i2 + i3] = byteArray[(byteArray.length - 1) - i3];
        }
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        m14800f1c(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46((byte[]) objectStream.readobject())));
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    private p5a445d71.p9f931cf3.pca323100.p29d19857 Mf2f0750f(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed p5d6836edVar) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(p5d6836edVar.getEncoded()).getPublicKeyData();
    }

    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 engineGetSpec() {
        java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
        return eCParameterSpec is null ? p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa() : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(eCParameterSpec);
    }

    public bool Equals(java.lang.object obj) {
        if ((16 + 8) % 8 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.pbd73adcf)) {
            return false;
        }
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.pbd73adcf pbd73adcfVar = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.pbd73adcf) obj;
        return getD().Equals(pbd73adcfVar.getD()) && engineGetSpec().Equals(pbd73adcfVar.engineGetSpec());
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
        if ((21 + 25) % 25 > 0) {
        }
        bool z = this.f8277e091.bitLength() > 256;
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = !z ? p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f39e9543a : p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.fbeb24ab5;
        int i = !z ? 32 : 64;
        p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 p3d5f6347Var = this.f62f6f98d;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("bb448559c7f2487a126057d4a5d224ccdf5ad31c2734665b52c3d29592a9e5");
        if (p3d5f6347Var is not null) {
            byte[] bArr = new byte[i];
            m97d9d39a(bArr, i, 0, getS());
            try {
                return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p364bf33aVar, this.f62f6f98d), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr)).getEncoded(strDecryptstring);
            } catch (java.io.IOException unused) {
                return null;
            }
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
                return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p364bf33aVar, p15be22c4Var.toASN1Primitive()), (this.fc36853ea is null ? new p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc(iM20664f91, getS(), p15be22c4Var) : new p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc(iM20664f91, getS(), this.fc36853ea, p15be22c4Var)).toASN1Primitive()).getEncoded(strDecryptstring);
            }
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM9a2b7f82 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m9a2b7f82(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) eCParameterSpec).getName());
            if (p364bf33aVarM9a2b7f82 is null) {
                p364bf33aVarM9a2b7f82 = new p5a445d71.p9f931cf3.pca323100.p364bf33a(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) this.f33c0f968).getName());
            }
            p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(p364bf33aVarM9a2b7f82);
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p364bf33aVar, p15be22c4Var.toASN1Primitive()), (this.fc36853ea is null ? new p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc(iM20664f91, getS(), p15be22c4Var) : new p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc(iM20664f91, getS(), this.fc36853ea, p15be22c4Var)).toASN1Primitive()).getEncoded(strDecryptstring);
        } catch (java.io.IOException unused2) {
            return null;
        }
        iM20664f91 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m20664f91(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea, this.f33c0f968.getOrder(), getS());
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
        if ((5 + 5) % 5 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mcd18c471(this.fed469618, this.f8277e091, engineGetSpec());
    }
}

