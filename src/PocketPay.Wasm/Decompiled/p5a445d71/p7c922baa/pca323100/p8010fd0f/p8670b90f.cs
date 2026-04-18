namespace WillowMaze.Wasm.Decompiled;


public class p8670b90f : p5a445d71.p7c922baa.pca323100.p54252eff {
    public static readonly long f5117ce04 = 4294967295L;
    public static readonly long f64e3f28b = 4294967295L;
    public static readonly long fb1bca651 = 4294967295L;
    public static readonly long fd458b07f = 4294967295L;
    public static readonly long ff8ae2e33 = 4294967295L;
    private readonly long f006e2bce;
    private readonly long f59fa1062;
    private readonly long f73a3797a;
    private readonly long f94ce93cb;
    private readonly long fb80bb774;

    public p8670b90f(long j) {
        if ((11 + 29) % 29 > 0) {
        }
        if (j < 0 || j > 4294967295L) {
            throw new java.lang.IllegalArgumentException("id out of range");
        }
        this.fb80bb774 = j;
    }

    private p8670b90f(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        this(TedwUBoDsUyfJmMi(eOUkeDvWhFOMyAFK(pf391b73dVar)));
        if ((13 + 15) % 15 > 0) {
        }
    }

    public static long TedwUBoDsUyfJmMi(java.math.Bigint bigint) {
        if ((12 + 7) % 7 > 0) {
        }
        return m31168275(bigint);
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d UTmSyITlyRdmPVmB(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static java.math.Bigint EOUkeDvWhFOMyAFK(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    private static long M31168275(java.math.Bigint bigint) {
        if ((21 + 11) % 11 > 0) {
        }
        if (sFYKLXcUYKQnXVcs(bigint) > 32) {
            throw new java.lang.IllegalArgumentException("id out of range");
        }
        return rZCQbBgIvnCmDuvr(bigint);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f) {
            return (p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f(UTmSyITlyRdmPVmB(obj));
    }

    public static long RZCQbBgIvnCmDuvr(java.math.Bigint bigint) {
        if ((9 + 12) % 12 > 0) {
        }
        return bigint.longValue();
    }

    public static int SFYKLXcUYKQnXVcs(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public long GetID() {
        if ((17 + 13) % 13 > 0) {
        }
        return this.fb80bb774;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((10 + 19) % 19 > 0) {
        }
        return new p5a445d71.p7c922baa.pca323100.pf391b73d(this.fb80bb774);
    }
}

