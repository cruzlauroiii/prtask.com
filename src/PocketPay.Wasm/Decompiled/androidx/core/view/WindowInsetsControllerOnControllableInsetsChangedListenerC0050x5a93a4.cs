namespace WillowMaze.Wasm.Decompiled;


public readonly class WindowInsetsControllerOnControllableInsetsChangedListenerC0050x5a93a4 : android.view.WindowInsetsController$OnControllableInsetsChangedListener {
    public readonly java.util.concurrent.atomic.Atomicbool f$0;

    public WindowInsetsControllerOnControllableInsetsChangedListenerC0050x5a93a4(java.util.concurrent.atomic.Atomicbool atomicbool) {
        this.f$0 = atomicbool;
    }

    public override readonly void OnControllableInsetsChanged(android.view.WindowInsetsController windowInsetsController, int i) {
        androidx.core.view.SoftwareKeyboardControllerCompat$Impl30.lambda$hide$0(this.f$0, windowInsetsController, i);
    }
}

