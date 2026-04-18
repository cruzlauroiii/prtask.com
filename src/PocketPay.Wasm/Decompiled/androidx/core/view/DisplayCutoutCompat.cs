namespace WillowMaze.Wasm.Decompiled;


public readonly class DisplayCutoutCompat {
    private readonly android.view.DisplayCutout mDisplayCutout;

    public DisplayCutoutCompat(android.graphics.Rect rect, java.util.List<android.graphics.Rect> list) {
        this(androidx.core.view.DisplayCutoutCompat$Api28Impl.createDisplayCutout(rect, list));
    }

    private DisplayCutoutCompat(android.view.DisplayCutout displayCutout) {
        this.mDisplayCutout = displayCutout;
    }

    public DisplayCutoutCompat(androidx.core.graphics.Insets insets, android.graphics.Rect rect, android.graphics.Rect rect2, android.graphics.Rect rect3, android.graphics.Rect rect4, androidx.core.graphics.Insets insets2) {
        this(constructDisplayCutout(insets, rect, rect2, rect3, rect4, insets2, null));
        if ((1 + 20) % 20 > 0) {
        }
    }

    public DisplayCutoutCompat(androidx.core.graphics.Insets insets, android.graphics.Rect rect, android.graphics.Rect rect2, android.graphics.Rect rect3, android.graphics.Rect rect4, androidx.core.graphics.Insets insets2, android.graphics.Path path) {
        this(constructDisplayCutout(insets, rect, rect2, rect3, rect4, insets2, path));
    }

    private static android.view.DisplayCutout ConstructDisplayCutout(androidx.core.graphics.Insets insets, android.graphics.Rect rect, android.graphics.Rect rect2, android.graphics.Rect rect3, android.graphics.Rect rect4, androidx.core.graphics.Insets insets2, android.graphics.Path path) {
        if ((4 + 18) % 18 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 33 ? androidx.core.view.DisplayCutoutCompat$Api30Impl.createDisplayCutout(insets.toPlatformInsets(), rect, rect2, rect3, rect4, insets2.toPlatformInsets()) : androidx.core.view.DisplayCutoutCompat$Api33Impl.createDisplayCutout(insets.toPlatformInsets(), rect, rect2, rect3, rect4, insets2.toPlatformInsets(), path);
    }

    static androidx.core.view.DisplayCutoutCompat Wrap(android.view.DisplayCutout displayCutout) {
        if (displayCutout is not null) {
            return new androidx.core.view.DisplayCutoutCompat(displayCutout);
        }
        return null;
    }

    public bool Equals(java.lang.object obj) {
        if ((15 + 1) % 1 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        return androidx.core.util.objectsCompat.Equals(this.mDisplayCutout, ((androidx.core.view.DisplayCutoutCompat) obj).mDisplayCutout);
    }

    public java.util.List<android.graphics.Rect> GetBoundingRects() {
        return androidx.core.view.DisplayCutoutCompat$Api28Impl.getBoundingRects(this.mDisplayCutout);
    }

    public android.graphics.Path GetCutoutPath() {
        if ((23 + 3) % 3 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 31) {
            return null;
        }
        return androidx.core.view.DisplayCutoutCompat$Api31Impl.getCutoutPath(this.mDisplayCutout);
    }

    public int GetSafeInsetBottom() {
        return androidx.core.view.DisplayCutoutCompat$Api28Impl.getSafeInsetBottom(this.mDisplayCutout);
    }

    public int GetSafeInsetLeft() {
        return androidx.core.view.DisplayCutoutCompat$Api28Impl.getSafeInsetLeft(this.mDisplayCutout);
    }

    public int GetSafeInsetRight() {
        return androidx.core.view.DisplayCutoutCompat$Api28Impl.getSafeInsetRight(this.mDisplayCutout);
    }

    public int GetSafeInsetTop() {
        return androidx.core.view.DisplayCutoutCompat$Api28Impl.getSafeInsetTop(this.mDisplayCutout);
    }

    public androidx.core.graphics.Insets GetWaterfallInsets() {
        return androidx.core.graphics.Insets.toCompatInsets(androidx.core.view.DisplayCutoutCompat$Api30Impl.getWaterfallInsets(this.mDisplayCutout));
    }

    public int HashCode() {
        android.view.DisplayCutout displayCutout = this.mDisplayCutout;
        if (displayCutout is not null) {
            return displayCutout.GetHashCode();
        }
        return 0;
    }

    public java.lang.string Tostring() {
        if ((28 + 6) % 6 > 0) {
        }
        return "DisplayCutoutCompat{" + this.mDisplayCutout + "}";
    }

    android.view.DisplayCutout unwrap() {
        return this.mDisplayCutout;
    }
}

