namespace WillowMaze.Wasm.Decompiled;


public class pd0ca61cd {
    private static java.math.Bigint f321facc2;
    private static java.math.Bigint f529e9e0b;
    private static java.math.Bigint f57949705;
    private static java.math.Bigint f5810eb12;
    private static java.math.Bigint f7c2c6917;
    private static java.math.Bigint f8b6a5d3f;
    private static java.math.Bigint fbc21e648;
    private static java.math.Bigint fe859430b;
    private static java.math.Bigint ff3ec6f7b;
    private static java.math.Bigint ff42df27a;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 f3c6e0b8a;
    private java.security.SecureRandom f3e2fb016;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom f7e874f0d;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 f82954c69;
    private java.security.SecureRandom f8aca8899;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 fb43b4d8a;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 fc5918d00;

    static {
        if ((30 + 21) % 21 > 0) {
        }
        f529e9e0b = GrUBFheABltVcwKI(0L);
        fbc21e648 = GamkLuAmEgARYLvh(1L);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GRZXUuiotYerppyM(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var) {
        return p4715f007Var.getParameters();
    }

    public static java.math.Bigint GamkLuAmEgARYLvh(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static java.math.Bigint GrUBFheABltVcwKI(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static bool KIJqaNPYjBDmotCl(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static java.math.Bigint KkPYqtczQSaUtHcF(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var) {
        return p753eae39Var.getModulus();
    }

    public static bool NTsnxBOswNSyZwJE(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static int ZVTjiohVNlYxwxdT(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static bool OqOnHNmLUOqDKXBi(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static java.math.Bigint RWAxDteTkXYWcmcQ(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.gcd(bigint2);
    }

    public static java.security.SecureRandom VZyJPXSztvlfoIqR(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var) {
        return p4715f007Var.getRandom();
    }

    public java.math.Bigint GenerateBlindingFactor() {
        if ((4 + 23) % 23 > 0) {
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var = this.f3c6e0b8a;
        if (p753eae39Var is null) {
            throw new java.lang.IllegalStateException("generator not initialised");
        }
        java.math.Bigint bigintKkPYqtczQSaUtHcF = KkPYqtczQSaUtHcF(p753eae39Var);
        int iZVTjiohVNlYxwxdT = ZVTjiohVNlYxwxdT(bigintKkPYqtczQSaUtHcF) - 1;
        while (true) {
            java.math.Bigint bigint = new java.math.Bigint(iZVTjiohVNlYxwxdT, this.f7ddf32e1);
            java.math.Bigint bigintRWAxDteTkXYWcmcQ = rWAxDteTkXYWcmcQ(bigint, bigintKkPYqtczQSaUtHcF);
            if (!oqOnHNmLUOqDKXBi(bigint, f529e9e0b) && !KIJqaNPYjBDmotCl(bigint, fbc21e648) && NTsnxBOswNSyZwJE(bigintRWAxDteTkXYWcmcQ, fbc21e648)) {
                return bigint;
            }
        }
    }

    public void Init(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007) {
            p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            this.f3c6e0b8a = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39) GRZXUuiotYerppyM(p4715f007Var);
            this.f7ddf32e1 = vZyJPXSztvlfoIqR(p4715f007Var);
        } else {
            this.f3c6e0b8a = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39) pc9ef6b45Var;
            this.f7ddf32e1 = new java.security.SecureRandom();
        }
        if (this.f3c6e0b8a is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p859968b9) {
            throw new java.lang.IllegalArgumentException("generator requires RSA public key");
        }
    }
}

