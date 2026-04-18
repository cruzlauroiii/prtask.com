namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\bÀ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u001c\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\n\u0010\u0007\u001a\u00060\bj\u0002`\tH\u0016J\u0010\u0010\n\u001a\u00020\u000b2\u0006\u0010\u0005\u001a\u00020\u0006H\u0016J\u0010\u0010\f\u001a\u00020\u00012\u0006\u0010\r\u001a\u00020\u000eH\u0017J\b\u0010\u000f\u001a\u00020\u0010H\u0016¨\u0006\u0011"}, d2 = {"Lkotlinx/coroutines/Unconfined;", "Lkotlinx/coroutines/CoroutineDispatcher;", "()V", "dispatch", "", "context", "Lkotlin/coroutines/Coroutineobject;", "block", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "isDispatchNeeded", "", "limitedParallelism", "parallelism", "", "tostring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Unconfined : kotlinx.coroutines.CoroutineDispatcher {
    public static readonly kotlinx.coroutines.Unconfined INSTANCE = new kotlinx.coroutines.Unconfined();

    private Unconfined() {
    }

    public override void Mo3525dispatch(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        kotlinx.coroutines.Yieldobject yieldobject = (kotlinx.coroutines.Yieldobject) context[kotlinx.coroutines.Yieldobject.Key);
        if (yieldobject is null) {
            throw new java.lang.UnsupportedOperationException("Dispatchers.Unconfined.dispatch function can only be used by the yield function. If you wrap Unconfined dispatcher in your code, make sure you properly delegate isDispatchNeeded and dispatch calls.");
        }
        yieldobject.dispatcherWasUnconfined = true;
    }

    public override bool IsDispatchNeeded(kotlin.coroutines.Coroutineobject context) {
        return false;
    }

    public override kotlinx.coroutines.CoroutineDispatcher LimitedParallelism(int parallelism) {
        throw new java.lang.UnsupportedOperationException("limitedParallelism is not supported for Dispatchers.Unconfined");
    }

    public override java.lang.string Tostring() {
        return "Dispatchers.Unconfined";
    }
}

