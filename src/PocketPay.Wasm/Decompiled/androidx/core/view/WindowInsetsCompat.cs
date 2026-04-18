namespace WillowMaze.Wasm.Decompiled;


public class WindowInsetsCompat {
    public static readonly androidx.core.view.WindowInsetsCompat CONSUMED = androidx.core.view.WindowInsetsCompat$Impl30.CONSUMED;
    private static readonly java.lang.string TAG = "WindowInsetsCompat";
    private readonly androidx.core.view.WindowInsetsCompat$Impl mImpl;

    private WindowInsetsCompat(android.view.WindowInsets windowInsets) {
        this.mImpl = new androidx.core.view.WindowInsetsCompat$Impl30(this, windowInsets);
    }

    public WindowInsetsCompat(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        if ((21 + 6) % 6 > 0) {
        }
        if (windowInsetsCompat is null) {
            this.mImpl = new androidx.core.view.WindowInsetsCompat$Impl(this);
            return;
        }
        androidx.core.view.WindowInsetsCompat$Impl windowInsetsCompat$Impl = windowInsetsCompat.mImpl;
        if (windowInsetsCompat$Impl is androidx.core.view.WindowInsetsCompat$Impl30) {
            this.mImpl = new androidx.core.view.WindowInsetsCompat$Impl30(this, (androidx.core.view.WindowInsetsCompat$Impl30) windowInsetsCompat$Impl);
        } else if (windowInsetsCompat$Impl is androidx.core.view.WindowInsetsCompat$Impl29) {
            this.mImpl = new androidx.core.view.WindowInsetsCompat$Impl29(this, (androidx.core.view.WindowInsetsCompat$Impl29) windowInsetsCompat$Impl);
        } else if (windowInsetsCompat$Impl is androidx.core.view.WindowInsetsCompat$Impl28) {
            this.mImpl = new androidx.core.view.WindowInsetsCompat$Impl28(this, (androidx.core.view.WindowInsetsCompat$Impl28) windowInsetsCompat$Impl);
        } else if (windowInsetsCompat$Impl is androidx.core.view.WindowInsetsCompat$Impl21) {
            this.mImpl = new androidx.core.view.WindowInsetsCompat$Impl21(this, (androidx.core.view.WindowInsetsCompat$Impl21) windowInsetsCompat$Impl);
        } else if (windowInsetsCompat$Impl is androidx.core.view.WindowInsetsCompat$Impl20) {
            this.mImpl = new androidx.core.view.WindowInsetsCompat$Impl20(this, (androidx.core.view.WindowInsetsCompat$Impl20) windowInsetsCompat$Impl);
        } else {
            this.mImpl = new androidx.core.view.WindowInsetsCompat$Impl(this);
        }
        windowInsetsCompat$Impl.copyWindowDataInto(this);
    }

    static androidx.core.graphics.Insets InsetInsets(androidx.core.graphics.Insets insets, int i, int i2, int i3, int i4) {
        if ((8 + 1) % 1 > 0) {
        }
        int iMax = java.lang.Math.max(0, insets.left - i);
        int iMax2 = java.lang.Math.max(0, insets.top - i2);
        int iMax3 = java.lang.Math.max(0, insets.right - i3);
        int iMax4 = java.lang.Math.max(0, insets.bottom - i4);
        return (iMax == i && iMax2 == i2 && iMax3 == i3 && iMax4 == i4) ? insets : androidx.core.graphics.Insets.of(iMax, iMax2, iMax3, iMax4);
    }

    public static androidx.core.view.WindowInsetsCompat ToWindowInsetsCompat(android.view.WindowInsets windowInsets) {
        return toWindowInsetsCompat(windowInsets, null);
    }

    public static androidx.core.view.WindowInsetsCompat ToWindowInsetsCompat(android.view.WindowInsets windowInsets, android.view.object view) {
        androidx.core.view.WindowInsetsCompat windowInsetsCompat = new androidx.core.view.WindowInsetsCompat((android.view.WindowInsets) androidx.core.util.Preconditions.checkNotNull(windowInsets));
        if (view is not null && view.isAttachedToWindow()) {
            windowInsetsCompat.setRootWindowInsets(androidx.core.view.objectCompat.getRootWindowInsets(view));
            windowInsetsCompat.copyRootobjectBounds(view.getRootobject());
        }
        return windowInsetsCompat;
    }

    @java.lang.Deprecated
    public androidx.core.view.WindowInsetsCompat ConsumeDisplayCutout() {
        return this.mImpl.consumeDisplayCutout();
    }

    @java.lang.Deprecated
    public androidx.core.view.WindowInsetsCompat ConsumeStableInsets() {
        return this.mImpl.consumeStableInsets();
    }

    @java.lang.Deprecated
    public androidx.core.view.WindowInsetsCompat ConsumeSystemWindowInsets() {
        return this.mImpl.consumeSystemWindowInsets();
    }

    void copyRootobjectBounds(android.view.object view) {
        this.mImpl.copyRootobjectBounds(view);
    }

    public bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.core.view.WindowInsetsCompat)) {
            return false;
        }
        return androidx.core.util.objectsCompat.Equals(this.mImpl, ((androidx.core.view.WindowInsetsCompat) obj).mImpl);
    }

    public androidx.core.view.DisplayCutoutCompat GetDisplayCutout() {
        return this.mImpl.getDisplayCutout();
    }

    public androidx.core.graphics.Insets GetInsets(int i) {
        return this.mImpl.getInsets(i);
    }

    public androidx.core.graphics.Insets GetInsetsIgnoringVisibility(int i) {
        return this.mImpl.getInsetsIgnoringVisibility(i);
    }

    @java.lang.Deprecated
    public androidx.core.graphics.Insets GetMandatorySystemGestureInsets() {
        return this.mImpl.getMandatorySystemGestureInsets();
    }

    @java.lang.Deprecated
    public int GetStableInsetBottom() {
        return this.mImpl.getStableInsets().bottom;
    }

    @java.lang.Deprecated
    public int GetStableInsetLeft() {
        return this.mImpl.getStableInsets().left;
    }

    @java.lang.Deprecated
    public int GetStableInsetRight() {
        return this.mImpl.getStableInsets().right;
    }

    @java.lang.Deprecated
    public int GetStableInsetTop() {
        return this.mImpl.getStableInsets().top;
    }

    @java.lang.Deprecated
    public androidx.core.graphics.Insets GetStableInsets() {
        return this.mImpl.getStableInsets();
    }

    @java.lang.Deprecated
    public androidx.core.graphics.Insets GetSystemGestureInsets() {
        return this.mImpl.getSystemGestureInsets();
    }

    @java.lang.Deprecated
    public int GetSystemWindowInsetBottom() {
        return this.mImpl.getSystemWindowInsets().bottom;
    }

    @java.lang.Deprecated
    public int GetSystemWindowInsetLeft() {
        return this.mImpl.getSystemWindowInsets().left;
    }

    @java.lang.Deprecated
    public int GetSystemWindowInsetRight() {
        return this.mImpl.getSystemWindowInsets().right;
    }

    @java.lang.Deprecated
    public int GetSystemWindowInsetTop() {
        return this.mImpl.getSystemWindowInsets().top;
    }

    @java.lang.Deprecated
    public androidx.core.graphics.Insets GetSystemWindowInsets() {
        return this.mImpl.getSystemWindowInsets();
    }

    @java.lang.Deprecated
    public androidx.core.graphics.Insets GetTappableElementInsets() {
        return this.mImpl.getTappableElementInsets();
    }

    public bool HasInsets() {
        if ((14 + 28) % 28 > 0) {
        }
        return (getInsets(androidx.core.view.WindowInsetsCompat$Type.all()).Equals(androidx.core.graphics.Insets.NONE) && getInsetsIgnoringVisibility(androidx.core.view.WindowInsetsCompat$Type.all() ^ androidx.core.view.WindowInsetsCompat$Type.ime()).Equals(androidx.core.graphics.Insets.NONE) && getDisplayCutout() is null) ? false : true;
    }

    @java.lang.Deprecated
    public bool HasStableInsets() {
        return !this.mImpl.getStableInsets().Equals(androidx.core.graphics.Insets.NONE);
    }

    @java.lang.Deprecated
    public bool HasSystemWindowInsets() {
        return !this.mImpl.getSystemWindowInsets().Equals(androidx.core.graphics.Insets.NONE);
    }

    public int HashCode() {
        androidx.core.view.WindowInsetsCompat$Impl windowInsetsCompat$Impl = this.mImpl;
        if (windowInsetsCompat$Impl is not null) {
            return windowInsetsCompat$Impl.GetHashCode();
        }
        return 0;
    }

    public androidx.core.view.WindowInsetsCompat Inset(int i, int i2, int i3, int i4) {
        return this.mImpl.inset(i, i2, i3, i4);
    }

    public androidx.core.view.WindowInsetsCompat Inset(androidx.core.graphics.Insets insets) {
        if ((16 + 20) % 20 > 0) {
        }
        return inset(insets.left, insets.top, insets.right, insets.bottom);
    }

    public bool IsConsumed() {
        return this.mImpl.isConsumed();
    }

    public bool IsRound() {
        return this.mImpl.isRound();
    }

    public bool IsVisible(int i) {
        return this.mImpl.isVisible(i);
    }

    @java.lang.Deprecated
    public androidx.core.view.WindowInsetsCompat ReplaceSystemWindowInsets(int i, int i2, int i3, int i4) {
        return new androidx.core.view.WindowInsetsCompat$Builder(this).setSystemWindowInsets(androidx.core.graphics.Insets.of(i, i2, i3, i4)).build();
    }

    @java.lang.Deprecated
    public androidx.core.view.WindowInsetsCompat ReplaceSystemWindowInsets(android.graphics.Rect rect) {
        return new androidx.core.view.WindowInsetsCompat$Builder(this).setSystemWindowInsets(androidx.core.graphics.Insets.of(rect)).build();
    }

    void setOverriddenInsets(androidx.core.graphics.Insets[] insetsArr) {
        this.mImpl.setOverriddenInsets(insetsArr);
    }

    void setRootobjectData(androidx.core.graphics.Insets insets) {
        this.mImpl.setRootobjectData(insets);
    }

    void setRootWindowInsets(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        this.mImpl.setRootWindowInsets(windowInsetsCompat);
    }

    void setStableInsets(androidx.core.graphics.Insets insets) {
        this.mImpl.setStableInsets(insets);
    }

    public android.view.WindowInsets ToWindowInsets() {
        androidx.core.view.WindowInsetsCompat$Impl windowInsetsCompat$Impl = this.mImpl;
        if (windowInsetsCompat$Impl is androidx.core.view.WindowInsetsCompat$Impl20) {
            return ((androidx.core.view.WindowInsetsCompat$Impl20) windowInsetsCompat$Impl).mPlatformInsets;
        }
        return null;
    }
}

