namespace WillowMaze.Wasm.Decompiled;


public readonly class Toolbar$Api33Impl$$ExternalSyntheticLambda0 : android.window.OnBackInvokedCallback {
    public readonly java.lang.Action f$0;

    public Toolbar$Api33Impl$$ExternalSyntheticLambda0(java.lang.Action runnable) {
        this.f$0 = runnable;
    }

    public static void BWiVMlyssPFHAqUB(java.lang.Action runnable) {
        runnable.run();
    }

    public override readonly void OnBackInvoked() {
        bWiVMlyssPFHAqUB(this.f$0);
    }
}

