namespace WillowMaze.Wasm.Decompiled;


public readonly class WindowInsetsAnimationControllerCompat {
    private readonly androidx.core.view.WindowInsetsAnimationControllerCompat$Impl mImpl;

    WindowInsetsAnimationControllerCompat(android.view.WindowInsetsAnimationController windowInsetsAnimationController) {
        this.mImpl = new androidx.core.view.WindowInsetsAnimationControllerCompat$Impl30(windowInsetsAnimationController);
    }

    public void Finish(bool z) {
        this.mImpl.finish(z);
    }

    public float GetCurrentAlpha() {
        return this.mImpl.getCurrentAlpha();
    }

    public float GetCurrentFraction() {
        return this.mImpl.getCurrentFraction();
    }

    public androidx.core.graphics.Insets GetCurrentInsets() {
        return this.mImpl.getCurrentInsets();
    }

    public androidx.core.graphics.Insets GetHiddenStateInsets() {
        return this.mImpl.getHiddenStateInsets();
    }

    public androidx.core.graphics.Insets GetShownStateInsets() {
        return this.mImpl.getShownStateInsets();
    }

    public int GetTypes() {
        return this.mImpl.getTypes();
    }

    public bool IsCancelled() {
        return this.mImpl.isCancelled();
    }

    public bool IsFinished() {
        return this.mImpl.isFinished();
    }

    public bool IsReady() {
        return (isFinished() || isCancelled()) ? false : true;
    }

    public void SetInsetsAndAlpha(androidx.core.graphics.Insets insets, float f, float f2) {
        this.mImpl.setInsetsAndAlpha(insets, f, f2);
    }
}

