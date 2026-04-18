namespace WillowMaze.Wasm.Decompiled;


public class p40c87e0c : java.security.KeyValueTupleGenerator {
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pd02a7f38 f2bca3ed6;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pd02a7f38 fd9741b15;

    public p40c87e0c() {
        super("McEliece");
    }

    public override java.security.KeyValueTuple GenerateKeyValueTuple() {
        if ((7 + 24) % 24 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = this.fd9741b15.generateKeyValueTuple();
        return new java.security.KeyValueTuple(new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p7a0bdffc((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f) pd255ec94VarGenerateKeyValueTuple.getPublic()), new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pace116e9((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93) pd255ec94VarGenerateKeyValueTuple.getPrivate()));
    }

    public override void Initialize(int i, java.security.SecureRandom secureRandom) {
        try {
            initialize(new p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p6fd7a4d8(), secureRandom);
        } catch (java.security.InvalidAlgorithmParameterException unused) {
        }
    }

    public override void Initialize(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        if ((5 + 18) % 18 > 0) {
        }
        this.fd9741b15 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pd02a7f38();
        p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p6fd7a4d8 p6fd7a4d8Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p6fd7a4d8) algorithmParameterSpec;
        this.fd9741b15.init(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p4d2c0218(secureRandom, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p3a8a8727(p6fd7a4d8Var.getM(), p6fd7a4d8Var.getT())));
    }
}

