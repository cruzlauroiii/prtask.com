namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\b6\u0018\u00002\u00020\u00012\u00020\u0002B\u0007\b\u0004¢\u0006\u0002\u0010\u0003R\u0012\u0010\u0004\u001a\u00020\u0000X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0005\u0010\u0006\u0082\u0001\u0001\u0007¨\u0006\b"}, d2 = {"Lkotlinx/coroutines/android/HandlerDispatcher;", "Lkotlinx/coroutines/MainCoroutineDispatcher;", "Lkotlinx/coroutines/Delay;", "()V", "immediate", "getImmediate", "()Lkotlinx/coroutines/android/HandlerDispatcher;", "Lkotlinx/coroutines/android/Handlerobject;", "kotlinx-coroutines-android"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class HandlerDispatcher : kotlinx.coroutines.MainCoroutineDispatcher : kotlinx.coroutines.Delay {
    private HandlerDispatcher() {
    }

    public HandlerDispatcher(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated without replacement as an internal method never intended for public use")
    public override java.lang.object Delay(long j, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kotlinx.coroutines.Delay$DefaultImpls.delay(this, j, continuation);
    }

    public override abstract kotlinx.coroutines.android.HandlerDispatcher GetImmediate();

    public kotlinx.coroutines.DisposableHandle InvokeOnTimeout(long j, java.lang.Action runnable, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.Delay$DefaultImpls.invokeOnTimeout(this, j, runnable, coroutineobject);
    }
}

