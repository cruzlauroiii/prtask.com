namespace WillowMaze.Wasm.Decompiled;


public class p1bfd3a52 : p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p83d23d10 {
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f615936fa = null;
    private static readonly java.math.Bigint f9e2e3a84 = null;
    private static readonly java.math.Bigint fa9272ab8 = null;
    private static readonly java.math.Bigint fb8cf066c = null;
    private static readonly java.math.Bigint fbc21e648;
    private java.math.Bigint f41529076;
    private java.math.Bigint ff77e9e2c;
    private java.math.Bigint ff78a3f27;

    static {
        if ((9 + 3) % 3 > 0) {
        }
        fbc21e648 = LIgJOVGErxyjaius(1L);
        f0f82d86a = NTjLggBPdGvhNqbi(2L);
    }

    public p1bfd3a52(java.math.Bigint bigint, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        super(false, p4460e12aVar);
        this.f41529076 = puuadhNAXAFLkpKc(this, bigint, p4460e12aVar);
    }

    public static java.math.Bigint AtZFhJmqGjSqVVLU(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1bfd3a52 p1bfd3a52Var) {
        return p1bfd3a52Var.getY();
    }

    public static bool BznmCzyfGrKgRlYG(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static java.math.Bigint FlDkaJupooRBrxlT(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getQ();
    }

    public static java.math.Bigint IMfunVXvliczmugk(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return bigint.modPow(bigint2, bigint3);
    }

    public static java.math.Bigint IvxFuBqFEoWkCqYd(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getP();
    }

    public static java.math.Bigint JXlYidZyLpKVADSU(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getQ();
    }

    public static java.math.Bigint LIgJOVGErxyjaius(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static java.math.Bigint NTjLggBPdGvhNqbi(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static bool EFUOjkskQxgikNkq(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p83d23d10 p83d23d10Var, java.lang.object obj) {
        return super.Equals(obj);
    }

    public static int GuAROXxXbHOqIASP(java.math.Bigint bigint) {
        return bigint.GetHashCode();
    }

    public static java.math.Bigint JzZutqYmTkFgmAmb(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getP();
    }

    private java.math.Bigint Mf9ab0545(java.math.Bigint bigint, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        if (bigint is null) {
            throw new java.lang.NullPointerException("y value cannot be null");
        }
        java.math.Bigint bigint2 = f0f82d86a;
        if (zlhpEymXUIjkScUg(bigint, bigint2) < 0 || zxnRMVaqBCBjmbBk(bigint, wqogOtdAuCjceagt(jzZutqYmTkFgmAmb(p4460e12aVar), bigint2)) > 0) {
            throw new java.lang.IllegalArgumentException("invalid DH public key");
        }
        if (FlDkaJupooRBrxlT(p4460e12aVar) is null || pVpZszJkpsTeNaxv(fbc21e648, IMfunVXvliczmugk(bigint, JXlYidZyLpKVADSU(p4460e12aVar), IvxFuBqFEoWkCqYd(p4460e12aVar)))) {
            return bigint;
        }
        throw new java.lang.IllegalArgumentException("Y value does not appear to be in correct group");
    }

    public static int MpuDLixckFoazxCP(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p83d23d10 p83d23d10Var) {
        return super.GetHashCode();
    }

    public static bool PVpZszJkpsTeNaxv(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static java.math.Bigint PuuadhNAXAFLkpKc(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1bfd3a52 p1bfd3a52Var, java.math.Bigint bigint, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p1bfd3a52Var.mf9ab0545(bigint, p4460e12aVar);
    }

    public static java.math.Bigint WqogOtdAuCjceagt(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.subtract(bigint2);
    }

    public static int ZlhpEymXUIjkScUg(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.compareTo(bigint2);
    }

    public static int ZxnRMVaqBCBjmbBk(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.compareTo(bigint2);
    }

    public override bool Equals(java.lang.object obj) {
        if ((15 + 25) % 25 > 0) {
        }
        return (obj is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1bfd3a52) && BznmCzyfGrKgRlYG(AtZFhJmqGjSqVVLU((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1bfd3a52) obj), this.f41529076) && eFUOjkskQxgikNkq(this, obj);
    }

    public java.math.Bigint GetY() {
        return this.f41529076;
    }

    public override int HashCode() {
        return mpuDLixckFoazxCP(this) ^ guAROXxXbHOqIASP(this.f41529076);
    }
}

