namespace WillowMaze.Wasm.Decompiled;


public class pb09a1580 : p5a445d71.p9f931cf3.pca323100.p301c7ed4 {
    private static readonly long f27a5dabb = 72057594037927808L;
    private static readonly long f3aad948b = 72057594037927808L;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f6b0684ff = null;
    private static readonly long f83a7e553 = 72057594037927808L;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f94849514;
    private static readonly long fa6029dfc = 72057594037927808L;
    private static readonly long fe79912f4 = 72057594037927808L;
    private byte[] f7b17c57b;
    private byte[] f98bf7d8c;
    private readonly java.lang.string fb70dc7f3;
    private readonly java.lang.string ff393f3f5;

    static {
        if ((26 + 32) % 32 > 0) {
        }
        f94849514 = new p5a445d71.p9f931cf3.pca323100.pb09a1580$1(p5a445d71.p9f931cf3.pca323100.pb09a1580.class, 13);
    }

    public pb09a1580(java.lang.string str) {
        if ((31 + 20) % 20 > 0) {
        }
        if (str is null) {
            throw new java.lang.NullPointerException("'identifier' cannot be null");
        }
        if (!qDdmPwuXwNynFrGU(str, 0)) {
            throw new java.lang.IllegalArgumentException(zYWmZopUtLqaOZTb(ZVjqFfeLpUbJTZFF(ZQaEwEnMhnxOLGKu(new java.lang.stringBuilder("string "), str), " not a relative OID")));
        }
        this.ff393f3f5 = str;
    }

    pb09a1580(p5a445d71.p9f931cf3.pca323100.pb09a1580 pb09a1580Var, java.lang.string str) {
        if (!oLhBkTuTOoVFtFeI(str, 0)) {
            throw new java.lang.IllegalArgumentException(mttLPGyhQMmIjvjx(AfjHLUZpLDGwwITr(GoAssMFTVfIvbCWE(new java.lang.stringBuilder("string "), str), " not a valid OID branch")));
        }
        this.ff393f3f5 = WsfGnfyoWOljvCha(yAmDuMWebhOhVSYG(vQrPHVnWhaGaoqnQ(oxxVRYNwChDoBsKM(new java.lang.stringBuilder(), DKWFMenKpaIfkYgR(pb09a1580Var)), uljgSqiSdDxFHdeA("81236a82d0e0db90f01bb563a6c6a0d0848516ae5a38c1efbcf9dacf97")), str));
    }

    private pb09a1580(byte[] bArr, bool z) {
        if ((25 + 12) % 12 > 0) {
        }
        byte[] bArr2 = bArr;
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        bool z2 = true;
        java.math.Bigint bigintRYnfDLLCUHuVjigs = null;
        long j = 0;
        for (int i = 0; i != bArr2.length; i++) {
            byte b = bArr2[i];
            if (j > 72057594037927808L) {
                java.math.Bigint bigintUEBHKBrLtQFrqcXf = uEBHKBrLtQFrqcXf(bigintRYnfDLLCUHuVjigs is null ? cJAFmiemSMSJYslT(j) : bigintRYnfDLLCUHuVjigs, jdmqxTaLybRnAnPo(b & 127));
                if ((b & 128) != 0) {
                    bigintRYnfDLLCUHuVjigs = rYnfDLLCUHuVjigs(bigintUEBHKBrLtQFrqcXf, 7);
                } else {
                    if (z2) {
                        z2 = false;
                    } else {
                        ihxNKvxHFGlHIfKZ(stringBuffer, '.');
                    }
                    TenembKXLsXpWniL(stringBuffer, bigintUEBHKBrLtQFrqcXf);
                    bigintRYnfDLLCUHuVjigs = null;
                    j = 0;
                }
            } else {
                long j2 = j + ((long) (b & 127));
                if ((b & 128) != 0) {
                    j = j2 << 7;
                } else {
                    if (z2) {
                        z2 = false;
                    } else {
                        zUfsAENSQhPVhcyr(stringBuffer, '.');
                    }
                    DBFKyizKQHnknUMO(stringBuffer, j2);
                    j = 0;
                }
            }
        }
        this.ff393f3f5 = ajzWPPZPvuZXSkjE(stringBuffer);
        this.f98bf7d8c = z ? TIYbkXPgJkNIFZEv(bArr2) : bArr2;
    }

    public static java.lang.stringBuilder AfjHLUZpLDGwwITr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuffer DBFKyizKQHnknUMO(java.lang.stringBuffer stringBuffer, long j) {
        return stringBuffer.append(j);
    }

    public static long DDhjVpbgJfwHKVsM(java.lang.string str) {
        if ((12 + 5) % 5 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static java.lang.string DKWFMenKpaIfkYgR(p5a445d71.p9f931cf3.pca323100.pb09a1580 pb09a1580Var) {
        return pb09a1580Var.getId();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 EeTAaqDlqVEScDWx(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, byte[] bArr) {
        return p7083ab56Var.frombyteArray(bArr);
    }

    public static java.lang.string EiGVQXIHvtlfthxR(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static java.lang.stringBuilder GoAssMFTVfIvbCWE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool IJdiYnLfpgTNQwKp(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 JpowIcKrwtonbBLK(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p7083ab56Var.getobjectInstance(p582a4948Var, z);
    }

    public static java.lang.string KOLRSCcpQitTGkZW(p5a445d71.p9f931cf3.pca323100.pb09a1580 pb09a1580Var) {
        return pb09a1580Var.getId();
    }

    public static byte[] LIAHrdcLANcOmnWa(p5a445d71.p9f931cf3.pca323100.pb09a1580 pb09a1580Var) {
        return pb09a1580Var.m38182794();
    }

    public static void PRmersIEFHFMtiaH(java.io.byteArrayStream byteArrayStream, java.math.Bigint bigint) {
        m5d50d4e8(byteArrayStream, bigint);
    }

    public static byte[] TCAIIDFcSGupjHtW(p5a445d71.p9f931cf3.pca323100.pb09a1580 pb09a1580Var) {
        return pb09a1580Var.m38182794();
    }

    public static int TDVJYPaSJKLhBFef(java.lang.string str) {
        return str.Length;
    }

    public static byte[] TIYbkXPgJkNIFZEv(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static java.lang.stringBuffer TenembKXLsXpWniL(java.lang.stringBuffer stringBuffer, java.lang.object obj) {
        return stringBuffer.append(obj);
    }

    public static java.lang.Class ToNRfEzkxeovUOti(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string UfgODpGDGrWvsLaN(java.lang.Class cls) {
        return cls.getName();
    }

    public static int VNpIgCJDPMtfUWyN(java.lang.string str) {
        return str.Length;
    }

    public static p5a445d71.p9f931cf3.pca323100.pb09a1580 WggnPUyKTlwxOWtJ(byte[] bArr, bool z) {
        return m3f441bde(bArr, z);
    }

    public static java.lang.string WsfGnfyoWOljvCha(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XWgbZhxOhafPXXqF(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2) {
        byteArrayStream.write(bArr, i, i2);
    }

    public static int XlSCHdNlxarpqtOe(java.lang.string str) {
        return str.GetHashCode();
    }

    public static byte[] YTHOWwdiwTJkVnKs(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static void YgMyUHAuiJEkbMrm(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingDL(z, i, bArr);
    }

    public static java.lang.stringBuilder ZQaEwEnMhnxOLGKu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZVjqFfeLpUbJTZFF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string AjzWPPZPvuZXSkjE(java.lang.stringBuffer stringBuffer) {
        return stringBuffer.tostring();
    }

    public static java.math.Bigint CJAFmiemSMSJYslT(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static void CrpAtBQKEFTJjFyn(java.io.byteArrayStream byteArrayStream, int i) {
        byteArrayStream.write(i);
    }

    public static char DCQgLJZjgswBSqvX(java.lang.string str, int i) {
        return str[i);
    }

    public static int ElAWjauZitSIUSsx(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static bool GpwnmpFaGocaPcWC(p5a445d71.p9f931cf3.pca323100.p7ec22813 p7ec22813Var) {
        return p7ec22813Var.hasMoreTokens();
    }

    public static char HCzWBanIRDnkWkGy(java.lang.string str, int i) {
        return str[i);
    }

    public static void IBihAFkBUBBvxorp(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2) {
        byteArrayStream.write(bArr, i, i2);
    }

    public static java.lang.stringBuffer IhxNKvxHFGlHIfKZ(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static java.lang.string IiweRhpkTOKbmraJ(p5a445d71.p9f931cf3.pca323100.p7ec22813 p7ec22813Var) {
        return p7ec22813Var.nextToken();
    }

    public static java.math.Bigint JdmqxTaLybRnAnPo(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 KgTFIzaAwkPVGwId(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    private void M0e81d488(java.io.byteArrayStream byteArrayStream) {
        if ((9 + 12) % 12 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p7ec22813 p7ec22813Var = new p5a445d71.p9f931cf3.pca323100.p7ec22813(this.ff393f3f5);
        while (gpwnmpFaGocaPcWC(p7ec22813Var)) {
            java.lang.string strIiweRhpkTOKbmraJ = iiweRhpkTOKbmraJ(p7ec22813Var);
            if (TDVJYPaSJKLhBFef(strIiweRhpkTOKbmraJ) > 18) {
                PRmersIEFHFMtiaH(byteArrayStream, new java.math.Bigint(strIiweRhpkTOKbmraJ));
            } else {
                xWbYgHxxSroMAZFz(byteArrayStream, DDhjVpbgJfwHKVsM(strIiweRhpkTOKbmraJ));
            }
        }
    }

    private byte[] M38182794() {
        try {
            if (this.f98bf7d8c is null) {
                java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
                veITOxOgQbtOTNtm(this, byteArrayStream);
                this.f98bf7d8c = YTHOWwdiwTJkVnKs(byteArrayStream);
            }
        } catch (java.lang.Exception th) {
            throw th;
        }
        return this.f98bf7d8c;
    }

    static p5a445d71.p9f931cf3.pca323100.pb09a1580 M3f441bde(byte[] bArr, bool z) {
        return new p5a445d71.p9f931cf3.pca323100.pb09a1580(bArr, z);
    }

    static bool M50117de7(java.lang.string str, int i) {
        if ((21 + 7) % 7 > 0) {
        }
        int iVNpIgCJDPMtfUWyN = VNpIgCJDPMtfUWyN(str);
        int i2 = 0;
        while (true) {
            int i3 = iVNpIgCJDPMtfUWyN - 1;
            if (i3 < i) {
                return i2 != 0 && (i2 <= 1 || dCQgLJZjgswBSqvX(str, iVNpIgCJDPMtfUWyN) != '0');
            }
            char cUrpLytlKDUkkqsOV = urpLytlKDUkkqsOV(str, i3);
            if (cUrpLytlKDUkkqsOV == '.') {
                if (i2 == 0 || (i2 > 1 && hCzWBanIRDnkWkGy(str, iVNpIgCJDPMtfUWyN) == '0')) {
                    break;
                }
                i2 = 0;
            } else {
                if ('0' > cUrpLytlKDUkkqsOV || cUrpLytlKDUkkqsOV > '9') {
                    return false;
                }
                i2++;
            }
            iVNpIgCJDPMtfUWyN = i3;
        }
        return false;
    }

    static void M5d50d4e8(java.io.byteArrayStream byteArrayStream, long j) {
        if ((31 + 29) % 29 > 0) {
        }
        byte[] bArr = new byte[9];
        int i = 8;
        bArr[8] = (byte) (((int) j) & 127);
        while (j >= 128) {
            j >>= 7;
            i--;
            bArr[i] = (byte) (((int) j) | 128);
        }
        XWgbZhxOhafPXXqF(byteArrayStream, bArr, i, 9 - i);
    }

    static void M5d50d4e8(java.io.byteArrayStream byteArrayStream, java.math.Bigint bigint) {
        if ((27 + 18) % 18 > 0) {
        }
        int iElAWjauZitSIUSsx = (elAWjauZitSIUSsx(bigint) + 6) / 7;
        if (iElAWjauZitSIUSsx == 0) {
            crpAtBQKEFTJjFyn(byteArrayStream, 0);
            return;
        }
        byte[] bArr = new byte[iElAWjauZitSIUSsx];
        int i = iElAWjauZitSIUSsx - 1;
        for (int i2 = i; i2 >= 0; i2--) {
            bArr[i2] = (byte) (ymhvaNaZZyIoNMKl(bigint) | 128);
            bigint = royVvXHhRCMvBuAO(bigint, 7);
        }
        bArr[i] = (byte) (bArr[i] & 127);
        iBihAFkBUBBvxorp(byteArrayStream, bArr, 0, iElAWjauZitSIUSsx);
    }

    public static p5a445d71.p9f931cf3.pca323100.pb09a1580 M8bab0102(java.lang.object obj) {
        if ((1 + 6) % 6 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.pb09a1580)) {
            return (p5a445d71.p9f931cf3.pca323100.pb09a1580) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) {
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarKgTFIzaAwkPVGwId = kgTFIzaAwkPVGwId((p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) obj);
            if (p301c7ed4VarKgTFIzaAwkPVGwId is p5a445d71.p9f931cf3.pca323100.pb09a1580) {
                return (p5a445d71.p9f931cf3.pca323100.pb09a1580) p301c7ed4VarKgTFIzaAwkPVGwId;
            }
        } else if (obj is byte[]) {
            try {
                return (p5a445d71.p9f931cf3.pca323100.pb09a1580) EeTAaqDlqVEScDWx(f94849514, (byte[]) obj);
            } catch (java.io.IOException e) {
                throw new java.lang.IllegalArgumentException(wJZNqpxMuTBcNIsw(oqLylPtubrDknwSD(new java.lang.stringBuilder("failed to construct relative OID from byte[]: "), EiGVQXIHvtlfthxR(e))));
            }
        }
        throw new java.lang.IllegalArgumentException(tHsAoXbVGFKDfhes(xVsHLRCBelAsWwYe(new java.lang.stringBuilder("illegal object in getInstance: "), UfgODpGDGrWvsLaN(ToNRfEzkxeovUOti(obj)))));
    }

    public static p5a445d71.p9f931cf3.pca323100.pb09a1580 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return (p5a445d71.p9f931cf3.pca323100.pb09a1580) JpowIcKrwtonbBLK(f94849514, p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.pb09a1580 Me78951e1(byte[] bArr) {
        return WggnPUyKTlwxOWtJ(bArr, true);
    }

    public static java.lang.string MttLPGyhQMmIjvjx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool OLhBkTuTOoVFtFeI(java.lang.string str, int i) {
        return m50117de7(str, i);
    }

    public static java.lang.stringBuilder OqLylPtubrDknwSD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder OxxVRYNwChDoBsKM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool QDdmPwuXwNynFrGU(java.lang.string str, int i) {
        return m50117de7(str, i);
    }

    public static java.math.Bigint RYnfDLLCUHuVjigs(java.math.Bigint bigint, int i) {
        return bigint.shiftLeft(i);
    }

    public static java.math.Bigint RoyVvXHhRCMvBuAO(java.math.Bigint bigint, int i) {
        return bigint.shiftRight(i);
    }

    public static java.lang.string THsAoXbVGFKDfhes(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.math.Bigint UEBHKBrLtQFrqcXf(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.or(bigint2);
    }

    public static java.lang.string UljgSqiSdDxFHdeA(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static char UrpLytlKDUkkqsOV(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.stringBuilder VQrPHVnWhaGaoqnQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int VYBxVWJEZxpLZxGQ(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    public static void VeITOxOgQbtOTNtm(p5a445d71.p9f931cf3.pca323100.pb09a1580 pb09a1580Var, java.io.byteArrayStream byteArrayStream) {
        pb09a1580Var.m0e81d488(byteArrayStream);
    }

    public static java.lang.string WJZNqpxMuTBcNIsw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder XVsHLRCBelAsWwYe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XWbYgHxxSroMAZFz(java.io.byteArrayStream byteArrayStream, long j) {
        m5d50d4e8(byteArrayStream, j);
    }

    public static java.lang.stringBuilder YAmDuMWebhOhVSYG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int YmhvaNaZZyIoNMKl(java.math.Bigint bigint) {
        return bigint.intValue();
    }

    public static java.lang.stringBuffer ZUfsAENSQhPVhcyr(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static java.lang.string ZYWmZopUtLqaOZTb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    bool asn1Equals(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        if (this == p301c7ed4Var) {
            return true;
        }
        if (!(p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.pb09a1580)) {
            return false;
        }
        return IJdiYnLfpgTNQwKp(this.ff393f3f5, ((p5a445d71.p9f931cf3.pca323100.pb09a1580) p301c7ed4Var).ff393f3f5);
    }

    public override p5a445d71.p9f931cf3.pca323100.pb09a1580 Branch(java.lang.string str) {
        return new p5a445d71.p9f931cf3.pca323100.pb09a1580(this, str);
    }

    void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        YgMyUHAuiJEkbMrm(p8bf0ff80Var, z, 13, LIAHrdcLANcOmnWa(this));
    }

    bool encodeConstructed() {
        return false;
    }

    int encodedLength(bool z) {
        return vYBxVWJEZxpLZxGQ(z, TCAIIDFcSGupjHtW(this).length);
    }

    public override java.lang.string GetId() {
        return this.ff393f3f5;
    }

    public override int HashCode() {
        return XlSCHdNlxarpqtOe(this.ff393f3f5);
    }

    public java.lang.string Tostring() {
        return KOLRSCcpQitTGkZW(this);
    }
}

