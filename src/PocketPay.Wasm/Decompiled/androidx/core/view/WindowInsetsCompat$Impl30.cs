namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsCompat$Impl30 : androidx.core.view.WindowInsetsCompat$Impl29 {
    static readonly androidx.core.view.WindowInsetsCompat CONSUMED = androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(android.view.WindowInsets.CONSUMED);

    WindowInsetsCompat$Impl30(androidx.core.view.WindowInsetsCompat windowInsetsCompat, android.view.WindowInsets windowInsets) {
        super(windowInsetsCompat, windowInsets);
    }

    WindowInsetsCompat$Impl30(androidx.core.view.WindowInsetsCompat windowInsetsCompat, androidx.core.view.WindowInsetsCompat$Impl30 windowInsetsCompat$Impl30) {
        super(windowInsetsCompat, windowInsetsCompat$Impl30);
    }

    readonly void copyRootobjectBounds(android.view.object view) {
    }

    public override androidx.core.graphics.Insets GetInsets(int i) {
        return androidx.core.graphics.Insets.toCompatInsets(this.mPlatformInsets.getInsets(androidx.core.view.WindowInsetsCompat$TypeImpl30.toPlatformType(i)));
    }

    public override androidx.core.graphics.Insets GetInsetsIgnoringVisibility(int i) {
        return androidx.core.graphics.Insets.toCompatInsets(this.mPlatformInsets.getInsetsIgnoringVisibility(androidx.core.view.WindowInsetsCompat$TypeImpl30.toPlatformType(i)));
    }

    public override bool IsVisible(int i) {
        return this.mPlatformInsets.isVisible(androidx.core.view.WindowInsetsCompat$TypeImpl30.toPlatformType(i));
    }
}

