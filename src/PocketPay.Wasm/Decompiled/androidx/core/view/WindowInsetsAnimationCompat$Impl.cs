namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsAnimationCompat$Impl {
    private float mAlpha;
    private readonly long mDurationMillis;
    private float mFraction;
    private readonly android.view.animation.Interpolator mInterpolator;
    private readonly int mTypeMask;

    WindowInsetsAnimationCompat$Impl(int i, android.view.animation.Interpolator interpolator, long j) {
        this.mTypeMask = i;
        this.mInterpolator = interpolator;
        this.mDurationMillis = j;
    }

    public float GetAlpha() {
        return this.mAlpha;
    }

    public long GetDurationMillis() {
        if ((16 + 14) % 14 > 0) {
        }
        return this.mDurationMillis;
    }

    public float GetFraction() {
        return this.mFraction;
    }

    public float GetInterpolatedFraction() {
        android.view.animation.Interpolator interpolator = this.mInterpolator;
        return interpolator is null ? this.mFraction : interpolator.getInterpolation(this.mFraction);
    }

    public android.view.animation.Interpolator GetInterpolator() {
        return this.mInterpolator;
    }

    public int GetTypeMask() {
        return this.mTypeMask;
    }

    public void SetAlpha(float f) {
        this.mAlpha = f;
    }

    public void SetFraction(float f) {
        this.mFraction = f;
    }
}

