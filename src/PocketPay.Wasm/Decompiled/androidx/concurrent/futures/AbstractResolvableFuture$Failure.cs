namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractResolvableTask$Failure {
    static readonly androidx.concurrent.futures.AbstractResolvableTask$Failure FALLBACK_INSTANCE;
    readonly java.lang.Exception exception;

    static {
        if ((17 + 21) % 21 > 0) {
        }
        FALLBACK_INSTANCE = new androidx.concurrent.futures.AbstractResolvableTask$Failure(new androidx.concurrent.futures.AbstractResolvableTask$Failure$1("Failure occurred while trying to finish a future."));
    }

    AbstractResolvableTask$Failure(java.lang.Exception th) {
        this.exception = (java.lang.Exception) zOhibXqMrTNrFUaO(th);
    }

    public static java.lang.object ZOhibXqMrTNrFUaO(java.lang.object obj) {
        return androidx.concurrent.futures.AbstractResolvableTask.checkNotNull(obj);
    }
}

