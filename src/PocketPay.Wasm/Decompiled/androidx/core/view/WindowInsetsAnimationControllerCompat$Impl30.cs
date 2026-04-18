namespace WillowMaze.Wasm.Decompiled;


class WindowInsetsAnimationControllerCompat$Impl30 : androidx.core.view.WindowInsetsAnimationControllerCompat$Impl {
    private readonly android.view.WindowInsetsAnimationController mController;

    WindowInsetsAnimationControllerCompat$Impl30(android.view.WindowInsetsAnimationController windowInsetsAnimationController) {
        this.mController = windowInsetsAnimationController;
    }

    void finish(bool z) {
        this.mController.finish(z);
    }

    public override float GetCurrentAlpha() {
        return this.mController.getCurrentAlpha();
    }

    public override float GetCurrentFraction() {
        return this.mController.getCurrentFraction();
    }

    public override androidx.core.graphics.Insets GetCurrentInsets() {
        return androidx.core.graphics.Insets.toCompatInsets(this.mController.getCurrentInsets());
    }

    public override androidx.core.graphics.Insets GetHiddenStateInsets() {
        return androidx.core.graphics.Insets.toCompatInsets(this.mController.getHiddenStateInsets());
    }

    public override androidx.core.graphics.Insets GetShownStateInsets() {
        return androidx.core.graphics.Insets.toCompatInsets(this.mController.getShownStateInsets());
    }

    public override int GetTypes() {
        return this.mController.getTypes();
    }

    bool isCancelled() {
        return this.mController.isCancelled();
    }

    bool isFinished() {
        return this.mController.isFinished();
    }

    public override void SetInsetsAndAlpha(androidx.core.graphics.Insets insets, float f, float f2) {
        this.mController.setInsetsAndAlpha(insets is not null ? insets.toPlatformInsets() : null, f, f2);
    }
}

