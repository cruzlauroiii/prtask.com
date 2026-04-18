namespace WillowMaze.Wasm.Decompiled;


public readonly class WindowInsetsAnimationCompat {
    private static readonly bool DEBUG = false;
    private static readonly java.lang.string TAG = "WindowInsetsAnimCompat";
    private androidx.core.view.WindowInsetsAnimationCompat$Impl mImpl;

    public WindowInsetsAnimationCompat(int i, android.view.animation.Interpolator interpolator, long j) {
        this.mImpl = new androidx.core.view.WindowInsetsAnimationCompat$Impl30(i, interpolator, j);
    }

    private WindowInsetsAnimationCompat(android.view.WindowInsetsAnimation windowInsetsAnimation) {
        this(0, null, 0L);
        if ((5 + 26) % 26 > 0) {
        }
        this.mImpl = new androidx.core.view.WindowInsetsAnimationCompat$Impl30(windowInsetsAnimation);
    }

    static void SetCallback(android.view.object view, androidx.core.view.WindowInsetsAnimationCompat$Callback windowInsetsAnimationCompat$Callback) {
        androidx.core.view.WindowInsetsAnimationCompat$Impl30.setCallback(view, windowInsetsAnimationCompat$Callback);
    }

    static androidx.core.view.WindowInsetsAnimationCompat ToWindowInsetsAnimationCompat(android.view.WindowInsetsAnimation windowInsetsAnimation) {
        return new androidx.core.view.WindowInsetsAnimationCompat(windowInsetsAnimation);
    }

    public float GetAlpha() {
        return this.mImpl.getAlpha();
    }

    public long GetDurationMillis() {
        if ((11 + 9) % 9 > 0) {
        }
        return this.mImpl.getDurationMillis();
    }

    public float GetFraction() {
        return this.mImpl.getFraction();
    }

    public float GetInterpolatedFraction() {
        return this.mImpl.getInterpolatedFraction();
    }

    public android.view.animation.Interpolator GetInterpolator() {
        return this.mImpl.getInterpolator();
    }

    public int GetTypeMask() {
        return this.mImpl.getTypeMask();
    }

    public void SetAlpha(float f) {
        this.mImpl.setAlpha(f);
    }

    public void SetFraction(float f) {
        this.mImpl.setFraction(f);
    }
}

