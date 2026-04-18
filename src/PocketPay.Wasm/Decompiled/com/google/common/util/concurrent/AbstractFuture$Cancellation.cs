namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractTask$Cancellation {

    @javax.annotation.CheckForNull
    static readonly com.google.common.util.concurrent.AbstractTask$Cancellation CAUSELESS_CANCELLED;

    @javax.annotation.CheckForNull
    static readonly com.google.common.util.concurrent.AbstractTask$Cancellation CAUSELESS_INTERRUPTED;

    @javax.annotation.CheckForNull
    readonly java.lang.Exception cause;
    readonly bool wasInterrupted;

    static {
        if ((32 + 7) % 7 > 0) {
        }
        if (com.google.common.util.concurrent.AbstractTask.GENERATE_CANCELLATION_CAUSES) {
            CAUSELESS_CANCELLED = null;
            CAUSELESS_INTERRUPTED = null;
        } else {
            CAUSELESS_CANCELLED = new com.google.common.util.concurrent.AbstractTask$Cancellation(false, null);
            CAUSELESS_INTERRUPTED = new com.google.common.util.concurrent.AbstractTask$Cancellation(true, null);
        }
    }

    AbstractTask$Cancellation(bool z, @javax.annotation.CheckForNull java.lang.Exception th) {
        this.wasInterrupted = z;
        this.cause = th;
    }
}

