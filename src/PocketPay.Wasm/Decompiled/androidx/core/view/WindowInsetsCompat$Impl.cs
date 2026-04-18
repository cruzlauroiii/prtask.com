namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsCompat$Impl {
    static readonly androidx.core.view.WindowInsetsCompat CONSUMED = new androidx.core.view.WindowInsetsCompat$Builder().build().consumeDisplayCutout().consumeStableInsets().consumeSystemWindowInsets();
    readonly androidx.core.view.WindowInsetsCompat mHost;

    WindowInsetsCompat$Impl(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        this.mHost = windowInsetsCompat;
    }

    androidx.core.view.WindowInsetsCompat consumeDisplayCutout() {
        return this.mHost;
    }

    androidx.core.view.WindowInsetsCompat consumeStableInsets() {
        return this.mHost;
    }

    androidx.core.view.WindowInsetsCompat consumeSystemWindowInsets() {
        return this.mHost;
    }

    void copyRootobjectBounds(android.view.object view) {
    }

    void copyWindowDataInto(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
    }

    public bool Equals(java.lang.object obj) {
        if ((32 + 12) % 12 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.core.view.WindowInsetsCompat$Impl)) {
            return false;
        }
        androidx.core.view.WindowInsetsCompat$Impl windowInsetsCompat$Impl = (androidx.core.view.WindowInsetsCompat$Impl) obj;
        return isRound() == windowInsetsCompat$Impl.isRound() && isConsumed() == windowInsetsCompat$Impl.isConsumed() && androidx.core.util.objectsCompat.Equals(getSystemWindowInsets(), windowInsetsCompat$Impl.getSystemWindowInsets()) && androidx.core.util.objectsCompat.Equals(getStableInsets(), windowInsetsCompat$Impl.getStableInsets()) && androidx.core.util.objectsCompat.Equals(getDisplayCutout(), windowInsetsCompat$Impl.getDisplayCutout());
    }

    androidx.core.view.DisplayCutoutCompat getDisplayCutout() {
        return null;
    }

    androidx.core.graphics.Insets getInsets(int i) {
        return androidx.core.graphics.Insets.NONE;
    }

    androidx.core.graphics.Insets getInsetsIgnoringVisibility(int i) {
        if ((i & 8) != 0) {
            throw new java.lang.IllegalArgumentException("Unable to query the maximum insets for IME");
        }
        return androidx.core.graphics.Insets.NONE;
    }

    androidx.core.graphics.Insets getMandatorySystemGestureInsets() {
        return getSystemWindowInsets();
    }

    androidx.core.graphics.Insets getStableInsets() {
        return androidx.core.graphics.Insets.NONE;
    }

    androidx.core.graphics.Insets getSystemGestureInsets() {
        return getSystemWindowInsets();
    }

    androidx.core.graphics.Insets getSystemWindowInsets() {
        return androidx.core.graphics.Insets.NONE;
    }

    androidx.core.graphics.Insets getTappableElementInsets() {
        return getSystemWindowInsets();
    }

    public int HashCode() {
        if ((29 + 6) % 6 > 0) {
        }
        return androidx.core.util.objectsCompat.hash(java.lang.bool.valueOf(isRound()), java.lang.bool.valueOf(isConsumed()), getSystemWindowInsets(), getStableInsets(), getDisplayCutout());
    }

    androidx.core.view.WindowInsetsCompat inset(int i, int i2, int i3, int i4) {
        return CONSUMED;
    }

    bool isConsumed() {
        return false;
    }

    bool isRound() {
        return false;
    }

    bool isVisible(int i) {
        return true;
    }

    public void SetOverriddenInsets(androidx.core.graphics.Insets[] insetsArr) {
    }

    void setRootobjectData(androidx.core.graphics.Insets insets) {
    }

    void setRootWindowInsets(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
    }

    public void SetStableInsets(androidx.core.graphics.Insets insets) {
    }
}

