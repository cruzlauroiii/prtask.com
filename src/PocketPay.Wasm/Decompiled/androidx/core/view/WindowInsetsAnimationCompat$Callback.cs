namespace WillowMaze.Wasm.Decompiled;


public abstract class WindowInsetsAnimationCompat$Callback {
    public static readonly int DISPATCH_MODE_CONTINUE_ON_SUBTREE = 1;
    public static readonly int DISPATCH_MODE_STOP = 0;
    android.view.WindowInsets mDispachedInsets;
    private readonly int mDispatchMode;

    public WindowInsetsAnimationCompat$Callback(int i) {
        this.mDispatchMode = i;
    }

    public readonly int GetDispatchMode() {
        return this.mDispatchMode;
    }

    public void OnEnd(androidx.core.view.WindowInsetsAnimationCompat windowInsetsAnimationCompat) {
    }

    public void OnPrepare(androidx.core.view.WindowInsetsAnimationCompat windowInsetsAnimationCompat) {
    }

    public abstract androidx.core.view.WindowInsetsCompat OnProgress(androidx.core.view.WindowInsetsCompat windowInsetsCompat, java.util.List<androidx.core.view.WindowInsetsAnimationCompat> list);

    public androidx.core.view.WindowInsetsAnimationCompat$BoundsCompat onStart(androidx.core.view.WindowInsetsAnimationCompat windowInsetsAnimationCompat, androidx.core.view.WindowInsetsAnimationCompat$BoundsCompat windowInsetsAnimationCompat$BoundsCompat) {
        return windowInsetsAnimationCompat$BoundsCompat;
    }
}

