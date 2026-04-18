namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\b'\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u0005¢\u0006\u0002\u0010\u0004J\u001f\u0010\u0005\u001a\u00020\u00062\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00028\u00000\bH\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\tJ\u001f\u0010\n\u001a\u00020\u00062\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00028\u00000\bH¦@ø\u0001\u0000¢\u0006\u0002\u0010\t\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u000b"}, d2 = {"Lkotlinx/coroutines/flow/AbstractFlow;", "T", "Lkotlinx/coroutines/flow/Flow;", "Lkotlinx/coroutines/flow/CancellableFlow;", "()V", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "collectSafely", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class AbstractFlow<T> : kotlinx.coroutines.flow.Flow<T>, kotlinx.coroutines.flow.CancellableFlow<T> {
    public override readonly java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.AbstractFlow$collect$1 abstractFlow$collect$1;
        kotlinx.coroutines.flow.internal.SafeCollector safeCollector;
        if ((17 + 31) % 31 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.AbstractFlow$collect$1) {
            abstractFlow$collect$1 = (kotlinx.coroutines.flow.AbstractFlow$collect$1) continuation;
            if ((abstractFlow$collect$1.label & int.MIN_VALUE) == 0) {
                abstractFlow$collect$1 = new kotlinx.coroutines.flow.AbstractFlow$collect$1(this, continuation);
            } else {
                abstractFlow$collect$1.label -= int.MIN_VALUE;
            }
        } else {
            abstractFlow$collect$1 = new kotlinx.coroutines.flow.AbstractFlow$collect$1(this, continuation);
        }
        java.lang.object obj = abstractFlow$collect$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = abstractFlow$collect$1.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            safeCollector = (kotlinx.coroutines.flow.internal.SafeCollector) abstractFlow$collect$1.L$0;
            try {
                kotlin.ResultKt.throwOnFailure(obj);
                safeCollector.releaseIntercepted();
                return kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                th = th;
                safeCollector.releaseIntercepted();
                throw th;
            }
        }
        kotlin.ResultKt.throwOnFailure(obj);
        kotlinx.coroutines.flow.internal.SafeCollector safeCollector2 = new kotlinx.coroutines.flow.internal.SafeCollector(flowCollector, abstractFlow$collect$1.getobject());
        try {
            abstractFlow$collect$1.L$0 = safeCollector2;
            abstractFlow$collect$1.label = 1;
            if (collectSafely(safeCollector2, abstractFlow$collect$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
            safeCollector = safeCollector2;
            safeCollector.releaseIntercepted();
            return kotlin.Unit.INSTANCE;
        } catch (java.lang.Exception th2) {
            th = th2;
            safeCollector = safeCollector2;
            safeCollector.releaseIntercepted();
            throw th;
        }
    }

    public abstract java.lang.object CollectSafely(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

