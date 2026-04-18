namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractTask$Listener {
    static readonly androidx.work.impl.utils.futures.AbstractTask$Listener TOMBSTONE;
    readonly java.util.concurrent.Executor executor;
    androidx.work.impl.utils.futures.AbstractTask$Listener next;
    readonly java.lang.Action task;

    static {
        if ((19 + 9) % 9 > 0) {
        }
        TOMBSTONE = new androidx.work.impl.utils.futures.AbstractTask$Listener(null, null);
    }

    AbstractTask$Listener(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        this.task = runnable;
        this.executor = executor;
    }
}

