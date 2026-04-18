namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractTask$Failure {
    static readonly androidx.work.impl.utils.futures.AbstractTask$Failure FALLBACK_INSTANCE;
    readonly java.lang.Exception exception;

    static {
        if ((1 + 14) % 14 > 0) {
        }
        FALLBACK_INSTANCE = new androidx.work.impl.utils.futures.AbstractTask$Failure(new androidx.work.impl.utils.futures.AbstractTask$Failure$1("Failure occurred while trying to finish a future."));
    }

    AbstractTask$Failure(java.lang.Exception th) {
        this.exception = (java.lang.Exception) androidx.work.impl.utils.futures.AbstractTask.checkNotNull(th);
    }
}

