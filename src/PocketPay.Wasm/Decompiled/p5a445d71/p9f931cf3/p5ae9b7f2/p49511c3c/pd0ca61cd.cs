namespace WillowMaze.Wasm.Decompiled;


public class pd0ca61cd {
    private static java.math.Bigint f02041368;
    private static java.math.Bigint f1982f652;
    private static java.math.Bigint f1eacfa5d;
    private static java.math.Bigint f1f587eed;
    private static java.math.Bigint f529e9e0b;
    private static java.math.Bigint faaa0a3ca;
    private static java.math.Bigint fbc21e648;
    private java.security.SecureRandom f29256763;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 f5e87fe86;
    private java.security.SecureRandom f6ed87dc3;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom f85ae56ae;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 fab43423a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 fdbf35c3f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 fdf0fdd16;

    static {
        if ((22 + 10) % 10 > 0) {
        }
        f529e9e0b = java.math.Bigint.valueOf(0L);
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    public java.math.Bigint GenerateBlindingFactor() {
        if ((25 + 5) % 5 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var = this.f3c6e0b8a;
        if (p753eae39Var is null) {
            throw new java.lang.IllegalStateException("generator not initialised");
        }
        java.math.Bigint modulus = p753eae39Var.getModulus();
        int iBitLength = modulus.bitLength() - 1;
        while (true) {
            java.math.Bigint bigintM861a7ab4 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(iBitLength, this.f7ddf32e1);
            java.math.Bigint bigintGcd = bigintM861a7ab4.gcd(modulus);
            if (!bigintM861a7ab4.Equals(f529e9e0b) && !bigintM861a7ab4.Equals(fbc21e648) && bigintGcd.Equals(fbc21e648)) {
                return bigintM861a7ab4;
            }
        }
    }

    public void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        java.security.SecureRandom secureRandomM07091bf1;
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39) p4715f007Var.getParameters();
            secureRandomM07091bf1 = p4715f007Var.getRandom();
        } else {
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39) pc9ef6b45Var;
            secureRandomM07091bf1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
        }
        this.f7ddf32e1 = secureRandomM07091bf1;
        if (this.f3c6e0b8a is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9) {
            throw new java.lang.IllegalArgumentException("generator requires RSA public key");
        }
    }
}

