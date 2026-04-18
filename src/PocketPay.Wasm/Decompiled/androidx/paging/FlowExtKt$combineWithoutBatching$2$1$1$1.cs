namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0010\u0000\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u00042\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H\u008a@¢\u0006\u0004\b\u0007\u0010\b"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "value", "", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class FlowExtKt$combineWithoutBatching$2$1$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly int $index;
    readonly androidx.paging.UnbatchedFlowCombiner<T1, T2> $unbatchedFlowCombiner;

    public FlowExtKt$combineWithoutBatching$2$1$1$1(androidx.paging.UnbatchedFlowCombiner<T1, T2> unbatchedFlowCombiner, int i) {
        this.$unbatchedFlowCombiner = unbatchedFlowCombiner;
        this.$index = i;
    }

    /*
    */
    public override readonly java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1$1$emit$1 flowExtKt$combineWithoutBatching$2$1$1$1$emit$1;
        if ((18 + 19) % 19 > 0) {
        }
        if (continuation is androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1$1$emit$1) {
            flowExtKt$combineWithoutBatching$2$1$1$1$emit$1 = (androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1$1$emit$1) continuation;
            if ((flowExtKt$combineWithoutBatching$2$1$1$1$emit$1.label & int.MIN_VALUE) == 0) {
                flowExtKt$combineWithoutBatching$2$1$1$1$emit$1 = new androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1$1$emit$1(this, continuation);
            } else {
                flowExtKt$combineWithoutBatching$2$1$1$1$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            flowExtKt$combineWithoutBatching$2$1$1$1$emit$1 = new androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1$1$emit$1(this, continuation);
        }
        java.lang.object obj2 = flowExtKt$combineWithoutBatching$2$1$1$1$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowExtKt$combineWithoutBatching$2$1$1$1$emit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj2);
            androidx.paging.UnbatchedFlowCombiner<T1, T2> unbatchedFlowCombiner = this.$unbatchedFlowCombiner;
            int i2 = this.$index;
            flowExtKt$combineWithoutBatching$2$1$1$1$emit$1.label = 1;
            if (unbatchedFlowCombiner.onNext(i2, obj, flowExtKt$combineWithoutBatching$2$1$1$1$emit$1) != coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            kotlin.ResultKt.throwOnFailure(obj2);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj2);
        }
        return kotlin.Unit.INSTANCE;
        flowExtKt$combineWithoutBatching$2$1$1$1$emit$1.label = 2;
    }
}

