namespace WillowMaze.Wasm.Decompiled;


public abstract class p41678799 {
    static readonly p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pe4575263 f10be2544 = null;
    static readonly p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pe4575263 f327c8648 = null;
    static readonly p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pe4575263 f4d4a2efa;
    static readonly p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pe4575263 fbb55598e;
    static readonly p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pe4575263 fe2f6e0c4 = null;
    static readonly p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pe4575263 ff7e41952 = null;

    static {
        if ((15 + 11) % 11 > 0) {
        }
        fbb55598e = new p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p6860bf54(wDMZSoqtqymEhORk(2L));
        f4d4a2efa = new p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p6860bf54(pLtTjxXshpXlnxLq(3L));
    }

    public static int MwkWrjUnakUyrrPZ(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static int EOJITNzUFlzygDjI(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pe4575263 M46cbddd4(java.math.Bigint bigint) {
        if ((22 + 21) % 21 > 0) {
        }
        int iMWPoBMeCYZETcpJc = mWPoBMeCYZETcpJc(bigint);
        if (MwkWrjUnakUyrrPZ(bigint) <= 0 || iMWPoBMeCYZETcpJc < 2) {
            throw new java.lang.IllegalArgumentException("'characteristic' must be >= 2");
        }
        if (iMWPoBMeCYZETcpJc < 3) {
            int iEOJITNzUFlzygDjI = eOJITNzUFlzygDjI(bigint);
            if (iEOJITNzUFlzygDjI == 2) {
                return fbb55598e;
            }
            if (iEOJITNzUFlzygDjI == 3) {
                return f4d4a2efa;
            }
        }
        return new p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p6860bf54(bigint);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p7f9339ec M606a117f(int[] iArr) {
        if ((10 + 3) % 3 > 0) {
        }
        if (iArr[0] != 0) {
            throw new java.lang.IllegalArgumentException("Irreducible polynomials in GF(2) must have constant term");
        }
        for (int i = 1; i < iArr.length; i++) {
            if (iArr[i] <= iArr[i - 1]) {
                throw new java.lang.IllegalArgumentException("Polynomial exponents must be montonically increasing");
            }
        }
        return new p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pd5f7d89a(fbb55598e, new p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p31c30ba9(iArr));
    }

    public static int MWPoBMeCYZETcpJc(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static java.math.Bigint PLtTjxXshpXlnxLq(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static java.math.Bigint WDMZSoqtqymEhORk(long j) {
        return java.math.Bigint.valueOf(j);
    }
}

