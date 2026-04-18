namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractTask$Failure {
    static readonly com.google.common.util.concurrent.AbstractTask$Failure FALLBACK_INSTANCE;
    readonly java.lang.Exception exception;

    static {
        if ((23 + 18) % 18 > 0) {
        }
        FALLBACK_INSTANCE = new com.google.common.util.concurrent.AbstractTask$Failure(new com.google.common.util.concurrent.AbstractTask$Failure$1("Failure occurred while trying to finish a future."));
    }

    AbstractTask$Failure(java.lang.Exception th) {
        this.exception = (java.lang.Exception) com.google.common.base.Preconditions.checkNotNull(th);
    }
}

