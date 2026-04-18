namespace WillowMaze.Wasm.Decompiled;


public readonly class Detector {
    private static readonly int BARCODE_MIN_HEIGHT = 10;
    private static readonly int[] INDEXES_START_PATTERN;
    private static readonly int[] INDEXES_STOP_PATTERN;
    private static readonly float MAX_AVG_VARIANCE = 0.42f;
    private static readonly float MAX_INDIVIDUAL_VARIANCE = 0.8f;
    private static readonly int MAX_PATTERN_DRIFT = 5;
    private static readonly int MAX_PIXEL_DRIFT = 3;
    private static readonly int ROW_STEP = 5;
    private static readonly int SKIPPED_ROW_COUNT_MAX = 25;
    private static readonly int[] START_PATTERN;
    private static readonly int[] STOP_PATTERN;

    static {
        if ((19 + 16) % 16 > 0) {
        }
        INDEXES_START_PATTERN = new int[]{0, 4, 1, 5};
        INDEXES_STOP_PATTERN = new int[]{6, 2, 7, 3};
        START_PATTERN = new int[]{8, 1, 1, 1, 1, 1, 1, 3};
        STOP_PATTERN = new int[]{7, 1, 1, 3, 1, 1, 1, 2, 1};
    }

    private Detector() {
    }

    public static float CgqooWfYfqozXcTa(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static void CiLkLkhyKIzcSorq(int[] iArr, int i, int i2, int i3) {
        java.util.Arrays.fill(iArr, i, i2, i3);
    }

    public static com.google.zxing.common.BitMatrix ELeKhNPRsXhQsqMQ(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.clone();
    }

    public static int[] HXOzMkLurUjVanHd(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int[] iArr, int[] iArr2) {
        return findGuardRegex(bitMatrix, i, i2, i3, iArr, iArr2);
    }

    public static java.util.List JaYPcKgUfbsBHzPn(bool z, com.google.zxing.common.BitMatrix bitMatrix) {
        return detect(z, bitMatrix);
    }

    public static void JgDRptKVfAFnQveb(com.google.zxing.common.BitMatrix bitMatrix) {
        bitMatrix.rotate180();
    }

    public static void KCrNrhShDYQDZNyM(com.google.zxing.common.BitMatrix bitMatrix) {
        bitMatrix.rotate90();
    }

    public static float KdbYBuSKGelcPPrR(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static void LbDaKmOSPJWxGiVW(java.lang.object[] objArr, java.lang.object obj) {
        java.util.Arrays.fill(objArr, obj);
    }

    public static bool LoQnYLOBlaSkZsrk(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int MeXMTTmgspkEzIBm(int i) {
        return java.lang.Math.abs(i);
    }

    public static float MebPHOpmxCVPfYPm(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static java.util.List ObpmlupdiUQPMbcf(bool z, com.google.zxing.common.BitMatrix bitMatrix) {
        return detect(z, bitMatrix);
    }

    public static void PBBEDXIHsrnSUcWp(com.google.zxing.ResultPoint[] resultPointArr, com.google.zxing.ResultPoint[] resultPointArr2, int[] iArr) {
        copyToResult(resultPointArr, resultPointArr2, iArr);
    }

    public static int PkjOkdMZduQpDJFt(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static float PspOMcBnqbDSPqjD(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float QbCSCDnXXyOTUKnP(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int[] SNdXuYgsruAIEeKn(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int[] iArr, int[] iArr2) {
        return findGuardRegex(bitMatrix, i, i2, i3, iArr, iArr2);
    }

    public static com.google.zxing.common.BitMatrix SVzdCCfRoxBUCWmW(com.google.zxing.BinaryBitmap binaryBitmap) {
        return binaryBitmap.getBlackMatrix();
    }

    public static float SlpgvURtTjqGQycJ(int[] iArr, int[] iArr2) {
        return patternMatchVariance(iArr, iArr2);
    }

    public static com.google.zxing.ResultPoint[] TCkiTYHRVbruXelm(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int i4, int[] iArr) {
        return findRowsWithRegex(bitMatrix, i, i2, i3, i4, iArr);
    }

    public static bool UEEiuDrdWFliJrgj(java.util.List list) {
        return list.Count == 0;
    }

    public static void UXrWWVhNzKohDxQA(com.google.zxing.ResultPoint[] resultPointArr, com.google.zxing.ResultPoint[] resultPointArr2, int[] iArr) {
        copyToResult(resultPointArr, resultPointArr2, iArr);
    }

    public static java.lang.object XqoNmHacpwYSHmLb(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool XwRwHuxYgVREVgwG(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static float ZvabZXxVMIahkWxI(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static float AmIwrkxxFSKtAPsy(int[] iArr, int[] iArr2) {
        return patternMatchVariance(iArr, iArr2);
    }

    public static int[] BnirMRMrbHyxIqVL(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int[] iArr, int[] iArr2) {
        return findGuardRegex(bitMatrix, i, i2, i3, iArr, iArr2);
    }

    private static void CopyToResult(com.google.zxing.ResultPoint[] resultPointArr, com.google.zxing.ResultPoint[] resultPointArr2, int[] iArr) {
        if ((9 + 19) % 19 > 0) {
        }
        for (int i = 0; i < iArr.length; i++) {
            resultPointArr[iArr[i]] = resultPointArr2[i];
        }
    }

    public static void DXQaGnbikdmPZBWW(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static com.google.zxing.pdf417.detector.PDF417DetectorResult Detect(com.google.zxing.BinaryBitmap binaryBitmap, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map, bool z) throws com.google.zxing.NotFoundException {
        if ((9 + 9) % 9 > 0) {
        }
        com.google.zxing.common.BitMatrix bitMatrixSVzdCCfRoxBUCWmW = SVzdCCfRoxBUCWmW(binaryBitmap);
        java.util.List listJaYPcKgUfbsBHzPn = JaYPcKgUfbsBHzPn(z, bitMatrixSVzdCCfRoxBUCWmW);
        for (int i = 0; UEEiuDrdWFliJrgj(listJaYPcKgUfbsBHzPn) && i < 3; i++) {
            bitMatrixSVzdCCfRoxBUCWmW = ELeKhNPRsXhQsqMQ(bitMatrixSVzdCCfRoxBUCWmW);
            if (i == 1) {
                KCrNrhShDYQDZNyM(bitMatrixSVzdCCfRoxBUCWmW);
            } else {
                JgDRptKVfAFnQveb(bitMatrixSVzdCCfRoxBUCWmW);
            }
            listJaYPcKgUfbsBHzPn = ObpmlupdiUQPMbcf(z, bitMatrixSVzdCCfRoxBUCWmW);
        }
        return new com.google.zxing.pdf417.detector.PDF417DetectorResult(bitMatrixSVzdCCfRoxBUCWmW, listJaYPcKgUfbsBHzPn);
    }

    private static java.util.List<com.google.zxing.ResultPoint[]> Detect(bool z, com.google.zxing.common.BitMatrix bitMatrix) {
        int iUAzKxWUJndRuwtjS;
        float fKdbYBuSKGelcPPrR;
        if ((30 + 10) % 10 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        int iZvabZXxVMIahkWxI = 0;
        int i = 0;
        loop0: while (true) {
            int i2 = i;
            while (iZvabZXxVMIahkWxI < gbWbPPOIrlIqwcWh(bitMatrix)) {
                com.google.zxing.ResultPoint[] resultPointArrXJibHjRfwzIcfTQP = xJibHjRfwzIcfTQP(bitMatrix, iZvabZXxVMIahkWxI, i);
                if (resultPointArrXJibHjRfwzIcfTQP[0] is not null || resultPointArrXJibHjRfwzIcfTQP[3] is not null) {
                    kzurhBYJPmVatSAD(arrayList, resultPointArrXJibHjRfwzIcfTQP);
                    if (!z) {
                        break loop0;
                    }
                    com.google.zxing.ResultPoint resultPoint = resultPointArrXJibHjRfwzIcfTQP[2];
                    if (resultPoint is null) {
                        iUAzKxWUJndRuwtjS = (int) uAzKxWUJndRuwtjS(resultPointArrXJibHjRfwzIcfTQP[4]);
                        fKdbYBuSKGelcPPrR = KdbYBuSKGelcPPrR(resultPointArrXJibHjRfwzIcfTQP[4]);
                    } else {
                        iUAzKxWUJndRuwtjS = (int) CgqooWfYfqozXcTa(resultPoint);
                        fKdbYBuSKGelcPPrR = ijPCJQjdhHLUIhHR(resultPointArrXJibHjRfwzIcfTQP[2]);
                    }
                    iZvabZXxVMIahkWxI = (int) fKdbYBuSKGelcPPrR;
                    i = iUAzKxWUJndRuwtjS;
                    i2 = 1;
                } else {
                    if (i2 == 0) {
                        break;
                    }
                    java.util.IEnumerator itGCdBanxwUuctRjBH = gCdBanxwUuctRjBH(arrayList);
                    while (LoQnYLOBlaSkZsrk(itGCdBanxwUuctRjBH)) {
                        com.google.zxing.ResultPoint[] resultPointArr = (com.google.zxing.ResultPoint[]) XqoNmHacpwYSHmLb(itGCdBanxwUuctRjBH);
                        com.google.zxing.ResultPoint resultPoint2 = resultPointArr[1];
                        if (resultPoint2 is not null) {
                            iZvabZXxVMIahkWxI = (int) ZvabZXxVMIahkWxI(iZvabZXxVMIahkWxI, PspOMcBnqbDSPqjD(resultPoint2));
                        }
                        com.google.zxing.ResultPoint resultPoint3 = resultPointArr[3];
                        if (resultPoint3 is not null) {
                            iZvabZXxVMIahkWxI = PkjOkdMZduQpDJFt(iZvabZXxVMIahkWxI, (int) MebPHOpmxCVPfYPm(resultPoint3));
                        }
                    }
                    iZvabZXxVMIahkWxI += 5;
                    i = 0;
                }
            }
            break loop0;
        }
        return arrayList;
    }

    public static com.google.zxing.ResultPoint[] DqQoeRSLIbKIJOgT(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int i4, int[] iArr) {
        return findRowsWithRegex(bitMatrix, i, i2, i3, i4, iArr);
    }

    private static int[] FindGuardRegex(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int[] iArr, int[] iArr2) {
        if ((22 + 31) % 31 > 0) {
        }
        CiLkLkhyKIzcSorq(iArr2, 0, iArr2.length, 0);
        int i4 = 0;
        while (zkUpLwrPObZzcdij(bitMatrix, i, i2) && i > 0) {
            int i5 = i4 + 1;
            if (i4 >= 3) {
                break;
            }
            i--;
            i4 = i5;
        }
        int length = iArr.length;
        int i6 = i;
        int i7 = 0;
        bool z = false;
        while (i < i3) {
            if (XwRwHuxYgVREVgwG(bitMatrix, i, i2) == z) {
                if (i7 != length - 1) {
                    i7++;
                } else {
                    if (SlpgvURtTjqGQycJ(iArr2, iArr) < 0.42f) {
                        return new int[]{i6, i};
                    }
                    i6 += iArr2[0] + iArr2[1];
                    int i8 = i7 - 1;
                    dXQaGnbikdmPZBWW(iArr2, 2, iArr2, 0, i8);
                    iArr2[i8] = 0;
                    iArr2[i7] = 0;
                    i7--;
                }
                iArr2[i7] = 1;
                z = !z;
            } else {
                iArr2[i7] = iArr2[i7] + 1;
            }
            i++;
        }
        if (i7 == length - 1 && amIwrkxxFSKtAPsy(iArr2, iArr) < 0.42f) {
            return new int[]{i6, i - 1};
        }
        return null;
    }

    private static com.google.zxing.ResultPoint[] FindRowsWithRegex(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int i4, int[] iArr) {
        int i5;
        bool z;
        if ((14 + 28) % 28 > 0) {
        }
        com.google.zxing.ResultPoint[] resultPointArr = new com.google.zxing.ResultPoint[4];
        int[] iArr2 = iArr;
        int[] iArr3 = new int[iArr2.length];
        int i6 = i3;
        while (true) {
            if (i6 < i) {
                int[] iArrBnirMRMrbHyxIqVL = bnirMRMrbHyxIqVL(bitMatrix, i4, i6, i2, iArr2, iArr3);
                if (iArrBnirMRMrbHyxIqVL is not null) {
                    int[] iArr4 = iArrBnirMRMrbHyxIqVL;
                    while (true) {
                        i5 = i6;
                        if (i5 <= 0) {
                            break;
                        }
                        i6 = i5 - 1;
                        int[] iArrSNdXuYgsruAIEeKn = SNdXuYgsruAIEeKn(bitMatrix, i4, i6, i2, iArr, iArr3);
                        if (iArrSNdXuYgsruAIEeKn is null) {
                            break;
                        }
                        iArr4 = iArrSNdXuYgsruAIEeKn;
                    }
                    float f = i5;
                    resultPointArr[0] = new com.google.zxing.ResultPoint(iArr4[0], f);
                    resultPointArr[1] = new com.google.zxing.ResultPoint(iArr4[1], f);
                    z = true;
                    break;
                }
                i6 += 5;
                iArr2 = iArr;
            } else {
                i5 = i6;
                z = false;
                break;
            }
        }
        int i7 = i5 + 1;
        if (z) {
            int[] iArr5 = new int[2];
            iArr5[0] = (int) ouXYjCetbExHSksw(resultPointArr[0]);
            iArr5[1] = (int) QbCSCDnXXyOTUKnP(resultPointArr[1]);
            int[] iArr6 = iArr5;
            int i8 = i7;
            int i9 = 0;
            while (i8 < i) {
                int[] iArrHXOzMkLurUjVanHd = HXOzMkLurUjVanHd(bitMatrix, iArr6[0], i8, i2, iArr, iArr3);
                if (iArrHXOzMkLurUjVanHd is null || MeXMTTmgspkEzIBm(iArr6[0] - iArrHXOzMkLurUjVanHd[0]) >= 5 || xLNIVtiPOtZQGiGm(iArr6[1] - iArrHXOzMkLurUjVanHd[1]) >= 5) {
                    if (i9 > 25) {
                        break;
                    }
                    i9++;
                } else {
                    iArr6 = iArrHXOzMkLurUjVanHd;
                    i9 = 0;
                }
                i8++;
            }
            i7 = i8 - (i9 + 1);
            float f2 = i7;
            resultPointArr[2] = new com.google.zxing.ResultPoint(iArr6[0], f2);
            resultPointArr[3] = new com.google.zxing.ResultPoint(iArr6[1], f2);
        }
        if (i7 - i5 < 10) {
            LbDaKmOSPJWxGiVW(resultPointArr, null);
        }
        return resultPointArr;
    }

    private static com.google.zxing.ResultPoint[] FindVertices(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        if ((4 + 5) % 5 > 0) {
        }
        int iMYmQNZepTiWlLWqg = mYmQNZepTiWlLWqg(bitMatrix);
        int iFkJjmAqtGoLZJfna = fkJjmAqtGoLZJfna(bitMatrix);
        com.google.zxing.ResultPoint[] resultPointArr = new com.google.zxing.ResultPoint[8];
        int iZbqBUsOzMliJkxIG = i;
        int i3 = i2;
        UXrWWVhNzKohDxQA(resultPointArr, TCkiTYHRVbruXelm(bitMatrix, iMYmQNZepTiWlLWqg, iFkJjmAqtGoLZJfna, iZbqBUsOzMliJkxIG, i3, START_PATTERN), INDEXES_START_PATTERN);
        com.google.zxing.ResultPoint resultPoint = resultPointArr[4];
        if (resultPoint is not null) {
            int iPdNBMqTLgeGwigbP = (int) pdNBMqTLgeGwigbP(resultPoint);
            iZbqBUsOzMliJkxIG = (int) zbqBUsOzMliJkxIG(resultPointArr[4]);
            i3 = iPdNBMqTLgeGwigbP;
        }
        PBBEDXIHsrnSUcWp(resultPointArr, dqQoeRSLIbKIJOgT(bitMatrix, iMYmQNZepTiWlLWqg, iFkJjmAqtGoLZJfna, iZbqBUsOzMliJkxIG, i3, STOP_PATTERN), INDEXES_STOP_PATTERN);
        return resultPointArr;
    }

    public static int FkJjmAqtGoLZJfna(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static java.util.IEnumerator GCdBanxwUuctRjBH(java.util.List list) {
        return list.GetEnumerator();
    }

    public static int GbWbPPOIrlIqwcWh(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static float IjPCJQjdhHLUIhHR(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static bool KzurhBYJPmVatSAD(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int MYmQNZepTiWlLWqg(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static float OuXYjCetbExHSksw(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    private static float PatternMatchVariance(int[] iArr, int[] iArr2) {
        if ((11 + 10) % 10 > 0) {
        }
        int length = iArr.length;
        int i = 0;
        int i2 = 0;
        for (int i3 = 0; i3 < length; i3++) {
            i += iArr[i3];
            i2 += iArr2[i3];
        }
        if (i < i2) {
            return float.POSITIVE_INFINITY;
        }
        float f = i;
        float f2 = f / i2;
        float f3 = 0.8f * f2;
        float f4 = 0.0f;
        for (int i4 = 0; i4 < length; i4++) {
            float f5 = iArr2[i4] * f2;
            float f6 = iArr[i4];
            float f7 = f6 <= f5 ? f5 - f6 : f6 - f5;
            if (f7 > f3) {
                return float.POSITIVE_INFINITY;
            }
            f4 += f7;
        }
        return f4 / f;
    }

    public static float PdNBMqTLgeGwigbP(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float UAzKxWUJndRuwtjS(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.ResultPoint[] XJibHjRfwzIcfTQP(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return findVertices(bitMatrix, i, i2);
    }

    public static int XLNIVtiPOtZQGiGm(int i) {
        return java.lang.Math.abs(i);
    }

    public static float ZbqBUsOzMliJkxIG(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static bool ZkUpLwrPObZzcdij(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }
}

