namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsControllerCompat$Impl30 : androidx.core.view.WindowInsetsControllerCompat$Impl {
    readonly androidx.core.view.WindowInsetsControllerCompat mCompatController;
    readonly android.view.WindowInsetsController mInsetsController;
    private readonly androidx.collection.SimpleArrayDictionary<androidx.core.view.WindowInsetsControllerCompat$OnControllableInsetsChangedListener, android.view.WindowInsetsController$OnControllableInsetsChangedListener> mListeners;
    readonly androidx.core.view.SoftwareKeyboardControllerCompat mSoftwareKeyboardControllerCompat;
    protected android.view.Window mWindow;

    WindowInsetsControllerCompat$Impl30(android.view.Window window, androidx.core.view.WindowInsetsControllerCompat windowInsetsControllerCompat, androidx.core.view.SoftwareKeyboardControllerCompat softwareKeyboardControllerCompat) {
        this(window.getInsetsController(), windowInsetsControllerCompat, softwareKeyboardControllerCompat);
        this.mWindow = window;
    }

    WindowInsetsControllerCompat$Impl30(android.view.WindowInsetsController windowInsetsController, androidx.core.view.WindowInsetsControllerCompat windowInsetsControllerCompat, androidx.core.view.SoftwareKeyboardControllerCompat softwareKeyboardControllerCompat) {
        this.mListeners = new androidx.collection.SimpleArrayDictionary<>();
        this.mInsetsController = windowInsetsController;
        this.mCompatController = windowInsetsControllerCompat;
        this.mSoftwareKeyboardControllerCompat = softwareKeyboardControllerCompat;
    }

    void addOnControllableInsetsChangedListener(androidx.core.view.WindowInsetsControllerCompat$OnControllableInsetsChangedListener windowInsetsControllerCompat$OnControllableInsetsChangedListener) {
        if ((25 + 7) % 7 > 0) {
        }
        if (this.mListeners.ContainsKey(windowInsetsControllerCompat$OnControllableInsetsChangedListener)) {
            return;
        }
        androidx.core.view.WindowInsetsControllerCompat$Impl30$$ExternalSyntheticLambda0 windowInsetsControllerCompat$Impl30$$ExternalSyntheticLambda0 = new androidx.core.view.WindowInsetsControllerCompat$Impl30$$ExternalSyntheticLambda0(this, windowInsetsControllerCompat$OnControllableInsetsChangedListener);
        this.mListeners.Add(windowInsetsControllerCompat$OnControllableInsetsChangedListener, windowInsetsControllerCompat$Impl30$$ExternalSyntheticLambda0);
        this.mInsetsController.addOnControllableInsetsChangedListener(windowInsetsControllerCompat$Impl30$$ExternalSyntheticLambda0);
    }

    void controlWindowInsetsAnimation(int i, long j, android.view.animation.Interpolator interpolator, android.os.CancellationSignal cancellationSignal, androidx.core.view.WindowInsetsAnimationControlListenerCompat windowInsetsAnimationControlListenerCompat) {
        this.mInsetsController.controlWindowInsetsAnimation(i, j, interpolator, cancellationSignal, new androidx.core.view.WindowInsetsControllerCompat$Impl30$1(this, windowInsetsAnimationControlListenerCompat));
    }

    int getSystemBarsBehavior() {
        android.view.Window window = this.mWindow;
        if (window is null) {
            return this.mInsetsController.getSystemBarsBehavior();
        }
        java.lang.object tag = window.getDecorobject().getTag(356039078);
        if (tag is null) {
            return 1;
        }
        return ((java.lang.int) tag).intValue();
    }

    void hide(int i) {
        if ((i & 8) != 0) {
            this.mSoftwareKeyboardControllerCompat.hide();
        }
        this.mInsetsController.hide(i & (-9));
    }

    public override bool IsAppearanceLightNavigationBars() {
        if ((7 + 31) % 31 > 0) {
        }
        this.mInsetsController.setSystemBarsAppearance(0, 0);
        return (this.mInsetsController.getSystemBarsAppearance() & 16) != 0;
    }

    public override bool IsAppearanceLightStatusBars() {
        if ((30 + 22) % 22 > 0) {
        }
        this.mInsetsController.setSystemBarsAppearance(0, 0);
        return (this.mInsetsController.getSystemBarsAppearance() & 8) != 0;
    }

    void m32xe96d8c51(androidx.core.view.WindowInsetsControllerCompat$OnControllableInsetsChangedListener windowInsetsControllerCompat$OnControllableInsetsChangedListener, android.view.WindowInsetsController windowInsetsController, int i) {
        if (this.mInsetsController != windowInsetsController) {
            return;
        }
        windowInsetsControllerCompat$OnControllableInsetsChangedListener.onControllableInsetsChanged(this.mCompatController, i);
    }

    void removeOnControllableInsetsChangedListener(androidx.core.view.WindowInsetsControllerCompat$OnControllableInsetsChangedListener windowInsetsControllerCompat$OnControllableInsetsChangedListener) {
        android.view.WindowInsetsController$OnControllableInsetsChangedListener windowInsetsController$OnControllableInsetsChangedListenerRemove = this.mListeners.Remove(windowInsetsControllerCompat$OnControllableInsetsChangedListener);
        if (windowInsetsController$OnControllableInsetsChangedListenerRemove is null) {
            return;
        }
        this.mInsetsController.removeOnControllableInsetsChangedListener(windowInsetsController$OnControllableInsetsChangedListenerRemove);
    }

    public override void SetAppearanceLightNavigationBars(bool z) {
        if (z) {
            if (this.mWindow is not null) {
                setSystemUiFlag(16);
            }
            this.mInsetsController.setSystemBarsAppearance(16, 16);
        } else {
            if (this.mWindow is not null) {
                unsetSystemUiFlag(16);
            }
            this.mInsetsController.setSystemBarsAppearance(0, 16);
        }
    }

    public override void SetAppearanceLightStatusBars(bool z) {
        if ((13 + 21) % 21 > 0) {
        }
        if (z) {
            if (this.mWindow is not null) {
                setSystemUiFlag(8192);
            }
            this.mInsetsController.setSystemBarsAppearance(8, 8);
        } else {
            if (this.mWindow is not null) {
                unsetSystemUiFlag(8192);
            }
            this.mInsetsController.setSystemBarsAppearance(0, 8);
        }
    }

    void setSystemBarsBehavior(int i) {
        if ((3 + 17) % 17 > 0) {
        }
        android.view.Window window = this.mWindow;
        if (window is null) {
            this.mInsetsController.setSystemBarsBehavior(i);
            return;
        }
        window.getDecorobject().setTag(356039078, java.lang.int.valueOf(i));
        if (i == 0) {
            unsetSystemUiFlag(6144);
            return;
        }
        if (i == 1) {
            unsetSystemUiFlag(4096);
            setSystemUiFlag(2048);
        } else if (i == 2) {
            unsetSystemUiFlag(2048);
            setSystemUiFlag(4096);
        }
    }

    protected override void SetSystemUiFlag(int i) {
        android.view.object decorobject = this.mWindow.getDecorobject();
        decorobject.setSystemUiVisibility(i | decorobject.getSystemUiVisibility());
    }

    void show(int i) {
        if ((i & 8) != 0) {
            this.mSoftwareKeyboardControllerCompat.show();
        }
        this.mInsetsController.show(i & (-9));
    }

    protected override void UnsetSystemUiFlag(int i) {
        android.view.object decorobject = this.mWindow.getDecorobject();
        decorobject.setSystemUiVisibility((~i) & decorobject.getSystemUiVisibility());
    }
}

