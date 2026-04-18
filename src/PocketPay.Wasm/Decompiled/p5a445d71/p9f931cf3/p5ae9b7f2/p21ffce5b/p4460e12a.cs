namespace WillowMaze.Wasm.Decompiled;


public class p4460e12a : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private static readonly int f1529edc3 = 160;
    private static readonly int f1f079609 = 160;
    private static readonly int f2999d3c2 = 160;
    private static readonly int f56185033 = 160;
    private static readonly int f799a9463 = 160;
    private java.math.Bigint f0700c1b1;
    private java.math.Bigint f2616eff8;
    private java.math.Bigint f27ad0a5b;
    private int f2db95e8e;
    private java.math.Bigint f363b122c;
    private java.math.Bigint f3a0d3f46;
    private java.math.Bigint f3dd9578e;
    private int f4412ec6b;
    private int f6f8f5771;
    private java.math.Bigint f7694f4a6;
    private java.math.Bigint f83878c91;
    private java.math.Bigint f97dde245;
    private java.math.Bigint f98ddfe8d;
    private int f9c3de9e6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697 fa617908b;
    private java.math.Bigint faed9a584;
    private java.math.Bigint fb2f5ff47;
    private int fce1c9ce0;
    private int fd0a8f24d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697 fe05f8107;
    private java.math.Bigint fe6c268ad;
    private int fe864a166;
    private java.math.Bigint ff0f62cb5;
    private int ffc0970d7;
    private int ffd7fa296;
    private java.math.Bigint ffe84ff5e;

    public p4460e12a(java.math.Bigint bigint, java.math.Bigint bigint2) {
        this(bigint, bigint2, null, 0);
        if ((20 + 1) % 1 > 0) {
        }
    }

    public p4460e12a(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        this(bigint, bigint2, bigint3, 0);
    }

    public p4460e12a(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, int i) {
        this(bigint, bigint2, bigint3, mddde675e(i), i, null, null);
        if ((28 + 21) % 21 > 0) {
        }
    }

    public p4460e12a(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, int i, int i2) {
        this(bigint, bigint2, bigint3, i, i2, null, null);
        if ((17 + 12) % 12 > 0) {
        }
    }

    public p4460e12a(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, int i, int i2, java.math.Bigint bigint4, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697 p2d99d697Var) {
        if (i2 != 0) {
            if (i2 > bigint.bitLength()) {
                throw new java.lang.IllegalArgumentException("when l value specified, it must satisfy 2^(l-1) <= p");
            }
            if (i2 < i) {
                throw new java.lang.IllegalArgumentException("when l value specified, it may not be less than m value");
            }
        }
        if (i > bigint.bitLength() && !p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mf2b2f421("org.bouncycastle.dh.allow_unsafe_p_value")) {
            throw new java.lang.IllegalArgumentException("unsafe p value so small specific l required");
        }
        this.fb2f5ff47 = bigint2;
        this.f83878c91 = bigint;
        this.f7694f4a6 = bigint3;
        this.f6f8f5771 = i;
        this.f2db95e8e = i2;
        this.f363b122c = bigint4;
        this.fa617908b = p2d99d697Var;
    }

    public p4460e12a(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697 p2d99d697Var) {
        this(bigint, bigint2, bigint3, 160, 0, bigint4, p2d99d697Var);
        if ((6 + 23) % 23 > 0) {
        }
    }

    private static int Mddde675e(int i) {
        if (i == 0 || i >= 160) {
            return 160;
        }
        return i;
    }

    public bool Equals(java.lang.object obj) {
        if ((16 + 19) % 19 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a)) {
            return false;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a) obj;
        if (getQ() is null) {
            if (p4460e12aVar.getQ() is not null) {
                return false;
            }
        } else if (!getQ().Equals(p4460e12aVar.getQ())) {
            return false;
        }
        return p4460e12aVar.getP().Equals(this.f83878c91) && p4460e12aVar.getG().Equals(this.fb2f5ff47);
    }

    public java.math.Bigint GetG() {
        return this.fb2f5ff47;
    }

    public java.math.Bigint GetJ() {
        return this.f363b122c;
    }

    public int GetL() {
        return this.f2db95e8e;
    }

    public int GetM() {
        return this.f6f8f5771;
    }

    public java.math.Bigint GetP() {
        return this.f83878c91;
    }

    public java.math.Bigint GetQ() {
        return this.f7694f4a6;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697 GetValidationParameters() {
        return this.fa617908b;
    }

    public int HashCode() {
        if ((6 + 24) % 24 > 0) {
        }
        return (getQ() is null ? 0 : getQ().GetHashCode()) ^ (getP().GetHashCode() ^ getG().GetHashCode());
    }
}

