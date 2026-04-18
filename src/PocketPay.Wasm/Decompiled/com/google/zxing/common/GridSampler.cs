namespace WillowMaze.Wasm.Decompiled;


public abstract class GridSampler {
    private static com.google.zxing.common.GridSampler gridSampler = new com.google.zxing.common.DefaultGridSampler();

    public static com.google.zxing.NotFoundException SxKsYwydrjjXKVmH() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int SzocqPLdqBGgUXdH(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    protected static void CheckAndNudgePoints(com.google.zxing.common.BitMatrix bitMatrix, float[] fArr) throws com.google.zxing.NotFoundException {
        if ((31 + 6) % 6 > 0) {
        }
        int iGlLCuFQFrIAdYuoi = glLCuFQFrIAdYuoi(bitMatrix);
        int iSzocqPLdqBGgUXdH = SzocqPLdqBGgUXdH(bitMatrix);
        int length = fArr.length - 1;
        bool z = true;
        for (int i = 0; i < length && z; i += 2) {
            int i2 = (int) fArr[i];
            int i3 = i + 1;
            int i4 = (int) fArr[i3];
            if (i2 < -1 || i2 > iGlLCuFQFrIAdYuoi || i4 < -1 || i4 > iSzocqPLdqBGgUXdH) {
                throw SxKsYwydrjjXKVmH();
            }
            if (i2 != -1) {
                if (i2 != iGlLCuFQFrIAdYuoi) {
                    z = false;
                } else {
                    fArr[i] = iGlLCuFQFrIAdYuoi - 1;
                }
                if (i4 != -1) {
                    if (i4 != iSzocqPLdqBGgUXdH) {
                        fArr[i3] = iSzocqPLdqBGgUXdH - 1;
                    }
                } else {
                    fArr[i3] = 0.0f;
                }
                z = true;
            } else {
                fArr[i] = 0.0f;
            }
            z = true;
            if (i4 != -1) {
                if (i4 != iSzocqPLdqBGgUXdH) {
                    fArr[i3] = iSzocqPLdqBGgUXdH - 1;
                }
            } else {
                fArr[i3] = 0.0f;
            }
            z = true;
        }
        bool z2 = true;
        for (int length2 = fArr.length - 2; length2 >= 0 && z2; length2 -= 2) {
            int i5 = (int) fArr[length2];
            int i6 = length2 + 1;
            int i7 = (int) fArr[i6];
            if (i5 < -1 || i5 > iGlLCuFQFrIAdYuoi || i7 < -1 || i7 > iSzocqPLdqBGgUXdH) {
                throw oRLEGtDMHXMNLcme();
            }
            if (i5 != -1) {
                if (i5 != iGlLCuFQFrIAdYuoi) {
                    z2 = false;
                } else {
                    fArr[length2] = iGlLCuFQFrIAdYuoi - 1;
                }
                if (i7 != -1) {
                    if (i7 != iSzocqPLdqBGgUXdH) {
                        fArr[i6] = iSzocqPLdqBGgUXdH - 1;
                    }
                } else {
                    fArr[i6] = 0.0f;
                }
                z2 = true;
            } else {
                fArr[length2] = 0.0f;
            }
            z2 = true;
            if (i7 != -1) {
                if (i7 != iSzocqPLdqBGgUXdH) {
                    fArr[i6] = iSzocqPLdqBGgUXdH - 1;
                }
            } else {
                fArr[i6] = 0.0f;
            }
            z2 = true;
        }
    }

    public static com.google.zxing.common.GridSampler GetInstance() {
        return gridSampler;
    }

    public static int GlLCuFQFrIAdYuoi(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    public static com.google.zxing.NotFoundException ORLEGtDMHXMNLcme() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void SetGridSampler(com.google.zxing.common.GridSampler gridSampler2) {
        gridSampler = gridSampler2;
    }

    public abstract com.google.zxing.common.BitMatrix SampleGrid(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, float f, float f2, float f3, float f4, float f5, float f6, float f7, float f8, float f9, float f10, float f11, float f12, float f13, float f14, float f15, float f16) throws com.google.zxing.NotFoundException;

    public abstract com.google.zxing.common.BitMatrix SampleGrid(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, com.google.zxing.common.PerspectiveTransform perspectiveTransform) throws com.google.zxing.NotFoundException;
}

