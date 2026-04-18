namespace WillowMaze.Wasm.Decompiled;


public readonly class PDF417ScanningDecoder {
    private static readonly int CODEWORD_SKEW_SIZE = 2;
    private static readonly int MAX_EC_CODEWORDS = 512;
    private static readonly int MAX_ERRORS = 3;
    private static readonly com.google.zxing.pdf417.decoder.ec.ErrorCorrection errorCorrection = new com.google.zxing.pdf417.decoder.ec.ErrorCorrection();

    private PDF417ScanningDecoder() {
    }

    public static int ATXsEzHWBrQumTxd(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getErrorCorrectionLevel();
    }

    public static com.google.zxing.common.DecoderResult AlQmBgmmoFQyIteh(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return createDecoderResult(detectionResult);
    }

    public static bool AmfiqqPXgpkvOzXy(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.string BKEKwrxudLyirssy(int i) {
        return java.lang.string.valueOf(i);
    }

    public static int[] BLkXuqIbKETDXsrI(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static bool BhPUBOlxwBCHTSMu(int i, int i2, int i3) {
        return checkCodewordSkew(i, i2, i3);
    }

    public static com.google.zxing.FormatException ByXUFlcHyMRnLVTH() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static void BzcEtoKAADjxZvxO(int[] iArr, int i) throws com.google.zxing.FormatException {
        verifyCodewordCount(iArr, i);
    }

    public static int DBygwMTNjXokVnIj(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getMinY();
    }

    public static int[] DJxrbVKsHXewDZCx(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static int DismYMfgOuCgJdqF(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.getBarcodeColumnCount();
    }

    public static int DooPSqGcRkcizDnm(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.getBarcodeColumnCount();
    }

    public static com.google.zxing.pdf417.decoder.Codeword EARzjWXhvUpykjWT(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn, int i) {
        return detectionResultColumn.getCodewordNearby(i);
    }

    public static com.google.zxing.NotFoundException EDKzizCtkiGtsHso() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int ETcKBFsIFSFyxRTz(int[] iArr) {
        return com.google.zxing.pdf417.decoder.PDF417CodewordDecoder.getDecodedValue(iArr);
    }

    public static int EnQKycsPrnfLcQBI(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getStartX();
    }

    public static void ErCKhlznrbvgfCaa(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, int i, com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        detectionResult.setDetectionResultColumn(i, detectionResultColumn);
    }

    public static void FFWGDKSxEuvlkIqB(com.google.zxing.common.DecoderResult decoderResult, java.lang.int num) {
        decoderResult.setErasures(num);
    }

    public static com.google.zxing.pdf417.decoder.BoundingBox FRKNkMQLOgeTFuzg(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return adjustBoundingBox(detectionResultRowIndicatorColumn);
    }

    public static com.google.zxing.pdf417.decoder.Codeword FeVOKIFEWbrteWYw(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, bool z, int i3, int i4, int i5, int i6) {
        return detectCodeword(bitMatrix, i, i2, z, i3, i4, i5, i6);
    }

    public static bool FiBCPIqRpvlRXKXW(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, int i) {
        return isValidBarcodeColumn(detectionResult, i);
    }

    public static com.google.zxing.pdf417.decoder.BoundingBox FnyIFsvpkxYJwCpG(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.getBoundingBox();
    }

    public static java.util.Formatter HJwCRqJgDeWUUFlE(java.util.Formatter formatter, java.lang.string str, java.lang.object[] objArr) {
        return formatter.format(str, objArr);
    }

    public static com.google.zxing.pdf417.decoder.BoundingBox HXLyaJKhqtiFWyYv(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return detectionResultRowIndicatorColumn.getBoundingBox();
    }

    public static int HaAzzSHBeNSEoYmS(int[] iArr, int[] iArr2, int i) {
        return correctErrors(iArr, iArr2, i);
    }

    public static int[] IhiHnFzgLqxflZUS(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static int IqiUbyrXXJhsBJKX(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getMinX();
    }

    public static int[] JFiTOHpaRvKCrvdg(java.util.ICollection collection) {
        return com.google.zxing.pdf417.PDF417Common.toIntArray(collection);
    }

    public static bool JJhzjxnCZIlZDwTy(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static int JfqgrXTAsKCNBQJU(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.getBarcodeColumnCount();
    }

    public static int JniAZTfvzaKKujbs(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getMaxY();
    }

    public static int JuOStsTBIOVeGfDU(int i) {
        return getNumberOfECCodeWords(i);
    }

    public static int JzfUwbkeTYKdzdaa(java.util.List list) {
        return list.Count;
    }

    public static com.google.zxing.pdf417.decoder.Codeword KJtqFmnwDuqlWdQw(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn, int i) {
        return detectionResultColumn.getCodewordNearby(i);
    }

    public static int KTFFFNpTBVUticlI(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static com.google.zxing.pdf417.decoder.DetectionResultColumn KvKdgyInckmsEHLq(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, int i) {
        return detectionResult.getDetectionResultColumn(i);
    }

    public static java.lang.object LETxkPcwfmpzPsjp(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static com.google.zxing.pdf417.decoder.Codeword LgYjPVaFVkxlnBLM(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, bool z, int i3, int i4, int i5, int i6) {
        return detectCodeword(bitMatrix, i, i2, z, i3, i4, i5, i6);
    }

    public static java.lang.int LlJgYYjrloRSqEeA(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue, int i) {
        return barcodeValue.getConfidence(i);
    }

    public static com.google.zxing.ChecksumException MeZClodlCLgFyBeE() {
        return com.google.zxing.ChecksumException.getChecksumInstance();
    }

    public static void NGEJNNPHKmWzoBkV(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn, int i, com.google.zxing.pdf417.decoder.Codeword codeword) {
        detectionResultRowIndicatorColumn.setCodeword(i, codeword);
    }

    public static int NcYPSRjPCPcAEVNj(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getMaxY();
    }

    public static com.google.zxing.common.DecoderResult OEMpOdzLooqVFIje(int[] iArr, int i, int[] iArr2) {
        return decodeCodewords(iArr, i, iArr2);
    }

    public static int OJHPiiAKOIfjnZwi(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getStartX();
    }

    public static int OSzIHuExpRrKNaxA(int i) {
        return java.lang.Math.abs(i);
    }

    public static int OZnngizhOuQUzhRQ(int[] iArr) {
        return com.google.zxing.common.detector.MathUtils.sum(iArr);
    }

    public static java.lang.int OtBNhTJbxPoCMRvR(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int PFfKnzeKuhPZtaCc(int[] iArr) {
        return getMax(iArr);
    }

    public static void PINlSiAjaEzOYfRK(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, com.google.zxing.pdf417.decoder.BarcodeValue[][] barcodeValueArr) throws com.google.zxing.NotFoundException {
        adjustCodewordCount(detectionResult, barcodeValueArr);
    }

    public static com.google.zxing.pdf417.decoder.DetectionResult PJZjVaFeDUSYulCZ(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn, com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn2) {
        return merge(detectionResultRowIndicatorColumn, detectionResultRowIndicatorColumn2);
    }

    public static com.google.zxing.pdf417.decoder.DetectionResultColumn PLtZKHUfZIxXobxE(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, int i) {
        return detectionResult.getDetectionResultColumn(i);
    }

    public static int[] PgSnBEZSbiUifLnG(java.util.ICollection collection) {
        return com.google.zxing.pdf417.PDF417Common.toIntArray(collection);
    }

    public static int QEwdaZwviFnpuONB(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getMaxX();
    }

    public static int RAJDFTFYlDVOpHRL(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getMinY();
    }

    public static int RYEAZFQfoEjQvswA(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getMinY();
    }

    public static bool SRKuwFsUOFYSIRBI(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, int i) {
        return isValidBarcodeColumn(detectionResult, i);
    }

    public static int SjouOQZkewxJGZCR(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, int i, int i2, bool z) {
        return getStartColumn(detectionResult, i, i2, z);
    }

    public static int[] SqHBVvvZKWkmZRNZ(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, bool z, int i3, int i4) {
        return getModuleBitCount(bitMatrix, i, i2, z, i3, i4);
    }

    public static com.google.zxing.FormatException SstWIrPZcfXefaZy() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static void SwPZFqDSerHynSLj(java.util.Formatter formatter) {
        formatter.Dispose();
    }

    public static java.lang.int TDCnWMHRlxjxWBMV(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.zxing.pdf417.decoder.BarcodeMetadata TWHvBZrbPLhlYUnR(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return detectionResultRowIndicatorColumn.getBarcodeMetadata();
    }

    public static java.lang.int TZXRhbFUxixMcHuB(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object TvfLFYBcDvpfWmaD(java.util.List list, int i) {
        return list[i);
    }

    public static int TvsyUGxIRCazkqXb(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int UGHivxhuydMrhSqL(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getStartX();
    }

    public static com.google.zxing.pdf417.decoder.DetectionResultColumn UTPNLXCDfwSVpMNf(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, int i) {
        return detectionResult.getDetectionResultColumn(i);
    }

    public static void UmHXNxQWNubhFQyO(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue, int i) {
        barcodeValue.setValue(i);
    }

    public static int UuPRukuUeshdFYYX(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.getBarcodeRowCount();
    }

    public static int VcuIHtyXEUZCxEJE(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static java.util.Formatter VlbsuOgJukknhovE(java.util.Formatter formatter, java.lang.string str, java.lang.object[] objArr) {
        return formatter.format(str, objArr);
    }

    public static java.util.Formatter XYZVUwWYiFURwIIR(java.util.Formatter formatter, java.lang.string str, java.lang.object[] objArr) {
        return formatter.format(str, objArr);
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] XcsRonWcuvcrPRce(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return detectionResultRowIndicatorColumn.getCodewords();
    }

    public static com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn ZUkJWRChexYLmokL(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.pdf417.decoder.BoundingBox boundingBox, com.google.zxing.ResultPoint resultPoint, bool z, int i, int i2) {
        return getRowIndicatorColumn(bitMatrix, boundingBox, resultPoint, z, i, i2);
    }

    public static com.google.zxing.NotFoundException ZhiogOOJjScDyMge() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.common.DecoderResult ZngyCjLCzaGTKRyy(int i, int[] iArr, int[] iArr2, int[] iArr3, int[][] iArr4) {
        return createDecoderResultFromAmbiguousValues(i, iArr, iArr2, iArr3, iArr4);
    }

    public static int AHDXkITdJqMpTfZo(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getMaxY();
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] AaKChpliZxbpLyqI(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        return detectionResultColumn.getCodewords();
    }

    public static int[] AcCkOxiPqkKxAxda(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    private static com.google.zxing.pdf417.decoder.BoundingBox AdjustBoundingBox(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) throws com.google.zxing.NotFoundException {
        int[] iArrMGIEwEnjWEZawKpv;
        if ((24 + 29) % 29 > 0) {
        }
        if (detectionResultRowIndicatorColumn is null || (iArrMGIEwEnjWEZawKpv = mGIEwEnjWEZawKpv(detectionResultRowIndicatorColumn)) is null) {
            return null;
        }
        int iPFfKnzeKuhPZtaCc = PFfKnzeKuhPZtaCc(iArrMGIEwEnjWEZawKpv);
        int i = 0;
        int i2 = 0;
        foreach (int I3 in iArrMGIEwEnjWEZawKpv) {
            i2 += iPFfKnzeKuhPZtaCc - i3;
            if (i3 > 0) {
                break;
            }
        }
        com.google.zxing.pdf417.decoder.Codeword[] codewordArrXcsRonWcuvcrPRce = XcsRonWcuvcrPRce(detectionResultRowIndicatorColumn);
        for (int i4 = 0; i2 > 0 && codewordArrXcsRonWcuvcrPRce[i4] is null; i4++) {
            i2--;
        }
        for (int length = iArrMGIEwEnjWEZawKpv.length - 1; length >= 0; length--) {
            int i5 = iArrMGIEwEnjWEZawKpv[length];
            i += iPFfKnzeKuhPZtaCc - i5;
            if (i5 > 0) {
                break;
            }
        }
        for (int length2 = codewordArrXcsRonWcuvcrPRce.length - 1; i > 0 && codewordArrXcsRonWcuvcrPRce[length2] is null; length2--) {
            i--;
        }
        return yjCOfJzYbJHzKJrV(HXLyaJKhqtiFWyYv(detectionResultRowIndicatorColumn), i2, i, oneijdfMZasmGHHF(detectionResultRowIndicatorColumn));
    }

    private static void AdjustCodewordCount(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, com.google.zxing.pdf417.decoder.BarcodeValue[][] barcodeValueArr) throws com.google.zxing.NotFoundException {
        if ((27 + 20) % 20 > 0) {
        }
        com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue = barcodeValueArr[0][1];
        int[] iArrAcCkOxiPqkKxAxda = acCkOxiPqkKxAxda(barcodeValue);
        int iFaMeVRBxFqqbjFVz = (faMeVRBxFqqbjFVz(detectionResult) * UuPRukuUeshdFYYX(detectionResult)) - JuOStsTBIOVeGfDU(fwKiBEHLutoCybCN(detectionResult));
        if (iArrAcCkOxiPqkKxAxda.length == 0) {
            if (iFaMeVRBxFqqbjFVz < 1 || iFaMeVRBxFqqbjFVz > 928) {
                throw ZhiogOOJjScDyMge();
            }
            rVroVFIlZAfMwToV(barcodeValue, iFaMeVRBxFqqbjFVz);
            return;
        }
        if (iArrAcCkOxiPqkKxAxda[0] != iFaMeVRBxFqqbjFVz && iFaMeVRBxFqqbjFVz >= 1 && iFaMeVRBxFqqbjFVz <= 928) {
            yPjArrYFsniZIXdt(barcodeValue, iFaMeVRBxFqqbjFVz);
        }
    }

    private static int AdjustCodewordStartColumn(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, bool z, int i3, int i4) {
        if ((7 + 29) % 29 > 0) {
        }
        int i5 = !z ? 1 : -1;
        int i6 = i3;
        for (int i7 = 0; i7 < 2; i7++) {
            while (true) {
                if (z) {
                    if (i6 < i) {
                        break;
                    }
                    if (z != uDvdbcOpIwJmqGNq(bitMatrix, i6, i4)) {
                        break;
                        break;
                    }
                    if (OSzIHuExpRrKNaxA(i3 - i6) <= 2) {
                        return i3;
                    }
                    i6 += i5;
                } else {
                    if (i6 >= i2) {
                        break;
                    }
                    if (z != uDvdbcOpIwJmqGNq(bitMatrix, i6, i4)) {
                        break;
                    }
                    if (OSzIHuExpRrKNaxA(i3 - i6) <= 2) {
                        return i3;
                    }
                    i6 += i5;
                }
            }
            i5 = -i5;
            z = !z;
        }
        return i6;
    }

    public static int AgBemkQtwwtsaOYQ(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getEndX();
    }

    public static int AxfWHmUsFkbeCqaw(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.getBarcodeRowCount();
    }

    public static com.google.zxing.ChecksumException BOtbrMsPvcJgtzwy() {
        return com.google.zxing.ChecksumException.getChecksumInstance();
    }

    public static int BgNmlxrOtrZTJFMl(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getEndX();
    }

    public static int BhPeAyjXzztOErVc(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getEndX();
    }

    private static bool CheckCodewordSkew(int i, int i2, int i3) {
        return i2 + (-2) <= i && i <= i3 + 2;
    }

    private static int CorrectErrors(int[] iArr, int[] iArr2, int i) throws com.google.zxing.ChecksumException {
        if ((13 + 26) % 26 > 0) {
        }
        if ((iArr2 is not null && iArr2.length > (i / 2) + 3) || i < 0 || i > 512) {
            throw feeRlTzgKvhtWRVJ();
        }
        return uQSavMrzSgdWKbrD(errorCorrection, iArr, i, iArr2);
    }

    private static com.google.zxing.pdf417.decoder.BarcodeValue[][] CreateBarcodeMatrix(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        int iEUzrHoqaSOPtdItJ;
        if ((30 + 5) % 5 > 0) {
        }
        int iKXHwtjFQCDnwGXLP = kXHwtjFQCDnwGXLP(detectionResult);
        int[] iArr = new int[2];
        iArr[1] = tcaMasOFBToOwHhO(detectionResult) + 2;
        iArr[0] = iKXHwtjFQCDnwGXLP;
        com.google.zxing.pdf417.decoder.BarcodeValue[][] barcodeValueArr = (com.google.zxing.pdf417.decoder.BarcodeValue[][]) LETxkPcwfmpzPsjp(com.google.zxing.pdf417.decoder.BarcodeValue.class, iArr);
        for (com.google.zxing.pdf417.decoder.BarcodeValue[] barcodeValueArr2 : barcodeValueArr) {
            int i = 0;
            while (true) {
                if (i >= barcodeValueArr2.length) {
                    break;
                }
                barcodeValueArr2[i] = new com.google.zxing.pdf417.decoder.BarcodeValue();
                i++;
            }
        }
        int i2 = 0;
        for (com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn : uAIuzGOprkGLHckd(detectionResult)) {
            if (detectionResultColumn is not null) {
                for (com.google.zxing.pdf417.decoder.Codeword codeword : qiKHnFLvDwaqvJHD(detectionResultColumn)) {
                    if (codeword is not null && (iEUzrHoqaSOPtdItJ = eUzrHoqaSOPtdItJ(codeword)) >= 0 && iEUzrHoqaSOPtdItJ < barcodeValueArr.length) {
                        UmHXNxQWNubhFQyO(barcodeValueArr[iEUzrHoqaSOPtdItJ][i2], iKmYxGSQNWpaAgIk(codeword));
                    }
                }
            }
            i2++;
        }
        return barcodeValueArr;
    }

    private static com.google.zxing.common.DecoderResult CreateDecoderResult(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        if ((23 + 15) % 15 > 0) {
        }
        com.google.zxing.pdf417.decoder.BarcodeValue[][] barcodeValueArrSLMDKDKpXgiAKauY = sLMDKDKpXgiAKauY(detectionResult);
        PINlSiAjaEzOYfRK(detectionResult, barcodeValueArrSLMDKDKpXgiAKauY);
        java.util.List arrayList = new java.util.List();
        int[] iArr = new int[axfWHmUsFkbeCqaw(detectionResult) * fszWFULjzxFrIEtW(detectionResult)];
        java.util.List arrayList2 = new java.util.List();
        java.util.List arrayList3 = new java.util.List();
        for (int i = 0; i < xcHxcqOFWypOIXWn(detectionResult); i++) {
            int i2 = 0;
            while (i2 < JfqgrXTAsKCNBQJU(detectionResult)) {
                int i3 = i2 + 1;
                int[] iArrBLkXuqIbKETDXsrI = BLkXuqIbKETDXsrI(barcodeValueArrSLMDKDKpXgiAKauY[i][i3]);
                int iWidUEdvuFMsPHNaJ = (widUEdvuFMsPHNaJ(detectionResult) * i) + i2;
                if (iArrBLkXuqIbKETDXsrI.length == 0) {
                    JJhzjxnCZIlZDwTy(arrayList, TDCnWMHRlxjxWBMV(iWidUEdvuFMsPHNaJ));
                } else if (iArrBLkXuqIbKETDXsrI.length != 1) {
                    AmfiqqPXgpkvOzXy(arrayList3, mcFFVZBYyLnAyfVr(iWidUEdvuFMsPHNaJ));
                    sKpzSOKSccHsRYZL(arrayList2, iArrBLkXuqIbKETDXsrI);
                } else {
                    iArr[iWidUEdvuFMsPHNaJ] = iArrBLkXuqIbKETDXsrI[0];
                }
                i2 = i3;
            }
        }
        int iJzfUwbkeTYKdzdaa = JzfUwbkeTYKdzdaa(arrayList2);
        int[][] iArr2 = new int[iJzfUwbkeTYKdzdaa][];
        for (int i4 = 0; i4 < iJzfUwbkeTYKdzdaa; i4++) {
            iArr2[i4] = (int[]) TvfLFYBcDvpfWmaD(arrayList2, i4);
        }
        return ZngyCjLCzaGTKRyy(ltHQDsoZqEYUrIDb(detectionResult), iArr, PgSnBEZSbiUifLnG(arrayList), JFiTOHpaRvKCrvdg(arrayList3), iArr2);
    }

    private static com.google.zxing.common.DecoderResult CreateDecoderResultFromAmbiguousValues(int i, int[] iArr, int[] iArr2, int[] iArr3, int[][] iArr4) throws com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        if ((4 + 1) % 1 > 0) {
        }
        int length = iArr3.length;
        int[] iArr5 = new int[length];
        int i2 = 100;
        while (true) {
            int i3 = i2 - 1;
            if (i2 <= 0) {
                throw MeZClodlCLgFyBeE();
            }
            for (int i4 = 0; i4 < length; i4++) {
                iArr[iArr3[i4]] = iArr4[i4][iArr5[i4]];
            }
            try {
                return OEMpOdzLooqVFIje(iArr, i, iArr2);
            } catch (com.google.zxing.ChecksumException unused) {
                if (length == 0) {
                    throw bOtbrMsPvcJgtzwy();
                }
                for (int i5 = 0; i5 < length; i5++) {
                    int i6 = iArr5[i5];
                    if (i6 < iArr4[i5].length - 1) {
                        iArr5[i5] = i6 + 1;
                        break;
                    }
                    iArr5[i5] = 0;
                    if (i5 == length - 1) {
                        throw mVEOZotjSlooUcLO();
                    }
                }
                i2 = i3;
            }
        }
    }

    public static int CwJMoNcOdVKWymKD(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getMinX();
    }

    public static void DIRhsiGLIWsJIEZY(java.util.Formatter formatter) {
        formatter.Dispose();
    }

    public static void DZBtSaIpfbZkrnij(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, int i, com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        detectionResult.setDetectionResultColumn(i, detectionResultColumn);
    }

    public static com.google.zxing.common.DecoderResult Decode(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3, com.google.zxing.ResultPoint resultPoint4, int i, int i2) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumnZUkJWRChexYLmokL;
        com.google.zxing.pdf417.decoder.BoundingBox boundingBox;
        com.google.zxing.pdf417.decoder.DetectionResult detectionResultPJZjVaFeDUSYulCZ;
        com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultRowIndicatorColumn;
        com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn;
        int i3;
        int i4;
        com.google.zxing.pdf417.decoder.Codeword codewordFeVOKIFEWbrteWYw;
        if ((15 + 12) % 12 > 0) {
        }
        com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn2 = null;
        bool z = true;
        com.google.zxing.pdf417.decoder.BoundingBox boundingBox2 = new com.google.zxing.pdf417.decoder.BoundingBox(bitMatrix, resultPoint, resultPoint2, resultPoint3, resultPoint4);
        com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumnYAQXLFnvBiftKlfy = null;
        bool z2 = true;
        while (true) {
            detectionResultRowIndicatorColumnZUkJWRChexYLmokL = resultPoint is null ? detectionResultRowIndicatorColumn2 : ZUkJWRChexYLmokL(bitMatrix, boundingBox2, resultPoint, true, i, i2);
            if (resultPoint3 is not null) {
                detectionResultRowIndicatorColumnYAQXLFnvBiftKlfy = yAQXLFnvBiftKlfy(bitMatrix, boundingBox2, resultPoint3, false, i, i2);
            }
            boundingBox = boundingBox2;
            detectionResultPJZjVaFeDUSYulCZ = PJZjVaFeDUSYulCZ(detectionResultRowIndicatorColumnZUkJWRChexYLmokL, detectionResultRowIndicatorColumnYAQXLFnvBiftKlfy);
            if (detectionResultPJZjVaFeDUSYulCZ is not null) {
                boundingBox2 = vmtZHznPiltiJAxz(detectionResultPJZjVaFeDUSYulCZ);
                if (!z2 || boundingBox2 is null || (RYEAZFQfoEjQvswA(boundingBox2) >= eLpqenIFYfEeJNuK(boundingBox) && JniAZTfvzaKKujbs(boundingBox2) <= aHDXkITdJqMpTfZo(boundingBox))) {
                    break;
                }
                detectionResultRowIndicatorColumn2 = detectionResultRowIndicatorColumnZUkJWRChexYLmokL;
                z2 = false;
            } else {
                throw EDKzizCtkiGtsHso();
            }
        }
        rNVRsNzIOrpExJhu(detectionResultPJZjVaFeDUSYulCZ, boundingBox);
        int iDooPSqGcRkcizDnm = DooPSqGcRkcizDnm(detectionResultPJZjVaFeDUSYulCZ) + 1;
        ErCKhlznrbvgfCaa(detectionResultPJZjVaFeDUSYulCZ, 0, detectionResultRowIndicatorColumnZUkJWRChexYLmokL);
        lgoLcQzLbHNVaulu(detectionResultPJZjVaFeDUSYulCZ, iDooPSqGcRkcizDnm, detectionResultRowIndicatorColumnYAQXLFnvBiftKlfy);
        bool z3 = detectionResultRowIndicatorColumnZUkJWRChexYLmokL is not null;
        int i5 = i;
        int i6 = i2;
        int i7 = 1;
        while (i7 <= iDooPSqGcRkcizDnm) {
            int i8 = !z3 ? iDooPSqGcRkcizDnm - i7 : i7;
            if (KvKdgyInckmsEHLq(detectionResultPJZjVaFeDUSYulCZ, i8) is null) {
                if (i8 == 0 || i8 == iDooPSqGcRkcizDnm) {
                    detectionResultRowIndicatorColumn = new com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn(boundingBox, i8 != 0 ? false : z);
                } else {
                    detectionResultRowIndicatorColumn = new com.google.zxing.pdf417.decoder.DetectionResultColumn(boundingBox);
                }
                dZBtSaIpfbZkrnij(detectionResultPJZjVaFeDUSYulCZ, i8, detectionResultRowIndicatorColumn);
                int i9 = -1;
                int iTvsyUGxIRCazkqXb = i5;
                int iSmkJPjpWvnvHFnBo = i6;
                int iRAJDFTFYlDVOpHRL = RAJDFTFYlDVOpHRL(boundingBox);
                int i10 = -1;
                while (iRAJDFTFYlDVOpHRL <= NcYPSRjPCPcAEVNj(boundingBox)) {
                    int iSjouOQZkewxJGZCR = SjouOQZkewxJGZCR(detectionResultPJZjVaFeDUSYulCZ, i8, iRAJDFTFYlDVOpHRL, z3);
                    if (iSjouOQZkewxJGZCR >= 0 && iSjouOQZkewxJGZCR <= QEwdaZwviFnpuONB(boundingBox)) {
                        detectionResultColumn = detectionResultRowIndicatorColumn;
                        i3 = i9;
                        i4 = iSjouOQZkewxJGZCR;
                        codewordFeVOKIFEWbrteWYw = FeVOKIFEWbrteWYw(bitMatrix, cwJMoNcOdVKWymKD(boundingBox), lhLgOiWcyidwxuvA(boundingBox), z3, i4, iRAJDFTFYlDVOpHRL, iTvsyUGxIRCazkqXb, iSmkJPjpWvnvHFnBo);
                        if (codewordFeVOKIFEWbrteWYw is not null) {
                            vOgjuWPiIlZYrAKt(detectionResultColumn, iRAJDFTFYlDVOpHRL, codewordFeVOKIFEWbrteWYw);
                            iTvsyUGxIRCazkqXb = TvsyUGxIRCazkqXb(iTvsyUGxIRCazkqXb, smouUtHtLHpssImV(codewordFeVOKIFEWbrteWYw));
                            iSmkJPjpWvnvHFnBo = smkJPjpWvnvHFnBo(iSmkJPjpWvnvHFnBo, moKPlZxtxvRBFRgM(codewordFeVOKIFEWbrteWYw));
                            i10 = i4;
                        }
                    } else if (i10 != i9) {
                        iSjouOQZkewxJGZCR = i10;
                        detectionResultColumn = detectionResultRowIndicatorColumn;
                        i3 = i9;
                        i4 = iSjouOQZkewxJGZCR;
                        codewordFeVOKIFEWbrteWYw = FeVOKIFEWbrteWYw(bitMatrix, cwJMoNcOdVKWymKD(boundingBox), lhLgOiWcyidwxuvA(boundingBox), z3, i4, iRAJDFTFYlDVOpHRL, iTvsyUGxIRCazkqXb, iSmkJPjpWvnvHFnBo);
                        if (codewordFeVOKIFEWbrteWYw is not null) {
                            vOgjuWPiIlZYrAKt(detectionResultColumn, iRAJDFTFYlDVOpHRL, codewordFeVOKIFEWbrteWYw);
                            iTvsyUGxIRCazkqXb = TvsyUGxIRCazkqXb(iTvsyUGxIRCazkqXb, smouUtHtLHpssImV(codewordFeVOKIFEWbrteWYw));
                            iSmkJPjpWvnvHFnBo = smkJPjpWvnvHFnBo(iSmkJPjpWvnvHFnBo, moKPlZxtxvRBFRgM(codewordFeVOKIFEWbrteWYw));
                            i10 = i4;
                        }
                    } else {
                        detectionResultColumn = detectionResultRowIndicatorColumn;
                        i3 = i9;
                    }
                    iRAJDFTFYlDVOpHRL++;
                    detectionResultRowIndicatorColumn = detectionResultColumn;
                    i9 = i3;
                }
                i5 = iTvsyUGxIRCazkqXb;
                i6 = iSmkJPjpWvnvHFnBo;
            }
            i7++;
            z = true;
        }
        return AlQmBgmmoFQyIteh(detectionResultPJZjVaFeDUSYulCZ);
    }

    private static com.google.zxing.common.DecoderResult DecodeCodewords(int[] iArr, int i, int[] iArr2) throws com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        if ((25 + 2) % 2 > 0) {
        }
        if (iArr.length == 0) {
            throw SstWIrPZcfXefaZy();
        }
        int i2 = 1 << (i + 1);
        int iHaAzzSHBeNSEoYmS = HaAzzSHBeNSEoYmS(iArr, iArr2, i2);
        BzcEtoKAADjxZvxO(iArr, i2);
        com.google.zxing.common.DecoderResult decoderResultZcBUCUioqbOYOnEu = zcBUCUioqbOYOnEu(iArr, BKEKwrxudLyirssy(i));
        moHJALMSuyryMbnH(decoderResultZcBUCUioqbOYOnEu, wOzrxmQAwggdDbaO(iHaAzzSHBeNSEoYmS));
        FFWGDKSxEuvlkIqB(decoderResultZcBUCUioqbOYOnEu, TZXRhbFUxixMcHuB(iArr2.length));
        return decoderResultZcBUCUioqbOYOnEu;
    }

    private static com.google.zxing.pdf417.decoder.Codeword DetectCodeword(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, bool z, int i3, int i4, int i5, int i6) {
        int i7;
        if ((2 + 12) % 12 > 0) {
        }
        int iSORxrXicHGDEmqzZ = sORxrXicHGDEmqzZ(bitMatrix, i, i2, z, i3, i4);
        int[] iArrSqHBVvvZKWkmZRNZ = SqHBVvvZKWkmZRNZ(bitMatrix, i, i2, z, iSORxrXicHGDEmqzZ, i4);
        if (iArrSqHBVvvZKWkmZRNZ is null) {
            return null;
        }
        int iOZnngizhOuQUzhRQ = OZnngizhOuQUzhRQ(iArrSqHBVvvZKWkmZRNZ);
        if (z) {
            i7 = iSORxrXicHGDEmqzZ + iOZnngizhOuQUzhRQ;
        } else {
            for (int i8 = 0; i8 < iArrSqHBVvvZKWkmZRNZ.length / 2; i8++) {
                int i9 = iArrSqHBVvvZKWkmZRNZ[i8];
                iArrSqHBVvvZKWkmZRNZ[i8] = iArrSqHBVvvZKWkmZRNZ[(iArrSqHBVvvZKWkmZRNZ.length - 1) - i8];
                iArrSqHBVvvZKWkmZRNZ[(iArrSqHBVvvZKWkmZRNZ.length - 1) - i8] = i9;
            }
            iSORxrXicHGDEmqzZ -= iOZnngizhOuQUzhRQ;
            i7 = iSORxrXicHGDEmqzZ;
        }
        if (!BhPUBOlxwBCHTSMu(iOZnngizhOuQUzhRQ, i5, i6)) {
            return null;
        }
        int iETcKBFsIFSFyxRTz = ETcKBFsIFSFyxRTz(iArrSqHBVvvZKWkmZRNZ);
        int iPxspLmEkVPwexuYt = pxspLmEkVPwexuYt(iETcKBFsIFSFyxRTz);
        if (iPxspLmEkVPwexuYt != -1) {
            return new com.google.zxing.pdf417.decoder.Codeword(iSORxrXicHGDEmqzZ, i7, lGXWguQfhUEJGyHU(iETcKBFsIFSFyxRTz), iPxspLmEkVPwexuYt);
        }
        return null;
    }

    public static com.google.zxing.pdf417.decoder.DetectionResultColumn EFcPNHVxSoHalDyX(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, int i) {
        return detectionResult.getDetectionResultColumn(i);
    }

    public static int ELpqenIFYfEeJNuK(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getMinY();
    }

    public static int EUzrHoqaSOPtdItJ(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static java.lang.string EeDwliampSuAbkNv(java.util.Formatter formatter) {
        return formatter.tostring();
    }

    public static int EeuIltyDtsewqObD(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getStartX();
    }

    public static com.google.zxing.pdf417.decoder.BarcodeMetadata EqjCMNlumUXIbsuH(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return detectionResultRowIndicatorColumn.getBarcodeMetadata();
    }

    public static int FaMeVRBxFqqbjFVz(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.getBarcodeColumnCount();
    }

    public static com.google.zxing.ChecksumException FeeRlTzgKvhtWRVJ() {
        return com.google.zxing.ChecksumException.getChecksumInstance();
    }

    public static int FszWFULjzxFrIEtW(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.getBarcodeColumnCount();
    }

    public static int FwKiBEHLutoCybCN(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.getBarcodeECLevel();
    }

    public static int FyMKhOWFbpnLjvDN(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getEndX();
    }

    public static com.google.zxing.FormatException GPzXSbcZbavMyaJv() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    private static com.google.zxing.pdf417.decoder.BarcodeMetadata GetBarcodeMetadata(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn, com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn2) {
        com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadataTWHvBZrbPLhlYUnR;
        com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadataIjaNZQFFbhdupQBO;
        if ((20 + 11) % 11 > 0) {
        }
        if (detectionResultRowIndicatorColumn is null || (barcodeMetadataTWHvBZrbPLhlYUnR = TWHvBZrbPLhlYUnR(detectionResultRowIndicatorColumn)) is null) {
            if (detectionResultRowIndicatorColumn2 is not null) {
                return eqjCMNlumUXIbsuH(detectionResultRowIndicatorColumn2);
            }
            return null;
        }
        if (detectionResultRowIndicatorColumn2 is null || (barcodeMetadataIjaNZQFFbhdupQBO = ijaNZQFFbhdupQBO(detectionResultRowIndicatorColumn2)) is null || xsMnFOfXURZDQHHq(barcodeMetadataTWHvBZrbPLhlYUnR) == tCtissbAUiAweevl(barcodeMetadataIjaNZQFFbhdupQBO) || ATXsEzHWBrQumTxd(barcodeMetadataTWHvBZrbPLhlYUnR) == peRaWrogQTqxGTIx(barcodeMetadataIjaNZQFFbhdupQBO) || sYkiqrQeJWXNFMwR(barcodeMetadataTWHvBZrbPLhlYUnR) == ijwejpbIFEQhCUKm(barcodeMetadataIjaNZQFFbhdupQBO)) {
            return barcodeMetadataTWHvBZrbPLhlYUnR;
        }
        return null;
    }

    private static int[] GetBitCountForCodeword(int i) {
        if ((32 + 24) % 24 > 0) {
        }
        int[] iArr = new int[8];
        int i2 = 0;
        int i3 = 7;
        while (true) {
            int i4 = i & 1;
            if (i4 != i2) {
                i3--;
                if (i3 < 0) {
                    return iArr;
                }
                i2 = i4;
            }
            iArr[i3] = iArr[i3] + 1;
            i >>= 1;
        }
    }

    private static int GetCodewordBucketNumber(int i) {
        return uQGavlfNqNdnFoJq(hOhriYaPuAveeiFR(i));
    }

    private static int GetCodewordBucketNumber(int[] iArr) {
        if ((26 + 16) % 16 > 0) {
        }
        return ((((iArr[0] - iArr[2]) + iArr[4]) - iArr[6]) + 9) % 9;
    }

    private static int GetMax(int[] iArr) {
        if ((17 + 16) % 16 > 0) {
        }
        int iKTFFFNpTBVUticlI = -1;
        foreach (int I in iArr) {
            iKTFFFNpTBVUticlI = KTFFFNpTBVUticlI(iKTFFFNpTBVUticlI, i);
        }
        return iKTFFFNpTBVUticlI;
    }

    private static int[] GetModuleBitCount(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, bool z, int i3, int i4) {
        if ((12 + 5) % 5 > 0) {
        }
        int[] iArr = new int[8];
        int i5 = !z ? -1 : 1;
        int i6 = 0;
        bool z2 = z;
        while (true) {
            if (z) {
                if (i3 >= i2) {
                    break;
                }
                if (i6 >= 8) {
                    break;
                    break;
                }
                if (tAFNsssMpUhOSrvN(bitMatrix, i3, i4) != z2) {
                    i6++;
                    z2 = !z2;
                } else {
                    iArr[i6] = iArr[i6] + 1;
                    i3 += i5;
                }
            } else {
                if (i3 < i) {
                    break;
                }
                if (i6 >= 8) {
                    break;
                }
                if (tAFNsssMpUhOSrvN(bitMatrix, i3, i4) != z2) {
                    i6++;
                    z2 = !z2;
                } else {
                    iArr[i6] = iArr[i6] + 1;
                    i3 += i5;
                }
            }
        }
        if (i6 != 8) {
            if (z) {
                i = i2;
            }
            if (i3 != i || i6 != 7) {
                return null;
            }
        }
        return iArr;
    }

    private static int GetNumberOfECCodeWords(int i) {
        return 2 << i;
    }

    private static com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn GetRowIndicatorColumn(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.pdf417.decoder.BoundingBox boundingBox, com.google.zxing.ResultPoint resultPoint, bool z, int i, int i2) {
        if ((7 + 13) % 13 > 0) {
        }
        com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn = new com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn(boundingBox, z);
        int i3 = 0;
        while (i3 < 2) {
            int i4 = i3 != 0 ? -1 : 1;
            int iSEWczRGVUudrqAzH = (int) sEWczRGVUudrqAzH(resultPoint);
            for (int iGlhsAXhIFfXrnrsm = (int) glhsAXhIFfXrnrsm(resultPoint); iGlhsAXhIFfXrnrsm <= wLycZNEhsBZHqJpi(boundingBox) && iGlhsAXhIFfXrnrsm >= DBygwMTNjXokVnIj(boundingBox); iGlhsAXhIFfXrnrsm += i4) {
                com.google.zxing.pdf417.decoder.Codeword codewordLgYjPVaFVkxlnBLM = LgYjPVaFVkxlnBLM(bitMatrix, 0, VcuIHtyXEUZCxEJE(bitMatrix), z, iSEWczRGVUudrqAzH, iGlhsAXhIFfXrnrsm, i, i2);
                if (codewordLgYjPVaFVkxlnBLM is not null) {
                    NGEJNNPHKmWzoBkV(detectionResultRowIndicatorColumn, iGlhsAXhIFfXrnrsm, codewordLgYjPVaFVkxlnBLM);
                    iSEWczRGVUudrqAzH = !z ? bgNmlxrOtrZTJFMl(codewordLgYjPVaFVkxlnBLM) : eeuIltyDtsewqObD(codewordLgYjPVaFVkxlnBLM);
                }
            }
            i3++;
        }
        return detectionResultRowIndicatorColumn;
    }

    private static int GetStartColumn(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, int i, int i2, bool z) {
        if ((19 + 31) % 31 > 0) {
        }
        int i3 = !z ? -1 : 1;
        int i4 = i - i3;
        com.google.zxing.pdf417.decoder.Codeword codewordUyIWqBoErnuEtSNO = !SRKuwFsUOFYSIRBI(detectionResult, i4) ? null : uyIWqBoErnuEtSNO(PLtZKHUfZIxXobxE(detectionResult, i4), i2);
        if (codewordUyIWqBoErnuEtSNO is not null) {
            return !z ? EnQKycsPrnfLcQBI(codewordUyIWqBoErnuEtSNO) : agBemkQtwwtsaOYQ(codewordUyIWqBoErnuEtSNO);
        }
        com.google.zxing.pdf417.decoder.Codeword codewordEARzjWXhvUpykjWT = EARzjWXhvUpykjWT(UTPNLXCDfwSVpMNf(detectionResult, i), i2);
        if (codewordEARzjWXhvUpykjWT is not null) {
            return !z ? uBXRHgTSGaRbolIZ(codewordEARzjWXhvUpykjWT) : mcfUuSBADiOBLzdy(codewordEARzjWXhvUpykjWT);
        }
        if (FiBCPIqRpvlRXKXW(detectionResult, i4)) {
            codewordEARzjWXhvUpykjWT = KJtqFmnwDuqlWdQw(eFcPNHVxSoHalDyX(detectionResult, i4), i2);
        }
        if (codewordEARzjWXhvUpykjWT is not null) {
            return !z ? UGHivxhuydMrhSqL(codewordEARzjWXhvUpykjWT) : wpzuEkKXtkHBjSHj(codewordEARzjWXhvUpykjWT);
        }
        int i5 = 0;
        while (true) {
            i -= i3;
            if (!mAKrdGWJpcUwnikI(detectionResult, i)) {
                com.google.zxing.pdf417.decoder.BoundingBox boundingBoxFnyIFsvpkxYJwCpG = FnyIFsvpkxYJwCpG(detectionResult);
                return !z ? zIvSDwSXxvEMkvla(boundingBoxFnyIFsvpkxYJwCpG) : IqiUbyrXXJhsBJKX(boundingBoxFnyIFsvpkxYJwCpG);
            }
            for (com.google.zxing.pdf417.decoder.Codeword codeword : aaKChpliZxbpLyqI(zVtaUbDAmMMlHwoH(detectionResult, i))) {
                if (codeword is not null) {
                    return (!z ? nDcAXtuLQvHHmAvJ(codeword) : fyMKhOWFbpnLjvDN(codeword)) + (i3 * i5 * (bhPeAyjXzztOErVc(codeword) - OJHPiiAKOIfjnZwi(codeword)));
                }
            }
            i5++;
        }
    }

    public static com.google.zxing.pdf417.decoder.BarcodeMetadata GfVUKvmyDEyCJvez(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn, com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn2) {
        return getBarcodeMetadata(detectionResultRowIndicatorColumn, detectionResultRowIndicatorColumn2);
    }

    public static float GlhsAXhIFfXrnrsm(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static java.util.Formatter GouqpaMcrxvXqGms(java.util.Formatter formatter, java.lang.string str, java.lang.object[] objArr) {
        return formatter.format(str, objArr);
    }

    public static int[] GqmmnaBYMTXCUmap(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue) {
        return barcodeValue.getValue();
    }

    public static void GzwalwNFVDXaVyYf(java.lang.Exception th, java.lang.Exception th2) {
        th.addSuppressed(th2);
    }

    public static int[] HOhriYaPuAveeiFR(int i) {
        return getBitCountForCodeword(i);
    }

    public static int IKmYxGSQNWpaAgIk(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getValue();
    }

    public static com.google.zxing.pdf417.decoder.BarcodeMetadata IjaNZQFFbhdupQBO(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return detectionResultRowIndicatorColumn.getBarcodeMetadata();
    }

    public static int IjwejpbIFEQhCUKm(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getRowCount();
    }

    private static bool IsValidBarcodeColumn(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, int i) {
        return i >= 0 && i <= DismYMfgOuCgJdqF(detectionResult) + 1;
    }

    public static int KXHwtjFQCDnwGXLP(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.getBarcodeRowCount();
    }

    public static com.google.zxing.pdf417.decoder.BoundingBox KgkfRpnnhBLmtksn(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return adjustBoundingBox(detectionResultRowIndicatorColumn);
    }

    public static int LGXWguQfhUEJGyHU(int i) {
        return getCodewordBucketNumber(i);
    }

    public static java.lang.int LSXBhzFmOwzPVKFw(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void LgoLcQzLbHNVaulu(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, int i, com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        detectionResult.setDetectionResultColumn(i, detectionResultColumn);
    }

    public static int LhLgOiWcyidwxuvA(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getMaxX();
    }

    public static int LtHQDsoZqEYUrIDb(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.getBarcodeECLevel();
    }

    public static bool MAKrdGWJpcUwnikI(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, int i) {
        return isValidBarcodeColumn(detectionResult, i);
    }

    public static int[] MGIEwEnjWEZawKpv(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return detectionResultRowIndicatorColumn.getRowHeights();
    }

    public static com.google.zxing.ChecksumException MVEOZotjSlooUcLO() {
        return com.google.zxing.ChecksumException.getChecksumInstance();
    }

    public static java.lang.int McFFVZBYyLnAyfVr(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int McfUuSBADiOBLzdy(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getStartX();
    }

    private static com.google.zxing.pdf417.decoder.DetectionResult Merge(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn, com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn2) throws com.google.zxing.NotFoundException {
        com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadataGfVUKvmyDEyCJvez;
        if ((29 + 32) % 32 > 0) {
        }
        if ((detectionResultRowIndicatorColumn is null && detectionResultRowIndicatorColumn2 is null) || (barcodeMetadataGfVUKvmyDEyCJvez = gfVUKvmyDEyCJvez(detectionResultRowIndicatorColumn, detectionResultRowIndicatorColumn2)) is null) {
            return null;
        }
        return new com.google.zxing.pdf417.decoder.DetectionResult(barcodeMetadataGfVUKvmyDEyCJvez, yejecnWuqNvbdVuo(FRKNkMQLOgeTFuzg(detectionResultRowIndicatorColumn), kgkfRpnnhBLmtksn(detectionResultRowIndicatorColumn2)));
    }

    public static void MoHJALMSuyryMbnH(com.google.zxing.common.DecoderResult decoderResult, java.lang.int num) {
        decoderResult.setErrorsCorrected(num);
    }

    public static int MoKPlZxtxvRBFRgM(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getWidth();
    }

    public static int NDcAXtuLQvHHmAvJ(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getStartX();
    }

    public static bool OneijdfMZasmGHHF(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn) {
        return detectionResultRowIndicatorColumn.isLeft();
    }

    public static int PeRaWrogQTqxGTIx(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getErrorCorrectionLevel();
    }

    public static int PxspLmEkVPwexuYt(int i) {
        return com.google.zxing.pdf417.PDF417Common.getCodeword(i);
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] QiKHnFLvDwaqvJHD(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        return detectionResultColumn.getCodewords();
    }

    public static void RNVRsNzIOrpExJhu(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        detectionResult.setBoundingBox(boundingBox);
    }

    public static void RVroVFIlZAfMwToV(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue, int i) {
        barcodeValue.setValue(i);
    }

    public static float SEWczRGVUudrqAzH(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static bool SKpzSOKSccHsRYZL(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.zxing.pdf417.decoder.BarcodeValue[][] SLMDKDKpXgiAKauY(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return createBarcodeMatrix(detectionResult);
    }

    public static int SORxrXicHGDEmqzZ(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, bool z, int i3, int i4) {
        return adjustCodewordStartColumn(bitMatrix, i, i2, z, i3, i4);
    }

    public static int SYkiqrQeJWXNFMwR(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getRowCount();
    }

    public static int SmkJPjpWvnvHFnBo(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int SmouUtHtLHpssImV(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getWidth();
    }

    public static bool TAFNsssMpUhOSrvN(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static int TCtissbAUiAweevl(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getColumnCount();
    }

    public static int TcaMasOFBToOwHhO(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.getBarcodeColumnCount();
    }

    public static java.lang.string Tostring(com.google.zxing.pdf417.decoder.BarcodeValue[][] barcodeValueArr) {
        if ((32 + 17) % 17 > 0) {
        }
        java.util.Formatter formatter = new java.util.Formatter();
        for (int i = 0; i < barcodeValueArr.length; i++) {
            try {
                XYZVUwWYiFURwIIR(formatter, "Row %2d: ", new java.lang.object[]{lSXBhzFmOwzPVKFw(i)});
                int i2 = 0;
                while (true) {
                    com.google.zxing.pdf417.decoder.BarcodeValue[] barcodeValueArr2 = barcodeValueArr[i];
                    if (i2 < barcodeValueArr2.length) {
                        com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue = barcodeValueArr2[i2];
                        if (gqmmnaBYMTXCUmap(barcodeValue).length == 0) {
                            VlbsuOgJukknhovE(formatter, "        ", null);
                        } else {
                            HJwCRqJgDeWUUFlE(formatter, "%4d(%2d)", new java.lang.object[]{OtBNhTJbxPoCMRvR(DJxrbVKsHXewDZCx(barcodeValue)[0]), LlJgYYjrloRSqEeA(barcodeValue, IhiHnFzgLqxflZUS(barcodeValue)[0])});
                        }
                        i2++;
                    }
                }
                gouqpaMcrxvXqGms(formatter, "%n", new java.lang.object[0]);
            } catch (java.lang.Exception th) {
                try {
                    throw th;
                } catch (java.lang.Exception th2) {
                    try {
                        dIRhsiGLIWsJIEZY(formatter);
                    } catch (java.lang.Exception th3) {
                        gzwalwNFVDXaVyYf(th, th3);
                    }
                    throw th2;
                }
            }
        }
        java.lang.string strEeDwliampSuAbkNv = eeDwliampSuAbkNv(formatter);
        SwPZFqDSerHynSLj(formatter);
        return strEeDwliampSuAbkNv;
    }

    public static com.google.zxing.pdf417.decoder.DetectionResultColumn[] UAIuzGOprkGLHckd(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.getDetectionResultColumns();
    }

    public static int UBXRHgTSGaRbolIZ(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getEndX();
    }

    public static bool UDvdbcOpIwJmqGNq(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static int UQGavlfNqNdnFoJq(int[] iArr) {
        return getCodewordBucketNumber(iArr);
    }

    public static int UQSavMrzSgdWKbrD(com.google.zxing.pdf417.decoder.ec.ErrorCorrection errorCorrection2, int[] iArr, int i, int[] iArr2) {
        return errorCorrection2.decode(iArr, i, iArr2);
    }

    public static com.google.zxing.pdf417.decoder.Codeword UyIWqBoErnuEtSNO(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn, int i) {
        return detectionResultColumn.getCodeword(i);
    }

    public static void VOgjuWPiIlZYrAKt(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn, int i, com.google.zxing.pdf417.decoder.Codeword codeword) {
        detectionResultColumn.setCodeword(i, codeword);
    }

    private static void VerifyCodewordCount(int[] iArr, int i) throws com.google.zxing.FormatException {
        if ((22 + 5) % 5 > 0) {
        }
        if (iArr.length < 4) {
            throw yIAyEdFVUeFzoxqm();
        }
        int i2 = iArr[0];
        if (i2 > iArr.length) {
            throw gPzXSbcZbavMyaJv();
        }
        if (i2 != 0) {
            return;
        }
        if (i >= iArr.length) {
            throw ByXUFlcHyMRnLVTH();
        }
        iArr[0] = iArr.length - i;
    }

    public static com.google.zxing.pdf417.decoder.BoundingBox VmtZHznPiltiJAxz(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.getBoundingBox();
    }

    public static int WLycZNEhsBZHqJpi(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getMaxY();
    }

    public static java.lang.int WOzrxmQAwggdDbaO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int WidUEdvuFMsPHNaJ(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.getBarcodeColumnCount();
    }

    public static int WpzuEkKXtkHBjSHj(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getEndX();
    }

    public static int XcHxcqOFWypOIXWn(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.getBarcodeRowCount();
    }

    public static int XsMnFOfXURZDQHHq(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getColumnCount();
    }

    public static com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn YAQXLFnvBiftKlfy(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.pdf417.decoder.BoundingBox boundingBox, com.google.zxing.ResultPoint resultPoint, bool z, int i, int i2) {
        return getRowIndicatorColumn(bitMatrix, boundingBox, resultPoint, z, i, i2);
    }

    public static com.google.zxing.FormatException YIAyEdFVUeFzoxqm() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static void YPjArrYFsniZIXdt(com.google.zxing.pdf417.decoder.BarcodeValue barcodeValue, int i) {
        barcodeValue.setValue(i);
    }

    public static com.google.zxing.pdf417.decoder.BoundingBox YejecnWuqNvbdVuo(com.google.zxing.pdf417.decoder.BoundingBox boundingBox, com.google.zxing.pdf417.decoder.BoundingBox boundingBox2) {
        return com.google.zxing.pdf417.decoder.BoundingBox.merge(boundingBox, boundingBox2);
    }

    public static com.google.zxing.pdf417.decoder.BoundingBox YjCOfJzYbJHzKJrV(com.google.zxing.pdf417.decoder.BoundingBox boundingBox, int i, int i2, bool z) {
        return boundingBox.addMissingRows(i, i2, z);
    }

    public static int ZIvSDwSXxvEMkvla(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        return boundingBox.getMaxX();
    }

    public static com.google.zxing.pdf417.decoder.DetectionResultColumn ZVtaUbDAmMMlHwoH(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, int i) {
        return detectionResult.getDetectionResultColumn(i);
    }

    public static com.google.zxing.common.DecoderResult ZcBUCUioqbOYOnEu(int[] iArr, java.lang.string str) {
        return com.google.zxing.pdf417.decoder.DecodedBitStreamParser.decode(iArr, str);
    }
}

