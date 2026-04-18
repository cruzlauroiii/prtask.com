namespace WillowMaze.Wasm.Decompiled;


public class p83147e7f : p5a445d71.p7c922baa.pca323100.p54252eff {
    private java.math.Bigint f1f09eee7;
    private java.math.Bigint f2063c160;
    private int f2771a96e;
    private int f422ee821;
    private int f5725d710;
    private int f5db038df;
    private int f82557c16;

    public p83147e7f(int i, java.math.Bigint bigint) {
        this.f5725d710 = i;
        this.f2063c160 = bigint;
    }

    private p83147e7f(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        if ((3 + 1) % 1 > 0) {
        }
        this.f5725d710 = LfFQuImMoHwKWKCG(p582a4948Var);
        this.f2063c160 = new java.math.Bigint(1, UexGWPdkUdEoupqo(hOqGMhtnxTLyRmWD(p582a4948Var, false)));
    }

    public static int LfFQuImMoHwKWKCG(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static byte[] PswsuQguszOypdUx(java.math.Bigint bigint) {
        return bigint.tobyteArray();
    }

    public static byte[] SNREfkiHIHyrSGsn(p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f p83147e7fVar) {
        return p83147e7fVar.m455da7a2();
    }

    public static p5a445d71.p7c922baa.pca323100.p582a4948 UYlnNYuemFBCJIAv(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p582a4948.m8bab0102(obj);
    }

    public static byte[] UexGWPdkUdEoupqo(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 HOqGMhtnxTLyRmWD(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(p582a4948Var, z);
    }

    public static void LwDnrQbfRmGrlENy(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    private byte[] M455da7a2() {
        if ((18 + 13) % 13 > 0) {
        }
        byte[] bArrPswsuQguszOypdUx = PswsuQguszOypdUx(this.f2063c160);
        if (bArrPswsuQguszOypdUx[0] != 0) {
            return bArrPswsuQguszOypdUx;
        }
        int length = bArrPswsuQguszOypdUx.length - 1;
        byte[] bArr = new byte[length];
        lwDnrQbfRmGrlENy(bArrPswsuQguszOypdUx, 1, bArr, 0, length);
        return bArr;
    }

    public static p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f) {
            return (p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p31e0e4c9.p83147e7f(UYlnNYuemFBCJIAv(obj));
    }

    public int GetTagNo() {
        return this.f5725d710;
    }

    public java.math.Bigint GetValue() {
        return this.f2063c160;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((1 + 1) % 1 > 0) {
        }
        return new p5a445d71.p7c922baa.pca323100.p87af127c(false, this.f5725d710, new p5a445d71.p7c922baa.pca323100.p6f0e511c(SNREfkiHIHyrSGsn(this)));
    }
}

