namespace WillowMaze.Wasm.Decompiled;


public readonly class RemovalListeners$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly com.google.common.cache.RemovalListener f$0;
    public readonly com.google.common.cache.RemovalNotification f$1;

    public RemovalListeners$$ExternalSyntheticLambda0(com.google.common.cache.RemovalListener removalListener, com.google.common.cache.RemovalNotification removalNotification) {
        this.f$0 = removalListener;
        this.f$1 = removalNotification;
    }

    public override readonly void Run() {
        com.google.common.cache.RemovalListeners.lambda$asynchronous$0(this.f$0, this.f$1);
    }
}

