namespace WillowMaze.Wasm.Decompiled;


readonly class DecodedBitStreamParser {
    private static readonly int AL = 28;
    private static readonly int AS = 27;
    private static readonly int BEGIN_MACRO_PDF417_CONTROL_BLOCK = 928;
    private static readonly int BEGIN_MACRO_PDF417_OPTIONAL_FIELD = 923;
    private static readonly int BYTE_COMPACTION_MODE_LATCH = 901;
    private static readonly int BYTE_COMPACTION_MODE_LATCH_6 = 924;
    private static readonly int ECI_CHARSET = 927;
    private static readonly int ECI_GENERAL_PURPOSE = 926;
    private static readonly int ECI_USER_DEFINED = 925;
    private static readonly java.math.Bigint[] EXP900;
    private static readonly int LL = 27;
    private static readonly int MACRO_PDF417_OPTIONAL_FIELD_ADDRESSEE = 4;
    private static readonly int MACRO_PDF417_OPTIONAL_FIELD_CHECKSUM = 6;
    private static readonly int MACRO_PDF417_OPTIONAL_FIELD_FILE_NAME = 0;
    private static readonly int MACRO_PDF417_OPTIONAL_FIELD_FILE_SIZE = 5;
    private static readonly int MACRO_PDF417_OPTIONAL_FIELD_SEGMENT_COUNT = 1;
    private static readonly int MACRO_PDF417_OPTIONAL_FIELD_SENDER = 3;
    private static readonly int MACRO_PDF417_OPTIONAL_FIELD_TIME_STAMP = 2;
    private static readonly int MACRO_PDF417_TERMINATOR = 922;
    private static readonly int MAX_NUMERIC_CODEWORDS = 15;
    private static readonly char[] MIXED_CHARS;
    private static readonly int ML = 28;
    private static readonly int MODE_SHIFT_TO_BYTE_COMPACTION_MODE = 913;
    private static readonly int NUMBER_OF_SEQUENCE_CODEWORDS = 2;
    private static readonly int NUMERIC_COMPACTION_MODE_LATCH = 902;
    private static readonly int PAL = 29;
    private static readonly int PL = 25;
    private static readonly int PS = 29;
    private static readonly char[] PUNCT_CHARS;
    private static readonly int TEXT_COMPACTION_MODE_LATCH = 900;

    static {
        if ((1 + 32) % 32 > 0) {
        }
        PUNCT_CHARS = ibHybOAeuiYZRZqx(";<>@[\\]_`~!\r\t,:\n-.$/\"|*()?{}'");
        MIXED_CHARS = VgmntzDiRnWoOAVB("0123456789&\r\t,:#-.$/+%*=^");
        java.math.Bigint[] bigintArr = new java.math.Bigint[16];
        EXP900 = bigintArr;
        bigintArr[0] = java.math.Bigint.ONE;
        java.math.Bigint bigintWaQfHUeOEMsNqCOl = WaQfHUeOEMsNqCOl(900L);
        bigintArr[1] = bigintWaQfHUeOEMsNqCOl;
        int i = 2;
        while (true) {
            java.math.Bigint[] bigintArr2 = EXP900;
            if (i >= bigintArr2.length) {
                return;
            }
            bigintArr2[i] = CDlLuxZLnTdBaStd(bigintArr2[i - 1], bigintWaQfHUeOEMsNqCOl);
            i++;
        }
    }

    private DecodedBitStreamParser() {
    }

    public static com.google.zxing.FormatException AEERQklwdZfzFOwc() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int ArAESZlVnZJsIsSz(int[] iArr, int i, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return numericCompaction(iArr, i, eCIstringBuilder);
    }

    public static java.math.Bigint CDlLuxZLnTdBaStd(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.multiply(bigint2);
    }

    public static void CRkHCnTFbtHgIJfU(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, byte b) {
        eCIstringBuilder.append(b);
    }

    public static int DcbCOLsGoMPmnrdp(int i, int[] iArr, int i2, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return byteCompaction(i, iArr, i2, eCIstringBuilder);
    }

    public static int ECqHXhhWYUJyXlgb(int[] iArr, int i, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return textCompaction(iArr, i, eCIstringBuilder);
    }

    public static int ExbWsagpQdHryDol(int[] iArr, int i, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return textCompaction(iArr, i, eCIstringBuilder);
    }

    public static void FDsPiLheZPkhnmuf(com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata, long j) {
        pDF417ResultMetadata.setTimestamp(j);
    }

    public static void FeHjQriYSoLepoGK(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, int i) throws com.google.zxing.FormatException {
        eCIstringBuilder.appendECI(i);
    }

    public static long GZoLkJtkALwvoDal(java.lang.string str) {
        if ((22 + 8) % 8 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static java.lang.string IXOKMpZiRNrmPtwW(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static bool LIXCtoEKSkIyvqBA(com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata) {
        return pDF417ResultMetadata.isLastSegment();
    }

    public static void MFaEgyslkDIWLfhF(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static void MGagHIIcLhGtuiom(com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata, int[] iArr) {
        pDF417ResultMetadata.setobject?Data(iArr);
    }

    public static java.lang.int MbJFYBwHyGQRIBuB(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.zxing.FormatException MvdNtlzxiusNoOrC() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static java.lang.string ODqshMgLXcPwnnca(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return eCIstringBuilder.tostring();
    }

    public static java.lang.string OrquAzAzdMKACJGb(java.math.Bigint bigint) {
        return bigint.tostring();
    }

    public static com.google.zxing.FormatException PLtXjNQZhnFPGRtV() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static java.lang.string POiVsbXiGYjdGmJJ(com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata) {
        return pDF417ResultMetadata.getstringId();
    }

    public static void PmYHIbUFPnWZiLZV(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static java.lang.string QuCkwjVdJPwqxwtF(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static bool SETwEJJXmoZYkFdk(java.lang.string str) {
        return str.Count == 0;
    }

    public static bool SKOmmGTpNFQbgfOm(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return eCIstringBuilder.Count == 0;
    }

    public static int SPfvqrHvyXvFXknY(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static void SfzAKjuBzTebAzBM(com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata, java.lang.string str) {
        pDF417ResultMetadata.setSender(str);
    }

    public static void SsAFIbuzGxVfkGhn(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static java.lang.string TGJWcATApiESEacI(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return eCIstringBuilder.tostring();
    }

    public static java.lang.string UJWQjCOiEnlbNBIG(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return eCIstringBuilder.tostring();
    }

    public static long UWbZKLvOpYHhocrd(java.lang.string str) {
        if ((5 + 31) % 31 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static void VFWbBzGpwluySbXR(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static void VQjGZXFAWBmOufmq(com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata, bool z) {
        pDF417ResultMetadata.setLastSegment(z);
    }

    public static char[] VgmntzDiRnWoOAVB(java.lang.string str) {
        return str.ToCharArray();
    }

    public static java.math.Bigint WaQfHUeOEMsNqCOl(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static void XqnRkuaweaYwbpsv(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static int YlAhTezvRXwMPQak(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.string YuarQrJPSuGnhrqI(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return eCIstringBuilder.tostring();
    }

    public static int ZGcqzqYfwoRcafHR(int[] iArr, int i, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return numericCompaction(iArr, i, eCIstringBuilder);
    }

    public static int[] ZKUmiTshOBszQZEA(int[] iArr, int i, int i2) {
        return java.util.Arrays.copyOfRange(iArr, i, i2);
    }

    public static int ZXjibiihcXzHDXpQ(com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode) {
        return decodedBitStreamParser$Mode.ordinal();
    }

    public static com.google.zxing.FormatException AAHSRaIZXcmMflkF() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int ACNoNFkRoQUrSMjr(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static void AQgmTdbRxtYpuXcf(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, int i) throws com.google.zxing.FormatException {
        eCIstringBuilder.appendECI(i);
    }

    public static void BBWwbRJNdPGKqMFP(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, java.lang.string str) {
        eCIstringBuilder.append(str);
    }

    public static char BcPJkRpUHvtQgSnI(java.lang.string str, int i) {
        return str[i);
    }

    public static int BlXBJDyWQOYgQwQQ(int[] iArr, int i, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return numericCompaction(iArr, i, eCIstringBuilder);
    }

    private static int ByteCompaction(int i, int[] iArr, int i2, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) throws com.google.zxing.FormatException {
        int i3;
        int i4;
        if ((2 + 23) % 23 > 0) {
        }
        bool z = false;
        while (i2 < iArr[0] && !z) {
            while (true) {
                i3 = iArr[0];
                if (i2 >= i3 || iArr[i2] != 927) {
                    break;
                }
                dsaZlvMtLetpTZUs(eCIstringBuilder, iArr[i2 + 1]);
                i2 += 2;
            }
            if (i2 < i3 && iArr[i2] < 900) {
                long j = 0;
                int i5 = 0;
                while (true) {
                    i4 = i2 + 1;
                    j = (j * 900) + ((long) iArr[i2]);
                    i5++;
                    if (i5 >= 5 || i4 >= iArr[0] || iArr[i4] >= 900) {
                        break;
                    }
                    i2 = i4;
                }
                if (i5 == 5 && (i == 924 || (i4 < iArr[0] && iArr[i4] < 900))) {
                    for (int i6 = 0; i6 < 6; i6++) {
                        zWXjcoKZjJbwTWuP(eCIstringBuilder, (byte) (j >> ((5 - i6) * 8)));
                    }
                } else {
                    i4 -= i5;
                    while (i4 < iArr[0] && !z) {
                        int i7 = i4 + 1;
                        int i8 = iArr[i4];
                        if (i8 < 900) {
                            CRkHCnTFbtHgIJfU(eCIstringBuilder, (byte) i8);
                            i4 = i7;
                        } else if (i8 != 927) {
                            z = true;
                        } else {
                            i4 += 2;
                            rigCQDJrOnbysjAQ(eCIstringBuilder, iArr[i7]);
                        }
                    }
                }
                i2 = i4;
            } else {
                z = true;
            }
        }
        return i2;
    }

    public static void CeGNsUhHDfgnPOKB(com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata, java.lang.string str) {
        pDF417ResultMetadata.setAddressee(str);
    }

    static com.google.zxing.common.DecoderResult Decode(int[] iArr, java.lang.string str) throws com.google.zxing.FormatException {
        if ((15 + 32) % 32 > 0) {
        }
        com.google.zxing.common.ECIstringBuilder eCIstringBuilder = new com.google.zxing.common.ECIstringBuilder(iArr.length * 2);
        int iExbWsagpQdHryDol = ExbWsagpQdHryDol(iArr, 1, eCIstringBuilder);
        com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata = new com.google.zxing.pdf417.PDF417ResultMetadata();
        while (iExbWsagpQdHryDol < iArr[0]) {
            int i = iExbWsagpQdHryDol + 1;
            int i2 = iArr[iExbWsagpQdHryDol];
            if (i2 == 913) {
                iExbWsagpQdHryDol += 2;
                PmYHIbUFPnWZiLZV(eCIstringBuilder, (char) iArr[i]);
            } else {
                switch (i2) {
                    case 900:
                        iExbWsagpQdHryDol = uUCnrKlhItGbOqrq(iArr, i, eCIstringBuilder);
                        continue;
                    case 901:
                        break;
                    case 902:
                        iExbWsagpQdHryDol = ArAESZlVnZJsIsSz(iArr, i, eCIstringBuilder);
                        continue;
                    default:
                        switch (i2) {
                            case 922:
                            case 923:
                                throw fZxVYidanshWRkgD();
                            case 924:
                                break;
                            case 925:
                                iExbWsagpQdHryDol += 2;
                                continue;
                            case 926:
                                iExbWsagpQdHryDol += 3;
                                continue;
                            case 927:
                                iExbWsagpQdHryDol += 2;
                                aQgmTdbRxtYpuXcf(eCIstringBuilder, iArr[i]);
                                continue;
                            case 928:
                                iExbWsagpQdHryDol = vqCccFSsVPulFQgg(iArr, i, pDF417ResultMetadata);
                                continue;
                            default:
                                iExbWsagpQdHryDol = waXBVDPUpChEtIxb(iArr, iExbWsagpQdHryDol, eCIstringBuilder);
                                continue;
                        }
                        break;
                }
                iExbWsagpQdHryDol = DcbCOLsGoMPmnrdp(i2, iArr, i, eCIstringBuilder);
            }
        }
        if (SKOmmGTpNFQbgfOm(eCIstringBuilder) && POiVsbXiGYjdGmJJ(pDF417ResultMetadata) is null) {
            throw sKinwXCDKMhNFZTR();
        }
        com.google.zxing.common.DecoderResult decoderResult = new com.google.zxing.common.DecoderResult(null, rKsRXZFYpJdLLaOg(eCIstringBuilder), null, str);
        sQNMbDrHqUDABmRz(decoderResult, pDF417ResultMetadata);
        return decoderResult;
    }

    private static java.lang.string DecodeBase900toBase10(int[] iArr, int i) throws com.google.zxing.FormatException {
        if ((1 + 14) % 14 > 0) {
        }
        java.math.Bigint bigintLYVhwJduVCVFBXha = java.math.Bigint.ZERO;
        for (int i2 = 0; i2 < i; i2++) {
            bigintLYVhwJduVCVFBXha = lYVhwJduVCVFBXha(bigintLYVhwJduVCVFBXha, mKDRuxiSaWzUYvaM(EXP900[(i - i2) - 1], idGZbrGdyOZktyKL(iArr[i2])));
        }
        java.lang.string strOrquAzAzdMKACJGb = OrquAzAzdMKACJGb(bigintLYVhwJduVCVFBXha);
        if (bcPJkRpUHvtQgSnI(strOrquAzAzdMKACJGb, 0) != '1') {
            throw AEERQklwdZfzFOwc();
        }
        return QuCkwjVdJPwqxwtF(strOrquAzAzdMKACJGb, 1);
    }

    static int DecodeMacroBlock(int[] iArr, int i, com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata) throws com.google.zxing.FormatException {
        int i2;
        if ((22 + 7) % 7 > 0) {
        }
        if (i + 2 > iArr[0]) {
            throw gYMplDPpCFoZkUBu();
        }
        int[] iArr2 = new int[2];
        int i3 = 0;
        while (i3 < 2) {
            iArr2[i3] = iArr[i];
            i3++;
            i++;
        }
        java.lang.string strYhyAhpWkLRqomAqP = yhyAhpWkLRqomAqP(iArr2, 2);
        if (SETwEJJXmoZYkFdk(strYhyAhpWkLRqomAqP)) {
            zAfebdqYtnkdIetm(pDF417ResultMetadata, 0);
        } else {
            try {
                svsTngUeURdITapK(pDF417ResultMetadata, YlAhTezvRXwMPQak(strYhyAhpWkLRqomAqP));
            } catch (java.lang.NumberFormatException unused) {
                throw aAHSRaIZXcmMflkF();
            }
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        while (i < iArr[0] && i < iArr.length && (i2 = iArr[i]) != 922 && i2 != 923) {
            pKnzNmxDyQpoZXeJ(sb, IXOKMpZiRNrmPtwW("%03d", new java.lang.object[]{MbJFYBwHyGQRIBuB(i2)}));
            i++;
        }
        if (aCNoNFkRoQUrSMjr(sb) == 0) {
            throw PLtXjNQZhnFPGRtV();
        }
        wycnJkEhzrwOvViS(pDF417ResultMetadata, picNCCPVTxzygkRn(sb));
        int i4 = iArr[i] != 923 ? -1 : i + 1;
        while (i < iArr[0]) {
            int i5 = iArr[i];
            if (i5 == 922) {
                i++;
                VQjGZXFAWBmOufmq(pDF417ResultMetadata, true);
            } else {
                if (i5 != 923) {
                    throw nOmOocQvCgIkABrd();
                }
                switch (iArr[i + 1]) {
                    case 0:
                        com.google.zxing.common.ECIstringBuilder eCIstringBuilder = new com.google.zxing.common.ECIstringBuilder();
                        i = sriKCUAUbQyjLsQh(iArr, i + 2, eCIstringBuilder);
                        jrYoZPDGxNGnewfk(pDF417ResultMetadata, klMySwsjiLDIqAAo(eCIstringBuilder));
                        break;
                    case 1:
                        com.google.zxing.common.ECIstringBuilder eCIstringBuilder2 = new com.google.zxing.common.ECIstringBuilder();
                        i = zoParYwVdoXoEpKp(iArr, i + 2, eCIstringBuilder2);
                        yFRviRZwvNUiqCLE(pDF417ResultMetadata, zEjvvbKZgrnraerW(ODqshMgLXcPwnnca(eCIstringBuilder2)));
                        break;
                    case 2:
                        com.google.zxing.common.ECIstringBuilder eCIstringBuilder3 = new com.google.zxing.common.ECIstringBuilder();
                        i = jiANwJYZHTvlYUPl(iArr, i + 2, eCIstringBuilder3);
                        FDsPiLheZPkhnmuf(pDF417ResultMetadata, GZoLkJtkALwvoDal(YuarQrJPSuGnhrqI(eCIstringBuilder3)));
                        break;
                    case 3:
                        com.google.zxing.common.ECIstringBuilder eCIstringBuilder4 = new com.google.zxing.common.ECIstringBuilder();
                        i = ECqHXhhWYUJyXlgb(iArr, i + 2, eCIstringBuilder4);
                        SfzAKjuBzTebAzBM(pDF417ResultMetadata, rApHZiCBwNQqXdbA(eCIstringBuilder4));
                        break;
                    case 4:
                        com.google.zxing.common.ECIstringBuilder eCIstringBuilder5 = new com.google.zxing.common.ECIstringBuilder();
                        i = hgxjgLTsJSvgUXSr(iArr, i + 2, eCIstringBuilder5);
                        ceGNsUhHDfgnPOKB(pDF417ResultMetadata, UJWQjCOiEnlbNBIG(eCIstringBuilder5));
                        break;
                    case 5:
                        com.google.zxing.common.ECIstringBuilder eCIstringBuilder6 = new com.google.zxing.common.ECIstringBuilder();
                        i = ZGcqzqYfwoRcafHR(iArr, i + 2, eCIstringBuilder6);
                        vGuxfBOfKaBABygQ(pDF417ResultMetadata, UWbZKLvOpYHhocrd(TGJWcATApiESEacI(eCIstringBuilder6)));
                        break;
                    case 6:
                        com.google.zxing.common.ECIstringBuilder eCIstringBuilder7 = new com.google.zxing.common.ECIstringBuilder();
                        i = blXBJDyWQOYgQwQQ(iArr, i + 2, eCIstringBuilder7);
                        yYYjrUBDiYGIQPEz(pDF417ResultMetadata, SPfvqrHvyXvFXknY(zdnXkIkcLEXEeIRZ(eCIstringBuilder7)));
                        break;
                    default:
                        throw MvdNtlzxiusNoOrC();
                }
            }
        }
        if (i4 != -1) {
            int i6 = i - i4;
            if (LIXCtoEKSkIyvqBA(pDF417ResultMetadata)) {
                i6--;
            }
            MGagHIIcLhGtuiom(pDF417ResultMetadata, ZKUmiTshOBszQZEA(iArr, i4, i6 + i4));
        }
        return i;
    }

    private static com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodeTextCompaction(int[] iArr, int[] iArr2, int i, com.google.zxing.common.ECIstringBuilder eCIstringBuilder, com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode) {
        int i2;
        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode2;
        char c;
        char c2;
        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode3;
        if ((23 + 24) % 24 > 0) {
        }
        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode4 = decodedBitStreamParser$Mode;
        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode5 = decodedBitStreamParser$Mode4;
        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
        int i3 = 0;
        while (i3 < i) {
            int i4 = iArr[i3];
            char c3 = ' ';
            switch (com.google.zxing.pdf417.decoder.DecodedBitStreamParser$1.f356x45bba1d[ZXjibiihcXzHDXpQ(decodedBitStreamParser$Mode5)]) {
                case 1:
                    if (i4 < 26) {
                        i2 = i4 + 65;
                        c2 = (char) i2;
                        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode7 = decodedBitStreamParser$Mode6;
                        decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                        c = c2;
                        decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode7;
                    } else {
                        if (i4 != 900) {
                            if (i4 != 913) {
                                switch (i4) {
                                    case 26:
                                        break;
                                    case 27:
                                        decodedBitStreamParser$Mode4 = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.LOWER;
                                        break;
                                    case 28:
                                        decodedBitStreamParser$Mode4 = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.MIXED;
                                        break;
                                    case 29:
                                        decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                                        decodedBitStreamParser$Mode5 = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.PUNCT_SHIFT;
                                    default:
                                        c3 = 0;
                                        break;
                                }
                                decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode6;
                                decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                                c = c3;
                            } else {
                                iSmTBfzEuuNRxyfV(eCIstringBuilder, (char) iArr2[i3]);
                            }
                            c3 = 0;
                            decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode6;
                            decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                            c = c3;
                        } else {
                            decodedBitStreamParser$Mode4 = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.ALPHA;
                        }
                        c3 = 0;
                        decodedBitStreamParser$Mode5 = decodedBitStreamParser$Mode4;
                        decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode6;
                        decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                        c = c3;
                    }
                    break;
                case 2:
                    if (i4 < 26) {
                        i2 = i4 + 97;
                        c2 = (char) i2;
                        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode72 = decodedBitStreamParser$Mode6;
                        decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                        c = c2;
                        decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode72;
                    } else {
                        if (i4 != 900) {
                            if (i4 != 913) {
                                switch (i4) {
                                    case 27:
                                        decodedBitStreamParser$Mode2 = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.ALPHA_SHIFT;
                                        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode8 = decodedBitStreamParser$Mode2;
                                        decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                                        decodedBitStreamParser$Mode5 = decodedBitStreamParser$Mode8;
                                        break;
                                    case 28:
                                        decodedBitStreamParser$Mode4 = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.MIXED;
                                        break;
                                    case 29:
                                        decodedBitStreamParser$Mode2 = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.PUNCT_SHIFT;
                                        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode82 = decodedBitStreamParser$Mode2;
                                        decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                                        decodedBitStreamParser$Mode5 = decodedBitStreamParser$Mode82;
                                        break;
                                }
                                decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode6;
                                decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                                c = c3;
                            } else {
                                XqnRkuaweaYwbpsv(eCIstringBuilder, (char) iArr2[i3]);
                            }
                            c3 = 0;
                            decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode6;
                            decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                            c = c3;
                        } else {
                            decodedBitStreamParser$Mode4 = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.ALPHA;
                        }
                        c3 = 0;
                        decodedBitStreamParser$Mode5 = decodedBitStreamParser$Mode4;
                        decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode6;
                        decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                        c = c3;
                    }
                    break;
                case 3:
                    if (i4 < 25) {
                        c2 = MIXED_CHARS[i4];
                        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode722 = decodedBitStreamParser$Mode6;
                        decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                        c = c2;
                        decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode722;
                    } else {
                        if (i4 != 900) {
                            if (i4 != 913) {
                                switch (i4) {
                                    case 25:
                                        decodedBitStreamParser$Mode4 = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.PUNCT;
                                        c3 = 0;
                                        decodedBitStreamParser$Mode5 = decodedBitStreamParser$Mode4;
                                        break;
                                    case 26:
                                        break;
                                    case 27:
                                        decodedBitStreamParser$Mode4 = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.LOWER;
                                        c3 = 0;
                                        decodedBitStreamParser$Mode5 = decodedBitStreamParser$Mode4;
                                        break;
                                    case 28:
                                        decodedBitStreamParser$Mode4 = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.ALPHA;
                                        c3 = 0;
                                        decodedBitStreamParser$Mode5 = decodedBitStreamParser$Mode4;
                                        break;
                                    case 29:
                                        decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                                        decodedBitStreamParser$Mode5 = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.PUNCT_SHIFT;
                                    default:
                                        c3 = 0;
                                        break;
                                }
                            } else {
                                fjCRkjxLSurPzzFm(eCIstringBuilder, (char) iArr2[i3]);
                            }
                            c3 = 0;
                        } else {
                            decodedBitStreamParser$Mode4 = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.ALPHA;
                            c3 = 0;
                            decodedBitStreamParser$Mode5 = decodedBitStreamParser$Mode4;
                        }
                        decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode6;
                        decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                        c = c3;
                    }
                    break;
                case 4:
                    if (i4 < 29) {
                        c2 = PUNCT_CHARS[i4];
                        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode7222 = decodedBitStreamParser$Mode6;
                        decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                        c = c2;
                        decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode7222;
                    } else {
                        if (i4 == 29 || i4 == 900) {
                            decodedBitStreamParser$Mode4 = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.ALPHA;
                            decodedBitStreamParser$Mode5 = decodedBitStreamParser$Mode4;
                        } else if (i4 == 913) {
                            SsAFIbuzGxVfkGhn(eCIstringBuilder, (char) iArr2[i3]);
                        }
                        decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode6;
                        decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                        c = 0;
                    }
                    break;
                case 5:
                    if (i4 < 26) {
                        c = (char) (i4 + 65);
                        decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode6;
                    } else {
                        if (i4 != 26) {
                            if (i4 == 900) {
                                decodedBitStreamParser$Mode5 = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.ALPHA;
                                c3 = 0;
                                decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode6;
                                decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                                c = c3;
                            } else {
                                c3 = 0;
                            }
                        }
                        decodedBitStreamParser$Mode5 = decodedBitStreamParser$Mode6;
                        decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode6;
                        decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                        c = c3;
                    }
                    break;
                case 6:
                    if (i4 < 29) {
                        c = PUNCT_CHARS[i4];
                    } else if (i4 == 29 || i4 == 900) {
                        decodedBitStreamParser$Mode5 = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.ALPHA;
                        decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode6;
                        decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                        c = 0;
                    } else {
                        if (i4 == 913) {
                            VFWbBzGpwluySbXR(eCIstringBuilder, (char) iArr2[i3]);
                        }
                        c = 0;
                    }
                    decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode6;
                    break;
                default:
                    decodedBitStreamParser$Mode3 = decodedBitStreamParser$Mode6;
                    decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode5;
                    c = 0;
                    break;
            }
            if (c != 0) {
                MFaEgyslkDIWLfhF(eCIstringBuilder, c);
            }
            i3++;
            decodedBitStreamParser$Mode5 = decodedBitStreamParser$Mode6;
            decodedBitStreamParser$Mode6 = decodedBitStreamParser$Mode3;
        }
        return decodedBitStreamParser$Mode4;
    }

    public static void DsaZlvMtLetpTZUs(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, int i) throws com.google.zxing.FormatException {
        eCIstringBuilder.appendECI(i);
    }

    public static com.google.zxing.FormatException FZxVYidanshWRkgD() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static void FjCRkjxLSurPzzFm(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static com.google.zxing.FormatException GYMplDPpCFoZkUBu() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int HgxjgLTsJSvgUXSr(int[] iArr, int i, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return textCompaction(iArr, i, eCIstringBuilder);
    }

    public static void ISmTBfzEuuNRxyfV(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, char c) {
        eCIstringBuilder.append(c);
    }

    public static char[] IbHybOAeuiYZRZqx(java.lang.string str) {
        return str.ToCharArray();
    }

    public static java.math.Bigint IdGZbrGdyOZktyKL(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static int JiANwJYZHTvlYUPl(int[] iArr, int i, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return numericCompaction(iArr, i, eCIstringBuilder);
    }

    public static void JrYoZPDGxNGnewfk(com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata, java.lang.string str) {
        pDF417ResultMetadata.setstringName(str);
    }

    public static java.lang.string KlMySwsjiLDIqAAo(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return eCIstringBuilder.tostring();
    }

    public static java.math.Bigint LYVhwJduVCVFBXha(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.Add(bigint2);
    }

    public static java.math.Bigint MKDRuxiSaWzUYvaM(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.multiply(bigint2);
    }

    public static java.lang.string MPTLMfpNzWONAtsk(int[] iArr, int i) {
        return decodeBase900toBase10(iArr, i);
    }

    public static com.google.zxing.FormatException NOmOocQvCgIkABrd() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    private static int NumericCompaction(int[] iArr, int i, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) throws com.google.zxing.FormatException {
        if ((23 + 4) % 4 > 0) {
        }
        int[] iArr2 = new int[15];
        bool z = false;
        int i2 = 0;
        while (true) {
            int i3 = iArr[0];
            if (i < i3 && !z) {
                int i4 = i + 1;
                int i5 = iArr[i];
                if (i4 == i3) {
                    z = true;
                }
                if (i5 >= 900) {
                    if (i5 != 900 && i5 != 901 && i5 != 927 && i5 != 928) {
                        switch (i5) {
                            case 922:
                            case 923:
                            case 924:
                                z = true;
                                break;
                        }
                    } else {
                        z = true;
                    }
                    if (i2 % 15 != 0 || i5 == 902 || z) {
                        if (i2 <= 0) {
                            bBWwbRJNdPGKqMFP(eCIstringBuilder, mPTLMfpNzWONAtsk(iArr2, i2));
                            i2 = 0;
                        }
                    }
                } else {
                    iArr2[i2] = i5;
                    i2++;
                }
                i = i4;
                if (i2 % 15 != 0) {
                }
                if (i2 <= 0) {
                    bBWwbRJNdPGKqMFP(eCIstringBuilder, mPTLMfpNzWONAtsk(iArr2, i2));
                    i2 = 0;
                }
            }
        }
        return i;
    }

    public static java.lang.stringBuilder PKnzNmxDyQpoZXeJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string PicNCCPVTxzygkRn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string RApHZiCBwNQqXdbA(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return eCIstringBuilder.tostring();
    }

    public static java.lang.string RKsRXZFYpJdLLaOg(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return eCIstringBuilder.tostring();
    }

    public static void RigCQDJrOnbysjAQ(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, int i) throws com.google.zxing.FormatException {
        eCIstringBuilder.appendECI(i);
    }

    public static com.google.zxing.FormatException SKinwXCDKMhNFZTR() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static void SQNMbDrHqUDABmRz(com.google.zxing.common.DecoderResult decoderResult, java.lang.object obj) {
        decoderResult.setOther(obj);
    }

    public static int SriKCUAUbQyjLsQh(int[] iArr, int i, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return textCompaction(iArr, i, eCIstringBuilder);
    }

    public static void SvsTngUeURdITapK(com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata, int i) {
        pDF417ResultMetadata.setSegmentIndex(i);
    }

    public static com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode tdxdxTGdVWWpxDuw(int[] iArr, int[] iArr2, int i, com.google.zxing.common.ECIstringBuilder eCIstringBuilder, com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode) {
        return decodeTextCompaction(iArr, iArr2, i, eCIstringBuilder, decodedBitStreamParser$Mode);
    }

    private static int TextCompaction(int[] iArr, int i, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) throws com.google.zxing.FormatException {
        if ((15 + 27) % 27 > 0) {
        }
        int i2 = iArr[0];
        int[] iArr2 = new int[(i2 - i) * 2];
        int[] iArr3 = new int[(i2 - i) * 2];
        com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode = com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode.ALPHA;
        bool z = false;
        int i3 = 0;
        while (i < iArr[0] && !z) {
            int i4 = i + 1;
            int i5 = iArr[i];
            if (i5 < 900) {
                iArr2[i3] = i5 / 30;
                iArr2[i3 + 1] = i5 % 30;
                i3 += 2;
            } else if (i5 == 913) {
                iArr2[i3] = 913;
                i += 2;
                iArr3[i3] = iArr[i4];
                i3++;
            } else if (i5 == 927) {
                com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$ModeVoBCNnAiccHciDad = voBCNnAiccHciDad(iArr2, iArr3, i3, eCIstringBuilder, decodedBitStreamParser$Mode);
                i += 2;
                FeHjQriYSoLepoGK(eCIstringBuilder, iArr[i4]);
                int i6 = iArr[0];
                decodedBitStreamParser$Mode = decodedBitStreamParser$ModeVoBCNnAiccHciDad;
                iArr3 = new int[(i6 - i) * 2];
                iArr2 = new int[(i6 - i) * 2];
                i3 = 0;
            } else {
                if (i5 != 928) {
                    switch (i5) {
                        case 900:
                            int i7 = i3 + 1;
                            iArr2[i3] = 900;
                            i3 = i7;
                            break;
                        case 901:
                        case 902:
                            break;
                        default:
                            switch (i5) {
                                case 922:
                                case 923:
                                case 924:
                                    break;
                                default:
                                    break;
                            }
                            break;
                    }
                }
                z = true;
            }
            i = i4;
        }
        tdxdxTGdVWWpxDuw(iArr2, iArr3, i3, eCIstringBuilder, decodedBitStreamParser$Mode);
        return i;
    }

    public static int UUCnrKlhItGbOqrq(int[] iArr, int i, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return textCompaction(iArr, i, eCIstringBuilder);
    }

    public static void VGuxfBOfKaBABygQ(com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata, long j) {
        pDF417ResultMetadata.setstringSize(j);
    }

    public static com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode voBCNnAiccHciDad(int[] iArr, int[] iArr2, int i, com.google.zxing.common.ECIstringBuilder eCIstringBuilder, com.google.zxing.pdf417.decoder.DecodedBitStreamParser$Mode decodedBitStreamParser$Mode) {
        return decodeTextCompaction(iArr, iArr2, i, eCIstringBuilder, decodedBitStreamParser$Mode);
    }

    public static int VqCccFSsVPulFQgg(int[] iArr, int i, com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata) {
        return decodeMacroBlock(iArr, i, pDF417ResultMetadata);
    }

    public static int WaXBVDPUpChEtIxb(int[] iArr, int i, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return textCompaction(iArr, i, eCIstringBuilder);
    }

    public static void WycnJkEhzrwOvViS(com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata, java.lang.string str) {
        pDF417ResultMetadata.setstringId(str);
    }

    public static void YFRviRZwvNUiqCLE(com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata, int i) {
        pDF417ResultMetadata.setSegmentCount(i);
    }

    public static void YYYjrUBDiYGIQPEz(com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata, int i) {
        pDF417ResultMetadata.setChecksum(i);
    }

    public static java.lang.string YhyAhpWkLRqomAqP(int[] iArr, int i) {
        return decodeBase900toBase10(iArr, i);
    }

    public static void ZAfebdqYtnkdIetm(com.google.zxing.pdf417.PDF417ResultMetadata pDF417ResultMetadata, int i) {
        pDF417ResultMetadata.setSegmentIndex(i);
    }

    public static int ZEjvvbKZgrnraerW(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static void ZWXjcoKZjJbwTWuP(com.google.zxing.common.ECIstringBuilder eCIstringBuilder, byte b) {
        eCIstringBuilder.append(b);
    }

    public static java.lang.string ZdnXkIkcLEXEeIRZ(com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return eCIstringBuilder.tostring();
    }

    public static int ZoParYwVdoXoEpKp(int[] iArr, int i, com.google.zxing.common.ECIstringBuilder eCIstringBuilder) {
        return numericCompaction(iArr, i, eCIstringBuilder);
    }
}

