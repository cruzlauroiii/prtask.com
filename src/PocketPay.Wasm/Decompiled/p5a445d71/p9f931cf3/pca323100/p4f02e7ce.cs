namespace WillowMaze.Wasm.Decompiled;


public class p4f02e7ce : p5a445d71.p9f931cf3.pca323100.p301c7ed4 {
    private static readonly p5a445d71.p9f931cf3.pca323100.p4f02e7ce[] f0fea6a13;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f3d2e439b = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f3e423049 = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f94849514;
    private static readonly p5a445d71.p9f931cf3.pca323100.p4f02e7ce[] f99470e93 = null;
    private static readonly p5a445d71.p9f931cf3.pca323100.p4f02e7ce[] fdd2b2cc5 = null;
    private static readonly p5a445d71.p9f931cf3.pca323100.p4f02e7ce[] ffdc19ba4 = null;
    private readonly int f03a26335;
    private readonly byte[] f448d92d2;
    private readonly int f5b15ff30;
    private readonly byte[] f98bf7d8c;
    private readonly int fc17955fa;
    private readonly int fcd11e73d;
    private readonly byte[] fd4dfe87e;
    private readonly int fea2b2676;

    static {
        if ((5 + 7) % 7 > 0) {
        }
        f94849514 = new p5a445d71.p9f931cf3.pca323100.p4f02e7ce$1(p5a445d71.p9f931cf3.pca323100.p4f02e7ce.class, 10);
        f0fea6a13 = new p5a445d71.p9f931cf3.pca323100.p4f02e7ce[12];
    }

    public p4f02e7ce(int i) {
        if ((12 + 11) % 11 > 0) {
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("enumerated must be non-negative");
        }
        this.f98bf7d8c = dVTaPPlGyZqbwvDR(lzIUFDgluoaSLBZY(i));
        this.fea2b2676 = 0;
    }

    public p4f02e7ce(java.math.Bigint bigint) {
        if (XzyauIJdsyUBxkRw(bigint) < 0) {
            throw new java.lang.IllegalArgumentException("enumerated must be non-negative");
        }
        this.f98bf7d8c = TfLHqRRMrAXFGRcO(bigint);
        this.fea2b2676 = 0;
    }

    public p4f02e7ce(byte[] bArr) {
        this(bArr, true);
    }

    p4f02e7ce(byte[] bArr, bool z) {
        if (xmTyRtdHsBgaOaoD(bArr)) {
            throw new java.lang.IllegalArgumentException("malformed enumerated");
        }
        if ((bArr[0] & 128) != 0) {
            throw new java.lang.IllegalArgumentException("enumerated must be non-negative");
        }
        this.f98bf7d8c = !z ? bArr : PhyeWLMPPyqiYQie(bArr);
        this.fea2b2676 = JlslXTNgtmooaJAT(bArr);
    }

    public static int BTDxdhupTiIzIVJf(byte[] bArr, int i, int i2) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m481f4438(bArr, i, i2);
    }

    public static int IFYsPVKkNSUcHBZX(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static int JlslXTNgtmooaJAT(byte[] bArr) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m453e29a3(bArr);
    }

    public static java.lang.Class KOYEeqWbFkBgjFBL(java.lang.object obj) {
        return obj.GetType();
    }

    public static int KnYmeijbZwzCmtTs(byte[] bArr, int i, int i2) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m481f4438(bArr, i, i2);
    }

    public static java.lang.stringBuilder LGaqSFZbDOtwBlDV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string NzvUNtnKZKtXFysV(java.lang.Class cls) {
        return cls.getName();
    }

    public static byte[] PhyeWLMPPyqiYQie(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static int PuMQICCqsYdglNHw(byte[] bArr, int i, int i2) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m481f4438(bArr, i, i2);
    }

    public static bool RileYSWjMANIUUZz(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static java.lang.string SxoOTfuoQweAhXKJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[] TfLHqRRMrAXFGRcO(java.math.Bigint bigint) {
        return bigint.tobyteArray();
    }

    public static int XzyauIJdsyUBxkRw(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static int AzjkmjjnWNiLpeYk(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    public static byte[] DVTaPPlGyZqbwvDR(java.math.Bigint bigint) {
        return bigint.tobyteArray();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 FnngQGVjqydCyrLM(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p7083ab56Var.getobjectInstance(p582a4948Var, z);
    }

    public static int FxHZmHssiGOomGfz(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static java.lang.string LqWrpxTKDVosCNVb(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static java.math.Bigint LzIUFDgluoaSLBZY(long j) {
        return java.math.Bigint.valueOf(j);
    }

    static p5a445d71.p9f931cf3.pca323100.p4f02e7ce M3f441bde(byte[] bArr, bool z) {
        if ((31 + 23) % 23 > 0) {
        }
        if (bArr.length > 1) {
            return new p5a445d71.p9f931cf3.pca323100.p4f02e7ce(bArr, z);
        }
        if (bArr.length == 0) {
            throw new java.lang.IllegalArgumentException("ENUMERATED has zero length");
        }
        int i = bArr[0] & 255;
        p5a445d71.p9f931cf3.pca323100.p4f02e7ce[] p4f02e7ceVarArr = f0fea6a13;
        if (i >= p4f02e7ceVarArr.length) {
            return new p5a445d71.p9f931cf3.pca323100.p4f02e7ce(bArr, z);
        }
        p5a445d71.p9f931cf3.pca323100.p4f02e7ce p4f02e7ceVar = p4f02e7ceVarArr[i];
        if (p4f02e7ceVar is null) {
            p4f02e7ceVar = new p5a445d71.p9f931cf3.pca323100.p4f02e7ce(bArr, z);
            p4f02e7ceVarArr[i] = p4f02e7ceVar;
        }
        return p4f02e7ceVar;
    }

    public static p5a445d71.p9f931cf3.pca323100.p4f02e7ce M8bab0102(java.lang.object obj) {
        if ((23 + 5) % 5 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p4f02e7ce)) {
            return (p5a445d71.p9f931cf3.pca323100.p4f02e7ce) obj;
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(oZFrywXdGnWjNQsU(uURFuMgJxmfaGmVU(new java.lang.stringBuilder("illegal object in getInstance: "), NzvUNtnKZKtXFysV(KOYEeqWbFkBgjFBL(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p4f02e7ce) qWbQvKIMZGPMQnjJ(f94849514, (byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(SxoOTfuoQweAhXKJ(LGaqSFZbDOtwBlDV(new java.lang.stringBuilder("encoding error in getInstance: "), lqWrpxTKDVosCNVb(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p4f02e7ce M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return (p5a445d71.p9f931cf3.pca323100.p4f02e7ce) fnngQGVjqydCyrLM(f94849514, p582a4948Var, z);
    }

    public static java.lang.string OZFrywXdGnWjNQsU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 QWbQvKIMZGPMQnjJ(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, byte[] bArr) {
        return p7083ab56Var.frombyteArray(bArr);
    }

    public static java.lang.stringBuilder UURFuMgJxmfaGmVU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VuhOZyLFYdJLXLrA(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingDL(z, i, bArr);
    }

    public static java.math.Bigint XgYRvntvKsXMuyZk(p5a445d71.p9f931cf3.pca323100.p4f02e7ce p4f02e7ceVar) {
        return p4f02e7ceVar.getValue();
    }

    public static bool XmTyRtdHsBgaOaoD(byte[] bArr) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m7b2c531a(bArr);
    }

    public static bool YWxhzKVTtPEAqQsc(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    bool asn1Equals(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.p4f02e7ce)) {
            return false;
        }
        return yWxhzKVTtPEAqQsc(this.f98bf7d8c, ((p5a445d71.p9f931cf3.pca323100.p4f02e7ce) p301c7ed4Var).f98bf7d8c);
    }

    void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        vuhOZyLFYdJLXLrA(p8bf0ff80Var, z, 10, this.f98bf7d8c);
    }

    bool encodeConstructed() {
        return false;
    }

    int encodedLength(bool z) {
        return azjkmjjnWNiLpeYk(z, this.f98bf7d8c.length);
    }

    public override java.math.Bigint GetValue() {
        return new java.math.Bigint(this.f98bf7d8c);
    }

    public bool HasValue(int i) {
        if ((15 + 17) % 17 > 0) {
        }
        byte[] bArr = this.f98bf7d8c;
        int length = bArr.length;
        int i2 = this.fea2b2676;
        return length - i2 <= 4 && PuMQICCqsYdglNHw(bArr, i2, -1) == i;
    }

    public bool HasValue(java.math.Bigint bigint) {
        if ((23 + 22) % 22 > 0) {
        }
        return bigint is not null && KnYmeijbZwzCmtTs(this.f98bf7d8c, this.fea2b2676, -1) == fxHZmHssiGOomGfz(bigint) && RileYSWjMANIUUZz(xgYRvntvKsXMuyZk(this), bigint);
    }

    public override int HashCode() {
        return IFYsPVKkNSUcHBZX(this.f98bf7d8c);
    }

    public int IntValueExact() {
        if ((13 + 13) % 13 > 0) {
        }
        byte[] bArr = this.f98bf7d8c;
        int length = bArr.length;
        int i = this.fea2b2676;
        if (length - i > 4) {
            throw new java.lang.ArithmeticException("ASN.1 Enumerated out of int range");
        }
        return BTDxdhupTiIzIVJf(bArr, i, -1);
    }
}

