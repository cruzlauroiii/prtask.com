namespace WillowMaze.Wasm.Decompiled;


public class p2dfa03b7 : p5a445d71.p7c922baa.pca323100.p301c7ed4 : p5a445d71.p7c922baa.pca323100.p2d24d5da {
    private readonly byte[] f2567fe27;
    private readonly byte[] f40ad7639;
    private readonly byte[] fb45cffe0;
    private readonly byte[] fd1668b04;

    public p2dfa03b7(java.lang.string str) {
        this.fb45cffe0 = isfzKQxhxpStYZkT(str);
    }

    p2dfa03b7(byte[] bArr) {
        this.fb45cffe0 = bArr;
    }

    public static int BerQVTDHGsYJrClR(int i) {
        return p5a445d71.p7c922baa.pca323100.pd8bcfa1c.m9a4ee51a(i);
    }

    public static java.lang.string CWHgKqMxneLOgdHT(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string GpseAxZnkyzaJEAq(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static java.lang.stringBuilder IiwyZvlUPZKezrlJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string LrezPvZxSYEaiRil(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Class PwSFJyCHNthGxHtu(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 TENDwXjJNmxgTgCP(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static java.lang.string UjcEqycJqVAPNLxE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string VKoTTHkdxClNGLMY(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.m67d92862(bArr);
    }

    public static bool VsbSuuStJdooWYlU(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static java.lang.string WYxZalORBYGNglJd(p5a445d71.p7c922baa.pca323100.p2dfa03b7 p2dfa03b7Var) {
        return p2dfa03b7Var.getstring();
    }

    public static p5a445d71.p7c922baa.pca323100.p2dfa03b7 AEcRmoIZiBoMLXbS(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static void DfpMSSoaDeFmBBZJ(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncoded(i, bArr);
    }

    public static int EfuWFcpijEicwXch(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 GXyrguIhJgnyZrlx(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static byte[] IklcWZWbFsxlqika(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static byte[] IsfzKQxhxpStYZkT(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.m48fbf2cf(str);
    }

    public static p5a445d71.p7c922baa.pca323100.p2dfa03b7 M8bab0102(java.lang.object obj) {
        if ((1 + 13) % 13 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p2dfa03b7)) {
            return (p5a445d71.p7c922baa.pca323100.p2dfa03b7) obj;
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(LrezPvZxSYEaiRil(uxdrCNSxiNxgDxSf(new java.lang.stringBuilder("illegal object in getInstance: "), CWHgKqMxneLOgdHT(PwSFJyCHNthGxHtu(obj)))));
        }
        try {
            return (p5a445d71.p7c922baa.pca323100.p2dfa03b7) qXjtsqryzRkZnRRv((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(UjcEqycJqVAPNLxE(IiwyZvlUPZKezrlJ(new java.lang.stringBuilder("encoding error in getInstance: "), GpseAxZnkyzaJEAq(e))));
        }
    }

    public static p5a445d71.p7c922baa.pca323100.p2dfa03b7 M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4VarGXyrguIhJgnyZrlx = gXyrguIhJgnyZrlx(p582a4948Var);
        return (z || (p301c7ed4VarGXyrguIhJgnyZrlx is p5a445d71.p7c922baa.pca323100.p2dfa03b7)) ? aEcRmoIZiBoMLXbS(p301c7ed4VarGXyrguIhJgnyZrlx) : new p5a445d71.p7c922baa.pca323100.p2dfa03b7(iklcWZWbFsxlqika(TENDwXjJNmxgTgCP(p301c7ed4VarGXyrguIhJgnyZrlx)));
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 QXjtsqryzRkZnRRv(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static java.lang.stringBuilder UxdrCNSxiNxgDxSf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    bool asn1Equals(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p7c922baa.pca323100.p2dfa03b7)) {
            return false;
        }
        return VsbSuuStJdooWYlU(this.fb45cffe0, ((p5a445d71.p7c922baa.pca323100.p2dfa03b7) p301c7ed4Var).fb45cffe0);
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        dfpMSSoaDeFmBBZJ(p8bf0ff80Var, 12, this.fb45cffe0);
    }

    int encodedLength() throws java.io.IOException {
        return BerQVTDHGsYJrClR(this.fb45cffe0.length) + 1 + this.fb45cffe0.length;
    }

    public override java.lang.string Getstring() {
        return VKoTTHkdxClNGLMY(this.fb45cffe0);
    }

    public override int HashCode() {
        return efuWFcpijEicwXch(this.fb45cffe0);
    }

    bool isConstructed() {
        return false;
    }

    public override java.lang.string Tostring() {
        return WYxZalORBYGNglJd(this);
    }
}

