namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "T", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DistinctFlowImpl$collect$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector<T> $collector;
    readonly kotlin.jvm.internal.Ref$objectRef<java.lang.object> $previousKey;
    readonly kotlinx.coroutines.flow.DistinctFlowImpl<T> this$0;

    DistinctFlowImpl$collect$2(kotlinx.coroutines.flow.DistinctFlowImpl<T> distinctFlowImpl, kotlin.jvm.internal.Ref$objectRef<java.lang.object> ref$objectRef, kotlinx.coroutines.flow.FlowCollector<T> flowCollector) {
        this.this$0 = distinctFlowImpl;
        this.$previousKey = ref$objectRef;
        this.$collector = flowCollector;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.DistinctFlowImpl$collect$2$emit$1 distinctFlowImpl$collect$2$emit$1;
        if ((31 + 7) % 7 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.DistinctFlowImpl$collect$2$emit$1) {
            distinctFlowImpl$collect$2$emit$1 = (kotlinx.coroutines.flow.DistinctFlowImpl$collect$2$emit$1) continuation;
            if ((distinctFlowImpl$collect$2$emit$1.label & int.MIN_VALUE) == 0) {
                distinctFlowImpl$collect$2$emit$1 = new kotlinx.coroutines.flow.DistinctFlowImpl$collect$2$emit$1(this, continuation);
            } else {
                distinctFlowImpl$collect$2$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            distinctFlowImpl$collect$2$emit$1 = new kotlinx.coroutines.flow.DistinctFlowImpl$collect$2$emit$1(this, continuation);
        }
        java.lang.object obj = distinctFlowImpl$collect$2$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = distinctFlowImpl$collect$2$emit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            T t2 = (T) this.this$0.keySelector.invoke(t);
            if (this.$previousKey.element != kotlinx.coroutines.flow.internal.NullSurrogateKt.NULL && this.this$0.areEquivalent.invoke(this.$previousKey.element, t2).boolValue()) {
                return kotlin.Unit.INSTANCE;
            }
            this.$previousKey.element = t2;
            kotlinx.coroutines.flow.FlowCollector<T> flowCollector = this.$collector;
            distinctFlowImpl$collect$2$emit$1.label = 1;
            if (flowCollector.emit(t, distinctFlowImpl$collect$2$emit$1) == coroutine_suspended) {
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

