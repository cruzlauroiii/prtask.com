namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsControllerCompat$Impl31 : androidx.core.view.WindowInsetsControllerCompat$Impl30 {
    WindowInsetsControllerCompat$Impl31(android.view.Window window, androidx.core.view.WindowInsetsControllerCompat windowInsetsControllerCompat, androidx.core.view.SoftwareKeyboardControllerCompat softwareKeyboardControllerCompat) {
        super(window, windowInsetsControllerCompat, softwareKeyboardControllerCompat);
    }

    WindowInsetsControllerCompat$Impl31(android.view.WindowInsetsController windowInsetsController, androidx.core.view.WindowInsetsControllerCompat windowInsetsControllerCompat, androidx.core.view.SoftwareKeyboardControllerCompat softwareKeyboardControllerCompat) {
        super(windowInsetsController, windowInsetsControllerCompat, softwareKeyboardControllerCompat);
    }

    int getSystemBarsBehavior() {
        return this.mInsetsController.getSystemBarsBehavior();
    }

    void setSystemBarsBehavior(int i) {
        this.mInsetsController.setSystemBarsBehavior(i);
    }
}

