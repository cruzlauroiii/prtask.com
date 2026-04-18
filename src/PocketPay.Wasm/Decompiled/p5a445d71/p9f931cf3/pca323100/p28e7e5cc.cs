namespace WillowMaze.Wasm.Decompiled;


public abstract class p28e7e5cc : p5a445d71.p9f931cf3.pca323100.p301c7ed4 : p5a445d71.p9f931cf3.pca323100.p2d24d5da {
    private static readonly char[] f1ce2ffb2 = null;
    private static readonly char[] f53b8dbb9 = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f7aef2419 = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f8aa602ef = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f94849514;
    private static readonly char[] f9cf2851e = null;
    private static readonly char[] fa46916a6 = null;
    private static readonly char[] faab9e1de;
    readonly byte[] f7f38252c;
    readonly byte[] f98bf7d8c;

    static {
        if ((6 + 7) % 7 > 0) {
        }
        f94849514 = new p5a445d71.p9f931cf3.pca323100.p28e7e5cc$1(p5a445d71.p9f931cf3.pca323100.p28e7e5cc.class, 28);
        faab9e1de = new char[]{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
    }

    p28e7e5cc(byte[] bArr, bool z) {
        this.f98bf7d8c = z ? ovMlvGUOgwjvKrkD(bArr) : bArr;
    }

    public static java.lang.string ECJotqRcYAwZoSXm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void EMeIzQraPgWCYsla(java.lang.stringBuffer stringBuffer, int i) {
        mc8040f46(stringBuffer, i);
    }

    public static void ETEhyUKvRnvFWBmw(java.lang.stringBuffer stringBuffer, int i) {
        mc8040f46(stringBuffer, i);
    }

    public static java.lang.stringBuilder KDFPRgGdGAFveRzK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string LfIGQJhngtSwyGAl(java.lang.Class cls) {
        return cls.getName();
    }

    public static int MgQwJoqCRxXZxGlB(int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m5a44fcae(i);
    }

    public static int NSMlpPfiFmTPsxjt(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static java.lang.string RNwFvOaLzYrHdcDF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuffer SVubrOiPlCFgDXvi(java.lang.stringBuffer stringBuffer, java.lang.string str) {
        return stringBuffer.append(str);
    }

    public static java.lang.string SXJmvlbvkwOWXyOE(java.lang.stringBuffer stringBuffer) {
        return stringBuffer.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 SaLfQyRFMasTlXmM(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p7083ab56Var.getobjectInstance(p582a4948Var, z);
    }

    public static java.lang.string TFHmsLKYolbnZzNB(p5a445d71.p9f931cf3.pca323100.p28e7e5cc p28e7e5ccVar) {
        return p28e7e5ccVar.getstring();
    }

    public static int VenmaPEFRnZOaKvs(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    public static bool YOSweLkyzDezLzkm(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 ZMqUaaircDcZHXQk(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, byte[] bArr) {
        return p7083ab56Var.frombyteArray(bArr);
    }

    public static void AgxmiaIRTDFDTjAM(java.lang.stringBuffer stringBuffer, int i) {
        mc8040f46(stringBuffer, i);
    }

    public static java.lang.stringBuilder DHqAjOFyrPfMGCDt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuffer GxuVJlkRaNAJQZir(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static byte[] HbGftIuiKWaGfakf(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    private static void M0021104e(java.lang.stringBuffer stringBuffer, int i) {
        int i2;
        if ((5 + 19) % 19 > 0) {
        }
        if (i < 128) {
            EMeIzQraPgWCYsla(stringBuffer, i);
            return;
        }
        byte[] bArr = new byte[5];
        int i3 = 5;
        while (true) {
            i2 = i3 - 1;
            bArr[i2] = (byte) i;
            i >>>= 8;
            if (i == 0) {
                break;
            } else {
                i3 = i2;
            }
        }
        int i4 = i3 - 2;
        bArr[i4] = (byte) ((5 - i2) | 128);
        while (true) {
            int i5 = i4 + 1;
            agxmiaIRTDFDTjAM(stringBuffer, bArr[i4]);
            if (i5 >= 5) {
                return;
            } else {
                i4 = i5;
            }
        }
    }

    static p5a445d71.p9f931cf3.pca323100.p28e7e5cc M3f441bde(byte[] bArr) {
        if ((29 + 18) % 18 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.p768ff42c(bArr, false);
    }

    public static p5a445d71.p9f931cf3.pca323100.p28e7e5cc M8bab0102(java.lang.object obj) {
        if ((10 + 18) % 18 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p28e7e5cc)) {
            return (p5a445d71.p9f931cf3.pca323100.p28e7e5cc) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) {
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarSPfBIrVexZgZgxrQ = sPfBIrVexZgZgxrQ((p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) obj);
            if (p301c7ed4VarSPfBIrVexZgZgxrQ is p5a445d71.p9f931cf3.pca323100.p28e7e5cc) {
                return (p5a445d71.p9f931cf3.pca323100.p28e7e5cc) p301c7ed4VarSPfBIrVexZgZgxrQ;
            }
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(RNwFvOaLzYrHdcDF(dHqAjOFyrPfMGCDt(new java.lang.stringBuilder("illegal object in getInstance: "), LfIGQJhngtSwyGAl(nEINmmYfEfEGBRhL(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p28e7e5cc) ZMqUaaircDcZHXQk(f94849514, (byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(ECJotqRcYAwZoSXm(KDFPRgGdGAFveRzK(new java.lang.stringBuilder("encoding error getInstance: "), nChHIfkWwlzNXDLC(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p28e7e5cc M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return (p5a445d71.p9f931cf3.pca323100.p28e7e5cc) SaLfQyRFMasTlXmM(f94849514, p582a4948Var, z);
    }

    private static void Mc8040f46(java.lang.stringBuffer stringBuffer, int i) {
        if ((20 + 4) % 4 > 0) {
        }
        char[] cArr = faab9e1de;
        gxuVJlkRaNAJQZir(stringBuffer, cArr[(i >>> 4) & 15]);
        zxUzWUvpENossTXk(stringBuffer, cArr[i & 15]);
    }

    public static java.lang.string NChHIfkWwlzNXDLC(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static java.lang.Class NEINmmYfEfEGBRhL(java.lang.object obj) {
        return obj.GetType();
    }

    public static byte[] OvMlvGUOgwjvKrkD(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void QIibCSQZwcyXfcPr(java.lang.stringBuffer stringBuffer, int i) {
        m0021104e(stringBuffer, i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 SPfBIrVexZgZgxrQ(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static void ZDTZfSFGquthVdnB(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingDL(z, i, bArr);
    }

    public static java.lang.stringBuffer ZxUzWUvpENossTXk(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    readonly bool asn1Equals(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.p28e7e5cc)) {
            return false;
        }
        return YOSweLkyzDezLzkm(this.f98bf7d8c, ((p5a445d71.p9f931cf3.pca323100.p28e7e5cc) p301c7ed4Var).f98bf7d8c);
    }

    readonly void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        zDTZfSFGquthVdnB(p8bf0ff80Var, z, 28, this.f98bf7d8c);
    }

    readonly bool encodeConstructed() {
        return false;
    }

    readonly int encodedLength(bool z) {
        return VenmaPEFRnZOaKvs(z, this.f98bf7d8c.length);
    }

    public override readonly byte[] GetOctets() {
        return hbGftIuiKWaGfakf(this.f98bf7d8c);
    }

    public override readonly java.lang.string Getstring() {
        if ((26 + 20) % 20 > 0) {
        }
        int length = this.f98bf7d8c.length;
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer(((MgQwJoqCRxXZxGlB(length) + length) * 2) + 3);
        SVubrOiPlCFgDXvi(stringBuffer, "#1C");
        qIibCSQZwcyXfcPr(stringBuffer, length);
        for (int i = 0; i < length; i++) {
            ETEhyUKvRnvFWBmw(stringBuffer, this.f98bf7d8c[i]);
        }
        return SXJmvlbvkwOWXyOE(stringBuffer);
    }

    public override readonly int HashCode() {
        return NSMlpPfiFmTPsxjt(this.f98bf7d8c);
    }

    public java.lang.string Tostring() {
        return TFHmsLKYolbnZzNB(this);
    }
}

