namespace WillowMaze.Wasm.Decompiled;


public readonly class Code39Reader : com.google.zxing.oned.OneDReader {
    static readonly java.lang.string ALPHABET_STRING = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%";
    static readonly int ASTERISK_ENCODING = 148;
    static readonly int[] CHARACTER_ENCODINGS = {52, 289, 97, 352, 49, 304, 112, 37, 292, 100, 265, 73, 328, 25, 280, 88, 13, 268, 76, 28, 259, 67, 322, 19, 274, 82, 7, 262, 70, 22, 385, 193, 448, 145, 400, 208, 133, 388, 196, 168, 162, 138, 42};
    private readonly int[] counters;
    private readonly java.lang.stringBuilder decodeRowResult;
    private readonly bool extendedMode;
    private readonly bool usingCheckDigit;

    public Code39Reader() {
        this(false);
    }

    public Code39Reader(bool z) {
        this(z, false);
    }

    public Code39Reader(bool z, bool z2) {
        this.usingCheckDigit = z;
        this.extendedMode = z2;
        this.decodeRowResult = new java.lang.stringBuilder(20);
        this.counters = new int[9];
    }

    public static void ANjAlbWNDEuvJZEl(int[] iArr, int i) {
        java.util.Arrays.fill(iArr, i);
    }

    public static char DFBBVeqnoQoxPXSx(java.lang.stringBuilder sb, int i) {
        return sb[i);
    }

    public static java.lang.string DSUbTKHyIgwoRBjc(java.lang.CharSequence charSequence) {
        return decodeExtended(charSequence);
    }

    public static java.lang.stringBuilder FonVaPlxsZGLmFpr(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static char GCUdVwHdwWjENiHh(java.lang.string str, int i) {
        return str[i);
    }

    public static com.google.zxing.NotFoundException GXEHrTwZksTnsapt() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int GwpfJFayhzBMlsHn(int[] iArr) {
        return toNarrowWideRegex(iArr);
    }

    public static int HFmelPcTPWInOtRz(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static java.lang.string HiAMZWALTByxBWBN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static char IJLGtcoaYFroDRZH(java.lang.stringBuilder sb, int i) {
        return sb[i);
    }

    public static java.lang.stringBuilder JCuHgoEPkNGxSjif(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int KyvEJwFvNZprUSBH(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static com.google.zxing.FormatException LcEJyAeZubwGaSdu() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static com.google.zxing.FormatException MeUZMstKArXULVfX() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static com.google.zxing.FormatException NcvZdxwLvqAeENKq() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static com.google.zxing.FormatException OXqpSWKhSVRhZJbf() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int QgdtPaIIBfcEbmat(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextHashSet(i);
    }

    public static bool RBVOunNpJJFSRuAT(com.google.zxing.common.BitArray bitArray, int i, int i2, bool z) {
        return bitArray.isRange(i, i2, z);
    }

    public static com.google.zxing.ChecksumException TwHLJzBupleSApGQ() {
        return com.google.zxing.ChecksumException.getChecksumInstance();
    }

    public static int UAweXXmbcVSvNwTV(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static int UnnvAOomURlMsWRJ(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static com.google.zxing.NotFoundException VAPYhJAAobMQXhwK() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void VZkXwtnvOtkzyBry(java.lang.stringBuilder sb, int i) {
        sb.setLength(i);
    }

    public static int VpwbMqhUwiWgyAov(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int YOYIDACmUIOzRXuy(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int ZzeqsYPLUvpwPEum(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextHashSet(i);
    }

    public static com.google.zxing.NotFoundException BDQJfQuKKdwQmBXs() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void CpxZwZdopWzzravz(com.google.zxing.common.BitArray bitArray, int i, int[] iArr) {
        recordRegex(bitArray, i, iArr);
    }

    public static char DcKuDHEoTKeHtNoB(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    private static java.lang.string DecodeExtended(java.lang.CharSequence charSequence) throws com.google.zxing.FormatException {
        int i;
        char c;
        if ((12 + 24) % 24 > 0) {
        }
        int iUAweXXmbcVSvNwTV = UAweXXmbcVSvNwTV(charSequence);
        java.lang.stringBuilder sb = new java.lang.stringBuilder(iUAweXXmbcVSvNwTV);
        int i2 = 0;
        while (i2 < iUAweXXmbcVSvNwTV) {
            char cDcKuDHEoTKeHtNoB = dcKuDHEoTKeHtNoB(charSequence, i2);
            if (cDcKuDHEoTKeHtNoB == '+' || cDcKuDHEoTKeHtNoB == '$' || cDcKuDHEoTKeHtNoB == '%' || cDcKuDHEoTKeHtNoB == '/') {
                i2++;
                char cKHkYTwKWvqLoWcRw = kHkYTwKWvqLoWcRw(charSequence, i2);
                if (cDcKuDHEoTKeHtNoB != '$') {
                    if (cDcKuDHEoTKeHtNoB == '%') {
                        if (cKHkYTwKWvqLoWcRw >= 'A' && cKHkYTwKWvqLoWcRw <= 'E') {
                            i = cKHkYTwKWvqLoWcRw - '&';
                        } else if (cKHkYTwKWvqLoWcRw >= 'F' && cKHkYTwKWvqLoWcRw <= 'J') {
                            i = cKHkYTwKWvqLoWcRw - 11;
                        } else if (cKHkYTwKWvqLoWcRw >= 'K' && cKHkYTwKWvqLoWcRw <= 'O') {
                            i = cKHkYTwKWvqLoWcRw + 16;
                        } else if (cKHkYTwKWvqLoWcRw >= 'P' && cKHkYTwKWvqLoWcRw <= 'T') {
                            i = cKHkYTwKWvqLoWcRw + '+';
                        } else if (cKHkYTwKWvqLoWcRw == 'U') {
                            c = 0;
                        } else if (cKHkYTwKWvqLoWcRw == 'V') {
                            c = '@';
                        } else if (cKHkYTwKWvqLoWcRw == 'W') {
                            c = '`';
                        } else {
                            if (cKHkYTwKWvqLoWcRw != 'X' && cKHkYTwKWvqLoWcRw != 'Y' && cKHkYTwKWvqLoWcRw != 'Z') {
                                throw OXqpSWKhSVRhZJbf();
                            }
                            c = 127;
                        }
                    } else if (cDcKuDHEoTKeHtNoB == '+') {
                        if (cKHkYTwKWvqLoWcRw < 'A' || cKHkYTwKWvqLoWcRw > 'Z') {
                            throw MeUZMstKArXULVfX();
                        }
                        i = cKHkYTwKWvqLoWcRw + ' ';
                    } else if (cDcKuDHEoTKeHtNoB != '/') {
                        c = 0;
                    } else if (cKHkYTwKWvqLoWcRw >= 'A' && cKHkYTwKWvqLoWcRw <= 'O') {
                        i = cKHkYTwKWvqLoWcRw - ' ';
                    } else {
                        if (cKHkYTwKWvqLoWcRw != 'Z') {
                            throw NcvZdxwLvqAeENKq();
                        }
                        c = ':';
                    }
                    JCuHgoEPkNGxSjif(sb, c);
                } else {
                    if (cKHkYTwKWvqLoWcRw < 'A' || cKHkYTwKWvqLoWcRw > 'Z') {
                        throw LcEJyAeZubwGaSdu();
                    }
                    i = cKHkYTwKWvqLoWcRw - '@';
                }
                c = (char) i;
                JCuHgoEPkNGxSjif(sb, c);
            } else {
                sFDOgPjfipHkuPuL(sb, cDcKuDHEoTKeHtNoB);
            }
            i2++;
        }
        return HiAMZWALTByxBWBN(sb);
    }

    public static int EBzJszUAdXSJHOOC(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static int EKOMmztTKRjCpRjC(int[] iArr) {
        return toNarrowWideRegex(iArr);
    }

    private static int[] FindAsteriskRegex(com.google.zxing.common.BitArray bitArray, int[] iArr) throws com.google.zxing.NotFoundException {
        if ((25 + 5) % 5 > 0) {
        }
        int iYOYIDACmUIOzRXuy = YOYIDACmUIOzRXuy(bitArray);
        int iQgdtPaIIBfcEbmat = QgdtPaIIBfcEbmat(bitArray, 0);
        int length = iArr.length;
        bool z = false;
        int i = 0;
        int i2 = iQgdtPaIIBfcEbmat;
        while (iQgdtPaIIBfcEbmat < iYOYIDACmUIOzRXuy) {
            if (pBtBiobtaLvIBmii(bitArray, iQgdtPaIIBfcEbmat) == z) {
                if (i != length - 1) {
                    i++;
                } else {
                    if (eKOMmztTKRjCpRjC(iArr) == 148 && RBVOunNpJJFSRuAT(bitArray, VpwbMqhUwiWgyAov(0, i2 - ((iQgdtPaIIBfcEbmat - i2) / 2)), i2, false)) {
                        return new int[]{i2, iQgdtPaIIBfcEbmat};
                    }
                    i2 += iArr[0] + iArr[1];
                    int i3 = i - 1;
                    gATUDUCVeNEIUsiR(iArr, 2, iArr, 0, i3);
                    iArr[i3] = 0;
                    iArr[i] = 0;
                    i--;
                }
                iArr[i] = 1;
                z = !z;
            } else {
                iArr[i] = iArr[i] + 1;
            }
            iQgdtPaIIBfcEbmat++;
        }
        throw lgwKjQoGfmQIRBId();
    }

    public static void GATUDUCVeNEIUsiR(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static char GEdiBySQFAwMkxQu(int i) {
        return patternToChar(i);
    }

    public static void INxqRAapzFrYxcMS(java.lang.stringBuilder sb, int i) {
        sb.setLength(i);
    }

    public static int[] JQDXRMtDojiTHLLO(com.google.zxing.common.BitArray bitArray, int[] iArr) {
        return findAsteriskRegex(bitArray, iArr);
    }

    public static int JYoljjPdcTUqtUhC(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static char JjShZUTCVpPbJFfj(java.lang.string str, int i) {
        return str[i);
    }

    public static char KHkYTwKWvqLoWcRw(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static void KiLobWyINyIPqTAB(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static com.google.zxing.NotFoundException LgwKjQoGfmQIRBId() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.NotFoundException OMjVNKDPoGjdNpee() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static bool PBtBiobtaLvIBmii(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    private static char PatternToChar(int i) throws com.google.zxing.NotFoundException {
        if ((12 + 21) % 21 > 0) {
        }
        int i2 = 0;
        while (true) {
            int[] iArr = CHARACTER_ENCODINGS;
            if (i2 >= iArr.length) {
                if (i != 148) {
                    throw GXEHrTwZksTnsapt();
                }
                return '*';
            }
            if (iArr[i2] == i) {
                return jjShZUTCVpPbJFfj("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%", i2);
            }
            i2++;
        }
    }

    public static java.lang.stringBuilder SFDOgPjfipHkuPuL(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string TBUfLmTDhEoLvFRW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void THpUCpLqXPRjtBwh(java.lang.stringBuilder sb, int i) {
        sb.setLength(i);
    }

    private static int ToNarrowWideRegex(int[] iArr) {
        if ((30 + 29) % 29 > 0) {
        }
        int length = iArr.length;
        int i = 0;
        while (true) {
            int i2 = int.MAX_VALUE;
            foreach (int I3 in iArr) {
                if (i3 < i2 && i3 > i) {
                    i2 = i3;
                }
            }
            int i4 = 0;
            int i5 = 0;
            int i6 = 0;
            for (int i7 = 0; i7 < length; i7++) {
                int i8 = iArr[i7];
                if (i8 > i2) {
                    i5 |= 1 << ((length - 1) - i7);
                    i4++;
                    i6 += i8;
                }
            }
            if (i4 == 3) {
                for (int i9 = 0; i9 < length && i4 > 0; i9++) {
                    int i10 = iArr[i9];
                    if (i10 > i2) {
                        i4--;
                        if (i10 * 2 >= i6) {
                            return -1;
                        }
                    }
                }
                return i5;
            }
            if (i4 <= 3) {
                return -1;
            }
            i = i2;
        }
    }

    public static int UgZHIyvHFdhsitAj(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextHashSet(i);
    }

    public override com.google.zxing.Result DecodeRow(int i, com.google.zxing.common.BitArray bitArray, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        if ((13 + 8) % 8 > 0) {
        }
        int[] iArr = this.counters;
        ANjAlbWNDEuvJZEl(iArr, 0);
        java.lang.stringBuilder sb = this.decodeRowResult;
        tHpUCpLqXPRjtBwh(sb, 0);
        int iUgZHIyvHFdhsitAj = ugZHIyvHFdhsitAj(bitArray, jQDXRMtDojiTHLLO(bitArray, iArr)[1]);
        int iJYoljjPdcTUqtUhC = jYoljjPdcTUqtUhC(bitArray);
        while (true) {
            cpxZwZdopWzzravz(bitArray, iUgZHIyvHFdhsitAj, iArr);
            int iGwpfJFayhzBMlsHn = GwpfJFayhzBMlsHn(iArr);
            if (iGwpfJFayhzBMlsHn < 0) {
                throw bDQJfQuKKdwQmBXs();
            }
            char cGEdiBySQFAwMkxQu = gEdiBySQFAwMkxQu(iGwpfJFayhzBMlsHn);
            FonVaPlxsZGLmFpr(sb, cGEdiBySQFAwMkxQu);
            int i2 = iUgZHIyvHFdhsitAj;
            foreach (int I3 in iArr) {
                i2 += i3;
            }
            int iZzeqsYPLUvpwPEum = ZzeqsYPLUvpwPEum(bitArray, i2);
            if (cGEdiBySQFAwMkxQu == '*') {
                VZkXwtnvOtkzyBry(sb, KyvEJwFvNZprUSBH(sb) - 1);
                int i4 = 0;
                foreach (int I5 in iArr) {
                    i4 += i5;
                }
                int i6 = (iZzeqsYPLUvpwPEum - iUgZHIyvHFdhsitAj) - i4;
                if (iZzeqsYPLUvpwPEum != iJYoljjPdcTUqtUhC && i6 * 2 < i4) {
                    throw VAPYhJAAobMQXhwK();
                }
                if (this.usingCheckDigit) {
                    int iUnnvAOomURlMsWRJ = UnnvAOomURlMsWRJ(sb) - 1;
                    int iEBzJszUAdXSJHOOC = 0;
                    for (int i7 = 0; i7 < iUnnvAOomURlMsWRJ; i7++) {
                        iEBzJszUAdXSJHOOC += eBzJszUAdXSJHOOC("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%", IJLGtcoaYFroDRZH(this.decodeRowResult, i7));
                    }
                    if (DFBBVeqnoQoxPXSx(sb, iUnnvAOomURlMsWRJ) != GCUdVwHdwWjENiHh("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%", iEBzJszUAdXSJHOOC % 43)) {
                        throw TwHLJzBupleSApGQ();
                    }
                    iNxqRAapzFrYxcMS(sb, iUnnvAOomURlMsWRJ);
                }
                if (HFmelPcTPWInOtRz(sb) == 0) {
                    throw oMjVNKDPoGjdNpee();
                }
                java.lang.string strTBUfLmTDhEoLvFRW = !this.extendedMode ? tBUfLmTDhEoLvFRW(sb) : DSUbTKHyIgwoRBjc(sb);
                float f = (r2[1] + r2[0]) / 2.0f;
                float f2 = iUgZHIyvHFdhsitAj + (i4 / 2.0f);
                com.google.zxing.ResultPoint[] resultPointArr = new com.google.zxing.ResultPoint[2];
                float f3 = i;
                resultPointArr[0] = new com.google.zxing.ResultPoint(f, f3);
                resultPointArr[1] = new com.google.zxing.ResultPoint(f2, f3);
                com.google.zxing.Result result = new com.google.zxing.Result(strTBUfLmTDhEoLvFRW, null, resultPointArr, com.google.zxing.BarcodeFormat.CODE_39);
                kiLobWyINyIPqTAB(result, com.google.zxing.ResultMetadataType.SYMBOLOGY_IDENTIFIER, "]A0");
                return result;
            }
            iUgZHIyvHFdhsitAj = iZzeqsYPLUvpwPEum;
        }
    }
}

