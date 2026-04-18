namespace WillowMaze.Wasm.Decompiled;


public class p2aacdd87 : p5a445d71.p9f931cf3.p5ae9b7f2.p38d4f313 {
    private static readonly java.math.Bigint f9140e166 = null;
    private static readonly java.math.Bigint fbc21e648;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a f80c66df7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec faa548528;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a fc16955d9;

    static {
        if ((18 + 19) % 19 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    public override java.math.Bigint CalculateAgreement(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((18 + 13) % 13 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 p1bfd3a52Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52) pc9ef6b45Var;
        if (!p1bfd3a52Var.getParameters().Equals(this.f80c66df7)) {
            throw new java.lang.IllegalArgumentException("Diffie-Hellman public key has wrong parameters.");
        }
        java.math.Bigint p = this.f80c66df7.getP();
        java.math.Bigint y = p1bfd3a52Var.getY();
        if (y is not null) {
            java.math.Bigint bigint = fbc21e648;
            if (y.compareTo(bigint) > 0 && y.compareTo(p.subtract(bigint)) < 0) {
                java.math.Bigint bigintModPow = y.modPow(this.f3c6e0b8a.getX(), p);
                if (bigintModPow.Equals(bigint)) {
                    throw new java.lang.IllegalStateException("Shared key can't be 1");
                }
                return bigintModPow;
            }
        }
        throw new java.lang.IllegalArgumentException("Diffie-Hellman public key is weak");
    }

    public override int GetFieldSize() {
        return (this.f3c6e0b8a.getParameters().getP().bitLength() + 7) / 8;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            pc9ef6b45Var = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var).getParameters();
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) pc9ef6b45Var;
        if (!(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec)) {
            throw new java.lang.IllegalArgumentException("DHEngine expects DHPrivateKeyParameters");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec pc9dc4fecVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec) pcfffbc4aVar;
        this.f3c6e0b8a = pc9dc4fecVar;
        this.f80c66df7 = pc9dc4fecVar.getParameters();
    }
}

