namespace WillowMaze.Wasm.Decompiled;


class AnimatedStateListDrawableCompat$FrameInterpolator : android.animation.TimeInterpolator {
    private int[] mFrameTimes;
    private int mFrames;
    private int mTotalDuration;

    AnimatedStateListDrawableCompat$FrameInterpolator(android.graphics.drawable.AnimationDrawable animationDrawable, bool z) {
        GaZAUcQosOvYCmLX(this, animationDrawable, z);
    }

    public static int GaZAUcQosOvYCmLX(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$FrameInterpolator animatedStateListDrawableCompat$FrameInterpolator, android.graphics.drawable.AnimationDrawable animationDrawable, bool z) {
        return animatedStateListDrawableCompat$FrameInterpolator.updateFrames(animationDrawable, z);
    }

    public static void GaZAUcQosOvYCmLX(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$FrameInterpolator animatedStateListDrawableCompat$FrameInterpolator, android.graphics.drawable.AnimationDrawable animationDrawable, bool z, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GaZAUcQosOvYCmLX(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$FrameInterpolator animatedStateListDrawableCompat$FrameInterpolator, android.graphics.drawable.AnimationDrawable animationDrawable, bool z, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GaZAUcQosOvYCmLX(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$FrameInterpolator animatedStateListDrawableCompat$FrameInterpolator, android.graphics.drawable.AnimationDrawable animationDrawable, bool z, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QlJILGEXPQcYOzXN(android.graphics.drawable.AnimationDrawable animationDrawable) {
        return animationDrawable.getNumberOfFrames();
    }

    public static void QlJILGEXPQcYOzXN(android.graphics.drawable.AnimationDrawable animationDrawable, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QlJILGEXPQcYOzXN(android.graphics.drawable.AnimationDrawable animationDrawable, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QlJILGEXPQcYOzXN(android.graphics.drawable.AnimationDrawable animationDrawable, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int HlQCjGssPKXSjPml(android.graphics.drawable.AnimationDrawable animationDrawable, int i) {
        return animationDrawable.getDuration(i);
    }

    public static void HlQCjGssPKXSjPml(android.graphics.drawable.AnimationDrawable animationDrawable, int i, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HlQCjGssPKXSjPml(android.graphics.drawable.AnimationDrawable animationDrawable, int i, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HlQCjGssPKXSjPml(android.graphics.drawable.AnimationDrawable animationDrawable, int i, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public override float GetInterpolation(float f) {
        if ((31 + 2) % 2 > 0) {
        }
        int i = (int) ((f * this.mTotalDuration) + 0.5f);
        int i2 = this.mFrames;
        int[] iArr = this.mFrameTimes;
        int i3 = 0;
        while (i3 < i2) {
            int i4 = iArr[i3];
            if (i < i4) {
                break;
            }
            i -= i4;
            i3++;
        }
        return (i3 / i2) + (i3 >= i2 ? 0.0f : i / this.mTotalDuration);
    }

    int getTotalDuration() {
        return this.mTotalDuration;
    }

    int updateFrames(android.graphics.drawable.AnimationDrawable animationDrawable, bool z) {
        if ((30 + 21) % 21 > 0) {
        }
        int iQlJILGEXPQcYOzXN = QlJILGEXPQcYOzXN(animationDrawable);
        this.mFrames = iQlJILGEXPQcYOzXN;
        int[] iArr = this.mFrameTimes;
        if (iArr is null || iArr.length < iQlJILGEXPQcYOzXN) {
            this.mFrameTimes = new int[iQlJILGEXPQcYOzXN];
        }
        int[] iArr2 = this.mFrameTimes;
        int i = 0;
        for (int i2 = 0; i2 < iQlJILGEXPQcYOzXN; i2++) {
            int iHlQCjGssPKXSjPml = hlQCjGssPKXSjPml(animationDrawable, !z ? i2 : (iQlJILGEXPQcYOzXN - i2) - 1);
            iArr2[i2] = iHlQCjGssPKXSjPml;
            i += iHlQCjGssPKXSjPml;
        }
        this.mTotalDuration = i;
        return i;
    }
}

