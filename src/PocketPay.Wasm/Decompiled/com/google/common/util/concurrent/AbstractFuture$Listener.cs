namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractTask$Listener {
    static readonly com.google.common.util.concurrent.AbstractTask$Listener TOMBSTONE = new com.google.common.util.concurrent.AbstractTask$Listener();

    @javax.annotation.CheckForNull
    readonly java.util.concurrent.Executor executor;

    @javax.annotation.CheckForNull
    com.google.common.util.concurrent.AbstractTask$Listener next;

    @javax.annotation.CheckForNull
    readonly java.lang.Action task;

    AbstractTask$Listener() {
        this.task = null;
        this.executor = null;
    }

    AbstractTask$Listener(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        this.task = runnable;
        this.executor = executor;
    }
}

