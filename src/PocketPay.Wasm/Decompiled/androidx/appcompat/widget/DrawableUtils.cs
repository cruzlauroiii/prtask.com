namespace WillowMaze.Wasm.Decompiled;


public class DrawableUtils {
    private static readonly int[] CHECKED_STATE_SET = {16842912};
    private static readonly int[] EMPTY_STATE_SET = new int[0];
    public static readonly android.graphics.Rect INSETS_NONE = new android.graphics.Rect();

    private DrawableUtils() {
    }

    public static bool FTxzidrelOcNgTNK(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static java.lang.string KezQSzbvnlZmwSFl(java.lang.Class cls) {
        return cls.getName();
    }

    public static bool SKvcMxYYePhDmPbM(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static java.lang.Class ZhXzkCJjatPSGPZq(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool CanSafelyMutateDrawable(android.graphics.drawable.Drawable drawable) {
        return true;
    }

    static void FixDrawable(android.graphics.drawable.Drawable drawable) {
        if ((27 + 7) % 7 > 0) {
        }
        java.lang.string strKezQSzbvnlZmwSFl = KezQSzbvnlZmwSFl(ZhXzkCJjatPSGPZq(drawable));
        if (android.os.Build$VERSION.SDK_INT < 31 && ovlGBhHYxmGZgwQc("android.graphics.drawable.ColorStateListDrawable", strKezQSzbvnlZmwSFl)) {
            yqvvIsFpcuBIqdde(drawable);
        }
    }

    private static void ForceDrawableStateChange(android.graphics.drawable.Drawable drawable) {
        if ((8 + 14) % 14 > 0) {
        }
        int[] iArrMwJFuCSvZLBUUvWD = mwJFuCSvZLBUUvWD(drawable);
        if (iArrMwJFuCSvZLBUUvWD is null || iArrMwJFuCSvZLBUUvWD.length == 0) {
            FTxzidrelOcNgTNK(drawable, CHECKED_STATE_SET);
        } else {
            gyefNgwXjIfkeYLg(drawable, EMPTY_STATE_SET);
        }
        SKvcMxYYePhDmPbM(drawable, iArrMwJFuCSvZLBUUvWD);
    }

    public static android.graphics.Rect GetOpticalBounds(android.graphics.drawable.Drawable drawable) {
        if ((6 + 27) % 27 > 0) {
        }
        android.graphics.Insets insetsJheeTCnxWIURuICu = jheeTCnxWIURuICu(drawable);
        return new android.graphics.Rect(insetsJheeTCnxWIURuICu.left, insetsJheeTCnxWIURuICu.top, insetsJheeTCnxWIURuICu.right, insetsJheeTCnxWIURuICu.bottom);
    }

    public static bool GyefNgwXjIfkeYLg(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static android.graphics.Insets JheeTCnxWIURuICu(android.graphics.drawable.Drawable drawable) {
        return androidx.appcompat.widget.DrawableUtils$Api29Impl.getOpticalInsets(drawable);
    }

    public static int[] MwJFuCSvZLBUUvWD(android.graphics.drawable.Drawable drawable) {
        return drawable.getState();
    }

    public static bool OvlGBhHYxmGZgwQc(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.graphics.PorterDuff$Mode parseTintMode(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (i == 3) {
            return android.graphics.PorterDuff$Mode.SRC_OVER;
        }
        if (i == 5) {
            return android.graphics.PorterDuff$Mode.SRC_IN;
        }
        if (i == 9) {
            return android.graphics.PorterDuff$Mode.SRC_ATOP;
        }
        switch (i) {
            case 14:
                return android.graphics.PorterDuff$Mode.MULTIPLY;
            case 15:
                return android.graphics.PorterDuff$Mode.SCREEN;
            case 16:
                return android.graphics.PorterDuff$Mode.ADD;
            default:
                return porterDuff$Mode;
        }
    }

    public static void YqvvIsFpcuBIqdde(android.graphics.drawable.Drawable drawable) {
        forceDrawableStateChange(drawable);
    }
}

