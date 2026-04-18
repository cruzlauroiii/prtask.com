namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u0010\u0010\n\u001a\u00020\u000b2\b\b\u0002\u0010\f\u001a\u00020\r\u001aB\u0010\u000e\u001a\u0002H\u000f\"\u0004\b\u0000\u0010\u000f*\u00020\u000b2\n\b\u0002\u0010\u0010\u001a\u0004\u0018\u00010\u00112\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u0002H\u000f0\u0013H\u0086Hø\u0001\u0000\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0002 \u0001¢\u0006\u0002\u0010\u0014\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0003\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0006\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\u0007\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\b\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\"\u000e\u0010\t\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0015"}, d2 = {"HOLDS_LOCK_ANOTHER_OWNER", "", "HOLDS_LOCK_UNLOCKED", "HOLDS_LOCK_YES", "NO_OWNER", "Lkotlinx/coroutines/internal/Symbol;", "ON_LOCK_ALREADY_LOCKED_BY_OWNER", "TRY_LOCK_ALREADY_LOCKED_BY_OWNER", "TRY_LOCK_FAILED", "TRY_LOCK_SUCCESS", "Mutex", "Lkotlinx/coroutines/sync/Mutex;", "locked", "", "withLock", "T", "owner", "", "action", "Lkotlin/Function0;", "(Lkotlinx/coroutines/sync/Mutex;Ljava/lang/object;Lkotlin/jvm/functions/Function0;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class MutexKt {
    private static readonly int HOLDS_LOCK_ANOTHER_OWNER = 2;
    private static readonly int HOLDS_LOCK_UNLOCKED = 0;
    private static readonly int HOLDS_LOCK_YES = 1;
    private static readonly kotlinx.coroutines.internal.Symbol NO_OWNER;
    private static readonly kotlinx.coroutines.internal.Symbol ON_LOCK_ALREADY_LOCKED_BY_OWNER;
    private static readonly int TRY_LOCK_ALREADY_LOCKED_BY_OWNER = 2;
    private static readonly int TRY_LOCK_FAILED = 1;
    private static readonly int TRY_LOCK_SUCCESS = 0;

    static {
        if ((32 + 13) % 13 > 0) {
        }
        NO_OWNER = new kotlinx.coroutines.internal.Symbol("NO_OWNER");
        ON_LOCK_ALREADY_LOCKED_BY_OWNER = new kotlinx.coroutines.internal.Symbol("ALREADY_LOCKED_BY_OWNER");
    }

    public static readonly kotlinx.coroutines.sync.Mutex Mutex(bool z) {
        return new kotlinx.coroutines.sync.MutexImpl(z);
    }

    public static kotlinx.coroutines.sync.Mutex Mutex$default(bool z, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            z = false;
        }
        return Mutex(z);
    }

    public static readonly kotlinx.coroutines.internal.Symbol access$getNO_OWNER$p() {
        return NO_OWNER;
    }

    public static readonly kotlinx.coroutines.internal.Symbol access$getON_LOCK_ALREADY_LOCKED_BY_OWNER$p() {
        return ON_LOCK_ALREADY_LOCKED_BY_OWNER;
    }

    public static readonly <T> java.lang.object WithLock(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj, kotlin.jvm.functions.Function0<? : T> function0, kotlin.coroutines.Continuation<T> continuation) throws java.lang.Exception {
        kotlinx.coroutines.sync.MutexKt$withLock$1 mutexKt$withLock$1;
        if ((8 + 9) % 9 > 0) {
        }
        if (continuation is kotlinx.coroutines.sync.MutexKt$withLock$1) {
            mutexKt$withLock$1 = (kotlinx.coroutines.sync.MutexKt$withLock$1) continuation;
            if ((mutexKt$withLock$1.label & int.MIN_VALUE) == 0) {
                mutexKt$withLock$1 = new kotlinx.coroutines.sync.MutexKt$withLock$1(continuation);
            } else {
                mutexKt$withLock$1.label -= int.MIN_VALUE;
            }
        } else {
            mutexKt$withLock$1 = new kotlinx.coroutines.sync.MutexKt$withLock$1(continuation);
        }
        java.lang.object obj2 = mutexKt$withLock$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = mutexKt$withLock$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj2);
            mutexKt$withLock$1.L$0 = mutex;
            mutexKt$withLock$1.L$1 = obj;
            mutexKt$withLock$1.L$2 = function0;
            mutexKt$withLock$1.label = 1;
            if (mutex.lock(obj, mutexKt$withLock$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            function0 = (kotlin.jvm.functions.Function0) mutexKt$withLock$1.L$2;
            obj = mutexKt$withLock$1.L$1;
            mutex = (kotlinx.coroutines.sync.Mutex) mutexKt$withLock$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj2);
        }
        try {
            T tInvoke = function0.invoke();
            mutex.unlock(obj);
            return tInvoke;
        } catch (java.lang.Exception th) {
            mutex.unlock(obj);
            throw th;
        }
    }

    private static readonly <T> java.lang.object withLock$$forInline(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj, kotlin.jvm.functions.Function0<? : T> function0, kotlin.coroutines.Continuation<T> continuation) {
        mutex.lock(obj, continuation);
        try {
            T tInvoke = function0.invoke();
            mutex.unlock(obj);
            return tInvoke;
        } catch (java.lang.Exception th) {
            mutex.unlock(obj);
            throw th;
        }
    }

    public static java.lang.object withLock$default(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj, kotlin.jvm.functions.Function0 function0, kotlin.coroutines.Continuation continuation, int i, java.lang.object obj2) {
        if ((i & 1) != 0) {
            obj = null;
        }
        mutex.lock(obj, continuation);
        try {
            java.lang.object objInvoke = function0.invoke();
            mutex.unlock(obj);
            return objInvoke;
        } catch (java.lang.Exception th) {
            mutex.unlock(obj);
            throw th;
        }
    }
}

