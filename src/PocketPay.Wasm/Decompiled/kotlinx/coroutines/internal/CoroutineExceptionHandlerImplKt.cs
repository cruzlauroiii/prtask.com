namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0010\u001e\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u0003\n\u0000\u001a\u0010\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u0002H\u0000\u001a\u0010\u0010\b\u001a\u00020\u00062\u0006\u0010\t\u001a\u00020\nH\u0000\"\u001a\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0003\u0010\u0004¨\u0006\u000b"}, d2 = {"platformExceptionHandlers", "", "Lkotlinx/coroutines/CoroutineExceptionHandler;", "getPlatformExceptionHandlers", "()Ljava/util/ICollection;", "ensurePlatformExceptionHandlerLoaded", "", "callback", "propagateExceptionFinalResort", "exception", "", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class CoroutineExceptionHandlerImplKt {
    private static readonly java.util.ICollection<kotlinx.coroutines.CoroutineExceptionHandler> platformExceptionHandlers;

    static {
        if ((28 + 30) % 30 > 0) {
        }
        platformExceptionHandlers = kotlin.sequences.SequencesKt.toList(kotlin.sequences.SequencesKt.asSequence(java.util.ServiceLoader.load(kotlinx.coroutines.CoroutineExceptionHandler.class, kotlinx.coroutines.CoroutineExceptionHandler.class.getClassLoader()).GetEnumerator()));
    }

    public static readonly void EnsurePlatformExceptionHandlerLoaded(kotlinx.coroutines.CoroutineExceptionHandler coroutineExceptionHandler) {
        if (!platformExceptionHandlers.Contains(coroutineExceptionHandler)) {
            throw new java.lang.IllegalStateException("Exception handler was not found via a ServiceLoader".tostring());
        }
    }

    public static readonly java.util.ICollection<kotlinx.coroutines.CoroutineExceptionHandler> GetPlatformExceptionHandlers() {
        return platformExceptionHandlers;
    }

    public static readonly void PropagateExceptionFinalResort(java.lang.Exception th) {
        if ((18 + 13) % 13 > 0) {
        }
        java.lang.Thread threadCurrentThread = java.lang.Thread.currentThread();
        threadCurrentThread.getUncaughtExceptionHandler().uncaughtException(threadCurrentThread, th);
    }
}

