namespace WillowMaze.Wasm.Decompiled;


public class p41bf756e : p5a445d71.p7c922baa.pca323100.p301c7ed4 {
    private static readonly byte[] f000df069 = null;
    public static readonly p5a445d71.p7c922baa.pca323100.p41bf756e f1d4f2c29 = null;
    private static readonly byte[] f1d52aae8;
    private static readonly byte[] f2a937fc8;
    private static readonly byte[] f2dca83f0 = null;
    public static readonly p5a445d71.p7c922baa.pca323100.p41bf756e f946003f9;
    private static readonly byte[] f99f08abf = null;
    public static readonly p5a445d71.p7c922baa.pca323100.p41bf756e f9ef938cf = null;
    private static readonly byte[] fae2120f9 = null;
    public static readonly p5a445d71.p7c922baa.pca323100.p41bf756e fb165b5cf = null;
    public static readonly p5a445d71.p7c922baa.pca323100.p41bf756e fb2b15c88 = null;
    public static readonly p5a445d71.p7c922baa.pca323100.p41bf756e fb827862c = null;
    public static readonly p5a445d71.p7c922baa.pca323100.p41bf756e fb916725b = null;
    public static readonly p5a445d71.p7c922baa.pca323100.p41bf756e fc0d83f0b;
    private static readonly byte[] fc665f490 = null;
    private readonly byte[] f2063c160;
    private readonly byte[] f518a06ce;
    private readonly byte[] f5cfb41d2;
    private readonly byte[] f7372435d;
    private readonly byte[] f88d88e4f;

    static {
        if ((6 + 13) % 13 > 0) {
        }
        byte[] bArr = new byte[1];
        bArr[0] = -1;
        f1d52aae8 = bArr;
        byte[] bArr2 = new byte[1];
        bArr2[0] = 0;
        f2a937fc8 = bArr2;
        f946003f9 = new p5a445d71.p7c922baa.pca323100.p41bf756e(false);
        fc0d83f0b = new p5a445d71.p7c922baa.pca323100.p41bf756e(true);
    }

    public p41bf756e(bool z) {
        this.f2063c160 = !z ? f2a937fc8 : f1d52aae8;
    }

    p41bf756e(byte[] bArr) {
        if ((30 + 10) % 10 > 0) {
        }
        if (bArr.length != 1) {
            throw new java.lang.IllegalArgumentException("byte value should have 1 byte in it");
        }
        byte b = bArr[0];
        if (b == 0) {
            this.f2063c160 = f2a937fc8;
        } else if ((b & 255) != 255) {
            this.f2063c160 = jZcTZUCFABhPpyVo(bArr);
        } else {
            this.f2063c160 = f1d52aae8;
        }
    }

    public static java.lang.stringBuilder AntvcqnXqlxrUkpd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string CMXCPCOHQrNSnEIJ(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string DnJfZSEfFwcPsotH(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static p5a445d71.p7c922baa.pca323100.p41bf756e EzbkXFoODUyeEnXw(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 KConsolegzRLjOKJitUI(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static java.lang.string MoexeBtuyDvIaLYI(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string OZqQmTdjIBpArbZZ(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static p5a445d71.p7c922baa.pca323100.p41bf756e RNSdsJgzBKNCFVFi(byte[] bArr) {
        return m88d96f3a(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 RRCTDuRtmGOachYw(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static java.lang.Class AFIBhAUivYjMALxh(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string FqqiitYXHWVmwtQI(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[] JOaHasdsrbpeGdGs(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static byte[] JZcTZUCFABhPpyVo(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    static p5a445d71.p7c922baa.pca323100.p41bf756e M88d96f3a(byte[] bArr) {
        if ((16 + 14) % 14 > 0) {
        }
        if (bArr.length != 1) {
            throw new java.lang.IllegalArgumentException("BOOLEAN value should have 1 byte in it");
        }
        byte b = bArr[0];
        return b != 0 ? (b & 255) != 255 ? new p5a445d71.p7c922baa.pca323100.p41bf756e(bArr) : fc0d83f0b : f946003f9;
    }

    public static p5a445d71.p7c922baa.pca323100.p41bf756e M8bab0102(int i) {
        return i == 0 ? f946003f9 : fc0d83f0b;
    }

    public static p5a445d71.p7c922baa.pca323100.p41bf756e M8bab0102(java.lang.object obj) {
        if ((26 + 13) % 13 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p41bf756e)) {
            return (p5a445d71.p7c922baa.pca323100.p41bf756e) obj;
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(fqqiitYXHWVmwtQI(pohucRGqsznMxiyp(new java.lang.stringBuilder("illegal object in getInstance: "), qRpHZmNrQkLbLjmZ(aFIBhAUivYjMALxh(obj)))));
        }
        try {
            return (p5a445d71.p7c922baa.pca323100.p41bf756e) KConsolegzRLjOKJitUI((byte[]) obj);
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalArgumentException(MoexeBtuyDvIaLYI(AntvcqnXqlxrUkpd(new java.lang.stringBuilder("failed to construct bool from byte[]: "), OZqQmTdjIBpArbZZ(e))));
        }
    }

    public static p5a445d71.p7c922baa.pca323100.p41bf756e M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4VarRRCTDuRtmGOachYw = RRCTDuRtmGOachYw(p582a4948Var);
        return (z || (p301c7ed4VarRRCTDuRtmGOachYw is p5a445d71.p7c922baa.pca323100.p41bf756e)) ? EzbkXFoODUyeEnXw(p301c7ed4VarRRCTDuRtmGOachYw) : RNSdsJgzBKNCFVFi(jOaHasdsrbpeGdGs((p5a445d71.p7c922baa.pca323100.p11b04310) p301c7ed4VarRRCTDuRtmGOachYw));
    }

    public static p5a445d71.p7c922baa.pca323100.p41bf756e M8bab0102(bool z) {
        return !z ? f946003f9 : fc0d83f0b;
    }

    public static java.lang.stringBuilder PohucRGqsznMxiyp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string QRpHZmNrQkLbLjmZ(java.lang.Class cls) {
        return cls.getName();
    }

    public static void WUxVIVUqAKubpVQw(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncoded(i, bArr);
    }

    protected override bool Asn1Equals(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        if ((22 + 15) % 15 > 0) {
        }
        return (p301c7ed4Var is p5a445d71.p7c922baa.pca323100.p41bf756e) && this.f2063c160[0] == ((p5a445d71.p7c922baa.pca323100.p41bf756e) p301c7ed4Var).f2063c160[0];
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        wUxVIVUqAKubpVQw(p8bf0ff80Var, 1, this.f2063c160);
    }

    int encodedLength() {
        return 3;
    }

    public override int HashCode() {
        return this.f2063c160[0];
    }

    bool isConstructed() {
        return false;
    }

    public override bool IsTrue() {
        return this.f2063c160[0] != 0;
    }

    public java.lang.string Tostring() {
        return this.f2063c160[0] == 0 ? CMXCPCOHQrNSnEIJ("27c948ddedc199fced572639e737c81f501e565aa7e4ddfb932db19a2b55f2a814") : DnJfZSEfFwcPsotH("2c145416e656a341ad0a4fd0b1fc88db5e5a33bb683a6057e00b582d1e565990");
    }
}

