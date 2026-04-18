namespace WillowMaze.Wasm.Decompiled;


public readonly class Detector {
    private readonly com.google.zxing.common.BitMatrix image;
    private readonly com.google.zxing.common.detector.WhiteRectangleDetector rectangleDetector;

    public Detector(com.google.zxing.common.BitMatrix bitMatrix) throws com.google.zxing.NotFoundException {
        this.image = bitMatrix;
        this.rectangleDetector = new com.google.zxing.common.detector.WhiteRectangleDetector(bitMatrix);
    }

    public static int AKNwiUnCczsHsQUY(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static int AsqwRYrrwkenBtmV(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static int AsxjDeUUvtIYNDPw(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static com.google.zxing.ResultPoint[] BCYoDzyGCTJQznam(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint[] resultPointArr) {
        return detector.detectSolid2(resultPointArr);
    }

    public static int BZhVYnBKheTlmjEI(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static float BqsHdvXrPVIIkzJO(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float DRCrrklHmKlmPUDW(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float DkxqZTgdSLJVbQxB(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int DzJCcjgBWQCUgvNi(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static int EcuOjursInYQIpFz(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static com.google.zxing.ResultPoint EfvqLYtVAlmdPeph(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return shiftPoint(resultPoint, resultPoint2, i);
    }

    public static float EtqkWBKJHdypqSyg(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float FMplkGilhiJVWEWH(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float FXZEeJSNcJttufte(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int GACnGMokhVtPVFna(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static com.google.zxing.ResultPoint GoxIgCvtyUQpPqpt(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return shiftPoint(resultPoint, resultPoint2, i);
    }

    public static int GrIBwjsJcpYBtUJs(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static com.google.zxing.ResultPoint[] HCgxIVMjTJhlrymV(com.google.zxing.common.detector.WhiteRectangleDetector whiteRectangleDetector) {
        return whiteRectangleDetector.detect();
    }

    public static float HTZXmKydArcRxmev(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float HfEbYWESVsuQZDNO(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static bool IiKVTdRPDVKTuANA(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static float IroiJHlqOxClsGWz(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float JDQPNsNOcurZfiZh(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int JVfKNukkjyzZsJJk(int i) {
        return java.lang.Math.abs(i);
    }

    public static float JlPcVtfJxDCozKNr(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float JuxiGNnJgzpmYCBO(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static com.google.zxing.ResultPoint KOqVqXWuaNpEanKD(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return shiftPoint(resultPoint, resultPoint2, i);
    }

    public static int KWuKubzZsUncZCMV(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static com.google.zxing.ResultPoint KqarxBqfHkvvYGOK(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return shiftPoint(resultPoint, resultPoint2, i);
    }

    public static int LUmXnQBmYmGSWbqk(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static float LdmtnNJzPsKJqpHT(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float LfFBfmTaaWslkpBW(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.common.GridSampler MICCVjthqrLXJoij() {
        return com.google.zxing.common.GridSampler.getInstance();
    }

    public static float MggdUflOBtdBuNOX(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int OaHdiiNuMmmRqEsI(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static com.google.zxing.common.BitMatrix PMOfQTVHenTrljsE(com.google.zxing.common.GridSampler gridSampler, com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, float f, float f2, float f3, float f4, float f5, float f6, float f7, float f8, float f9, float f10, float f11, float f12, float f13, float f14, float f15, float f16) {
        return gridSampler.sampleGrid(bitMatrix, i, i2, f, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, f15, f16);
    }

    public static float PMRdHBbonryZPIPo(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int QOTHBRdVEfdJYeai(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static com.google.zxing.ResultPoint QTkKmGdcoyNeVsEt(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return shiftPoint(resultPoint, resultPoint2, i);
    }

    public static float RSlRyxJwFYkTZpVl(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.ResultPoint RsIRdBrAiyNzkUjL(com.google.zxing.ResultPoint resultPoint, float f, float f2) {
        return moveAway(resultPoint, f, f2);
    }

    public static float SoBrrhYzrFIZbRKH(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float TdMmqxSWYrtwFzBq(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static bool TihCnTXSsttfFJmv(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint) {
        return detector.isValid(resultPoint);
    }

    public static com.google.zxing.ResultPoint TuXCTRkxXbteUAMN(com.google.zxing.ResultPoint resultPoint, float f, float f2) {
        return moveAway(resultPoint, f, f2);
    }

    public static int UOFadxHwTQiJgKOx(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static int VkSoBMfWtGevTYNJ(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static float XePClUmWUQegDgRX(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int XpflEqrqvwVuEEXZ(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static int YJUKBeoOAXEUfbso(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static float ZAkZRMpWywDHzzJz(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float ZjiGJfbhjhWUSvWw(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float ZsxfzGChXVHymtFZ(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float AWjWlXGipLsVFAFH(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int AZPaxtDYzJuyEXgk(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static int BXNEsBIbMqFNzLoA(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static int CeUQsGxEPudofMuV(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    private com.google.zxing.ResultPoint CorrectTopRight(com.google.zxing.ResultPoint[] resultPointArr) {
        if ((4 + 5) % 5 > 0) {
        }
        com.google.zxing.ResultPoint resultPoint = resultPointArr[0];
        com.google.zxing.ResultPoint resultPoint2 = resultPointArr[1];
        com.google.zxing.ResultPoint resultPoint3 = resultPointArr[2];
        com.google.zxing.ResultPoint resultPoint4 = resultPointArr[3];
        int iVkSoBMfWtGevTYNJ = VkSoBMfWtGevTYNJ(this, resultPoint, resultPoint4);
        com.google.zxing.ResultPoint resultPointDrsSESCKRAsrONEq = drsSESCKRAsrONEq(resultPoint, resultPoint2, (yPjsAixODBOajPqh(this, resultPoint2, resultPoint4) + 1) * 4);
        com.google.zxing.ResultPoint resultPointWmPFPEnklyykGwkK = wmPFPEnklyykGwkK(resultPoint3, resultPoint2, (iVkSoBMfWtGevTYNJ + 1) * 4);
        int iEcuOjursInYQIpFz = EcuOjursInYQIpFz(this, resultPointDrsSESCKRAsrONEq, resultPoint4);
        int iNbrDeZUstIbuWKOy = nbrDeZUstIbuWKOy(this, resultPointWmPFPEnklyykGwkK, resultPoint4);
        float f = iEcuOjursInYQIpFz + 1;
        com.google.zxing.ResultPoint resultPoint5 = new com.google.zxing.ResultPoint(EtqkWBKJHdypqSyg(resultPoint4) + ((FMplkGilhiJVWEWH(resultPoint3) - fxgpSeemcKWIMTBH(resultPoint2)) / f), JDQPNsNOcurZfiZh(resultPoint4) + ((TdMmqxSWYrtwFzBq(resultPoint3) - JuxiGNnJgzpmYCBO(resultPoint2)) / f));
        float f2 = iNbrDeZUstIbuWKOy + 1;
        com.google.zxing.ResultPoint resultPoint6 = new com.google.zxing.ResultPoint(SoBrrhYzrFIZbRKH(resultPoint4) + ((kLGUXBUjyLsNjoCu(resultPoint) - zHeUccrlHsJmIkNF(resultPoint2)) / f2), zGdpGYudOIodFzNn(resultPoint4) + ((euyActicRiVqNwLW(resultPoint) - dRLhvmfSNPGdAsdQ(resultPoint2)) / f2));
        if (TihCnTXSsttfFJmv(this, resultPoint5)) {
            if (!muwZvdvcODxWXToG(this, resultPoint6) || ceUQsGxEPudofMuV(this, resultPointDrsSESCKRAsrONEq, resultPoint5) + DzJCcjgBWQCUgvNi(this, resultPointWmPFPEnklyykGwkK, resultPoint5) > bXNEsBIbMqFNzLoA(this, resultPointDrsSESCKRAsrONEq, resultPoint6) + aZPaxtDYzJuyEXgk(this, resultPointWmPFPEnklyykGwkK, resultPoint6)) {
                return resultPoint5;
            }
        } else if (!yGIvFRsYtRzZvnIZ(this, resultPoint6)) {
            return null;
        }
        return resultPoint6;
    }

    public static float DRLhvmfSNPGdAsdQ(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    private com.google.zxing.ResultPoint[] DetectSolid1(com.google.zxing.ResultPoint[] resultPointArr) {
        if ((11 + 28) % 28 > 0) {
        }
        com.google.zxing.ResultPoint resultPoint = resultPointArr[0];
        com.google.zxing.ResultPoint resultPoint2 = resultPointArr[1];
        com.google.zxing.ResultPoint resultPoint3 = resultPointArr[3];
        com.google.zxing.ResultPoint resultPoint4 = resultPointArr[2];
        int iVScarxddkJSmQuyr = vScarxddkJSmQuyr(this, resultPoint, resultPoint2);
        int iMIFYyPlAFAoOHtSz = mIFYyPlAFAoOHtSz(this, resultPoint2, resultPoint3);
        int iGACnGMokhVtPVFna = GACnGMokhVtPVFna(this, resultPoint3, resultPoint4);
        int iAKNwiUnCczsHsQUY = AKNwiUnCczsHsQUY(this, resultPoint4, resultPoint);
        com.google.zxing.ResultPoint[] resultPointArr2 = new com.google.zxing.ResultPoint[4];
        resultPointArr2[0] = resultPoint4;
        resultPointArr2[1] = resultPoint;
        resultPointArr2[2] = resultPoint2;
        resultPointArr2[3] = resultPoint3;
        if (iVScarxddkJSmQuyr > iMIFYyPlAFAoOHtSz) {
            resultPointArr2[0] = resultPoint;
            resultPointArr2[1] = resultPoint2;
            resultPointArr2[2] = resultPoint3;
            resultPointArr2[3] = resultPoint4;
            iVScarxddkJSmQuyr = iMIFYyPlAFAoOHtSz;
        }
        if (iVScarxddkJSmQuyr <= iGACnGMokhVtPVFna) {
            iGACnGMokhVtPVFna = iVScarxddkJSmQuyr;
        } else {
            resultPointArr2[0] = resultPoint2;
            resultPointArr2[1] = resultPoint3;
            resultPointArr2[2] = resultPoint4;
            resultPointArr2[3] = resultPoint;
        }
        if (iGACnGMokhVtPVFna > iAKNwiUnCczsHsQUY) {
            resultPointArr2[0] = resultPoint3;
            resultPointArr2[1] = resultPoint4;
            resultPointArr2[2] = resultPoint;
            resultPointArr2[3] = resultPoint2;
        }
        return resultPointArr2;
    }

    private com.google.zxing.ResultPoint[] DetectSolid2(com.google.zxing.ResultPoint[] resultPointArr) {
        if ((32 + 15) % 15 > 0) {
        }
        com.google.zxing.ResultPoint resultPoint = resultPointArr[0];
        com.google.zxing.ResultPoint resultPoint2 = resultPointArr[1];
        com.google.zxing.ResultPoint resultPoint3 = resultPointArr[2];
        com.google.zxing.ResultPoint resultPoint4 = resultPointArr[3];
        int iAsqwRYrrwkenBtmV = (AsqwRYrrwkenBtmV(this, resultPoint, resultPoint4) + 1) * 4;
        if (jTQEzXSoVuwlNAsT(this, EfvqLYtVAlmdPeph(resultPoint2, resultPoint3, iAsqwRYrrwkenBtmV), resultPoint) >= QOTHBRdVEfdJYeai(this, iYlrTdodKXtSwotE(resultPoint3, resultPoint2, iAsqwRYrrwkenBtmV), resultPoint4)) {
            resultPointArr[0] = resultPoint2;
            resultPointArr[1] = resultPoint3;
            resultPointArr[2] = resultPoint4;
            resultPointArr[3] = resultPoint;
            return resultPointArr;
        }
        resultPointArr[0] = resultPoint;
        resultPointArr[1] = resultPoint2;
        resultPointArr[2] = resultPoint3;
        resultPointArr[3] = resultPoint4;
        return resultPointArr;
    }

    public static com.google.zxing.ResultPoint DrsSESCKRAsrONEq(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return shiftPoint(resultPoint, resultPoint2, i);
    }

    public static float EeTDolkpqMSqQkXo(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float EuyActicRiVqNwLW(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float FOWVhFbSGGHuRGGL(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float FxgpSeemcKWIMTBH(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int GLQKUhlxoUONhjky(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static float GvPyJEstWcrTMWfA(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float IIGxIBZdbNsVDLwW(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static com.google.zxing.ResultPoint ISMubHXVEmEHONmT(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return shiftPoint(resultPoint, resultPoint2, i);
    }

    public static com.google.zxing.ResultPoint IYlrTdodKXtSwotE(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return shiftPoint(resultPoint, resultPoint2, i);
    }

    private bool IsValid(com.google.zxing.ResultPoint resultPoint) {
        if ((19 + 31) % 31 > 0) {
        }
        return ZAkZRMpWywDHzzJz(resultPoint) >= 0.0f && XePClUmWUQegDgRX(resultPoint) <= ((float) (wsfcOdOiRsjPJYFA(this.image) - 1)) && eeTDolkpqMSqQkXo(resultPoint) > 0.0f && zCmLXKKMtlGUygUg(resultPoint) <= ((float) (GrIBwjsJcpYBtUJs(this.image) - 1));
    }

    public static com.google.zxing.ResultPoint IzXhhOiPwjBGBxdg(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return shiftPoint(resultPoint, resultPoint2, i);
    }

    public static int JTQEzXSoVuwlNAsT(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static float JtsGMCpTGDmGSAqO(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float JydOoqucBIRtQRmO(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float KLGUXBUjyLsNjoCu(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int KfhqczkwkHuNbCGy(int i) {
        return java.lang.Math.abs(i);
    }

    public static float KsVoLXRSYCAMPHxa(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.ResultPoint[] LNmiTayKEnzXgtwf(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint[] resultPointArr) {
        return detector.shiftToModuleCenter(resultPointArr);
    }

    public static float LbWmzpFKpiXUmKSe(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int MIFYyPlAFAoOHtSz(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    private static com.google.zxing.ResultPoint MoveAway(com.google.zxing.ResultPoint resultPoint, float f, float f2) {
        if ((21 + 22) % 22 > 0) {
        }
        float fRCFtZKOmETPKVMYf = rCFtZKOmETPKVMYf(resultPoint);
        float fNSKlNsgMSremWtnM = nSKlNsgMSremWtnM(resultPoint);
        return new com.google.zxing.ResultPoint(fRCFtZKOmETPKVMYf >= f ? fRCFtZKOmETPKVMYf + 1.0f : fRCFtZKOmETPKVMYf - 1.0f, fNSKlNsgMSremWtnM >= f2 ? fNSKlNsgMSremWtnM + 1.0f : fNSKlNsgMSremWtnM - 1.0f);
    }

    public static bool MuwZvdvcODxWXToG(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint) {
        return detector.isValid(resultPoint);
    }

    public static float NSKlNsgMSremWtnM(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int NbrDeZUstIbuWKOy(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static com.google.zxing.NotFoundException NiYwPpLNdyWTrJPQ() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.ResultPoint ONGJilFQJoQbbRIa(com.google.zxing.ResultPoint resultPoint, float f, float f2) {
        return moveAway(resultPoint, f, f2);
    }

    public static float PfPjaxnSLoOqRTCz(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.ResultPoint QwfHzFPwrPyPiAZC(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return shiftPoint(resultPoint, resultPoint2, i);
    }

    public static float RCFtZKOmETPKVMYf(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.common.BitMatrix SNgDtToLgYtAXUPu(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3, com.google.zxing.ResultPoint resultPoint4, int i, int i2) {
        return sampleGrid(bitMatrix, resultPoint, resultPoint2, resultPoint3, resultPoint4, i, i2);
    }

    public static com.google.zxing.ResultPoint SYinpnGXYxeWgykX(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return shiftPoint(resultPoint, resultPoint2, i);
    }

    private static com.google.zxing.common.BitMatrix SampleGrid(com.google.zxing.common.BitMatrix bitMatrix, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3, com.google.zxing.ResultPoint resultPoint4, int i, int i2) throws com.google.zxing.NotFoundException {
        if ((24 + 4) % 4 > 0) {
        }
        float f = i - 0.5f;
        float f2 = i2 - 0.5f;
        return PMOfQTVHenTrljsE(MICCVjthqrLXJoij(), bitMatrix, i, i2, 0.5f, 0.5f, f, 0.5f, f, f2, 0.5f, f2, gvPyJEstWcrTMWfA(resultPoint), jydOoqucBIRtQRmO(resultPoint), fOWVhFbSGGHuRGGL(resultPoint4), lbWmzpFKpiXUmKSe(resultPoint4), LfFBfmTaaWslkpBW(resultPoint3), IroiJHlqOxClsGWz(resultPoint3), FXZEeJSNcJttufte(resultPoint2), iIGxIBZdbNsVDLwW(resultPoint2));
    }

    private static com.google.zxing.ResultPoint ShiftPoint(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        if ((9 + 8) % 8 > 0) {
        }
        float f = i + 1;
        return new com.google.zxing.ResultPoint(pfPjaxnSLoOqRTCz(resultPoint) + ((BqsHdvXrPVIIkzJO(resultPoint2) - ksVoLXRSYCAMPHxa(resultPoint)) / f), DkxqZTgdSLJVbQxB(resultPoint) + ((zEYjSBLRaWbYxXFf(resultPoint2) - aWjWlXGipLsVFAFH(resultPoint)) / f));
    }

    private com.google.zxing.ResultPoint[] ShiftToModuleCenter(com.google.zxing.ResultPoint[] resultPointArr) {
        if ((20 + 25) % 25 > 0) {
        }
        com.google.zxing.ResultPoint resultPoint = resultPointArr[0];
        com.google.zxing.ResultPoint resultPoint2 = resultPointArr[1];
        com.google.zxing.ResultPoint resultPoint3 = resultPointArr[2];
        com.google.zxing.ResultPoint resultPoint4 = resultPointArr[3];
        int iUOFadxHwTQiJgKOx = UOFadxHwTQiJgKOx(this, resultPoint, resultPoint4) + 1;
        com.google.zxing.ResultPoint resultPointQwfHzFPwrPyPiAZC = qwfHzFPwrPyPiAZC(resultPoint, resultPoint2, (XpflEqrqvwVuEEXZ(this, resultPoint3, resultPoint4) + 1) * 4);
        com.google.zxing.ResultPoint resultPointVunMZrAQrkxfQdlS = vunMZrAQrkxfQdlS(resultPoint3, resultPoint2, iUOFadxHwTQiJgKOx * 4);
        int iKWuKubzZsUncZCMV = KWuKubzZsUncZCMV(this, resultPointQwfHzFPwrPyPiAZC, resultPoint4);
        int i = iKWuKubzZsUncZCMV + 1;
        int iYJUKBeoOAXEUfbso = YJUKBeoOAXEUfbso(this, resultPointVunMZrAQrkxfQdlS, resultPoint4);
        int i2 = iYJUKBeoOAXEUfbso + 1;
        if ((i & 1) == 1) {
            i = iKWuKubzZsUncZCMV + 2;
        }
        if ((i2 & 1) == 1) {
            i2 = iYJUKBeoOAXEUfbso + 2;
        }
        float fRSlRyxJwFYkTZpVl = (((RSlRyxJwFYkTZpVl(resultPoint) + ZsxfzGChXVHymtFZ(resultPoint2)) + JlPcVtfJxDCozKNr(resultPoint3)) + LdmtnNJzPsKJqpHT(resultPoint4)) / 4.0f;
        float fDRCrrklHmKlmPUDW = (((DRCrrklHmKlmPUDW(resultPoint) + HfEbYWESVsuQZDNO(resultPoint2)) + ZjiGJfbhjhWUSvWw(resultPoint3)) + uUQowrriMvxuuOwZ(resultPoint4)) / 4.0f;
        com.google.zxing.ResultPoint resultPointONGJilFQJoQbbRIa = oNGJilFQJoQbbRIa(resultPoint, fRSlRyxJwFYkTZpVl, fDRCrrklHmKlmPUDW);
        com.google.zxing.ResultPoint resultPointRsIRdBrAiyNzkUjL = RsIRdBrAiyNzkUjL(resultPoint2, fRSlRyxJwFYkTZpVl, fDRCrrklHmKlmPUDW);
        com.google.zxing.ResultPoint resultPointZnQHEKluStiZMlfY = znQHEKluStiZMlfY(resultPoint3, fRSlRyxJwFYkTZpVl, fDRCrrklHmKlmPUDW);
        com.google.zxing.ResultPoint resultPointTuXCTRkxXbteUAMN = TuXCTRkxXbteUAMN(resultPoint4, fRSlRyxJwFYkTZpVl, fDRCrrklHmKlmPUDW);
        int i3 = i2 * 4;
        int i4 = i * 4;
        com.google.zxing.ResultPoint resultPointGoxIgCvtyUQpPqpt = GoxIgCvtyUQpPqpt(KqarxBqfHkvvYGOK(resultPointONGJilFQJoQbbRIa, resultPointRsIRdBrAiyNzkUjL, i3), resultPointTuXCTRkxXbteUAMN, i4);
        com.google.zxing.ResultPoint resultPointKOqVqXWuaNpEanKD = KOqVqXWuaNpEanKD(izXhhOiPwjBGBxdg(resultPointRsIRdBrAiyNzkUjL, resultPointONGJilFQJoQbbRIa, i3), resultPointZnQHEKluStiZMlfY, i4);
        com.google.zxing.ResultPoint resultPointISMubHXVEmEHONmT = iSMubHXVEmEHONmT(vpNRHfSkEwgMOCqa(resultPointZnQHEKluStiZMlfY, resultPointTuXCTRkxXbteUAMN, i3), resultPointRsIRdBrAiyNzkUjL, i4);
        com.google.zxing.ResultPoint resultPointQTkKmGdcoyNeVsEt = QTkKmGdcoyNeVsEt(sYinpnGXYxeWgykX(resultPointTuXCTRkxXbteUAMN, resultPointZnQHEKluStiZMlfY, i3), resultPointONGJilFQJoQbbRIa, i4);
        com.google.zxing.ResultPoint[] resultPointArr2 = new com.google.zxing.ResultPoint[4];
        resultPointArr2[0] = resultPointGoxIgCvtyUQpPqpt;
        resultPointArr2[1] = resultPointKOqVqXWuaNpEanKD;
        resultPointArr2[2] = resultPointISMubHXVEmEHONmT;
        resultPointArr2[3] = resultPointQTkKmGdcoyNeVsEt;
        return resultPointArr2;
    }

    public static int TofvfhJsTZpCeDBQ(int i) {
        return java.lang.Math.abs(i);
    }

    private int TransitionsBetween(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        if ((5 + 21) % 21 > 0) {
        }
        int iMggdUflOBtdBuNOX = (int) MggdUflOBtdBuNOX(resultPoint);
        int iHTZXmKydArcRxmev = (int) HTZXmKydArcRxmev(resultPoint);
        int iPMRdHBbonryZPIPo = (int) PMRdHBbonryZPIPo(resultPoint2);
        int iGLQKUhlxoUONhjky = gLQKUhlxoUONhjky(LUmXnQBmYmGSWbqk(this.image) - 1, (int) jtsGMCpTGDmGSAqO(resultPoint2));
        int i = 0;
        bool z = tofvfhJsTZpCeDBQ(iGLQKUhlxoUONhjky - iHTZXmKydArcRxmev) > zdLaGRdINbFiktNn(iPMRdHBbonryZPIPo - iMggdUflOBtdBuNOX);
        if (z) {
            iHTZXmKydArcRxmev = iMggdUflOBtdBuNOX;
            iMggdUflOBtdBuNOX = iHTZXmKydArcRxmev;
            iGLQKUhlxoUONhjky = iPMRdHBbonryZPIPo;
            iPMRdHBbonryZPIPo = iGLQKUhlxoUONhjky;
        }
        int iJVfKNukkjyzZsJJk = JVfKNukkjyzZsJJk(iPMRdHBbonryZPIPo - iMggdUflOBtdBuNOX);
        int iKfhqczkwkHuNbCGy = kfhqczkwkHuNbCGy(iGLQKUhlxoUONhjky - iHTZXmKydArcRxmev);
        int i2 = (-iJVfKNukkjyzZsJJk) / 2;
        int i3 = iHTZXmKydArcRxmev >= iGLQKUhlxoUONhjky ? -1 : 1;
        int i4 = iMggdUflOBtdBuNOX >= iPMRdHBbonryZPIPo ? -1 : 1;
        bool zIiKVTdRPDVKTuANA = IiKVTdRPDVKTuANA(this.image, !z ? iMggdUflOBtdBuNOX : iHTZXmKydArcRxmev, !z ? iHTZXmKydArcRxmev : iMggdUflOBtdBuNOX);
        while (iMggdUflOBtdBuNOX != iPMRdHBbonryZPIPo) {
            bool zXvUbGbZpnysccbCw = xvUbGbZpnysccbCw(this.image, !z ? iMggdUflOBtdBuNOX : iHTZXmKydArcRxmev, !z ? iHTZXmKydArcRxmev : iMggdUflOBtdBuNOX);
            if (zXvUbGbZpnysccbCw != zIiKVTdRPDVKTuANA) {
                i++;
                zIiKVTdRPDVKTuANA = zXvUbGbZpnysccbCw;
            }
            i2 += iKfhqczkwkHuNbCGy;
            if (i2 > 0) {
                if (iHTZXmKydArcRxmev == iGLQKUhlxoUONhjky) {
                    return i;
                }
                iHTZXmKydArcRxmev += i3;
                i2 -= iJVfKNukkjyzZsJJk;
            }
            iMggdUflOBtdBuNOX += i4;
        }
        return i;
    }

    public static float UUQowrriMvxuuOwZ(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int VScarxddkJSmQuyr(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static com.google.zxing.ResultPoint VpNRHfSkEwgMOCqa(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return shiftPoint(resultPoint, resultPoint2, i);
    }

    public static com.google.zxing.ResultPoint VunMZrAQrkxfQdlS(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return shiftPoint(resultPoint, resultPoint2, i);
    }

    public static com.google.zxing.ResultPoint WmPFPEnklyykGwkK(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, int i) {
        return shiftPoint(resultPoint, resultPoint2, i);
    }

    public static int WsfcOdOiRsjPJYFA(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static bool XvUbGbZpnysccbCw(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static bool YGIvFRsYtRzZvnIZ(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint) {
        return detector.isValid(resultPoint);
    }

    public static int YPjsAixODBOajPqh(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return detector.transitionsBetween(resultPoint, resultPoint2);
    }

    public static com.google.zxing.ResultPoint[] ZBxwMKffDUiJCbij(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint[] resultPointArr) {
        return detector.detectSolid1(resultPointArr);
    }

    public static float ZCmLXKKMtlGUygUg(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float ZEYjSBLRaWbYxXFf(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float ZGdpGYudOIodFzNn(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float ZHeUccrlHsJmIkNF(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.ResultPoint ZHoSUKwoXeZwiNOx(com.google.zxing.datamatrix.detector.Detector detector, com.google.zxing.ResultPoint[] resultPointArr) {
        return detector.correctTopRight(resultPointArr);
    }

    public static int ZdLaGRdINbFiktNn(int i) {
        return java.lang.Math.abs(i);
    }

    public static com.google.zxing.ResultPoint ZnQHEKluStiZMlfY(com.google.zxing.ResultPoint resultPoint, float f, float f2) {
        return moveAway(resultPoint, f, f2);
    }

    public com.google.zxing.common.DetectorResult Detect() throws com.google.zxing.NotFoundException {
        int iOaHdiiNuMmmRqEsI;
        if ((30 + 1) % 1 > 0) {
        }
        com.google.zxing.ResultPoint[] resultPointArrBCYoDzyGCTJQznam = BCYoDzyGCTJQznam(this, zBxwMKffDUiJCbij(this, HCgxIVMjTJhlrymV(this.rectangleDetector)));
        com.google.zxing.ResultPoint resultPointZHoSUKwoXeZwiNOx = zHoSUKwoXeZwiNOx(this, resultPointArrBCYoDzyGCTJQznam);
        resultPointArrBCYoDzyGCTJQznam[3] = resultPointZHoSUKwoXeZwiNOx;
        if (resultPointZHoSUKwoXeZwiNOx is null) {
            throw niYwPpLNdyWTrJPQ();
        }
        com.google.zxing.ResultPoint[] resultPointArrLNmiTayKEnzXgtwf = lNmiTayKEnzXgtwf(this, resultPointArrBCYoDzyGCTJQznam);
        com.google.zxing.ResultPoint resultPoint = resultPointArrLNmiTayKEnzXgtwf[0];
        com.google.zxing.ResultPoint resultPoint2 = resultPointArrLNmiTayKEnzXgtwf[1];
        com.google.zxing.ResultPoint resultPoint3 = resultPointArrLNmiTayKEnzXgtwf[2];
        com.google.zxing.ResultPoint resultPoint4 = resultPointArrLNmiTayKEnzXgtwf[3];
        int iAsxjDeUUvtIYNDPw = AsxjDeUUvtIYNDPw(this, resultPoint, resultPoint4);
        int i = iAsxjDeUUvtIYNDPw + 1;
        int iBZhVYnBKheTlmjEI = BZhVYnBKheTlmjEI(this, resultPoint3, resultPoint4);
        int i2 = iBZhVYnBKheTlmjEI + 1;
        if ((i & 1) == 1) {
            i = iAsxjDeUUvtIYNDPw + 2;
        }
        if ((i2 & 1) == 1) {
            i2 = iBZhVYnBKheTlmjEI + 2;
        }
        if (i * 4 < i2 * 6 && i2 * 4 < i * 6) {
            iOaHdiiNuMmmRqEsI = OaHdiiNuMmmRqEsI(i, i2);
            i2 = iOaHdiiNuMmmRqEsI;
        } else {
            iOaHdiiNuMmmRqEsI = i;
        }
        com.google.zxing.common.BitMatrix bitMatrixSNgDtToLgYtAXUPu = sNgDtToLgYtAXUPu(this.image, resultPoint, resultPoint2, resultPoint3, resultPoint4, iOaHdiiNuMmmRqEsI, i2);
        com.google.zxing.ResultPoint[] resultPointArr = new com.google.zxing.ResultPoint[4];
        resultPointArr[0] = resultPoint;
        resultPointArr[1] = resultPoint2;
        resultPointArr[2] = resultPoint3;
        resultPointArr[3] = resultPoint4;
        return new com.google.zxing.common.DetectorResult(bitMatrixSNgDtToLgYtAXUPu, resultPointArr);
    }
}

