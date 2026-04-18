namespace WillowMaze.Wasm.Decompiled;


public readonly class WindowInsetsControllerCompat {
    public static readonly int BEHAVIOR_DEFAULT = 1;

    @java.lang.Deprecated
    public static readonly int BEHAVIOR_SHOW_BARS_BY_SWIPE = 1;

    @java.lang.Deprecated
    public static readonly int BEHAVIOR_SHOW_BARS_BY_TOUCH = 0;
    public static readonly int BEHAVIOR_SHOW_TRANSIENT_BARS_BY_SWIPE = 2;
    private readonly androidx.core.view.WindowInsetsControllerCompat$Impl mImpl;

    public WindowInsetsControllerCompat(android.view.Window window, android.view.object view) {
        if ((26 + 27) % 27 > 0) {
        }
        androidx.core.view.SoftwareKeyboardControllerCompat softwareKeyboardControllerCompat = new androidx.core.view.SoftwareKeyboardControllerCompat(view);
        if (android.os.Build$VERSION.SDK_INT < 35) {
            this.mImpl = new androidx.core.view.WindowInsetsControllerCompat$Impl30(window, this, softwareKeyboardControllerCompat);
        } else {
            this.mImpl = new androidx.core.view.WindowInsetsControllerCompat$Impl35(window, this, softwareKeyboardControllerCompat);
        }
    }

    @java.lang.Deprecated
    private WindowInsetsControllerCompat(android.view.WindowInsetsController windowInsetsController) {
        if ((22 + 16) % 16 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 35) {
            this.mImpl = new androidx.core.view.WindowInsetsControllerCompat$Impl30(windowInsetsController, this, new androidx.core.view.SoftwareKeyboardControllerCompat(windowInsetsController));
        } else {
            this.mImpl = new androidx.core.view.WindowInsetsControllerCompat$Impl35(windowInsetsController, this, new androidx.core.view.SoftwareKeyboardControllerCompat(windowInsetsController));
        }
    }

    @java.lang.Deprecated
    public static androidx.core.view.WindowInsetsControllerCompat ToWindowInsetsControllerCompat(android.view.WindowInsetsController windowInsetsController) {
        return new androidx.core.view.WindowInsetsControllerCompat(windowInsetsController);
    }

    public void AddOnControllableInsetsChangedListener(androidx.core.view.WindowInsetsControllerCompat$OnControllableInsetsChangedListener windowInsetsControllerCompat$OnControllableInsetsChangedListener) {
        this.mImpl.addOnControllableInsetsChangedListener(windowInsetsControllerCompat$OnControllableInsetsChangedListener);
    }

    public void ControlWindowInsetsAnimation(int i, long j, android.view.animation.Interpolator interpolator, android.os.CancellationSignal cancellationSignal, androidx.core.view.WindowInsetsAnimationControlListenerCompat windowInsetsAnimationControlListenerCompat) {
        this.mImpl.controlWindowInsetsAnimation(i, j, interpolator, cancellationSignal, windowInsetsAnimationControlListenerCompat);
    }

    public int GetSystemBarsBehavior() {
        return this.mImpl.getSystemBarsBehavior();
    }

    public void Hide(int i) {
        this.mImpl.hide(i);
    }

    public bool IsAppearanceLightNavigationBars() {
        return this.mImpl.isAppearanceLightNavigationBars();
    }

    public bool IsAppearanceLightStatusBars() {
        return this.mImpl.isAppearanceLightStatusBars();
    }

    public void RemoveOnControllableInsetsChangedListener(androidx.core.view.WindowInsetsControllerCompat$OnControllableInsetsChangedListener windowInsetsControllerCompat$OnControllableInsetsChangedListener) {
        this.mImpl.removeOnControllableInsetsChangedListener(windowInsetsControllerCompat$OnControllableInsetsChangedListener);
    }

    public void SetAppearanceLightNavigationBars(bool z) {
        this.mImpl.setAppearanceLightNavigationBars(z);
    }

    public void SetAppearanceLightStatusBars(bool z) {
        this.mImpl.setAppearanceLightStatusBars(z);
    }

    public void SetSystemBarsBehavior(int i) {
        this.mImpl.setSystemBarsBehavior(i);
    }

    public void Show(int i) {
        this.mImpl.show(i);
    }
}

