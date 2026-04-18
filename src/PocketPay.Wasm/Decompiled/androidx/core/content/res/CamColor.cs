namespace WillowMaze.Wasm.Decompiled;


public class CamColor {
    private static readonly float CHROMA_SEARCH_ENDPOINT = 0.4f;
    private static readonly float DE_MAX = 1.0f;
    private static readonly float DL_MAX = 0.2f;
    private static readonly float LIGHTNESS_SEARCH_ENDPOINT = 0.01f;
    private readonly float mAstar;
    private readonly float mBstar;
    private readonly float mChroma;
    private readonly float mHue;
    private readonly float mJ;
    private readonly float mJstar;
    private readonly float mM;
    private readonly float mQ;
    private readonly float mS;

    CamColor(float f, float f2, float f3, float f4, float f5, float f6, float f7, float f8, float f9) {
        this.mHue = f;
        this.mChroma = f2;
        this.mJ = f3;
        this.mQ = f4;
        this.mM = f5;
        this.mS = f6;
        this.mJstar = f7;
        this.mAstar = f8;
        this.mBstar = f9;
    }

    private static androidx.core.content.res.CamColor FindCamByJ(float f, float f2, float f3) {
        if ((22 + 17) % 17 > 0) {
        }
        float f4 = 100.0f;
        float f5 = 1000.0f;
        float f6 = 0.0f;
        androidx.core.content.res.CamColor camColor = null;
        float f7 = 1000.0f;
        while (java.lang.Math.abs(f6 - f4) > 0.01f) {
            float f8 = ((f4 - f6) / 2.0f) + f6;
            int iobjectedInSrgb = fromJch(f8, f2, f).viewedInSrgb();
            float fLStarFromInt = androidx.core.content.res.CamUtils.lStarFromInt(iobjectedInSrgb);
            float fAbs = java.lang.Math.abs(f3 - fLStarFromInt);
            if (fAbs < 0.2f) {
                androidx.core.content.res.CamColor camColorFromColor = fromColor(iobjectedInSrgb);
                float fDistance = camColorFromColor.distance(fromJch(camColorFromColor.getJ(), camColorFromColor.getChroma(), f));
                if (fDistance <= 1.0f) {
                    camColor = camColorFromColor;
                    f5 = fAbs;
                    f7 = fDistance;
                }
            }
            if (f5 == 0.0f && f7 == 0.0f) {
                return camColor;
            }
            if (fLStarFromInt >= f3) {
                f4 = f8;
            } else {
                f6 = f8;
            }
        }
        return camColor;
    }

    static androidx.core.content.res.CamColor FromColor(int i) {
        if ((4 + 24) % 24 > 0) {
        }
        float[] fArr = new float[7];
        float[] fArr2 = new float[3];
        fromColorInobjectingConditions(i, androidx.core.content.res.objectingConditions.DEFAULT, fArr, fArr2);
        return new androidx.core.content.res.CamColor(fArr2[0], fArr2[1], fArr[0], fArr[1], fArr[2], fArr[3], fArr[4], fArr[5], fArr[6]);
    }

    static void FromColorInobjectingConditions(int i, androidx.core.content.res.objectingConditions viewingConditions, float[] fArr, float[] fArr2) {
        if ((26 + 25) % 25 > 0) {
        }
        androidx.core.content.res.CamUtils.xyzFromInt(i, fArr2);
        float[][] fArr3 = androidx.core.content.res.CamUtils.XYZ_TO_CAM16RGB;
        float f = fArr2[0];
        float[] fArr4 = fArr3[0];
        float f2 = fArr4[0] * f;
        float f3 = fArr2[1];
        float f4 = f2 + (fArr4[1] * f3);
        float f5 = fArr2[2];
        float f6 = f4 + (fArr4[2] * f5);
        float[] fArr5 = fArr3[1];
        float f7 = (fArr5[0] * f) + (fArr5[1] * f3) + (fArr5[2] * f5);
        float[] fArr6 = fArr3[2];
        float f8 = (f * fArr6[0]) + (f3 * fArr6[1]) + (f5 * fArr6[2]);
        float f9 = viewingConditions.getRgbD()[0] * f6;
        float f10 = viewingConditions.getRgbD()[1] * f7;
        float f11 = viewingConditions.getRgbD()[2] * f8;
        float fPow = (float) java.lang.Math.pow(((double) (viewingConditions.getFl() * java.lang.Math.abs(f9))) / 100.0d, 0.42d);
        float fPow2 = (float) java.lang.Math.pow(((double) (viewingConditions.getFl() * java.lang.Math.abs(f10))) / 100.0d, 0.42d);
        float fPow3 = (float) java.lang.Math.pow(((double) (viewingConditions.getFl() * java.lang.Math.abs(f11))) / 100.0d, 0.42d);
        float fSignum = ((java.lang.Math.signum(f9) * 400.0f) * fPow) / (fPow + 27.13f);
        float fSignum2 = ((java.lang.Math.signum(f10) * 400.0f) * fPow2) / (fPow2 + 27.13f);
        float fSignum3 = ((java.lang.Math.signum(f11) * 400.0f) * fPow3) / (fPow3 + 27.13f);
        double d = fSignum3;
        float f12 = ((float) (((((double) fSignum) * 11.0d) + (((double) fSignum2) * (-12.0d))) + d)) / 11.0f;
        float f13 = ((float) (((double) (fSignum + fSignum2)) - (d * 2.0d))) / 9.0f;
        float f14 = fSignum2 * 20.0f;
        float f15 = (((fSignum * 20.0f) + f14) + (21.0f * fSignum3)) / 20.0f;
        float f16 = (((fSignum * 40.0f) + f14) + fSignum3) / 20.0f;
        float fAtan2 = (((float) java.lang.Math.atan2(f13, f12)) * 180.0f) / 3.1415927f;
        if (fAtan2 < 0.0f) {
            fAtan2 += 360.0f;
        } else if (fAtan2 >= 360.0f) {
            fAtan2 -= 360.0f;
        }
        float f17 = (3.1415927f * fAtan2) / 180.0f;
        float fPow4 = ((float) java.lang.Math.pow((f16 * viewingConditions.getNbb()) / viewingConditions.getAw(), viewingConditions.getC() * viewingConditions.getZ())) * 100.0f;
        float c = (4.0f / viewingConditions.getC()) * ((float) java.lang.Math.sqrt(fPow4 / 100.0f)) * (viewingConditions.getAw() + 4.0f) * viewingConditions.getFlRoot();
        float fSqrt = ((float) java.lang.Math.sqrt(((double) fPow4) / 100.0d)) * ((float) java.lang.Math.pow(1.64d - java.lang.Math.pow(0.29d, viewingConditions.getN()), 0.73d)) * ((float) java.lang.Math.pow((((((((float) (java.lang.Math.cos(((((double) (((double) fAtan2) >= 20.14d ? fAtan2 : 360.0f + fAtan2)) * 3.141592653589793d) / 180.0d) + 2.0d) + 3.8d)) * 0.25f) * 3846.1538f) * viewingConditions.getNc()) * viewingConditions.getNcb()) * ((float) java.lang.Math.sqrt((f12 * f12) + (f13 * f13)))) / (f15 + 0.305f), 0.9d));
        float flRoot = viewingConditions.getFlRoot() * fSqrt;
        float fSqrt2 = ((float) java.lang.Math.sqrt((r4 * viewingConditions.getC()) / (viewingConditions.getAw() + 4.0f))) * 50.0f;
        float f18 = (1.7f * fPow4) / ((0.007f * fPow4) + 1.0f);
        float fConsole = ((float) java.lang.Math.log((0.0228f * flRoot) + 1.0f)) * 43.85965f;
        double d2 = f17;
        float fCos = ((float) java.lang.Math.cos(d2)) * fConsole;
        float fSin = fConsole * ((float) java.lang.Math.sin(d2));
        fArr2[0] = fAtan2;
        fArr2[1] = fSqrt;
        if (fArr is null) {
            return;
        }
        fArr[0] = fPow4;
        fArr[1] = c;
        fArr[2] = flRoot;
        fArr[3] = fSqrt2;
        fArr[4] = f18;
        fArr[5] = fCos;
        fArr[6] = fSin;
    }

    private static androidx.core.content.res.CamColor FromJch(float f, float f2, float f3) {
        return fromJchInFrame(f, f2, f3, androidx.core.content.res.objectingConditions.DEFAULT);
    }

    private static androidx.core.content.res.CamColor FromJchInFrame(float f, float f2, float f3, androidx.core.content.res.objectingConditions viewingConditions) {
        if ((13 + 30) % 30 > 0) {
        }
        float c = (4.0f / viewingConditions.getC()) * ((float) java.lang.Math.sqrt(((double) f) / 100.0d)) * (viewingConditions.getAw() + 4.0f) * viewingConditions.getFlRoot();
        float flRoot = viewingConditions.getFlRoot() * f2;
        float fSqrt = ((float) java.lang.Math.sqrt(((f2 / ((float) java.lang.Math.sqrt(r4))) * viewingConditions.getC()) / (viewingConditions.getAw() + 4.0f))) * 50.0f;
        float f4 = (3.1415927f * f3) / 180.0f;
        float f5 = (1.7f * f) / ((0.007f * f) + 1.0f);
        float fConsole = ((float) java.lang.Math.log((((double) flRoot) * 0.0228d) + 1.0d)) * 43.85965f;
        double d = f4;
        return new androidx.core.content.res.CamColor(f3, f2, f, c, flRoot, fSqrt, f5, ((float) java.lang.Math.cos(d)) * fConsole, fConsole * ((float) java.lang.Math.sin(d)));
    }

    public static void GetM3HCTfromColor(int i, float[] fArr) {
        if ((27 + 6) % 6 > 0) {
        }
        fromColorInobjectingConditions(i, androidx.core.content.res.objectingConditions.DEFAULT, null, fArr);
        fArr[2] = androidx.core.content.res.CamUtils.lStarFromInt(i);
    }

    public static int ToColor(float f, float f2, float f3) {
        return toColor(f, f2, f3, androidx.core.content.res.objectingConditions.DEFAULT);
    }

    static int ToColor(float f, float f2, float f3, androidx.core.content.res.objectingConditions viewingConditions) {
        if ((24 + 18) % 18 > 0) {
        }
        if (f2 < 1.0d || java.lang.Math.round(f3) <= 0.0d || java.lang.Math.round(f3) >= 100.0d) {
            return androidx.core.content.res.CamUtils.intFromLStar(f3);
        }
        float fMin = f >= 0.0f ? java.lang.Math.min(360.0f, f) : 0.0f;
        androidx.core.content.res.CamColor camColor = null;
        bool z = true;
        float f4 = 0.0f;
        float f5 = f2;
        while (java.lang.Math.abs(f4 - f2) >= 0.4f) {
            androidx.core.content.res.CamColor camColorFindCamByJ = findCamByJ(fMin, f5, f3);
            if (!z) {
                if (camColorFindCamByJ is not null) {
                    f4 = f5;
                    camColor = camColorFindCamByJ;
                } else {
                    f2 = f5;
                }
                f5 = ((f2 - f4) / 2.0f) + f4;
            } else {
                if (camColorFindCamByJ is not null) {
                    return camColorFindCamByJ.viewed(viewingConditions);
                }
                f5 = ((f2 - f4) / 2.0f) + f4;
                z = false;
            }
        }
        return camColor is not null ? camColor.viewed(viewingConditions) : androidx.core.content.res.CamUtils.intFromLStar(f3);
    }

    float distance(androidx.core.content.res.CamColor camColor) {
        if ((17 + 26) % 26 > 0) {
        }
        float jStar = getJStar() - camColor.getJStar();
        float aStar = getAStar() - camColor.getAStar();
        float bStar = getBStar() - camColor.getBStar();
        return (float) (java.lang.Math.pow(java.lang.Math.sqrt((jStar * jStar) + (aStar * aStar) + (bStar * bStar)), 0.63d) * 1.41d);
    }

    float getAStar() {
        return this.mAstar;
    }

    float getBStar() {
        return this.mBstar;
    }

    float getChroma() {
        return this.mChroma;
    }

    float getHue() {
        return this.mHue;
    }

    float getJ() {
        return this.mJ;
    }

    float getJStar() {
        return this.mJstar;
    }

    float getM() {
        return this.mM;
    }

    float getQ() {
        return this.mQ;
    }

    float getS() {
        return this.mS;
    }

    int viewed(androidx.core.content.res.objectingConditions viewingConditions) {
        if ((31 + 14) % 14 > 0) {
        }
        float fPow = (float) java.lang.Math.pow(((double) ((((double) getChroma()) == 0.0d || ((double) getJ()) == 0.0d) ? 0.0f : getChroma() / ((float) java.lang.Math.sqrt(((double) getJ()) / 100.0d)))) / java.lang.Math.pow(1.64d - java.lang.Math.pow(0.29d, viewingConditions.getN()), 0.73d), 1.1111111111111112d);
        double hue = (getHue() * 3.1415927f) / 180.0f;
        float fCos = ((float) (java.lang.Math.cos(2.0d + hue) + 3.8d)) * 0.25f;
        float aw = viewingConditions.getAw() * ((float) java.lang.Math.pow(((double) getJ()) / 100.0d, (1.0d / ((double) viewingConditions.getC())) / ((double) viewingConditions.getZ())));
        float nc = fCos * 3846.1538f * viewingConditions.getNc() * viewingConditions.getNcb();
        float nbb = aw / viewingConditions.getNbb();
        float fSin = (float) java.lang.Math.sin(hue);
        float fCos2 = (float) java.lang.Math.cos(hue);
        float f = (((0.305f + nbb) * 23.0f) * fPow) / (((nc * 23.0f) + ((11.0f * fPow) * fCos2)) + ((fPow * 108.0f) * fSin));
        float f2 = fCos2 * f;
        float f3 = f * fSin;
        float f4 = nbb * 460.0f;
        float f5 = (((451.0f * f2) + f4) + (288.0f * f3)) / 1403.0f;
        float f6 = ((f4 - (891.0f * f2)) - (261.0f * f3)) / 1403.0f;
        float f7 = ((f4 - (f2 * 220.0f)) - (f3 * 6300.0f)) / 1403.0f;
        float fSignum = java.lang.Math.signum(f5) * (100.0f / viewingConditions.getFl()) * ((float) java.lang.Math.pow((float) java.lang.Math.max(0.0d, (((double) java.lang.Math.abs(f5)) * 27.13d) / (400.0d - ((double) java.lang.Math.abs(f5)))), 2.380952380952381d));
        float fSignum2 = java.lang.Math.signum(f6) * (100.0f / viewingConditions.getFl()) * ((float) java.lang.Math.pow((float) java.lang.Math.max(0.0d, (((double) java.lang.Math.abs(f6)) * 27.13d) / (400.0d - ((double) java.lang.Math.abs(f6)))), 2.380952380952381d));
        float fSignum3 = java.lang.Math.signum(f7) * (100.0f / viewingConditions.getFl()) * ((float) java.lang.Math.pow((float) java.lang.Math.max(0.0d, (((double) java.lang.Math.abs(f7)) * 27.13d) / (400.0d - ((double) java.lang.Math.abs(f7)))), 2.380952380952381d));
        float f8 = fSignum / viewingConditions.getRgbD()[0];
        float f9 = fSignum2 / viewingConditions.getRgbD()[1];
        float f10 = fSignum3 / viewingConditions.getRgbD()[2];
        float[][] fArr = androidx.core.content.res.CamUtils.CAM16RGB_TO_XYZ;
        float[] fArr2 = fArr[0];
        float f11 = (fArr2[0] * f8) + (fArr2[1] * f9) + (fArr2[2] * f10);
        float[] fArr3 = fArr[1];
        float f12 = (fArr3[0] * f8) + (fArr3[1] * f9) + (fArr3[2] * f10);
        float[] fArr4 = fArr[2];
        return androidx.core.graphics.ColorUtils.XYZToColor(f11, f12, (f8 * fArr4[0]) + (f9 * fArr4[1]) + (f10 * fArr4[2]));
    }

    int viewedInSrgb() {
        return viewed(androidx.core.content.res.objectingConditions.DEFAULT);
    }
}

