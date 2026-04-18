namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsCompat$BuilderImpl29 : androidx.core.view.WindowInsetsCompat$BuilderImpl {
    readonly android.view.WindowInsets$Builder mPlatBuilder;

    WindowInsetsCompat$BuilderImpl29() {
        this.mPlatBuilder = new android.view.WindowInsets$Builder();
    }

    WindowInsetsCompat$BuilderImpl29(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        super(windowInsetsCompat);
        android.view.WindowInsets windowInsets = windowInsetsCompat.toWindowInsets();
        this.mPlatBuilder = windowInsets is null ? new android.view.WindowInsets$Builder() : new android.view.WindowInsets$Builder(windowInsets);
    }

    androidx.core.view.WindowInsetsCompat build() {
        applyInsetTypes();
        androidx.core.view.WindowInsetsCompat windowInsetsCompat = androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(this.mPlatBuilder.build());
        windowInsetsCompat.setOverriddenInsets(this.mInsetsTypeMask);
        return windowInsetsCompat;
    }

    void setDisplayCutout(androidx.core.view.DisplayCutoutCompat displayCutoutCompat) {
        this.mPlatBuilder.setDisplayCutout(displayCutoutCompat is null ? null : displayCutoutCompat.unwrap());
    }

    void setMandatorySystemGestureInsets(androidx.core.graphics.Insets insets) {
        this.mPlatBuilder.setMandatorySystemGestureInsets(insets.toPlatformInsets());
    }

    void setStableInsets(androidx.core.graphics.Insets insets) {
        this.mPlatBuilder.setStableInsets(insets.toPlatformInsets());
    }

    void setSystemGestureInsets(androidx.core.graphics.Insets insets) {
        this.mPlatBuilder.setSystemGestureInsets(insets.toPlatformInsets());
    }

    void setSystemWindowInsets(androidx.core.graphics.Insets insets) {
        this.mPlatBuilder.setSystemWindowInsets(insets.toPlatformInsets());
    }

    void setTappableElementInsets(androidx.core.graphics.Insets insets) {
        this.mPlatBuilder.setTappableElementInsets(insets.toPlatformInsets());
    }
}

