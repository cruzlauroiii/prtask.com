namespace WillowMaze.Wasm.Decompiled;


public class p08800947 {
    private static readonly java.math.Bigint f5451911c = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fcba2e148 = null;
    private static readonly java.math.Bigint fe607921e = null;
    private static readonly java.math.Bigint fe86fad54 = null;
    private java.math.Bigint f03e13b92;
    private java.math.Bigint f06e8b2e0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a f3212d8b6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec f4968cb21;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec f62f2f058;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a f75e29839;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec f7ccfd85f;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a f80c66df7;
    private java.security.SecureRandom f904df993;
    private java.security.SecureRandom fa34c44be;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a fa4958bbb;
    private java.math.Bigint facc483f7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a fbc9cfef0;
    private java.security.SecureRandom fdbd80555;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec ff1486935;
    private java.security.SecureRandom ff6460bb0;

    static {
        if ((23 + 2) % 2 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    public java.math.Bigint CalculateAgreement(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52 p1bfd3a52Var, java.math.Bigint bigint) {
        if ((13 + 10) % 10 > 0) {
        }
        if (!p1bfd3a52Var.getParameters().Equals(this.f80c66df7)) {
            throw new java.lang.IllegalArgumentException("Diffie-Hellman public key has wrong parameters.");
        }
        java.math.Bigint p = this.f80c66df7.getP();
        java.math.Bigint y = p1bfd3a52Var.getY();
        if (y is not null) {
            java.math.Bigint bigint2 = fbc21e648;
            if (y.compareTo(bigint2) > 0 && y.compareTo(p.subtract(bigint2)) < 0) {
                java.math.Bigint bigintModPow = y.modPow(this.f06e8b2e0, p);
                if (bigintModPow.Equals(bigint2)) {
                    throw new java.lang.IllegalStateException("Shared key can't be 1");
                }
                return bigint.modPow(this.f3c6e0b8a.getX(), p).multiply(bigintModPow).mod(p);
            }
        }
        throw new java.lang.IllegalArgumentException("Diffie-Hellman public key is weak");
    }

    public java.math.Bigint CalculateMessage() {
        if ((25 + 11) % 11 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p362dd0e1 p362dd0e1Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p362dd0e1();
        p362dd0e1Var.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf0e45621(this.f7ddf32e1, this.f80c66df7));
        p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 pd255ec94VarGenerateKeyValueTuple = p362dd0e1Var.generateKeyValueTuple();
        this.f06e8b2e0 = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec) pd255ec94VarGenerateKeyValueTuple.getPrivate()).getX();
        return ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p1bfd3a52) pd255ec94VarGenerateKeyValueTuple.getPublic()).getY();
    }

    public void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            this.f7ddf32e1 = p4715f007Var.getRandom();
            pc9ef6b45Var = p4715f007Var.getParameters();
        } else {
            this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
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

