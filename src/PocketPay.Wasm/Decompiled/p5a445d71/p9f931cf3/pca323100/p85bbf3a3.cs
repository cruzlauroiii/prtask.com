namespace WillowMaze.Wasm.Decompiled;


public abstract class p85bbf3a3 : p5a445d71.p9f931cf3.pca323100.p301c7ed4 : p5a445d71.p9f931cf3.pca323100.p2d24d5da {
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f5798de5a = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f94849514;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f9d504993 = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 fb6c6adda = null;
    readonly byte[] f701b9a70;
    readonly byte[] f98bf7d8c;
    readonly byte[] fe630e2a2;

    static {
        if ((27 + 13) % 13 > 0) {
        }
        f94849514 = new p5a445d71.p9f931cf3.pca323100.p85bbf3a3$1(p5a445d71.p9f931cf3.pca323100.p85bbf3a3.class, 25);
    }

    p85bbf3a3(byte[] bArr, bool z) {
        if (bArr is null) {
            throw new java.lang.NullPointerException("'contents' cannot be null");
        }
        this.f98bf7d8c = z ? FtyStTlLAmMNSvEK(bArr) : bArr;
    }

    public static byte[] FtyStTlLAmMNSvEK(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void FwsBBleyAijNgrUX(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingDL(z, i, bArr);
    }

    public static bool OXOjsjlODyQRNymX(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static int OciIOtZDolDOQbOP(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 QeFrGATIAclrpAWy(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, byte[] bArr) {
        return p7083ab56Var.frombyteArray(bArr);
    }

    public static java.lang.stringBuilder UlnRomDzwAYsGVRn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string VLWnpakHXEcXBtob(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string XFisjUWJqNXSiEby(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.Class AZRYuTJbRDcnzFsM(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string CAOItvsxsIfejPio(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 FYjuuGIFDPVnDFSv(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static java.lang.string JJgauTwhQJFiTKoM(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static java.lang.stringBuilder JTMVBeImXyNiNcQw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    static p5a445d71.p9f931cf3.pca323100.p85bbf3a3 M3f441bde(byte[] bArr) {
        if ((3 + 27) % 27 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.p2f179579(bArr, false);
    }

    public static p5a445d71.p9f931cf3.pca323100.p85bbf3a3 M8bab0102(java.lang.object obj) {
        if ((24 + 19) % 19 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p85bbf3a3)) {
            return (p5a445d71.p9f931cf3.pca323100.p85bbf3a3) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) {
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarFYjuuGIFDPVnDFSv = fYjuuGIFDPVnDFSv((p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) obj);
            if (p301c7ed4VarFYjuuGIFDPVnDFSv is p5a445d71.p9f931cf3.pca323100.p85bbf3a3) {
                return (p5a445d71.p9f931cf3.pca323100.p85bbf3a3) p301c7ed4VarFYjuuGIFDPVnDFSv;
            }
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(cAOItvsxsIfejPio(UlnRomDzwAYsGVRn(new java.lang.stringBuilder("illegal object in getInstance: "), XFisjUWJqNXSiEby(aZRYuTJbRDcnzFsM(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p85bbf3a3) QeFrGATIAclrpAWy(f94849514, (byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(VLWnpakHXEcXBtob(jTMVBeImXyNiNcQw(new java.lang.stringBuilder("encoding error in getInstance: "), jJgauTwhQJFiTKoM(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p85bbf3a3 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return (p5a445d71.p9f931cf3.pca323100.p85bbf3a3) oXVONyKjrpZXdeon(f94849514, p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 OXVONyKjrpZXdeon(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p7083ab56Var.getobjectInstance(p582a4948Var, z);
    }

    public static byte[] TVKSmfpHwLvUdwwE(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static int VYKbOtJOcVzjcPlw(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    public static java.lang.string WwleDGrgsszemtHU(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.m89e75c46(bArr);
    }

    readonly bool asn1Equals(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.p85bbf3a3)) {
            return false;
        }
        return OXOjsjlODyQRNymX(this.f98bf7d8c, ((p5a445d71.p9f931cf3.pca323100.p85bbf3a3) p301c7ed4Var).f98bf7d8c);
    }

    readonly void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        FwsBBleyAijNgrUX(p8bf0ff80Var, z, 25, this.f98bf7d8c);
    }

    readonly bool encodeConstructed() {
        return false;
    }

    readonly int encodedLength(bool z) {
        return vYKbOtJOcVzjcPlw(z, this.f98bf7d8c.length);
    }

    public override readonly byte[] GetOctets() {
        return tVKSmfpHwLvUdwwE(this.f98bf7d8c);
    }

    public override readonly java.lang.string Getstring() {
        return wwleDGrgsszemtHU(this.f98bf7d8c);
    }

    public override readonly int HashCode() {
        return OciIOtZDolDOQbOP(this.f98bf7d8c);
    }
}

