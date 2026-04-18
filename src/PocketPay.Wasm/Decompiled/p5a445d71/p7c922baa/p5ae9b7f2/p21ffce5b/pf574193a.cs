namespace WillowMaze.Wasm.Decompiled;


public class pf574193a : p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p5a6b556f {
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f1b04a66d = null;
    private static readonly java.math.Bigint f4f1ea604 = null;
    private static readonly java.math.Bigint f52819c53 = null;
    private static readonly java.math.Bigint f8919adcf = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint ffa63182d = null;
    private java.math.Bigint f2074ae30;
    private java.math.Bigint f2cb26514;
    private java.math.Bigint f41529076;

    static {
        if ((7 + 1) % 1 > 0) {
        }
        fbc21e648 = YZMaNLqzziaQpyyN(1L);
        f0f82d86a = GVveFVTkkJmiRJKz(2L);
    }

    public pf574193a(java.math.Bigint bigint, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar) {
        super(false, pe0946eddVar);
        this.f41529076 = ydIIhEPvhkKIbRrc(this, bigint, pe0946eddVar);
    }

    public static java.math.Bigint GVveFVTkkJmiRJKz(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static java.math.Bigint MZNCubKjnLLLqdku(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar) {
        return pe0946eddVar.getP();
    }

    public static java.math.Bigint RShAjvjsmTyaMxeO(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar) {
        return pe0946eddVar.getQ();
    }

    public static bool VjtyoZeXpzzHcXZX(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static int WRGZtNPGRqLgVGkU(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.compareTo(bigint2);
    }

    public static java.math.Bigint YZMaNLqzziaQpyyN(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static int BopoiplNLKsUdrIV(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.compareTo(bigint2);
    }

    public static java.math.Bigint JzuIqIYnenIInKnT(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return bigint.modPow(bigint2, bigint3);
    }

    private java.math.Bigint Mf9ab0545(java.math.Bigint bigint, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar) {
        if (pe0946eddVar is not null) {
            java.math.Bigint bigint2 = f0f82d86a;
            if (WRGZtNPGRqLgVGkU(bigint2, bigint) > 0 || bopoiplNLKsUdrIV(xxycwfDAJTKRBxTk(yvGZTqTwclKVyGWi(pe0946eddVar), bigint2), bigint) < 0 || !VjtyoZeXpzzHcXZX(fbc21e648, jzuIqIYnenIInKnT(bigint, RShAjvjsmTyaMxeO(pe0946eddVar), MZNCubKjnLLLqdku(pe0946eddVar)))) {
                throw new java.lang.IllegalArgumentException("y value does not appear to be in correct group");
            }
        }
        return bigint;
    }

    public static java.math.Bigint XxycwfDAJTKRBxTk(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.subtract(bigint2);
    }

    public static java.math.Bigint YdIIhEPvhkKIbRrc(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf574193a pf574193aVar, java.math.Bigint bigint, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar) {
        return pf574193aVar.mf9ab0545(bigint, pe0946eddVar);
    }

    public static java.math.Bigint YvGZTqTwclKVyGWi(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar) {
        return pe0946eddVar.getP();
    }

    public java.math.Bigint GetY() {
        return this.f41529076;
    }
}

