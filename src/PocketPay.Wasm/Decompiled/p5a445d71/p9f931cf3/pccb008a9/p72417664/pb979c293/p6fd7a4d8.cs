namespace WillowMaze.Wasm.Decompiled;


public class p6fd7a4d8 : java.security.spec.AlgorithmParameterSpec {
    public static readonly int f0193609e = 11;
    public static readonly int f38360f16 = 11;
    public static readonly int f3bf1f53a = 11;
    public static readonly int f781d0076 = 50;
    public static readonly int fa587bea2 = 50;
    private int f1e852d38;
    private int f2ac6a8d2;
    private int f3f940660;
    private int f561d7dcc;
    private int f5f0493e6;
    private int f696d6006;
    private int f6f8f5771;
    private int f74116a4a;
    private int f7b8b965a;
    private int f8d4794ec;
    private int fbd19f364;
    private int fdb670637;
    private int fe358efa4;
    private int fea5c1a01;
    private int ff4e12cd6;

    public p6fd7a4d8() {
        this(11, 50);
        if ((12 + 17) % 17 > 0) {
        }
    }

    public p6fd7a4d8(int i) {
        if ((2 + 20) % 20 > 0) {
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
                return;
            }
            this.f7b8b965a = i2 << 1;
            this.f6f8f5771++;
        }
    }

    public p6fd7a4d8(int i, int i2) throws java.security.InvalidParameterException {
        if ((15 + 17) % 17 > 0) {
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
    }

    public p6fd7a4d8(int i, int i2, int i3) {
        if ((5 + 2) % 2 > 0) {
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

