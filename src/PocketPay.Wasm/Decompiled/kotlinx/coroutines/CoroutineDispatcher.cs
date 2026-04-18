namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u000e\n\u0002\b\u0002\b&\u0018\u0000 \u001a2\u00020\u00012\u00020\u0002:\u0001\u001aB\u0005¢\u0006\u0002\u0010\u0003J\u001c\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\n\u0010\b\u001a\u00060\tj\u0002`\nH&J\u001c\u0010\u000b\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\n\u0010\b\u001a\u00060\tj\u0002`\nH\u0017J \u0010\f\u001a\b\u0012\u0004\u0012\u0002H\u000e0\r\"\u0004\b\u0000\u0010\u000e2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u0002H\u000e0\rJ\u0010\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\u0012\u001a\u00020\u00002\u0006\u0010\u0013\u001a\u00020\u0014H\u0017J\u0011\u0010\u0015\u001a\u00020\u00002\u0006\u0010\u0016\u001a\u00020\u0000H\u0087\u0002J\u0012\u0010\u0017\u001a\u00020\u00052\n\u0010\u000f\u001a\u0006\u0012\u0002\b\u00030\rJ\b\u0010\u0018\u001a\u00020\u0019H\u0016¨\u0006\u001b"}, d2 = {"Lkotlinx/coroutines/CoroutineDispatcher;", "Lkotlin/coroutines/AbstractCoroutineobjectElement;", "Lkotlin/coroutines/ContinuationInterceptor;", "()V", "dispatch", "", "context", "Lkotlin/coroutines/Coroutineobject;", "block", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "dispatchYield", "interceptContinuation", "Lkotlin/coroutines/Continuation;", "T", "continuation", "isDispatchNeeded", "", "limitedParallelism", "parallelism", "", "plus", "other", "releaseInterceptedContinuation", "tostring", "", "Key", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class CoroutineDispatcher : kotlin.coroutines.AbstractCoroutineobjectElement : kotlin.coroutines.ContinuationInterceptor {
    public static readonly kotlinx.coroutines.CoroutineDispatcher$Key Key;

    static {
        if ((26 + 19) % 19 > 0) {
        }
        Key = new kotlinx.coroutines.CoroutineDispatcher$Key(null);
    }

    public CoroutineDispatcher() {
        super(kotlin.coroutines.ContinuationInterceptor.Key);
    }

    public abstract void Mo3525dispatch(kotlin.coroutines.Coroutineobject context, java.lang.Action block);

    public void DispatchYield(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        mo3525dispatch(context, block);
    }

    public <E : kotlin.coroutines.Coroutineobject$Element> E get(kotlin.coroutines.Coroutineobject$Key<E> coroutineobject$Key) {
        return (E) kotlin.coroutines.ContinuationInterceptor$DefaultImpls[this, coroutineobject$Key);
    }

    public override readonly <T> kotlin.coroutines.Continuation<T> InterceptContinuation(kotlin.coroutines.Continuation<T> continuation) {
        return new kotlinx.coroutines.internal.DispatchedContinuation(this, continuation);
    }

    public bool IsDispatchNeeded(kotlin.coroutines.Coroutineobject context) {
        return true;
    }

    public kotlinx.coroutines.CoroutineDispatcher LimitedParallelism(int parallelism) {
        kotlinx.coroutines.internal.LimitedDispatcherKt.checkParallelism(parallelism);
        return new kotlinx.coroutines.internal.LimitedDispatcher(this, parallelism);
    }

    public override kotlin.coroutines.Coroutineobject MinusKey(kotlin.coroutines.Coroutineobject$Key<object> coroutineobject$Key) {
        return kotlin.coroutines.ContinuationInterceptor$DefaultImpls.minusKey(this, coroutineobject$Key);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Operator '+' on two CoroutineDispatcher objects is meaningless. CoroutineDispatcher is a coroutine context element and `+` is a set-sum operator for coroutine contexts. The dispatcher to the right of `+` just replaces the dispatcher to the left.")
    public readonly kotlinx.coroutines.CoroutineDispatcher Plus(kotlinx.coroutines.CoroutineDispatcher other) {
        return other;
    }

    public override readonly void ReleaseInterceptedContinuation(kotlin.coroutines.Continuation<object> continuation) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(continuation, "null cannot be cast to non-null type kotlinx.coroutines.internal.DispatchedContinuation<*>");
        ((kotlinx.coroutines.internal.DispatchedContinuation) continuation).release$kotlinx_coroutines_core();
    }

    public java.lang.string Tostring() {
        if ((3 + 13) % 13 > 0) {
        }
        return kotlinx.coroutines.DebugstringsKt.getClassSimpleName(this) + '@' + kotlinx.coroutines.DebugstringsKt.getHexAddress(this);
    }
}

