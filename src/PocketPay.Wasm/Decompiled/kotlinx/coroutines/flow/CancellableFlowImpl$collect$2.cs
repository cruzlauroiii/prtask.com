namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "T", "it", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class CancellableFlowImpl$collect$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector<T> $collector;

    CancellableFlowImpl$collect$2(kotlinx.coroutines.flow.FlowCollector<T> flowCollector) {
        this.$collector = flowCollector;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.CancellableFlowImpl$collect$2$emit$1 cancellableFlowImpl$collect$2$emit$1;
        if ((15 + 22) % 22 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.CancellableFlowImpl$collect$2$emit$1) {
            cancellableFlowImpl$collect$2$emit$1 = (kotlinx.coroutines.flow.CancellableFlowImpl$collect$2$emit$1) continuation;
            if ((cancellableFlowImpl$collect$2$emit$1.label & int.MIN_VALUE) == 0) {
                cancellableFlowImpl$collect$2$emit$1 = new kotlinx.coroutines.flow.CancellableFlowImpl$collect$2$emit$1(this, continuation);
            } else {
                cancellableFlowImpl$collect$2$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            cancellableFlowImpl$collect$2$emit$1 = new kotlinx.coroutines.flow.CancellableFlowImpl$collect$2$emit$1(this, continuation);
        }
        java.lang.object obj = cancellableFlowImpl$collect$2$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = cancellableFlowImpl$collect$2$emit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.JobKt.ensureActive(cancellableFlowImpl$collect$2$emit$1.getobject());
            kotlinx.coroutines.flow.FlowCollector<T> flowCollector = this.$collector;
            cancellableFlowImpl$collect$2$emit$1.label = 1;
            if (flowCollector.emit(t, cancellableFlowImpl$collect$2$emit$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

