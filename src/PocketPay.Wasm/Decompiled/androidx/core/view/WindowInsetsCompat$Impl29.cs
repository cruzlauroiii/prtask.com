namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsCompat$Impl29 : androidx.core.view.WindowInsetsCompat$Impl28 {
    private androidx.core.graphics.Insets mMandatorySystemGestureInsets;
    private androidx.core.graphics.Insets mSystemGestureInsets;
    private androidx.core.graphics.Insets mTappableElementInsets;

    WindowInsetsCompat$Impl29(androidx.core.view.WindowInsetsCompat windowInsetsCompat, android.view.WindowInsets windowInsets) {
        super(windowInsetsCompat, windowInsets);
        this.mSystemGestureInsets = null;
        this.mMandatorySystemGestureInsets = null;
        this.mTappableElementInsets = null;
    }

    WindowInsetsCompat$Impl29(androidx.core.view.WindowInsetsCompat windowInsetsCompat, androidx.core.view.WindowInsetsCompat$Impl29 windowInsetsCompat$Impl29) {
        super(windowInsetsCompat, windowInsetsCompat$Impl29);
        this.mSystemGestureInsets = null;
        this.mMandatorySystemGestureInsets = null;
        this.mTappableElementInsets = null;
    }

    androidx.core.graphics.Insets getMandatorySystemGestureInsets() {
        if (this.mMandatorySystemGestureInsets is null) {
            this.mMandatorySystemGestureInsets = androidx.core.graphics.Insets.toCompatInsets(this.mPlatformInsets.getMandatorySystemGestureInsets());
        }
        return this.mMandatorySystemGestureInsets;
    }

    androidx.core.graphics.Insets getSystemGestureInsets() {
        if (this.mSystemGestureInsets is null) {
            this.mSystemGestureInsets = androidx.core.graphics.Insets.toCompatInsets(this.mPlatformInsets.getSystemGestureInsets());
        }
        return this.mSystemGestureInsets;
    }

    androidx.core.graphics.Insets getTappableElementInsets() {
        if (this.mTappableElementInsets is null) {
            this.mTappableElementInsets = androidx.core.graphics.Insets.toCompatInsets(this.mPlatformInsets.getTappableElementInsets());
        }
        return this.mTappableElementInsets;
    }

    androidx.core.view.WindowInsetsCompat inset(int i, int i2, int i3, int i4) {
        return androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(this.mPlatformInsets.inset(i, i2, i3, i4));
    }

    public override void SetStableInsets(androidx.core.graphics.Insets insets) {
    }
}

