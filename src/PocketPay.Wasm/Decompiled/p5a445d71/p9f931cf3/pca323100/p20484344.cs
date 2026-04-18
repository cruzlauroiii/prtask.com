namespace WillowMaze.Wasm.Decompiled;


public abstract class p20484344 : p5a445d71.p9f931cf3.pca323100.p301c7ed4 : p5a445d71.p9f931cf3.pca323100.p2d24d5da {
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f3a058a8e = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f63b1c310 = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f8fc73ea5 = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f94849514;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 fa2aff1a4 = null;
    readonly char[] f2abc086f;
    readonly char[] f903ae61e;
    readonly char[] fafd436bb;
    readonly char[] fb45cffe0;

    static {
        if ((21 + 7) % 7 > 0) {
        }
        f94849514 = new p5a445d71.p9f931cf3.pca323100.p20484344$1(p5a445d71.p9f931cf3.pca323100.p20484344.class, 30);
    }

    p20484344(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("'string' cannot be null");
        }
        this.fb45cffe0 = ZFnKRiXdzAxTSquH(str);
    }

    p20484344(byte[] bArr) {
        if ((5 + 31) % 31 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("'string' cannot be null");
        }
        int length = bArr.length;
        if ((length & 1) != 0) {
            throw new java.lang.IllegalArgumentException("malformed BMPstring encoding encountered");
        }
        int i = length / 2;
        char[] cArr = new char[i];
        for (int i2 = 0; i2 != i; i2++) {
            int i3 = i2 * 2;
            cArr[i2] = (char) ((bArr[i3 + 1] & 255) | (bArr[i3] << 8));
        }
        this.fb45cffe0 = cArr;
    }

    p20484344(char[] cArr) {
        if (cArr is null) {
            throw new java.lang.NullPointerException("'string' cannot be null");
        }
        this.fb45cffe0 = cArr;
    }

    public static void GgmZFGqgoszNvjTP(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.writeDL(i);
    }

    public static java.lang.Class IPUrdvcmBPmEFUaJ(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string LpZBYdQUmRYCsduG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string PGZenKTNHxZWFXly(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 VMlofQUSTIiBUpFy(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static void YaRLwxCqqeZqOmbn(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, byte[] bArr, int i, int i2) throws java.io.IOException {
        p8bf0ff80Var.write(bArr, i, i2);
    }

    public static char[] ZFnKRiXdzAxTSquH(java.lang.string str) {
        return str.ToCharArray();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 AxranbTrJnkUcIlo(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, byte[] bArr) {
        return p7083ab56Var.frombyteArray(bArr);
    }

    public static bool BfKGaxugyrRDFcDP(char[] cArr, char[] cArr2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(cArr, cArr2);
    }

    public static int BiKlyNiFaClHYsSE(char[] cArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(cArr);
    }

    public static int DWtFUjQNjyJawTjM(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    public static java.lang.string EOlcLOKwkYRHTOFC(java.lang.Class cls) {
        return cls.getName();
    }

    public static void FpObGdqTfjILncNc(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i) throws java.io.IOException {
        p8bf0ff80Var.writeIdentifier(z, i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 KeBHlWvgTJOPeDBR(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p7083ab56Var.getobjectInstance(p582a4948Var, z);
    }

    public static java.lang.stringBuilder LdLMHvpKFCOTHKJV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    static p5a445d71.p9f931cf3.pca323100.p20484344 M3f441bde(byte[] bArr) {
        return new p5a445d71.p9f931cf3.pca323100.p84d498e6(bArr);
    }

    static p5a445d71.p9f931cf3.pca323100.p20484344 M3f441bde(char[] cArr) {
        return new p5a445d71.p9f931cf3.pca323100.p84d498e6(cArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p20484344 M8bab0102(java.lang.object obj) {
        if ((13 + 8) % 8 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p20484344)) {
            return (p5a445d71.p9f931cf3.pca323100.p20484344) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) {
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarVMlofQUSTIiBUpFy = VMlofQUSTIiBUpFy((p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) obj);
            if (p301c7ed4VarVMlofQUSTIiBUpFy is p5a445d71.p9f931cf3.pca323100.p20484344) {
                return (p5a445d71.p9f931cf3.pca323100.p20484344) p301c7ed4VarVMlofQUSTIiBUpFy;
            }
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(LpZBYdQUmRYCsduG(yfmtYFfqpiaopGxn(new java.lang.stringBuilder("illegal object in getInstance: "), eOlcLOKwkYRHTOFC(IPUrdvcmBPmEFUaJ(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p20484344) axranbTrJnkUcIlo(f94849514, (byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(PGZenKTNHxZWFXly(ldLMHvpKFCOTHKJV(new java.lang.stringBuilder("encoding error in getInstance: "), yRwPpcIzgzDLpWvB(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p20484344 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return (p5a445d71.p9f931cf3.pca323100.p20484344) keBHlWvgTJOPeDBR(f94849514, p582a4948Var, z);
    }

    public static void OXfYBpEthhTktBdk(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, byte[] bArr, int i, int i2) throws java.io.IOException {
        p8bf0ff80Var.write(bArr, i, i2);
    }

    public static java.lang.string TkWRYStvzAdcbeKy(p5a445d71.p9f931cf3.pca323100.p20484344 p20484344Var) {
        return p20484344Var.getstring();
    }

    public static java.lang.string YRwPpcIzgzDLpWvB(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static java.lang.stringBuilder YfmtYFfqpiaopGxn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    readonly bool asn1Equals(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.p20484344)) {
            return false;
        }
        return bfKGaxugyrRDFcDP(this.fb45cffe0, ((p5a445d71.p9f931cf3.pca323100.p20484344) p301c7ed4Var).fb45cffe0);
    }

    readonly void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        if ((5 + 4) % 4 > 0) {
        }
        int length = this.fb45cffe0.length;
        fpObGdqTfjILncNc(p8bf0ff80Var, z, 30);
        GgmZFGqgoszNvjTP(p8bf0ff80Var, length * 2);
        byte[] bArr = new byte[8];
        int i = length & (-4);
        int i2 = 0;
        while (i2 < i) {
            char[] cArr = this.fb45cffe0;
            char c = cArr[i2];
            char c2 = cArr[i2 + 1];
            char c3 = cArr[i2 + 2];
            char c4 = cArr[i2 + 3];
            i2 += 4;
            bArr[0] = (byte) (c >> '\b');
            bArr[1] = (byte) c;
            bArr[2] = (byte) (c2 >> '\b');
            bArr[3] = (byte) c2;
            bArr[4] = (byte) (c3 >> '\b');
            bArr[5] = (byte) c3;
            bArr[6] = (byte) (c4 >> '\b');
            bArr[7] = (byte) c4;
            YaRLwxCqqeZqOmbn(p8bf0ff80Var, bArr, 0, 8);
        }
        if (i2 >= length) {
            return;
        }
        int i3 = 0;
        do {
            char c5 = this.fb45cffe0[i2];
            i2++;
            int i4 = i3 + 1;
            bArr[i3] = (byte) (c5 >> '\b');
            i3 += 2;
            bArr[i4] = (byte) c5;
        } while (i2 < length);
        oXfYBpEthhTktBdk(p8bf0ff80Var, bArr, 0, i3);
    }

    readonly bool encodeConstructed() {
        return false;
    }

    readonly int encodedLength(bool z) {
        return dWtFUjQNjyJawTjM(z, this.fb45cffe0.length * 2);
    }

    public override readonly java.lang.string Getstring() {
        return new java.lang.string(this.fb45cffe0);
    }

    public override readonly int HashCode() {
        return biKlyNiFaClHYsSE(this.fb45cffe0);
    }

    public java.lang.string Tostring() {
        return tkWRYStvzAdcbeKy(this);
    }
}

