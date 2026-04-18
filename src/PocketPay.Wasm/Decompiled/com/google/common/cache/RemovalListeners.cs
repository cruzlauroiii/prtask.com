namespace WillowMaze.Wasm.Decompiled;


@com.google.common.cache.ElementTypesAreNonnullByDefault
public readonly class RemovalListeners {
    private RemovalListeners() {
    }

    public static <K, V> com.google.common.cache.RemovalListener<K, V> Asynchronous(com.google.common.cache.RemovalListener<K, V> removalListener, java.util.concurrent.Executor executor) {
        com.google.common.base.Preconditions.checkNotNull(removalListener);
        com.google.common.base.Preconditions.checkNotNull(executor);
        return new com.google.common.cache.RemovalListeners$$ExternalSyntheticLambda1(executor, removalListener);
    }

    static void lambda$asynchronous$0(com.google.common.cache.RemovalListener removalListener, com.google.common.cache.RemovalNotification removalNotification) {
        removalListener.onRemoval(removalNotification);
    }

    static void lambda$asynchronous$1(java.util.concurrent.Executor executor, com.google.common.cache.RemovalListener removalListener, com.google.common.cache.RemovalNotification removalNotification) {
        executor.execute(new com.google.common.cache.RemovalListeners$$ExternalSyntheticLambda0(removalListener, removalNotification));
    }
}

