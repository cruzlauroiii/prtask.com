namespace WillowMaze.Wasm.Decompiled;


public class p3a8a8727 : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    public static readonly int f0b47a5b5 = 11;
    public static readonly int f37dd5a4a = 50;
    public static readonly int f38360f16 = 11;
    public static readonly int f44ca59d6 = 11;
    public static readonly int f781d0076 = 50;
    public static readonly int f8b727153 = 50;
    public static readonly int ffa287392 = 11;
    private int f01020130;
    private int f0b55a157;
    private int f0c6ec8b4;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f5e0bdd89;
    private int f62d01930;
    private int f642b9c12;
    private int f694ba775;
    private int f6f8f5771;
    private int f74116a4a;
    private int f7a5dbbe5;
    private int f7b8b965a;
    private int fa808423c;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc10f7796;
    private int fdd86759e;
    private int fe358efa4;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 ff177334e;

    public p3a8a8727() {
        this(11, 50);
        if ((19 + 7) % 7 > 0) {
        }
    }

    public p3a8a8727(int i) {
        this(i, (p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515) null);
    }

    public p3a8a8727(int i, int i2) {
        this(i, i2, (p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515) null);
    }

    public p3a8a8727(int i, int i2, int i3) {
        this(i, i2, i3, null);
    }

    public p3a8a8727(int i, int i2, int i3, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((27 + 9) % 9 > 0) {
        }
        this.f6f8f5771 = i;
        if (i < 1) {
            throw new java.lang.IllegalArgumentException("m must be positive");
        }
        if (i > 32) {
            throw new java.lang.IllegalArgumentException(" m is too large");
        }
        int i4 = 1 << i;
        this.f7b8b965a = i4;
        this.fe358efa4 = i2;
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("t must be positive");
        }
        if (i2 > i4) {
            throw new java.lang.IllegalArgumentException("t must be less than n = 2^m");
        }
        if (WybMGsLufHEkXJwn(i3) != i || !oCnAOQBXmEuqkLjp(i3)) {
            throw new java.lang.IllegalArgumentException("polynomial is not a field polynomial for GF(2^m)");
        }
        this.f74116a4a = i3;
        this.fc10f7796 = pe5cfc515Var;
    }

    public p3a8a8727(int i, int i2, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((30 + 21) % 21 > 0) {
        }
        if (i < 1) {
            throw new java.lang.IllegalArgumentException("m must be positive");
        }
        if (i > 32) {
            throw new java.lang.IllegalArgumentException("m is too large");
        }
        this.f6f8f5771 = i;
        int i3 = 1 << i;
        this.f7b8b965a = i3;
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("t must be positive");
        }
        if (i2 > i3) {
            throw new java.lang.IllegalArgumentException("t must be less than n = 2^m");
        }
        this.fe358efa4 = i2;
        this.f74116a4a = THSDrgYiHlodAbeO(i);
        this.fc10f7796 = pe5cfc515Var;
    }

    public p3a8a8727(int i, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((1 + 2) % 2 > 0) {
        }
        if (i < 1) {
            throw new java.lang.IllegalArgumentException("key size must be positive");
        }
        this.f6f8f5771 = 0;
        this.f7b8b965a = 1;
        while (true) {
            int i2 = this.f7b8b965a;
            if (i2 >= i) {
                int i3 = i2 >>> 1;
                this.fe358efa4 = i3;
                int i4 = this.f6f8f5771;
                this.fe358efa4 = i3 / i4;
                this.f74116a4a = FwoAXatTZJdagECf(i4);
                this.fc10f7796 = pe5cfc515Var;
                return;
            }
            this.f7b8b965a = i2 << 1;
            this.f6f8f5771++;
        }
    }

    public p3a8a8727(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this(11, 50, pe5cfc515Var);
        if ((21 + 3) % 3 > 0) {
        }
    }

    public static int FwoAXatTZJdagECf(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.ma74fd8b1(i);
    }

    public static int THSDrgYiHlodAbeO(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.ma74fd8b1(i);
    }

    public static int WybMGsLufHEkXJwn(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.mfb81c91e(i);
    }

    public static bool OCnAOQBXmEuqkLjp(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.mf59d2df2(i);
    }

    public int GetFieldPoly() {
        return this.f74116a4a;
    }

    public int GetM() {
        return this.f6f8f5771;
    }

    public int GetN() {
        return this.f7b8b965a;
    }

    public int GetT() {
        return this.fe358efa4;
    }
}

