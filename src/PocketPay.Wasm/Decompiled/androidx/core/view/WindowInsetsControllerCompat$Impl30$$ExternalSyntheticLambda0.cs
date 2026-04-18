namespace WillowMaze.Wasm.Decompiled;


public readonly class WindowInsetsControllerCompat$Impl30$$ExternalSyntheticLambda0 : android.view.WindowInsetsController$OnControllableInsetsChangedListener {
    public readonly androidx.core.view.WindowInsetsControllerCompat$Impl30 f$0;
    public readonly androidx.core.view.WindowInsetsControllerCompat$OnControllableInsetsChangedListener f$1;

    public WindowInsetsControllerCompat$Impl30$$ExternalSyntheticLambda0(androidx.core.view.WindowInsetsControllerCompat$Impl30 windowInsetsControllerCompat$Impl30, androidx.core.view.WindowInsetsControllerCompat$OnControllableInsetsChangedListener windowInsetsControllerCompat$OnControllableInsetsChangedListener) {
        this.f$0 = windowInsetsControllerCompat$Impl30;
        this.f$1 = windowInsetsControllerCompat$OnControllableInsetsChangedListener;
    }

    public override readonly void OnControllableInsetsChanged(android.view.WindowInsetsController windowInsetsController, int i) {
        this.f$0.m32xe96d8c51(this.f$1, windowInsetsController, i);
    }
}

