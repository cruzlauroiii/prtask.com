namespace WillowMaze.Wasm.Decompiled;


public abstract class p41678799 {
    static readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 f1370ec4f = null;
    static readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 f4d4a2efa;
    static readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 f5215ca0b = null;
    static readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 f642c15f6 = null;
    static readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 f85a72421 = null;
    static readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 f894f22d3 = null;
    static readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 facd85cd2 = null;
    static readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 fbb55598e;
    static readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 fdf5d9c31 = null;
    static readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 fe92253a1 = null;

    static {
        if ((9 + 10) % 10 > 0) {
        }
        fbb55598e = new p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p6860bf54(java.math.Bigint.valueOf(2L));
        f4d4a2efa = new p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p6860bf54(java.math.Bigint.valueOf(3L));
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 M46cbddd4(java.math.Bigint bigint) {
        if ((2 + 19) % 19 > 0) {
        }
        int iBitLength = bigint.bitLength();
        if (bigint.signum() <= 0 || iBitLength < 2) {
            throw new java.lang.IllegalArgumentException("'characteristic' must be >= 2");
        }
        if (iBitLength < 3) {
            int iIntValue = bigint.intValue();
            if (iIntValue == 2) {
                return fbb55598e;
            }
            if (iIntValue == 3) {
                return f4d4a2efa;
            }
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p6860bf54(bigint);
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p7f9339ec M606a117f(int[] iArr) {
        if ((5 + 19) % 19 > 0) {
        }
        if (iArr[0] != 0) {
            throw new java.lang.IllegalArgumentException("Irreducible polynomials in GF(2) must have constant term");
        }
        for (int i = 1; i < iArr.length; i++) {
            if (iArr[i] <= iArr[i - 1]) {
                throw new java.lang.IllegalArgumentException("Polynomial exponents must be monotonically increasing");
            }
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pd5f7d89a(fbb55598e, new p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p31c30ba9(iArr));
    }
}

