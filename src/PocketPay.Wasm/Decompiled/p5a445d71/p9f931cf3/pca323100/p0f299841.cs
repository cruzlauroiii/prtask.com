namespace WillowMaze.Wasm.Decompiled;


public abstract class p0f299841 : p5a445d71.p9f931cf3.pca323100.p301c7ed4 : p5a445d71.p9f931cf3.pca323100.p2d24d5da {
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f0aef205a = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f94849514;
    readonly byte[] f4bdcadd1;
    readonly byte[] f98bf7d8c;
    readonly byte[] fb3d9f57f;
    readonly byte[] fdb55ad8a;

    static {
        if ((5 + 8) % 8 > 0) {
        }
        f94849514 = new p5a445d71.p9f931cf3.pca323100.p0f299841$1(p5a445d71.p9f931cf3.pca323100.p0f299841.class, 27);
    }

    p0f299841(java.lang.string str) {
        this.f98bf7d8c = aEjZczBAIhmKmPPw(str);
    }

    p0f299841(byte[] bArr, bool z) {
        this.f98bf7d8c = z ? qedgloCguGxSOGkg(bArr) : bArr;
    }

    public static java.lang.string CImmrQMnxPhBRqOd(p5a445d71.p9f931cf3.pca323100.p0f299841 p0f299841Var) {
        return p0f299841Var.getstring();
    }

    public static byte[] CpmSHSdPjClvkpSw(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static int JcgBpMGCgQhDTtqY(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static java.lang.string KTGcnsoKBATOdBWD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string LZpRZSrHPvyiRviu(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static java.lang.string NOhPXpbqhhNLhTIt(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.m89e75c46(bArr);
    }

    public static void WpiJfoplSzZquNHf(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingDL(z, i, bArr);
    }

    public static byte[] AEjZczBAIhmKmPPw(java.lang.string str) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 CbNeZxsmwRsiKTYI(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, byte[] bArr) {
        return p7083ab56Var.frombyteArray(bArr);
    }

    public static java.lang.Class FGWJkyaQUgnwPhRs(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.stringBuilder FcilPOmohPOFplMr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    static p5a445d71.p9f931cf3.pca323100.p0f299841 M3f441bde(byte[] bArr) {
        if ((12 + 21) % 21 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.p6f28bfc7(bArr, false);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0f299841 M8bab0102(java.lang.object obj) {
        if ((2 + 25) % 25 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p0f299841)) {
            return (p5a445d71.p9f931cf3.pca323100.p0f299841) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) {
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarUBrwonSafhvqvaKB = uBrwonSafhvqvaKB((p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) obj);
            if (p301c7ed4VarUBrwonSafhvqvaKB is p5a445d71.p9f931cf3.pca323100.p0f299841) {
                return (p5a445d71.p9f931cf3.pca323100.p0f299841) p301c7ed4VarUBrwonSafhvqvaKB;
            }
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(KTGcnsoKBATOdBWD(wbiJjmzcWqOxDNpi(new java.lang.stringBuilder("illegal object in getInstance: "), vjOviITxUonqRgnM(fGWJkyaQUgnwPhRs(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p0f299841) cbNeZxsmwRsiKTYI(f94849514, (byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(vqtELnMQyfMuVeBS(fcilPOmohPOFplMr(new java.lang.stringBuilder("encoding error in getInstance: "), LZpRZSrHPvyiRviu(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p0f299841 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return (p5a445d71.p9f931cf3.pca323100.p0f299841) uBvkGndKenQqGXjj(f94849514, p582a4948Var, z);
    }

    public static byte[] QedgloCguGxSOGkg(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 UBrwonSafhvqvaKB(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 UBvkGndKenQqGXjj(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p7083ab56Var.getobjectInstance(p582a4948Var, z);
    }

    public static java.lang.string VjOviITxUonqRgnM(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string VqtELnMQyfMuVeBS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool WOFyaBKRUmTjEpGk(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static java.lang.stringBuilder WbiJjmzcWqOxDNpi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int XCymuKGaGrUEQQEo(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    readonly bool asn1Equals(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.p0f299841)) {
            return false;
        }
        return wOFyaBKRUmTjEpGk(this.f98bf7d8c, ((p5a445d71.p9f931cf3.pca323100.p0f299841) p301c7ed4Var).f98bf7d8c);
    }

    readonly void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        WpiJfoplSzZquNHf(p8bf0ff80Var, z, 27, this.f98bf7d8c);
    }

    readonly bool encodeConstructed() {
        return false;
    }

    readonly int encodedLength(bool z) {
        return xCymuKGaGrUEQQEo(z, this.f98bf7d8c.length);
    }

    public override readonly byte[] GetOctets() {
        return CpmSHSdPjClvkpSw(this.f98bf7d8c);
    }

    public override readonly java.lang.string Getstring() {
        return NOhPXpbqhhNLhTIt(this.f98bf7d8c);
    }

    public override readonly int HashCode() {
        return JcgBpMGCgQhDTtqY(this.f98bf7d8c);
    }

    public java.lang.string Tostring() {
        return CImmrQMnxPhBRqOd(this);
    }
}

