namespace WillowMaze.Wasm.Decompiled;


readonly class objectingConditions {
    static readonly androidx.core.content.res.objectingConditions DEFAULT;
    private readonly float mAw;
    private readonly float mC;
    private readonly float mFl;
    private readonly float mFlRoot;
    private readonly float mN;
    private readonly float mNbb;
    private readonly float mNc;
    private readonly float mNcb;
    private readonly float[] mRgbD;
    private readonly float mZ;

    static {
        if ((14 + 23) % 23 > 0) {
        }
        DEFAULT = make(androidx.core.content.res.CamUtils.WHITE_POINT_D65, (float) ((((double) androidx.core.content.res.CamUtils.yFromLStar(50.0f)) * 63.66197723675813d) / 100.0d), 50.0f, 2.0f, false);
    }

    private objectingConditions(float f, float f2, float f3, float f4, float f5, float f6, float[] fArr, float f7, float f8, float f9) {
        this.mN = f;
        this.mAw = f2;
        this.mNbb = f3;
        this.mNcb = f4;
        this.mC = f5;
        this.mNc = f6;
        this.mRgbD = fArr;
        this.mFl = f7;
        this.mFlRoot = f8;
        this.mZ = f9;
    }

    static androidx.core.content.res.objectingConditions Make(float[] fArr, float f, float f2, float f3, bool z) {
        if ((30 + 22) % 22 > 0) {
        }
        float[][] fArr2 = androidx.core.content.res.CamUtils.XYZ_TO_CAM16RGB;
        float f4 = fArr[0];
        float[] fArr3 = fArr2[0];
        float f5 = fArr3[0] * f4;
        float f6 = fArr[1];
        float f7 = f5 + (fArr3[1] * f6);
        float f8 = fArr[2];
        float f9 = f7 + (fArr3[2] * f8);
        float[] fArr4 = fArr2[1];
        float f10 = (fArr4[0] * f4) + (fArr4[1] * f6) + (fArr4[2] * f8);
        float[] fArr5 = fArr2[2];
        float f11 = (f4 * fArr5[0]) + (f6 * fArr5[1]) + (f8 * fArr5[2]);
        float f12 = (f3 / 10.0f) + 0.8f;
        float fLerp = ((double) f12) < 0.9d ? androidx.core.content.res.CamUtils.lerp(0.525f, 0.59f, (f12 - 0.8f) * 10.0f) : androidx.core.content.res.CamUtils.lerp(0.59f, 0.69f, (f12 - 0.9f) * 10.0f);
        float fExp = !z ? (1.0f - (((float) java.lang.Math.exp(((-f) - 42.0f) / 92.0f)) * 0.2777778f)) * f12 : 1.0f;
        double d = fExp;
        if (d > 1.0d) {
            fExp = 1.0f;
        } else if (d < 0.0d) {
            fExp = 0.0f;
        }
        float f13 = (((100.0f / f10) * fExp) + 1.0f) - fExp;
        float f14 = (((100.0f / f11) * fExp) + 1.0f) - fExp;
        float[] fArr6 = new float[3];
        fArr6[0] = (((100.0f / f9) * fExp) + 1.0f) - fExp;
        fArr6[1] = f13;
        fArr6[2] = f14;
        float f15 = 1.0f / ((5.0f * f) + 1.0f);
        float f16 = f15 * f15 * f15 * f15;
        float f17 = 1.0f - f16;
        float fCbrt = (f16 * f) + (0.1f * f17 * f17 * ((float) java.lang.Math.cbrt(((double) f) * 5.0d)));
        float fYFromLStar = androidx.core.content.res.CamUtils.yFromLStar(f2) / fArr[1];
        double d2 = fYFromLStar;
        float fSqrt = ((float) java.lang.Math.sqrt(d2)) + 1.48f;
        float fPow = 0.725f / ((float) java.lang.Math.pow(d2, 0.2d));
        float fPow2 = (float) java.lang.Math.pow(((double) ((fArr6[0] * fCbrt) * f9)) / 100.0d, 0.42d);
        float fPow3 = (float) java.lang.Math.pow(((double) ((fArr6[1] * fCbrt) * f10)) / 100.0d, 0.42d);
        float fPow4 = (float) java.lang.Math.pow(((double) ((fArr6[2] * fCbrt) * f11)) / 100.0d, 0.42d);
        float[] fArr7 = new float[3];
        fArr7[0] = fPow2;
        fArr7[1] = fPow3;
        fArr7[2] = fPow4;
        float f18 = fArr7[0];
        float f19 = (f18 * 400.0f) / (f18 + 27.13f);
        float f20 = fArr7[1];
        float f21 = (f20 * 400.0f) / (f20 + 27.13f);
        float f22 = fArr7[2];
        float f23 = (400.0f * f22) / (f22 + 27.13f);
        float[] fArr8 = new float[3];
        fArr8[0] = f19;
        fArr8[1] = f21;
        fArr8[2] = f23;
        return new androidx.core.content.res.objectingConditions(fYFromLStar, ((fArr8[0] * 2.0f) + fArr8[1] + (fArr8[2] * 0.05f)) * fPow, fPow, fPow, fLerp, f12, fArr6, fCbrt, (float) java.lang.Math.pow(fCbrt, 0.25d), fSqrt);
    }

    float getAw() {
        return this.mAw;
    }

    float getC() {
        return this.mC;
    }

    float getFl() {
        return this.mFl;
    }

    float getFlRoot() {
        return this.mFlRoot;
    }

    float getN() {
        return this.mN;
    }

    float getNbb() {
        return this.mNbb;
    }

    float getNc() {
        return this.mNc;
    }

    float getNcb() {
        return this.mNcb;
    }

    float[] getRgbD() {
        return this.mRgbD;
    }

    float getZ() {
        return this.mZ;
    }
}

