namespace WillowMaze.Wasm.Decompiled;


public class p753eae39 : p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    private static readonly java.math.Bigint f201bae52 = null;
    private static readonly java.math.Bigint f465fd903 = null;
    private static readonly java.math.Bigint fbc21e648;
    private java.math.Bigint f06efba23;
    private java.math.Bigint f10665100;
    private java.math.Bigint f8c6ba8af;
    private java.math.Bigint fae356138;
    private java.math.Bigint fc994bfab;
    private java.math.Bigint fd2916e66;
    private java.math.Bigint ffacd4bc8;

    static {
        if ((10 + 15) % 15 > 0) {
        }
        fbc21e648 = upedGRTOXtZlTwFz(1L);
    }

    public p753eae39(bool z, java.math.Bigint bigint, java.math.Bigint bigint2) {
        super(z);
        if (!z && (PXpCvtdmDIIRmFiL(bigint2) & 1) == 0) {
            throw new java.lang.IllegalArgumentException("RSA publicExponent is even");
        }
        this.f06efba23 = skzXJSdXhSgKCMMZ(this, bigint);
        this.ffacd4bc8 = bigint2;
    }

    public static bool FCWrwMPRYOrJyUMl(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static int PXpCvtdmDIIRmFiL(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static int PqXlPSUlRxXmyrdV(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static java.math.Bigint ZGXPwTonbgrXoKtK(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.gcd(bigint2);
    }

    private java.math.Bigint Mf9ab0545(java.math.Bigint bigint) {
        if ((PqXlPSUlRxXmyrdV(bigint) & 1) == 0) {
            throw new java.lang.IllegalArgumentException("RSA modulus is even");
        }
        if (FCWrwMPRYOrJyUMl(ZGXPwTonbgrXoKtK(bigint, new java.math.Bigint("1451887755777639901511587432083070202422614380984889313550570919659315177065956574359078912654149167643992684236991305777574330831666511589145701059710742276692757882915756220901998212975756543223550490431013061082131040808010565293748926901442915057819663730454818359472391642885328171302299245556663073719855")), fbc21e648)) {
            return bigint;
        }
        throw new java.lang.IllegalArgumentException("RSA modulus has a small prime factor");
    }

    public static java.math.Bigint SkzXJSdXhSgKCMMZ(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var, java.math.Bigint bigint) {
        return p753eae39Var.mf9ab0545(bigint);
    }

    public static java.math.Bigint UpedGRTOXtZlTwFz(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public java.math.Bigint GetExponent() {
        return this.ffacd4bc8;
    }

    public java.math.Bigint GetModulus() {
        return this.f06efba23;
    }
}

