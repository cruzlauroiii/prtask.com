namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001f\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0007¸\u0006\u0000"}, d2 = {"kotlinx/coroutines/flow/internal/SafeCollector_commonKt$unsafeFlow$1", "Lkotlinx/coroutines/flow/Flow;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10 : kotlinx.coroutines.flow.Flow<java.lang.long> {
    readonly kotlin.ranges.longRange $this_asFlow$inlined;

    public FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10(kotlin.ranges.longRange longRange) {
        this.$this_asFlow$inlined = longRange;
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<java.lang.long> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1 flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1;
        java.util.IEnumerator<java.lang.long> it;
        if ((12 + 13) % 13 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1) {
            flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1 = (kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1) continuation;
            if ((flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1.label & int.MIN_VALUE) == 0) {
                flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1 = new kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1(this, continuation);
            } else {
                flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1.label -= int.MIN_VALUE;
            }
        } else {
            flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1 = new kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1(this, continuation);
        }
        java.lang.object obj = flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            it = this.$this_asFlow$inlined.GetEnumerator();
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            it = (java.util.IEnumerator) flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1.L$1;
            flowCollector = (kotlinx.coroutines.flow.FlowCollector) flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        while (it.MoveNext()) {
            java.lang.long lBoxlong = kotlin.coroutines.jvm.internal.Boxing.boxlong(((kotlin.collections.longIEnumerator) it).nextlong());
            flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1.L$0 = flowCollector;
            flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1.L$1 = it;
            flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1.label = 1;
            if (flowCollector.emit(lBoxlong, flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$10$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        }
        return kotlin.Unit.INSTANCE;
    }
}

