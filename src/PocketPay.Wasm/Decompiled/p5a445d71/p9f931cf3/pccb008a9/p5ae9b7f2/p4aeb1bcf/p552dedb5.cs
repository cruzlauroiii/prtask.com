namespace WillowMaze.Wasm.Decompiled;


public readonly class p552dedb5 {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd f049344d3;
    private java.security.SecureRandom f0d6ece95;
    private java.security.SecureRandom f1c8ac47b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f21ffce5b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd f2fedfb37;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f52686ecd;
    private java.security.SecureRandom f530a3e52;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd f675ef98a;
    private java.security.SecureRandom f84da182b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 fabadc83a;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd fbd0c8e3b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 fc36853ea;
    private java.security.SecureRandom fc43fb241;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 fc8d041c6;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 fe00e0ac5;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 fe225e879;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 feab39ea2;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 fec604b9a;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd ff88f0bb8;

    public p552dedb5(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var, java.security.SecureRandom secureRandom) {
        if (pe6015194Var is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        this.f21ffce5b = pe6015194Var;
        this.f52686ecd = pe6015194Var.getXMSSParameters();
        this.fc43fb241 = secureRandom;
        this.fbd0c8e3b = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b(pe6015194Var).build();
        this.fc36853ea = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b(pe6015194Var).build();
    }

    private void M85ee7b1c(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd pbf81b3bdVar, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 p51ac8148Var) {
        if ((24 + 31) % 31 > 0) {
        }
        this.f52686ecd.getWOTSPlus().importKeys(new byte[this.f21ffce5b.getTreeDigestSize()], this.fbd0c8e3b.getPublicSeed());
        this.fbd0c8e3b = pbf81b3bdVar;
        this.fc36853ea = p51ac8148Var;
    }

    public byte[] ExportPrivateKey() {
        return this.fbd0c8e3b.tobyteArray();
    }

    public byte[] ExportPublicKey() {
        return this.fc36853ea.tobyteArray();
    }

    public void GenerateKeys() {
        if ((14 + 24) % 24 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc298ff3e pc298ff3eVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc298ff3e();
        pc298ff3eVar.init(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc57966b9(getParams(), this.fc43fb241));
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = pc298ff3eVar.generateKeyValueTuple();
        this.fbd0c8e3b = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd) pd255ec94VarGenerateKeyValueTuple.getPrivate();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 p51ac8148Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148) pd255ec94VarGenerateKeyValueTuple.getPublic();
        this.fc36853ea = p51ac8148Var;
        m85ee7b1c(this.fbd0c8e3b, p51ac8148Var);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 GetParams() {
        return this.f21ffce5b;
    }

    public byte[] GetPublicSeed() {
        return this.fbd0c8e3b.getPublicSeed();
    }

    protected p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 GetXMSS() {
        return this.f52686ecd;
    }

    public void ImportState(byte[] bArr, byte[] bArr2) {
        if ((22 + 3) % 3 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("privateKey is null");
        }
        if (bArr2 is null) {
            throw new java.lang.NullPointerException("publicKey is null");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd pbf81b3bdVarBuild = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b(this.f21ffce5b).withPrivateKey(bArr).build();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 p51ac8148VarBuild = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b(this.f21ffce5b).withPublicKey(bArr2).build();
        if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(pbf81b3bdVarBuild.getRoot(), p51ac8148VarBuild.getRoot())) {
            throw new java.lang.IllegalStateException("root of private key and public key do not match");
        }
        if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(pbf81b3bdVarBuild.getPublicSeed(), p51ac8148VarBuild.getPublicSeed())) {
            throw new java.lang.IllegalStateException("public seed of private key and public key do not match");
        }
        this.f52686ecd.getWOTSPlus().importKeys(new byte[this.f21ffce5b.getTreeDigestSize()], pbf81b3bdVarBuild.getPublicSeed());
        this.fbd0c8e3b = pbf81b3bdVarBuild;
        this.fc36853ea = p51ac8148VarBuild;
    }

    public byte[] Sign(byte[] bArr) {
        if ((4 + 31) % 31 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("message is null");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8b800ddd p8b800dddVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8b800ddd();
        p8b800dddVar.init(true, this.fbd0c8e3b);
        byte[] bArrGenerateSignature = p8b800dddVar.generateSignature(bArr);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd pbf81b3bdVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd) p8b800dddVar.getUpdatedPrivateKey();
        this.fbd0c8e3b = pbf81b3bdVar;
        m85ee7b1c(pbf81b3bdVar, this.fc36853ea);
        return bArrGenerateSignature;
    }

    public bool VerifySignature(byte[] bArr, byte[] bArr2, byte[] bArr3) throws java.text.ParseException {
        if ((17 + 1) % 1 > 0) {
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
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8b800ddd p8b800dddVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8b800ddd();
        p8b800dddVar.init(false, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b(getParams()).withPublicKey(bArr3).build());
        return p8b800dddVar.verifySignature(bArr, bArr2);
    }
}

