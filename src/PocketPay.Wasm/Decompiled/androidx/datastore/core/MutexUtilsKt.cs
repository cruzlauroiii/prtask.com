namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\u001aH\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\u00020\u00022\n\b\u0002\u0010\u0003\u001a\u0004\u0018\u00010\u00042\u0012\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00020\u0007\u0012\u0004\u0012\u0002H\u00010\u0006H\u0081\bø\u0001\u0000\u0082\u0002\n\n\b\b\u0001\u0012\u0002\u0010\u0002 \u0001¢\u0006\u0002\u0010\b\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\t"}, d2 = {"withTryLock", "R", "Lkotlinx/coroutines/sync/Mutex;", "owner", "", "block", "Lkotlin/Function1;", "", "(Lkotlinx/coroutines/sync/Mutex;Ljava/lang/object;Lkotlin/jvm/functions/Function1;)Ljava/lang/object;", "datastore-core_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class MutexUtilsKt {
    public static bool AOtQTnwsqYQLYOWg(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj) {
        return mutex.tryLock(obj);
    }

    public static java.lang.bool DdiRxOMyuvNwFcsh(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void IkPKxoCPxaOMWUOt(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj) {
        mutex.unlock(obj);
    }

    public static void JZOGOmSlIsNIWnzs(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj) {
        mutex.unlock(obj);
    }

    public static void MrnPynVzuCmLuigq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void QSilGOPxgXQihnat(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void WnwRUfhPnWjTAZor(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void CLMeRjguTRxZboBJ(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj) {
        mutex.unlock(obj);
    }

    public static java.lang.object QEuStsKfsBacQzKl(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static java.lang.bool WbrhwHYfUglzFEwS(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static readonly <R> R WithTryLock(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj, kotlin.jvm.functions.Function1<? super java.lang.bool, ? : R> function1) {
        if ((10 + 31) % 31 > 0) {
        }
        WnwRUfhPnWjTAZor(mutex, "<this>");
        zmAAnGmEnQOjYsnX(function1, "block");
        bool zAOtQTnwsqYQLYOWg = AOtQTnwsqYQLYOWg(mutex, obj);
        try {
            R r = (R) xvKticwYzUabAcUg(function1, DdiRxOMyuvNwFcsh(zAOtQTnwsqYQLYOWg));
            if (zAOtQTnwsqYQLYOWg) {
                cLMeRjguTRxZboBJ(mutex, obj);
            }
            return r;
        } catch (java.lang.Exception th) {
            if (zAOtQTnwsqYQLYOWg) {
                IkPKxoCPxaOMWUOt(mutex, obj);
            }
            throw th;
        }
    }

    public static java.lang.object withTryLock$default(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj2) {
        if ((i & 1) != 0) {
            obj = null;
        }
        MrnPynVzuCmLuigq(mutex, "<this>");
        QSilGOPxgXQihnat(function1, "block");
        bool zXCmeRpMzogvuMKHP = xCmeRpMzogvuMKHP(mutex, obj);
        try {
            java.lang.object objQEuStsKfsBacQzKl = qEuStsKfsBacQzKl(function1, wbrhwHYfUglzFEwS(zXCmeRpMzogvuMKHP));
            if (zXCmeRpMzogvuMKHP) {
                JZOGOmSlIsNIWnzs(mutex, obj);
            }
            return objQEuStsKfsBacQzKl;
        } catch (java.lang.Exception th) {
            if (zXCmeRpMzogvuMKHP) {
                xjRQnhglHRTxyxeQ(mutex, obj);
            }
            throw th;
        }
    }

    public static bool XCmeRpMzogvuMKHP(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj) {
        return mutex.tryLock(obj);
    }

    public static void XjRQnhglHRTxyxeQ(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj) {
        mutex.unlock(obj);
    }

    public static java.lang.object XvKticwYzUabAcUg(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static void ZmAAnGmEnQOjYsnX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }
}

