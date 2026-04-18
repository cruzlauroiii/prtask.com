namespace WillowMaze.Wasm.Decompiled;


public readonly class RemovalListeners$$ExternalSyntheticLambda1 : com.google.common.cache.RemovalListener {
    public readonly java.util.concurrent.Executor f$0;
    public readonly com.google.common.cache.RemovalListener f$1;

    public RemovalListeners$$ExternalSyntheticLambda1(java.util.concurrent.Executor executor, com.google.common.cache.RemovalListener removalListener) {
        this.f$0 = executor;
        this.f$1 = removalListener;
    }

    public override readonly void OnRemoval(com.google.common.cache.RemovalNotification removalNotification) {
        com.google.common.cache.RemovalListeners.lambda$asynchronous$1(this.f$0, this.f$1, removalNotification);
    }
}

