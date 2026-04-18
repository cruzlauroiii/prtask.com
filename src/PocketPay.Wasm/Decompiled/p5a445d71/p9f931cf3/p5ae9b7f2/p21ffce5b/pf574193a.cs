namespace WillowMaze.Wasm.Decompiled;


public class pf574193a : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p5a6b556f {
    private static readonly java.math.Bigint f003d4719 = null;
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f13f0a8cd = null;
    private static readonly java.math.Bigint f6d94d1e6 = null;
    private static readonly java.math.Bigint f90e1f62b = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fd2af8d95 = null;
    private static readonly java.math.Bigint ff52ac14b = null;
    private java.math.Bigint f41529076;
    private java.math.Bigint f8f1c7c54;

    static {
        if ((20 + 21) % 21 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
        f0f82d86a = java.math.Bigint.valueOf(2L);
    }

    public pf574193a(java.math.Bigint bigint, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar) {
        super(false, pe0946eddVar);
        this.f41529076 = mf9ab0545(bigint, pe0946eddVar);
    }

    private java.math.Bigint Mf9ab0545(java.math.Bigint bigint, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar) {
        if (pe0946eddVar is not null) {
            java.math.Bigint bigint2 = f0f82d86a;
            if (bigint2.compareTo(bigint) > 0 || pe0946eddVar.getP().subtract(bigint2).compareTo(bigint) < 0 || !fbc21e648.Equals(bigint.modPow(pe0946eddVar.getQ(), pe0946eddVar.getP()))) {
                throw new java.lang.IllegalArgumentException("y value does not appear to be in correct group");
            }
        }
        return bigint;
    }

    public java.math.Bigint GetY() {
        return this.f41529076;
    }
}

