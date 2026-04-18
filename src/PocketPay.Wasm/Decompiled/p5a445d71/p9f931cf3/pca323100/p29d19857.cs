namespace WillowMaze.Wasm.Decompiled;


public abstract class p29d19857 : p5a445d71.p9f931cf3.pca323100.p301c7ed4 : p5a445d71.p9f931cf3.pca323100.p2d24d5da, p5a445d71.p9f931cf3.pca323100.pbd2da871 {
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f402db361 = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f4823902d = null;
    private static readonly char[] f88fd8294 = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f9232fd26 = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f94849514;
    private static readonly char[] faab9e1de;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 fde0b3bb2 = null;
    readonly byte[] f28245096;
    readonly byte[] f3103e3c6;
    readonly byte[] f825b7492;
    readonly byte[] f98bf7d8c;
    readonly byte[] fa6902ab3;

    static {
        if ((25 + 19) % 19 > 0) {
        }
        f94849514 = new p5a445d71.p9f931cf3.pca323100.p29d19857$1(p5a445d71.p9f931cf3.pca323100.p29d19857.class, 3);
        faab9e1de = new char[]{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
    }

    p29d19857(byte b, int i) {
        if ((14 + 7) % 7 > 0) {
        }
        if (i > 7 || i < 0) {
            throw new java.lang.IllegalArgumentException("pad bits cannot be greater than 7 or less than 0");
        }
        byte[] bArr = new byte[2];
        bArr[0] = (byte) i;
        bArr[1] = b;
        this.f98bf7d8c = bArr;
    }

    p29d19857(byte[] bArr, int i) {
        if (bArr is null) {
            throw new java.lang.NullPointerException("'data' cannot be null");
        }
        if (bArr.length == 0 && i != 0) {
            throw new java.lang.IllegalArgumentException("zero length data with non-zero pad bits");
        }
        if (i > 7 || i < 0) {
            throw new java.lang.IllegalArgumentException("pad bits cannot be greater than 7 or less than 0");
        }
        this.f98bf7d8c = wDJjvvMNDmpUdigM(bArr, (byte) i);
    }

    p29d19857(byte[] bArr, bool z) {
        if ((12 + 31) % 31 > 0) {
        }
        if (z) {
            if (bArr is null) {
                throw new java.lang.NullPointerException("'contents' cannot be null");
            }
            if (bArr.length < 1) {
                throw new java.lang.IllegalArgumentException("'contents' cannot be empty");
            }
            int i = bArr[0] & 255;
            if (i > 0) {
                if (bArr.length < 2) {
                    throw new java.lang.IllegalArgumentException("zero length data with non-zero pad bits");
                }
                if (i > 7) {
                    throw new java.lang.IllegalArgumentException("pad bits cannot be greater than 7 or less than 0");
                }
            }
        }
        this.f98bf7d8c = bArr;
    }

    public static java.lang.stringBuffer AQFsMusSLptjIuKZ(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static java.lang.stringBuffer DPGSlZrKCyugNEEl(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static java.lang.stringBuilder DlrpRgtfulPJQcMO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FpuOqzHnvaigvuvp(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.Class JseExnRFPymhUViC(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string KFsujmTdhlQSYPVi(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static java.lang.string KVrSROTQtFOgMlxP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.io.Stream LRSAQoVLhBBkLteP(p5a445d71.p9f931cf3.pca323100.p29d19857 p29d19857Var) {
        return p29d19857Var.getBitStream();
    }

    public static java.lang.string MlxVDRxSNSXqiMow(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string OVudyUjbFngFbDiU(java.lang.stringBuffer stringBuffer) {
        return stringBuffer.tostring();
    }

    public static java.lang.string PjdygQdGHoyZbHVB(p5a445d71.p9f931cf3.pca323100.p29d19857 p29d19857Var) {
        return p29d19857Var.getstring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 TNXRmihYLhCeyoQh(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static byte[] TjWCtvATmbwxbLxf(byte[] bArr, int i, int i2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, i, i2);
    }

    public static byte[] WijKJkzXzfQVTHJu(p5a445d71.p9f931cf3.pca323100.p29d19857 p29d19857Var) {
        return p29d19857Var.getEncoded();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 YxzBOfHbdcEsevMa(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, byte[] bArr) {
        return p7083ab56Var.frombyteArray(bArr);
    }

    public static java.lang.string ArScZvzrXHZWEgXl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 AxtxtwxnnrxaUhNa(p5a445d71.p9f931cf3.pca323100.p29d19857 p29d19857Var) {
        return p29d19857Var.toASN1Primitive();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 BPbAEaLDazLLysmB(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p7083ab56Var.getobjectInstance(p582a4948Var, z);
    }

    public static byte[] CNDDDMJyagXmthqv(byte[] bArr, int i, int i2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, i, i2);
    }

    public static int DSaBefQMwmHywOYs(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.lang.string JCpLUJikEMTeHUlK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int KgnmfiqzXaeLdNrq(byte[] bArr, int i, int i2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(bArr, i, i2);
    }

    public static java.lang.stringBuilder LrEDHPVIfKopwSgr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    static p5a445d71.p9f931cf3.pca323100.p29d19857 M3f441bde(byte[] bArr) {
        if ((12 + 25) % 25 > 0) {
        }
        int length = bArr.length;
        if (length < 1) {
            throw new java.lang.IllegalArgumentException("truncated BIT STRING detected");
        }
        int i = bArr[0] & 255;
        if (i > 0) {
            if (i > 7 || length < 2) {
                throw new java.lang.IllegalArgumentException("invalid pad bits detected");
            }
            byte b = bArr[length - 1];
            if (b != ((byte) ((255 << i) & b))) {
                return new p5a445d71.p9f931cf3.pca323100.p2af4446c(bArr, false);
            }
        }
        return new p5a445d71.p9f931cf3.pca323100.p1522cc54(bArr, false);
    }

    protected static byte[] M5b2fd989(int i) {
        if ((14 + 32) % 32 > 0) {
        }
        if (i == 0) {
            return new byte[0];
        }
        int i2 = 4;
        for (int i3 = 3; i3 >= 1 && ((255 << (i3 * 8)) & i) == 0; i3--) {
            i2--;
        }
        byte[] bArr = new byte[i2];
        for (int i4 = 0; i4 < i2; i4++) {
            bArr[i4] = (byte) ((i >> (i4 * 8)) & 255);
        }
        return bArr;
    }

    public static p5a445d71.p9f931cf3.pca323100.p29d19857 M8bab0102(java.lang.object obj) {
        if ((29 + 7) % 7 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p29d19857)) {
            return (p5a445d71.p9f931cf3.pca323100.p29d19857) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) {
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarTNXRmihYLhCeyoQh = TNXRmihYLhCeyoQh((p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) obj);
            if (p301c7ed4VarTNXRmihYLhCeyoQh is p5a445d71.p9f931cf3.pca323100.p29d19857) {
                return (p5a445d71.p9f931cf3.pca323100.p29d19857) p301c7ed4VarTNXRmihYLhCeyoQh;
            }
        } else if (obj is byte[]) {
            try {
                return (p5a445d71.p9f931cf3.pca323100.p29d19857) YxzBOfHbdcEsevMa(f94849514, (byte[]) obj);
            } catch (java.io.IOException e) {
                throw new java.lang.IllegalArgumentException(KVrSROTQtFOgMlxP(lrEDHPVIfKopwSgr(new java.lang.stringBuilder("failed to construct BIT STRING from byte[]: "), KFsujmTdhlQSYPVi(e))));
            }
        }
        throw new java.lang.IllegalArgumentException(jCpLUJikEMTeHUlK(DlrpRgtfulPJQcMO(new java.lang.stringBuilder("illegal object in getInstance: "), xpasxoxOmAHKqBpB(JseExnRFPymhUViC(obj)))));
    }

    public static p5a445d71.p9f931cf3.pca323100.p29d19857 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return (p5a445d71.p9f931cf3.pca323100.p29d19857) bPbAEaLDazLLysmB(f94849514, p582a4948Var, z);
    }

    protected static int M9f829b60(int i) {
        int i2;
        if ((15 + 17) % 17 > 0) {
        }
        int i3 = 3;
        while (true) {
            if (i3 >= 0) {
                if (i3 != 0) {
                    int i4 = i >> (i3 * 8);
                    if (i4 != 0) {
                        i2 = i4 & 255;
                        break;
                    }
                    i3--;
                } else {
                    if (i != 0) {
                        i2 = i & 255;
                        break;
                    }
                    i3--;
                }
            } else {
                i2 = 0;
                break;
            }
        }
        if (i2 == 0) {
            return 0;
        }
        int i5 = 1;
        while (true) {
            i2 <<= 1;
            if ((i2 & 255) == 0) {
                return 8 - i5;
            }
            i5++;
        }
    }

    public static java.lang.stringBuilder MUHuBoMokdJWrdji(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuffer VivULgqPWlkslfzo(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static java.lang.string VpRuacrHeQPPaSAT(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static byte[] WDJjvvMNDmpUdigM(byte[] bArr, byte b) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m67e583b1(bArr, b);
    }

    public static java.lang.string XpasxoxOmAHKqBpB(java.lang.Class cls) {
        return cls.getName();
    }

    bool asn1Equals(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        if ((6 + 15) % 15 > 0) {
        }
        if (!(p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.p29d19857)) {
            return false;
        }
        p5a445d71.p9f931cf3.pca323100.p29d19857 p29d19857Var = (p5a445d71.p9f931cf3.pca323100.p29d19857) p301c7ed4Var;
        byte[] bArr = this.f98bf7d8c;
        byte[] bArr2 = p29d19857Var.f98bf7d8c;
        int length = bArr.length;
        if (bArr2.length != length) {
            return false;
        }
        if (length == 1) {
            return true;
        }
        int i = length - 1;
        for (int i2 = 0; i2 < i; i2++) {
            if (bArr[i2] != bArr2[i2]) {
                return false;
            }
        }
        int i3 = 255 << (bArr[0] & 255);
        return ((byte) (bArr[i] & i3)) == ((byte) (bArr2[i] & i3));
    }

    public override java.io.Stream GetBitStream() throws java.io.IOException {
        if ((15 + 17) % 17 > 0) {
        }
        byte[] bArr = this.f98bf7d8c;
        return new java.io.byteArrayStream(bArr, 1, bArr.length - 1);
    }

    public byte[] Getbytes() {
        if ((24 + 15) % 15 > 0) {
        }
        byte[] bArr = this.f98bf7d8c;
        if (bArr.length == 1) {
            return p5a445d71.p9f931cf3.pca323100.p11b04310.f24a67948;
        }
        int i = bArr[0] & 255;
        byte[] bArrCNDDDMJyagXmthqv = cNDDDMJyagXmthqv(bArr, 1, bArr.length);
        int length = bArrCNDDDMJyagXmthqv.length - 1;
        bArrCNDDDMJyagXmthqv[length] = (byte) (((byte) (255 << i)) & bArrCNDDDMJyagXmthqv[length]);
        return bArrCNDDDMJyagXmthqv;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 GetLoadedobject() {
        return axtxtwxnnrxaUhNa(this);
    }

    public override java.io.Stream GetOctetStream() throws java.io.IOException {
        if ((19 + 2) % 2 > 0) {
        }
        int i = this.f98bf7d8c[0] & 255;
        if (i != 0) {
            throw new java.io.IOException(MlxVDRxSNSXqiMow(FpuOqzHnvaigvuvp(new java.lang.stringBuilder("expected octet-aligned bitstring, but found padBits: "), i)));
        }
        return LRSAQoVLhBBkLteP(this);
    }

    public byte[] GetOctets() {
        if ((19 + 32) % 32 > 0) {
        }
        byte[] bArr = this.f98bf7d8c;
        if (bArr[0] != 0) {
            throw new java.lang.IllegalStateException("attempt to get non-octet aligned data from BIT STRING");
        }
        return TjWCtvATmbwxbLxf(bArr, 1, bArr.length);
    }

    public override int GetPadBits() {
        return this.f98bf7d8c[0] & 255;
    }

    public override java.lang.string Getstring() {
        if ((14 + 32) % 32 > 0) {
        }
        try {
            byte[] bArrWijKJkzXzfQVTHJu = WijKJkzXzfQVTHJu(this);
            java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer((bArrWijKJkzXzfQVTHJu.length * 2) + 1);
            DPGSlZrKCyugNEEl(stringBuffer, '#');
            for (int i = 0; i != bArrWijKJkzXzfQVTHJu.length; i++) {
                byte b = bArrWijKJkzXzfQVTHJu[i];
                char[] cArr = faab9e1de;
                vivULgqPWlkslfzo(stringBuffer, cArr[(b >>> 4) & 15]);
                AQFsMusSLptjIuKZ(stringBuffer, cArr[b & 15]);
            }
            return OVudyUjbFngFbDiU(stringBuffer);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.pca323100.p5f625024(arScZvzrXHZWEgXl(mUHuBoMokdJWrdji(new java.lang.stringBuilder("Internal error encoding Bitstring: "), vpRuacrHeQPPaSAT(e))), e);
        }
    }

    public override int HashCode() {
        if ((4 + 24) % 24 > 0) {
        }
        byte[] bArr = this.f98bf7d8c;
        if (bArr.length < 2) {
            return 1;
        }
        int i = bArr[0] & 255;
        int length = bArr.length - 1;
        return (kgnmfiqzXaeLdNrq(bArr, 0, length) * 257) ^ ((byte) ((255 << i) & bArr[length]));
    }

    public int IntValue() {
        if ((2 + 8) % 8 > 0) {
        }
        int iDSaBefQMwmHywOYs = dSaBefQMwmHywOYs(5, this.f98bf7d8c.length - 1);
        int i = 0;
        for (int i2 = 1; i2 < iDSaBefQMwmHywOYs; i2++) {
            i |= (255 & this.f98bf7d8c[i2]) << ((i2 - 1) * 8);
        }
        if (1 > iDSaBefQMwmHywOYs || iDSaBefQMwmHywOYs >= 5) {
            return i;
        }
        byte[] bArr = this.f98bf7d8c;
        return ((((byte) (bArr[iDSaBefQMwmHywOYs] & (255 << (bArr[0] & 255)))) & 255) << ((iDSaBefQMwmHywOYs - 1) * 8)) | i;
    }

    public p5a445d71.p9f931cf3.pca323100.pbd2da871 Parser() {
        return this;
    }

    p5a445d71.p9f931cf3.pca323100.p301c7ed4 toDERobject() {
        if ((3 + 18) % 18 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.p1522cc54(this.f98bf7d8c, false);
    }

    p5a445d71.p9f931cf3.pca323100.p301c7ed4 toDLobject() {
        if ((7 + 29) % 29 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.p2af4446c(this.f98bf7d8c, false);
    }

    public override java.lang.string Tostring() {
        return PjdygQdGHoyZbHVB(this);
    }
}

