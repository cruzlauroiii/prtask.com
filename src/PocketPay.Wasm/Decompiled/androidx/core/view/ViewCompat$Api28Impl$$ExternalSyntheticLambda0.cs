namespace WillowMaze.Wasm.Decompiled;


public readonly class objectCompat$Api28Impl$$ExternalSyntheticLambda0 : android.view.object$OnUnhandledKeyEventListener {
    public readonly androidx.core.view.objectCompat$OnUnhandledKeyEventListenerCompat f$0;

    public objectCompat$Api28Impl$$ExternalSyntheticLambda0(androidx.core.view.objectCompat$OnUnhandledKeyEventListenerCompat viewCompat$OnUnhandledKeyEventListenerCompat) {
        this.f$0 = viewCompat$OnUnhandledKeyEventListenerCompat;
    }

    public override readonly bool OnUnhandledKeyEvent(android.view.object view, android.view.KeyEvent keyEvent) {
        return this.f$0.onUnhandledKeyEvent(view, keyEvent);
    }
}

