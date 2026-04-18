namespace WillowMaze.Wasm.Decompiled;


public class pcc112f44 {
    private readonly java.math.Bigint f344aa45c;
    private readonly java.math.Bigint f40203bed;
    private readonly java.math.Bigint f7694f4a6;
    private readonly java.math.Bigint f83878c91;
    private readonly java.math.Bigint fb2f5ff47;
    private readonly java.math.Bigint fbce99a47;
    private readonly java.math.Bigint fbeed5104;
    private readonly java.math.Bigint fc836bfe8;
    private readonly java.math.Bigint fcbeb3b42;
    private readonly java.math.Bigint ff28db884;
    private readonly java.math.Bigint ff2c545d1;

    public pcc112f44(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        this(bigint, bigint2, bigint3, false);
    }

    pcc112f44(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, bool z) {
        if ((6 + 16) % 16 > 0) {
        }
        WYmkntvzUQFcuGno(bigint, "p");
        iQFiQiRmGIMGefnG(bigint2, "q");
        LIMURCXQGWMhEOiu(bigint3, "g");
        if (!z) {
            if (!RGajkuJqxYefzBIX(IBABRaxCSPoFmkWS(LkMuBrpvxzAxpisU(bigint, p5a445d71.p7c922baa.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.fbc21e648), bigint2), p5a445d71.p7c922baa.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.f529e9e0b)) {
                throw new java.lang.IllegalArgumentException("p-1 must be evenly divisible by q");
            }
            if (xLnqXDKjVheOHCcF(bigint3, bfOSSQlxPgvERvQA(2L)) == -1 || GqvIkRzEbyAnongk(bigint3, aJmmKhhIAkzIrTJH(bigint, p5a445d71.p7c922baa.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.fbc21e648)) == 1) {
                throw new java.lang.IllegalArgumentException("g must be in [2, p-1]");
            }
            if (!dXdoCRzZvbANajcw(xzZzTYVorgxYhpbj(bigint3, bigint2, bigint), p5a445d71.p7c922baa.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.fbc21e648)) {
                throw new java.lang.IllegalArgumentException("g^q mod p must equal 1");
            }
            if (!xcmHlwXdmmLuLInr(bigint, 20)) {
                throw new java.lang.IllegalArgumentException("p must be prime");
            }
            if (!PnivviSolRyJPnBV(bigint2, 20)) {
                throw new java.lang.IllegalArgumentException("q must be prime");
            }
        }
        this.f83878c91 = bigint;
        this.f7694f4a6 = bigint2;
        this.fb2f5ff47 = bigint3;
    }

    public static int GqvIkRzEbyAnongk(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.compareTo(bigint2);
    }

    public static void GqvIkRzEbyAnongk(java.math.Bigint bigint, java.math.Bigint bigint2, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GqvIkRzEbyAnongk(java.math.Bigint bigint, java.math.Bigint bigint2, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GqvIkRzEbyAnongk(java.math.Bigint bigint, java.math.Bigint bigint2, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint IBABRaxCSPoFmkWS(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.mod(bigint2);
    }

    public static void IBABRaxCSPoFmkWS(java.math.Bigint bigint, java.math.Bigint bigint2, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IBABRaxCSPoFmkWS(java.math.Bigint bigint, java.math.Bigint bigint2, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IBABRaxCSPoFmkWS(java.math.Bigint bigint, java.math.Bigint bigint2, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LIMURCXQGWMhEOiu(java.lang.object obj, java.lang.string str) {
        p5a445d71.p7c922baa.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.m44e711df(obj, str);
    }

    public static void LIMURCXQGWMhEOiu(java.lang.object obj, java.lang.string str, int i, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LIMURCXQGWMhEOiu(java.lang.object obj, java.lang.string str, int i, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LIMURCXQGWMhEOiu(java.lang.object obj, java.lang.string str, java.lang.string str2, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint LkMuBrpvxzAxpisU(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.subtract(bigint2);
    }

    public static void LkMuBrpvxzAxpisU(java.math.Bigint bigint, java.math.Bigint bigint2, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LkMuBrpvxzAxpisU(java.math.Bigint bigint, java.math.Bigint bigint2, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LkMuBrpvxzAxpisU(java.math.Bigint bigint, java.math.Bigint bigint2, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PnivviSolRyJPnBV(java.math.Bigint bigint, int i, float f, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PnivviSolRyJPnBV(java.math.Bigint bigint, int i, float f, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PnivviSolRyJPnBV(java.math.Bigint bigint, int i, int i2, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool PnivviSolRyJPnBV(java.math.Bigint bigint, int i) {
        return bigint.isProbablePrime(i);
    }

    public static void RGajkuJqxYefzBIX(java.math.Bigint bigint, java.lang.object obj, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RGajkuJqxYefzBIX(java.math.Bigint bigint, java.lang.object obj, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RGajkuJqxYefzBIX(java.math.Bigint bigint, java.lang.object obj, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool RGajkuJqxYefzBIX(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static void WYmkntvzUQFcuGno(java.lang.object obj, java.lang.string str) {
        p5a445d71.p7c922baa.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.m44e711df(obj, str);
    }

    public static void WYmkntvzUQFcuGno(java.lang.object obj, java.lang.string str, byte b, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WYmkntvzUQFcuGno(java.lang.object obj, java.lang.string str, java.lang.string str2, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WYmkntvzUQFcuGno(java.lang.object obj, java.lang.string str, java.lang.string str2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint AJmmKhhIAkzIrTJH(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.subtract(bigint2);
    }

    public static void AJmmKhhIAkzIrTJH(java.math.Bigint bigint, java.math.Bigint bigint2, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AJmmKhhIAkzIrTJH(java.math.Bigint bigint, java.math.Bigint bigint2, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AJmmKhhIAkzIrTJH(java.math.Bigint bigint, java.math.Bigint bigint2, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint BfOSSQlxPgvERvQA(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static void BfOSSQlxPgvERvQA(long j, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BfOSSQlxPgvERvQA(long j, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BfOSSQlxPgvERvQA(long j, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DXdoCRzZvbANajcw(java.math.Bigint bigint, java.lang.object obj, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DXdoCRzZvbANajcw(java.math.Bigint bigint, java.lang.object obj, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DXdoCRzZvbANajcw(java.math.Bigint bigint, java.lang.object obj, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool DXdoCRzZvbANajcw(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static void IQFiQiRmGIMGefnG(java.lang.object obj, java.lang.string str) {
        p5a445d71.p7c922baa.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.m44e711df(obj, str);
    }

    public static void IQFiQiRmGIMGefnG(java.lang.object obj, java.lang.string str, byte b, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IQFiQiRmGIMGefnG(java.lang.object obj, java.lang.string str, float f, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void IQFiQiRmGIMGefnG(java.lang.object obj, java.lang.string str, java.lang.string str2, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int XLnqXDKjVheOHCcF(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.compareTo(bigint2);
    }

    public static void XLnqXDKjVheOHCcF(java.math.Bigint bigint, java.math.Bigint bigint2, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XLnqXDKjVheOHCcF(java.math.Bigint bigint, java.math.Bigint bigint2, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XLnqXDKjVheOHCcF(java.math.Bigint bigint, java.math.Bigint bigint2, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XcmHlwXdmmLuLInr(java.math.Bigint bigint, int i, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XcmHlwXdmmLuLInr(java.math.Bigint bigint, int i, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XcmHlwXdmmLuLInr(java.math.Bigint bigint, int i, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XcmHlwXdmmLuLInr(java.math.Bigint bigint, int i) {
        return bigint.isProbablePrime(i);
    }

    public static java.math.Bigint XzZzTYVorgxYhpbj(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return bigint.modPow(bigint2, bigint3);
    }

    public static void XzZzTYVorgxYhpbj(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XzZzTYVorgxYhpbj(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XzZzTYVorgxYhpbj(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public java.math.Bigint GetG() {
        return this.fb2f5ff47;
    }

    public java.math.Bigint GetP() {
        return this.f83878c91;
    }

    public java.math.Bigint GetQ() {
        return this.f7694f4a6;
    }
}

