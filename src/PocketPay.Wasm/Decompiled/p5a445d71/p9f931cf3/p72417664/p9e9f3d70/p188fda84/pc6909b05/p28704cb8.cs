namespace WillowMaze.Wasm.Decompiled;


public class p28704cb8 : java.security.interfaces.ECPrivateKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5eff85bc, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pb45a567f {
    static readonly long f400c6fd1 = 7245981689601667138L;
    static readonly long f803cec9f = 7245981689601667138L;
    static readonly long f8bc00df4 = 7245981689601667138L;
    static readonly long fc6e1e520 = 7245981689601667138L;
    static readonly long ff48ea12b = 7245981689601667138L;
    private java.security.spec.ECParameterSpec f00b78af5;
    private java.security.spec.ECParameterSpec f086b0e2d;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f201da641;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f32f18c43;
    private java.security.spec.ECParameterSpec f33c0f968;
    private java.security.spec.ECParameterSpec f4874f488;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 f4d98c080;
    private java.security.spec.ECParameterSpec f539160ec;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f62f6f98d;
    private java.lang.string f6e3cc708;
    private java.math.Bigint f6f4ec5f8;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 f7f96061c;
    private java.math.Bigint f8277e091;
    private java.lang.string f8d93626d;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f9b8818e7;
    private bool f9bb3a42a;
    private bool f9e14288f;
    private bool fa04a9104;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 fb319952e;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 fc36853ea;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 fdba0e91e;
    private java.lang.string fed469618;
    private java.math.Bigint ffb5a356f;

    protected p28704cb8() {
        this.fed469618 = "ECGOST3410";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    public p28704cb8(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar) {
        this.fed469618 = "ECGOST3410";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = p06022b5aVar.getD();
        this.f33c0f968 = null;
    }

    public p28704cb8(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685 pecf68685Var, java.security.spec.ECParameterSpec eCParameterSpec) {
        if ((12 + 18) % 18 > 0) {
        }
        this.fed469618 = "ECGOST3410";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = p06022b5aVar.getD();
        if (eCParameterSpec is null) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = p06022b5aVar.getParameters();
            eCParameterSpec = new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(parameters.getG()), parameters.getN(), parameters.getH().intValue());
        }
        this.f33c0f968 = eCParameterSpec;
        this.f62f6f98d = pecf68685Var.getGostParams();
        this.fc36853ea = mf2f0750f(pecf68685Var);
    }

    public p28704cb8(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685 pecf68685Var, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var) {
        if ((20 + 10) % 10 > 0) {
        }
        this.fed469618 = "ECGOST3410";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = p06022b5aVar.getD();
        if (p835df581Var is not null) {
            this.f33c0f968 = new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p835df581Var.getCurve(), p835df581Var.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p835df581Var.getG()), p835df581Var.getN(), p835df581Var.getH().intValue());
        } else {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = p06022b5aVar.getParameters();
            this.f33c0f968 = new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(parameters.getG()), parameters.getN(), parameters.getH().intValue());
        }
        this.f62f6f98d = pecf68685Var.getGostParams();
        this.fc36853ea = mf2f0750f(pecf68685Var);
    }

    public p28704cb8(java.security.interfaces.ECPrivateKey eCPrivateKey) {
        this.fed469618 = "ECGOST3410";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f8277e091 = eCPrivateKey.getS();
        this.fed469618 = eCPrivateKey.getAlgorithm();
        this.f33c0f968 = eCPrivateKey.getParams();
    }

    public p28704cb8(java.security.spec.ECPrivateKeySpec eCPrivateKeySpec) {
        this.fed469618 = "ECGOST3410";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f8277e091 = eCPrivateKeySpec.getS();
        this.f33c0f968 = eCPrivateKeySpec.getParams();
    }

    public p28704cb8(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p7ae61a0e p7ae61a0eVar) {
        if ((16 + 5) % 5 > 0) {
        }
        this.fed469618 = "ECGOST3410";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f8277e091 = p7ae61a0eVar.getD();
        this.f33c0f968 = p7ae61a0eVar.getParams() is null ? null : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p7ae61a0eVar.getParams().getCurve(), p7ae61a0eVar.getParams().getSeed()), p7ae61a0eVar.getParams());
    }

    public p28704cb8(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p28704cb8 p28704cb8Var) {
        this.fed469618 = "ECGOST3410";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f8277e091 = p28704cb8Var.f8277e091;
        this.f33c0f968 = p28704cb8Var.f33c0f968;
        this.fa04a9104 = p28704cb8Var.fa04a9104;
        this.f201da641 = p28704cb8Var.f201da641;
        this.fc36853ea = p28704cb8Var.fc36853ea;
        this.f62f6f98d = p28704cb8Var.f62f6f98d;
    }

    p28704cb8(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        this.fed469618 = "ECGOST3410";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        m14800f1c(p811299f8Var);
    }

    private void M14800f1c(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        java.security.spec.ECParameterSpec p698f972dVar;
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 privateKey;
        if ((27 + 30) % 30 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 parameters = p811299f8Var.getPrivateKeyAlgorithm().getParameters();
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 aSN1Primitive = parameters.toASN1Primitive();
        if ((aSN1Primitive is p5a445d71.p9f931cf3.pca323100.p80f8c729) && (p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(aSN1Primitive).Count == 2 || p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(aSN1Primitive).Count == 3)) {
            p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 p3d5f6347VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347.m8bab0102(parameters);
            this.f62f6f98d = p3d5f6347VarM8bab0102;
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f p8226e45fVarM141cb7b2 = p5a445d71.p9f931cf3.p3d5d08c7.p6bf26786.m141cb7b2(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m32132c89(p3d5f6347VarM8bab0102.getPublicKeyParamHashSet()));
            this.f33c0f968 = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m32132c89(p3d5f6347VarM8bab0102.getPublicKeyParamHashSet()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p8226e45fVarM141cb7b2.getCurve(), p8226e45fVarM141cb7b2.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p8226e45fVarM141cb7b2.getG()), p8226e45fVarM141cb7b2.getN(), p8226e45fVarM141cb7b2.getH());
            p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 privateKey2 = p811299f8Var.parsePrivateKey();
            if (privateKey2 is p5a445d71.p9f931cf3.pca323100.pf391b73d) {
                this.f8277e091 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(privateKey2).getPositiveValue();
                return;
            }
            byte[] octets = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(privateKey2).getOctets();
            byte[] bArr = new byte[octets.length];
            for (int i = 0; i != octets.length; i++) {
                bArr[i] = octets[(octets.length - 1) - i];
            }
            this.f8277e091 = new java.math.Bigint(1, bArr);
            return;
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4.m8bab0102(parameters);
        if (!p15be22c4VarM8bab0102.isNamedCurve()) {
            if (p15be22c4VarM8bab0102.isImplicitlyCA()) {
                this.f33c0f968 = null;
            } else {
                p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb.m8bab0102(p15be22c4VarM8bab0102.getParameters());
                p698f972dVar = new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p35e46fcbVarM8bab0102.getCurve(), p35e46fcbVarM8bab0102.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p35e46fcbVarM8bab0102.getG()), p35e46fcbVarM8bab0102.getN(), p35e46fcbVarM8bab0102.getH().intValue());
            }
            privateKey = p811299f8Var.parsePrivateKey();
            if (!(privateKey is p5a445d71.p9f931cf3.pca323100.pf391b73d)) {
                this.f8277e091 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(privateKey).getValue();
                return;
            }
            p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc p5eff85bcVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc.m8bab0102(privateKey);
            this.f8277e091 = p5eff85bcVarM8bab0102.getKey();
            this.fc36853ea = p5eff85bcVarM8bab0102.getPublicKey();
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(p15be22c4VarM8bab0102.getParameters());
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMf7b916f7 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mf7b916f7(p364bf33aVarM8bab0102);
        if (p35e46fcbVarMf7b916f7 is null) {
            throw new java.lang.IllegalStateException();
        }
        p698f972dVar = new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m6720e003(p364bf33aVarM8bab0102), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p35e46fcbVarMf7b916f7.getCurve(), p35e46fcbVarMf7b916f7.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p35e46fcbVarMf7b916f7.getG()), p35e46fcbVarMf7b916f7.getN(), p35e46fcbVarMf7b916f7.getH());
        this.f33c0f968 = p698f972dVar;
        privateKey = p811299f8Var.parsePrivateKey();
        if (!(privateKey is p5a445d71.p9f931cf3.pca323100.pf391b73d)) {
            this.f8277e091 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(privateKey).getValue();
            return;
        }
        p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc p5eff85bcVarM8bab01022 = p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc.m8bab0102(privateKey);
        this.f8277e091 = p5eff85bcVarM8bab01022.getKey();
        this.fc36853ea = p5eff85bcVarM8bab01022.getPublicKey();
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(getEncoded());
    }

    private void M97d9d39a(byte[] bArr, int i, java.math.Bigint bigint) {
        if ((17 + 4) % 4 > 0) {
        }
        byte[] byteArray = bigint.tobyteArray();
        if (byteArray.length < 32) {
            byte[] bArr2 = new byte[32];
            java.lang.System.arraycopy(byteArray, 0, bArr2, 32 - byteArray.length, byteArray.length);
            byteArray = bArr2;
        }
        for (int i2 = 0; i2 != 32; i2++) {
            bArr[i + i2] = byteArray[(byteArray.length - 1) - i2];
        }
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        m14800f1c(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46((byte[]) objectStream.readobject())));
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    private p5a445d71.p9f931cf3.pca323100.p29d19857 Mf2f0750f(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685 pecf68685Var) {
        try {
            return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(pecf68685Var.getEncoded())).getPublicKeyData();
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 engineGetSpec() {
        java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
        return eCParameterSpec is null ? p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa() : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(eCParameterSpec);
    }

    public bool Equals(java.lang.object obj) {
        if ((25 + 25) % 25 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p28704cb8)) {
            return false;
        }
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p28704cb8 p28704cb8Var = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p28704cb8) obj;
        return getD().Equals(p28704cb8Var.getD()) && engineGetSpec().Equals(p28704cb8Var.engineGetSpec());
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
        if ((11 + 3) % 3 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var = this.f62f6f98d;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("63c29421480928329d42180d6250a51d0f9124dc677f9c1df6d9d959fd6593");
        if (p0fd1bdf1Var is not null) {
            byte[] bArr = new byte[32];
            m97d9d39a(bArr, 0, getS());
            try {
                return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c, this.f62f6f98d), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr)).getEncoded(strDecryptstring);
            } catch (java.io.IOException unused) {
                return null;
            }
        }
        java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
        if (eCParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM9a2b7f82 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m9a2b7f82(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) eCParameterSpec).getName());
            if (p364bf33aVarM9a2b7f82 is null) {
                p364bf33aVarM9a2b7f82 = new p5a445d71.p9f931cf3.pca323100.p364bf33a(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) this.f33c0f968).getName());
            }
            p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(p364bf33aVarM9a2b7f82);
            iM20664f91 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m20664f91(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea, this.f33c0f968.getOrder(), getS());
        } else if (eCParameterSpec is not null) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarM2ace2977 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(eCParameterSpec.getCurve());
            p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb(pa827ecfaVarM2ace2977, new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(pa827ecfaVarM2ace2977, this.f33c0f968.getGenerator()), this.fa04a9104), this.f33c0f968.getOrder(), java.math.Bigint.valueOf(this.f33c0f968.getCofactor()), this.f33c0f968.getCurve().getSeed()));
            iM20664f91 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m20664f91(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea, this.f33c0f968.getOrder(), getS());
        } else {
            p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4((p5a445d71.p9f931cf3.pca323100.pb9fa8367) p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17);
            iM20664f91 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m20664f91(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea, null, getS());
        }
        try {
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c, p15be22c4Var.toASN1Primitive()), (this.fc36853ea is null ? new p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc(iM20664f91, getS(), p15be22c4Var) : new p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc(iM20664f91, getS(), this.fc36853ea, p15be22c4Var)).toASN1Primitive()).getEncoded(strDecryptstring);
        } catch (java.io.IOException unused2) {
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
        if ((20 + 5) % 5 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mcd18c471(this.fed469618, this.f8277e091, engineGetSpec());
    }
}

