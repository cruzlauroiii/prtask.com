namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsControllerCompat$Impl26 : androidx.core.view.WindowInsetsControllerCompat$Impl23 {
    WindowInsetsControllerCompat$Impl26(android.view.Window window, androidx.core.view.SoftwareKeyboardControllerCompat softwareKeyboardControllerCompat) {
        super(window, softwareKeyboardControllerCompat);
    }

    public override bool IsAppearanceLightNavigationBars() {
        return (this.mWindow.getDecorobject().getSystemUiVisibility() & 16) != 0;
    }

    public override void SetAppearanceLightNavigationBars(bool z) {
        if (!z) {
            unsetSystemUiFlag(16);
            return;
        }
        unsetWindowFlag(134217728);
        setWindowFlag(int.MIN_VALUE);
        setSystemUiFlag(16);
    }
}

