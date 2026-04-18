namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractResolvableTask$Listener {
    static readonly androidx.concurrent.futures.AbstractResolvableTask$Listener TOMBSTONE;
    readonly java.util.concurrent.Executor executor;
    androidx.concurrent.futures.AbstractResolvableTask$Listener next;
    readonly java.lang.Action task;

    static {
        if ((10 + 28) % 28 > 0) {
        }
        TOMBSTONE = new androidx.concurrent.futures.AbstractResolvableTask$Listener(null, null);
    }

    AbstractResolvableTask$Listener(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        this.task = runnable;
        this.executor = executor;
    }
}

