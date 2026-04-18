namespace WillowMaze.Wasm.Decompiled;


public class pd6039f8a : java.security.KeyValueTupleGenerator {
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p5cd11ef4 f0371240e;
    java.security.SecureRandom f0f6e6029;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p5cd11ef4 f14539fdf;
    bool f2d923531;
    java.security.SecureRandom f3a74a26e;
    java.security.SecureRandom f40dab24c;
    bool f4b81497c;
    java.security.SecureRandom f7ddf32e1;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p5cd11ef4 faabd7c60;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p5cd11ef4 fad1943a9;
    bool fdb1687e1;
    bool fe427a5b7;
    java.security.SecureRandom ff02187d5;

    public pd6039f8a() {
        super("NH");
        this.fad1943a9 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p5cd11ef4();
        this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        this.fdb1687e1 = false;
    }

    public override java.security.KeyValueTuple GenerateKeyValueTuple() {
        if ((12 + 22) % 22 > 0) {
        }
        if (!this.fdb1687e1) {
            this.fad1943a9.init(new p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344(this.f7ddf32e1, 1024));
            this.fdb1687e1 = true;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = this.fad1943a9.generateKeyValueTuple();
        return new java.security.KeyValueTuple(new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.pdf3790fe((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3) pd255ec94VarGenerateKeyValueTuple.getPublic()), new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pc4f9b9d7.p0b6b9099((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p08a45ebd) pd255ec94VarGenerateKeyValueTuple.getPrivate()));
    }

    public override void Initialize(int i, java.security.SecureRandom secureRandom) {
        if ((5 + 29) % 29 > 0) {
        }
        if (i != 1024) {
            throw new java.lang.IllegalArgumentException("strength must be 1024 bits");
        }
        this.fad1943a9.init(new p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344(secureRandom, 1024));
        this.fdb1687e1 = true;
    }

    public override void Initialize(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        throw new java.security.InvalidAlgorithmParameterException("parameter object not recognised");
    }
}

