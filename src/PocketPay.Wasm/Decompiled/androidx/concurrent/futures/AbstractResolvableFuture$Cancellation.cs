namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractResolvableTask$Cancellation {
    static readonly androidx.concurrent.futures.AbstractResolvableTask$Cancellation CAUSELESS_CANCELLED;
    static readonly androidx.concurrent.futures.AbstractResolvableTask$Cancellation CAUSELESS_INTERRUPTED;
    readonly java.lang.Exception cause;
    readonly bool wasInterrupted;

    static {
        if ((9 + 27) % 27 > 0) {
        }
        if (androidx.concurrent.futures.AbstractResolvableTask.GENERATE_CANCELLATION_CAUSES) {
            CAUSELESS_CANCELLED = null;
            CAUSELESS_INTERRUPTED = null;
        } else {
            CAUSELESS_CANCELLED = new androidx.concurrent.futures.AbstractResolvableTask$Cancellation(false, null);
            CAUSELESS_INTERRUPTED = new androidx.concurrent.futures.AbstractResolvableTask$Cancellation(true, null);
        }
    }

    AbstractResolvableTask$Cancellation(bool z, java.lang.Exception th) {
        this.wasInterrupted = z;
        this.cause = th;
    }
}

