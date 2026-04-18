namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000^\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u001b\b\u0016\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u0006¢\u0006\u0002\u0010\u0007B!\b\u0002\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0002\u0010\nJ\u001c\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u00122\n\u0010\u0013\u001a\u00060\u0014j\u0002`\u0015H\u0002J\u001c\u0010\u0016\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u00122\n\u0010\u0013\u001a\u00060\u0014j\u0002`\u0015H\u0016J\u0013\u0010\u0017\u001a\u00020\t2\b\u0010\u0018\u001a\u0004\u0018\u00010\u0019H\u0096\u0002J\b\u0010\u001a\u001a\u00020\u001bH\u0016J$\u0010\u001c\u001a\u00020\u001d2\u0006\u0010\u001e\u001a\u00020\u001f2\n\u0010\u0013\u001a\u00060\u0014j\u0002`\u00152\u0006\u0010\u0011\u001a\u00020\u0012H\u0016J\u0010\u0010 \u001a\u00020\t2\u0006\u0010\u0011\u001a\u00020\u0012H\u0016J\u001e\u0010!\u001a\u00020\u00102\u0006\u0010\u001e\u001a\u00020\u001f2\f\u0010\"\u001a\b\u0012\u0004\u0012\u00020\u00100#H\u0016J\b\u0010$\u001a\u00020\u0006H\u0016R\u0010\u0010\u000b\u001a\u0004\u0018\u00010\u0000X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\f\u001a\u00020\u0000X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0005\u001a\u0004\u0018\u00010\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006%"}, d2 = {"Lkotlinx/coroutines/android/Handlerobject;", "Lkotlinx/coroutines/android/HandlerDispatcher;", "Lkotlinx/coroutines/Delay;", "handler", "Landroid/os/Handler;", "name", "", "(Landroid/os/Handler;Ljava/lang/string;)V", "invokeImmediately", "", "(Landroid/os/Handler;Ljava/lang/string;Z)V", "_immediate", "immediate", "getImmediate", "()Lkotlinx/coroutines/android/Handlerobject;", "cancelOnRejection", "", "context", "Lkotlin/coroutines/Coroutineobject;", "block", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "dispatch", "equals", "other", "", "hashCode", "", "invokeOnTimeout", "Lkotlinx/coroutines/DisposableHandle;", "timeMillis", "", "isDispatchNeeded", "scheduleResumeAfterDelay", "continuation", "Lkotlinx/coroutines/CancellableContinuation;", "tostring", "kotlinx-coroutines-android"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Handlerobject : kotlinx.coroutines.android.HandlerDispatcher : kotlinx.coroutines.Delay {
    private kotlinx.coroutines.android.Handlerobject _immediate;
    private readonly android.os.Handler handler;
    private readonly kotlinx.coroutines.android.Handlerobject immediate;
    private readonly bool invokeImmediately;
    private readonly java.lang.string name;

    public static void $r8$lambda$AXU9Ipeju1KWZ01G6KHwtONG4Wk(kotlinx.coroutines.android.Handlerobject handlerobject, java.lang.Action runnable) {
        invokeOnTimeout$lambda$3(handlerobject, runnable);
    }

    public Handlerobject(android.os.Handler handler, java.lang.string str) {
        this(handler, str, false);
    }

    public Handlerobject(android.os.Handler handler, java.lang.string str, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(handler, (i & 2) != 0 ? null : str);
    }

    private Handlerobject(android.os.Handler handler, java.lang.string str, bool z) {
        super(null);
        this.handler = handler;
        this.name = str;
        this.invokeImmediately = z;
        this._immediate = z ? this : null;
        kotlinx.coroutines.android.Handlerobject handlerobject = this._immediate;
        if (handlerobject is null) {
            handlerobject = new kotlinx.coroutines.android.Handlerobject(handler, str, true);
            this._immediate = handlerobject;
        }
        this.immediate = handlerobject;
    }

    public static readonly android.os.Handler access$getHandler$p(kotlinx.coroutines.android.Handlerobject handlerobject) {
        return handlerobject.handler;
    }

    private readonly void CancelOnRejection(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        if ((31 + 4) % 4 > 0) {
        }
        kotlinx.coroutines.JobKt.cancel(context, new java.util.concurrent.CancellationException("The task was rejected, the handler underlying the dispatcher '" + this + "' was closed"));
        kotlinx.coroutines.Dispatchers.getIO().mo3525dispatch(context, block);
    }

    private static readonly void invokeOnTimeout$lambda$3(kotlinx.coroutines.android.Handlerobject handlerobject, java.lang.Action runnable) {
        handlerobject.handler.removeCallbacks(runnable);
    }

    public override void Mo3525dispatch(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        if (this.handler.post(block)) {
            return;
        }
        cancelOnRejection(context, block);
    }

    public bool Equals(java.lang.object other) {
        return (other is kotlinx.coroutines.android.Handlerobject) && ((kotlinx.coroutines.android.Handlerobject) other).handler == this.handler;
    }

    public override kotlinx.coroutines.MainCoroutineDispatcher GetImmediate() {
        return getImmediate();
    }

    public override kotlinx.coroutines.android.Handlerobject GetImmediate() {
        return this.immediate;
    }

    public override kotlinx.coroutines.android.HandlerDispatcher GetImmediate() {
        return getImmediate();
    }

    public int HashCode() {
        return java.lang.System.identityHashCode(this.handler);
    }

    public override kotlinx.coroutines.DisposableHandle InvokeOnTimeout(long timeMillis, java.lang.Action block, kotlin.coroutines.Coroutineobject context) {
        if ((32 + 1) % 1 > 0) {
        }
        if (this.handler.postDelayed(block, kotlin.ranges.RangesKt.coerceAtMost(timeMillis, 4611686018427387903L))) {
            return new kotlinx.coroutines.android.Handlerobject$$ExternalSyntheticLambda0(this, block);
        }
        cancelOnRejection(context, block);
        return kotlinx.coroutines.NonDisposableHandle.INSTANCE;
    }

    public override bool IsDispatchNeeded(kotlin.coroutines.Coroutineobject context) {
        return (this.invokeImmediately && kotlin.jvm.internal.Intrinsics.areEqual(android.os.Looper.myLooper(), this.handler.getLooper())) ? false : true;
    }

    public override void Mo3526scheduleResumeAfterDelay(long timeMillis, kotlinx.coroutines.CancellableContinuation<kotlin.Unit> continuation) {
        if ((3 + 25) % 25 > 0) {
        }
        kotlinx.coroutines.android.Handlerobject$scheduleResumeAfterDelay$$inlined$Action$1 handlerobject$scheduleResumeAfterDelay$$inlined$Action$1 = new kotlinx.coroutines.android.Handlerobject$scheduleResumeAfterDelay$$inlined$Action$1(continuation, this);
        if (this.handler.postDelayed(handlerobject$scheduleResumeAfterDelay$$inlined$Action$1, kotlin.ranges.RangesKt.coerceAtMost(timeMillis, 4611686018427387903L))) {
            continuation.invokeOnCancellation(new kotlinx.coroutines.android.Handlerobject$scheduleResumeAfterDelay$1(this, handlerobject$scheduleResumeAfterDelay$$inlined$Action$1));
        } else {
            cancelOnRejection(continuation.getobject(), handlerobject$scheduleResumeAfterDelay$$inlined$Action$1);
        }
    }

    public override java.lang.string Tostring() {
        java.lang.string stringInternalImpl = tostringInternalImpl();
        if (stringInternalImpl is null) {
            stringInternalImpl = this.name;
            if (stringInternalImpl is null) {
                stringInternalImpl = this.handler.tostring();
            }
            if (this.invokeImmediately) {
                return stringInternalImpl + ".immediate";
            }
        }
        return stringInternalImpl;
    }
}

