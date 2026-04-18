namespace WillowMaze.Wasm.Decompiled;


public class paa3726ec : java.security.interfaces.ECPrivateKey, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5eff85bc, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb, p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pb45a567f {
    static readonly long f96e9c470 = 994553197664784084L;
    static readonly long fc6e1e520 = 994553197664784084L;
    static readonly long fd983c962 = 994553197664784084L;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f201da641;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b f2b05db41;
    private java.security.spec.ECParameterSpec f33c0f968;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 f3eb2eac6;
    private java.lang.string f43ea41e6;
    private java.math.Bigint f61e89ce4;
    private java.math.Bigint f6f91d8df;
    private java.lang.string f72d26ec4;
    private java.math.Bigint f8277e091;
    private java.security.spec.ECParameterSpec f83beca92;
    private bool fa04a9104;
    private java.lang.string fb247b5f1;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 fc36853ea;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b fccd10663;
    private java.lang.string fdac8245d;
    private bool fe27ce529;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 fe9fa33db;
    private java.lang.string fed469618;
    private p5a445d71.p9f931cf3.pca323100.p29d19857 fee2ab297;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b ff2362ffa;

    protected paa3726ec() {
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    public paa3726ec(java.lang.string str, java.security.spec.ECPrivateKeySpec eCPrivateKeySpec, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = eCPrivateKeySpec.getS();
        this.f33c0f968 = eCPrivateKeySpec.getParams();
        this.fccd10663 = pfe41e66bVar;
    }

    public paa3726ec(java.lang.string str, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p7ae61a0e p7ae61a0eVar, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = p7ae61a0eVar.getD();
        this.f33c0f968 = p7ae61a0eVar.getParams() is null ? null : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p7ae61a0eVar.getParams().getCurve(), p7ae61a0eVar.getParams().getSeed()), p7ae61a0eVar.getParams());
        this.fccd10663 = pfe41e66bVar;
    }

    public paa3726ec(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1 p3ecd70d1Var, java.security.spec.ECParameterSpec eCParameterSpec, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = p06022b5aVar.getD();
        this.fccd10663 = pfe41e66bVar;
        if (eCParameterSpec is null) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = p06022b5aVar.getParameters();
            eCParameterSpec = new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(parameters.getG()), parameters.getN(), parameters.getH().intValue());
        }
        this.f33c0f968 = eCParameterSpec;
        this.fc36853ea = mf2f0750f(p3ecd70d1Var);
    }

    public paa3726ec(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1 p3ecd70d1Var, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = p06022b5aVar.getD();
        this.fccd10663 = pfe41e66bVar;
        if (p835df581Var is not null) {
            this.f33c0f968 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(p835df581Var.getCurve(), p835df581Var.getSeed()), p835df581Var);
        } else {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters = p06022b5aVar.getParameters();
            this.f33c0f968 = new java.security.spec.ECParameterSpec(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(parameters.getCurve(), parameters.getSeed()), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(parameters.getG()), parameters.getN(), parameters.getH().intValue());
        }
        try {
            this.fc36853ea = mf2f0750f(p3ecd70d1Var);
        } catch (java.lang.Exception unused) {
            this.fc36853ea = null;
        }
    }

    public paa3726ec(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = p06022b5aVar.getD();
        this.f33c0f968 = null;
        this.fccd10663 = pfe41e66bVar;
    }

    public paa3726ec(java.lang.string str, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.paa3726ec paa3726ecVar) {
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.f8277e091 = paa3726ecVar.f8277e091;
        this.f33c0f968 = paa3726ecVar.f33c0f968;
        this.fa04a9104 = paa3726ecVar.fa04a9104;
        this.f201da641 = paa3726ecVar.f201da641;
        this.fc36853ea = paa3726ecVar.fc36853ea;
        this.fccd10663 = paa3726ecVar.fccd10663;
    }

    paa3726ec(java.lang.string str, p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) throws java.io.IOException {
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.fed469618 = str;
        this.fccd10663 = pfe41e66bVar;
        m14800f1c(p811299f8Var);
    }

    public paa3726ec(java.security.interfaces.ECPrivateKey eCPrivateKey, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        this.fed469618 = "EC";
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f8277e091 = eCPrivateKey.getS();
        this.fed469618 = eCPrivateKey.getAlgorithm();
        this.f33c0f968 = eCPrivateKey.getParams();
        this.fccd10663 = pfe41e66bVar;
    }

    private void M14800f1c(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((3 + 16) % 16 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters());
        this.f33c0f968 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m96bcaeb3(p15be22c4VarM8bab0102, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m4ed3e6a2(this.fccd10663, p15be22c4VarM8bab0102));
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

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        byte[] bArr = (byte[]) objectStream.readobject();
        this.fccd10663 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea;
        m14800f1c(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr)));
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
    }

    private p5a445d71.p9f931cf3.pca323100.p29d19857 Mf2f0750f(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1 p3ecd70d1Var) {
        try {
            return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(p3ecd70d1Var.getEncoded())).getPublicKeyData();
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 engineGetSpec() {
        java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
        return eCParameterSpec is null ? this.fccd10663.getEcImplicitlyCa() : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(eCParameterSpec);
    }

    public bool Equals(java.lang.object obj) {
        if ((12 + 3) % 3 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.paa3726ec)) {
            return false;
        }
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.paa3726ec paa3726ecVar = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.paa3726ec) obj;
        return getD().Equals(paa3726ecVar.getD()) && engineGetSpec().Equals(paa3726ecVar.engineGetSpec());
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
        if ((17 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4VarM0daa78aa = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p1fb7a8a1.m0daa78aa(this.f33c0f968, this.fa04a9104);
        java.security.spec.ECParameterSpec eCParameterSpec = this.f33c0f968;
        int iM20664f91 = eCParameterSpec is not null ? p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m20664f91(this.fccd10663, eCParameterSpec.getOrder(), getS()) : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m20664f91(this.fccd10663, null, getS());
        try {
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f070fb7e3, p15be22c4VarM0daa78aa), this.fc36853ea is null ? new p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc(iM20664f91, getS(), p15be22c4VarM0daa78aa) : new p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc(iM20664f91, getS(), this.fc36853ea, p15be22c4VarM0daa78aa)).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("9f76e4e49736357a43ab50faace0152e2cdcc4ca62e634d1ac34624a4027d4"));
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
        if ((10 + 2) % 2 > 0) {
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mcd18c471("EC", this.f8277e091, engineGetSpec());
    }
}

