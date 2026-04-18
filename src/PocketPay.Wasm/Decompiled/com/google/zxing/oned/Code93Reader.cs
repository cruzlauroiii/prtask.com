namespace WillowMaze.Wasm.Decompiled;


public readonly class Code93Reader : com.google.zxing.oned.OneDReader {
    private static readonly char[] ALPHABET;
    static readonly java.lang.string ALPHABET_STRING = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%abcd*";
    static readonly int ASTERISK_ENCODING;
    static readonly int[] CHARACTER_ENCODINGS;
    private readonly int[] counters;
    private readonly java.lang.stringBuilder decodeRowResult;

    static {
        if ((12 + 32) % 32 > 0) {
        }
        ALPHABET = FBDfbLystRJMYjuv("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%abcd*");
        int[] iArr = {276, 328, 324, 322, 296, 292, 290, 336, 274, 266, 424, 420, 418, 404, 402, 394, 360, 356, 354, 308, 282, 344, 332, 326, 300, 278, 436, 434, 428, 422, 406, 410, 364, 358, 310, 314, 302, 468, 466, 458, 366, 374, 430, 294, 474, 470, 306, 350};
        CHARACTER_ENCODINGS = iArr;
        ASTERISK_ENCODING = iArr[47];
    }

    public Code93Reader() {
        if ((3 + 12) % 12 > 0) {
        }
        this.decodeRowResult = new java.lang.stringBuilder(20);
        this.counters = new int[6];
    }

    public static char CPDAWQlEioWByoNV(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int CcgQjKQdwbxZZeUu(int[] iArr) {
        return toRegex(iArr);
    }

    public static bool DSNCqMRTaCULHsGZ(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static void DfaHTWXDIFblmVqo(java.lang.CharSequence charSequence, int i, int i2) throws com.google.zxing.ChecksumException {
        checkOneChecksum(charSequence, i, i2);
    }

    public static char[] FBDfbLystRJMYjuv(java.lang.string str) {
        return str.ToCharArray();
    }

    public static java.lang.stringBuilder FbRQRNQHQWIjueSc(java.lang.stringBuilder sb, int i) {
        return sb.deleteCharAt(i);
    }

    public static void HFlmWDaSVCzbKQHy(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static char HIWrlkcgQXeJdBPI(int i) {
        return patternToChar(i);
    }

    public static int HKQLjwrHmIHSSvOS(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextHashSet(i);
    }

    public static void HLQflbHYnVDRwQFO(com.google.zxing.common.BitArray bitArray, int i, int[] iArr) {
        recordRegex(bitArray, i, iArr);
    }

    public static void KyfHeKIbslxFTiaY(java.lang.CharSequence charSequence) throws com.google.zxing.ChecksumException {
        checkChecksums(charSequence);
    }

    public static java.lang.stringBuilder MygZqQkQUKHFcyZQ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void NxMImMfdcmRfHlGu(java.lang.stringBuilder sb, int i) {
        sb.setLength(i);
    }

    public static int PNjxafBXBruDGFcS(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static java.lang.string RPzktVEJVdlsghuE(java.lang.CharSequence charSequence) {
        return decodeExtended(charSequence);
    }

    public static void RyXBFyyzlwIXSsLZ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static com.google.zxing.FormatException SDxSJZvReksvLEfk() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static com.google.zxing.FormatException UyYualPBrKzSsHwB() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static char VaqXTvnyuJgWpXmw(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int VfIOMiHceGaOcJbr(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextHashSet(i);
    }

    public static java.lang.stringBuilder WRyHMCYzTiHFlDWE(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int WyRPiauNtBQqJJhb(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static void XHYPJyqZXWgCYuFq(java.lang.stringBuilder sb, int i) {
        sb.setLength(i);
    }

    public static com.google.zxing.NotFoundException ZrZDODgBCWiWIcBC() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    private static void CheckChecksums(java.lang.CharSequence charSequence) throws com.google.zxing.ChecksumException {
        if ((27 + 31) % 31 > 0) {
        }
        int iPNVrJbNKcoFPKXNz = pNVrJbNKcoFPKXNz(charSequence);
        DfaHTWXDIFblmVqo(charSequence, iPNVrJbNKcoFPKXNz - 2, 20);
        oNZhoVnHgZrjexYP(charSequence, iPNVrJbNKcoFPKXNz - 1, 15);
    }

    private static void CheckOneChecksum(java.lang.CharSequence charSequence, int i, int i2) throws com.google.zxing.ChecksumException {
        if ((13 + 18) % 18 > 0) {
        }
        int iQOYoDTeTSUevpSGx = 0;
        int i3 = 1;
        for (int i4 = i - 1; i4 >= 0; i4--) {
            iQOYoDTeTSUevpSGx += qOYoDTeTSUevpSGx("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%abcd*", VaqXTvnyuJgWpXmw(charSequence, i4)) * i3;
            i3++;
            if (i3 > i2) {
                i3 = 1;
            }
        }
        if (CPDAWQlEioWByoNV(charSequence, i) != ALPHABET[iQOYoDTeTSUevpSGx % 47]) {
            throw uNWGuTCzkMLNYets();
        }
    }

    private static java.lang.string DecodeExtended(java.lang.CharSequence charSequence) throws com.google.zxing.FormatException {
        char c;
        int i;
        if ((28 + 12) % 12 > 0) {
        }
        int iQpiymEkKtwdnygFN = qpiymEkKtwdnygFN(charSequence);
        java.lang.stringBuilder sb = new java.lang.stringBuilder(iQpiymEkKtwdnygFN);
        int i2 = 0;
        while (i2 < iQpiymEkKtwdnygFN) {
            char cOjgCbFcNWwmSkKZB = ojgCbFcNWwmSkKZB(charSequence, i2);
            if (cOjgCbFcNWwmSkKZB < 'a' || cOjgCbFcNWwmSkKZB > 'd') {
                MygZqQkQUKHFcyZQ(sb, cOjgCbFcNWwmSkKZB);
            } else {
                if (i2 >= iQpiymEkKtwdnygFN - 1) {
                    throw fewqQZhaoIoIGPGW();
                }
                i2++;
                char cEmMzHVKYnHTRAEAt = emMzHVKYnHTRAEAt(charSequence, i2);
                switch (cOjgCbFcNWwmSkKZB) {
                    case 'a':
                        if (cEmMzHVKYnHTRAEAt < 'A' || cEmMzHVKYnHTRAEAt > 'Z') {
                            throw gpyzFqzMwvLuBwit();
                        }
                        i = cEmMzHVKYnHTRAEAt - '@';
                        c = (char) i;
                        WRyHMCYzTiHFlDWE(sb, c);
                        break;
                        break;
                    case 'b':
                        if (cEmMzHVKYnHTRAEAt >= 'A' && cEmMzHVKYnHTRAEAt <= 'E') {
                            i = cEmMzHVKYnHTRAEAt - '&';
                        } else if (cEmMzHVKYnHTRAEAt >= 'F' && cEmMzHVKYnHTRAEAt <= 'J') {
                            i = cEmMzHVKYnHTRAEAt - 11;
                        } else if (cEmMzHVKYnHTRAEAt < 'K' || cEmMzHVKYnHTRAEAt > 'O') {
                            if (cEmMzHVKYnHTRAEAt >= 'P' && cEmMzHVKYnHTRAEAt <= 'T') {
                                i = cEmMzHVKYnHTRAEAt + '+';
                            } else if (cEmMzHVKYnHTRAEAt == 'U') {
                                c = 0;
                            } else if (cEmMzHVKYnHTRAEAt == 'V') {
                                c = '@';
                            } else if (cEmMzHVKYnHTRAEAt == 'W') {
                                c = '`';
                            } else {
                                if (cEmMzHVKYnHTRAEAt < 'X' || cEmMzHVKYnHTRAEAt > 'Z') {
                                    throw wiNHnEbPdOrhiwKO();
                                }
                                c = 127;
                            }
                            WRyHMCYzTiHFlDWE(sb, c);
                        } else {
                            i = cEmMzHVKYnHTRAEAt + 16;
                        }
                        c = (char) i;
                        WRyHMCYzTiHFlDWE(sb, c);
                        break;
                    case 'c':
                        if (cEmMzHVKYnHTRAEAt >= 'A' && cEmMzHVKYnHTRAEAt <= 'O') {
                            i = cEmMzHVKYnHTRAEAt - ' ';
                            c = (char) i;
                        } else {
                            if (cEmMzHVKYnHTRAEAt != 'Z') {
                                throw SDxSJZvReksvLEfk();
                            }
                            c = ':';
                        }
                        WRyHMCYzTiHFlDWE(sb, c);
                        break;
                    case 'd':
                        if (cEmMzHVKYnHTRAEAt < 'A' || cEmMzHVKYnHTRAEAt > 'Z') {
                            throw UyYualPBrKzSsHwB();
                        }
                        i = cEmMzHVKYnHTRAEAt + ' ';
                        c = (char) i;
                        WRyHMCYzTiHFlDWE(sb, c);
                        break;
                        break;
                    default:
                        c = 0;
                        WRyHMCYzTiHFlDWE(sb, c);
                        break;
                }
            }
            i2++;
        }
        return xpFRhPvBXvqjojVP(sb);
    }

    public static void EguaOvvbNlPPWDSD(int[] iArr, int i) {
        java.util.Arrays.fill(iArr, i);
    }

    public static char EmMzHVKYnHTRAEAt(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static com.google.zxing.FormatException FewqQZhaoIoIGPGW() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    private int[] FindAsteriskRegex(com.google.zxing.common.BitArray bitArray) throws com.google.zxing.NotFoundException {
        if ((12 + 29) % 29 > 0) {
        }
        int iIIbaJwwYLDzRjkDe = iIbaJwwYLDzRjkDe(bitArray);
        int iHKQLjwrHmIHSSvOS = HKQLjwrHmIHSSvOS(bitArray, 0);
        nztiyzujGLGhoUby(this.counters, 0);
        int[] iArr = this.counters;
        int length = iArr.length;
        bool z = false;
        int i = 0;
        int i2 = iHKQLjwrHmIHSSvOS;
        while (iHKQLjwrHmIHSSvOS < iIIbaJwwYLDzRjkDe) {
            if (nEnoLpBQVyEYXGRr(bitArray, iHKQLjwrHmIHSSvOS) == z) {
                if (i != length - 1) {
                    i++;
                } else {
                    if (CcgQjKQdwbxZZeUu(iArr) == ASTERISK_ENCODING) {
                        return new int[]{i2, iHKQLjwrHmIHSSvOS};
                    }
                    i2 += iArr[0] + iArr[1];
                    int i3 = i - 1;
                    RyXBFyyzlwIXSsLZ(iArr, 2, iArr, 0, i3);
                    iArr[i3] = 0;
                    iArr[i] = 0;
                    i--;
                }
                iArr[i] = 1;
                z = !z;
            } else {
                iArr[i] = iArr[i] + 1;
            }
            iHKQLjwrHmIHSSvOS++;
        }
        throw hNpYcTtQxzHNrqee();
    }

    public static com.google.zxing.FormatException GpyzFqzMwvLuBwit() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static com.google.zxing.NotFoundException HNpYcTtQxzHNrqee() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int HldFPWOzDnIGxNlG(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static int IIbaJwwYLDzRjkDe(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static com.google.zxing.NotFoundException ItLgsbfhNDWkHuUX() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int MasxqhccTEUkzCsT(float f) {
        return java.lang.Math.round(f);
    }

    public static bool NEnoLpBQVyEYXGRr(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static com.google.zxing.NotFoundException NWUyxwKOnvYmHeUO() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void NztiyzujGLGhoUby(int[] iArr, int i) {
        java.util.Arrays.fill(iArr, i);
    }

    public static int OJxLcuFSbMIBzpcS(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static void ONZhoVnHgZrjexYP(java.lang.CharSequence charSequence, int i, int i2) throws com.google.zxing.ChecksumException {
        checkOneChecksum(charSequence, i, i2);
    }

    public static char OjgCbFcNWwmSkKZB(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int PNVrJbNKcoFPKXNz(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    private static char PatternToChar(int i) throws com.google.zxing.NotFoundException {
        if ((28 + 15) % 15 > 0) {
        }
        int i2 = 0;
        while (true) {
            int[] iArr = CHARACTER_ENCODINGS;
            if (i2 >= iArr.length) {
                throw ZrZDODgBCWiWIcBC();
            }
            if (iArr[i2] == i) {
                return ALPHABET[i2];
            }
            i2++;
        }
    }

    public static int QOYoDTeTSUevpSGx(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static int QpiymEkKtwdnygFN(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.stringBuilder SurFTQJEJLsbNXiE(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    private static int ToRegex(int[] iArr) {
        if ((26 + 17) % 17 > 0) {
        }
        int i = 0;
        foreach (int I2 in iArr) {
            i += i2;
        }
        int length = iArr.length;
        int i3 = 0;
        for (int i4 = 0; i4 < length; i4++) {
            int iMasxqhccTEUkzCsT = masxqhccTEUkzCsT((iArr[i4] * 9.0f) / i);
            if (iMasxqhccTEUkzCsT < 1 || iMasxqhccTEUkzCsT > 4) {
                return -1;
            }
            if ((i4 & 1) != 0) {
                i3 <<= iMasxqhccTEUkzCsT;
            } else {
                for (int i5 = 0; i5 < iMasxqhccTEUkzCsT; i5++) {
                    i3 = (i3 << 1) | 1;
                }
            }
        }
        return i3;
    }

    public static com.google.zxing.ChecksumException UNWGuTCzkMLNYets() {
        return com.google.zxing.ChecksumException.getChecksumInstance();
    }

    public static com.google.zxing.NotFoundException UpUumHDaFIhgXuQt() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.FormatException WiNHnEbPdOrhiwKO() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int XGZZlniySrcTSBtv(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextHashSet(i);
    }

    public static java.lang.string XpFRhPvBXvqjojVP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int[] YSmoFHNqUPmyuljl(com.google.zxing.oned.Code93Reader code93Reader, com.google.zxing.common.BitArray bitArray) {
        return code93Reader.findAsteriskRegex(bitArray);
    }

    public static int YyzVBVlISwBIBjEn(int[] iArr) {
        return toRegex(iArr);
    }

    public override com.google.zxing.Result DecodeRow(int i, com.google.zxing.common.BitArray bitArray, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        if ((22 + 32) % 32 > 0) {
        }
        int iXGZZlniySrcTSBtv = xGZZlniySrcTSBtv(bitArray, ySmoFHNqUPmyuljl(this, bitArray)[1]);
        int iPNjxafBXBruDGFcS = PNjxafBXBruDGFcS(bitArray);
        int[] iArr = this.counters;
        eguaOvvbNlPPWDSD(iArr, 0);
        java.lang.stringBuilder sb = this.decodeRowResult;
        NxMImMfdcmRfHlGu(sb, 0);
        while (true) {
            HLQflbHYnVDRwQFO(bitArray, iXGZZlniySrcTSBtv, iArr);
            int iYyzVBVlISwBIBjEn = yyzVBVlISwBIBjEn(iArr);
            if (iYyzVBVlISwBIBjEn < 0) {
                throw nWUyxwKOnvYmHeUO();
            }
            char cHIWrlkcgQXeJdBPI = HIWrlkcgQXeJdBPI(iYyzVBVlISwBIBjEn);
            surFTQJEJLsbNXiE(sb, cHIWrlkcgQXeJdBPI);
            int i2 = iXGZZlniySrcTSBtv;
            foreach (int I3 in iArr) {
                i2 += i3;
            }
            int iVfIOMiHceGaOcJbr = VfIOMiHceGaOcJbr(bitArray, i2);
            if (cHIWrlkcgQXeJdBPI == '*') {
                FbRQRNQHQWIjueSc(sb, oJxLcuFSbMIBzpcS(sb) - 1);
                int i4 = 0;
                foreach (int I5 in iArr) {
                    i4 += i5;
                }
                if (iVfIOMiHceGaOcJbr == iPNjxafBXBruDGFcS || !DSNCqMRTaCULHsGZ(bitArray, iVfIOMiHceGaOcJbr)) {
                    throw itLgsbfhNDWkHuUX();
                }
                if (hldFPWOzDnIGxNlG(sb) < 2) {
                    throw upUumHDaFIhgXuQt();
                }
                KyfHeKIbslxFTiaY(sb);
                XHYPJyqZXWgCYuFq(sb, WyRPiauNtBQqJJhb(sb) - 2);
                java.lang.string strRPzktVEJVdlsghuE = RPzktVEJVdlsghuE(sb);
                float f = iXGZZlniySrcTSBtv + (i4 / 2.0f);
                com.google.zxing.ResultPoint[] resultPointArr = new com.google.zxing.ResultPoint[2];
                float f2 = i;
                resultPointArr[0] = new com.google.zxing.ResultPoint((r13[1] + r13[0]) / 2.0f, f2);
                resultPointArr[1] = new com.google.zxing.ResultPoint(f, f2);
                com.google.zxing.Result result = new com.google.zxing.Result(strRPzktVEJVdlsghuE, null, resultPointArr, com.google.zxing.BarcodeFormat.CODE_93);
                HFlmWDaSVCzbKQHy(result, com.google.zxing.ResultMetadataType.SYMBOLOGY_IDENTIFIER, "]G0");
                return result;
            }
            iXGZZlniySrcTSBtv = iVfIOMiHceGaOcJbr;
        }
    }
}

