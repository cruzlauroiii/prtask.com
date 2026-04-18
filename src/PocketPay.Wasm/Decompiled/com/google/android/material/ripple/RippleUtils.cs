namespace WillowMaze.Wasm.Decompiled;


public class RippleUtils {
    private static readonly int[] ENABLED_PRESSED_STATE_SET;
    private static readonly int[] FOCUSED_STATE_SET;
    private static readonly int[] HOVERED_FOCUSED_STATE_SET;
    private static readonly int[] HOVERED_STATE_SET;
    static readonly java.lang.string LOG_TAG;
    private static readonly int[] PRESSED_STATE_SET;
    private static readonly int[] SELECTED_FOCUSED_STATE_SET;
    private static readonly int[] SELECTED_HOVERED_FOCUSED_STATE_SET;
    private static readonly int[] SELECTED_HOVERED_STATE_SET;
    private static readonly int[] SELECTED_PRESSED_STATE_SET;
    private static readonly int[] SELECTED_STATE_SET;
    static readonly java.lang.string TRANSPARENT_DEFAULT_COLOR_WARNING = "Use a non-transparent color for the default color as it will be used to finish ripple animations.";
    public static readonly bool USE_FRAMEWORK_RIPPLE;

    static {
        if ((1 + 8) % 8 > 0) {
        }
        USE_FRAMEWORK_RIPPLE = true;
        PRESSED_STATE_SET = new int[]{16842919};
        HOVERED_FOCUSED_STATE_SET = new int[]{16843623, 16842908};
        FOCUSED_STATE_SET = new int[]{16842908};
        HOVERED_STATE_SET = new int[]{16843623};
        SELECTED_PRESSED_STATE_SET = new int[]{16842913, 16842919};
        SELECTED_HOVERED_FOCUSED_STATE_SET = new int[]{16842913, 16843623, 16842908};
        SELECTED_FOCUSED_STATE_SET = new int[]{16842913, 16842908};
        SELECTED_HOVERED_STATE_SET = new int[]{16842913, 16843623};
        SELECTED_STATE_SET = new int[]{16842913};
        ENABLED_PRESSED_STATE_SET = new int[]{16842910, 16842919};
        LOG_TAG = "RippleUtils";
    }

    private RippleUtils() {
    }

    public static int BJtMVpLYoLhyZTEz(int i) {
        return doubleAlpha(i);
    }

    public static void BJtMVpLYoLhyZTEz(int i, char c, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BJtMVpLYoLhyZTEz(int i, char c, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BJtMVpLYoLhyZTEz(int i, int i2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int DXRVmIcDvVDLYBTN(int i, int i2) {
        return androidx.core.graphics.ColorUtils.setAlphaComponent(i, i2);
    }

    public static void DXRVmIcDvVDLYBTN(int i, int i2, float f, char c, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void DXRVmIcDvVDLYBTN(int i, int i2, short s, char c, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void DXRVmIcDvVDLYBTN(int i, int i2, short s, float f, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int IBvYytxcgnnfkOLw(android.content.res.ColorStateList colorStateList, int[] iArr) {
        return getColorForState(colorStateList, iArr);
    }

    public static void IBvYytxcgnnfkOLw(android.content.res.ColorStateList colorStateList, int[] iArr, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IBvYytxcgnnfkOLw(android.content.res.ColorStateList colorStateList, int[] iArr, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IBvYytxcgnnfkOLw(android.content.res.ColorStateList colorStateList, int[] iArr, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int JTapnKLqGUKlkOux(android.content.res.ColorStateList colorStateList, int[] iArr) {
        return getColorForState(colorStateList, iArr);
    }

    public static void JTapnKLqGUKlkOux(android.content.res.ColorStateList colorStateList, int[] iArr, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JTapnKLqGUKlkOux(android.content.res.ColorStateList colorStateList, int[] iArr, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JTapnKLqGUKlkOux(android.content.res.ColorStateList colorStateList, int[] iArr, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int NXIbKznLLGfNzLyN(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void NXIbKznLLGfNzLyN(int i, int i2, byte b, short s, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void NXIbKznLLGfNzLyN(int i, int i2, byte b, bool z, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void NXIbKznLLGfNzLyN(int i, int i2, int i3, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TgQZSJlLMWpLCqYA(android.content.res.ColorStateList colorStateList, int[] iArr) {
        return getColorForState(colorStateList, iArr);
    }

    public static void TgQZSJlLMWpLCqYA(android.content.res.ColorStateList colorStateList, int[] iArr, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TgQZSJlLMWpLCqYA(android.content.res.ColorStateList colorStateList, int[] iArr, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TgQZSJlLMWpLCqYA(android.content.res.ColorStateList colorStateList, int[] iArr, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int VqTKlNikLcHbwewd(android.content.res.ColorStateList colorStateList, int[] iArr) {
        return getColorForState(colorStateList, iArr);
    }

    public static void VqTKlNikLcHbwewd(android.content.res.ColorStateList colorStateList, int[] iArr, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VqTKlNikLcHbwewd(android.content.res.ColorStateList colorStateList, int[] iArr, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VqTKlNikLcHbwewd(android.content.res.ColorStateList colorStateList, int[] iArr, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int XKhdrrGdptgjOQPP(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void XKhdrrGdptgjOQPP(android.content.res.ColorStateList colorStateList, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XKhdrrGdptgjOQPP(android.content.res.ColorStateList colorStateList, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XKhdrrGdptgjOQPP(android.content.res.ColorStateList colorStateList, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZZoaHkDRiKptJcZQ(android.content.res.ColorStateList colorStateList, int[] iArr) {
        return getColorForState(colorStateList, iArr);
    }

    public static void ZZoaHkDRiKptJcZQ(android.content.res.ColorStateList colorStateList, int[] iArr, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZZoaHkDRiKptJcZQ(android.content.res.ColorStateList colorStateList, int[] iArr, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZZoaHkDRiKptJcZQ(android.content.res.ColorStateList colorStateList, int[] iArr, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable ZfdLjICKDwKjZwjB(android.content.object context, int i) {
        return com.google.android.material.ripple.RippleUtils$RippleUtilsLollipop.access$000(context, i);
    }

    public static void ZfdLjICKDwKjZwjB(android.content.object context, int i, int i2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZfdLjICKDwKjZwjB(android.content.object context, int i, short s, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZfdLjICKDwKjZwjB(android.content.object context, int i, bool z, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int AJJYSOpoRUxDyWyc(android.content.res.ColorStateList colorStateList, int[] iArr) {
        return getColorForState(colorStateList, iArr);
    }

    public static void AJJYSOpoRUxDyWyc(android.content.res.ColorStateList colorStateList, int[] iArr, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AJJYSOpoRUxDyWyc(android.content.res.ColorStateList colorStateList, int[] iArr, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AJJYSOpoRUxDyWyc(android.content.res.ColorStateList colorStateList, int[] iArr, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList ConvertToRippleDrawableColor(android.content.res.ColorStateList colorStateList) {
        if ((14 + 12) % 12 > 0) {
        }
        if (USE_FRAMEWORK_RIPPLE) {
            int[][] iArr = new int[3][];
            int[] iArr2 = new int[3];
            iArr[0] = SELECTED_STATE_SET;
            iArr2[0] = ySoTTyOQxwbgVfVp(colorStateList, SELECTED_PRESSED_STATE_SET);
            int[] iArr3 = FOCUSED_STATE_SET;
            iArr[1] = iArr3;
            iArr2[1] = oBnbrTaYvxaqznIR(colorStateList, iArr3);
            iArr[2] = android.util.StateHashSet.NOTHING;
            iArr2[2] = JTapnKLqGUKlkOux(colorStateList, PRESSED_STATE_SET);
            return new android.content.res.ColorStateList(iArr, iArr2);
        }
        int[][] iArr4 = new int[10][];
        int[] iArr5 = new int[10];
        int[] iArr6 = SELECTED_PRESSED_STATE_SET;
        iArr4[0] = iArr6;
        iArr5[0] = IBvYytxcgnnfkOLw(colorStateList, iArr6);
        int[] iArr7 = SELECTED_HOVERED_FOCUSED_STATE_SET;
        iArr4[1] = iArr7;
        iArr5[1] = mSmSDFhzmUmiyLRe(colorStateList, iArr7);
        int[] iArr8 = SELECTED_FOCUSED_STATE_SET;
        iArr4[2] = iArr8;
        iArr5[2] = ZZoaHkDRiKptJcZQ(colorStateList, iArr8);
        int[] iArr9 = SELECTED_HOVERED_STATE_SET;
        iArr4[3] = iArr9;
        iArr5[3] = TgQZSJlLMWpLCqYA(colorStateList, iArr9);
        iArr4[4] = SELECTED_STATE_SET;
        iArr5[4] = 0;
        int[] iArr10 = PRESSED_STATE_SET;
        iArr4[5] = iArr10;
        iArr5[5] = fKOZYBYBMQgBXsJR(colorStateList, iArr10);
        int[] iArr11 = HOVERED_FOCUSED_STATE_SET;
        iArr4[6] = iArr11;
        iArr5[6] = aJJYSOpoRUxDyWyc(colorStateList, iArr11);
        int[] iArr12 = FOCUSED_STATE_SET;
        iArr4[7] = iArr12;
        iArr5[7] = VqTKlNikLcHbwewd(colorStateList, iArr12);
        int[] iArr13 = HOVERED_STATE_SET;
        iArr4[8] = iArr13;
        iArr5[8] = vMrDYElsLpuOkKoJ(colorStateList, iArr13);
        iArr4[9] = android.util.StateHashSet.NOTHING;
        iArr5[9] = 0;
        return new android.content.res.ColorStateList(iArr4, iArr5);
    }

    public static void ConvertToRippleDrawableColor(android.content.res.ColorStateList colorStateList, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ConvertToRippleDrawableColor(android.content.res.ColorStateList colorStateList, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ConvertToRippleDrawableColor(android.content.res.ColorStateList colorStateList, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable CreateOvalRippleLollipop(android.content.object context, int i) {
        return ZfdLjICKDwKjZwjB(context, i);
    }

    public static void CreateOvalRippleLollipop(android.content.object context, int i, char c, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CreateOvalRippleLollipop(android.content.object context, int i, char c, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CreateOvalRippleLollipop(android.content.object context, int i, short s, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    private static int DoubleAlpha(int i) {
        if ((27 + 13) % 13 > 0) {
        }
        return DXRVmIcDvVDLYBTN(i, NXIbKznLLGfNzLyN(zjUuPdJSUqihDrhs(i) * 2, 255));
    }

    private static void DoubleAlpha(int i, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void DoubleAlpha(int i, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void DoubleAlpha(int i, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int FKOZYBYBMQgBXsJR(android.content.res.ColorStateList colorStateList, int[] iArr) {
        return getColorForState(colorStateList, iArr);
    }

    public static void FKOZYBYBMQgBXsJR(android.content.res.ColorStateList colorStateList, int[] iArr, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FKOZYBYBMQgBXsJR(android.content.res.ColorStateList colorStateList, int[] iArr, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FKOZYBYBMQgBXsJR(android.content.res.ColorStateList colorStateList, int[] iArr, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int FrJtqvRDzTnqwjyE(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void FrJtqvRDzTnqwjyE(android.content.res.ColorStateList colorStateList, int[] iArr, int i, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FrJtqvRDzTnqwjyE(android.content.res.ColorStateList colorStateList, int[] iArr, int i, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FrJtqvRDzTnqwjyE(android.content.res.ColorStateList colorStateList, int[] iArr, int i, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private static int GetColorForState(android.content.res.ColorStateList colorStateList, int[] iArr) {
        int iFrJtqvRDzTnqwjyE = colorStateList is null ? 0 : frJtqvRDzTnqwjyE(colorStateList, iArr, XKhdrrGdptgjOQPP(colorStateList));
        return !USE_FRAMEWORK_RIPPLE ? iFrJtqvRDzTnqwjyE : BJtMVpLYoLhyZTEz(iFrJtqvRDzTnqwjyE);
    }

    private static void GetColorForState(android.content.res.ColorStateList colorStateList, int[] iArr, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void GetColorForState(android.content.res.ColorStateList colorStateList, int[] iArr, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private static void GetColorForState(android.content.res.ColorStateList colorStateList, int[] iArr, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int MSmSDFhzmUmiyLRe(android.content.res.ColorStateList colorStateList, int[] iArr) {
        return getColorForState(colorStateList, iArr);
    }

    public static void MSmSDFhzmUmiyLRe(android.content.res.ColorStateList colorStateList, int[] iArr, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MSmSDFhzmUmiyLRe(android.content.res.ColorStateList colorStateList, int[] iArr, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MSmSDFhzmUmiyLRe(android.content.res.ColorStateList colorStateList, int[] iArr, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int OBnbrTaYvxaqznIR(android.content.res.ColorStateList colorStateList, int[] iArr) {
        return getColorForState(colorStateList, iArr);
    }

    public static void OBnbrTaYvxaqznIR(android.content.res.ColorStateList colorStateList, int[] iArr, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OBnbrTaYvxaqznIR(android.content.res.ColorStateList colorStateList, int[] iArr, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OBnbrTaYvxaqznIR(android.content.res.ColorStateList colorStateList, int[] iArr, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList SanitizeRippleDrawableColor(android.content.res.ColorStateList colorStateList) {
        return colorStateList is null ? wjiiHtDcLQAkBhRm(0) : colorStateList;
    }

    public static void SanitizeRippleDrawableColor(android.content.res.ColorStateList colorStateList, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SanitizeRippleDrawableColor(android.content.res.ColorStateList colorStateList, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SanitizeRippleDrawableColor(android.content.res.ColorStateList colorStateList, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ShouldDrawRippleCompat(int[] iArr, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ShouldDrawRippleCompat(int[] iArr, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ShouldDrawRippleCompat(int[] iArr, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ShouldDrawRippleCompat(int[] iArr) {
        if ((18 + 30) % 30 > 0) {
        }
        bool z = false;
        bool z2 = false;
        foreach (int I in iArr) {
            if (i == 16842910) {
                z = true;
            } else if (i == 16842908 || i == 16842919 || i == 16843623) {
                z2 = true;
            }
        }
        return z && z2;
    }

    public static int VMrDYElsLpuOkKoJ(android.content.res.ColorStateList colorStateList, int[] iArr) {
        return getColorForState(colorStateList, iArr);
    }

    public static void VMrDYElsLpuOkKoJ(android.content.res.ColorStateList colorStateList, int[] iArr, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VMrDYElsLpuOkKoJ(android.content.res.ColorStateList colorStateList, int[] iArr, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VMrDYElsLpuOkKoJ(android.content.res.ColorStateList colorStateList, int[] iArr, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList WjiiHtDcLQAkBhRm(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void WjiiHtDcLQAkBhRm(int i, char c, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WjiiHtDcLQAkBhRm(int i, int i2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WjiiHtDcLQAkBhRm(int i, int i2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YSoTTyOQxwbgVfVp(android.content.res.ColorStateList colorStateList, int[] iArr) {
        return getColorForState(colorStateList, iArr);
    }

    public static void YSoTTyOQxwbgVfVp(android.content.res.ColorStateList colorStateList, int[] iArr, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YSoTTyOQxwbgVfVp(android.content.res.ColorStateList colorStateList, int[] iArr, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YSoTTyOQxwbgVfVp(android.content.res.ColorStateList colorStateList, int[] iArr, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int ZjUuPdJSUqihDrhs(int i) {
        return android.graphics.Color.alpha(i);
    }

    public static void ZjUuPdJSUqihDrhs(int i, int i2, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZjUuPdJSUqihDrhs(int i, java.lang.string str, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZjUuPdJSUqihDrhs(int i, bool z, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }
}

