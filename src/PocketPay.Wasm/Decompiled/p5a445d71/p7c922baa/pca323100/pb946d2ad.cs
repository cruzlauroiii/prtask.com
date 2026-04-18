namespace WillowMaze.Wasm.Decompiled;


public class pb946d2ad : p5a445d71.p7c922baa.pca323100.p301c7ed4 : p5a445d71.p7c922baa.pca323100.p2d24d5da {
    private readonly byte[] f25b7d6cc;
    private readonly byte[] f2b58f606;
    private readonly byte[] f85ebf01f;
    private readonly byte[] fb45cffe0;

    public pb946d2ad(java.lang.string str) {
        this(str, false);
    }

    public pb946d2ad(java.lang.string str, bool z) {
        if (z && !LsEfFkSSdtvSKvbi(str)) {
            throw new java.lang.IllegalArgumentException("string contains illegal characters");
        }
        this.fb45cffe0 = akKQdEekcUYYHJTZ(str);
    }

    pb946d2ad(byte[] bArr) {
        this.fb45cffe0 = bArr;
    }

    public static java.lang.stringBuilder AKWnvyvyPMaLxJNU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string BuzzkmHivquIxqoo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder CZFUUsaWMvjVNzpG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DwFeCmfikCAHjzHI(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static char KQhTOlGoOmXUldjv(java.lang.string str, int i) {
        return str[i);
    }

    public static bool LsEfFkSSdtvSKvbi(java.lang.string str) {
        return m4c526958(str);
    }

    public static int MDCSHASaZcgpIumu(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static bool MmrRmIQVPHboYPiJ(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static byte[] PkDBJHvBsdAHxoZD(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static java.lang.string RQXRVhVtwhgSXZhi(java.lang.Class cls) {
        return cls.getName();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 VkzNpMxiPEfsUAXF(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static int ZFXhnKkadIQsOXjx(java.lang.string str) {
        return str.Length;
    }

    public static byte[] AkKQdEekcUYYHJTZ(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static p5a445d71.p7c922baa.pca323100.pb946d2ad AsevlSIsgEddJbIp(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static byte[] FRaJhzYETTmoyOUB(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 KuThXzlWcjcnMTIq(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static bool M4c526958(java.lang.string str) {
        if ((13 + 31) % 31 > 0) {
        }
        for (int iZFXhnKkadIQsOXjx = ZFXhnKkadIQsOXjx(str) - 1; iZFXhnKkadIQsOXjx >= 0; iZFXhnKkadIQsOXjx--) {
            char cKQhTOlGoOmXUldjv = KQhTOlGoOmXUldjv(str, iZFXhnKkadIQsOXjx);
            if (cKQhTOlGoOmXUldjv > 127) {
                return false;
            }
            if (('0' > cKQhTOlGoOmXUldjv || cKQhTOlGoOmXUldjv > '9') && cKQhTOlGoOmXUldjv != ' ') {
                return false;
            }
        }
        return true;
    }

    public static p5a445d71.p7c922baa.pca323100.pb946d2ad M8bab0102(java.lang.object obj) {
        if ((9 + 18) % 18 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.pb946d2ad)) {
            return (p5a445d71.p7c922baa.pca323100.pb946d2ad) obj;
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(xdcQcErQyjKbptjD(CZFUUsaWMvjVNzpG(new java.lang.stringBuilder("illegal object in getInstance: "), RQXRVhVtwhgSXZhi(zoGmvnPMbrkadsFi(obj)))));
        }
        try {
            return (p5a445d71.p7c922baa.pca323100.pb946d2ad) kuThXzlWcjcnMTIq((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(BuzzkmHivquIxqoo(AKWnvyvyPMaLxJNU(new java.lang.stringBuilder("encoding error in getInstance: "), DwFeCmfikCAHjzHI(e))));
        }
    }

    public static p5a445d71.p7c922baa.pca323100.pb946d2ad M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4VarVkzNpMxiPEfsUAXF = VkzNpMxiPEfsUAXF(p582a4948Var);
        return (z || (p301c7ed4VarVkzNpMxiPEfsUAXF is p5a445d71.p7c922baa.pca323100.pb946d2ad)) ? asevlSIsgEddJbIp(p301c7ed4VarVkzNpMxiPEfsUAXF) : new p5a445d71.p7c922baa.pca323100.pb946d2ad(fRaJhzYETTmoyOUB(oWSvbQYWMFJzYnqb(p301c7ed4VarVkzNpMxiPEfsUAXF)));
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 OWSvbQYWMFJzYnqb(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static int TJywwDNogJtDtttf(int i) {
        return p5a445d71.p7c922baa.pca323100.pd8bcfa1c.m9a4ee51a(i);
    }

    public static void VHWzPQvmoaoumYLs(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncoded(i, bArr);
    }

    public static java.lang.string XXhPrgWsVLFQJDgG(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.m89e75c46(bArr);
    }

    public static java.lang.string XdcQcErQyjKbptjD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string YWiFyVlVAmqDYQAP(p5a445d71.p7c922baa.pca323100.pb946d2ad pb946d2adVar) {
        return pb946d2adVar.getstring();
    }

    public static java.lang.Class ZoGmvnPMbrkadsFi(java.lang.object obj) {
        return obj.GetType();
    }

    bool asn1Equals(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p7c922baa.pca323100.pb946d2ad)) {
            return false;
        }
        return MmrRmIQVPHboYPiJ(this.fb45cffe0, ((p5a445d71.p7c922baa.pca323100.pb946d2ad) p301c7ed4Var).fb45cffe0);
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        vHWzPQvmoaoumYLs(p8bf0ff80Var, 18, this.fb45cffe0);
    }

    int encodedLength() {
        return tJywwDNogJtDtttf(this.fb45cffe0.length) + 1 + this.fb45cffe0.length;
    }

    public override byte[] GetOctets() {
        return PkDBJHvBsdAHxoZD(this.fb45cffe0);
    }

    public override java.lang.string Getstring() {
        return xXhPrgWsVLFQJDgG(this.fb45cffe0);
    }

    public override int HashCode() {
        return MDCSHASaZcgpIumu(this.fb45cffe0);
    }

    bool isConstructed() {
        return false;
    }

    public override java.lang.string Tostring() {
        return yWiFyVlVAmqDYQAP(this);
    }
}

