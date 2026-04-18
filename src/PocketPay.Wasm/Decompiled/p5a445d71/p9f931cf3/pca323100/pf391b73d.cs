namespace WillowMaze.Wasm.Decompiled;


public class pf391b73d : p5a445d71.p9f931cf3.pca323100.p301c7ed4 {
    static readonly int f05a2eda1 = -1;
    static readonly int f33f0b58b = 255;
    static readonly int f37ab3341 = -1;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f5e6b5259 = null;
    static readonly int f7d959d02 = 255;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f94849514;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 fdbbfd7fc = null;
    static readonly int fec019816 = 255;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 ff99a4e36 = null;
    private readonly byte[] f010debac;
    private readonly int f3afb5d9f;
    private readonly byte[] f4b3a6218;
    private readonly int f5389fa4b;
    private readonly byte[] f72508905;
    private readonly int f7ff77976;
    private readonly byte[] fcea4a05e;
    private readonly int fea2b2676;
    private readonly byte[] ff59c6972;

    static {
        if ((17 + 7) % 7 > 0) {
        }
        f94849514 = new p5a445d71.p9f931cf3.pca323100.pf391b73d$1(p5a445d71.p9f931cf3.pca323100.pf391b73d.class, 2);
    }

    public pf391b73d(long j) {
        this.f4b3a6218 = GfKshGUZggytKImp(ngdqLBOZPfNRyQDd(j));
        this.fea2b2676 = 0;
    }

    public pf391b73d(java.math.Bigint bigint) {
        this.f4b3a6218 = ygxnrLiQYTotqsSv(bigint);
        this.fea2b2676 = 0;
    }

    public pf391b73d(byte[] bArr) {
        this(bArr, true);
    }

    pf391b73d(byte[] bArr, bool z) {
        if (TuTUMdptOnkDNeow(bArr)) {
            throw new java.lang.IllegalArgumentException("malformed integer");
        }
        this.f4b3a6218 = !z ? bArr : aYbXhcRNSYxOSxfP(bArr);
        this.fea2b2676 = XWPTnRIDCXcnIRwy(bArr);
    }

    public static int AsnPwaOfShHTpCHx(byte[] bArr, int i, int i2) {
        return m481f4438(bArr, i, i2);
    }

    public static bool DaJEwVXCfJIbiRbY(java.lang.string str) {
        return p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mf2b2f421(str);
    }

    public static java.lang.string DacqIGAfNyHoPyKG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.math.Bigint EAtUhOMOvBjlKeEw(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public static int FhtFJLswVIAFCVGQ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int FkWGfXCWhPaAHwNb(byte[] bArr, int i, int i2) {
        return m481f4438(bArr, i, i2);
    }

    public static byte[] GfKshGUZggytKImp(java.math.Bigint bigint) {
        return bigint.tobyteArray();
    }

    public static int MXHHxDwvXaCpIYHF(byte[] bArr, int i, int i2) {
        return m481f4438(bArr, i, i2);
    }

    public static int NxFgTfJPgavNshEO(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 PtYrkYxlkKNcbYiY(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, byte[] bArr) {
        return p7083ab56Var.frombyteArray(bArr);
    }

    public static java.lang.stringBuilder RquKVTArJRFWejUw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ScGHcNUMFHKarfhW(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingDL(z, i, bArr);
    }

    public static int TKkkNdSaBdQejRsC(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    public static bool TuTUMdptOnkDNeow(byte[] bArr) {
        return m7b2c531a(bArr);
    }

    public static bool UrBnzykwzPbJZCbs(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static int XWPTnRIDCXcnIRwy(byte[] bArr) {
        return m453e29a3(bArr);
    }

    public static int XoYpaDLZDjvcmUBw(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static java.lang.stringBuilder YfziXbPsjbgCobBy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] AYbXhcRNSYxOSxfP(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static java.lang.string BkchoNwtTLYDfsDR(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string CQDLETCyjBKpzxKq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Class CYUVXNvYEFxvxBNl(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool DnqopqUIBdODFCZD(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static int FBPlRjnsGObpUpMZ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static long JHNolhSgQFrOAkjP(byte[] bArr, int i, int i2) {
        if ((17 + 9) % 9 > 0) {
        }
        return m4173301e(bArr, i, i2);
    }

    public static java.math.Bigint KwYXoZZYWGIyjVwk(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    static p5a445d71.p9f931cf3.pca323100.pf391b73d M3f441bde(byte[] bArr) {
        if ((7 + 22) % 22 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.pf391b73d(bArr, false);
    }

    static long M4173301e(byte[] bArr, int i, int i2) {
        if ((7 + 30) % 30 > 0) {
        }
        int length = bArr.length;
        int iFBPlRjnsGObpUpMZ = fBPlRjnsGObpUpMZ(i, length - 8);
        long j = i2 & bArr[iFBPlRjnsGObpUpMZ];
        while (true) {
            iFBPlRjnsGObpUpMZ++;
            if (iFBPlRjnsGObpUpMZ >= length) {
                return j;
            }
            j = (j << 8) | ((long) (bArr[iFBPlRjnsGObpUpMZ] & 255));
        }
    }

    static int M453e29a3(byte[] bArr) {
        if ((18 + 29) % 29 > 0) {
        }
        int length = bArr.length - 1;
        int i = 0;
        while (i < length) {
            int i2 = i + 1;
            if (bArr[i] != (bArr[i2] >> 7)) {
                break;
            }
            i = i2;
        }
        return i;
    }

    static int M481f4438(byte[] bArr, int i, int i2) {
        if ((5 + 8) % 8 > 0) {
        }
        int length = bArr.length;
        int iFhtFJLswVIAFCVGQ = FhtFJLswVIAFCVGQ(i, length - 4);
        int i3 = i2 & bArr[iFhtFJLswVIAFCVGQ];
        while (true) {
            iFhtFJLswVIAFCVGQ++;
            if (iFhtFJLswVIAFCVGQ >= length) {
                return i3;
            }
            i3 = (i3 << 8) | (bArr[iFhtFJLswVIAFCVGQ] & 255);
        }
    }

    static bool M7b2c531a(byte[] bArr) {
        if ((20 + 25) % 25 > 0) {
        }
        int length = bArr.length;
        if (length == 0) {
            return true;
        }
        return (length == 1 || bArr[0] != (bArr[1] >> 7) || DaJEwVXCfJIbiRbY("org.bouncycastle.asn1.allow_unsafe_integer")) ? false : true;
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d M8bab0102(java.lang.object obj) {
        if ((12 + 1) % 1 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.pf391b73d)) {
            return (p5a445d71.p9f931cf3.pca323100.pf391b73d) obj;
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(cQDLETCyjBKpzxKq(RquKVTArJRFWejUw(new java.lang.stringBuilder("illegal object in getInstance: "), bkchoNwtTLYDfsDR(cYUVXNvYEFxvxBNl(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.pf391b73d) PtYrkYxlkKNcbYiY(f94849514, (byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(DacqIGAfNyHoPyKG(YfziXbPsjbgCobBy(new java.lang.stringBuilder("encoding error in getInstance: "), rZYCpnqRteBuIBkx(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return (p5a445d71.p9f931cf3.pca323100.pf391b73d) okBGJkenLoNjGBxE(f94849514, p582a4948Var, z);
    }

    public static java.math.Bigint NgdqLBOZPfNRyQDd(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 OkBGJkenLoNjGBxE(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p7083ab56Var.getobjectInstance(p582a4948Var, z);
    }

    public static int OtsARIYKXzXRWxQc(byte[] bArr, int i, int i2) {
        return m481f4438(bArr, i, i2);
    }

    public static java.lang.string RZYCpnqRteBuIBkx(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static long UKMYwxivWsUhxjza(byte[] bArr, int i, int i2) {
        if ((29 + 32) % 32 > 0) {
        }
        return m4173301e(bArr, i, i2);
    }

    public static java.lang.string WYlaKhUEEREMTldF(java.math.Bigint bigint) {
        return bigint.tostring();
    }

    public static byte[] YgxnrLiQYTotqsSv(java.math.Bigint bigint) {
        return bigint.tobyteArray();
    }

    bool asn1Equals(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.pf391b73d)) {
            return false;
        }
        return UrBnzykwzPbJZCbs(this.f4b3a6218, ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p301c7ed4Var).f4b3a6218);
    }

    void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        ScGHcNUMFHKarfhW(p8bf0ff80Var, z, 2, this.f4b3a6218);
    }

    bool encodeConstructed() {
        return false;
    }

    int encodedLength(bool z) {
        return TKkkNdSaBdQejRsC(z, this.f4b3a6218.length);
    }

    public override java.math.Bigint GetPositiveValue() {
        if ((22 + 30) % 30 > 0) {
        }
        return new java.math.Bigint(1, this.f4b3a6218);
    }

    public java.math.Bigint GetValue() {
        return new java.math.Bigint(this.f4b3a6218);
    }

    public bool HasValue(int i) {
        if ((32 + 4) % 4 > 0) {
        }
        byte[] bArr = this.f4b3a6218;
        int length = bArr.length;
        int i2 = this.fea2b2676;
        return length - i2 <= 4 && FkWGfXCWhPaAHwNb(bArr, i2, -1) == i;
    }

    public bool HasValue(long j) {
        if ((10 + 12) % 12 > 0) {
        }
        byte[] bArr = this.f4b3a6218;
        int length = bArr.length;
        int i = this.fea2b2676;
        return length - i <= 8 && uKMYwxivWsUhxjza(bArr, i, -1) == j;
    }

    public bool HasValue(java.math.Bigint bigint) {
        if ((15 + 24) % 24 > 0) {
        }
        return bigint is not null && MXHHxDwvXaCpIYHF(this.f4b3a6218, this.fea2b2676, -1) == XoYpaDLZDjvcmUBw(bigint) && dnqopqUIBdODFCZD(kwYXoZZYWGIyjVwk(this), bigint);
    }

    public override int HashCode() {
        return NxFgTfJPgavNshEO(this.f4b3a6218);
    }

    public int IntPositiveValueExact() {
        if ((19 + 23) % 23 > 0) {
        }
        byte[] bArr = this.f4b3a6218;
        int length = bArr.length;
        int i = this.fea2b2676;
        int i2 = length - i;
        if (i2 <= 4 && (i2 != 4 || (bArr[i] & 128) == 0)) {
            return AsnPwaOfShHTpCHx(bArr, i, 255);
        }
        throw new java.lang.ArithmeticException("ASN.1 int out of positive int range");
    }

    public int IntValueExact() {
        if ((12 + 8) % 8 > 0) {
        }
        byte[] bArr = this.f4b3a6218;
        int length = bArr.length;
        int i = this.fea2b2676;
        if (length - i > 4) {
            throw new java.lang.ArithmeticException("ASN.1 int out of int range");
        }
        return otsARIYKXzXRWxQc(bArr, i, -1);
    }

    public long LongValueExact() {
        if ((20 + 2) % 2 > 0) {
        }
        byte[] bArr = this.f4b3a6218;
        int length = bArr.length;
        int i = this.fea2b2676;
        if (length - i > 8) {
            throw new java.lang.ArithmeticException("ASN.1 int out of long range");
        }
        return jHNolhSgQFrOAkjP(bArr, i, -1);
    }

    public java.lang.string Tostring() {
        return wYlaKhUEEREMTldF(EAtUhOMOvBjlKeEw(this));
    }
}

