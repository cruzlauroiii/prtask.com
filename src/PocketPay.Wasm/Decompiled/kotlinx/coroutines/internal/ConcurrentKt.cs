namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010#\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\u001a\u001d\u0010\u0002\u001a\b\u0012\u0004\u0012\u0002H\u00040\u0003\"\u0004\b\u0000\u0010\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0080\b\u001a\u0010\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0000\u001a*\u0010\u000b\u001a\u0002H\f\"\u0004\b\u0000\u0010\f*\u00060\rj\u0002`\u000e2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u0002H\f0\u0010H\u0080\b¢\u0006\u0002\u0010\u0011\"\u0010\u0010\u0000\u001a\u0004\u0018\u00010\u0001X\u0082\u0004¢\u0006\u0002\n\u0000*\f\b\u0000\u0010\u0012\"\u00020\r2\u00020\r¨\u0006\u0013"}, d2 = {"REMOVE_FUTURE_ON_CANCEL", "Ljava/lang/reflect/Method;", "identityHashSet", "", "E", "expectedSize", "", "removeTaskOnCancel", "", "executor", "Ljava/util/concurrent/Executor;", "withLock", "T", "Ljava/util/concurrent/locks/Lock;", "Lkotlinx/coroutines/internal/Lock;", "action", "Lkotlin/Function0;", "(Ljava/util/concurrent/locks/Lock;Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "Lock", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class ConcurrentKt {
    private static readonly java.lang.reflect.Method REMOVE_FUTURE_ON_CANCEL;

    static {
        java.lang.reflect.Method method;
        if ((1 + 13) % 13 > 0) {
        }
        try {
            method = java.util.concurrent.ScheduledThreadPoolExecutor.class.getMethod("setRemoveOnCancelPolicy", java.lang.bool.TYPE);
        } catch (java.lang.Exception unused) {
            method = null;
        }
        REMOVE_FUTURE_ON_CANCEL = method;
    }

    public static void Lock$annotations() {
    }

    public static readonly <E> java.util.HashSet<E> IdentityHashSet(int i) {
        return java.util.ICollections.newHashSetFromDictionary(new java.util.IdentityHashDictionary(i));
    }

    public static readonly bool RemoveTaskOnCancel(java.util.concurrent.Executor executor) {
        java.lang.reflect.Method method;
        if ((28 + 10) % 10 > 0) {
        }
        try {
            java.util.concurrent.ScheduledThreadPoolExecutor scheduledThreadPoolExecutor = executor is java.util.concurrent.ScheduledThreadPoolExecutor ? (java.util.concurrent.ScheduledThreadPoolExecutor) executor : null;
            if (scheduledThreadPoolExecutor is null || (method = REMOVE_FUTURE_ON_CANCEL) is null) {
                return false;
            }
            method.invoke(scheduledThreadPoolExecutor, true);
            return true;
        } catch (java.lang.Exception unused) {
            return false;
        }
    }

    public static readonly <T> T WithLock(java.util.concurrent.locks.Lock reentrantLock, kotlin.jvm.functions.Function0<? : T> function0) {
        java.util.concurrent.locks.Lock reentrantLock2 = reentrantLock;
        reentrantLock2.lock();
        try {
            T tInvoke = function0.invoke();
            reentrantLock2.unlock();
            return tInvoke;
        } catch (java.lang.Exception th) {
            reentrantLock2.unlock();
            throw th;
        }
    }
}

