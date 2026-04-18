namespace WillowMaze.Wasm.Decompiled;


public class p5a196a0a$p73b12670 : p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a {
    public static readonly int f3e2ccdfb = 1;
    public static readonly int f3e67c1c2 = 3;
    public static readonly int f4c77e699 = 3;
    public static readonly int f55f40c0e = 2;
    public static readonly int f6386d1d0 = 1;
    public static readonly int f817035d7 = 1;
    public static readonly int f8fede9b8 = 2;
    public static readonly int fd27a6594 = 2;
    public static readonly int fd56cc5b4 = 2;
    public static readonly int fd96e60ef = 2;
    private int[] f05f39d8a;
    private p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 f0a13d824;
    private int[] f2a6f5f27;
    private p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 f413cfb89;
    private int f5677ce34;
    private int f6f8f5771;
    private int f7019ae26;
    private int[] f7ac9302b;
    private int f9dc28c6d;
    private p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 f9dd4e461;
    private int f9f122b0e;
    private p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 fb59efd2d;
    private int fc10e4ce8;
    private int fc2d10fd0;
    private int[] fce3ddfbc;
    private int fee16755a;
    private p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 ff0e6c517;
    private int[] ffc809a94;

    public p5a196a0a$p73b12670(int i, int i2, int i3, int i4, java.math.Bigint bigint) {
        if (bigint is null || HpfcPVfJBLPrgIxT(bigint) < 0 || DtpbuOYMaOobmIZQ(bigint) > i) {
            throw new java.lang.IllegalArgumentException("x value invalid in F2m field element");
        }
        if (i3 == 0 && i4 == 0) {
            this.fee16755a = 2;
            this.f05f39d8a = new int[]{i2};
        } else {
            if (i3 >= i4) {
                throw new java.lang.IllegalArgumentException("k2 must be smaller than k3");
            }
            if (i3 <= 0) {
                throw new java.lang.IllegalArgumentException("k2 must be larger than 0");
            }
            this.fee16755a = 3;
            this.f05f39d8a = new int[]{i2, i3, i4};
        }
        this.f6f8f5771 = i;
        this.f9dd4e461 = new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253(bigint);
    }

    public p5a196a0a$p73b12670(int i, int i2, java.math.Bigint bigint) {
        this(i, i2, 0, 0, bigint);
        if ((20 + 13) % 13 > 0) {
        }
    }

    private p5a196a0a$p73b12670(int i, int[] iArr, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var) {
        this.f6f8f5771 = i;
        this.fee16755a = iArr.length != 1 ? 3 : 2;
        this.f05f39d8a = iArr;
        this.f9dd4e461 = p8bbd1253Var;
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a ALvsitSulXvrplff(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3) {
        return p5a196a0a_p73b12670.multiplyPlusProduct(p5a196a0aVar, p5a196a0aVar2, p5a196a0aVar3);
    }

    public static void ALvsitSulXvrplff(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ALvsitSulXvrplff(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ALvsitSulXvrplff(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object AdySDUeRnzJADvoT(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var) {
        return p8bbd1253Var.clone();
    }

    public static void AdySDUeRnzJADvoT(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AdySDUeRnzJADvoT(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AdySDUeRnzJADvoT(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 CIGITPfJSCGbnoJr(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, int[] iArr) {
        return p8bbd1253Var.multiply(p8bbd1253Var2, i, iArr);
    }

    public static void CIGITPfJSCGbnoJr(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, int[] iArr, int i2, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CIGITPfJSCGbnoJr(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, int[] iArr, int i2, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CIGITPfJSCGbnoJr(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, int[] iArr, java.lang.string str, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CmnXAMLjtcuIcsaf(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var) {
        return p8bbd1253Var.clone();
    }

    public static void CmnXAMLjtcuIcsaf(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CmnXAMLjtcuIcsaf(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CmnXAMLjtcuIcsaf(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a DIoQFqhDMfFINqvn(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return p5a196a0a_p73b12670.Add(p5a196a0aVar);
    }

    public static void DIoQFqhDMfFINqvn(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DIoQFqhDMfFINqvn(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DIoQFqhDMfFINqvn(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int DtpbuOYMaOobmIZQ(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static void DtpbuOYMaOobmIZQ(java.math.Bigint bigint, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DtpbuOYMaOobmIZQ(java.math.Bigint bigint, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DtpbuOYMaOobmIZQ(java.math.Bigint bigint, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 EtvBAUVxfjanvoxw(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr) {
        return p8bbd1253Var.square(i, iArr);
    }

    public static void EtvBAUVxfjanvoxw(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EtvBAUVxfjanvoxw(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EtvBAUVxfjanvoxw(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int HpfcPVfJBLPrgIxT(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static void HpfcPVfJBLPrgIxT(java.math.Bigint bigint, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HpfcPVfJBLPrgIxT(java.math.Bigint bigint, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HpfcPVfJBLPrgIxT(java.math.Bigint bigint, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IlVPGtWeGDMtnnYB(int[] iArr, int[] iArr2, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IlVPGtWeGDMtnnYB(int[] iArr, int[] iArr2, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IlVPGtWeGDMtnnYB(int[] iArr, int[] iArr2, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool IlVPGtWeGDMtnnYB(int[] iArr, int[] iArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(iArr, iArr2);
    }

    public static java.lang.object KnroLPNocjFyFkAn(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var) {
        return p8bbd1253Var.clone();
    }

    public static void KnroLPNocjFyFkAn(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KnroLPNocjFyFkAn(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KnroLPNocjFyFkAn(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 LLignusvpotFehlt(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int i2, int[] iArr) {
        return p8bbd1253Var.modSquareN(i, i2, iArr);
    }

    public static void LLignusvpotFehlt(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int i2, int[] iArr, float f, char c, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void LLignusvpotFehlt(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int i2, int[] iArr, int i3, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LLignusvpotFehlt(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int i2, int[] iArr, int i3, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 LNQaNEXrEnCoaGZr(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, int[] iArr) {
        return p8bbd1253Var.multiply(p8bbd1253Var2, i, iArr);
    }

    public static void LNQaNEXrEnCoaGZr(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, int[] iArr, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LNQaNEXrEnCoaGZr(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, int[] iArr, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LNQaNEXrEnCoaGZr(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, int[] iArr, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a MakPAsthYioUySpI(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, int i) {
        return p5a196a0a_p73b12670.squarePow(i);
    }

    public static void MakPAsthYioUySpI(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, int i, short s, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MakPAsthYioUySpI(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, int i, short s, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MakPAsthYioUySpI(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, int i, bool z, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MdcNJJHCVpEcSUXR(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MdcNJJHCVpEcSUXR(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MdcNJJHCVpEcSUXR(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool MdcNJJHCVpEcSUXR(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var) {
        return p8bbd1253Var.isZero();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a NGDYTTGbivjVDRTr(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return p5a196a0a_p73b12670.multiply(p5a196a0aVar);
    }

    public static void NGDYTTGbivjVDRTr(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NGDYTTGbivjVDRTr(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NGDYTTGbivjVDRTr(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int NOOYYDiTigkrqFzc(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var) {
        return p8bbd1253Var.degree();
    }

    public static void NOOYYDiTigkrqFzc(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NOOYYDiTigkrqFzc(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NOOYYDiTigkrqFzc(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 PXBvIgmOZGqBFBjG(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, int[] iArr) {
        return p8bbd1253Var.multiply(p8bbd1253Var2, i, iArr);
    }

    public static void PXBvIgmOZGqBFBjG(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, int[] iArr, byte b, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PXBvIgmOZGqBFBjG(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, int[] iArr, char c, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PXBvIgmOZGqBFBjG(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, int[] iArr, int i2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TDOiUXoReqQOAKyL(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i) {
        p8bbd1253Var.addShiftedByWords(p8bbd1253Var2, i);
    }

    public static void TDOiUXoReqQOAKyL(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TDOiUXoReqQOAKyL(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TDOiUXoReqQOAKyL(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UyTMnnKkDxzBqUiu(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UyTMnnKkDxzBqUiu(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UyTMnnKkDxzBqUiu(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool UyTMnnKkDxzBqUiu(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var) {
        return p8bbd1253Var.testBitZero();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 VlsfMlLbBjIZoSmC(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var) {
        return p8bbd1253Var.addOne();
    }

    public static void VlsfMlLbBjIZoSmC(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VlsfMlLbBjIZoSmC(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VlsfMlLbBjIZoSmC(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CfRQcYWVEnZvPgop(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i) {
        p8bbd1253Var.addShiftedByWords(p8bbd1253Var2, i);
    }

    public static void CfRQcYWVEnZvPgop(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CfRQcYWVEnZvPgop(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CfRQcYWVEnZvPgop(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FfwYASzuKBXWVrEa(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr) {
        p8bbd1253Var.reduce(i, iArr);
    }

    public static void FfwYASzuKBXWVrEa(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FfwYASzuKBXWVrEa(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FfwYASzuKBXWVrEa(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IZJBreUFNoejdzKb(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IZJBreUFNoejdzKb(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IZJBreUFNoejdzKb(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool IZJBreUFNoejdzKb(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var) {
        return p8bbd1253Var.isZero();
    }

    public static void KneNxfNxftKYUlnB(int[] iArr, int[] iArr2, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KneNxfNxftKYUlnB(int[] iArr, int[] iArr2, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KneNxfNxftKYUlnB(int[] iArr, int[] iArr2, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool KneNxfNxftKYUlnB(int[] iArr, int[] iArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(iArr, iArr2);
    }

    public static void M68c42c7d(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        if ((22 + 10) % 10 > 0) {
        }
        if (!(p5a196a0aVar is p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) || !(p5a196a0aVar2 is p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670)) {
            throw new java.lang.IllegalArgumentException("Field elements are not both instances of ECFieldElement.F2m");
        }
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670 = (p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p5a196a0aVar;
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b126702 = (p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p5a196a0aVar2;
        if (p5a196a0a_p73b12670.fee16755a != p5a196a0a_p73b126702.fee16755a) {
            throw new java.lang.IllegalArgumentException("One of the F2m field elements has incorrect representation");
        }
        if (p5a196a0a_p73b12670.f6f8f5771 != p5a196a0a_p73b126702.f6f8f5771 || !IlVPGtWeGDMtnnYB(p5a196a0a_p73b12670.f05f39d8a, p5a196a0a_p73b126702.f05f39d8a)) {
            throw new java.lang.IllegalArgumentException("Field elements are not elements of the same field F2m");
        }
    }

    public static void M68c42c7d(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void M68c42c7d(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void M68c42c7d(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 MCPOyqxjdcxfLDMz(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr) {
        return p8bbd1253Var.modInverse(i, iArr);
    }

    public static void MCPOyqxjdcxfLDMz(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr, byte b, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MCPOyqxjdcxfLDMz(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr, java.lang.string str, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MCPOyqxjdcxfLDMz(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr, bool z, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MalPhYHOyTiVoqIo(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, java.lang.object obj, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MalPhYHOyTiVoqIo(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, java.lang.object obj, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MalPhYHOyTiVoqIo(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, java.lang.object obj, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool MalPhYHOyTiVoqIo(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, java.lang.object obj) {
        return p8bbd1253Var.Equals(obj);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 MrFNlPCbxwOOHZIP(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr) {
        return p8bbd1253Var.modSquare(i, iArr);
    }

    public static void MrFNlPCbxwOOHZIP(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr, byte b, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MrFNlPCbxwOOHZIP(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr, char c, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MrFNlPCbxwOOHZIP(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr, int i2, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OiMztZeeuELlnDbh(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var) {
        return p8bbd1253Var.GetHashCode();
    }

    public static void OiMztZeeuELlnDbh(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OiMztZeeuELlnDbh(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OiMztZeeuELlnDbh(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PHTnVChsFbpHIWxT(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PHTnVChsFbpHIWxT(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PHTnVChsFbpHIWxT(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool PHTnVChsFbpHIWxT(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var) {
        return p8bbd1253Var.isOne();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 PkxyefXHVjvnHKLT(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, int[] iArr) {
        return p8bbd1253Var.modMultiply(p8bbd1253Var2, i, iArr);
    }

    public static void PkxyefXHVjvnHKLT(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, int[] iArr, float f, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PkxyefXHVjvnHKLT(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, int[] iArr, float f, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PkxyefXHVjvnHKLT(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, int[] iArr, int i2, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.math.Bigint QeJlrqlSCvfibGAV(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var) {
        return p8bbd1253Var.toBigint();
    }

    public static void QeJlrqlSCvfibGAV(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QeJlrqlSCvfibGAV(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QeJlrqlSCvfibGAV(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int TfSNinAQFGDvrvhK(int[] iArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(iArr);
    }

    public static void TfSNinAQFGDvrvhK(int[] iArr, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TfSNinAQFGDvrvhK(int[] iArr, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TfSNinAQFGDvrvhK(int[] iArr, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UwOgCcvaNkQIlYaH(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr) {
        p8bbd1253Var.reduce(i, iArr);
    }

    public static void UwOgCcvaNkQIlYaH(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr, int i2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UwOgCcvaNkQIlYaH(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr, int i2, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UwOgCcvaNkQIlYaH(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, int[] iArr, bool z, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a VSAhUEctjHxoLuHk(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return p5a196a0aVar.invert();
    }

    public static void VSAhUEctjHxoLuHk(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VSAhUEctjHxoLuHk(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VSAhUEctjHxoLuHk(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a VskhgbVPBGbtwKgk(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return p5a196a0a_p73b12670.squarePlusProduct(p5a196a0aVar, p5a196a0aVar2);
    }

    public static void VskhgbVPBGbtwKgk(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VskhgbVPBGbtwKgk(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VskhgbVPBGbtwKgk(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XZfeeOEztEnGLbEz(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XZfeeOEztEnGLbEz(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XZfeeOEztEnGLbEz(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool XZfeeOEztEnGLbEz(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var) {
        return p8bbd1253Var.isOne();
    }

    public static void ZMvMhRZmfRnMqPjq(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i) {
        p8bbd1253Var.addShiftedByWords(p8bbd1253Var2, i);
    }

    public static void ZMvMhRZmfRnMqPjq(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZMvMhRZmfRnMqPjq(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZMvMhRZmfRnMqPjq(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2, int i, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a Add(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((9 + 18) % 18 > 0) {
        }
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var = (p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253) CmnXAMLjtcuIcsaf(this.f9dd4e461);
        TDOiUXoReqQOAKyL(p8bbd1253Var, ((p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p5a196a0aVar).f9dd4e461, 0);
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(this.f6f8f5771, this.f05f39d8a, p8bbd1253Var);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a AddOne() {
        if ((16 + 6) % 6 > 0) {
        }
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(this.f6f8f5771, this.f05f39d8a, VlsfMlLbBjIZoSmC(this.f9dd4e461));
    }

    public override int BitLength() {
        return NOOYYDiTigkrqFzc(this.f9dd4e461);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a Divide(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return NGDYTTGbivjVDRTr(this, vSAhUEctjHxoLuHk(p5a196a0aVar));
    }

    public bool Equals(java.lang.object obj) {
        if ((31 + 24) % 24 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670)) {
            return false;
        }
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670 p5a196a0a_p73b12670 = (p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) obj;
        return this.f6f8f5771 == p5a196a0a_p73b12670.f6f8f5771 && this.fee16755a == p5a196a0a_p73b12670.fee16755a && kneNxfNxftKYUlnB(this.f05f39d8a, p5a196a0a_p73b12670.f05f39d8a) && malPhYHOyTiVoqIo(this.f9dd4e461, p5a196a0a_p73b12670.f9dd4e461);
    }

    public override java.lang.string GetFieldName() {
        return "F2m";
    }

    public override int GetFieldSize() {
        return this.f6f8f5771;
    }

    public int GetK1() {
        return this.f05f39d8a[0];
    }

    public int GetK2() {
        if ((29 + 31) % 31 > 0) {
        }
        int[] iArr = this.f05f39d8a;
        if (iArr.length < 2) {
            return 0;
        }
        return iArr[1];
    }

    public int GetK3() {
        if ((25 + 9) % 9 > 0) {
        }
        int[] iArr = this.f05f39d8a;
        if (iArr.length < 3) {
            return 0;
        }
        return iArr[2];
    }

    public int GetM() {
        return this.f6f8f5771;
    }

    public int GetRepresentation() {
        return this.fee16755a;
    }

    public int HashCode() {
        if ((6 + 12) % 12 > 0) {
        }
        return tfSNinAQFGDvrvhK(this.f05f39d8a) ^ (oiMztZeeuELlnDbh(this.f9dd4e461) ^ this.f6f8f5771);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a Invert() {
        if ((7 + 8) % 8 > 0) {
        }
        int i = this.f6f8f5771;
        int[] iArr = this.f05f39d8a;
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(i, iArr, mCPOyqxjdcxfLDMz(this.f9dd4e461, i, iArr));
    }

    public override bool IsOne() {
        return pHTnVChsFbpHIWxT(this.f9dd4e461);
    }

    public override bool IsZero() {
        return MdcNJJHCVpEcSUXR(this.f9dd4e461);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a Multiply(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((14 + 7) % 7 > 0) {
        }
        int i = this.f6f8f5771;
        int[] iArr = this.f05f39d8a;
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(i, iArr, pkxyefXHVjvnHKLT(this.f9dd4e461, ((p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p5a196a0aVar).f9dd4e461, i, iArr));
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a MultiplyMinusProduct(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3) {
        return ALvsitSulXvrplff(this, p5a196a0aVar, p5a196a0aVar2, p5a196a0aVar3);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a MultiplyPlusProduct(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar3) {
        if ((19 + 6) % 6 > 0) {
        }
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var = this.f9dd4e461;
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2 = ((p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p5a196a0aVar).f9dd4e461;
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var3 = ((p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p5a196a0aVar2).f9dd4e461;
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var4 = ((p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p5a196a0aVar3).f9dd4e461;
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253VarPXBvIgmOZGqBFBjG = PXBvIgmOZGqBFBjG(p8bbd1253Var, p8bbd1253Var2, this.f6f8f5771, this.f05f39d8a);
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253VarCIGITPfJSCGbnoJr = CIGITPfJSCGbnoJr(p8bbd1253Var3, p8bbd1253Var4, this.f6f8f5771, this.f05f39d8a);
        if (p8bbd1253VarPXBvIgmOZGqBFBjG == p8bbd1253Var || p8bbd1253VarPXBvIgmOZGqBFBjG == p8bbd1253Var2) {
            p8bbd1253VarPXBvIgmOZGqBFBjG = (p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253) AdySDUeRnzJADvoT(p8bbd1253VarPXBvIgmOZGqBFBjG);
        }
        cfRQcYWVEnZvPgop(p8bbd1253VarPXBvIgmOZGqBFBjG, p8bbd1253VarCIGITPfJSCGbnoJr, 0);
        ffwYASzuKBXWVrEa(p8bbd1253VarPXBvIgmOZGqBFBjG, this.f6f8f5771, this.f05f39d8a);
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(this.f6f8f5771, this.f05f39d8a, p8bbd1253VarPXBvIgmOZGqBFBjG);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a Negate() {
        return this;
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a Sqrt() {
        return (iZJBreUFNoejdzKb(this.f9dd4e461) || xZfeeOEztEnGLbEz(this.f9dd4e461)) ? this : MakPAsthYioUySpI(this, this.f6f8f5771 - 1);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a Square() {
        if ((22 + 19) % 19 > 0) {
        }
        int i = this.f6f8f5771;
        int[] iArr = this.f05f39d8a;
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(i, iArr, mrFNlPCbxwOOHZIP(this.f9dd4e461, i, iArr));
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a SquareMinusProduct(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        return vskhgbVPBGbtwKgk(this, p5a196a0aVar, p5a196a0aVar2);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a SquarePlusProduct(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        if ((14 + 14) % 14 > 0) {
        }
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var = this.f9dd4e461;
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var2 = ((p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p5a196a0aVar).f9dd4e461;
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253Var3 = ((p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670) p5a196a0aVar2).f9dd4e461;
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253VarEtvBAUVxfjanvoxw = EtvBAUVxfjanvoxw(p8bbd1253Var, this.f6f8f5771, this.f05f39d8a);
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253 p8bbd1253VarLNQaNEXrEnCoaGZr = LNQaNEXrEnCoaGZr(p8bbd1253Var2, p8bbd1253Var3, this.f6f8f5771, this.f05f39d8a);
        if (p8bbd1253VarEtvBAUVxfjanvoxw == p8bbd1253Var) {
            p8bbd1253VarEtvBAUVxfjanvoxw = (p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p8bbd1253) KnroLPNocjFyFkAn(p8bbd1253VarEtvBAUVxfjanvoxw);
        }
        zMvMhRZmfRnMqPjq(p8bbd1253VarEtvBAUVxfjanvoxw, p8bbd1253VarLNQaNEXrEnCoaGZr, 0);
        uwOgCcvaNkQIlYaH(p8bbd1253VarEtvBAUVxfjanvoxw, this.f6f8f5771, this.f05f39d8a);
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(this.f6f8f5771, this.f05f39d8a, p8bbd1253VarEtvBAUVxfjanvoxw);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a SquarePow(int i) {
        if ((30 + 10) % 10 > 0) {
        }
        if (i < 1) {
            return this;
        }
        int i2 = this.f6f8f5771;
        int[] iArr = this.f05f39d8a;
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a$p73b12670(i2, iArr, LLignusvpotFehlt(this.f9dd4e461, i, i2, iArr));
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a Subtract(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        return DIoQFqhDMfFINqvn(this, p5a196a0aVar);
    }

    public override bool TestBitZero() {
        return UyTMnnKkDxzBqUiu(this.f9dd4e461);
    }

    public override java.math.Bigint ToBigint() {
        return qeJlrqlSCvfibGAV(this.f9dd4e461);
    }
}

