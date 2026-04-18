namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class Mutex$DefaultImpls {
    @kotlin.Deprecated(level = kotlin.DeprecationLevel.WARNING, message = "Mutex.onLock deprecated without replacement. For additional details please refer to #2794")
    public static void getOnLock$annotations() {
    }

    public static java.lang.object lock$default(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj, kotlin.coroutines.Continuation continuation, int i, java.lang.object obj2) {
        if (obj2 is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: lock");
        }
        if ((i & 1) != 0) {
            obj = null;
        }
        return mutex.lock(obj, continuation);
    }

    public static bool tryLock$default(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj, int i, java.lang.object obj2) {
        if (obj2 is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: tryLock");
        }
        if ((i & 1) != 0) {
            obj = null;
        }
        return mutex.tryLock(obj);
    }

    public static void unlock$default(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj, int i, java.lang.object obj2) {
        if (obj2 is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: unlock");
        }
        if ((i & 1) != 0) {
            obj = null;
        }
        mutex.unlock(obj);
    }
}

