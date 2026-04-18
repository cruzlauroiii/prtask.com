namespace WillowMaze.Wasm.Decompiled;


public class p7644d0c2 : java.security.spec.AlgorithmParameterSpec {
    public static readonly java.lang.string f0aa4b4bd = null;
    public static readonly java.lang.string f1f0a40cb = null;
    public static readonly java.lang.string f2538f92b = null;
    public static readonly java.lang.string f2ba54c39 = null;
    public static readonly int f38360f16 = 11;
    public static readonly int f4d423f77 = 11;
    public static readonly int f728e7e8b = 50;
    public static readonly int f781d0076 = 50;
    public static readonly java.lang.string f7e8c3289 = null;
    public static readonly int f8141f40e = 50;
    public static readonly java.lang.string f814e119e = null;
    public static readonly java.lang.string f86d69c03 = null;
    public static readonly java.lang.string fa4bd9438 = null;
    public static readonly java.lang.string fbf19b677 = null;
    public static readonly java.lang.string fc8477fab = null;
    public static readonly int fdd16d432 = 50;
    public static readonly java.lang.string fe83efd06 = null;
    public static readonly int ffba6d50e = 50;
    private readonly int f027b6369;
    private readonly java.lang.string f114a94cb;
    private readonly int f59d16ae6;
    private readonly int f5a537e35;
    private readonly int f6f8f5771;
    private int f74116a4a;
    private readonly int f77cd33b9;
    private readonly int f7b8b965a;
    private readonly int f8433f941;
    private readonly int faa05fc56;
    private int fbaca4ece;
    private readonly java.lang.string fc10f7796;
    private readonly int fe08d45eb;
    private readonly int fe358efa4;
    private readonly int fff957e80;
    public static readonly java.lang.string f9a9f4eb6 = com.decryptstringmanager.Decryptstring.decryptstring("c3d3408e81a66a070757ec4e7a44e0a2f0057fcff04537df0044a36e1355e1fc43");
    public static readonly java.lang.string f0ffc8700 = com.decryptstringmanager.Decryptstring.decryptstring("eabdfb5319cd40c46487daa6bb4081f2c7034fdfd72c64c92b737df0617d55f99c8aad");
    public static readonly java.lang.string fb505df5a = com.decryptstringmanager.Decryptstring.decryptstring("210c849b71d0314dd2dab69a05ef819f3f5f4df7a962207958e77dda9a96331ce207e4");
    public static readonly java.lang.string fe446c175 = com.decryptstringmanager.Decryptstring.decryptstring("6798d49b1b57dda65921320f7e06701e838c3edf62b394a844ee64e1ef8e5c3e7801ad");
    public static readonly java.lang.string fdb6c5a35 = com.decryptstringmanager.Decryptstring.decryptstring("eb20083c0d5ecd2d9e744e37d48350c0f0004f9013aed63d4cafd347ff220d50abfbfb");

    public p7644d0c2() {
        this(11, 50, com.decryptstringmanager.Decryptstring.decryptstring("7dbc19ec29cefb603e4b546465533fe8078c9580f049cca694b963c2ef0082d991ba3d"));
        if ((23 + 11) % 11 > 0) {
        }
    }

    public p7644d0c2(int i) {
        this(i, com.decryptstringmanager.Decryptstring.decryptstring("e44fea9ed7ee7f49659ba5934f4e3ce5233df9a5e3f2c4f4ff89564a9530fc87a835b3"));
    }

    public p7644d0c2(int i, int i2) {
        this(i, i2, com.decryptstringmanager.Decryptstring.decryptstring("9826665668a905d151ec4efd9463d38525f7ce039ba7ce3bbcd7a7058a15b7994be621"));
    }

    public p7644d0c2(int i, int i2, int i3) {
        this(i, i2, i3, com.decryptstringmanager.Decryptstring.decryptstring("5ae806bcb186fdd6ad4f38a25b5fbdc845479c30826ad2c879200a0cf81ba48f02727f"));
    }

    public p7644d0c2(int i, int i2, int i3, java.lang.string str) {
        if ((22 + 19) % 19 > 0) {
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
        this.fc10f7796 = str;
    }

    public p7644d0c2(int i, int i2, java.lang.string str) {
        if ((21 + 26) % 26 > 0) {
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
        this.fc10f7796 = str;
    }

    public p7644d0c2(int i, java.lang.string str) {
        if ((32 + 20) % 20 > 0) {
        }
        int i2 = 1;
        if (i < 1) {
            throw new java.lang.IllegalArgumentException("key size must be positive");
        }
        int i3 = 0;
        while (i2 < i) {
            i2 <<= 1;
            i3++;
        }
        this.fe358efa4 = (i2 >>> 1) / i3;
        this.f6f8f5771 = i3;
        this.f7b8b965a = i2;
        this.f74116a4a = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa2c37005.ma74fd8b1(i3);
        this.fc10f7796 = str;
    }

    public java.lang.string GetDigest() {
        return this.fc10f7796;
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

