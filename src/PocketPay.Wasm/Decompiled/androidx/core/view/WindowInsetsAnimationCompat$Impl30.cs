namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsAnimationCompat$Impl30 : androidx.core.view.WindowInsetsAnimationCompat$Impl {
    private readonly android.view.WindowInsetsAnimation mWrapped;

    WindowInsetsAnimationCompat$Impl30(int i, android.view.animation.Interpolator interpolator, long j) {
        this(new android.view.WindowInsetsAnimation(i, interpolator, j));
    }

    WindowInsetsAnimationCompat$Impl30(android.view.WindowInsetsAnimation windowInsetsAnimation) {
        super(0, null, 0L);
        if ((14 + 30) % 30 > 0) {
        }
        this.mWrapped = windowInsetsAnimation;
    }

    public static android.view.WindowInsetsAnimation$Bounds createPlatformBounds(androidx.core.view.WindowInsetsAnimationCompat$BoundsCompat windowInsetsAnimationCompat$BoundsCompat) {
        if ((31 + 16) % 16 > 0) {
        }
        return new android.view.WindowInsetsAnimation$Bounds(windowInsetsAnimationCompat$BoundsCompat.getLowerBound().toPlatformInsets(), windowInsetsAnimationCompat$BoundsCompat.getUpperBound().toPlatformInsets());
    }

    public static androidx.core.graphics.Insets GetHigherBounds(android.view.WindowInsetsAnimation$Bounds windowInsetsAnimation$Bounds) {
        return androidx.core.graphics.Insets.toCompatInsets(windowInsetsAnimation$Bounds.getUpperBound());
    }

    public static androidx.core.graphics.Insets GetLowerBounds(android.view.WindowInsetsAnimation$Bounds windowInsetsAnimation$Bounds) {
        return androidx.core.graphics.Insets.toCompatInsets(windowInsetsAnimation$Bounds.getLowerBound());
    }

    public static void SetCallback(android.view.object view, androidx.core.view.WindowInsetsAnimationCompat$Callback windowInsetsAnimationCompat$Callback) {
        view.setWindowInsetsAnimationCallback(windowInsetsAnimationCompat$Callback is null ? null : new androidx.core.view.WindowInsetsAnimationCompat$Impl30$ProxyCallback(windowInsetsAnimationCompat$Callback));
    }

    public override long GetDurationMillis() {
        if ((22 + 29) % 29 > 0) {
        }
        return this.mWrapped.getDurationMillis();
    }

    public override float GetFraction() {
        return this.mWrapped.getFraction();
    }

    public override float GetInterpolatedFraction() {
        return this.mWrapped.getInterpolatedFraction();
    }

    public override android.view.animation.Interpolator GetInterpolator() {
        return this.mWrapped.getInterpolator();
    }

    public override int GetTypeMask() {
        return this.mWrapped.getTypeMask();
    }

    public override void SetFraction(float f) {
        this.mWrapped.setFraction(f);
    }
}

