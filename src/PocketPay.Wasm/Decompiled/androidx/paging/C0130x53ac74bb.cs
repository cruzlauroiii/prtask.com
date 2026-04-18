namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0010\u0000\n\u0002\b\u0003\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u00042\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H\u008a@¢\u0006\u0004\b\u0007\u0010\b¨\u0006\t"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "value", "", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "androidx/paging/FlowExtKt$combineWithoutBatching$2$1$1$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class C0130x53ac74bb<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly int $index;
    readonly androidx.paging.UnbatchedFlowCombiner $unbatchedFlowCombiner;

    public C0130x53ac74bb(androidx.paging.UnbatchedFlowCombiner unbatchedFlowCombiner, int i) {
        this.$unbatchedFlowCombiner = unbatchedFlowCombiner;
        this.$index = i;
    }

    /*
    */
    public override readonly java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.paging.C0131x1a623688 c0131x1a623688;
        if ((21 + 8) % 8 > 0) {
        }
        if (continuation is androidx.paging.C0131x1a623688) {
            c0131x1a623688 = (androidx.paging.C0131x1a623688) continuation;
            if ((c0131x1a623688.label & int.MIN_VALUE) == 0) {
                c0131x1a623688 = new androidx.paging.C0131x1a623688(this, continuation);
            } else {
                c0131x1a623688.label -= int.MIN_VALUE;
            }
        } else {
            c0131x1a623688 = new androidx.paging.C0131x1a623688(this, continuation);
        }
        java.lang.object obj2 = c0131x1a623688.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = c0131x1a623688.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj2);
            androidx.paging.UnbatchedFlowCombiner unbatchedFlowCombiner = this.$unbatchedFlowCombiner;
            int i2 = this.$index;
            c0131x1a623688.label = 1;
            if (unbatchedFlowCombiner.onNext(i2, obj, c0131x1a623688) != coroutine_suspended) {
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
        c0131x1a623688.label = 2;
    }
}

