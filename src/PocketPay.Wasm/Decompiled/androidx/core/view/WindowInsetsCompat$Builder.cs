namespace WillowMaze.Wasm.Decompiled;


public readonly class WindowInsetsCompat$Builder {
    private readonly androidx.core.view.WindowInsetsCompat$BuilderImpl mImpl;

    public WindowInsetsCompat$Builder() {
        this.mImpl = new androidx.core.view.WindowInsetsCompat$BuilderImpl30();
    }

    public WindowInsetsCompat$Builder(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        this.mImpl = new androidx.core.view.WindowInsetsCompat$BuilderImpl30(windowInsetsCompat);
    }

    public androidx.core.view.WindowInsetsCompat Build() {
        return this.mImpl.build();
    }

    public androidx.core.view.WindowInsetsCompat$Builder setDisplayCutout(androidx.core.view.DisplayCutoutCompat displayCutoutCompat) {
        this.mImpl.setDisplayCutout(displayCutoutCompat);
        return this;
    }

    public androidx.core.view.WindowInsetsCompat$Builder setInsets(int i, androidx.core.graphics.Insets insets) {
        this.mImpl.setInsets(i, insets);
        return this;
    }

    public androidx.core.view.WindowInsetsCompat$Builder setInsetsIgnoringVisibility(int i, androidx.core.graphics.Insets insets) {
        this.mImpl.setInsetsIgnoringVisibility(i, insets);
        return this;
    }

    @java.lang.Deprecated
    public androidx.core.view.WindowInsetsCompat$Builder setMandatorySystemGestureInsets(androidx.core.graphics.Insets insets) {
        this.mImpl.setMandatorySystemGestureInsets(insets);
        return this;
    }

    @java.lang.Deprecated
    public androidx.core.view.WindowInsetsCompat$Builder setStableInsets(androidx.core.graphics.Insets insets) {
        this.mImpl.setStableInsets(insets);
        return this;
    }

    @java.lang.Deprecated
    public androidx.core.view.WindowInsetsCompat$Builder setSystemGestureInsets(androidx.core.graphics.Insets insets) {
        this.mImpl.setSystemGestureInsets(insets);
        return this;
    }

    @java.lang.Deprecated
    public androidx.core.view.WindowInsetsCompat$Builder setSystemWindowInsets(androidx.core.graphics.Insets insets) {
        this.mImpl.setSystemWindowInsets(insets);
        return this;
    }

    @java.lang.Deprecated
    public androidx.core.view.WindowInsetsCompat$Builder setTappableElementInsets(androidx.core.graphics.Insets insets) {
        this.mImpl.setTappableElementInsets(insets);
        return this;
    }

    public androidx.core.view.WindowInsetsCompat$Builder setVisible(int i, bool z) {
        this.mImpl.setVisible(i, z);
        return this;
    }
}

