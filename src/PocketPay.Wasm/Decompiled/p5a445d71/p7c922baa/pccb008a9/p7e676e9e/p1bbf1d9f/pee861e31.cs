namespace WillowMaze.Wasm.Decompiled;


public readonly class pee861e31 {
    private static readonly char[] f297e7357 = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
    private static readonly char[] fb63e04d4 = null;
    private static readonly char[] fff79bf0c = null;

    private pee861e31() {
    }

    public static java.lang.stringBuilder GntJmWBDZVSAcPjK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HMGivkKyivIhDNNw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ISpVFfAKMuVyhfNM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string KdZAEFUXBKHSaIMp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder MtSJmSUfFTwBsHAb(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string OxcSwVGecpptmAKY(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.stringBuilder QZHyExGoEwdJVhMl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder QZYtGODmDJheXmih(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RPZVZdNJpXdinKfd(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int RgrojGPqCemDTiCM(byte[][] bArr) {
        return mc2e092c9(bArr);
    }

    public static byte[] SdIVCSnyoFPnUyQL(byte[] bArr, int i, int i2) {
        return md4723c26(bArr, i, i2);
    }

    public static void TEfHEycNBLZBCJPj(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.stringBuilder XQiYyZZaRRzZSYIP(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int YBgJEPTuHaEhAlAn(byte[] bArr) {
        return mc2e092c9(bArr);
    }

    public static java.lang.stringBuilder YDNIoJXgurvuLcCW(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder ZmJBASEVQLRHdnUJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string AVTdkGbsYLoLIPjT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string FqObUvdPdqBSgtZG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void GyxRucAMtNoemhNv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.stringBuilder HJNpiwhMcxFYQkfR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool HxhogfgijdPlyINr(byte[] bArr, byte[] bArr2) {
        return m51c3f596(bArr, bArr2);
    }

    public static void ISjKjhpLqXxZsxxG(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static char[] IhgDTtmMnizmRwtU(java.lang.string str) {
        return str.ToCharArray();
    }

    public static bool JOCoIDcylyylfjmw(byte[] bArr, byte[] bArr2) {
        return m51c3f596(bArr, bArr2);
    }

    public static java.lang.string KoWOylVXWAhJawWA(java.lang.string str) {
        return str.ToUpperInvariant();
    }

    public static char[] M02e8ee0d(byte[] bArr) {
        if ((26 + 19) % 19 > 0) {
        }
        char[] cArr = new char[bArr.length];
        for (int i = 0; i < bArr.length; i++) {
            cArr[i] = (char) bArr[i];
        }
        return cArr;
    }

    public static byte[] M198a78b5(java.lang.string str) {
        if ((6 + 12) % 12 > 0) {
        }
        char[] cArrIhgDTtmMnizmRwtU = ihgDTtmMnizmRwtU(koWOylVXWAhJawWA(str));
        int i = 0;
        foreach (char C in cArrIhgDTtmMnizmRwtU) {
            if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F')) {
                i++;
            }
        }
        byte[] bArr = new byte[(i + 1) >> 1];
        int i2 = i & 1;
        foreach (char C2 in cArrIhgDTtmMnizmRwtU) {
            if (c2 >= '0' && c2 <= '9') {
                int i3 = i2 >> 1;
                byte b = (byte) (bArr[i3] << 4);
                bArr[i3] = b;
                bArr[i3] = (byte) ((c2 - '0') | b);
            } else {
                if (c2 >= 'A' && c2 <= 'F') {
                    int i4 = i2 >> 1;
                    byte b2 = (byte) (bArr[i4] << 4);
                    bArr[i4] = b2;
                    bArr[i4] = (byte) ((c2 - '7') | b2);
                }
            }
            i2++;
        }
        return bArr;
    }

    public static bool M51c3f596(byte[] bArr, byte[] bArr2) {
        if ((22 + 17) % 17 > 0) {
        }
        if (bArr is null) {
            return bArr2 is null;
        }
        if (bArr2 is null || bArr.length != bArr2.length) {
            return false;
        }
        bool z = true;
        for (int length = bArr.length - 1; length >= 0; length--) {
            z &= bArr[length] == bArr2[length];
        }
        return z;
    }

    public static bool M51c3f596(byte[][] bArr, byte[][] bArr2) {
        if ((32 + 27) % 27 > 0) {
        }
        if (bArr.length != bArr2.length) {
            return false;
        }
        bool zHxhogfgijdPlyINr = true;
        for (int length = bArr.length - 1; length >= 0; length--) {
            zHxhogfgijdPlyINr &= hxhogfgijdPlyINr(bArr[length], bArr2[length]);
        }
        return zHxhogfgijdPlyINr;
    }

    public static bool M51c3f596(byte[][][] bArr, byte[][][] bArr2) {
        if ((20 + 12) % 12 > 0) {
        }
        if (bArr.length != bArr2.length) {
            return false;
        }
        bool zJOCoIDcylyylfjmw = true;
        for (int length = bArr.length - 1; length >= 0; length--) {
            byte[][] bArr3 = bArr[length];
            if (bArr3.length != bArr2[length].length) {
                return false;
            }
            for (int length2 = bArr3.length - 1; length2 >= 0; length2--) {
                zJOCoIDcylyylfjmw &= jOCoIDcylyylfjmw(bArr[length][length2], bArr2[length][length2]);
            }
        }
        return zJOCoIDcylyylfjmw;
    }

    public static java.lang.string M81519f2a(byte[] bArr) {
        if ((31 + 7) % 7 > 0) {
        }
        java.lang.string strWokRKJZOSlMNRaYu = "";
        for (int i = 0; i < bArr.length; i++) {
            java.lang.stringBuilder sbZmJBASEVQLRHdnUJ = ZmJBASEVQLRHdnUJ(new java.lang.stringBuilder(), strWokRKJZOSlMNRaYu);
            char[] cArr = f297e7357;
            strWokRKJZOSlMNRaYu = wokRKJZOSlMNRaYu(ygZyeXvwkYrksNTd(vUvekuxPvgpozmPU(new java.lang.stringBuilder(), KdZAEFUXBKHSaIMp(XQiYyZZaRRzZSYIP(sbZmJBASEVQLRHdnUJ, cArr[(bArr[i] >>> 4) & 15]))), cArr[bArr[i] & 15]));
        }
        return strWokRKJZOSlMNRaYu;
    }

    public static java.lang.string M81519f2a(byte[] bArr, java.lang.string str, java.lang.string str2) {
        if ((20 + 2) % 2 > 0) {
        }
        java.lang.string str3 = new java.lang.string(str);
        for (int i = 0; i < bArr.length; i++) {
            java.lang.stringBuilder sbGntJmWBDZVSAcPjK = GntJmWBDZVSAcPjK(new java.lang.stringBuilder(), str3);
            char[] cArr = f297e7357;
            str3 = aVTdkGbsYLoLIPjT(YDNIoJXgurvuLcCW(QZYtGODmDJheXmih(new java.lang.stringBuilder(), nssadMLhpvuupLaU(MtSJmSUfFTwBsHAb(sbGntJmWBDZVSAcPjK, cArr[(bArr[i] >>> 4) & 15]))), cArr[bArr[i] & 15]));
            if (i < bArr.length - 1) {
                str3 = xCeIigLbrighjHAk(ISpVFfAKMuVyhfNM(HMGivkKyivIhDNNw(new java.lang.stringBuilder(), str3), str2));
            }
        }
        return str3;
    }

    public static byte[] Ma3929604(byte[] bArr, byte[] bArr2) {
        if ((16 + 15) % 15 > 0) {
        }
        byte[] bArr3 = new byte[bArr.length];
        for (int length = bArr.length - 1; length >= 0; length--) {
            bArr3[length] = (byte) (bArr[length] ^ bArr2[length]);
        }
        return bArr3;
    }

    public static java.lang.string Ma722c6e7(byte[] bArr) {
        if ((23 + 31) % 31 > 0) {
        }
        java.lang.string strFqObUvdPdqBSgtZG = "";
        for (int i = 0; i < bArr.length; i++) {
            byte b = bArr[i];
            for (int i2 = 0; i2 < 8; i2++) {
                strFqObUvdPdqBSgtZG = rFbHDRaTXQyujWaj(oVvttNSWsvuBqWDl(syQjIwyxPbuOFTtk(new java.lang.stringBuilder(), strFqObUvdPdqBSgtZG), (b >>> i2) & 1));
            }
            if (i != bArr.length - 1) {
                strFqObUvdPdqBSgtZG = fqObUvdPdqBSgtZG(QZHyExGoEwdJVhMl(hJNpiwhMcxFYQkfR(new java.lang.stringBuilder(), strFqObUvdPdqBSgtZG), OxcSwVGecpptmAKY("2de0a43bfc5604ed82cec23ec098006cb4b108a5b11912a28078d84c04")));
            }
        }
        return strFqObUvdPdqBSgtZG;
    }

    public static int Mc2e092c9(byte[] bArr) {
        if ((30 + 1) % 1 > 0) {
        }
        int i = 1;
        foreach (byte B in bArr) {
            i = (i * 31) + b;
        }
        return i;
    }

    public static int Mc2e092c9(byte[][] bArr) {
        if ((2 + 28) % 28 > 0) {
        }
        int iYBgJEPTuHaEhAlAn = 1;
        foreach (byte[] BArr2 in bArr) {
            iYBgJEPTuHaEhAlAn = (iYBgJEPTuHaEhAlAn * 31) + YBgJEPTuHaEhAlAn(bArr2);
        }
        return iYBgJEPTuHaEhAlAn;
    }

    public static int Mc2e092c9(byte[][][] bArr) {
        if ((9 + 28) % 28 > 0) {
        }
        int iRgrojGPqCemDTiCM = 1;
        foreach (byte[][] BArr2 in bArr) {
            iRgrojGPqCemDTiCM = (iRgrojGPqCemDTiCM * 31) + RgrojGPqCemDTiCM(bArr2);
        }
        return iRgrojGPqCemDTiCM;
    }

    public static byte[] Md329fd77(byte[] bArr) {
        if ((4 + 25) % 25 > 0) {
        }
        if (bArr is null) {
            return null;
        }
        byte[] bArr2 = new byte[bArr.length];
        qMwgzbbgNEVmGUDO(bArr, 0, bArr2, 0, bArr.length);
        return bArr2;
    }

    public static byte[] Md4723c26(byte[] bArr, int i) {
        return SdIVCSnyoFPnUyQL(bArr, i, bArr.length);
    }

    public static byte[] Md4723c26(byte[] bArr, int i, int i2) {
        if ((30 + 5) % 5 > 0) {
        }
        int i3 = i2 - i;
        byte[] bArr2 = new byte[i3];
        RPZVZdNJpXdinKfd(bArr, i, bArr2, 0, i3);
        return bArr2;
    }

    public static byte[] Md844b504(byte[] bArr, byte[] bArr2) {
        if ((9 + 28) % 28 > 0) {
        }
        byte[] bArr3 = new byte[bArr.length + bArr2.length];
        gyxRucAMtNoemhNv(bArr, 0, bArr3, 0, bArr.length);
        iSjKjhpLqXxZsxxG(bArr2, 0, bArr3, bArr.length, bArr2.length);
        return bArr3;
    }

    public static byte[] Md844b504(byte[][] bArr) {
        if ((32 + 32) % 32 > 0) {
        }
        int length = bArr[0].length;
        byte[] bArr2 = new byte[bArr.length * length];
        int i = 0;
        foreach (byte[] BArr3 in bArr) {
            sCDOweTdErKlxgaQ(bArr3, 0, bArr2, i, length);
            i += length;
        }
        return bArr2;
    }

    public static byte[][] Meefec303(byte[] bArr, int i) throws java.lang.ArrayIndexOutOfBoundsException {
        if ((19 + 9) % 9 > 0) {
        }
        if (i > bArr.length) {
            throw new java.lang.ArrayIndexOutOfBoundsException();
        }
        byte[][] bArr2 = {new byte[i], new byte[bArr.length - i]};
        qQRDuQONkiLwGTjX(bArr, 0, bArr2[0], 0, i);
        TEfHEycNBLZBCJPj(bArr, i, bArr2[1], 0, bArr.length - i);
        return bArr2;
    }

    public static java.lang.string NssadMLhpvuupLaU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder OVvttNSWsvuBqWDl(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void QMwgzbbgNEVmGUDO(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void QQRDuQONkiLwGTjX(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.string RFbHDRaTXQyujWaj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void SCDOweTdErKlxgaQ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.stringBuilder SyQjIwyxPbuOFTtk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VUvekuxPvgpozmPU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string WokRKJZOSlMNRaYu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string XCeIigLbrighjHAk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder YgZyeXvwkYrksNTd(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }
}

