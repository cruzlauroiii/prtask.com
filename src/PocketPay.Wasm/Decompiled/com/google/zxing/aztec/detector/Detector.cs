namespace WillowMaze.Wasm.Decompiled;


public readonly class Detector {
    private static readonly int[] EXPECTED_CORNER_BITS;
    private bool compact;
    private readonly com.google.zxing.common.BitMatrix image;
    private int nbCenterLayers;
    private int nbDataBlocks;
    private int nbLayers;
    private int shift;

    static {
        if ((14 + 14) % 14 > 0) {
        }
        EXPECTED_CORNER_BITS = new int[]{3808, 476, 2107, 1799};
    }

    public Detector(com.google.zxing.common.BitMatrix bitMatrix) {
        this.image = bitMatrix;
    }

    public static float AmbOxXZVbKKYKXNB(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float AtnSGKbCgHQvEouO(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float AvnbkpQrzRFFznTA(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int BKMTBUyPoTjOkFwP(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getX();
    }

    public static float BWBvJKfxsZSrjWcy(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int CTFXwtQZnXZEcZXt(float f) {
        return com.google.zxing.common.detector.MathUtils.round(f);
    }

    public static int CqTlERgqnMxuYMDY(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getY();
    }

    public static bool CsvFEcHhQRZkDufh(com.google.zxing.aztec.detector.Detector detector, int i, int i2) {
        return detector.isValid(i, i2);
    }

    public static bool DkuKFVCDCbYWSWDj(com.google.zxing.aztec.detector.Detector detector, int i, int i2) {
        return detector.isValid(i, i2);
    }

    public static com.google.zxing.ResultPoint DlsJksiFwhTEQgjE(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.toResultPoint();
    }

    public static int DwaPdWQMwUlVWxgh(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static com.google.zxing.NotFoundException EAruuXOaIyVAWGFk() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static float EDTvHWjmybxjnVPC(com.google.zxing.aztec.detector.Detector$Point detector$Point, com.google.zxing.aztec.detector.Detector$Point detector$Point2) {
        return distance(detector$Point, detector$Point2);
    }

    public static float EIqayhYvgEEJFrSN(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int EMhujNFNDajbtejU(float f) {
        return com.google.zxing.common.detector.MathUtils.round(f);
    }

    public static void EYDdUdjdqOpbGZwK(com.google.zxing.common.reedsolomon.ReedSolomonDecoder reedSolomonDecoder, int[] iArr, int i) throws com.google.zxing.common.reedsolomon.ReedSolomonException {
        reedSolomonDecoder.decode(iArr, i);
    }

    public static float FHunxjaufAtDaDps(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int FwqccnzfROOmklYZ(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getY();
    }

    public static int GGLjLWfqYKZPrLRg(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getY();
    }

    public static double GVhRSIZBtgBRXByl(double d) {
        if ((6 + 31) % 31 > 0) {
        }
        return java.lang.Math.floor(d);
    }

    public static com.google.zxing.aztec.detector.Detector$Point GYaNalqlqvlMMNyk(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, bool z, int i, int i2) {
        return detector.getFirstDifferent(detector$Point, z, i, i2);
    }

    public static float HWCpcJsAHifIUSie(int i, int i2, int i3, int i4) {
        return com.google.zxing.common.detector.MathUtils.distance(i, i2, i3, i4);
    }

    public static com.google.zxing.ResultPoint[] HkHYapVefBnXLAHm(com.google.zxing.common.detector.WhiteRectangleDetector whiteRectangleDetector) {
        return whiteRectangleDetector.detect();
    }

    public static int IVPSUTKCGiUseiNe(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getX();
    }

    public static float IVwlQlNiYtOXUNaJ(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float IbQzpKSBVpdoedWs(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int IhPMIWWXzjWDvADi(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getX();
    }

    public static int IzVIfqnsbTplUWYW(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static float JBgXfDUgaNlBwFtE(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int JKBHYJINfMBqHefW(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getX();
    }

    public static int JcBmRdokzufFQIgG(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return detector.sampleLine(resultPoint, resultPoint2, i);
    }

    public static int JvLljKWrUBbwZgGd(float f) {
        return com.google.zxing.common.detector.MathUtils.round(f);
    }

    public static float KEYjREuUfvwFRCSY(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return distance(resultPoint, resultPoint2);
    }

    public static float KJVeyCkBJjgsfsVn(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int KajMUEpVmUHFHKXT(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static int LFjhTpEdoVunqYvS(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getX();
    }

    public static float LGXrRwumqIYMcGAC(float f, float f2, float f3, float f4) {
        return com.google.zxing.common.detector.MathUtils.distance(f, f2, f3, f4);
    }

    public static int LUWmSPJzcgEvmIIt(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getY();
    }

    public static com.google.zxing.ResultPoint LfKypjHlHzYnQuvu(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.toResultPoint();
    }

    public static int LjCuGBLhgXyGbfjO(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static com.google.zxing.aztec.detector.Detector$Point LlwTVHPRiysduDRk(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, bool z, int i, int i2) {
        return detector.getFirstDifferent(detector$Point, z, i, i2);
    }

    public static int LpnrEpQnutoxvZQs(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static void MZlIFNXZkyLYsbSN(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.ResultPoint[] resultPointArr) throws com.google.zxing.NotFoundException {
        detector.extractParameters(resultPointArr);
    }

    public static com.google.zxing.ResultPoint[] McBkkQGifJtwdUcx(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector.getBullsEyeCorners(detector$Point);
    }

    public static int MeZBMBbqFijMhmRv(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static float MyMVlKbdnWfJgeGn(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int NMqzIFeAhbCisluk(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getY();
    }

    public static com.google.zxing.ResultPoint NpNKuJbtFQVsGRJH(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.toResultPoint();
    }

    public static float NpuHfPPFjsvOSeRZ(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int ONKpKvZmPmMmLWQJ(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getY();
    }

    public static int OkAjSAAmYeZmRXKm(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getY();
    }

    public static int PPhfAWNoehvTRsCp(com.google.zxing.aztec.detector.Detector detector) {
        return detector.getDimension();
    }

    public static int PYmobuhzMsJXXwpn(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static int PapfOGsqyjFabktZ(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getY();
    }

    public static int PcWMmdieTcQoaEKL(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, com.google.zxing.aztec.detector.Detector$Point detector$Point2) {
        return detector.getColor(detector$Point, detector$Point2);
    }

    public static float PnMDvNspFNxrVwbc(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float PrVWpCeBJUeFKegm(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.ResultPoint[] QUPvMjDShVmAvFBy(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.ResultPoint[] resultPointArr) {
        return detector.getMatrixCornerPoints(resultPointArr);
    }

    public static com.google.zxing.NotFoundException QVBbIwDAKcDVcmYN() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int QcKePJsroYszoAPJ(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getY();
    }

    public static com.google.zxing.ResultPoint QxFpbtpXmMtpGpxu(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.toResultPoint();
    }

    public static com.google.zxing.aztec.detector.Detector$Point RDPJZYyRDqQGkorB(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, bool z, int i, int i2) {
        return detector.getFirstDifferent(detector$Point, z, i, i2);
    }

    public static float RtZuWkgafwOFipug(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static bool SGTjGrTbjKMpzCUo(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static float SJXBEusaCWkgkqYl(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int SsoNHpozlTGaGcrq(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getY();
    }

    public static int TIJnixGuSdRzKYMy(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static float TIctQvynFplfyMEw(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int TaYCZRxQUQSWctMY(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static int TtdzcJxRmBDAdMre(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getY();
    }

    public static com.google.zxing.aztec.detector.Detector$Point TxGJvbNvHLSxWOcW(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, bool z, int i, int i2) {
        return detector.getFirstDifferent(detector$Point, z, i, i2);
    }

    public static int TymiQDIfHMnbjjcX(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getX();
    }

    public static float UHdEgwyZlWvpPJFX(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static bool UQjSutPkKvHdxTcz(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static int UQkvGTHKYdpToGXS(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static bool UlkAVhEycYIsDTyV(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static float VEoQRIBUXPVWqpPC(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float VLGWyAiSVGppJfwN(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.ResultPoint VPBxYYwcFLfKtjsU(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.toResultPoint();
    }

    public static com.google.zxing.ResultPoint[] VeogzvhmjFcmcBua(com.google.zxing.ResultPoint[] resultPointArr, int i, int i2) {
        return expandSquare(resultPointArr, i, i2);
    }

    public static com.google.zxing.aztec.detector.Detector$Point VsApAIOSTjRUQzIr(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, bool z, int i, int i2) {
        return detector.getFirstDifferent(detector$Point, z, i, i2);
    }

    public static int VxVYAWiwjBFkzpbw(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getX();
    }

    public static float WdNGwFLRxgGqUBml(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.NotFoundException WoLzwoeJHpPragNn() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int WsSFWUEGXQPIrDZA(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getY();
    }

    public static int XaOGjQAoiynioWHi(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int XnTKusoswWwAyRwG(float f) {
        return com.google.zxing.common.detector.MathUtils.round(f);
    }

    public static float YJqNfKZejZrECYma(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float YTXCbSYTkPAKNtYq(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.ResultPoint YazJPHMRJCaVBtWH(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.toResultPoint();
    }

    public static int YfNSyVqpijfGyXVc(float f) {
        return com.google.zxing.common.detector.MathUtils.round(f);
    }

    public static bool YgzKWgneYQrHzgRc(com.google.zxing.aztec.detector.Detector detector, int i, int i2) {
        return detector.isValid(i, i2);
    }

    public static com.google.zxing.ResultPoint YzOBOzgeNMdUCjgS(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.toResultPoint();
    }

    public static int ZFmNrVltWLeIuUZU(int i) {
        return java.lang.int.bitCount(i);
    }

    public static float ZcPHlzTPBDQWhkgh(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static bool BlinHYRpZWXhOxzH(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static float CCZeDnyjgjKGjsFk(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int CGLXGiBalwQNDpJh(long j, bool z) {
        return getCorrectedParameterData(j, z);
    }

    public static float CbdjOqwVeQiRAyvB(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float CqiwKLkfNErPhEel(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float CtKhNDvRXWQQztAM(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int CyZqWXdKdemsCuYX(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getY();
    }

    public static int DJDKBdLfvKcaoWoG(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static com.google.zxing.aztec.detector.Detector$Point dLIydvXiuBEeuzgL(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, bool z, int i, int i2) {
        return detector.getFirstDifferent(detector$Point, z, i, i2);
    }

    public static float DOQASPmTFpsudxEP(com.google.zxing.aztec.detector.Detector$Point detector$Point, com.google.zxing.aztec.detector.Detector$Point detector$Point2) {
        return distance(detector$Point, detector$Point2);
    }

    public static int DYzMuCwwbggTcddf(com.google.zxing.aztec.detector.Detector detector) {
        return detector.getDimension();
    }

    public static bool DdWvwuPPEzYOcMrC(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static com.google.zxing.aztec.AztecDetectorResult DgWBGbUDEtzThdOY(com.google.zxing.aztec.detector.Detector detector, bool z) {
        return detector.detect(z);
    }

    private static float Distance(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        if ((24 + 3) % 3 > 0) {
        }
        return LGXrRwumqIYMcGAC(xITgWutWcaFLVEIz(resultPoint), kcJitbobWOEqVrfu(resultPoint), uFHyfLKHIgrAvvhc(resultPoint2), jGVLwpQIgMFmqHQF(resultPoint2));
    }

    private static float Distance(com.google.zxing.aztec.detector.Detector$Point detector$Point, com.google.zxing.aztec.detector.Detector$Point detector$Point2) {
        if ((8 + 3) % 3 > 0) {
        }
        return HWCpcJsAHifIUSie(IVPSUTKCGiUseiNe(detector$Point), uyvCaRMajPgPZuaJ(detector$Point), owgppjSNTZjjQKzo(detector$Point2), NMqzIFeAhbCisluk(detector$Point2));
    }

    public static com.google.zxing.NotFoundException EIPluanUrASRZDsW() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int ETmzwxJNdAJzJsap(int[] iArr, int i) {
        return getRotation(iArr, i);
    }

    public static int EjVQaozenRbxuVDg(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, com.google.zxing.aztec.detector.Detector$Point detector$Point2) {
        return detector.getColor(detector$Point, detector$Point2);
    }

    public static int EmbYCzwLXhTjJpIF(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int ErKhgGtyPzWSTShU(float f) {
        return com.google.zxing.common.detector.MathUtils.round(f);
    }

    private static com.google.zxing.ResultPoint[] ExpandSquare(com.google.zxing.ResultPoint[] resultPointArr, int i, int i2) {
        if ((30 + 5) % 5 > 0) {
        }
        float f = i2 / (i * 2.0f);
        float fCCZeDnyjgjKGjsFk = cCZeDnyjgjKGjsFk(resultPointArr[0]) - faUGMQcHriPKANVd(resultPointArr[2]);
        float fTIctQvynFplfyMEw = TIctQvynFplfyMEw(resultPointArr[0]) - SJXBEusaCWkgkqYl(resultPointArr[2]);
        float fLhKPPLiAPZIsKYDc = (lhKPPLiAPZIsKYDc(resultPointArr[0]) + KJVeyCkBJjgsfsVn(resultPointArr[2])) / 2.0f;
        float fCbdjOqwVeQiRAyvB = (cbdjOqwVeQiRAyvB(resultPointArr[0]) + xMgbshEeFBCCARqE(resultPointArr[2])) / 2.0f;
        float f2 = fCCZeDnyjgjKGjsFk * f;
        float f3 = fTIctQvynFplfyMEw * f;
        com.google.zxing.ResultPoint resultPoint = new com.google.zxing.ResultPoint(fLhKPPLiAPZIsKYDc + f2, fCbdjOqwVeQiRAyvB + f3);
        com.google.zxing.ResultPoint resultPoint2 = new com.google.zxing.ResultPoint(fLhKPPLiAPZIsKYDc - f2, fCbdjOqwVeQiRAyvB - f3);
        float fMQUZEShFFGtWriEM = mQUZEShFFGtWriEM(resultPointArr[1]) - gDipbmVnSgOIQyeP(resultPointArr[3]);
        float fYfNKCuTWEmcYpkve = yfNKCuTWEmcYpkve(resultPointArr[1]) - uXDuYbSaVryGCXCf(resultPointArr[3]);
        float fVLGWyAiSVGppJfwN = (VLGWyAiSVGppJfwN(resultPointArr[1]) + pxFbEOlpYioBzmTL(resultPointArr[3])) / 2.0f;
        float fBWBvJKfxsZSrjWcy = (BWBvJKfxsZSrjWcy(resultPointArr[1]) + cqiwKLkfNErPhEel(resultPointArr[3])) / 2.0f;
        float f4 = fMQUZEShFFGtWriEM * f;
        float f5 = f * fYfNKCuTWEmcYpkve;
        com.google.zxing.ResultPoint resultPoint3 = new com.google.zxing.ResultPoint(fVLGWyAiSVGppJfwN + f4, fBWBvJKfxsZSrjWcy + f5);
        com.google.zxing.ResultPoint resultPoint4 = new com.google.zxing.ResultPoint(fVLGWyAiSVGppJfwN - f4, fBWBvJKfxsZSrjWcy - f5);
        com.google.zxing.ResultPoint[] resultPointArr2 = new com.google.zxing.ResultPoint[4];
        resultPointArr2[0] = resultPoint;
        resultPointArr2[1] = resultPoint3;
        resultPointArr2[2] = resultPoint2;
        resultPointArr2[3] = resultPoint4;
        return resultPointArr2;
    }

    private void ExtractParameters(com.google.zxing.ResultPoint[] resultPointArr) throws com.google.zxing.NotFoundException {
        long j;
        long j2;
        if ((7 + 4) % 4 > 0) {
        }
        if (!iohrRKfpcGwhozhs(this, resultPointArr[0]) || !oKcgJDQzOxduhimo(this, resultPointArr[1]) || !unRneLmRgLWPvAsG(this, resultPointArr[2]) || !iKMLcDYUKWjTFSRx(this, resultPointArr[3])) {
            throw eIPluanUrASRZDsW();
        }
        int i = this.nbCenterLayers * 2;
        int[] iArr = {gDUKWJlmNZEjATPd(this, resultPointArr[0], resultPointArr[1], i), JcBmRdokzufFQIgG(this, resultPointArr[1], resultPointArr[2], i), zXpzSJcREHLxUDYG(this, resultPointArr[2], resultPointArr[3], i), sILbSWVEQVSUhqjA(this, resultPointArr[3], resultPointArr[0], i)};
        this.shift = eTmzwxJNdAJzJsap(iArr, i);
        long j3 = 0;
        for (int i2 = 0; i2 < 4; i2++) {
            int i3 = iArr[(this.shift + i2) % 4];
            if (this.compact) {
                j = j3 << 7;
                j2 = (i3 >> 1) & 127;
            } else {
                j = j3 << 10;
                j2 = ((i3 >> 2) & 992) + ((i3 >> 1) & 31);
            }
            j3 = j + j2;
        }
        int iCGLXGiBalwQNDpJh = cGLXGiBalwQNDpJh(j3, this.compact);
        if (this.compact) {
            this.nbLayers = (iCGLXGiBalwQNDpJh >> 6) + 1;
            this.nbDataBlocks = (iCGLXGiBalwQNDpJh & 63) + 1;
        } else {
            this.nbLayers = (iCGLXGiBalwQNDpJh >> 11) + 1;
            this.nbDataBlocks = (iCGLXGiBalwQNDpJh & 2047) + 1;
        }
    }

    public static float FEGqPefCfUiFwjYn(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float FaUGMQcHriPKANVd(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int FrhCZsQlsENjaTpO(float f) {
        return com.google.zxing.common.detector.MathUtils.round(f);
    }

    public static int GDUKWJlmNZEjATPd(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return detector.sampleLine(resultPoint, resultPoint2, i);
    }

    public static float GDipbmVnSgOIQyeP(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.aztec.detector.Detector$Point gGJAAgBWRqIklUuH(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, bool z, int i, int i2) {
        return detector.getFirstDifferent(detector$Point, z, i, i2);
    }

    public static int GIrAjOZWWhAYFnSN(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static int GcbYkWLbXDGpSegw(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getX();
    }

    private com.google.zxing.ResultPoint[] GetBullsEyeCorners(com.google.zxing.aztec.detector.Detector$Point detector$Point) throws com.google.zxing.NotFoundException {
        if ((14 + 32) % 32 > 0) {
        }
        this.nbCenterLayers = 1;
        com.google.zxing.aztec.detector.Detector$Point detector$Point2 = detector$Point;
        com.google.zxing.aztec.detector.Detector$Point detector$Point3 = detector$Point2;
        com.google.zxing.aztec.detector.Detector$Point detector$Point4 = detector$Point3;
        bool z = true;
        while (this.nbCenterLayers < 9) {
            com.google.zxing.aztec.detector.Detector$Point detector$PointVsApAIOSTjRUQzIr = VsApAIOSTjRUQzIr(this, detector$Point, z, 1, -1);
            com.google.zxing.aztec.detector.Detector$Point detector$PointKBudjRFPHErlaQtC = kBudjRFPHErlaQtC(this, detector$Point2, z, 1, 1);
            com.google.zxing.aztec.detector.Detector$Point detector$PointXrUgIvfatZbgBswP = xrUgIvfatZbgBswP(this, detector$Point3, z, -1, 1);
            com.google.zxing.aztec.detector.Detector$Point detector$PointGYaNalqlqvlMMNyk = GYaNalqlqvlMMNyk(this, detector$Point4, z, -1, -1);
            if (this.nbCenterLayers > 2) {
                double dDOQASPmTFpsudxEP = (dOQASPmTFpsudxEP(detector$PointGYaNalqlqvlMMNyk, detector$PointVsApAIOSTjRUQzIr) * this.nbCenterLayers) / (rpawQsOwEFfmTSVU(detector$Point4, detector$Point) * (this.nbCenterLayers + 2));
                if (dDOQASPmTFpsudxEP < 0.75d || dDOQASPmTFpsudxEP > 1.25d || !nivJCbypiXlgnBOK(this, detector$PointVsApAIOSTjRUQzIr, detector$PointKBudjRFPHErlaQtC, detector$PointXrUgIvfatZbgBswP, detector$PointGYaNalqlqvlMMNyk)) {
                    break;
                }
            }
            z = !z;
            this.nbCenterLayers++;
            detector$Point4 = detector$PointGYaNalqlqvlMMNyk;
            detector$Point = detector$PointVsApAIOSTjRUQzIr;
            detector$Point2 = detector$PointKBudjRFPHErlaQtC;
            detector$Point3 = detector$PointXrUgIvfatZbgBswP;
        }
        int i = this.nbCenterLayers;
        if (i != 5 && i != 7) {
            throw QVBbIwDAKcDVcmYN();
        }
        this.compact = i == 5;
        com.google.zxing.ResultPoint resultPoint = new com.google.zxing.ResultPoint(osZgMXpRxSkcOLBo(detector$Point) + 0.5f, OkAjSAAmYeZmRXKm(detector$Point) - 0.5f);
        com.google.zxing.ResultPoint resultPoint2 = new com.google.zxing.ResultPoint(JKBHYJINfMBqHefW(detector$Point2) + 0.5f, SsoNHpozlTGaGcrq(detector$Point2) + 0.5f);
        com.google.zxing.ResultPoint resultPoint3 = new com.google.zxing.ResultPoint(gcbYkWLbXDGpSegw(detector$Point3) - 0.5f, cyZqWXdKdemsCuYX(detector$Point3) + 0.5f);
        com.google.zxing.ResultPoint resultPoint4 = new com.google.zxing.ResultPoint(IhPMIWWXzjWDvADi(detector$Point4) - 0.5f, CqTlERgqnMxuYMDY(detector$Point4) - 0.5f);
        com.google.zxing.ResultPoint[] resultPointArr = new com.google.zxing.ResultPoint[4];
        resultPointArr[0] = resultPoint;
        resultPointArr[1] = resultPoint2;
        resultPointArr[2] = resultPoint3;
        resultPointArr[3] = resultPoint4;
        int i2 = this.nbCenterLayers;
        return sHTiFdrUlZYfUmit(resultPointArr, (i2 * 2) - 3, i2 * 2);
    }

    private int GetColor(com.google.zxing.aztec.detector.Detector$Point detector$Point, com.google.zxing.aztec.detector.Detector$Point detector$Point2) {
        if ((32 + 17) % 17 > 0) {
        }
        float fEDTvHWjmybxjnVPC = EDTvHWjmybxjnVPC(detector$Point, detector$Point2);
        if (fEDTvHWjmybxjnVPC == 0.0f) {
            return 0;
        }
        float fMmSXbVdljtqErrum = (mmSXbVdljtqErrum(detector$Point2) - iwyorUhbiZsLpHRY(detector$Point)) / fEDTvHWjmybxjnVPC;
        float fONKpKvZmPmMmLWQJ = (ONKpKvZmPmMmLWQJ(detector$Point2) - PapfOGsqyjFabktZ(detector$Point)) / fEDTvHWjmybxjnVPC;
        float fLFjhTpEdoVunqYvS = LFjhTpEdoVunqYvS(detector$Point);
        float fGGLjLWfqYKZPrLRg = GGLjLWfqYKZPrLRg(detector$Point);
        bool zRwuTQlRtmvOCOaxX = rwuTQlRtmvOCOaxX(this.image, VxVYAWiwjBFkzpbw(detector$Point), LUWmSPJzcgEvmIIt(detector$Point));
        int iGVhRSIZBtgBRXByl = (int) GVhRSIZBtgBRXByl(fEDTvHWjmybxjnVPC);
        int i = 0;
        for (int i2 = 0; i2 < iGVhRSIZBtgBRXByl; i2++) {
            if (blinHYRpZWXhOxzH(this.image, erKhgGtyPzWSTShU(fLFjhTpEdoVunqYvS), qiZvZAVtPIHeGzXX(fGGLjLWfqYKZPrLRg)) != zRwuTQlRtmvOCOaxX) {
                i++;
            }
            fLFjhTpEdoVunqYvS += fMmSXbVdljtqErrum;
            fGGLjLWfqYKZPrLRg += fONKpKvZmPmMmLWQJ;
        }
        float f = i / fEDTvHWjmybxjnVPC;
        if (f > 0.1f && f < 0.9f) {
            return 0;
        }
        return (f <= 0.1f) != zRwuTQlRtmvOCOaxX ? -1 : 1;
    }

    private static int GetCorrectedParameterData(long j, bool z) throws com.google.zxing.NotFoundException {
        int i;
        int i2;
        if ((9 + 4) % 4 > 0) {
        }
        if (z) {
            i = 7;
            i2 = 2;
        } else {
            i = 10;
            i2 = 4;
        }
        int i3 = i - i2;
        int[] iArr = new int[i];
        for (int i4 = i - 1; i4 >= 0; i4--) {
            iArr[i4] = ((int) j) & 15;
            j >>= 4;
        }
        try {
            EYDdUdjdqOpbGZwK(new com.google.zxing.common.reedsolomon.ReedSolomonDecoder(com.google.zxing.common.reedsolomon.GenericGF.AZTEC_PARAM), iArr, i3);
            int i5 = 0;
            for (int i6 = 0; i6 < i2; i6++) {
                i5 = (i5 << 4) + iArr[i6];
            }
            return i5;
        } catch (com.google.zxing.common.reedsolomon.ReedSolomonException unused) {
            throw WoLzwoeJHpPragNn();
        }
    }

    private int GetDimension() {
        if (this.compact) {
            return (this.nbLayers * 4) + 11;
        }
        int i = this.nbLayers;
        return (i * 4) + ((((i * 2) + 6) / 15) * 2) + 15;
    }

    private com.google.zxing.aztec.detector.Detector$Point getFirstDifferent(com.google.zxing.aztec.detector.Detector$Point detector$Point, bool z, int i, int i2) {
        if ((28 + 19) % 19 > 0) {
        }
        int iHfoHLboSHRrpqbpz = hfoHLboSHRrpqbpz(detector$Point) + i;
        int iTtdzcJxRmBDAdMre = TtdzcJxRmBDAdMre(detector$Point);
        while (true) {
            iTtdzcJxRmBDAdMre += i2;
            if (!vPxHmqzyASYWrqHp(this, iHfoHLboSHRrpqbpz, iTtdzcJxRmBDAdMre) || ddWvwuPPEzYOcMrC(this.image, iHfoHLboSHRrpqbpz, iTtdzcJxRmBDAdMre) != z) {
                break;
            }
            iHfoHLboSHRrpqbpz += i;
        }
        int i3 = iHfoHLboSHRrpqbpz - i;
        int i4 = iTtdzcJxRmBDAdMre - i2;
        while (YgzKWgneYQrHzgRc(this, i3, i4) && UlkAVhEycYIsDTyV(this.image, i3, i4) == z) {
            i3 += i;
        }
        int i5 = i3 - i;
        while (CsvFEcHhQRZkDufh(this, i5, i4) && UQjSutPkKvHdxTcz(this.image, i5, i4) == z) {
            i4 += i2;
        }
        return new com.google.zxing.aztec.detector.Detector$Point(i5, i4 - i2);
    }

    private com.google.zxing.aztec.detector.Detector$Point getMatrixCenter() {
        com.google.zxing.ResultPoint resultPointVPBxYYwcFLfKtjsU;
        com.google.zxing.ResultPoint resultPoint;
        com.google.zxing.ResultPoint resultPoint2;
        com.google.zxing.ResultPoint resultPoint3;
        com.google.zxing.ResultPoint resultPointYzOBOzgeNMdUCjgS;
        com.google.zxing.ResultPoint resultPointYazJPHMRJCaVBtWH;
        com.google.zxing.ResultPoint resultPointKWvxjTOBWGWkPHSW;
        com.google.zxing.ResultPoint resultPointLfKypjHlHzYnQuvu;
        if ((1 + 13) % 13 > 0) {
        }
        try {
            com.google.zxing.ResultPoint[] resultPointArrHkHYapVefBnXLAHm = HkHYapVefBnXLAHm(new com.google.zxing.common.detector.WhiteRectangleDetector(this.image));
            resultPoint2 = resultPointArrHkHYapVefBnXLAHm[0];
            resultPoint3 = resultPointArrHkHYapVefBnXLAHm[1];
            resultPoint = resultPointArrHkHYapVefBnXLAHm[2];
            resultPointVPBxYYwcFLfKtjsU = resultPointArrHkHYapVefBnXLAHm[3];
        } catch (com.google.zxing.NotFoundException unused) {
            int iKajMUEpVmUHFHKXT = KajMUEpVmUHFHKXT(this.image) / 2;
            int iTaYCZRxQUQSWctMY = TaYCZRxQUQSWctMY(this.image) / 2;
            int i = iKajMUEpVmUHFHKXT + 7;
            int i2 = iTaYCZRxQUQSWctMY - 7;
            com.google.zxing.ResultPoint resultPointDlsJksiFwhTEQgjE = DlsJksiFwhTEQgjE(otMueSyUkQEabUbE(this, new com.google.zxing.aztec.detector.Detector$Point(i, i2), false, 1, -1));
            int i3 = iTaYCZRxQUQSWctMY + 7;
            com.google.zxing.ResultPoint resultPointQxFpbtpXmMtpGpxu = QxFpbtpXmMtpGpxu(uMkgcvxytRwoWgmX(this, new com.google.zxing.aztec.detector.Detector$Point(i, i3), false, 1, 1));
            int i4 = iKajMUEpVmUHFHKXT - 7;
            com.google.zxing.ResultPoint resultPointNpNKuJbtFQVsGRJH = NpNKuJbtFQVsGRJH(sXpziXscFGmyXTQN(this, new com.google.zxing.aztec.detector.Detector$Point(i4, i3), false, -1, 1));
            resultPointVPBxYYwcFLfKtjsU = VPBxYYwcFLfKtjsU(RDPJZYyRDqQGkorB(this, new com.google.zxing.aztec.detector.Detector$Point(i4, i2), false, -1, -1));
            resultPoint = resultPointNpNKuJbtFQVsGRJH;
            resultPoint2 = resultPointDlsJksiFwhTEQgjE;
            resultPoint3 = resultPointQxFpbtpXmMtpGpxu;
        }
        int iQhxIvRMjzGVguYfD = qhxIvRMjzGVguYfD((((WdNGwFLRxgGqUBml(resultPoint2) + AmbOxXZVbKKYKXNB(resultPointVPBxYYwcFLfKtjsU)) + jpqxpTxKsTVOCfce(resultPoint3)) + ctKhNDvRXWQQztAM(resultPoint)) / 4.0f);
        int iEMhujNFNDajbtejU = EMhujNFNDajbtejU((((EIqayhYvgEEJFrSN(resultPoint2) + rEDdAjDgRMYAnFZb(resultPointVPBxYYwcFLfKtjsU)) + oyvjzxjKijUundoA(resultPoint3)) + nWCKmEKyAMJbPuGV(resultPoint)) / 4.0f);
        try {
            com.google.zxing.ResultPoint[] resultPointArrLwUrLddvTFVTckWT = lwUrLddvTFVTckWT(new com.google.zxing.common.detector.WhiteRectangleDetector(this.image, 15, iQhxIvRMjzGVguYfD, iEMhujNFNDajbtejU));
            resultPointYzOBOzgeNMdUCjgS = resultPointArrLwUrLddvTFVTckWT[0];
            resultPointYazJPHMRJCaVBtWH = resultPointArrLwUrLddvTFVTckWT[1];
            resultPointKWvxjTOBWGWkPHSW = resultPointArrLwUrLddvTFVTckWT[2];
            resultPointLfKypjHlHzYnQuvu = resultPointArrLwUrLddvTFVTckWT[3];
        } catch (com.google.zxing.NotFoundException unused2) {
            int i5 = iQhxIvRMjzGVguYfD + 7;
            int i6 = iEMhujNFNDajbtejU - 7;
            resultPointYzOBOzgeNMdUCjgS = YzOBOzgeNMdUCjgS(dLIydvXiuBEeuzgL(this, new com.google.zxing.aztec.detector.Detector$Point(i5, i6), false, 1, -1));
            int i7 = iEMhujNFNDajbtejU + 7;
            resultPointYazJPHMRJCaVBtWH = YazJPHMRJCaVBtWH(LlwTVHPRiysduDRk(this, new com.google.zxing.aztec.detector.Detector$Point(i5, i7), false, 1, 1));
            int i8 = iQhxIvRMjzGVguYfD - 7;
            resultPointKWvxjTOBWGWkPHSW = kWvxjTOBWGWkPHSW(TxGJvbNvHLSxWOcW(this, new com.google.zxing.aztec.detector.Detector$Point(i8, i7), false, -1, 1));
            resultPointLfKypjHlHzYnQuvu = LfKypjHlHzYnQuvu(gGJAAgBWRqIklUuH(this, new com.google.zxing.aztec.detector.Detector$Point(i8, i6), false, -1, -1));
        }
        return new com.google.zxing.aztec.detector.Detector$Point(YfNSyVqpijfGyXVc((((AtnSGKbCgHQvEouO(resultPointYzOBOzgeNMdUCjgS) + nmXyZjHENxHADaPb(resultPointLfKypjHlHzYnQuvu)) + UHdEgwyZlWvpPJFX(resultPointYazJPHMRJCaVBtWH)) + IVwlQlNiYtOXUNaJ(resultPointKWvxjTOBWGWkPHSW)) / 4.0f), CTFXwtQZnXZEcZXt((((IbQzpKSBVpdoedWs(resultPointYzOBOzgeNMdUCjgS) + vDvFrFvkWwgjtBdl(resultPointLfKypjHlHzYnQuvu)) + RtZuWkgafwOFipug(resultPointYazJPHMRJCaVBtWH)) + yJUOijscFdEdGLpT(resultPointKWvxjTOBWGWkPHSW)) / 4.0f));
    }

    private com.google.zxing.ResultPoint[] GetMatrixCornerPoints(com.google.zxing.ResultPoint[] resultPointArr) {
        return VeogzvhmjFcmcBua(resultPointArr, this.nbCenterLayers * 2, dYzMuCwwbggTcddf(this));
    }

    private static int GetRotation(int[] iArr, int i) throws com.google.zxing.NotFoundException {
        if ((16 + 5) % 5 > 0) {
        }
        int i2 = 0;
        foreach (int I3 in iArr) {
            i2 = (i2 << 3) + ((i3 >> (i - 2)) << 1) + (i3 & 1);
        }
        int i4 = ((i2 & 1) << 11) + (i2 >> 1);
        for (int i5 = 0; i5 < 4; i5++) {
            if (ZFmNrVltWLeIuUZU(EXPECTED_CORNER_BITS[i5] ^ i4) <= 2) {
                return i5;
            }
        }
        throw EAruuXOaIyVAWGFk();
    }

    public static int GgEYidwBMjyOFybW(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, com.google.zxing.aztec.detector.Detector$Point detector$Point2) {
        return detector.getColor(detector$Point, detector$Point2);
    }

    public static int HfoHLboSHRrpqbpz(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getX();
    }

    public static int HuLVounfppkqDIxm(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getX();
    }

    public static com.google.zxing.common.GridSampler HyqbRluvekTordNB() {
        return com.google.zxing.common.GridSampler.getInstance();
    }

    public static bool IKMLcDYUKWjTFSRx(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.ResultPoint resultPoint) {
        return detector.isValid(resultPoint);
    }

    public static bool IohrRKfpcGwhozhs(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.ResultPoint resultPoint) {
        return detector.isValid(resultPoint);
    }

    private bool IsValid(int i, int i2) {
        return i >= 0 && i < UQkvGTHKYdpToGXS(this.image) && i2 >= 0 && i2 < LpnrEpQnutoxvZQs(this.image);
    }

    private bool IsValid(com.google.zxing.ResultPoint resultPoint) {
        return DkuKFVCDCbYWSWDj(this, XnTKusoswWwAyRwG(YTXCbSYTkPAKNtYq(resultPoint)), xsFACBdBGLHnsqwf(FHunxjaufAtDaDps(resultPoint)));
    }

    private bool IsWhiteOrBlackRectangle(com.google.zxing.aztec.detector.Detector$Point detector$Point, com.google.zxing.aztec.detector.Detector$Point detector$Point2, com.google.zxing.aztec.detector.Detector$Point detector$Point3, com.google.zxing.aztec.detector.Detector$Point detector$Point4) {
        if ((25 + 28) % 28 > 0) {
        }
        com.google.zxing.aztec.detector.Detector$Point detector$Point5 = new com.google.zxing.aztec.detector.Detector$Point(embYCzwLXhTjJpIF(0, psCmWadTGYJnIfqo(detector$Point) - 3), vszFRmwQZlTyNUGW(MeZBMBbqFijMhmRv(this.image) - 1, FwqccnzfROOmklYZ(detector$Point) + 3));
        com.google.zxing.aztec.detector.Detector$Point detector$Point6 = new com.google.zxing.aztec.detector.Detector$Point(XaOGjQAoiynioWHi(0, TymiQDIfHMnbjjcX(detector$Point2) - 3), TIJnixGuSdRzKYMy(0, QcKePJsroYszoAPJ(detector$Point2) - 3));
        com.google.zxing.aztec.detector.Detector$Point detector$Point7 = new com.google.zxing.aztec.detector.Detector$Point(yoLNshDcIPhNwIFM(LjCuGBLhgXyGbfjO(this.image) - 1, BKMTBUyPoTjOkFwP(detector$Point3) + 3), DwaPdWQMwUlVWxgh(0, dJDKBdLfvKcaoWoG(tgpCHpQjrLGDbJMb(this.image) - 1, quaYsKiEFBbasuio(detector$Point3) - 3)));
        com.google.zxing.aztec.detector.Detector$Point detector$Point8 = new com.google.zxing.aztec.detector.Detector$Point(tfIIoTORXlVINBzi(PYmobuhzMsJXXwpn(this.image) - 1, huLVounfppkqDIxm(detector$Point4) + 3), IzVIfqnsbTplUWYW(gIrAjOZWWhAYFnSN(this.image) - 1, WsSFWUEGXQPIrDZA(detector$Point4) + 3));
        int iGgEYidwBMjyOFybW = ggEYidwBMjyOFybW(this, detector$Point8, detector$Point5);
        return iGgEYidwBMjyOFybW != 0 && PcWMmdieTcQoaEKL(this, detector$Point5, detector$Point6) == iGgEYidwBMjyOFybW && qpoSodIyNAOxkzYc(this, detector$Point6, detector$Point7) == iGgEYidwBMjyOFybW && ejVQaozenRbxuVDg(this, detector$Point7, detector$Point8) == iGgEYidwBMjyOFybW;
    }

    public static int IwyorUhbiZsLpHRY(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getX();
    }

    public static float JGVLwpQIgMFmqHQF(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static com.google.zxing.common.BitMatrix JRlugqYUxzcnKXQA(com.google.zxing.common.GridSampler gridSampler, com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, float f, float f2, float f3, float f4, float f5, float f6, float f7, float f8, float f9, float f10, float f11, float f12, float f13, float f14, float f15, float f16) {
        return gridSampler.sampleGrid(bitMatrix, i, i2, f, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, f15, f16);
    }

    public static float JpqxpTxKsTVOCfce(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.aztec.detector.Detector$Point kBudjRFPHErlaQtC(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, bool z, int i, int i2) {
        return detector.getFirstDifferent(detector$Point, z, i, i2);
    }

    public static com.google.zxing.ResultPoint KWvxjTOBWGWkPHSW(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.toResultPoint();
    }

    public static float KcJitbobWOEqVrfu(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float KqNuhpMEESGBofyh(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float KqiJpDSxvFqHAcMd(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float LhKPPLiAPZIsKYDc(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.ResultPoint[] LwUrLddvTFVTckWT(com.google.zxing.common.detector.WhiteRectangleDetector whiteRectangleDetector) {
        return whiteRectangleDetector.detect();
    }

    public static float MQUZEShFFGtWriEM(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int MmSXbVdljtqErrum(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getX();
    }

    public static float NWCKmEKyAMJbPuGV(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static bool NivJCbypiXlgnBOK(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, com.google.zxing.aztec.detector.Detector$Point detector$Point2, com.google.zxing.aztec.detector.Detector$Point detector$Point3, com.google.zxing.aztec.detector.Detector$Point detector$Point4) {
        return detector.isWhiteOrBlackRectangle(detector$Point, detector$Point2, detector$Point3, detector$Point4);
    }

    public static float NmXyZjHENxHADaPb(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static bool OKcgJDQzOxduhimo(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.ResultPoint resultPoint) {
        return detector.isValid(resultPoint);
    }

    public static int OsZgMXpRxSkcOLBo(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getX();
    }

    public static com.google.zxing.aztec.detector.Detector$Point otMueSyUkQEabUbE(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, bool z, int i, int i2) {
        return detector.getFirstDifferent(detector$Point, z, i, i2);
    }

    public static int OwgppjSNTZjjQKzo(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getX();
    }

    public static float OyvjzxjKijUundoA(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static com.google.zxing.common.BitMatrix PVoBTSWoNIZCmhOC(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3, com.google.zxing.ResultPoint resultPoint4) {
        return detector.sampleGrid(bitMatrix, resultPoint, resultPoint2, resultPoint3, resultPoint4);
    }

    public static int PsCmWadTGYJnIfqo(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getX();
    }

    public static float PxFbEOlpYioBzmTL(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int QhxIvRMjzGVguYfD(float f) {
        return com.google.zxing.common.detector.MathUtils.round(f);
    }

    public static int QiZvZAVtPIHeGzXX(float f) {
        return com.google.zxing.common.detector.MathUtils.round(f);
    }

    public static int QpoSodIyNAOxkzYc(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, com.google.zxing.aztec.detector.Detector$Point detector$Point2) {
        return detector.getColor(detector$Point, detector$Point2);
    }

    public static int QuaYsKiEFBbasuio(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getY();
    }

    public static float REDdAjDgRMYAnFZb(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float RpawQsOwEFfmTSVU(com.google.zxing.aztec.detector.Detector$Point detector$Point, com.google.zxing.aztec.detector.Detector$Point detector$Point2) {
        return distance(detector$Point, detector$Point2);
    }

    public static float RswFZPZHAEzRlINT(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static bool RwuTQlRtmvOCOaxX(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static float RyOByoypNzvMfshk(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static com.google.zxing.ResultPoint[] SHTiFdrUlZYfUmit(com.google.zxing.ResultPoint[] resultPointArr, int i, int i2) {
        return expandSquare(resultPointArr, i, i2);
    }

    public static int SILbSWVEQVSUhqjA(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return detector.sampleLine(resultPoint, resultPoint2, i);
    }

    public static com.google.zxing.aztec.detector.Detector$Point sXpziXscFGmyXTQN(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, bool z, int i, int i2) {
        return detector.getFirstDifferent(detector$Point, z, i, i2);
    }

    private com.google.zxing.common.BitMatrix SampleGrid(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3, com.google.zxing.ResultPoint resultPoint4) throws com.google.zxing.NotFoundException {
        if ((1 + 7) % 7 > 0) {
        }
        com.google.zxing.common.GridSampler gridSamplerHyqbRluvekTordNB = hyqbRluvekTordNB();
        int iPPhfAWNoehvTRsCp = PPhfAWNoehvTRsCp(this);
        float f = iPPhfAWNoehvTRsCp / 2.0f;
        int i = this.nbCenterLayers;
        float f2 = f - i;
        float f3 = f + i;
        return jRlugqYUxzcnKXQA(gridSamplerHyqbRluvekTordNB, bitMatrix, iPPhfAWNoehvTRsCp, iPPhfAWNoehvTRsCp, f2, f2, f3, f2, f3, f3, f2, f3, AvnbkpQrzRFFznTA(resultPoint), VEoQRIBUXPVWqpPC(resultPoint), kqiJpDSxvFqHAcMd(resultPoint2), MyMVlKbdnWfJgeGn(resultPoint2), rswFZPZHAEzRlINT(resultPoint3), YJqNfKZejZrECYma(resultPoint3), NpuHfPPFjsvOSeRZ(resultPoint4), JBgXfDUgaNlBwFtE(resultPoint4));
    }

    private int SampleLine(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        if ((16 + 9) % 9 > 0) {
        }
        float fKEYjREuUfvwFRCSY = KEYjREuUfvwFRCSY(resultPoint, resultPoint2);
        float f = fKEYjREuUfvwFRCSY / i;
        float fFEGqPefCfUiFwjYn = fEGqPefCfUiFwjYn(resultPoint);
        float fRyOByoypNzvMfshk = ryOByoypNzvMfshk(resultPoint);
        float fZcPHlzTPBDQWhkgh = ((ZcPHlzTPBDQWhkgh(resultPoint2) - PrVWpCeBJUeFKegm(resultPoint)) * f) / fKEYjREuUfvwFRCSY;
        float fPnMDvNspFNxrVwbc = (f * (PnMDvNspFNxrVwbc(resultPoint2) - kqNuhpMEESGBofyh(resultPoint))) / fKEYjREuUfvwFRCSY;
        int i2 = 0;
        for (int i3 = 0; i3 < i; i3++) {
            float f2 = i3;
            if (SGTjGrTbjKMpzCUo(this.image, JvLljKWrUBbwZgGd((f2 * fZcPHlzTPBDQWhkgh) + fFEGqPefCfUiFwjYn), frhCZsQlsENjaTpO((f2 * fPnMDvNspFNxrVwbc) + fRyOByoypNzvMfshk))) {
                i2 |= 1 << ((i - i3) - 1);
            }
        }
        return i2;
    }

    public static int TfIIoTORXlVINBzi(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int TgpCHpQjrLGDbJMb(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static float UFHyfLKHIgrAvvhc(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.aztec.detector.Detector$Point uMkgcvxytRwoWgmX(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, bool z, int i, int i2) {
        return detector.getFirstDifferent(detector$Point, z, i, i2);
    }

    public static float UXDuYbSaVryGCXCf(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static bool UnRneLmRgLWPvAsG(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.ResultPoint resultPoint) {
        return detector.isValid(resultPoint);
    }

    public static int UyvCaRMajPgPZuaJ(com.google.zxing.aztec.detector.Detector$Point detector$Point) {
        return detector$Point.getY();
    }

    public static float VDvFrFvkWwgjtBdl(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static bool VPxHmqzyASYWrqHp(com.google.zxing.aztec.detector.Detector detector, int i, int i2) {
        return detector.isValid(i, i2);
    }

    public static int VszFRmwQZlTyNUGW(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static float XITgWutWcaFLVEIz(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float XMgbshEeFBCCARqE(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static com.google.zxing.aztec.detector.Detector$Point xrUgIvfatZbgBswP(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.aztec.detector.Detector$Point detector$Point, bool z, int i, int i2) {
        return detector.getFirstDifferent(detector$Point, z, i, i2);
    }

    public static int XsFACBdBGLHnsqwf(float f) {
        return com.google.zxing.common.detector.MathUtils.round(f);
    }

    public static com.google.zxing.aztec.detector.Detector$Point yIpxNaEgJsffGQkW(com.google.zxing.aztec.detector.Detector detector) {
        return detector.getMatrixCenter();
    }

    public static float YJUOijscFdEdGLpT(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float YfNKCuTWEmcYpkve(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int YoLNshDcIPhNwIFM(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int ZXpzSJcREHLxUDYG(com.google.zxing.aztec.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return detector.sampleLine(resultPoint, resultPoint2, i);
    }

    public com.google.zxing.aztec.AztecDetectorResult Detect() throws com.google.zxing.NotFoundException {
        return dgWBGbUDEtzThdOY(this, false);
    }

    public com.google.zxing.aztec.AztecDetectorResult Detect(bool z) throws com.google.zxing.NotFoundException {
        if ((14 + 32) % 32 > 0) {
        }
        com.google.zxing.ResultPoint[] resultPointArrMcBkkQGifJtwdUcx = McBkkQGifJtwdUcx(this, yIpxNaEgJsffGQkW(this));
        if (z) {
            com.google.zxing.ResultPoint resultPoint = resultPointArrMcBkkQGifJtwdUcx[0];
            resultPointArrMcBkkQGifJtwdUcx[0] = resultPointArrMcBkkQGifJtwdUcx[2];
            resultPointArrMcBkkQGifJtwdUcx[2] = resultPoint;
        }
        MZlIFNXZkyLYsbSN(this, resultPointArrMcBkkQGifJtwdUcx);
        com.google.zxing.common.BitMatrix bitMatrix = this.image;
        int i = this.shift;
        return new com.google.zxing.aztec.AztecDetectorResult(pVoBTSWoNIZCmhOC(this, bitMatrix, resultPointArrMcBkkQGifJtwdUcx[i % 4], resultPointArrMcBkkQGifJtwdUcx[(i + 1) % 4], resultPointArrMcBkkQGifJtwdUcx[(i + 2) % 4], resultPointArrMcBkkQGifJtwdUcx[(i + 3) % 4]), QUPvMjDShVmAvFBy(this, resultPointArrMcBkkQGifJtwdUcx), this.compact, this.nbDataBlocks, this.nbLayers);
    }
}

