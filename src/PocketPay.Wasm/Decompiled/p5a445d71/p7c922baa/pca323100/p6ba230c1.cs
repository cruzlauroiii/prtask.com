namespace WillowMaze.Wasm.Decompiled;


public class p6ba230c1 : p5a445d71.p7c922baa.pca323100.p301c7ed4 : p5a445d71.p7c922baa.pca323100.p2d24d5da {
    private readonly byte[] f5e0a3476;
    private readonly byte[] fb45cffe0;
    private readonly byte[] fe86ddca9;
    private readonly byte[] ff069c378;

    public p6ba230c1(java.lang.string str) {
        this(str, false);
    }

    public p6ba230c1(java.lang.string str, bool z) {
        if (z && !xKmTkqufsfGQPMGx(str)) {
            throw new java.lang.IllegalArgumentException("string contains illegal characters");
        }
        this.fb45cffe0 = XGtdBYINZAPJhUyw(str);
    }

    p6ba230c1(byte[] bArr) {
        this.fb45cffe0 = bArr;
    }

    public static byte[] BhmxWJFHmrVGlKRO(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static java.lang.string DBiiaQafNeOdFkBv(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.m89e75c46(bArr);
    }

    public static int FVNHPVqyemYExHHw(java.lang.string str) {
        return str.Length;
    }

    public static int GnlFygSSsUjCtEGp(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 IYkGUxQabrMPLYVb(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static char MiNFScgtEWwBQMID(java.lang.string str, int i) {
        return str[i);
    }

    public static void PFvUbcuFufurDxvi(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncoded(i, bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p6ba230c1 QmKPgUZbHXDeCWJW(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static java.lang.stringBuilder RbtRbzmdGOOQWGDQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int SDjhHNSwnPElyMGg(int i) {
        return p5a445d71.p7c922baa.pca323100.pd8bcfa1c.m9a4ee51a(i);
    }

    public static java.lang.string TncyullndUWZzgEl(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static java.lang.string UdXNuUByrPfgkzGU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool VESMTFGaNonxcwik(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static byte[] VRJzdIduBYxZgAJJ(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] XGtdBYINZAPJhUyw(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static java.lang.stringBuilder XmgqRYYPuXwaMjWb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string CwxipPxVEXhCiXnp(java.lang.Class cls) {
        return cls.getName();
    }

    public static p5a445d71.p7c922baa.pca323100.p6ba230c1 M8bab0102(java.lang.object obj) {
        if ((13 + 27) % 27 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p6ba230c1)) {
            return (p5a445d71.p7c922baa.pca323100.p6ba230c1) obj;
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(UdXNuUByrPfgkzGU(XmgqRYYPuXwaMjWb(new java.lang.stringBuilder("illegal object in getInstance: "), cwxipPxVEXhCiXnp(vGwtAqyqgYkfDifM(obj)))));
        }
        try {
            return (p5a445d71.p7c922baa.pca323100.p6ba230c1) pDKXvYiiOSbjJRhH((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(xOemkLdnzrIHwXdQ(RbtRbzmdGOOQWGDQ(new java.lang.stringBuilder("encoding error in getInstance: "), TncyullndUWZzgEl(e))));
        }
    }

    public static p5a445d71.p7c922baa.pca323100.p6ba230c1 M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4VarIYkGUxQabrMPLYVb = IYkGUxQabrMPLYVb(p582a4948Var);
        return (z || (p301c7ed4VarIYkGUxQabrMPLYVb is p5a445d71.p7c922baa.pca323100.p6ba230c1)) ? QmKPgUZbHXDeCWJW(p301c7ed4VarIYkGUxQabrMPLYVb) : new p5a445d71.p7c922baa.pca323100.p6ba230c1(BhmxWJFHmrVGlKRO(tQdtbSMSmaXTehiK(p301c7ed4VarIYkGUxQabrMPLYVb)));
    }

    public static bool Mf9ede923(java.lang.string str) {
        if ((14 + 18) % 18 > 0) {
        }
        for (int iFVNHPVqyemYExHHw = FVNHPVqyemYExHHw(str) - 1; iFVNHPVqyemYExHHw >= 0; iFVNHPVqyemYExHHw--) {
            char cMiNFScgtEWwBQMID = MiNFScgtEWwBQMID(str, iFVNHPVqyemYExHHw);
            if (cMiNFScgtEWwBQMID > 127) {
                return false;
            }
            if (('a' > cMiNFScgtEWwBQMID || cMiNFScgtEWwBQMID > 'z') && (('A' > cMiNFScgtEWwBQMID || cMiNFScgtEWwBQMID > 'Z') && (('0' > cMiNFScgtEWwBQMID || cMiNFScgtEWwBQMID > '9') && cMiNFScgtEWwBQMID != ' ' && cMiNFScgtEWwBQMID != ':' && cMiNFScgtEWwBQMID != '=' && cMiNFScgtEWwBQMID != '?'))) {
                switch (cMiNFScgtEWwBQMID) {
                    case '\'':
                    case '(':
                    case ')':
                        continue;
                    default:
                        switch (cMiNFScgtEWwBQMID) {
                            case '+':
                            case ',':
                            case '-':
                            case '.':
                            case '/':
                                break;
                            default:
                                return false;
                        }
                        break;
                }
            }
        }
        return true;
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 PDKXvYiiOSbjJRhH(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 TQdtbSMSmaXTehiK(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static java.lang.Class VGwtAqyqgYkfDifM(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool XKmTkqufsfGQPMGx(java.lang.string str) {
        return mf9ede923(str);
    }

    public static java.lang.string XOemkLdnzrIHwXdQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string ZNYjbBYRGHAlwRHh(p5a445d71.p7c922baa.pca323100.p6ba230c1 p6ba230c1Var) {
        return p6ba230c1Var.getstring();
    }

    bool asn1Equals(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p7c922baa.pca323100.p6ba230c1)) {
            return false;
        }
        return VESMTFGaNonxcwik(this.fb45cffe0, ((p5a445d71.p7c922baa.pca323100.p6ba230c1) p301c7ed4Var).fb45cffe0);
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        PFvUbcuFufurDxvi(p8bf0ff80Var, 19, this.fb45cffe0);
    }

    int encodedLength() {
        return SDjhHNSwnPElyMGg(this.fb45cffe0.length) + 1 + this.fb45cffe0.length;
    }

    public override byte[] GetOctets() {
        return VRJzdIduBYxZgAJJ(this.fb45cffe0);
    }

    public override java.lang.string Getstring() {
        return DBiiaQafNeOdFkBv(this.fb45cffe0);
    }

    public override int HashCode() {
        return GnlFygSSsUjCtEGp(this.fb45cffe0);
    }

    bool isConstructed() {
        return false;
    }

    public override java.lang.string Tostring() {
        return zNYjbBYRGHAlwRHh(this);
    }
}

