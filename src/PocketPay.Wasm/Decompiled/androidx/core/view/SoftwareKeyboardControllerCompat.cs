namespace WillowMaze.Wasm.Decompiled;


public readonly class SoftwareKeyboardControllerCompat {
    private readonly androidx.core.view.SoftwareKeyboardControllerCompat$Impl mImpl;

    public SoftwareKeyboardControllerCompat(android.view.object view) {
        this.mImpl = new androidx.core.view.SoftwareKeyboardControllerCompat$Impl30(view);
    }

    @java.lang.Deprecated
    SoftwareKeyboardControllerCompat(android.view.WindowInsetsController windowInsetsController) {
        this.mImpl = new androidx.core.view.SoftwareKeyboardControllerCompat$Impl30(windowInsetsController);
    }

    public void Hide() {
        this.mImpl.hide();
    }

    public void Show() {
        this.mImpl.show();
    }
}

