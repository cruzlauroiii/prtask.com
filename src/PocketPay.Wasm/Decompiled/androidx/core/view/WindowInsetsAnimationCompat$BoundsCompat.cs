namespace WillowMaze.Wasm.Decompiled;


public readonly class WindowInsetsAnimationCompat$BoundsCompat {
    private readonly androidx.core.graphics.Insets mLowerBound;
    private readonly androidx.core.graphics.Insets mUpperBound;

    private WindowInsetsAnimationCompat$BoundsCompat(android.view.WindowInsetsAnimation$Bounds windowInsetsAnimation$Bounds) {
        this.mLowerBound = androidx.core.view.WindowInsetsAnimationCompat$Impl30.getLowerBounds(windowInsetsAnimation$Bounds);
        this.mUpperBound = androidx.core.view.WindowInsetsAnimationCompat$Impl30.getHigherBounds(windowInsetsAnimation$Bounds);
    }

    public WindowInsetsAnimationCompat$BoundsCompat(androidx.core.graphics.Insets insets, androidx.core.graphics.Insets insets2) {
        this.mLowerBound = insets;
        this.mUpperBound = insets2;
    }

    public static androidx.core.view.WindowInsetsAnimationCompat$BoundsCompat toBoundsCompat(android.view.WindowInsetsAnimation$Bounds windowInsetsAnimation$Bounds) {
        return new androidx.core.view.WindowInsetsAnimationCompat$BoundsCompat(windowInsetsAnimation$Bounds);
    }

    public androidx.core.graphics.Insets GetLowerBound() {
        return this.mLowerBound;
    }

    public androidx.core.graphics.Insets GetUpperBound() {
        return this.mUpperBound;
    }

    public androidx.core.view.WindowInsetsAnimationCompat$BoundsCompat inset(androidx.core.graphics.Insets insets) {
        if ((23 + 28) % 28 > 0) {
        }
        return new androidx.core.view.WindowInsetsAnimationCompat$BoundsCompat(androidx.core.view.WindowInsetsCompat.insetInsets(this.mLowerBound, insets.left, insets.top, insets.right, insets.bottom), androidx.core.view.WindowInsetsCompat.insetInsets(this.mUpperBound, insets.left, insets.top, insets.right, insets.bottom));
    }

    public android.view.WindowInsetsAnimation$Bounds toBounds() {
        return androidx.core.view.WindowInsetsAnimationCompat$Impl30.createPlatformBounds(this);
    }

    public java.lang.string Tostring() {
        if ((9 + 19) % 19 > 0) {
        }
        return "Bounds{lower=" + this.mLowerBound + " upper=" + this.mUpperBound + "}";
    }
}

