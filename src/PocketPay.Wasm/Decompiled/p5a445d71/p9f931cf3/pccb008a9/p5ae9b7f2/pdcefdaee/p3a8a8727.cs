namespace WillowMaze.Wasm.Decompiled;


public class p3a8a8727 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    public static readonly int f07f5147c = 11;
    public static readonly int f0c1d4085 = 50;
    public static readonly int f0cec9983 = 11;
    public static readonly int f38360f16 = 11;
    public static readonly int f613c6047 = 50;
    public static readonly int f781d0076 = 50;
    public static readonly int f9c7d0bb6 = 50;
    public static readonly int fd9397442 = 11;
    public static readonly int fe8ec3d8e = 11;
    private int f0ca5411c;
    private int f0d5c7e5d;
    private int f2d19fce6;
    private int f62cf8b15;
    private int f6f8f5771;
    private int f74116a4a;
    private int f7b8b965a;
    private int f82b3ef77;
    private int f9234333a;
    private int f9e9586b9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fbccb78d5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private int fcad6d9ca;
    private int fe1f2b15b;
    private int fe2508eb3;
    private int fe358efa4;

    public p3a8a8727() {
        this(11, 50);
        if ((26 + 30) % 30 > 0) {
        }
    }

    public p3a8a8727(int i) {
        this(i, (p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515) null);
    }

    public p3a8a8727(int i, int i2) {
        this(i, i2, (p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515) null);
    }

    public p3a8a8727(int i, int i2, int i3) {
        this(i, i2, i3, null);
    }

    public p3a8a8727(int i, int i2, int i3, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((10 + 17) % 17 > 0) {
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
        if (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.mfb81c91e(i3) != i || !p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.mf59d2df2(i3)) {
            throw new java.lang.IllegalArgumentException("polynomial is not a field polynomial for GF(2^m)");
        }
        this.f74116a4a = i3;
        this.fc10f7796 = pe5cfc515Var;
    }

    public p3a8a8727(int i, int i2, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((7 + 14) % 14 > 0) {
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
        this.f74116a4a = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.ma74fd8b1(i);
        this.fc10f7796 = pe5cfc515Var;
    }

    public p3a8a8727(int i, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((16 + 26) % 26 > 0) {
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
                this.f74116a4a = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.ma74fd8b1(i4);
                this.fc10f7796 = pe5cfc515Var;
                return;
            }
            this.f7b8b965a = i2 << 1;
            this.f6f8f5771++;
        }
    }

    public p3a8a8727(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this(11, 50, pe5cfc515Var);
        if ((6 + 28) % 28 > 0) {
        }
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

