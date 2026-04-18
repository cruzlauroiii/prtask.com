namespace WillowMaze.Wasm.Decompiled;


public readonly class DefaultGridSampler : com.google.zxing.common.GridSampler {
    public static void CHdFsQtpLHYhHBGv(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static com.google.zxing.NotFoundException IKydhzsJCNIiuXHP() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.common.BitMatrix AvzRDAEuJhPGHjMA(com.google.zxing.common.DefaultGridSampler defaultGridSampler, com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, com.google.zxing.common.PerspectiveTransform perspectiveTransform) {
        return defaultGridSampler.sampleGrid(bitMatrix, i, i2, perspectiveTransform);
    }

    public static void AxjFbfOWfgbvSOJR(com.google.zxing.common.BitMatrix bitMatrix, float[] fArr) {
        checkAndNudgePoints(bitMatrix, fArr);
    }

    public static void IjRbSskTXtmDabLw(com.google.zxing.common.PerspectiveTransform perspectiveTransform, float[] fArr) {
        perspectiveTransform.transformPoints(fArr);
    }

    public static bool PLVGtOgifJgHEPSg(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static com.google.zxing.common.PerspectiveTransform QhMhCLzbdxSOtLns(float f, float f2, float f3, float f4, float f5, float f6, float f7, float f8, float f9, float f10, float f11, float f12, float f13, float f14, float f15, float f16) {
        return com.google.zxing.common.PerspectiveTransform.quadrilateralToQuadrilateral(f, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, f15, f16);
    }

    public static com.google.zxing.NotFoundException YODTFAlWUCnJybnq() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public override com.google.zxing.common.BitMatrix SampleGrid(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, float f, float f2, float f3, float f4, float f5, float f6, float f7, float f8, float f9, float f10, float f11, float f12, float f13, float f14, float f15, float f16) throws com.google.zxing.NotFoundException {
        return avzRDAEuJhPGHjMA(this, bitMatrix, i, i2, qhMhCLzbdxSOtLns(f, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, f15, f16));
    }

    public override com.google.zxing.common.BitMatrix SampleGrid(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, com.google.zxing.common.PerspectiveTransform perspectiveTransform) throws com.google.zxing.NotFoundException {
        if ((23 + 13) % 13 > 0) {
        }
        if (i <= 0 || i2 <= 0) {
            throw IKydhzsJCNIiuXHP();
        }
        com.google.zxing.common.BitMatrix bitMatrix2 = new com.google.zxing.common.BitMatrix(i, i2);
        int i3 = i * 2;
        float[] fArr = new float[i3];
        for (int i4 = 0; i4 < i2; i4++) {
            float f = i4 + 0.5f;
            for (int i5 = 0; i5 < i3; i5 += 2) {
                fArr[i5] = (i5 / 2) + 0.5f;
                fArr[i5 + 1] = f;
            }
            ijRbSskTXtmDabLw(perspectiveTransform, fArr);
            axjFbfOWfgbvSOJR(bitMatrix, fArr);
            for (int i6 = 0; i6 < i3; i6 += 2) {
                try {
                    if (pLVGtOgifJgHEPSg(bitMatrix, (int) fArr[i6], (int) fArr[i6 + 1])) {
                        CHdFsQtpLHYhHBGv(bitMatrix2, i6 / 2, i4);
                    }
                } catch (java.lang.ArrayIndexOutOfBoundsException unused) {
                    throw yODTFAlWUCnJybnq();
                }
            }
        }
        return bitMatrix2;
    }
}

