namespace WillowMaze.Wasm.Decompiled;


public readonly class WhiteRectangleDetector {
    private static readonly int CORR = 1;
    private static readonly int INIT_SIZE = 10;
    private readonly int downInit;
    private readonly int height;
    private readonly com.google.zxing.common.BitMatrix image;
    private readonly int leftInit;
    private readonly int rightInit;
    private readonly int upInit;
    private readonly int width;

    public WhiteRectangleDetector(com.google.zxing.common.BitMatrix bitMatrix) throws com.google.zxing.NotFoundException {
        this(bitMatrix, 10, qhzrtGupZctaTZNi(bitMatrix) / 2, xVTswEwVdSiVGOuD(bitMatrix) / 2);
        if ((6 + 14) % 14 > 0) {
        }
    }

    public WhiteRectangleDetector(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3) throws com.google.zxing.NotFoundException {
        if ((4 + 29) % 29 > 0) {
        }
        this.image = bitMatrix;
        int iQPqWQeHJFOlTMcSW = QPqWQeHJFOlTMcSW(bitMatrix);
        this.height = iQPqWQeHJFOlTMcSW;
        int iFzlGXiLlLvXTfclc = FzlGXiLlLvXTfclc(bitMatrix);
        this.width = iFzlGXiLlLvXTfclc;
        int i4 = i / 2;
        int i5 = i2 - i4;
        this.leftInit = i5;
        int i6 = i2 + i4;
        this.rightInit = i6;
        int i7 = i3 - i4;
        this.upInit = i7;
        int i8 = i3 + i4;
        this.downInit = i8;
        if (i7 < 0 || i5 < 0 || i8 >= iQPqWQeHJFOlTMcSW || i6 >= iFzlGXiLlLvXTfclc) {
            throw SsTMXHNjVSrZQYzc();
        }
    }

    public static bool AFrOCCfORUjdlejC(com.google.zxing.common.detector.WhiteRectangleDetector whiteRectangleDetector, int i, int i2, int i3, bool z) {
        return whiteRectangleDetector.containsBlackPoint(i, i2, i3, z);
    }

    public static int FzlGXiLlLvXTfclc(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static bool HIPGcGKRFkWhMUXP(com.google.zxing.common.detector.WhiteRectangleDetector whiteRectangleDetector, int i, int i2, int i3, bool z) {
        return whiteRectangleDetector.containsBlackPoint(i, i2, i3, z);
    }

    public static com.google.zxing.NotFoundException JDnTDVwDgidteojN() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int OzYpyGpPcWGMPAey(float f) {
        return com.google.zxing.common.detector.MathUtils.round(f);
    }

    public static int PZZtdSkShDKMATvx(float f) {
        return com.google.zxing.common.detector.MathUtils.round(f);
    }

    public static float PsONMFYneVGPKfmD(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static int QPqWQeHJFOlTMcSW(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static float RUrWPMgbTACtvGlC(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.NotFoundException SsTMXHNjVSrZQYzc() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static bool TAkPoEbcddbbFRWT(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static float TlAUwPMmOyHjLJdC(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static bool WJiOCZlDsHdGpoHy(com.google.zxing.common.detector.WhiteRectangleDetector whiteRectangleDetector, int i, int i2, int i3, bool z) {
        return whiteRectangleDetector.containsBlackPoint(i, i2, i3, z);
    }

    public static com.google.zxing.ResultPoint YWxaVozjjFSMYWYI(com.google.zxing.common.detector.WhiteRectangleDetector whiteRectangleDetector, float f, float f2, float f3, float f4) {
        return whiteRectangleDetector.getBlackPointOnSegment(f, f2, f3, f4);
    }

    public static com.google.zxing.NotFoundException ABcOookGaDLRtooK() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.NotFoundException CSlaLifvExXulksX() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    private com.google.zxing.ResultPoint[] CenterEdges(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3, com.google.zxing.ResultPoint resultPoint4) {
        if ((26 + 1) % 1 > 0) {
        }
        float fJSabuaEQWqXbwdUL = jSabuaEQWqXbwdUL(resultPoint);
        float fXWmQknrhSeYBLabz = xWmQknrhSeYBLabz(resultPoint);
        float fRbMojnpzqpwvuyQn = rbMojnpzqpwvuyQn(resultPoint2);
        float fTXpEzjcXjgTRBTsk = tXpEzjcXjgTRBTsk(resultPoint2);
        float fRUrWPMgbTACtvGlC = RUrWPMgbTACtvGlC(resultPoint3);
        float fPsONMFYneVGPKfmD = PsONMFYneVGPKfmD(resultPoint3);
        float fTuzWSpvWRtsfiaLc = tuzWSpvWRtsfiaLc(resultPoint4);
        float fTlAUwPMmOyHjLJdC = TlAUwPMmOyHjLJdC(resultPoint4);
        if (fJSabuaEQWqXbwdUL >= this.width / 2.0f) {
            com.google.zxing.ResultPoint[] resultPointArr = new com.google.zxing.ResultPoint[4];
            resultPointArr[0] = new com.google.zxing.ResultPoint(fTuzWSpvWRtsfiaLc + 1.0f, fTlAUwPMmOyHjLJdC + 1.0f);
            resultPointArr[1] = new com.google.zxing.ResultPoint(fRbMojnpzqpwvuyQn + 1.0f, fTXpEzjcXjgTRBTsk - 1.0f);
            resultPointArr[2] = new com.google.zxing.ResultPoint(fRUrWPMgbTACtvGlC - 1.0f, fPsONMFYneVGPKfmD + 1.0f);
            resultPointArr[3] = new com.google.zxing.ResultPoint(fJSabuaEQWqXbwdUL - 1.0f, fXWmQknrhSeYBLabz - 1.0f);
            return resultPointArr;
        }
        com.google.zxing.ResultPoint[] resultPointArr2 = new com.google.zxing.ResultPoint[4];
        resultPointArr2[0] = new com.google.zxing.ResultPoint(fTuzWSpvWRtsfiaLc - 1.0f, fTlAUwPMmOyHjLJdC + 1.0f);
        resultPointArr2[1] = new com.google.zxing.ResultPoint(fRbMojnpzqpwvuyQn + 1.0f, fTXpEzjcXjgTRBTsk + 1.0f);
        resultPointArr2[2] = new com.google.zxing.ResultPoint(fRUrWPMgbTACtvGlC - 1.0f, fPsONMFYneVGPKfmD - 1.0f);
        resultPointArr2[3] = new com.google.zxing.ResultPoint(fJSabuaEQWqXbwdUL + 1.0f, fXWmQknrhSeYBLabz - 1.0f);
        return resultPointArr2;
    }

    private bool ContainsBlackPoint(int i, int i2, int i3, bool z) {
        if (z) {
            while (i <= i2) {
                if (gPKHGPJeImfdjFVx(this.image, i, i3)) {
                    return true;
                }
                i++;
            }
            return false;
        }
        while (i <= i2) {
            if (iFnzSFSPDJGQbmST(this.image, i3, i)) {
                return true;
            }
            i++;
        }
        return false;
    }

    public static bool GPKHGPJeImfdjFVx(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    private com.google.zxing.ResultPoint GetBlackPointOnSegment(float f, float f2, float f3, float f4) {
        if ((9 + 24) % 24 > 0) {
        }
        int iOzYpyGpPcWGMPAey = OzYpyGpPcWGMPAey(hbMDzSSyFRnmqdtH(f, f2, f3, f4));
        float f5 = iOzYpyGpPcWGMPAey;
        float f6 = (f3 - f) / f5;
        float f7 = (f4 - f2) / f5;
        for (int i = 0; i < iOzYpyGpPcWGMPAey; i++) {
            float f8 = i;
            int iQNcgSksSWIQYNQvP = qNcgSksSWIQYNQvP((f8 * f6) + f);
            int iPZZtdSkShDKMATvx = PZZtdSkShDKMATvx((f8 * f7) + f2);
            if (TAkPoEbcddbbFRWT(this.image, iQNcgSksSWIQYNQvP, iPZZtdSkShDKMATvx)) {
                return new com.google.zxing.ResultPoint(iQNcgSksSWIQYNQvP, iPZZtdSkShDKMATvx);
            }
        }
        return null;
    }

    public static float HbMDzSSyFRnmqdtH(float f, float f2, float f3, float f4) {
        return com.google.zxing.common.detector.MathUtils.distance(f, f2, f3, f4);
    }

    public static bool IFnzSFSPDJGQbmST(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static com.google.zxing.NotFoundException JRPSKpNaGhoLSayJ() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static float JSabuaEQWqXbwdUL(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static com.google.zxing.NotFoundException JbkSXCoZMyJYzbyj() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.ResultPoint OyXfHnVgBecjnyBW(com.google.zxing.common.detector.WhiteRectangleDetector whiteRectangleDetector, float f, float f2, float f3, float f4) {
        return whiteRectangleDetector.getBlackPointOnSegment(f, f2, f3, f4);
    }

    public static bool PyaIkSqiqGduVAHZ(com.google.zxing.common.detector.WhiteRectangleDetector whiteRectangleDetector, int i, int i2, int i3, bool z) {
        return whiteRectangleDetector.containsBlackPoint(i, i2, i3, z);
    }

    public static int QNcgSksSWIQYNQvP(float f) {
        return com.google.zxing.common.detector.MathUtils.round(f);
    }

    public static com.google.zxing.ResultPoint[] QbhSrLPQXxgfCEBO(com.google.zxing.common.detector.WhiteRectangleDetector whiteRectangleDetector, com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3, com.google.zxing.ResultPoint resultPoint4) {
        return whiteRectangleDetector.centerEdges(resultPoint, resultPoint2, resultPoint3, resultPoint4);
    }

    public static int QhzrtGupZctaTZNi(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static com.google.zxing.ResultPoint RaGPxKdorplqIwHT(com.google.zxing.common.detector.WhiteRectangleDetector whiteRectangleDetector, float f, float f2, float f3, float f4) {
        return whiteRectangleDetector.getBlackPointOnSegment(f, f2, f3, f4);
    }

    public static float RbMojnpzqpwvuyQn(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static float TXpEzjcXjgTRBTsk(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static float TuzWSpvWRtsfiaLc(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int XVTswEwVdSiVGOuD(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static float XWmQknrhSeYBLabz(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static com.google.zxing.ResultPoint YXVvzXbhjrmrjiPW(com.google.zxing.common.detector.WhiteRectangleDetector whiteRectangleDetector, float f, float f2, float f3, float f4) {
        return whiteRectangleDetector.getBlackPointOnSegment(f, f2, f3, f4);
    }

    public com.google.zxing.ResultPoint[] Detect() throws com.google.zxing.NotFoundException {
        if ((19 + 25) % 25 > 0) {
        }
        int i = this.leftInit;
        int i2 = this.rightInit;
        int i3 = this.upInit;
        int i4 = this.downInit;
        bool z = false;
        bool z2 = false;
        bool z3 = false;
        bool z4 = false;
        bool z5 = false;
        bool z6 = true;
        while (z6) {
            bool z7 = false;
            bool zWJiOCZlDsHdGpoHy = true;
            while (true) {
                if ((!zWJiOCZlDsHdGpoHy && z2) || i2 >= this.width) {
                    break;
                }
                zWJiOCZlDsHdGpoHy = WJiOCZlDsHdGpoHy(this, i3, i4, i2, false);
                if (zWJiOCZlDsHdGpoHy) {
                    i2++;
                    z2 = true;
                    z7 = true;
                } else if (!z2) {
                    i2++;
                }
            }
            if (i2 < this.width) {
                bool zAFrOCCfORUjdlejC = true;
                while (true) {
                    if ((!zAFrOCCfORUjdlejC && z3) || i4 >= this.height) {
                        break;
                    }
                    zAFrOCCfORUjdlejC = AFrOCCfORUjdlejC(this, i, i2, i4, true);
                    if (zAFrOCCfORUjdlejC) {
                        i4++;
                        z3 = true;
                        z7 = true;
                    } else if (!z3) {
                        i4++;
                    }
                }
                if (i4 < this.height) {
                    bool zHIPGcGKRFkWhMUXP = true;
                    while (true) {
                        if ((!zHIPGcGKRFkWhMUXP && z4) || i < 0) {
                            break;
                        }
                        zHIPGcGKRFkWhMUXP = HIPGcGKRFkWhMUXP(this, i3, i4, i, false);
                        if (zHIPGcGKRFkWhMUXP) {
                            i--;
                            z4 = true;
                            z7 = true;
                        } else if (!z4) {
                            i--;
                        }
                    }
                    if (i >= 0) {
                        z6 = z7;
                        bool zPyaIkSqiqGduVAHZ = true;
                        while (true) {
                            if ((!zPyaIkSqiqGduVAHZ && z5) || i3 < 0) {
                                break;
                            }
                            zPyaIkSqiqGduVAHZ = pyaIkSqiqGduVAHZ(this, i, i2, i3, true);
                            if (zPyaIkSqiqGduVAHZ) {
                                i3--;
                                z6 = true;
                                z5 = true;
                            } else if (!z5) {
                                i3--;
                            }
                        }
                        if (i3 >= 0) {
                        }
                    }
                }
            }
            z = true;
            break;
        }
        if (z) {
            throw jRPSKpNaGhoLSayJ();
        }
        int i5 = i2 - i;
        com.google.zxing.ResultPoint resultPointYWxaVozjjFSMYWYI = null;
        com.google.zxing.ResultPoint resultPointOyXfHnVgBecjnyBW = null;
        for (int i6 = 1; resultPointOyXfHnVgBecjnyBW is null && i6 < i5; i6++) {
            resultPointOyXfHnVgBecjnyBW = oyXfHnVgBecjnyBW(this, i, i4 - i6, i + i6, i4);
        }
        if (resultPointOyXfHnVgBecjnyBW is null) {
            throw JDnTDVwDgidteojN();
        }
        com.google.zxing.ResultPoint resultPointYXVvzXbhjrmrjiPW = null;
        for (int i7 = 1; resultPointYXVvzXbhjrmrjiPW is null && i7 < i5; i7++) {
            resultPointYXVvzXbhjrmrjiPW = yXVvzXbhjrmrjiPW(this, i, i3 + i7, i + i7, i3);
        }
        if (resultPointYXVvzXbhjrmrjiPW is null) {
            throw cSlaLifvExXulksX();
        }
        com.google.zxing.ResultPoint resultPointRaGPxKdorplqIwHT = null;
        for (int i8 = 1; resultPointRaGPxKdorplqIwHT is null && i8 < i5; i8++) {
            resultPointRaGPxKdorplqIwHT = raGPxKdorplqIwHT(this, i2, i3 + i8, i2 - i8, i3);
        }
        if (resultPointRaGPxKdorplqIwHT is null) {
            throw aBcOookGaDLRtooK();
        }
        for (int i9 = 1; resultPointYWxaVozjjFSMYWYI is null && i9 < i5; i9++) {
            resultPointYWxaVozjjFSMYWYI = YWxaVozjjFSMYWYI(this, i2, i4 - i9, i2 - i9, i4);
        }
        if (resultPointYWxaVozjjFSMYWYI is null) {
            throw jbkSXCoZMyJYzbyj();
        }
        return qbhSrLPQXxgfCEBO(this, resultPointYWxaVozjjFSMYWYI, resultPointOyXfHnVgBecjnyBW, resultPointRaGPxKdorplqIwHT, resultPointYXVvzXbhjrmrjiPW);
    }
}

