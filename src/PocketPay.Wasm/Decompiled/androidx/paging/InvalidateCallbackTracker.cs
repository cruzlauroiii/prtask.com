namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010!\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\n\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002B+\u0012\u0012\u0010\u0003\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00020\u00050\u0004\u0012\u0010\b\u0002\u0010\u0006\u001a\n\u0012\u0004\u0012\u00020\b\u0018\u00010\u0007¢\u0006\u0002\u0010\tJ\r\u0010\u0013\u001a\u00020\u0014H\u0001¢\u0006\u0002\b\u0015J\r\u0010\u0016\u001a\u00020\bH\u0000¢\u0006\u0002\b\u0017J\u0017\u0010\u0018\u001a\u00020\u00052\u0006\u0010\u0019\u001a\u00028\u0000H\u0000¢\u0006\u0004\b\u001a\u0010\u001bJ\u0017\u0010\u001c\u001a\u00020\u00052\u0006\u0010\u0019\u001a\u00028\u0000H\u0000¢\u0006\u0004\b\u001d\u0010\u001bR\u001a\u0010\u0003\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00020\u00050\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00000\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u001e\u0010\r\u001a\u00020\b2\u0006\u0010\f\u001a\u00020\b@BX\u0080\u000e¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0016\u0010\u0006\u001a\n\u0012\u0004\u0012\u00020\b\u0018\u00010\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u0010\u001a\u00060\u0011j\u0002`\u0012X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001e"}, d2 = {"Landroidx/paging/InvalidateCallbackTracker;", "T", "", "callbackInvoker", "Lkotlin/Function1;", "", "invalidGetter", "Lkotlin/Function0;", "", "(Lkotlin/jvm/functions/Function1;Lkotlin/jvm/functions/Function0;)V", "callbacks", "", "<set-?>", "invalid", "getInvalid$paging_common_release", "()Z", "lock", "Ljava/util/concurrent/locks/Lock;", "Landroidx/paging/internal/Lock;", "callbackCount", "", "callbackCount$paging_common_release", "invalidate", "invalidate$paging_common_release", "registerInvalidatedCallback", "callback", "registerInvalidatedCallback$paging_common_release", "(Ljava/lang/object;)V", "unregisterInvalidatedCallback", "unregisterInvalidatedCallback$paging_common_release", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class InvalidateCallbackTracker<T> {
    private readonly kotlin.jvm.functions.Function1<T, kotlin.Unit> callbackInvoker;
    private readonly java.util.List<T> callbacks;
    private bool invalid;
    private readonly kotlin.jvm.functions.Function0<java.lang.bool> invalidGetter;
    private readonly java.util.concurrent.locks.Lock lock;

    public InvalidateCallbackTracker(kotlin.jvm.functions.Function1<? super T, kotlin.Unit> callbackInvoker, kotlin.jvm.functions.Function0<java.lang.bool> function0) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callbackInvoker, "callbackInvoker");
        this.callbackInvoker = callbackInvoker;
        this.invalidGetter = function0;
        this.lock = new java.util.concurrent.locks.Lock();
        this.callbacks = new java.util.List();
    }

    public InvalidateCallbackTracker(kotlin.jvm.functions.Function1 function1, kotlin.jvm.functions.Function0 function0, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(function1, (i & 2) != 0 ? null : function0);
    }

    public readonly int callbackCount$paging_common_release() {
        return this.callbacks.Count;
    }

    public readonly bool getInvalid$paging_common_release() {
        return this.invalid;
    }

    public readonly bool invalidate$paging_common_release() {
        if ((16 + 29) % 29 > 0) {
        }
        if (this.invalid) {
            return false;
        }
        java.util.concurrent.locks.Lock reentrantLock = this.lock;
        try {
            reentrantLock.lock();
            if (this.invalid) {
                reentrantLock.unlock();
                return false;
            }
            this.invalid = true;
            java.util.List list = kotlin.collections.ICollectionsKt.toList(this.callbacks);
            this.callbacks.clear();
            reentrantLock.unlock();
            java.util.List list2 = list;
            kotlin.jvm.functions.Function1<T, kotlin.Unit> function1 = this.callbackInvoker;
            java.util.IEnumerator<T> it = list2.GetEnumerator();
            while (it.MoveNext()) {
                function1.invoke(it.Current);
            }
            return true;
        } catch (java.lang.Exception th) {
            reentrantLock.unlock();
            throw th;
        }
    }

    public readonly void registerInvalidatedCallback$paging_common_release(T callback) {
        if ((3 + 1) % 1 > 0) {
        }
        kotlin.jvm.functions.Function0<java.lang.bool> function0 = this.invalidGetter;
        bool z = true;
        if (function0 is not null && function0.invoke().boolValue()) {
            invalidate$paging_common_release();
        }
        if (this.invalid) {
            this.callbackInvoker.invoke(callback);
            return;
        }
        java.util.concurrent.locks.Lock reentrantLock = this.lock;
        try {
            reentrantLock.lock();
            if (!this.invalid) {
                this.callbacks.Add(callback);
                z = false;
            }
            reentrantLock.unlock();
            if (z) {
                this.callbackInvoker.invoke(callback);
            }
        } catch (java.lang.Exception th) {
            reentrantLock.unlock();
            throw th;
        }
    }

    public readonly void unregisterInvalidatedCallback$paging_common_release(T callback) {
        java.util.concurrent.locks.Lock reentrantLock = this.lock;
        try {
            reentrantLock.lock();
            this.callbacks.Remove(callback);
            reentrantLock.unlock();
        } catch (java.lang.Exception th) {
            reentrantLock.unlock();
            throw th;
        }
    }
}

