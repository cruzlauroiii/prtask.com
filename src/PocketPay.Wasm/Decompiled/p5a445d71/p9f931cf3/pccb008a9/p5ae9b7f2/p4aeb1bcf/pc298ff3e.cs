namespace WillowMaze.Wasm.Decompiled;


public readonly class pc298ff3e : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f0655d197;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f0cae30c2;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f21ffce5b;
    private java.security.SecureRandom f2686ad57;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f52686ecd;
    private java.security.SecureRandom f843fe209;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f94e6214b;
    private java.security.SecureRandom f97cc9394;
    private java.security.SecureRandom fc43fb241;
    private java.security.SecureRandom fca8afb6b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 fdceb313d;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 fdf30a1eb;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 feb6fe465;

    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd M5a76c5a5(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 p8fc89a90Var) {
        if ((7 + 11) % 11 > 0) {
        }
        int treeDigestSize = this.f21ffce5b.getTreeDigestSize();
        byte[] bArr = new byte[treeDigestSize];
        this.fc43fb241.nextbytes(bArr);
        byte[] bArr2 = new byte[treeDigestSize];
        this.fc43fb241.nextbytes(bArr2);
        byte[] bArr3 = new byte[treeDigestSize];
        this.fc43fb241.nextbytes(bArr3);
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b(this.f21ffce5b).withSecretKeySeed(bArr).withSecretKeyPRF(bArr2).withPublicSeed(bArr3).withBDSState(p8fc89a90Var).build();
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((16 + 18) % 18 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd pbf81b3bdVarM5a76c5a5 = m5a76c5a5(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b(this.f21ffce5b).build().getBDSState());
        this.f52686ecd.getWOTSPlus().importKeys(new byte[this.f21ffce5b.getTreeDigestSize()], pbf81b3bdVarM5a76c5a5.getPublicSeed());
        int layers = this.f21ffce5b.getLayers() - 1;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a p1a8a272aVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a(this.f52686ecd, pbf81b3bdVarM5a76c5a5.getPublicSeed(), pbf81b3bdVarM5a76c5a5.getSecretKeySeed(), (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().withLayerAddress(layers)).build());
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f root = p1a8a272aVar.getRoot();
        pbf81b3bdVarM5a76c5a5.getBDSState().Add(layers, p1a8a272aVar);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd pbf81b3bdVarBuild = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b(this.f21ffce5b).withSecretKeySeed(pbf81b3bdVarM5a76c5a5.getSecretKeySeed()).withSecretKeyPRF(pbf81b3bdVarM5a76c5a5.getSecretKeyPRF()).withPublicSeed(pbf81b3bdVarM5a76c5a5.getPublicSeed()).withRoot(root.getValue()).withBDSState(pbf81b3bdVarM5a76c5a5.getBDSState()).build();
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148$p2bd4a59b(this.f21ffce5b).withRoot(root.getValue()).withPublicSeed(pbf81b3bdVarBuild.getPublicSeed()).build(), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) pbf81b3bdVarBuild);
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc57966b9 pc57966b9Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc57966b9) pf7bb6344Var;
        this.fc43fb241 = pc57966b9Var.getRandom();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 parameters = pc57966b9Var.getParameters();
        this.f21ffce5b = parameters;
        this.f52686ecd = parameters.getXMSSParameters();
    }
}

