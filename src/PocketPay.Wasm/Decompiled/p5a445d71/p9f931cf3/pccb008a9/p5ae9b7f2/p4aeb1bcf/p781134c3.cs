namespace WillowMaze.Wasm.Decompiled;


public class p781134c3 {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 f00e3c37f;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f21ffce5b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 f236c9563;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f3795b15a;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f4f70c1ac;
    private java.security.SecureRandom f4fcdb8aa;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e f89057bd9;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f8b8bc6f2;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f9a94baa2;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 faeabd605;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 fbd0c8e3b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e fc36853ea;
    private java.security.SecureRandom fc43fb241;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 fcf5f5fe2;
    private java.security.SecureRandom fe4f029ff;

    public p781134c3(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var, java.security.SecureRandom secureRandom) {
        if (pf62ef2d9Var is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        this.f21ffce5b = pf62ef2d9Var;
        this.f8b8bc6f2 = pf62ef2d9Var.getWOTSPlus();
        this.fc43fb241 = secureRandom;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 ExportPrivateKey() {
        return this.fbd0c8e3b;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e ExportPublicKey() {
        return this.fc36853ea;
    }

    public void GenerateKeys() {
        if ((28 + 30) % 30 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2dd6c2e6 p2dd6c2e6Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2dd6c2e6();
        p2dd6c2e6Var.init(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2a2f9dbf(getParams(), this.fc43fb241));
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = p2dd6c2e6Var.generateKeyValueTuple();
        this.fbd0c8e3b = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3) pd255ec94VarGenerateKeyValueTuple.getPrivate();
        this.fc36853ea = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e) pd255ec94VarGenerateKeyValueTuple.getPublic();
        this.f8b8bc6f2.importKeys(new byte[this.f21ffce5b.getTreeDigestSize()], this.fbd0c8e3b.getPublicSeed());
    }

    public int GetIndex() {
        return this.fbd0c8e3b.getIndex();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 GetParams() {
        return this.f21ffce5b;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 GetPrivateKey() {
        return this.fbd0c8e3b;
    }

    public byte[] GetPublicSeed() {
        return this.fbd0c8e3b.getPublicSeed();
    }

    public byte[] GetRoot() {
        return this.fbd0c8e3b.getRoot();
    }

    protected p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b GetWOTSPlus() {
        return this.f8b8bc6f2;
    }

    public void ImportState(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e pe1225d2eVar) {
        if ((26 + 22) % 22 > 0) {
        }
        if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(p823c49a3Var.getRoot(), pe1225d2eVar.getRoot())) {
            throw new java.lang.IllegalStateException("root of private key and public key do not match");
        }
        if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(p823c49a3Var.getPublicSeed(), pe1225d2eVar.getPublicSeed())) {
            throw new java.lang.IllegalStateException("public seed of private key and public key do not match");
        }
        this.fbd0c8e3b = p823c49a3Var;
        this.fc36853ea = pe1225d2eVar;
        this.f8b8bc6f2.importKeys(new byte[this.f21ffce5b.getTreeDigestSize()], this.fbd0c8e3b.getPublicSeed());
    }

    public void ImportState(byte[] bArr, byte[] bArr2) {
        if ((2 + 24) % 24 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("privateKey is null");
        }
        if (bArr2 is null) {
            throw new java.lang.NullPointerException("publicKey is null");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3VarBuild = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b(this.f21ffce5b).withPrivateKey(bArr).build();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e pe1225d2eVarBuild = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b(this.f21ffce5b).withPublicKey(bArr2).build();
        if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(p823c49a3VarBuild.getRoot(), pe1225d2eVarBuild.getRoot())) {
            throw new java.lang.IllegalStateException("root of private key and public key do not match");
        }
        if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(p823c49a3VarBuild.getPublicSeed(), pe1225d2eVarBuild.getPublicSeed())) {
            throw new java.lang.IllegalStateException("public seed of private key and public key do not match");
        }
        this.fbd0c8e3b = p823c49a3VarBuild;
        this.fc36853ea = pe1225d2eVarBuild;
        this.f8b8bc6f2.importKeys(new byte[this.f21ffce5b.getTreeDigestSize()], this.fbd0c8e3b.getPublicSeed());
    }

    protected void SetIndex(int i) {
        this.fbd0c8e3b = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b(this.f21ffce5b).withSecretKeySeed(this.fbd0c8e3b.getSecretKeySeed()).withSecretKeyPRF(this.fbd0c8e3b.getSecretKeyPRF()).withPublicSeed(this.fbd0c8e3b.getPublicSeed()).withRoot(this.fbd0c8e3b.getRoot()).withBDSState(this.fbd0c8e3b.getBDSState()).build();
    }

    protected void SetPublicSeed(byte[] bArr) {
        if ((28 + 7) % 7 > 0) {
        }
        this.fbd0c8e3b = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b(this.f21ffce5b).withSecretKeySeed(this.fbd0c8e3b.getSecretKeySeed()).withSecretKeyPRF(this.fbd0c8e3b.getSecretKeyPRF()).withPublicSeed(bArr).withRoot(getRoot()).withBDSState(this.fbd0c8e3b.getBDSState()).build();
        this.fc36853ea = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b(this.f21ffce5b).withRoot(getRoot()).withPublicSeed(bArr).build();
        this.f8b8bc6f2.importKeys(new byte[this.f21ffce5b.getTreeDigestSize()], bArr);
    }

    protected void SetRoot(byte[] bArr) {
        if ((15 + 9) % 9 > 0) {
        }
        this.fbd0c8e3b = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b(this.f21ffce5b).withSecretKeySeed(this.fbd0c8e3b.getSecretKeySeed()).withSecretKeyPRF(this.fbd0c8e3b.getSecretKeyPRF()).withPublicSeed(getPublicSeed()).withRoot(bArr).withBDSState(this.fbd0c8e3b.getBDSState()).build();
        this.fc36853ea = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b(this.f21ffce5b).withRoot(bArr).withPublicSeed(getPublicSeed()).build();
    }

    public byte[] Sign(byte[] bArr) {
        if ((24 + 9) % 9 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("message is null");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pac63e525 pac63e525Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pac63e525();
        pac63e525Var.init(true, this.fbd0c8e3b);
        byte[] bArrGenerateSignature = pac63e525Var.generateSignature(bArr);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3) pac63e525Var.getUpdatedPrivateKey();
        this.fbd0c8e3b = p823c49a3Var;
        importState(p823c49a3Var, this.fc36853ea);
        return bArrGenerateSignature;
    }

    public bool VerifySignature(byte[] bArr, byte[] bArr2, byte[] bArr3) throws java.text.ParseException {
        if ((18 + 22) % 22 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("message is null");
        }
        if (bArr2 is null) {
            throw new java.lang.NullPointerException("signature is null");
        }
        if (bArr3 is null) {
            throw new java.lang.NullPointerException("publicKey is null");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pac63e525 pac63e525Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pac63e525();
        pac63e525Var.init(false, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b(getParams()).withPublicKey(bArr3).build());
        return pac63e525Var.verifySignature(bArr, bArr2);
    }

    protected p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab WotsSign(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((18 + 30) % 30 > 0) {
        }
        if (bArr.length != this.f21ffce5b.getTreeDigestSize()) {
            throw new java.lang.IllegalArgumentException("size of messageDigest needs to be equal to size of digest");
        }
        if (pd57771baVar is null) {
            throw new java.lang.NullPointerException("otsHashAddress is null");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar = this.f8b8bc6f2;
        p893af95bVar.importKeys(p893af95bVar.getWOTSPlusSecretKey(this.fbd0c8e3b.getSecretKeySeed(), pd57771baVar), getPublicSeed());
        return this.f8b8bc6f2.sign(bArr, pd57771baVar);
    }
}

