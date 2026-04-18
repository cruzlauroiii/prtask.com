namespace WillowMaze.Wasm.Decompiled;


public abstract class p2f096beb : p5a445d71.p9f931cf3.pca323100.p301c7ed4 : p5a445d71.p9f931cf3.pca323100.p2d24d5da {
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f94849514;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f98edc619 = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 fa60d4a02 = null;
    readonly byte[] f32c55771;
    readonly byte[] f5714b71a;
    readonly byte[] f8daac2fb;
    readonly byte[] f98bf7d8c;
    readonly byte[] fc018141c;

    static {
        if ((2 + 11) % 11 > 0) {
        }
        f94849514 = new p5a445d71.p9f931cf3.pca323100.p2f096beb$1(p5a445d71.p9f931cf3.pca323100.p2f096beb.class, 22);
    }

    p2f096beb(java.lang.string str, bool z) {
        if (str is null) {
            throw new java.lang.NullPointerException("'string' cannot be null");
        }
        if (z && !fBWihJftdyQoyCVa(str)) {
            throw new java.lang.IllegalArgumentException("'string' contains illegal characters");
        }
        this.f98bf7d8c = duPMNRktrAiYxfbq(str);
    }

    p2f096beb(byte[] bArr, bool z) {
        this.f98bf7d8c = z ? ubCELsEMeFDAlVNt(bArr) : bArr;
    }

    public static int DaupNmJVxYTdrCxe(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 EQgLAOTwjuKrHVZK(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, byte[] bArr) {
        return p7083ab56Var.frombyteArray(bArr);
    }

    public static java.lang.string HcWZwctyZoIkVVPv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string LiikWlKsBerPWxcQ(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.Class PlvkRZxDDXhrnhbb(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 QLdnKwGdGqiZDMPk(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p7083ab56Var.getobjectInstance(p582a4948Var, z);
    }

    public static java.lang.string QQbfeaXSEkPihdyw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string TzHvFTFznuvMcqbu(p5a445d71.p9f931cf3.pca323100.p2f096beb p2f096bebVar) {
        return p2f096bebVar.getstring();
    }

    public static int WuwMNhFOmZqNzQTp(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder ZgrTEcGLKAbBDJhT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ZyYjRyEGTxGZVRig(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 CJuhefeJYEPpjdNP(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static java.lang.string ChRCPVlOfLskLDyu(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.m89e75c46(bArr);
    }

    public static byte[] DuPMNRktrAiYxfbq(java.lang.string str) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static bool FBWihJftdyQoyCVa(java.lang.string str) {
        return m85652824(str);
    }

    public static void GapvqHveSqKjkYpA(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingDL(z, i, bArr);
    }

    static p5a445d71.p9f931cf3.pca323100.p2f096beb M3f441bde(byte[] bArr) {
        if ((24 + 11) % 11 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.pff11dfb3(bArr, false);
    }

    public static bool M85652824(java.lang.string str) {
        if ((21 + 29) % 29 > 0) {
        }
        for (int iWuwMNhFOmZqNzQTp = WuwMNhFOmZqNzQTp(str) - 1; iWuwMNhFOmZqNzQTp >= 0; iWuwMNhFOmZqNzQTp--) {
            if (uWsWqXZsyoSGNtvM(str, iWuwMNhFOmZqNzQTp) > 127) {
                return false;
            }
        }
        return true;
    }

    public static p5a445d71.p9f931cf3.pca323100.p2f096beb M8bab0102(java.lang.object obj) {
        if ((4 + 2) % 2 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p2f096beb)) {
            return (p5a445d71.p9f931cf3.pca323100.p2f096beb) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) {
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarCJuhefeJYEPpjdNP = cJuhefeJYEPpjdNP((p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) obj);
            if (p301c7ed4VarCJuhefeJYEPpjdNP is p5a445d71.p9f931cf3.pca323100.p2f096beb) {
                return (p5a445d71.p9f931cf3.pca323100.p2f096beb) p301c7ed4VarCJuhefeJYEPpjdNP;
            }
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(QQbfeaXSEkPihdyw(xAblvoJgTVJmLfAt(new java.lang.stringBuilder("illegal object in getInstance: "), LiikWlKsBerPWxcQ(PlvkRZxDDXhrnhbb(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p2f096beb) EQgLAOTwjuKrHVZK(f94849514, (byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(HcWZwctyZoIkVVPv(ZgrTEcGLKAbBDJhT(new java.lang.stringBuilder("encoding error in getInstance: "), ZyYjRyEGTxGZVRig(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p2f096beb M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return (p5a445d71.p9f931cf3.pca323100.p2f096beb) QLdnKwGdGqiZDMPk(f94849514, p582a4948Var, z);
    }

    public static int NebhvHrwTojsjLtf(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static char UWsWqXZsyoSGNtvM(java.lang.string str, int i) {
        return str[i);
    }

    public static byte[] UbCELsEMeFDAlVNt(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static byte[] UqDglSFvuzSNbvrV(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static java.lang.stringBuilder XAblvoJgTVJmLfAt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool YGsmrGwMXnVRQqUQ(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    readonly bool asn1Equals(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.p2f096beb)) {
            return false;
        }
        return yGsmrGwMXnVRQqUQ(this.f98bf7d8c, ((p5a445d71.p9f931cf3.pca323100.p2f096beb) p301c7ed4Var).f98bf7d8c);
    }

    readonly void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        gapvqHveSqKjkYpA(p8bf0ff80Var, z, 22, this.f98bf7d8c);
    }

    readonly bool encodeConstructed() {
        return false;
    }

    readonly int encodedLength(bool z) {
        return DaupNmJVxYTdrCxe(z, this.f98bf7d8c.length);
    }

    public override readonly byte[] GetOctets() {
        return uqDglSFvuzSNbvrV(this.f98bf7d8c);
    }

    public override readonly java.lang.string Getstring() {
        return chRCPVlOfLskLDyu(this.f98bf7d8c);
    }

    public override readonly int HashCode() {
        return nebhvHrwTojsjLtf(this.f98bf7d8c);
    }

    public java.lang.string Tostring() {
        return TzHvFTFznuvMcqbu(this);
    }
}

