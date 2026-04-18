namespace WillowMaze.Wasm.Decompiled;


public readonly class p2dd6c2e6 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private java.security.SecureRandom f17a18361;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f21ffce5b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f8d89d1e8;
    private java.security.SecureRandom fa5cb09c3;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 fa646c6e5;
    private java.security.SecureRandom fc43fb241;
    private java.security.SecureRandom ffaf28341;

    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 M5a76c5a5(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 pf62ef2d9Var, java.security.SecureRandom secureRandom) {
        if ((11 + 21) % 21 > 0) {
        }
        int treeDigestSize = pf62ef2d9Var.getTreeDigestSize();
        byte[] bArr = new byte[treeDigestSize];
        secureRandom.nextbytes(bArr);
        byte[] bArr2 = new byte[treeDigestSize];
        secureRandom.nextbytes(bArr2);
        byte[] bArr3 = new byte[treeDigestSize];
        secureRandom.nextbytes(bArr3);
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b(pf62ef2d9Var).withSecretKeySeed(bArr).withSecretKeyPRF(bArr2).withPublicSeed(bArr3).withBDSState(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a(pf62ef2d9Var, bArr3, bArr, (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().build())).build();
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((14 + 18) % 18 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3VarM5a76c5a5 = m5a76c5a5(this.f21ffce5b, this.fc43fb241);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f root = p823c49a3VarM5a76c5a5.getBDSState().getRoot();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3VarBuild = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b(this.f21ffce5b).withSecretKeySeed(p823c49a3VarM5a76c5a5.getSecretKeySeed()).withSecretKeyPRF(p823c49a3VarM5a76c5a5.getSecretKeyPRF()).withPublicSeed(p823c49a3VarM5a76c5a5.getPublicSeed()).withRoot(root.getValue()).withBDSState(p823c49a3VarM5a76c5a5.getBDSState()).build();
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e$p2bd4a59b(this.f21ffce5b).withRoot(root.getValue()).withPublicSeed(p823c49a3VarBuild.getPublicSeed()).build(), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) p823c49a3VarBuild);
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2a2f9dbf p2a2f9dbfVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2a2f9dbf) pf7bb6344Var;
        this.fc43fb241 = p2a2f9dbfVar.getRandom();
        this.f21ffce5b = p2a2f9dbfVar.getParameters();
    }
}

