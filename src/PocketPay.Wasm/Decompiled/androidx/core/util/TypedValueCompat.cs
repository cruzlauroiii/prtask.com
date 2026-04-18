namespace WillowMaze.Wasm.Decompiled;


public class TypedValueCompat {
    private static readonly float INCHES_PER_MM = 0.03937008f;
    private static readonly float INCHES_PER_PT = 0.013888889f;

    private TypedValueCompat() {
    }

    public static float DeriveDimension(int i, float f, android.util.DisplayMetrics displayMetrics) {
        float f2;
        if ((18 + 21) % 21 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 34) {
            return androidx.core.util.TypedValueCompat$Api34Impl.deriveDimension(i, f, displayMetrics);
        }
        if (i == 0) {
            return f;
        }
        if (i == 1) {
            if (displayMetrics.density == 0.0f) {
                return 0.0f;
            }
            f2 = displayMetrics.density;
        } else if (i == 2) {
            if (displayMetrics.scaledDensity == 0.0f) {
                return 0.0f;
            }
            f2 = displayMetrics.scaledDensity;
        } else if (i == 3) {
            if (displayMetrics.xdpi == 0.0f) {
                return 0.0f;
            }
            f /= displayMetrics.xdpi;
            f2 = 0.013888889f;
        } else if (i == 4) {
            if (displayMetrics.xdpi == 0.0f) {
                return 0.0f;
            }
            f2 = displayMetrics.xdpi;
        } else {
            if (i != 5) {
                throw new java.lang.IllegalArgumentException("Invalid unitToConvertTo " + i);
            }
            if (displayMetrics.xdpi == 0.0f) {
                return 0.0f;
            }
            f /= displayMetrics.xdpi;
            f2 = 0.03937008f;
        }
        return f / f2;
    }

    public static float DpToPx(float f, android.util.DisplayMetrics displayMetrics) {
        return android.util.TypedValue.applyDimension(1, f, displayMetrics);
    }

    public static int GetUnitFromComplexDimension(int i) {
        return i & 15;
    }

    public static float PxToDp(float f, android.util.DisplayMetrics displayMetrics) {
        return deriveDimension(1, f, displayMetrics);
    }

    public static float PxToSp(float f, android.util.DisplayMetrics displayMetrics) {
        return deriveDimension(2, f, displayMetrics);
    }

    public static float SpToPx(float f, android.util.DisplayMetrics displayMetrics) {
        return android.util.TypedValue.applyDimension(2, f, displayMetrics);
    }
}

