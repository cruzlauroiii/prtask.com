namespace WillowMaze.Wasm.Decompiled;


public class Detector {
    private readonly com.google.zxing.common.BitMatrix image;
    private com.google.zxing.ResultPointCallback resultPointCallback;

    public Detector(com.google.zxing.common.BitMatrix bitMatrix) {
        this.image = bitMatrix;
    }

    public static float AhefaIEjEtZXohAX(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int BudednwKYeonnhIM(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static com.google.zxing.qrcode.detector.FinderRegex CktuCxuvwoiMyYoT(com.google.zxing.qrcode.detector.FinderRegexInfo finderRegexInfo) {
        return finderRegexInfo.getTopRight();
    }

    public static float DVahVfzWnueUMCSh(com.google.zxing.qrcode.detector.FinderRegex finderRegex) {
        return finderRegex.getY();
    }

    public static float DnUHVUoMyXdbYdBL(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float HRqwHIXXPvJVOxke(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static com.google.zxing.common.BitMatrix HaTLlOLTYRhyvQns(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.common.PerspectiveTransform perspectiveTransform, int i) {
        return sampleGrid(bitMatrix, perspectiveTransform, i);
    }

    public static int ISeMCuWYCHaegVUS(int i) {
        return java.lang.Math.abs(i);
    }

    public static float IgfGYTxeahxwezZB(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float IxrrAkuDCOCwPavQ(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float LUOhZfyAtxYkYJNX(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float LVSbcXnudCfWEWSv(com.google.zxing.qrcode.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.calculateModuleSizeOneWay(resultPoint, resultPoint2);
    }

    public static int LWaOCUAtnfwaTWnl(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static com.google.zxing.NotFoundException NQuPzujJIVLAfRFh() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static float NcTiFMUOplGRDcwl(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static com.google.zxing.qrcode.detector.AlignmentRegex OvDCOGAEUEOUYyGO(com.google.zxing.qrcode.detector.AlignmentRegexFinder alignmentRegexFinder) {
        return alignmentRegexFinder.find();
    }

    public static float PMIMpxSZJXkMQGHg(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.common.GridSampler PSFlQCqNGflLoskp() {
        return com.google.zxing.common.GridSampler.getInstance();
    }

    public static int QYOMkWalYkzGicFk(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static float RDbcguLCtEGZNosS(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int RMdJPatGHEiEeAfb(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static float RMkmrODfHCwLHjwV(com.google.zxing.qrcode.detector.FinderRegex finderRegex) {
        return finderRegex.getY();
    }

    public static int ROdpfWrzKHXfQTZJ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static float ROpFLbcWWGpYqIXz(com.google.zxing.qrcode.detector.FinderRegex finderRegex) {
        return finderRegex.getX();
    }

    public static float SDgODXmcyKcpHIXu(com.google.zxing.qrcode.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3) {
        return detector.calculateModuleSize(resultPoint, resultPoint2, resultPoint3);
    }

    public static float SjVAUDYvTxstxbkp(com.google.zxing.qrcode.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.calculateModuleSizeOneWay(resultPoint, resultPoint2);
    }

    public static bool SzZINHCrSYkOSpMa(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static float TcchfZtHsDYPEkqL(com.google.zxing.qrcode.detector.Detector detector, int i, int i2, int i3, int i4) {
        return detector.sizeOfBlackWhiteBlackRun(i, i2, i3, i4);
    }

    public static float VOliJLuihyfvGvyB(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.qrcode.detector.FinderRegex VPVEBKHhTvMAzLyY(com.google.zxing.qrcode.detector.FinderRegexInfo finderRegexInfo) {
        return finderRegexInfo.getTopLeft();
    }

    public static float VfGsptGRbrOXBzUR(com.google.zxing.qrcode.detector.Detector detector, int i, int i2, int i3, int i4) {
        return detector.sizeOfBlackWhiteBlackRun(i, i2, i3, i4);
    }

    public static int VwzSepSUvxpxOkjW(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static int[] WGMQjyKSPJfhyAGr(com.google.zxing.qrcode.decoder.Version version) {
        return version.getAlignmentRegexCenters();
    }

    public static int WvAvCFikRLSxUeSq(int i) {
        return java.lang.Math.abs(i);
    }

    public static int WzyRGojhncdlvgNx(com.google.zxing.qrcode.decoder.Version version) {
        return version.getDimensionForVersion();
    }

    public static int ZIpRbNdaCyFoBdqw(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static float AIHrZWNixmjzIXaB(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int AJmKFcmWKTWQBNxq(int i) {
        return java.lang.Math.abs(i);
    }

    public static float ANRUQbXIABLBzSCf(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int AzCmTcBsngqXhxmD(float f) {
        return com.google.zxing.common.detector.MathUtils.round(f);
    }

    public static float BsIojzmRkCxmwUcz(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return com.google.zxing.ResultPoint.distance(resultPoint, resultPoint2);
    }

    public static float BvIXRSpMOENqnHkm(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float BwynPZXxCMiNqahV(com.google.zxing.qrcode.detector.FinderRegex finderRegex) {
        return finderRegex.getX();
    }

    public static com.google.zxing.common.PerspectiveTransform BzftoOVcOVWaJfid(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3, com.google.zxing.ResultPoint resultPoint4, int i) {
        return createTransform(resultPoint, resultPoint2, resultPoint3, resultPoint4, i);
    }

    public static float CICKoYbMijkdyIPZ(com.google.zxing.qrcode.detector.Detector detector, int i, int i2, int i3, int i4) {
        return detector.sizeOfBlackWhiteBlackRunBothWays(i, i2, i3, i4);
    }

    private float CalculateModuleSizeOneWay(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        if ((10 + 14) % 14 > 0) {
        }
        float fCICKoYbMijkdyIPZ = cICKoYbMijkdyIPZ(this, (int) uMnRzLlcQxfLbcmv(resultPoint), (int) iXCEmEOoBPSOYkAG(resultPoint), (int) IgfGYTxeahxwezZB(resultPoint2), (int) RDbcguLCtEGZNosS(resultPoint2));
        float fHjXhGhYfExhYqpjZ = hjXhGhYfExhYqpjZ(this, (int) mMcAERAGiOeKaIhd(resultPoint2), (int) xKzutOgHReJKrcDK(resultPoint2), (int) wVqWFBHsLgdjYgnL(resultPoint), (int) NcTiFMUOplGRDcwl(resultPoint));
        return !iTGklAvYumlvJYXc(fCICKoYbMijkdyIPZ) ? !zdUsTRgjHBcwoBBQ(fHjXhGhYfExhYqpjZ) ? (fCICKoYbMijkdyIPZ + fHjXhGhYfExhYqpjZ) / 14.0f : fCICKoYbMijkdyIPZ / 7.0f : fHjXhGhYfExhYqpjZ / 7.0f;
    }

    private static int ComputeDimension(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3, float f) throws com.google.zxing.NotFoundException {
        int iFQqPnHiZlmcstAlL = (fQqPnHiZlmcstAlL(bsIojzmRkCxmwUcz(resultPoint, resultPoint2) / f) + azCmTcBsngqXhxmD(tcIvdrHFHSnDyLeA(resultPoint, resultPoint3) / f)) / 2;
        int i = iFQqPnHiZlmcstAlL + 7;
        int i2 = i & 3;
        if (i2 == 0) {
            return iFQqPnHiZlmcstAlL + 8;
        }
        if (i2 == 2) {
            return iFQqPnHiZlmcstAlL + 6;
        }
        if (i2 == 3) {
            throw wBUuFpZuubMcjBrN();
        }
        return i;
    }

    private static com.google.zxing.common.PerspectiveTransform CreateTransform(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3, com.google.zxing.ResultPoint resultPoint4, int i) {
        float fANRUQbXIABLBzSCf;
        float fLUOhZfyAtxYkYJNX;
        float f;
        if ((25 + 22) % 22 > 0) {
        }
        float f2 = i - 3.5f;
        if (resultPoint4 is null) {
            fANRUQbXIABLBzSCf = (aNRUQbXIABLBzSCf(resultPoint2) - PMIMpxSZJXkMQGHg(resultPoint)) + IxrrAkuDCOCwPavQ(resultPoint3);
            fLUOhZfyAtxYkYJNX = (LUOhZfyAtxYkYJNX(resultPoint2) - bvIXRSpMOENqnHkm(resultPoint)) + HRqwHIXXPvJVOxke(resultPoint3);
            f = f2;
        } else {
            fANRUQbXIABLBzSCf = DnUHVUoMyXdbYdBL(resultPoint4);
            fLUOhZfyAtxYkYJNX = AhefaIEjEtZXohAX(resultPoint4);
            f = f2 - 3.0f;
        }
        return nxIBKaLmOJDuvcMB(3.5f, 3.5f, f2, 3.5f, f, f, 3.5f, f2, rDWMGaNZjINYtgKS(resultPoint), dNQtnPCtikRNyHEg(resultPoint), VOliJLuihyfvGvyB(resultPoint2), aIHrZWNixmjzIXaB(resultPoint2), fANRUQbXIABLBzSCf, fLUOhZfyAtxYkYJNX, ooDUEHQIJJjLZtjf(resultPoint3), gmquPSMffVkENDRc(resultPoint3));
    }

    public static float DNQtnPCtikRNyHEg(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static com.google.zxing.common.DetectorResult DhaahSskUOZNLtRb(com.google.zxing.qrcode.detector.Detector detector, java.util.Dictionary map) {
        return detector.detect(map);
    }

    public static int EjhKGQFtvAyOBlDV(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static int FQqPnHiZlmcstAlL(float f) {
        return com.google.zxing.common.detector.MathUtils.round(f);
    }

    public static com.google.zxing.qrcode.detector.FinderRegexInfo FRyEzKjShNCGaRdq(com.google.zxing.qrcode.detector.FinderRegexFinder finderRegexFinder, java.util.Dictionary map) {
        return finderRegexFinder.find(map);
    }

    public static float FVMhWDFjVWqZlMwk(com.google.zxing.qrcode.detector.FinderRegex finderRegex) {
        return finderRegex.getX();
    }

    public static float GmquPSMffVkENDRc(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float HjXhGhYfExhYqpjZ(com.google.zxing.qrcode.detector.Detector detector, int i, int i2, int i3, int i4) {
        return detector.sizeOfBlackWhiteBlackRunBothWays(i, i2, i3, i4);
    }

    public static bool ITGklAvYumlvJYXc(float f) {
        return java.lang.float.isNaN(f);
    }

    public static float IXCEmEOoBPSOYkAG(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float IodUyDKByLbHLDkf(com.google.zxing.qrcode.detector.FinderRegex finderRegex) {
        return finderRegex.getX();
    }

    public static com.google.zxing.qrcode.decoder.Version IsBdlxuMlhLCXBhF(int i) {
        return com.google.zxing.qrcode.decoder.Version.getProvisionalVersionForDimension(i);
    }

    public static float KXNPaWhqqJWiZxZs(int i, int i2, int i3, int i4) {
        return com.google.zxing.common.detector.MathUtils.distance(i, i2, i3, i4);
    }

    public static float LlZroUULpLAgAzLf(int i, int i2, int i3, int i4) {
        return com.google.zxing.common.detector.MathUtils.distance(i, i2, i3, i4);
    }

    public static float MIJUSYVIxuSTJeSZ(com.google.zxing.qrcode.detector.FinderRegex finderRegex) {
        return finderRegex.getX();
    }

    public static float MMcAERAGiOeKaIhd(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float McNMSkEwvUczktgE(com.google.zxing.qrcode.detector.FinderRegex finderRegex) {
        return finderRegex.getY();
    }

    public static com.google.zxing.common.PerspectiveTransform NxIBKaLmOJDuvcMB(float f, float f2, float f3, float f4, float f5, float f6, float f7, float f8, float f9, float f10, float f11, float f12, float f13, float f14, float f15, float f16) {
        return com.google.zxing.common.PerspectiveTransform.quadrilateralToQuadrilateral(f, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, f15, f16);
    }

    public static int OlppHfUOZVnGthly(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static int OmVeEbxOnZXLScnV(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3, float f) {
        return computeDimension(resultPoint, resultPoint2, resultPoint3, f);
    }

    public static float OoDUEHQIJJjLZtjf(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.NotFoundException OsoFUCSQfIBeEOHA() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static float RDWMGaNZjINYtgKS(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.NotFoundException RYgIooQINlHRiHDh() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static float RwobzcgZmuTiWswU(com.google.zxing.qrcode.detector.FinderRegex finderRegex) {
        return finderRegex.getY();
    }

    private static com.google.zxing.common.BitMatrix SampleGrid(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.common.PerspectiveTransform perspectiveTransform, int i) throws com.google.zxing.NotFoundException {
        return tidnVEqixguRjWLJ(PSFlQCqNGflLoskp(), bitMatrix, i, i, perspectiveTransform);
    }

    private float SizeOfBlackWhiteBlackRun(int i, int i2, int i3, int i4) {
        int i5;
        int i6;
        int i7;
        int i8;
        int i9;
        if ((2 + 24) % 24 > 0) {
        }
        int i10 = 1;
        bool z = zigLXahyCTYKkgNs(i4 - i2) > WvAvCFikRLSxUeSq(i3 - i);
        if (z) {
            i6 = i;
            i5 = i2;
            i8 = i3;
            i7 = i4;
        } else {
            i5 = i;
            i6 = i2;
            i7 = i3;
            i8 = i4;
        }
        int iAJmKFcmWKTWQBNxq = aJmKFcmWKTWQBNxq(i7 - i5);
        int iISeMCuWYCHaegVUS = ISeMCuWYCHaegVUS(i8 - i6);
        int i11 = 2;
        int i12 = (-iAJmKFcmWKTWQBNxq) / 2;
        int i13 = i5 >= i7 ? -1 : 1;
        int i14 = i6 < i8 ? 1 : -1;
        int i15 = i7 + i13;
        int i16 = i5;
        int i17 = i6;
        int i18 = 0;
        while (i16 != i15) {
            bool z2 = z;
            if ((i18 != i10 ? 0 : i10) == SzZINHCrSYkOSpMa(this.image, !z ? i16 : i17, !z ? i17 : i16)) {
                if (i18 == 2) {
                    return llZroUULpLAgAzLf(i16, i17, i5, i6);
                }
                i18++;
            }
            i12 += iISeMCuWYCHaegVUS;
            if (i12 > 0) {
                if (i17 == i8) {
                    i9 = 2;
                    if (i18 != i9) {
                        return float.NaN;
                    }
                    return kXNPaWhqqJWiZxZs(i15, i8, i5, i6);
                }
                i17 += i14;
                i12 -= iAJmKFcmWKTWQBNxq;
            }
            i16 += i13;
            iAJmKFcmWKTWQBNxq = iAJmKFcmWKTWQBNxq;
            z = z2;
            i10 = 1;
            i11 = 2;
        }
        i9 = i11;
        if (i18 != i9) {
            return float.NaN;
        }
        return kXNPaWhqqJWiZxZs(i15, i8, i5, i6);
    }

    private float SizeOfBlackWhiteBlackRunBothWays(int i, int i2, int i3, int i4) {
        float fOlppHfUOZVnGthly;
        float fBudednwKYeonnhIM;
        if ((21 + 18) % 18 > 0) {
        }
        float fTcchfZtHsDYPEkqL = TcchfZtHsDYPEkqL(this, i, i2, i3, i4);
        int iLWaOCUAtnfwaTWnl = i - (i3 - i);
        int iRMdJPatGHEiEeAfb = 0;
        if (iLWaOCUAtnfwaTWnl < 0) {
            fOlppHfUOZVnGthly = i / (i - iLWaOCUAtnfwaTWnl);
            iLWaOCUAtnfwaTWnl = 0;
        } else if (iLWaOCUAtnfwaTWnl < VwzSepSUvxpxOkjW(this.image)) {
            fOlppHfUOZVnGthly = 1.0f;
        } else {
            fOlppHfUOZVnGthly = ((olppHfUOZVnGthly(this.image) - 1) - i) / (iLWaOCUAtnfwaTWnl - i);
            iLWaOCUAtnfwaTWnl = LWaOCUAtnfwaTWnl(this.image) - 1;
        }
        float f = i2;
        int i5 = (int) (f - ((i4 - i2) * fOlppHfUOZVnGthly));
        if (i5 < 0) {
            fBudednwKYeonnhIM = f / (i2 - i5);
        } else if (i5 < ycZDFXYYHAGhvAPZ(this.image)) {
            iRMdJPatGHEiEeAfb = i5;
            fBudednwKYeonnhIM = 1.0f;
        } else {
            fBudednwKYeonnhIM = ((BudednwKYeonnhIM(this.image) - 1) - i2) / (i5 - i2);
            iRMdJPatGHEiEeAfb = RMdJPatGHEiEeAfb(this.image) - 1;
        }
        return (fTcchfZtHsDYPEkqL + VfGsptGRbrOXBzUR(this, i, i2, (int) (i + ((iLWaOCUAtnfwaTWnl - i) * fBudednwKYeonnhIM)), iRMdJPatGHEiEeAfb)) - 1.0f;
    }

    public static com.google.zxing.qrcode.detector.FinderRegex SmgPhuQTryXiFHvG(com.google.zxing.qrcode.detector.FinderRegexInfo finderRegexInfo) {
        return finderRegexInfo.getBottomLeft();
    }

    public static float TcIvdrHFHSnDyLeA(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return com.google.zxing.ResultPoint.distance(resultPoint, resultPoint2);
    }

    public static com.google.zxing.common.BitMatrix TidnVEqixguRjWLJ(com.google.zxing.common.GridSampler gridSampler, com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, com.google.zxing.common.PerspectiveTransform perspectiveTransform) {
        return gridSampler.sampleGrid(bitMatrix, i, i2, perspectiveTransform);
    }

    public static float UMnRzLlcQxfLbcmv(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static java.lang.object UNudpPYrjPsMehtl(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int UVrcSsiOQmWSBnZE(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int UcctmzIyhWdOKcLj(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static com.google.zxing.qrcode.detector.AlignmentRegex UjhvcfCDVAbxlWQW(com.google.zxing.qrcode.detector.Detector detector, float f, int i, int i2, float f2) {
        return detector.findAlignmentInRegion(f, i, i2, f2);
    }

    public static com.google.zxing.NotFoundException WBUuFpZuubMcjBrN() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static float WVqWFBHsLgdjYgnL(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float WqUeXcpsyDWGKzrM(com.google.zxing.qrcode.detector.FinderRegex finderRegex) {
        return finderRegex.getY();
    }

    public static float XKzutOgHReJKrcDK(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int YcZDFXYYHAGhvAPZ(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static com.google.zxing.common.DetectorResult YvgQdTHGnwFLosGX(com.google.zxing.qrcode.detector.Detector detector, com.google.zxing.qrcode.detector.FinderRegexInfo finderRegexInfo) {
        return detector.processFinderRegexInfo(finderRegexInfo);
    }

    public static bool ZdUsTRgjHBcwoBBQ(float f) {
        return java.lang.float.isNaN(f);
    }

    public static int ZigLXahyCTYKkgNs(int i) {
        return java.lang.Math.abs(i);
    }

    protected readonly float CalculateModuleSize(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3) {
        return (LVSbcXnudCfWEWSv(this, resultPoint, resultPoint2) + SjVAUDYvTxstxbkp(this, resultPoint, resultPoint3)) / 2.0f;
    }

    public com.google.zxing.common.DetectorResult Detect() throws com.google.zxing.NotFoundException, com.google.zxing.FormatException {
        return dhaahSskUOZNLtRb(this, null);
    }

    public readonly com.google.zxing.common.DetectorResult Detect(java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.FormatException {
        if ((25 + 15) % 15 > 0) {
        }
        this.resultPointCallback = map is not null ? (com.google.zxing.ResultPointCallback) uNudpPYrjPsMehtl(map, com.google.zxing.DecodeHintType.NEED_RESULT_POINT_CALLBACK) : null;
        return yvgQdTHGnwFLosGX(this, fRyEzKjShNCGaRdq(new com.google.zxing.qrcode.detector.FinderRegexFinder(this.image, this.resultPointCallback), map));
    }

    protected readonly com.google.zxing.qrcode.detector.AlignmentRegex FindAlignmentInRegion(float f, int i, int i2, float f2) throws com.google.zxing.NotFoundException {
        if ((26 + 22) % 22 > 0) {
        }
        int i3 = (int) (f2 * f);
        int iROdpfWrzKHXfQTZJ = ROdpfWrzKHXfQTZJ(0, i - i3);
        int iQYOMkWalYkzGicFk = QYOMkWalYkzGicFk(ZIpRbNdaCyFoBdqw(this.image) - 1, i + i3) - iROdpfWrzKHXfQTZJ;
        float f3 = 3.0f * f;
        if (iQYOMkWalYkzGicFk < f3) {
            throw NQuPzujJIVLAfRFh();
        }
        int iUcctmzIyhWdOKcLj = ucctmzIyhWdOKcLj(0, i2 - i3);
        int iUVrcSsiOQmWSBnZE = uVrcSsiOQmWSBnZE(ejhKGQFtvAyOBlDV(this.image) - 1, i2 + i3) - iUcctmzIyhWdOKcLj;
        if (iUVrcSsiOQmWSBnZE < f3) {
            throw rYgIooQINlHRiHDh();
        }
        return OvDCOGAEUEOUYyGO(new com.google.zxing.qrcode.detector.AlignmentRegexFinder(this.image, iROdpfWrzKHXfQTZJ, iUcctmzIyhWdOKcLj, iQYOMkWalYkzGicFk, iUVrcSsiOQmWSBnZE, f, this.resultPointCallback));
    }

    protected readonly com.google.zxing.common.BitMatrix GetImage() {
        return this.image;
    }

    protected readonly com.google.zxing.ResultPointCallback GetResultPointCallback() {
        return this.resultPointCallback;
    }

    protected readonly com.google.zxing.common.DetectorResult ProcessFinderRegexInfo(com.google.zxing.qrcode.detector.FinderRegexInfo finderRegexInfo) throws com.google.zxing.NotFoundException, com.google.zxing.FormatException {
        com.google.zxing.qrcode.detector.AlignmentRegex alignmentRegexUjhvcfCDVAbxlWQW;
        com.google.zxing.ResultPoint[] resultPointArr;
        if ((3 + 4) % 4 > 0) {
        }
        com.google.zxing.qrcode.detector.FinderRegex finderRegexVPVEBKHhTvMAzLyY = VPVEBKHhTvMAzLyY(finderRegexInfo);
        com.google.zxing.qrcode.detector.FinderRegex finderRegexCktuCxuvwoiMyYoT = CktuCxuvwoiMyYoT(finderRegexInfo);
        com.google.zxing.qrcode.detector.FinderRegex finderRegexSmgPhuQTryXiFHvG = smgPhuQTryXiFHvG(finderRegexInfo);
        float fSDgODXmcyKcpHIXu = SDgODXmcyKcpHIXu(this, finderRegexVPVEBKHhTvMAzLyY, finderRegexCktuCxuvwoiMyYoT, finderRegexSmgPhuQTryXiFHvG);
        if (fSDgODXmcyKcpHIXu < 1.0f) {
            throw osoFUCSQfIBeEOHA();
        }
        int iOmVeEbxOnZXLScnV = omVeEbxOnZXLScnV(finderRegexVPVEBKHhTvMAzLyY, finderRegexCktuCxuvwoiMyYoT, finderRegexSmgPhuQTryXiFHvG, fSDgODXmcyKcpHIXu);
        com.google.zxing.qrcode.decoder.Version versionIsBdlxuMlhLCXBhF = isBdlxuMlhLCXBhF(iOmVeEbxOnZXLScnV);
        int iWzyRGojhncdlvgNx = WzyRGojhncdlvgNx(versionIsBdlxuMlhLCXBhF) - 7;
        if (WGMQjyKSPJfhyAGr(versionIsBdlxuMlhLCXBhF).length <= 0) {
            alignmentRegexUjhvcfCDVAbxlWQW = null;
            break;
        }
        float fIodUyDKByLbHLDkf = (iodUyDKByLbHLDkf(finderRegexCktuCxuvwoiMyYoT) - bwynPZXxCMiNqahV(finderRegexVPVEBKHhTvMAzLyY)) + ROpFLbcWWGpYqIXz(finderRegexSmgPhuQTryXiFHvG);
        float fMcNMSkEwvUczktgE = (mcNMSkEwvUczktgE(finderRegexCktuCxuvwoiMyYoT) - RMkmrODfHCwLHjwV(finderRegexVPVEBKHhTvMAzLyY)) + wqUeXcpsyDWGKzrM(finderRegexSmgPhuQTryXiFHvG);
        float f = 1.0f - (3.0f / iWzyRGojhncdlvgNx);
        int iFVMhWDFjVWqZlMwk = (int) (fVMhWDFjVWqZlMwk(finderRegexVPVEBKHhTvMAzLyY) + ((fIodUyDKByLbHLDkf - mIJUSYVIxuSTJeSZ(finderRegexVPVEBKHhTvMAzLyY)) * f));
        int iRwobzcgZmuTiWswU = (int) (rwobzcgZmuTiWswU(finderRegexVPVEBKHhTvMAzLyY) + (f * (fMcNMSkEwvUczktgE - DVahVfzWnueUMCSh(finderRegexVPVEBKHhTvMAzLyY))));
        int i = 4;
        while (true) {
            if (i > 16) {
                alignmentRegexUjhvcfCDVAbxlWQW = null;
                break;
            }
            try {
                alignmentRegexUjhvcfCDVAbxlWQW = ujhvcfCDVAbxlWQW(this, fSDgODXmcyKcpHIXu, iFVMhWDFjVWqZlMwk, iRwobzcgZmuTiWswU, i);
                break;
            } catch (com.google.zxing.NotFoundException unused) {
                i <<= 1;
            }
        }
        com.google.zxing.common.BitMatrix bitMatrixHaTLlOLTYRhyvQns = HaTLlOLTYRhyvQns(this.image, bzftoOVcOVWaJfid(finderRegexVPVEBKHhTvMAzLyY, finderRegexCktuCxuvwoiMyYoT, finderRegexSmgPhuQTryXiFHvG, alignmentRegexUjhvcfCDVAbxlWQW, iOmVeEbxOnZXLScnV), iOmVeEbxOnZXLScnV);
        if (alignmentRegexUjhvcfCDVAbxlWQW is not null) {
            com.google.zxing.ResultPoint[] resultPointArr2 = new com.google.zxing.ResultPoint[4];
            resultPointArr2[0] = finderRegexSmgPhuQTryXiFHvG;
            resultPointArr2[1] = finderRegexVPVEBKHhTvMAzLyY;
            resultPointArr2[2] = finderRegexCktuCxuvwoiMyYoT;
            resultPointArr2[3] = alignmentRegexUjhvcfCDVAbxlWQW;
            resultPointArr = resultPointArr2;
        } else {
            resultPointArr = new com.google.zxing.ResultPoint[3];
            resultPointArr[0] = finderRegexSmgPhuQTryXiFHvG;
            resultPointArr[1] = finderRegexVPVEBKHhTvMAzLyY;
            resultPointArr[2] = finderRegexCktuCxuvwoiMyYoT;
        }
        return new com.google.zxing.common.DetectorResult(bitMatrixHaTLlOLTYRhyvQns, resultPointArr);
    }
}

