namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class MonochromeRectangleDetector {
    private static readonly int MAX_MODULES = 32;
    private readonly com.google.zxing.common.BitMatrix image;

    public MonochromeRectangleDetector(com.google.zxing.common.BitMatrix bitMatrix) {
        this.image = bitMatrix;
    }

    public static com.google.zxing.NotFoundException DfjXAWDnvNKvhAaJ() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static bool EinekNoyvXFktkVY(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static float HSnFSzELUiCmbBDK(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static bool MCyZBRajVRvMcLKj(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static int McGcKoKhUnorwTVk(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static com.google.zxing.ResultPoint RWEIoWLZNFBPHLQy(com.google.zxing.common.detector.MonochromeRectangleDetector monochromeRectangleDetector, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9) {
        return monochromeRectangleDetector.findCornerFromCenter(i, i2, i3, i4, i5, i6, i7, i8, i9);
    }

    public static com.google.zxing.ResultPoint SDPWCEIjwzbYEozX(com.google.zxing.common.detector.MonochromeRectangleDetector monochromeRectangleDetector, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9) {
        return monochromeRectangleDetector.findCornerFromCenter(i, i2, i3, i4, i5, i6, i7, i8, i9);
    }

    public static int TsDCGpPPJPbMzvgH(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static com.google.zxing.NotFoundException XPNUPSOSMKPOUjfS() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static bool YCfgCyvetekACjHw(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static float YPPwBqtltZCFacuu(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getY();
    }

    public static bool AahwHGwrPgDkyUYR(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    private int[] BlackWhiteRange(int i, int i2, int i3, int i4, bool z) {
        int i5;
        com.google.zxing.common.BitMatrix bitMatrix;
        int i6;
        com.google.zxing.common.BitMatrix bitMatrix2;
        if ((3 + 31) % 31 > 0) {
        }
        int i7 = (i3 + i4) / 2;
        int i8 = i7;
        while (i8 >= i3) {
            com.google.zxing.common.BitMatrix bitMatrix3 = this.image;
            if (z) {
                if (aahwHGwrPgDkyUYR(bitMatrix3, i8, i)) {
                    i8--;
                } else {
                    i6 = i8;
                    while (true) {
                        i6--;
                        if (i6 < i3) {
                            bitMatrix2 = this.image;
                            if (z) {
                                if (!rRuhmQpemgnfHulm(bitMatrix2, i, i6)) {
                                    break;
                                    break;
                                }
                            } else if (!YCfgCyvetekACjHw(bitMatrix2, i6, i)) {
                                break;
                                break;
                            }
                        } else {
                            break;
                            break;
                        }
                    }
                    int i9 = i8 - i6;
                    if (i6 >= i3) {
                        break;
                    }
                    i8 = i6;
                }
            } else if (!MCyZBRajVRvMcLKj(bitMatrix3, i, i8)) {
                i6 = i8;
                while (true) {
                    i6--;
                    if (i6 < i3) {
                        bitMatrix2 = this.image;
                        if (z) {
                            if (!YCfgCyvetekACjHw(bitMatrix2, i6, i)) {
                                break;
                            }
                        } else if (!rRuhmQpemgnfHulm(bitMatrix2, i, i6)) {
                            break;
                        }
                    } else {
                        break;
                    }
                }
                int i92 = i8 - i6;
                if (i6 >= i3 || i92 > i2) {
                    break;
                }
                i8 = i6;
            } else {
                i8--;
            }
        }
        int i10 = i8 + 1;
        while (i7 < i4) {
            com.google.zxing.common.BitMatrix bitMatrix4 = this.image;
            if (z) {
                if (mKtZZRUVtieghkjf(bitMatrix4, i7, i)) {
                    i7++;
                } else {
                    i5 = i7;
                    while (true) {
                        i5++;
                        if (i5 >= i4) {
                            bitMatrix = this.image;
                            if (z) {
                                if (!zjyhErVlgOgjEwJO(bitMatrix, i, i5)) {
                                    break;
                                    break;
                                }
                            } else if (!EinekNoyvXFktkVY(bitMatrix, i5, i)) {
                                break;
                                break;
                            }
                        } else {
                            break;
                            break;
                        }
                    }
                    int i11 = i5 - i7;
                    if (i5 < i4) {
                        break;
                    }
                    i7 = i5;
                }
            } else if (!jgFAOCRcEUeMsuNq(bitMatrix4, i, i7)) {
                i5 = i7;
                while (true) {
                    i5++;
                    if (i5 >= i4) {
                        bitMatrix = this.image;
                        if (z) {
                            if (!EinekNoyvXFktkVY(bitMatrix, i5, i)) {
                                break;
                            }
                        } else if (!zjyhErVlgOgjEwJO(bitMatrix, i, i5)) {
                            break;
                        }
                    } else {
                        break;
                    }
                }
                int i112 = i5 - i7;
                if (i5 < i4 || i112 > i2) {
                    break;
                }
                i7 = i5;
            } else {
                i7++;
            }
        }
        int i12 = i7 - 1;
        if (i12 <= i10) {
            return null;
        }
        int[] iArr = new int[2];
        iArr[0] = i10;
        iArr[1] = i12;
        return iArr;
    }

    public static com.google.zxing.ResultPoint EteMCtVbhVhGTlfL(com.google.zxing.common.detector.MonochromeRectangleDetector monochromeRectangleDetector, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9) {
        return monochromeRectangleDetector.findCornerFromCenter(i, i2, i3, i4, i5, i6, i7, i8, i9);
    }

    private com.google.zxing.ResultPoint FindCornerFromCenter(int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9) throws com.google.zxing.NotFoundException {
        if ((23 + 18) % 18 > 0) {
        }
        int[] iArr = null;
        int i10 = i;
        int i11 = i5;
        while (i11 < i8 && i11 >= i7 && i10 < i4 && i10 >= i3) {
            int[] iArrJohLJdBxRebhpZHV = i2 != 0 ? johLJdBxRebhpZHV(this, i10, i9, i7, i8, false) : okXkOYSXUcdhFaKF(this, i11, i9, i3, i4, true);
            if (iArrJohLJdBxRebhpZHV is null) {
                if (iArr is null) {
                    throw XPNUPSOSMKPOUjfS();
                }
                if (i2 != 0) {
                    int i12 = i10 - i2;
                    if (iArr[0] >= i5) {
                        return new com.google.zxing.ResultPoint(i12, iArr[1]);
                    }
                    if (iArr[1] <= i5) {
                        return new com.google.zxing.ResultPoint(i12, iArr[0]);
                    }
                    return new com.google.zxing.ResultPoint(i12, iArr[i2 < 0 ? (char) 0 : (char) 1]);
                }
                int i13 = i11 - i6;
                if (iArr[0] >= i) {
                    return new com.google.zxing.ResultPoint(iArr[1], i13);
                }
                if (iArr[1] <= i) {
                    return new com.google.zxing.ResultPoint(iArr[0], i13);
                }
                return new com.google.zxing.ResultPoint(iArr[i6 > 0 ? (char) 0 : (char) 1], i13);
            }
            i11 += i6;
            i10 += i2;
            iArr = iArrJohLJdBxRebhpZHV;
        }
        throw DfjXAWDnvNKvhAaJ();
    }

    public static float GcKuVIAATEZyJTGn(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static bool JgFAOCRcEUeMsuNq(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static int[] JohLJdBxRebhpZHV(com.google.zxing.common.detector.MonochromeRectangleDetector monochromeRectangleDetector, int i, int i2, int i3, int i4, bool z) {
        return monochromeRectangleDetector.blackWhiteRange(i, i2, i3, i4, z);
    }

    public static int KIpPALshFhlZHPgp(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static bool MKtZZRUVtieghkjf(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static float MRTFCWYLbuObKhBu(com.google.zxing.ResultPoint resultPoint) {
        return resultPoint.getX();
    }

    public static int[] OkXkOYSXUcdhFaKF(com.google.zxing.common.detector.MonochromeRectangleDetector monochromeRectangleDetector, int i, int i2, int i3, int i4, bool z) {
        return monochromeRectangleDetector.blackWhiteRange(i, i2, i3, i4, z);
    }

    public static bool RRuhmQpemgnfHulm(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static int TdnnhCjobaOKGMBd(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static com.google.zxing.ResultPoint WJUmTpwCchNUmcWv(com.google.zxing.common.detector.MonochromeRectangleDetector monochromeRectangleDetector, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9) {
        return monochromeRectangleDetector.findCornerFromCenter(i, i2, i3, i4, i5, i6, i7, i8, i9);
    }

    public static com.google.zxing.ResultPoint XFmwUPvYGPCGQUuK(com.google.zxing.common.detector.MonochromeRectangleDetector monochromeRectangleDetector, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9) {
        return monochromeRectangleDetector.findCornerFromCenter(i, i2, i3, i4, i5, i6, i7, i8, i9);
    }

    public static bool ZjyhErVlgOgjEwJO(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public com.google.zxing.ResultPoint[] Detect() throws com.google.zxing.NotFoundException {
        if ((16 + 14) % 14 > 0) {
        }
        int iKIpPALshFhlZHPgp = kIpPALshFhlZHPgp(this.image);
        int iTsDCGpPPJPbMzvgH = TsDCGpPPJPbMzvgH(this.image);
        int i = iKIpPALshFhlZHPgp / 2;
        int i2 = iTsDCGpPPJPbMzvgH / 2;
        int iMcGcKoKhUnorwTVk = McGcKoKhUnorwTVk(1, iKIpPALshFhlZHPgp / 256);
        int iTdnnhCjobaOKGMBd = tdnnhCjobaOKGMBd(1, iTsDCGpPPJPbMzvgH / 256);
        int i3 = -iMcGcKoKhUnorwTVk;
        int i4 = i2 / 2;
        int iHSnFSzELUiCmbBDK = ((int) HSnFSzELUiCmbBDK(SDPWCEIjwzbYEozX(this, i2, 0, 0, iTsDCGpPPJPbMzvgH, i, i3, 0, iKIpPALshFhlZHPgp, i4))) - 1;
        int i5 = i / 2;
        com.google.zxing.ResultPoint resultPointWJUmTpwCchNUmcWv = wJUmTpwCchNUmcWv(this, i2, -iTdnnhCjobaOKGMBd, 0, iTsDCGpPPJPbMzvgH, i, 0, iHSnFSzELUiCmbBDK, iKIpPALshFhlZHPgp, i5);
        int iGcKuVIAATEZyJTGn = ((int) gcKuVIAATEZyJTGn(resultPointWJUmTpwCchNUmcWv)) - 1;
        com.google.zxing.ResultPoint resultPointXFmwUPvYGPCGQUuK = xFmwUPvYGPCGQUuK(this, i2, iTdnnhCjobaOKGMBd, iGcKuVIAATEZyJTGn, iTsDCGpPPJPbMzvgH, i, 0, iHSnFSzELUiCmbBDK, iKIpPALshFhlZHPgp, i5);
        int iMRTFCWYLbuObKhBu = ((int) mRTFCWYLbuObKhBu(resultPointXFmwUPvYGPCGQUuK)) + 1;
        com.google.zxing.ResultPoint resultPointEteMCtVbhVhGTlfL = eteMCtVbhVhGTlfL(this, i2, 0, iGcKuVIAATEZyJTGn, iMRTFCWYLbuObKhBu, i, iMcGcKoKhUnorwTVk, iHSnFSzELUiCmbBDK, iKIpPALshFhlZHPgp, i4);
        com.google.zxing.ResultPoint resultPointRWEIoWLZNFBPHLQy = RWEIoWLZNFBPHLQy(this, i2, 0, iGcKuVIAATEZyJTGn, iMRTFCWYLbuObKhBu, i, i3, iHSnFSzELUiCmbBDK, ((int) YPPwBqtltZCFacuu(resultPointEteMCtVbhVhGTlfL)) + 1, i2 / 4);
        com.google.zxing.ResultPoint[] resultPointArr = new com.google.zxing.ResultPoint[4];
        resultPointArr[0] = resultPointRWEIoWLZNFBPHLQy;
        resultPointArr[1] = resultPointWJUmTpwCchNUmcWv;
        resultPointArr[2] = resultPointXFmwUPvYGPCGQUuK;
        resultPointArr[3] = resultPointEteMCtVbhVhGTlfL;
        return resultPointArr;
    }
}

