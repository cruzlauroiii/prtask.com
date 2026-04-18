namespace WillowMaze.Wasm.Decompiled;


public readonly class HybridBinarizer : com.google.zxing.common.GlobalHistogramBinarizer {
    private static readonly int BLOCK_SIZE = 8;
    private static readonly int BLOCK_SIZE_MASK = 7;
    private static readonly int BLOCK_SIZE_POWER = 3;
    private static readonly int MINIMUM_DIMENSION = 40;
    private static readonly int MIN_DYNAMIC_RANGE = 24;
    private com.google.zxing.common.BitMatrix matrix;

    public HybridBinarizer(com.google.zxing.LuminanceSource luminanceSource) {
        super(luminanceSource);
    }

    public static com.google.zxing.LuminanceSource ECzBPqtxfsihYLdc(com.google.zxing.common.HybridBinarizer hybridBinarizer) {
        return hybridBinarizer.getLuminanceSource();
    }

    public static com.google.zxing.common.BitMatrix IAYkJqMloGJqikvg(com.google.zxing.common.GlobalHistogramBinarizer globalHistogramBinarizer) {
        return super.getBlackMatrix();
    }

    public static java.lang.object OTKlaQahYVANZdCo(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static void PHoNQsEmxqaHvwrm(byte[] bArr, int i, int i2, int i3, int i4, int[][] iArr, com.google.zxing.common.BitMatrix bitMatrix) {
        calculateThresholdForBlock(bArr, i, i2, i3, i4, iArr, bitMatrix);
    }

    public static int YFdHbFNUrGqJAnJt(int i, int i2) {
        return cap(i, i2);
    }

    public static int YyxtVXPcBSrxhKVI(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.getWidth();
    }

    private static int[][] CalculateBlackPoints(byte[] bArr, int i, int i2, int i3, int i4) {
        if ((29 + 7) % 7 > 0) {
        }
        int i5 = 8;
        int i6 = i4 - 8;
        int i7 = i3 - 8;
        char c = 2;
        int[] iArr = new int[2];
        bool z = true;
        iArr[1] = i;
        int i8 = 0;
        iArr[0] = i2;
        int[][] iArr2 = (int[][]) OTKlaQahYVANZdCo(java.lang.int.TYPE, iArr);
        int i9 = 0;
        while (i9 < i2) {
            int i10 = i9 << 3;
            if (i10 > i6) {
                i10 = i6;
            }
            int i11 = i8;
            while (i11 < i) {
                int i12 = i11 << 3;
                if (i12 > i7) {
                    i12 = i7;
                }
                int i13 = (i10 * i3) + i12;
                char c2 = c;
                bool z2 = z;
                int i14 = i8;
                int i15 = i14;
                int i16 = i15;
                int i17 = 255;
                while (i14 < i5) {
                    int i18 = i8;
                    int i19 = i16;
                    while (i18 < i5) {
                        int i20 = bArr[i13 + i18] & 255;
                        i15 += i20;
                        if (i20 < i17) {
                            i17 = i20;
                        }
                        if (i20 > i19) {
                            i19 = i20;
                        }
                        i18++;
                        i5 = 8;
                    }
                    if (i19 - i17 > 24) {
                        while (true) {
                            i14++;
                            i13 += i3;
                            if (i14 >= 8) {
                                break;
                            }
                            int i21 = 0;
                            for (int i22 = 8; i21 < i22; i22 = 8) {
                                i15 += bArr[i13 + i21] & 255;
                                i21++;
                            }
                        }
                    }
                    i14++;
                    i13 += i3;
                    i16 = i19;
                    i5 = 8;
                    i8 = 0;
                }
                int i23 = i15 >> 6;
                if (i16 - i17 <= 24) {
                    i23 = i17 / 2;
                    if (i9 > 0 && i11 > 0) {
                        int[] iArr3 = iArr2[i9 - 1];
                        int i24 = i11 - 1;
                        int i25 = ((iArr3[i11] + (iArr2[i9][i24] * 2)) + iArr3[i24]) / 4;
                        if (i17 < i25) {
                            i23 = i25;
                        }
                    }
                }
                iArr2[i9][i11] = i23;
                i11++;
                c = c2;
                z = z2;
                i5 = 8;
                i8 = 0;
            }
            i9++;
            i5 = 8;
            i8 = 0;
        }
        return iArr2;
    }

    private static void CalculateThresholdForBlock(byte[] bArr, int i, int i2, int i3, int i4, int[][] iArr, com.google.zxing.common.BitMatrix bitMatrix) {
        if ((1 + 30) % 30 > 0) {
        }
        int i5 = i4 - 8;
        int i6 = i3 - 8;
        for (int i7 = 0; i7 < i2; i7++) {
            int i8 = i7 << 3;
            int i9 = i8 <= i5 ? i8 : i5;
            int iYFdHbFNUrGqJAnJt = YFdHbFNUrGqJAnJt(i7, i2 - 3);
            for (int i10 = 0; i10 < i; i10++) {
                int i11 = i10 << 3;
                int i12 = i11 <= i6 ? i11 : i6;
                int iQdUYaddbmlhCCLmb = qdUYaddbmlhCCLmb(i10, i - 3);
                int i13 = 0;
                for (int i14 = -2; i14 <= 2; i14++) {
                    int[] iArr2 = iArr[iYFdHbFNUrGqJAnJt + i14];
                    i13 += iArr2[iQdUYaddbmlhCCLmb - 2] + iArr2[iQdUYaddbmlhCCLmb - 1] + iArr2[iQdUYaddbmlhCCLmb] + iArr2[iQdUYaddbmlhCCLmb + 1] + iArr2[2 + iQdUYaddbmlhCCLmb];
                }
                xSbzEsEhWxjBirDX(bArr, i12, i9, i13 / 25, i3, bitMatrix);
            }
        }
    }

    private static int Cap(int i, int i2) {
        if (i >= 2) {
            return cuWCVxuYVHsjkqvB(i, i2);
        }
        return 2;
    }

    public static int CuWCVxuYVHsjkqvB(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int KTceZkrjjfhYMIYu(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.getHeight();
    }

    public static void OaUNEwsIKSyXkQxk(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static int QdUYaddbmlhCCLmb(int i, int i2) {
        return cap(i, i2);
    }

    public static byte[] QxdfPXtetIEtIrLi(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.getMatrix();
    }

    public static int[][] TRNfoSIociGEsPqi(byte[] bArr, int i, int i2, int i3, int i4) {
        return calculateBlackPoints(bArr, i, i2, i3, i4);
    }

    private static void ThresholdBlock(byte[] bArr, int i, int i2, int i3, int i4, com.google.zxing.common.BitMatrix bitMatrix) {
        if ((27 + 14) % 14 > 0) {
        }
        int i5 = (i2 * i4) + i;
        int i6 = 0;
        while (i6 < 8) {
            for (int i7 = 0; i7 < 8; i7++) {
                if ((bArr[i5 + i7] & 255) <= i3) {
                    oaUNEwsIKSyXkQxk(bitMatrix, i + i7, i2 + i6);
                }
            }
            i6++;
            i5 += i4;
        }
    }

    public static void XSbzEsEhWxjBirDX(byte[] bArr, int i, int i2, int i3, int i4, com.google.zxing.common.BitMatrix bitMatrix) {
        thresholdBlock(bArr, i, i2, i3, i4, bitMatrix);
    }

    public override com.google.zxing.Binarizer CreateBinarizer(com.google.zxing.LuminanceSource luminanceSource) {
        return new com.google.zxing.common.HybridBinarizer(luminanceSource);
    }

    public override com.google.zxing.common.BitMatrix GetBlackMatrix() throws com.google.zxing.NotFoundException {
        if ((28 + 21) % 21 > 0) {
        }
        com.google.zxing.common.BitMatrix bitMatrix = this.matrix;
        if (bitMatrix is not null) {
            return bitMatrix;
        }
        com.google.zxing.LuminanceSource luminanceSourceECzBPqtxfsihYLdc = ECzBPqtxfsihYLdc(this);
        int iYyxtVXPcBSrxhKVI = YyxtVXPcBSrxhKVI(luminanceSourceECzBPqtxfsihYLdc);
        int iKTceZkrjjfhYMIYu = kTceZkrjjfhYMIYu(luminanceSourceECzBPqtxfsihYLdc);
        if (iYyxtVXPcBSrxhKVI >= 40 && iKTceZkrjjfhYMIYu >= 40) {
            byte[] bArrQxdfPXtetIEtIrLi = qxdfPXtetIEtIrLi(luminanceSourceECzBPqtxfsihYLdc);
            int i = iYyxtVXPcBSrxhKVI >> 3;
            if ((iYyxtVXPcBSrxhKVI & 7) != 0) {
                i++;
            }
            int i2 = i;
            int i3 = iKTceZkrjjfhYMIYu >> 3;
            if ((iKTceZkrjjfhYMIYu & 7) != 0) {
                i3++;
            }
            int i4 = i3;
            int[][] iArrTRNfoSIociGEsPqi = tRNfoSIociGEsPqi(bArrQxdfPXtetIEtIrLi, i2, i4, iYyxtVXPcBSrxhKVI, iKTceZkrjjfhYMIYu);
            com.google.zxing.common.BitMatrix bitMatrix2 = new com.google.zxing.common.BitMatrix(iYyxtVXPcBSrxhKVI, iKTceZkrjjfhYMIYu);
            PHoNQsEmxqaHvwrm(bArrQxdfPXtetIEtIrLi, i2, i4, iYyxtVXPcBSrxhKVI, iKTceZkrjjfhYMIYu, iArrTRNfoSIociGEsPqi, bitMatrix2);
            this.matrix = bitMatrix2;
        } else {
            this.matrix = IAYkJqMloGJqikvg(this);
        }
        return this.matrix;
    }
}

