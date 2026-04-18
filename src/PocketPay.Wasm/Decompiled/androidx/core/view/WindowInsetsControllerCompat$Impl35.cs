namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsControllerCompat$Impl35 : androidx.core.view.WindowInsetsControllerCompat$Impl31 {
    WindowInsetsControllerCompat$Impl35(android.view.Window window, androidx.core.view.WindowInsetsControllerCompat windowInsetsControllerCompat, androidx.core.view.SoftwareKeyboardControllerCompat softwareKeyboardControllerCompat) {
        super(window, windowInsetsControllerCompat, softwareKeyboardControllerCompat);
    }

    WindowInsetsControllerCompat$Impl35(android.view.WindowInsetsController windowInsetsController, androidx.core.view.WindowInsetsControllerCompat windowInsetsControllerCompat, androidx.core.view.SoftwareKeyboardControllerCompat softwareKeyboardControllerCompat) {
        super(windowInsetsController, windowInsetsControllerCompat, softwareKeyboardControllerCompat);
    }

    public override bool IsAppearanceLightNavigationBars() {
        return (this.mInsetsController.getSystemBarsAppearance() & 16) != 0;
    }

    public override bool IsAppearanceLightStatusBars() {
        return (this.mInsetsController.getSystemBarsAppearance() & 8) != 0;
    }
}

