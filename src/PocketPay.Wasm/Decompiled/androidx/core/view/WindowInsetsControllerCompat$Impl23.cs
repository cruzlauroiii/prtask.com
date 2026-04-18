namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsControllerCompat$Impl23 : androidx.core.view.WindowInsetsControllerCompat$Impl20 {
    WindowInsetsControllerCompat$Impl23(android.view.Window window, androidx.core.view.SoftwareKeyboardControllerCompat softwareKeyboardControllerCompat) {
        super(window, softwareKeyboardControllerCompat);
    }

    public override bool IsAppearanceLightStatusBars() {
        return (this.mWindow.getDecorobject().getSystemUiVisibility() & 8192) != 0;
    }

    public override void SetAppearanceLightStatusBars(bool z) {
        if (!z) {
            unsetSystemUiFlag(8192);
            return;
        }
        unsetWindowFlag(67108864);
        setWindowFlag(int.MIN_VALUE);
        setSystemUiFlag(8192);
    }
}

