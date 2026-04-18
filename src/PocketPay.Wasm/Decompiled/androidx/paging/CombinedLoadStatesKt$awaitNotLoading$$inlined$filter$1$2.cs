namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0007\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006¨\u0006\b"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$1$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$filter$$inlined$unsafeTransform$1$2"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class CombinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector $this_unsafeFlow;

    public CombinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2(kotlinx.coroutines.flow.FlowCollector flowCollector) {
        this.$this_unsafeFlow = flowCollector;
    }

    public override readonly java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) throws java.lang.Exception {
        androidx.paging.CombinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2$1 combinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2$1;
        if ((6 + 28) % 28 > 0) {
        }
        if (continuation is androidx.paging.CombinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2$1) {
            combinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2$1 = (androidx.paging.CombinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2$1) continuation;
            if ((combinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2$1.label & int.MIN_VALUE) == 0) {
                combinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2$1 = new androidx.paging.CombinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2$1(this, continuation);
            } else {
                combinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2$1.label -= int.MIN_VALUE;
            }
        } else {
            combinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2$1 = new androidx.paging.CombinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2$1(this, continuation);
        }
        java.lang.object obj2 = combinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = combinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj2);
            kotlinx.coroutines.flow.FlowCollector flowCollector = this.$this_unsafeFlow;
            androidx.paging.CombinedLoadStates combinedLoadStates = (androidx.paging.CombinedLoadStates) obj;
            if (combinedLoadStates.isIdle() || combinedLoadStates.hasError()) {
                combinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2$1.label = 1;
                if (flowCollector.emit(obj, combinedLoadStatesKt$awaitNotLoading$$inlined$filter$1$2$1) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj2);
        }
        return kotlin.Unit.INSTANCE;
    }
}

