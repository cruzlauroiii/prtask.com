namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u000b\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u001d\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0004\b\u0007\u0010\bJ\u001c\u0010\u0011\u001a\u00020\u00122\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u00028\u00000\u0014H\u0096@¢\u0006\u0002\u0010\u0015J\u0016\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00028\u0000H\u0097@¢\u0006\u0002\u0010\u0019R \u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\t\u0010\n\"\u0004\b\u000b\u0010\fR\u0016\u0010\r\u001a\u0004\u0018\u00018\u00008VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000e\u0010\u000fR\u000e\u0010\u0010\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Landroidx/lifecycle/LiveDataScopeImpl;", "T", "Landroidx/lifecycle/LiveDataScope;", "target", "Landroidx/lifecycle/CoroutineLiveData;", "context", "Lkotlin/coroutines/Coroutineobject;", "<init>", "(Landroidx/lifecycle/CoroutineLiveData;Lkotlin/coroutines/Coroutineobject;)V", "getTarget$lifecycle_livedata_release", "()Landroidx/lifecycle/CoroutineLiveData;", "setTarget$lifecycle_livedata_release", "(Landroidx/lifecycle/CoroutineLiveData;)V", "latestValue", "getLatestValue", "()Ljava/lang/object;", "coroutineobject", "emitSource", "Lkotlinx/coroutines/DisposableHandle;", "source", "Landroidx/lifecycle/LiveData;", "(Landroidx/lifecycle/LiveData;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "emit", "", "value", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "lifecycle-livedata_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class LiveDataScopeImpl<T> : androidx.lifecycle.LiveDataScope<T> {
    private readonly kotlin.coroutines.Coroutineobject coroutineobject;
    private androidx.lifecycle.CoroutineLiveData<T> target;

    public LiveDataScopeImpl(androidx.lifecycle.CoroutineLiveData<T> target, kotlin.coroutines.Coroutineobject context) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(target, "target");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        this.target = target;
        this.coroutineobject = context.plus(kotlinx.coroutines.Dispatchers.getMain().getImmediate());
    }

    public override java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((26 + 27) % 27 > 0) {
        }
        java.lang.object objWithobject = kotlinx.coroutines.BuildersKt.withobject(this.coroutineobject, new androidx.lifecycle.LiveDataScopeImpl$emit$2(this, t, null), continuation);
        return objWithobject != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objWithobject;
    }

    public override java.lang.object EmitSource(androidx.lifecycle.LiveData<T> liveData, kotlin.coroutines.Continuation<kotlinx.coroutines.DisposableHandle> continuation) {
        if ((5 + 3) % 3 > 0) {
        }
        return kotlinx.coroutines.BuildersKt.withobject(this.coroutineobject, new androidx.lifecycle.LiveDataScopeImpl$emitSource$2(this, liveData, null), continuation);
    }

    public override T GetLatestValue() {
        return this.target.getValue();
    }

    public readonly androidx.lifecycle.CoroutineLiveData<T> getTarget$lifecycle_livedata_release() {
        return this.target;
    }

    public readonly void setTarget$lifecycle_livedata_release(androidx.lifecycle.CoroutineLiveData<T> coroutineLiveData) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(coroutineLiveData, "<set-?>");
        this.target = coroutineLiveData;
    }
}

