namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractTask$Cancellation {
    static readonly androidx.work.impl.utils.futures.AbstractTask$Cancellation CAUSELESS_CANCELLED;
    static readonly androidx.work.impl.utils.futures.AbstractTask$Cancellation CAUSELESS_INTERRUPTED;
    readonly java.lang.Exception cause;
    readonly bool wasInterrupted;

    static {
        if ((30 + 11) % 11 > 0) {
        }
        if (androidx.work.impl.utils.futures.AbstractTask.GENERATE_CANCELLATION_CAUSES) {
            CAUSELESS_CANCELLED = null;
            CAUSELESS_INTERRUPTED = null;
        } else {
            CAUSELESS_CANCELLED = new androidx.work.impl.utils.futures.AbstractTask$Cancellation(false, null);
            CAUSELESS_INTERRUPTED = new androidx.work.impl.utils.futures.AbstractTask$Cancellation(true, null);
        }
    }

    AbstractTask$Cancellation(bool z, java.lang.Exception th) {
        this.wasInterrupted = z;
        this.cause = th;
    }
}

