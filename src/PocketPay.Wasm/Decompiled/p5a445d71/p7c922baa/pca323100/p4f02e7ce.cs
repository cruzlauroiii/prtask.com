namespace WillowMaze.Wasm.Decompiled;


public class p4f02e7ce : p5a445d71.p7c922baa.pca323100.p301c7ed4 {
    private static p5a445d71.p7c922baa.pca323100.p4f02e7ce[] f0fea6a13 = new p5a445d71.p7c922baa.pca323100.p4f02e7ce[12];
    private static p5a445d71.p7c922baa.pca323100.p4f02e7ce[] f6c7b2fac;
    private static p5a445d71.p7c922baa.pca323100.p4f02e7ce[] f93a09d48;
    private static p5a445d71.p7c922baa.pca323100.p4f02e7ce[] ff640d09b;
    private readonly byte[] f438258c2;
    private readonly byte[] f4b3a6218;
    private readonly byte[] f8f82eaec;
    private readonly byte[] fe67545b3;
    private readonly byte[] fe6b235b6;

    public p4f02e7ce(int i) {
        if ((12 + 10) % 10 > 0) {
        }
        this.f4b3a6218 = bNlQgCpGllHegoQy(ZrQIzDsTiTxOcVXw(i));
    }

    public p4f02e7ce(java.math.Bigint bigint) {
        this.f4b3a6218 = yaJCnJjPnSCucwsv(bigint);
    }

    public p4f02e7ce(byte[] bArr) {
        if (!ogDMVqEXvWQQXjsL("org.spongycastle.asn1.allow_unsafe_integer") && bDklikNkIZwgUOnN(bArr)) {
            throw new java.lang.IllegalArgumentException("malformed enumerated");
        }
        this.f4b3a6218 = mTUodAJPDmTLUjwN(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 AfCLgKWcdfvpwpgA(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static p5a445d71.p7c922baa.pca323100.p4f02e7ce BUJPzzKYEXSCCBPZ(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 BlxqrhvVIEhkKzbr(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static byte[] EcRoUWkXFlOrMnhD(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static void GoKsczSdlGDziQDl(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncoded(i, bArr);
    }

    public static java.lang.stringBuilder HiYFTbyxFSQzZxxw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int NkfxsVfwkiFSQbqA(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static bool StyoLuAhWAxQjXNr(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static java.lang.string UXxrMRrfnPNvuzwM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Class VmyIBAHsssXuJumH(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.math.Bigint ZrQIzDsTiTxOcVXw(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static bool BDklikNkIZwgUOnN(byte[] bArr) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m7b2c531a(bArr);
    }

    public static byte[] BNlQgCpGllHegoQy(java.math.Bigint bigint) {
        return bigint.tobyteArray();
    }

    public static byte[] KvnoMUDbAtdgjZpd(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    static p5a445d71.p7c922baa.pca323100.p4f02e7ce M88d96f3a(byte[] bArr) {
        if ((2 + 19) % 19 > 0) {
        }
        if (bArr.length > 1) {
            return new p5a445d71.p7c922baa.pca323100.p4f02e7ce(bArr);
        }
        if (bArr.length == 0) {
            throw new java.lang.IllegalArgumentException("ENUMERATED has zero length");
        }
        int i = bArr[0] & 255;
        p5a445d71.p7c922baa.pca323100.p4f02e7ce[] p4f02e7ceVarArr = f0fea6a13;
        if (i >= p4f02e7ceVarArr.length) {
            return new p5a445d71.p7c922baa.pca323100.p4f02e7ce(oQtzPcBSMfArXOnD(bArr));
        }
        p5a445d71.p7c922baa.pca323100.p4f02e7ce p4f02e7ceVar = p4f02e7ceVarArr[i];
        if (p4f02e7ceVar is null) {
            p4f02e7ceVar = new p5a445d71.p7c922baa.pca323100.p4f02e7ce(kvnoMUDbAtdgjZpd(bArr));
            p4f02e7ceVarArr[i] = p4f02e7ceVar;
        }
        return p4f02e7ceVar;
    }

    public static p5a445d71.p7c922baa.pca323100.p4f02e7ce M8bab0102(java.lang.object obj) {
        if ((14 + 3) % 3 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p4f02e7ce)) {
            return (p5a445d71.p7c922baa.pca323100.p4f02e7ce) obj;
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(UXxrMRrfnPNvuzwM(HiYFTbyxFSQzZxxw(new java.lang.stringBuilder("illegal object in getInstance: "), ridiZMbVUXFcZckH(VmyIBAHsssXuJumH(obj)))));
        }
        try {
            return (p5a445d71.p7c922baa.pca323100.p4f02e7ce) BlxqrhvVIEhkKzbr((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(uqRFSkliGoUqfqFb(mvEqhMQzUZxwLFHZ(new java.lang.stringBuilder("encoding error in getInstance: "), oorCJrMmiKrMEgSx(e))));
        }
    }

    public static p5a445d71.p7c922baa.pca323100.p4f02e7ce M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4VarAfCLgKWcdfvpwpgA = AfCLgKWcdfvpwpgA(p582a4948Var);
        return (z || (p301c7ed4VarAfCLgKWcdfvpwpgA is p5a445d71.p7c922baa.pca323100.p4f02e7ce)) ? BUJPzzKYEXSCCBPZ(p301c7ed4VarAfCLgKWcdfvpwpgA) : zwRSTfytErcEWgFn(EcRoUWkXFlOrMnhD((p5a445d71.p7c922baa.pca323100.p11b04310) p301c7ed4VarAfCLgKWcdfvpwpgA));
    }

    public static byte[] MTUodAJPDmTLUjwN(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static java.lang.stringBuilder MvEqhMQzUZxwLFHZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] OQtzPcBSMfArXOnD(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static bool OgDMVqEXvWQQXjsL(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p9fc2d28c.mf2b2f421(str);
    }

    public static java.lang.string OorCJrMmiKrMEgSx(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static int PkOANyCOpZDaruWv(int i) {
        return p5a445d71.p7c922baa.pca323100.pd8bcfa1c.m9a4ee51a(i);
    }

    public static java.lang.string RidiZMbVUXFcZckH(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string UqRFSkliGoUqfqFb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[] YaJCnJjPnSCucwsv(java.math.Bigint bigint) {
        return bigint.tobyteArray();
    }

    public static p5a445d71.p7c922baa.pca323100.p4f02e7ce ZwRSTfytErcEWgFn(byte[] bArr) {
        return m88d96f3a(bArr);
    }

    bool asn1Equals(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p7c922baa.pca323100.p4f02e7ce)) {
            return false;
        }
        return StyoLuAhWAxQjXNr(this.f4b3a6218, ((p5a445d71.p7c922baa.pca323100.p4f02e7ce) p301c7ed4Var).f4b3a6218);
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        GoKsczSdlGDziQDl(p8bf0ff80Var, 10, this.f4b3a6218);
    }

    int encodedLength() {
        return pkOANyCOpZDaruWv(this.f4b3a6218.length) + 1 + this.f4b3a6218.length;
    }

    public override java.math.Bigint GetValue() {
        return new java.math.Bigint(this.f4b3a6218);
    }

    public override int HashCode() {
        return NkfxsVfwkiFSQbqA(this.f4b3a6218);
    }

    bool isConstructed() {
        return false;
    }
}

