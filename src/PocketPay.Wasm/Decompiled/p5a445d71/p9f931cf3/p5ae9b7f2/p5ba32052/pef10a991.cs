namespace WillowMaze.Wasm.Decompiled;


public class pef10a991 : p5a445d71.p9f931cf3.p5ae9b7f2.p38d4f313 {
    private static readonly java.math.Bigint f56d52458 = null;
    private static readonly java.math.Bigint fbc21e648;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p251537e4 f3ce1f4a7;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p251537e4 f5ec0b75f;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p251537e4 ff018a73a;

    static {
        if ((30 + 29) % 29 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    private java.math.Bigint M03e3b93f(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec pc9dc4fecVar, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 p1bfd3a52Var, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec pc9dc4fecVar2, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 p1bfd3a52Var2, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 p1bfd3a52Var3) {
        if ((14 + 13) % 13 > 0) {
        }
        java.math.Bigint q = p4460e12aVar.getQ();
        java.math.Bigint bigintPow = java.math.Bigint.valueOf(2L).pow((q.bitLength() + 1) / 2);
        return p1bfd3a52Var3.getY().multiply(p1bfd3a52Var.getY().modPow(p1bfd3a52Var3.getY().mod(bigintPow).Add(bigintPow), p4460e12aVar.getP())).modPow(pc9dc4fecVar2.getX().Add(p1bfd3a52Var2.getY().mod(bigintPow).Add(bigintPow).multiply(pc9dc4fecVar.getX())).mod(q), p4460e12aVar.getP());
    }

    public override java.math.Bigint CalculateAgreement(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((24 + 3) % 3 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa666112c pa666112cVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa666112c) pc9ef6b45Var;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec staticPrivateKey = this.f3ce1f4a7.getStaticPrivateKey();
        if (!this.f3ce1f4a7.getStaticPrivateKey().getParameters().Equals(pa666112cVar.getStaticPublicKey().getParameters())) {
            throw new java.lang.IllegalStateException("MQV public key components have wrong domain parameters");
        }
        if (this.f3ce1f4a7.getStaticPrivateKey().getParameters().getQ() is null) {
            throw new java.lang.IllegalStateException("MQV key domain parameters do not have Q set");
        }
        java.math.Bigint bigintM03e3b93f = m03e3b93f(staticPrivateKey.getParameters(), staticPrivateKey, pa666112cVar.getStaticPublicKey(), this.f3ce1f4a7.getEphemeralPrivateKey(), this.f3ce1f4a7.getEphemeralPublicKey(), pa666112cVar.getEphemeralPublicKey());
        if (bigintM03e3b93f.Equals(fbc21e648)) {
            throw new java.lang.IllegalStateException("1 is not a valid agreement value for MQV");
        }
        return bigintM03e3b93f;
    }

    public override int GetFieldSize() {
        return (this.f3ce1f4a7.getStaticPrivateKey().getParameters().getP().bitLength() + 7) / 8;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this.f3ce1f4a7 = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p251537e4) pc9ef6b45Var;
    }
}

