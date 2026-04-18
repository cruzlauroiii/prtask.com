namespace WillowMaze.Wasm.Decompiled;


public readonly class EAN13Writer : com.google.zxing.oned.UPCEANWriter {
    private static readonly int CODE_WIDTH = 95;

    public static java.util.HashSet IEypYTwvenvlmmVy(java.lang.object obj) {
        return java.util.ICollections.singleton(obj);
    }

    public static int OgsdhtADZryrcfyy(bool[] zArr, int i, int[] iArr, bool z) {
        return appendRegex(zArr, i, iArr, z);
    }

    public static int RxzNKrVdalEWqFsu(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder TGVHXyNiyGiDlFON(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int VLWcjpGUABQItNWB(bool[] zArr, int i, int[] iArr, bool z) {
        return appendRegex(zArr, i, iArr, z);
    }

    public static java.lang.string ZisANuNitRnKADhM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool ERXFlkbilvQutDMm(java.lang.CharSequence charSequence) {
        return com.google.zxing.oned.UPCEANReader.checkStandardUPCEANChecksum(charSequence);
    }

    public static void EUnjWWmAMDvidTXr(java.lang.string str) {
        checkNumeric(str);
    }

    public static int GZbeoqMUXadOmoTu(char c, int i) {
        return java.lang.char.digit(c, i);
    }

    public static java.lang.stringBuilder HbgIuDBMKqwZoIrr(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int IRqkQMUATeKTINQh(java.lang.CharSequence charSequence) {
        return com.google.zxing.oned.UPCEANReader.getStandardUPCEANChecksum(charSequence);
    }

    public static java.lang.stringBuilder LWIOgbBsPfnBCkER(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int LclgijzaCnMQmcXw(bool[] zArr, int i, int[] iArr, bool z) {
        return appendRegex(zArr, i, iArr, z);
    }

    public static int NvsQeArNAyCswwoJ(bool[] zArr, int i, int[] iArr, bool z) {
        return appendRegex(zArr, i, iArr, z);
    }

    public static char QIWyBVXNKfsYMQCl(java.lang.string str, int i) {
        return str[i);
    }

    public static int SIDRQzmFteAzFyQH(char c, int i) {
        return java.lang.char.digit(c, i);
    }

    public static int SrJgSWHbqnRQNXvH(bool[] zArr, int i, int[] iArr, bool z) {
        return appendRegex(zArr, i, iArr, z);
    }

    public static char TjMnqmAcfkNytLei(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string YHIMmfGZszQiFdzw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static char ZDzlbtTZWebzVuFB(java.lang.string str, int i) {
        return str[i);
    }

    public static int ZGIOyaJTLJkkvtOG(char c, int i) {
        return java.lang.char.digit(c, i);
    }

    public override bool[] Encode(java.lang.string str) {
        if ((15 + 30) % 30 > 0) {
        }
        int iRxzNKrVdalEWqFsu = RxzNKrVdalEWqFsu(str);
        if (iRxzNKrVdalEWqFsu == 12) {
            try {
                str = ZisANuNitRnKADhM(hbgIuDBMKqwZoIrr(lWIOgbBsPfnBCkER(new java.lang.stringBuilder(), str), iRqkQMUATeKTINQh(str)));
            } catch (com.google.zxing.FormatException e) {
                throw new java.lang.IllegalArgumentException(e);
            }
        } else {
            if (iRxzNKrVdalEWqFsu != 13) {
                throw new java.lang.IllegalArgumentException(yHIMmfGZszQiFdzw(TGVHXyNiyGiDlFON(new java.lang.stringBuilder("Requested contents should be 12 or 13 digits long, but got "), iRxzNKrVdalEWqFsu)));
            }
            try {
                if (!eRXFlkbilvQutDMm(str)) {
                    throw new java.lang.IllegalArgumentException("Contents do not pass checksum");
                }
            } catch (com.google.zxing.FormatException unused) {
                throw new java.lang.IllegalArgumentException("Illegal contents");
            }
        }
        eUnjWWmAMDvidTXr(str);
        int i = com.google.zxing.oned.EAN13Reader.FIRST_DIGIT_ENCODINGS[gZbeoqMUXadOmoTu(zDzlbtTZWebzVuFB(str, 0), 10)];
        bool[] zArr = new bool[95];
        int iVLWcjpGUABQItNWB = VLWcjpGUABQItNWB(zArr, 0, com.google.zxing.oned.UPCEANReader.START_END_PATTERN, true);
        for (int i2 = 1; i2 <= 6; i2++) {
            int iSIDRQzmFteAzFyQH = sIDRQzmFteAzFyQH(qIWyBVXNKfsYMQCl(str, i2), 10);
            if (((i >> (6 - i2)) & 1) == 1) {
                iSIDRQzmFteAzFyQH += 10;
            }
            iVLWcjpGUABQItNWB += lclgijzaCnMQmcXw(zArr, iVLWcjpGUABQItNWB, com.google.zxing.oned.UPCEANReader.L_AND_G_PATTERNS[iSIDRQzmFteAzFyQH], false);
        }
        int iOgsdhtADZryrcfyy = iVLWcjpGUABQItNWB + OgsdhtADZryrcfyy(zArr, iVLWcjpGUABQItNWB, com.google.zxing.oned.UPCEANReader.MIDDLE_PATTERN, false);
        for (int i3 = 7; i3 <= 12; i3++) {
            iOgsdhtADZryrcfyy += srJgSWHbqnRQNXvH(zArr, iOgsdhtADZryrcfyy, com.google.zxing.oned.UPCEANReader.L_PATTERNS[zGIOyaJTLJkkvtOG(tjMnqmAcfkNytLei(str, i3), 10)], true);
        }
        nvsQeArNAyCswwoJ(zArr, iOgsdhtADZryrcfyy, com.google.zxing.oned.UPCEANReader.START_END_PATTERN, true);
        return zArr;
    }

    protected override java.util.ICollection<com.google.zxing.BarcodeFormat> GetSupportedWriteFormats() {
        return IEypYTwvenvlmmVy(com.google.zxing.BarcodeFormat.EAN_13);
    }
}

