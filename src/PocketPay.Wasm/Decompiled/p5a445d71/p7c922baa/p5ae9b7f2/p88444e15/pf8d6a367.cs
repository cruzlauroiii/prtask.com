namespace WillowMaze.Wasm.Decompiled;


public class pf8d6a367 : p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf87e7128 {
    private long f15660581;
    private long f1b44ec5d;
    private long f1d62d03d;
    private long f1de54859;
    private long f207ed6f9;
    private long f20b00a3c;
    private long f27d1dde0;
    private long f31d379d7;
    private long f3a6c868c;
    private long f46a10b8f;
    private long f5422c8e9;
    private long f591eb652;
    private int f60c53b4c;
    private long f72f0fc79;
    private long f732b52ea;
    private long f7f37398b;
    private long f7f946043;
    private long f8ecd30c9;
    private long f95e063c3;
    private long fa33546fd;
    private long faa7e5008;
    private int fb1eb93af;
    private long fb36793d6;
    private long fc2d9fe28;
    private long fca4275e2;
    private int fcb5c1553;
    private long fe5f6f18c;
    private long fef8d195a;
    private long ff35e8886;
    private long ff73e63aa;

    public pf8d6a367(int i) {
        if (i >= 512) {
            throw new java.lang.IllegalArgumentException("bitLength cannot be >= 512");
        }
        if (i % 8 != 0) {
            throw new java.lang.IllegalArgumentException("bitLength needs to be a multiple of 8");
        }
        if (i == 384) {
            throw new java.lang.IllegalArgumentException("bitLength cannot be 384 use SHA384 instead");
        }
        int i2 = i / 8;
        this.f60c53b4c = i2;
        keYzIFCSlmHCaDeG(this, i2 * 8);
        VzLErvPZnRDoDGWx(this);
    }

    public pf8d6a367(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var) {
        super(pf8d6a367Var);
        this.f60c53b4c = pf8d6a367Var.f60c53b4c;
        RAKEZQwvaMEnMvTI(this, pf8d6a367Var);
    }

    public pf8d6a367(byte[] bArr) {
        this(MVVifBKEAEBrJqvn(bArr));
        XHRqcMLawtsBiGGO(this, bArr);
    }

    public static void EaMlsfLDKBDvlWaj(long j, byte[] bArr, int i, int i2) {
        m38b01934(j, bArr, i, i2);
    }

    public static void EaMlsfLDKBDvlWaj(long j, byte[] bArr, int i, int i2, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EaMlsfLDKBDvlWaj(long j, byte[] bArr, int i, int i2, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EaMlsfLDKBDvlWaj(long j, byte[] bArr, int i, int i2, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EiKNBlQjgxnrnZso(long j, byte[] bArr, int i, int i2) {
        m38b01934(j, bArr, i, i2);
    }

    public static void EiKNBlQjgxnrnZso(long j, byte[] bArr, int i, int i2, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EiKNBlQjgxnrnZso(long j, byte[] bArr, int i, int i2, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EiKNBlQjgxnrnZso(long j, byte[] bArr, int i, int i2, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FZjVlWeBFSEHVHcw(long j, byte[] bArr, int i, int i2) {
        m38b01934(j, bArr, i, i2);
    }

    public static void FZjVlWeBFSEHVHcw(long j, byte[] bArr, int i, int i2, int i3, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FZjVlWeBFSEHVHcw(long j, byte[] bArr, int i, int i2, int i3, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FZjVlWeBFSEHVHcw(long j, byte[] bArr, int i, int i2, short s, java.lang.string str, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FueGAedcKEQOOYLN(long j, byte[] bArr, int i, int i2) {
        m38b01934(j, bArr, i, i2);
    }

    public static void FueGAedcKEQOOYLN(long j, byte[] bArr, int i, int i2, byte b, int i3, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FueGAedcKEQOOYLN(long j, byte[] bArr, int i, int i2, short s, int i3, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FueGAedcKEQOOYLN(long j, byte[] bArr, int i, int i2, short s, int i3, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IOTEudHIxDvvjIiH(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b) {
        pf8d6a367Var.update(b);
    }

    public static void IOTEudHIxDvvjIiH(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IOTEudHIxDvvjIiH(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IOTEudHIxDvvjIiH(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int MVVifBKEAEBrJqvn(byte[] bArr) {
        return mf4040b00(bArr);
    }

    public static void MVVifBKEAEBrJqvn(byte[] bArr, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MVVifBKEAEBrJqvn(byte[] bArr, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MVVifBKEAEBrJqvn(byte[] bArr, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OdAyyiCaeIXhLTYZ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b) {
        pf8d6a367Var.update(b);
    }

    public static void OdAyyiCaeIXhLTYZ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, int i, byte b2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OdAyyiCaeIXhLTYZ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, int i, byte b2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OdAyyiCaeIXhLTYZ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, int i, char c, byte b2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QLycPuZjiWIiprlu(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b) {
        pf8d6a367Var.update(b);
    }

    public static void QLycPuZjiWIiprlu(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, float f, int i, byte b2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QLycPuZjiWIiprlu(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, float f, int i, short s, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void QLycPuZjiWIiprlu(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, int i, short s, float f, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void QtLhfdbwmGcxFGYL(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b) {
        pf8d6a367Var.update(b);
    }

    public static void QtLhfdbwmGcxFGYL(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, byte b2, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QtLhfdbwmGcxFGYL(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, java.lang.string str, float f, byte b2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QtLhfdbwmGcxFGYL(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, java.lang.string str, bool z, float f, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void QtwqFQuZbbFhMzyA(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b) {
        pf8d6a367Var.update(b);
    }

    public static void QtwqFQuZbbFhMzyA(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QtwqFQuZbbFhMzyA(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QtwqFQuZbbFhMzyA(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RAKEZQwvaMEnMvTI(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1 p4d7fdfb1Var) {
        pf8d6a367Var.reset(p4d7fdfb1Var);
    }

    public static void RAKEZQwvaMEnMvTI(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1 p4d7fdfb1Var, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RAKEZQwvaMEnMvTI(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1 p4d7fdfb1Var, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RAKEZQwvaMEnMvTI(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1 p4d7fdfb1Var, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ROWKUBCDHQmcfUSm(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte[] bArr) {
        pf8d6a367Var.populateState(bArr);
    }

    public static void ROWKUBCDHQmcfUSm(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte[] bArr, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ROWKUBCDHQmcfUSm(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte[] bArr, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ROWKUBCDHQmcfUSm(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte[] bArr, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TigICrKatXHOwcHC(long j, byte[] bArr, int i, int i2) {
        m38b01934(j, bArr, i, i2);
    }

    public static void TigICrKatXHOwcHC(long j, byte[] bArr, int i, int i2, int i3, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TigICrKatXHOwcHC(long j, byte[] bArr, int i, int i2, int i3, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TigICrKatXHOwcHC(long j, byte[] bArr, int i, int i2, short s, int i3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UGgQZbnaqoAaQTnr(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b) {
        pf8d6a367Var.update(b);
    }

    public static void UGgQZbnaqoAaQTnr(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UGgQZbnaqoAaQTnr(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UGgQZbnaqoAaQTnr(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VQtDixbUZedppHsT(int i, byte[] bArr, int i2) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m27c2615b(i, bArr, i2);
    }

    public static void VQtDixbUZedppHsT(int i, byte[] bArr, int i2, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VQtDixbUZedppHsT(int i, byte[] bArr, int i2, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VQtDixbUZedppHsT(int i, byte[] bArr, int i2, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VbdZmNtsOouIrSRD(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b) {
        pf8d6a367Var.update(b);
    }

    public static void VbdZmNtsOouIrSRD(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VbdZmNtsOouIrSRD(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VbdZmNtsOouIrSRD(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VzLErvPZnRDoDGWx(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var) {
        pf8d6a367Var.reset();
    }

    public static void VzLErvPZnRDoDGWx(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VzLErvPZnRDoDGWx(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VzLErvPZnRDoDGWx(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XHRqcMLawtsBiGGO(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte[] bArr) {
        pf8d6a367Var.restoreState(bArr);
    }

    public static void XHRqcMLawtsBiGGO(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte[] bArr, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XHRqcMLawtsBiGGO(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte[] bArr, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XHRqcMLawtsBiGGO(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte[] bArr, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ABZlpkJZqykMoOZa(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf87e7128 pf87e7128Var, p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf87e7128 pf87e7128Var2) {
        super.copyIn(pf87e7128Var2);
    }

    public static void ABZlpkJZqykMoOZa(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf87e7128 pf87e7128Var, p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf87e7128 pf87e7128Var2, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ABZlpkJZqykMoOZa(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf87e7128 pf87e7128Var, p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf87e7128 pf87e7128Var2, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ABZlpkJZqykMoOZa(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf87e7128 pf87e7128Var, p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf87e7128 pf87e7128Var2, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BVSYYktCqUPYBstg(int i, byte[] bArr, int i2, int i3) {
        m27c2615b(i, bArr, i2, i3);
    }

    public static void BVSYYktCqUPYBstg(int i, byte[] bArr, int i2, int i3, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BVSYYktCqUPYBstg(int i, byte[] bArr, int i2, int i3, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BVSYYktCqUPYBstg(int i, byte[] bArr, int i2, int i3, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BzqeVSqbMNWCPpKV(int i) {
        return java.lang.int.tostring(i);
    }

    public static void BzqeVSqbMNWCPpKV(int i, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BzqeVSqbMNWCPpKV(int i, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BzqeVSqbMNWCPpKV(int i, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CTzPeJKGOLcnOSpk(int i, byte[] bArr, int i2, int i3) {
        m27c2615b(i, bArr, i2, i3);
    }

    public static void CTzPeJKGOLcnOSpk(int i, byte[] bArr, int i2, int i3, byte b, bool z, float f, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void CTzPeJKGOLcnOSpk(int i, byte[] bArr, int i2, int i3, float f, int i4, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CTzPeJKGOLcnOSpk(int i, byte[] bArr, int i2, int i3, bool z, float f, int i4, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DJGOfZSGfutqjcXC(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var) {
        return pf8d6a367Var.getEncodedStateSize();
    }

    public static void DJGOfZSGfutqjcXC(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DJGOfZSGfutqjcXC(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DJGOfZSGfutqjcXC(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder DgbnEQjxcbFUtYfj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DgbnEQjxcbFUtYfj(java.lang.stringBuilder sb, java.lang.string str, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DgbnEQjxcbFUtYfj(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DgbnEQjxcbFUtYfj(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FkYpHTfLnyrRubfD(long j, byte[] bArr, int i, int i2) {
        m38b01934(j, bArr, i, i2);
    }

    public static void FkYpHTfLnyrRubfD(long j, byte[] bArr, int i, int i2, float f, byte b, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void FkYpHTfLnyrRubfD(long j, byte[] bArr, int i, int i2, float f, int i3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FkYpHTfLnyrRubfD(long j, byte[] bArr, int i, int i2, int i3, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GGDZDUWaWPetJpss(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b) {
        pf8d6a367Var.update(b);
    }

    public static void GGDZDUWaWPetJpss(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, byte b2, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GGDZDUWaWPetJpss(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, short s, bool z, java.lang.string str, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void GGDZDUWaWPetJpss(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, bool z, byte b2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HQduYwYNommIlIGE(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b) {
        pf8d6a367Var.update(b);
    }

    public static void HQduYwYNommIlIGE(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HQduYwYNommIlIGE(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HQduYwYNommIlIGE(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KeYzIFCSlmHCaDeG(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, int i) {
        pf8d6a367Var.m6db11730(i);
    }

    public static void KeYzIFCSlmHCaDeG(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, int i, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KeYzIFCSlmHCaDeG(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, int i, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KeYzIFCSlmHCaDeG(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, int i, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KfyvPaEYPFPJZUJf(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b) {
        pf8d6a367Var.update(b);
    }

    public static void KfyvPaEYPFPJZUJf(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, float f, byte b2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KfyvPaEYPFPJZUJf(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, float f, bool z, java.lang.string str, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void KfyvPaEYPFPJZUJf(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, bool z, java.lang.string str, float f, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LayDjGDvNKufGIdm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void LayDjGDvNKufGIdm(java.lang.stringBuilder sb, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LayDjGDvNKufGIdm(java.lang.stringBuilder sb, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LayDjGDvNKufGIdm(java.lang.stringBuilder sb, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LyMDyMpIXroSaQCZ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b) {
        pf8d6a367Var.update(b);
    }

    public static void LyMDyMpIXroSaQCZ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, byte b2, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LyMDyMpIXroSaQCZ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, short s, byte b2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LyMDyMpIXroSaQCZ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, bool z, java.lang.string str, short s, byte b2) {
        double d = (42 * 210) + 210;
    }

    private static void M27c2615b(int i, byte[] bArr, int i2, int i3) {
        if ((13 + 31) % 31 > 0) {
        }
        int iYMlJNENNdWgcgrid = yMlJNENNdWgcgrid(4, i3);
        while (true) {
            iYMlJNENNdWgcgrid--;
            if (iYMlJNENNdWgcgrid < 0) {
                return;
            } else {
                bArr[i2 + iYMlJNENNdWgcgrid] = (byte) (i >>> ((3 - iYMlJNENNdWgcgrid) * 8));
            }
        }
    }

    private static void M27c2615b(int i, byte[] bArr, int i2, int i3, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private static void M27c2615b(int i, byte[] bArr, int i2, int i3, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private static void M27c2615b(int i, byte[] bArr, int i2, int i3, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private static void M38b01934(long j, byte[] bArr, int i, int i2) {
        if ((2 + 12) % 12 > 0) {
        }
        if (i2 <= 0) {
            return;
        }
        bVSYYktCqUPYBstg((int) (j >>> 32), bArr, i, i2);
        if (i2 <= 4) {
            return;
        }
        cTzPeJKGOLcnOSpk((int) (j & 4294967295L), bArr, i + 4, i2 - 4);
    }

    private static void M38b01934(long j, byte[] bArr, int i, int i2, byte b, char c, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void M38b01934(long j, byte[] bArr, int i, int i2, char c, int i3, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void M38b01934(long j, byte[] bArr, int i, int i2, java.lang.string str, byte b, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    private void M6db11730(int i) {
        if ((5 + 29) % 29 > 0) {
        }
        this.f106530dc = -3482333909917012819L;
        this.fca2bf3f6 = 2216346199247487646L;
        this.fb1476321 = -7364697282686394994L;
        this.f6b57370b = 65953792586715988L;
        this.f83065208 = -816286391624063116L;
        this.f2ac6cc2e = 4512832404995164602L;
        this.f3b3736ef = -5033199132376557362L;
        this.fb9895a4a = -124578254951840548L;
        wnYUbosaMBLegYcp(this, (byte) 83);
        tHZrxeuuMRtbnGSJ(this, (byte) 72);
        kfyvPaEYPFPJZUJf(this, (byte) 65);
        QtwqFQuZbbFhMzyA(this, (byte) 45);
        hQduYwYNommIlIGE(this, (byte) 53);
        QtLhfdbwmGcxFGYL(this, (byte) 49);
        lyMDyMpIXroSaQCZ(this, (byte) 50);
        xLOQvQcKheMWxwDb(this, (byte) 47);
        if (i > 100) {
            VbdZmNtsOouIrSRD(this, (byte) ((i / 100) + 48));
            int i2 = i % 100;
            IOTEudHIxDvvjIiH(this, (byte) ((i2 / 10) + 48));
            UGgQZbnaqoAaQTnr(this, (byte) ((i2 % 10) + 48));
        } else if (i <= 10) {
            QLycPuZjiWIiprlu(this, (byte) (i + 48));
        } else {
            gGDZDUWaWPetJpss(this, (byte) ((i / 10) + 48));
            OdAyyiCaeIXhLTYZ(this, (byte) ((i % 10) + 48));
        }
        tCGSqQrlRGYuvzRb(this);
        this.f732b52ea = this.f106530dc;
        this.faa7e5008 = this.fca2bf3f6;
        this.fca4275e2 = this.fb1476321;
        this.f591eb652 = this.f6b57370b;
        this.f1b44ec5d = this.f83065208;
        this.f46a10b8f = this.f2ac6cc2e;
        this.fa33546fd = this.f3b3736ef;
        this.f7f946043 = this.fb9895a4a;
    }

    private void M6db11730(int i, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void M6db11730(int i, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void M6db11730(int i, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private static int Mf4040b00(byte[] bArr) {
        return uktLMmsLgdCOKVaP(bArr, bArr.length - 4);
    }

    private static void Mf4040b00(byte[] bArr, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private static void Mf4040b00(byte[] bArr, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private static void Mf4040b00(byte[] bArr, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MkNeVAaOhHQsAxPs(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var) {
        pf8d6a367Var.reset();
    }

    public static void MkNeVAaOhHQsAxPs(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MkNeVAaOhHQsAxPs(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MkNeVAaOhHQsAxPs(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RCLSPKyZWWPpLnqW(long j, byte[] bArr, int i, int i2) {
        m38b01934(j, bArr, i, i2);
    }

    public static void RCLSPKyZWWPpLnqW(long j, byte[] bArr, int i, int i2, char c, int i3, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RCLSPKyZWWPpLnqW(long j, byte[] bArr, int i, int i2, int i3, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RCLSPKyZWWPpLnqW(long j, byte[] bArr, int i, int i2, short s, java.lang.string str, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RICmRguKdDlUboQR(long j, byte[] bArr, int i, int i2) {
        m38b01934(j, bArr, i, i2);
    }

    public static void RICmRguKdDlUboQR(long j, byte[] bArr, int i, int i2, byte b, int i3, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RICmRguKdDlUboQR(long j, byte[] bArr, int i, int i2, int i3, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RICmRguKdDlUboQR(long j, byte[] bArr, int i, int i2, short s, byte b, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void TCGSqQrlRGYuvzRb(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var) {
        pf8d6a367Var.finish();
    }

    public static void TCGSqQrlRGYuvzRb(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TCGSqQrlRGYuvzRb(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TCGSqQrlRGYuvzRb(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void THZrxeuuMRtbnGSJ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b) {
        pf8d6a367Var.update(b);
    }

    public static void THZrxeuuMRtbnGSJ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, float f, byte b2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void THZrxeuuMRtbnGSJ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, java.lang.string str, bool z, float f, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void THZrxeuuMRtbnGSJ(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, bool z, float f, java.lang.string str, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void UJhrSXOMEwNxVQEi(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf87e7128 pf87e7128Var) {
        super.reset();
    }

    public static void UJhrSXOMEwNxVQEi(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf87e7128 pf87e7128Var, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UJhrSXOMEwNxVQEi(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf87e7128 pf87e7128Var, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UJhrSXOMEwNxVQEi(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf87e7128 pf87e7128Var, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int UktLMmsLgdCOKVaP(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p05c7e247.p4492081c.mc4a60053(bArr, i);
    }

    public static void UktLMmsLgdCOKVaP(byte[] bArr, int i, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UktLMmsLgdCOKVaP(byte[] bArr, int i, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UktLMmsLgdCOKVaP(byte[] bArr, int i, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UwXkYPqWvxqPyphn(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var) {
        pf8d6a367Var.finish();
    }

    public static void UwXkYPqWvxqPyphn(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UwXkYPqWvxqPyphn(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UwXkYPqWvxqPyphn(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WnYUbosaMBLegYcp(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b) {
        pf8d6a367Var.update(b);
    }

    public static void WnYUbosaMBLegYcp(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WnYUbosaMBLegYcp(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WnYUbosaMBLegYcp(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XLOQvQcKheMWxwDb(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b) {
        pf8d6a367Var.update(b);
    }

    public static void XLOQvQcKheMWxwDb(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, byte b2, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XLOQvQcKheMWxwDb(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, float f, bool z, short s, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static void XLOQvQcKheMWxwDb(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var, byte b, bool z, float f, byte b2, short s) {
        double d = (42 * 210) + 210;
    }

    public static int YMlJNENNdWgcgrid(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void YMlJNENNdWgcgrid(int i, int i2, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YMlJNENNdWgcgrid(int i, int i2, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YMlJNENNdWgcgrid(int i, int i2, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public override p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1 Copy() {
        return new p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367(this);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((9 + 3) % 3 > 0) {
        }
        uwXkYPqWvxqPyphn(this);
        fkYpHTfLnyrRubfD(this.f106530dc, bArr, i, this.f60c53b4c);
        TigICrKatXHOwcHC(this.fca2bf3f6, bArr, i + 8, this.f60c53b4c - 8);
        EaMlsfLDKBDvlWaj(this.fb1476321, bArr, i + 16, this.f60c53b4c - 16);
        FueGAedcKEQOOYLN(this.f6b57370b, bArr, i + 24, this.f60c53b4c - 24);
        EiKNBlQjgxnrnZso(this.f83065208, bArr, i + 32, this.f60c53b4c - 32);
        FZjVlWeBFSEHVHcw(this.f2ac6cc2e, bArr, i + 40, this.f60c53b4c - 40);
        rCLSPKyZWWPpLnqW(this.f3b3736ef, bArr, i + 48, this.f60c53b4c - 48);
        rICmRguKdDlUboQR(this.fb9895a4a, bArr, i + 56, this.f60c53b4c - 56);
        mkNeVAaOhHQsAxPs(this);
        return this.f60c53b4c;
    }

    public override java.lang.string GetAlgorithmName() {
        if ((26 + 23) % 23 > 0) {
        }
        return layDjGDvNKufGIdm(dgbnEQjxcbFUtYfj(new java.lang.stringBuilder("SHA-512/"), bzqeVSqbMNWCPpKV(this.f60c53b4c * 8)));
    }

    public override int GetDigestSize() {
        return this.f60c53b4c;
    }

    public override byte[] GetEncodedState() {
        if ((18 + 3) % 3 > 0) {
        }
        int iDJGOfZSGfutqjcXC = dJGOfZSGfutqjcXC(this);
        byte[] bArr = new byte[iDJGOfZSGfutqjcXC + 4];
        ROWKUBCDHQmcfUSm(this, bArr);
        VQtDixbUZedppHsT(this.f60c53b4c * 8, bArr, iDJGOfZSGfutqjcXC);
        return bArr;
    }

    public override void Reset() {
        if ((21 + 22) % 22 > 0) {
        }
        uJhrSXOMEwNxVQEi(this);
        this.f106530dc = this.f732b52ea;
        this.fca2bf3f6 = this.faa7e5008;
        this.fb1476321 = this.fca4275e2;
        this.f6b57370b = this.f591eb652;
        this.f83065208 = this.f1b44ec5d;
        this.f2ac6cc2e = this.f46a10b8f;
        this.f3b3736ef = this.fa33546fd;
        this.fb9895a4a = this.f7f946043;
    }

    public override void Reset(p5a445d71.p7c922baa.p05c7e247.p4d7fdfb1 p4d7fdfb1Var) {
        if ((9 + 21) % 21 > 0) {
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367 pf8d6a367Var = (p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.pf8d6a367) p4d7fdfb1Var;
        if (this.f60c53b4c != pf8d6a367Var.f60c53b4c) {
            throw new p5a445d71.p7c922baa.p05c7e247.p1a54066e("digestLength inappropriate in other");
        }
        aBZlpkJZqykMoOZa(this, pf8d6a367Var);
        this.f732b52ea = pf8d6a367Var.f732b52ea;
        this.faa7e5008 = pf8d6a367Var.faa7e5008;
        this.fca4275e2 = pf8d6a367Var.fca4275e2;
        this.f591eb652 = pf8d6a367Var.f591eb652;
        this.f1b44ec5d = pf8d6a367Var.f1b44ec5d;
        this.f46a10b8f = pf8d6a367Var.f46a10b8f;
        this.fa33546fd = pf8d6a367Var.fa33546fd;
        this.f7f946043 = pf8d6a367Var.f7f946043;
    }
}

