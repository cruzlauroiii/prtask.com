namespace WillowMaze.Wasm.Decompiled;


public class pa235b83e : java.security.KeyValueTupleGenerator {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2a2f9dbf f3cbaa3e6;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f42c28003;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2dd6c2e6 f868d92bc;
    private java.security.SecureRandom f8a9da1a7;
    private java.security.SecureRandom fa44c682c;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2dd6c2e6 fad1943a9;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2a2f9dbf fcdd5da99;
    private bool fceae0707;
    private bool fdb1687e1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2a2f9dbf fe0bfbdb6;
    private bool fe3a01336;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fe4029bf7;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2a2f9dbf feca07335;

    public pa235b83e() {
        super("XMSS");
        this.fad1943a9 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2dd6c2e6();
        this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        this.fdb1687e1 = false;
    }

    public override java.security.KeyValueTuple GenerateKeyValueTuple() {
        if ((30 + 22) % 22 > 0) {
        }
        if (!this.fdb1687e1) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2a2f9dbf p2a2f9dbfVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2a2f9dbf(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9(10, new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p876d6ecf()), this.f7ddf32e1);
            this.feca07335 = p2a2f9dbfVar;
            this.fad1943a9.init(p2a2f9dbfVar);
            this.fdb1687e1 = true;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = this.fad1943a9.generateKeyValueTuple();
        return new java.security.KeyValueTuple(new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.p46415c23(this.f42c28003, (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e) pd255ec94VarGenerateKeyValueTuple.getPublic()), new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8(this.f42c28003, (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3) pd255ec94VarGenerateKeyValueTuple.getPrivate()));
    }

    public override void Initialize(int i, java.security.SecureRandom secureRandom) {
        throw new java.lang.IllegalArgumentException("use AlgorithmParameterSpec");
    }

    public override void Initialize(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2a2f9dbf p2a2f9dbfVar;
        if ((14 + 13) % 13 > 0) {
        }
        if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p8d398416)) {
            throw new java.security.InvalidAlgorithmParameterException("parameter object not a XMSSParameterSpec");
        }
        p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p8d398416 p8d398416Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p8d398416) algorithmParameterSpec;
        if (p8d398416Var.getTreeDigest().Equals(com.decryptstringmanager.Decryptstring.decryptstring("1d0a9243b6b0bb232637db3ecc288f9a3e05c9fb915ccd2bbb4035c3d4a3653ffa04"))) {
            this.f42c28003 = p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613;
            p2a2f9dbfVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2a2f9dbf(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9(p8d398416Var.getHeight(), new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c()), secureRandom);
        } else if (p8d398416Var.getTreeDigest().Equals(com.decryptstringmanager.Decryptstring.decryptstring("5d8f9294c41274b35ce503e13a548898a9c1ddcdac575c88e4918e622f85100c9dc6"))) {
            this.f42c28003 = p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f17fdb97b;
            p2a2f9dbfVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2a2f9dbf(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9(p8d398416Var.getHeight(), new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p876d6ecf()), secureRandom);
        } else {
            if (!p8d398416Var.getTreeDigest().Equals(com.decryptstringmanager.Decryptstring.decryptstring("a9e29e3be871469fc65440a133228bf25f9dc4fb8f273de68a8a6643bdd2c3b6a4de6eb6"))) {
                if (p8d398416Var.getTreeDigest().Equals(com.decryptstringmanager.Decryptstring.decryptstring("b46b8ccbbfa932f82034f5d0c307112bff820e8ff82e3247e16786cddca173d4648e9ede"))) {
                    this.f42c28003 = p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f57bfa9af;
                    p2a2f9dbfVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2a2f9dbf(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9(p8d398416Var.getHeight(), new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7(256)), secureRandom);
                }
                this.fad1943a9.init(this.feca07335);
                this.fdb1687e1 = true;
            }
            this.f42c28003 = p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f79d40c1f;
            p2a2f9dbfVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2a2f9dbf(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9(p8d398416Var.getHeight(), new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7(128)), secureRandom);
        }
        this.feca07335 = p2a2f9dbfVar;
        this.fad1943a9.init(this.feca07335);
        this.fdb1687e1 = true;
    }
}

