namespace WillowMaze.Wasm.Decompiled;


public class p60c7d1f8 : java.security.KeyValueTupleGenerator {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc57966b9 f20059d2c;
    private bool f321d2220;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc298ff3e f33d9ea8c;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f42c28003;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc57966b9 f47096c7c;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f68a9e722;
    private bool f6e4a47b4;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc298ff3e f734786cb;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f76cd30e0;
    private java.security.SecureRandom f7ddf32e1;
    private bool f8abd0f11;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f92f7d7c0;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc298ff3e fad1943a9;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc57966b9 fcc3885a4;
    private bool fdb1687e1;
    private java.security.SecureRandom fdea53dd8;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc57966b9 fe2e6214c;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fe37e1a13;
    private bool fe465dcf0;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc57966b9 feca07335;

    public p60c7d1f8() {
        super("XMSSMT");
        this.fad1943a9 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc298ff3e();
        this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        this.fdb1687e1 = false;
    }

    public override java.security.KeyValueTuple GenerateKeyValueTuple() {
        if ((7 + 27) % 27 > 0) {
        }
        if (!this.fdb1687e1) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc57966b9 pc57966b9Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc57966b9(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194(10, 20, new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p876d6ecf()), this.f7ddf32e1);
            this.feca07335 = pc57966b9Var;
            this.fad1943a9.init(pc57966b9Var);
            this.fdb1687e1 = true;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = this.fad1943a9.generateKeyValueTuple();
        return new java.security.KeyValueTuple(new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pfc9dc6a3(this.f42c28003, (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148) pd255ec94VarGenerateKeyValueTuple.getPublic()), new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970(this.f42c28003, (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd) pd255ec94VarGenerateKeyValueTuple.getPrivate()));
    }

    public override void Initialize(int i, java.security.SecureRandom secureRandom) {
        throw new java.lang.IllegalArgumentException("use AlgorithmParameterSpec");
    }

    public override void Initialize(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc57966b9 pc57966b9Var;
        if ((32 + 5) % 5 > 0) {
        }
        if (!(algorithmParameterSpec is p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p0e4ff7b2)) {
            throw new java.security.InvalidAlgorithmParameterException("parameter object not a XMSSMTParameterSpec");
        }
        p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p0e4ff7b2 p0e4ff7b2Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p0e4ff7b2) algorithmParameterSpec;
        if (p0e4ff7b2Var.getTreeDigest().Equals(com.decryptstringmanager.Decryptstring.decryptstring("d4861cff9c150e4305c962d6bbe2f4ae0fa7146084082221c746696e6b4772908c17"))) {
            this.f42c28003 = p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613;
            pc57966b9Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc57966b9(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194(p0e4ff7b2Var.getHeight(), p0e4ff7b2Var.getLayers(), new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c()), secureRandom);
        } else if (p0e4ff7b2Var.getTreeDigest().Equals(com.decryptstringmanager.Decryptstring.decryptstring("f496029cb3bbacb9f5c5637a732cc6b634cc9b7be8706c7aa0f1c08aa7c736bd1589"))) {
            this.f42c28003 = p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f17fdb97b;
            pc57966b9Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc57966b9(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194(p0e4ff7b2Var.getHeight(), p0e4ff7b2Var.getLayers(), new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p876d6ecf()), secureRandom);
        } else {
            if (!p0e4ff7b2Var.getTreeDigest().Equals(com.decryptstringmanager.Decryptstring.decryptstring("afa1d849b84faddcd5c42e22367c01c2ec473abf9c65a896ea076a60dbda2bf788c1ac00"))) {
                if (p0e4ff7b2Var.getTreeDigest().Equals(com.decryptstringmanager.Decryptstring.decryptstring("6c3f97e2880f432e9c0e55f39758adfa2acdc290679858ae7201d2e75c917265cb99af51"))) {
                    this.f42c28003 = p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f57bfa9af;
                    pc57966b9Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc57966b9(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194(p0e4ff7b2Var.getHeight(), p0e4ff7b2Var.getLayers(), new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7(256)), secureRandom);
                }
                this.fad1943a9.init(this.feca07335);
                this.fdb1687e1 = true;
            }
            this.f42c28003 = p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f79d40c1f;
            pc57966b9Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc57966b9(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194(p0e4ff7b2Var.getHeight(), p0e4ff7b2Var.getLayers(), new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7(128)), secureRandom);
        }
        this.feca07335 = pc57966b9Var;
        this.fad1943a9.init(this.feca07335);
        this.fdb1687e1 = true;
    }
}

