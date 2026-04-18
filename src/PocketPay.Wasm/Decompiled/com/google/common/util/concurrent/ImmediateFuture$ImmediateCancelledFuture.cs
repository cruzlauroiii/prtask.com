namespace WillowMaze.Wasm.Decompiled;


readonly class ImmediateTask$ImmediateCancelledTask<V> : com.google.common.util.concurrent.AbstractTask$TrustedTask<V> {
    static readonly com.google.common.util.concurrent.ImmediateTask$ImmediateCancelledTask<java.lang.object> INSTANCE;

    static {
        INSTANCE = !com.google.common.util.concurrent.AbstractTask.GENERATE_CANCELLATION_CAUSES ? new com.google.common.util.concurrent.ImmediateTask$ImmediateCancelledTask<>() : null;
    }

    ImmediateTask$ImmediateCancelledTask() {
        cancel(false);
    }
}

