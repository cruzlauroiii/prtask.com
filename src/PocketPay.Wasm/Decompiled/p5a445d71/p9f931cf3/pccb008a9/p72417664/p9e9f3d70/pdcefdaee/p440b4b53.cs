namespace WillowMaze.Wasm.Decompiled;


public class p440b4b53 : java.security.KeyValueTupleGenerator {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p5cba4ae4 f1f2b45a4;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p5cba4ae4 f6a6d8e5d;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p5cba4ae4 fd9741b15;

    public p440b4b53() {
        super("McEliece-CCA2");
    }

    public override java.security.KeyValueTuple GenerateKeyValueTuple() {
        if ((1 + 19) % 19 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = this.fd9741b15.generateKeyValueTuple();
        return new java.security.KeyValueTuple(new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.p002d5cbb((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe) pd255ec94VarGenerateKeyValueTuple.getPublic()), new p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.pdcefdaee.pdfc33cf2((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f) pd255ec94VarGenerateKeyValueTuple.getPrivate()));
    }

    public override void Initialize(int i, java.security.SecureRandom secureRandom) {
        this.fd9741b15 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p5cba4ae4();
        this.fd9741b15.init(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p9cf83c3f(secureRandom, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pfe86320c()));
    }

    public override void Initialize(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.InvalidAlgorithmParameterException {
        if ((16 + 26) % 26 > 0) {
        }
        this.fd9741b15 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p5cba4ae4();
        p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p7644d0c2 p7644d0c2Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p7644d0c2) algorithmParameterSpec;
        this.fd9741b15.init(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p9cf83c3f(p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1(), new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pfe86320c(p7644d0c2Var.getM(), p7644d0c2Var.getT(), p7644d0c2Var.getDigest())));
    }

    public override void Initialize(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidAlgorithmParameterException {
        if ((19 + 17) % 17 > 0) {
        }
        this.fd9741b15 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p5cba4ae4();
        p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p7644d0c2 p7644d0c2Var = (p5a445d71.p9f931cf3.pccb008a9.p72417664.pb979c293.p7644d0c2) algorithmParameterSpec;
        this.fd9741b15.init(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p9cf83c3f(secureRandom, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pfe86320c(p7644d0c2Var.getM(), p7644d0c2Var.getT(), p7644d0c2Var.getDigest())));
    }
}

