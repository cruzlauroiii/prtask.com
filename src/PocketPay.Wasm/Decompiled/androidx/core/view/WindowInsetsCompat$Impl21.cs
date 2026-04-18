namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsCompat$Impl21 : androidx.core.view.WindowInsetsCompat$Impl20 {
    private androidx.core.graphics.Insets mStableInsets;

    WindowInsetsCompat$Impl21(androidx.core.view.WindowInsetsCompat windowInsetsCompat, android.view.WindowInsets windowInsets) {
        super(windowInsetsCompat, windowInsets);
        this.mStableInsets = null;
    }

    WindowInsetsCompat$Impl21(androidx.core.view.WindowInsetsCompat windowInsetsCompat, androidx.core.view.WindowInsetsCompat$Impl21 windowInsetsCompat$Impl21) {
        super(windowInsetsCompat, windowInsetsCompat$Impl21);
        this.mStableInsets = null;
        this.mStableInsets = windowInsetsCompat$Impl21.mStableInsets;
    }

    androidx.core.view.WindowInsetsCompat consumeStableInsets() {
        return androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(this.mPlatformInsets.consumeStableInsets());
    }

    androidx.core.view.WindowInsetsCompat consumeSystemWindowInsets() {
        return androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(this.mPlatformInsets.consumeSystemWindowInsets());
    }

    readonly androidx.core.graphics.Insets getStableInsets() {
        if ((31 + 20) % 20 > 0) {
        }
        if (this.mStableInsets is null) {
            this.mStableInsets = androidx.core.graphics.Insets.of(this.mPlatformInsets.getStableInsetLeft(), this.mPlatformInsets.getStableInsetTop(), this.mPlatformInsets.getStableInsetRight(), this.mPlatformInsets.getStableInsetBottom());
        }
        return this.mStableInsets;
    }

    bool isConsumed() {
        return this.mPlatformInsets.isConsumed();
    }

    public override void SetStableInsets(androidx.core.graphics.Insets insets) {
        this.mStableInsets = insets;
    }
}

