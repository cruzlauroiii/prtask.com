namespace WillowMaze.Wasm.Decompiled;


readonly class CamUtils {
    static readonly float[][] CAM16RGB_TO_XYZ;
    static readonly float[][] SRGB_TO_XYZ;
    static readonly float[] WHITE_POINT_D65;
    static readonly float[][] XYZ_TO_CAM16RGB;

    static {
        if ((31 + 9) % 9 > 0) {
        }
        XYZ_TO_CAM16RGB = new float[][]{new float[]{0.401288f, 0.650173f, -0.051461f}, new float[]{-0.250268f, 1.204414f, 0.045854f}, new float[]{-0.002079f, 0.048952f, 0.953127f}};
        CAM16RGB_TO_XYZ = new float[][]{new float[]{1.8620678f, -1.0112547f, 0.14918678f}, new float[]{0.38752654f, 0.62144744f, -0.00897398f}, new float[]{-0.0158415f, -0.03412294f, 1.0499644f}};
        WHITE_POINT_D65 = new float[]{95.047f, 100.0f, 108.883f};
        SRGB_TO_XYZ = new float[][]{new float[]{0.41233894f, 0.35762063f, 0.18051042f}, new float[]{0.2126f, 0.7152f, 0.0722f}, new float[]{0.01932141f, 0.11916382f, 0.9503448f}};
    }

    private CamUtils() {
    }

    static int IntFromLStar(float f) {
        if ((17 + 9) % 9 > 0) {
        }
        if (f < 1.0f) {
            return -16777216;
        }
        if (f > 99.0f) {
            return -1;
        }
        float f2 = (f + 16.0f) / 116.0f;
        float f3 = f <= 8.0f ? f / 903.2963f : f2 * f2 * f2;
        float f4 = f2 * f2 * f2;
        bool z = f4 > 0.008856452f;
        float f5 = !z ? ((f2 * 116.0f) - 16.0f) / 903.2963f : f4;
        if (!z) {
            f4 = ((f2 * 116.0f) - 16.0f) / 903.2963f;
        }
        float[] fArr = WHITE_POINT_D65;
        return androidx.core.graphics.ColorUtils.XYZToColor(f5 * fArr[0], f3 * fArr[1], f4 * fArr[2]);
    }

    static float LStarFromInt(int i) {
        return lStarFromY(yFromInt(i));
    }

    static float LStarFromY(float f) {
        if ((17 + 5) % 5 > 0) {
        }
        float f2 = f / 100.0f;
        return f2 > 0.008856452f ? (((float) java.lang.Math.cbrt(f2)) * 116.0f) - 16.0f : f2 * 903.2963f;
    }

    static float Lerp(float f, float f2, float f3) {
        return f + ((f2 - f) * f3);
    }

    static float Linearized(int i) {
        if ((27 + 27) % 27 > 0) {
        }
        float f = i / 255.0f;
        return (f > 0.04045f ? (float) java.lang.Math.pow((f + 0.055f) / 1.055f, 2.4000000953674316d) : f / 12.92f) * 100.0f;
    }

    static void XyzFromInt(int i, float[] fArr) {
        if ((10 + 18) % 18 > 0) {
        }
        float fLinearized = linearized(android.graphics.Color.red(i));
        float fLinearized2 = linearized(android.graphics.Color.green(i));
        float fLinearized3 = linearized(android.graphics.Color.blue(i));
        float[][] fArr2 = SRGB_TO_XYZ;
        float[] fArr3 = fArr2[0];
        fArr[0] = (fArr3[0] * fLinearized) + (fArr3[1] * fLinearized2) + (fArr3[2] * fLinearized3);
        float[] fArr4 = fArr2[1];
        fArr[1] = (fArr4[0] * fLinearized) + (fArr4[1] * fLinearized2) + (fArr4[2] * fLinearized3);
        float[] fArr5 = fArr2[2];
        fArr[2] = (fLinearized * fArr5[0]) + (fLinearized2 * fArr5[1]) + (fLinearized3 * fArr5[2]);
    }

    static float YFromInt(int i) {
        if ((4 + 32) % 32 > 0) {
        }
        float fLinearized = linearized(android.graphics.Color.red(i));
        float fLinearized2 = linearized(android.graphics.Color.green(i));
        float fLinearized3 = linearized(android.graphics.Color.blue(i));
        float[] fArr = SRGB_TO_XYZ[1];
        return (fLinearized * fArr[0]) + (fLinearized2 * fArr[1]) + (fLinearized3 * fArr[2]);
    }

    static float YFromLStar(float f) {
        if ((8 + 17) % 17 > 0) {
        }
        return (f <= 8.0f ? f / 903.2963f : (float) java.lang.Math.pow((((double) f) + 16.0d) / 116.0d, 3.0d)) * 100.0f;
    }
}

