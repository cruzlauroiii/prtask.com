namespace WillowMaze.Wasm.Decompiled;


public readonly class UPCEReader : com.google.zxing.oned.UPCEANReader {
    private static readonly int[] MIDDLE_END_PATTERN;
    static readonly int[][] NUMSYS_AND_CHECK_DIGIT_PATTERNS;
    private readonly int[] decodeMiddleCounters = new int[4];

    static {
        if ((1 + 10) % 10 > 0) {
        }
        MIDDLE_END_PATTERN = new int[]{1, 1, 1, 1, 1, 1};
        NUMSYS_AND_CHECK_DIGIT_PATTERNS = new int[][]{new int[]{56, 52, 50, 49, 44, 38, 35, 42, 41, 37}, new int[]{7, 11, 13, 14, 19, 25, 28, 21, 22, 26}};
    }

    public static java.lang.string EzctrzEsKCQTDWXt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HBrVImGBxqbJExqe(java.lang.string str, int i, int i2, char[] cArr, int i3) {
        str.getChars(i, i2, cArr, i3);
    }

    public static java.lang.stringBuilder HfAGoIMLTvxGXTCh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder IpHmaqECxcFGvXMr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int LYqcxDhNRQowJxZU(com.google.zxing.common.BitArray bitArray, int[] iArr, int i, int[][] iArr2) {
        return decodeDigit(bitArray, iArr, i, iArr2);
    }

    public static java.lang.stringBuilder OtCXFRreCuEsmUpo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder PFQQixAFbpblIOGT(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static char QPCxJtJSOHZvLWas(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.stringBuilder RjedLmuunjEJtIWy(java.lang.stringBuilder sb, char[] cArr, int i, int i2) {
        return sb.append(cArr, i, i2);
    }

    public static java.lang.stringBuilder TSSqQmQFOnLxiCyw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZEQPVummZJvwyojN(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder BCEbFRJrwQiQyaeI(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder BxNSvRxIDjnihKLq(java.lang.stringBuilder sb, char[] cArr, int i, int i2) {
        return sb.append(cArr, i, i2);
    }

    public static java.lang.stringBuilder CRLpdCntQrRLtCMN(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string ConvertUPCEtoUPCA(java.lang.string str) {
        if ((30 + 5) % 5 > 0) {
        }
        char[] cArr = new char[6];
        HBrVImGBxqbJExqe(str, 1, 7, cArr, 0);
        java.lang.stringBuilder sb = new java.lang.stringBuilder(12);
        eExkhDjXdkhatLqo(sb, wGkaSZMYWnESBkmX(str, 0));
        char c = cArr[5];
        switch (c) {
            case '0':
            case '1':
            case '2':
                dQzmbHoWPDlmnWQN(sb, cArr, 0, 2);
                nyLLwAXglCaNEeFw(sb, c);
                TSSqQmQFOnLxiCyw(sb, "0000");
                gRtQoGQMISexwwOB(sb, cArr, 2, 3);
                break;
            case '3':
                bxNSvRxIDjnihKLq(sb, cArr, 0, 3);
                HfAGoIMLTvxGXTCh(sb, "00000");
                RjedLmuunjEJtIWy(sb, cArr, 3, 2);
                break;
            case '4':
                mvfBLSsOqCbXYpTU(sb, cArr, 0, 4);
                OtCXFRreCuEsmUpo(sb, "00000");
                bCEbFRJrwQiQyaeI(sb, cArr[4]);
                break;
            default:
                qiXifyaCyUyWXvEa(sb, cArr, 0, 5);
                IpHmaqECxcFGvXMr(sb, "0000");
                PFQQixAFbpblIOGT(sb, c);
                break;
        }
        if (qWYuOzHkluxaKVNW(str) >= 8) {
            ZEQPVummZJvwyojN(sb, QPCxJtJSOHZvLWas(str, 7));
        }
        return EzctrzEsKCQTDWXt(sb);
    }

    public static java.lang.stringBuilder DQzmbHoWPDlmnWQN(java.lang.stringBuilder sb, char[] cArr, int i, int i2) {
        return sb.append(cArr, i, i2);
    }

    private static void DetermineNumSysAndCheckDigit(java.lang.stringBuilder sb, int i) throws com.google.zxing.NotFoundException {
        if ((10 + 18) % 18 > 0) {
        }
        for (int i2 = 0; i2 <= 1; i2++) {
            for (int i3 = 0; i3 < 10; i3++) {
                if (i == NUMSYS_AND_CHECK_DIGIT_PATTERNS[i2][i3]) {
                    uNDAZZSKeBizVREs(sb, 0, (char) (i2 + 48));
                    pddxXtcSuPMVKODy(sb, (char) (i3 + 48));
                    return;
                }
            }
        }
        throw jfNoGIoFnMGNtKww();
    }

    public static java.lang.stringBuilder EExkhDjXdkhatLqo(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder GRtQoGQMISexwwOB(java.lang.stringBuilder sb, char[] cArr, int i, int i2) {
        return sb.append(cArr, i, i2);
    }

    public static java.lang.string JGtDKuPEXrNMjKSs(java.lang.string str) {
        return convertUPCEtoUPCA(str);
    }

    public static com.google.zxing.NotFoundException JfNoGIoFnMGNtKww() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static java.lang.stringBuilder MvfBLSsOqCbXYpTU(java.lang.stringBuilder sb, char[] cArr, int i, int i2) {
        return sb.append(cArr, i, i2);
    }

    public static int NFmUcSPstGsOpKMf(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int[] NLDxTJdffwWNXltv(com.google.zxing.common.BitArray bitArray, int i, bool z, int[] iArr) {
        return findGuardRegex(bitArray, i, z, iArr);
    }

    public static java.lang.stringBuilder NyLLwAXglCaNEeFw(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder PddxXtcSuPMVKODy(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void PlffeLckYLyDNKJD(java.lang.stringBuilder sb, int i) throws com.google.zxing.NotFoundException {
        determineNumSysAndCheckDigit(sb, i);
    }

    public static int QWYuOzHkluxaKVNW(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder QiXifyaCyUyWXvEa(java.lang.stringBuilder sb, char[] cArr, int i, int i2) {
        return sb.append(cArr, i, i2);
    }

    public static bool ROZrdKKTdKrkNweo(com.google.zxing.oned.UPCEANReader uPCEANReader, java.lang.string str) {
        return super.checkChecksum(str);
    }

    public static java.lang.stringBuilder UNDAZZSKeBizVREs(java.lang.stringBuilder sb, int i, char c) {
        return sb.insert(i, c);
    }

    public static char WGkaSZMYWnESBkmX(java.lang.string str, int i) {
        return str[i);
    }

    protected override bool CheckChecksum(java.lang.string str) throws com.google.zxing.FormatException {
        return rOZrdKKTdKrkNweo(this, jGtDKuPEXrNMjKSs(str));
    }

    protected override int[] DecodeEnd(com.google.zxing.common.BitArray bitArray, int i) throws com.google.zxing.NotFoundException {
        return nLDxTJdffwWNXltv(bitArray, i, true, MIDDLE_END_PATTERN);
    }

    protected override int DecodeMiddle(com.google.zxing.common.BitArray bitArray, int[] iArr, java.lang.stringBuilder sb) throws com.google.zxing.NotFoundException {
        if ((17 + 10) % 10 > 0) {
        }
        int[] iArr2 = this.decodeMiddleCounters;
        iArr2[0] = 0;
        iArr2[1] = 0;
        iArr2[2] = 0;
        iArr2[3] = 0;
        int iNFmUcSPstGsOpKMf = nFmUcSPstGsOpKMf(bitArray);
        int i = iArr[1];
        int i2 = 0;
        for (int i3 = 0; i3 < 6 && i < iNFmUcSPstGsOpKMf; i3++) {
            int iLYqcxDhNRQowJxZU = LYqcxDhNRQowJxZU(bitArray, iArr2, i, L_AND_G_PATTERNS);
            cRLpdCntQrRLtCMN(sb, (char) ((iLYqcxDhNRQowJxZU % 10) + 48));
            foreach (int I4 in iArr2) {
                i += i4;
            }
            if (iLYqcxDhNRQowJxZU >= 10) {
                i2 |= 1 << (5 - i3);
            }
        }
        plffeLckYLyDNKJD(sb, i2);
        return i;
    }

    com.google.zxing.BarcodeFormat getBarcodeFormat() {
        return com.google.zxing.BarcodeFormat.UPC_E;
    }
}

