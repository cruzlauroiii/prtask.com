namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001f\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0007¸\u0006\u0000"}, d2 = {"kotlinx/coroutines/flow/internal/SafeCollector_commonKt$unsafeFlow$1", "Lkotlinx/coroutines/flow/Flow;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FlowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1<T> : kotlinx.coroutines.flow.Flow<T> {
    readonly kotlin.jvm.functions.Function2 $predicate$inlined;
    readonly kotlinx.coroutines.flow.Flow $this_takeWhile$inlined;

    public FlowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1(kotlinx.coroutines.flow.Flow flow, kotlin.jvm.functions.Function2 function2) {
        this.$this_takeWhile$inlined = flow;
        this.$predicate$inlined = function2;
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1 flowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1;
        kotlinx.coroutines.flow.FlowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1 flowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1;
        if ((31 + 19) % 19 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.FlowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1) {
            flowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1 = (kotlinx.coroutines.flow.FlowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1) continuation;
            if ((flowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1.label & int.MIN_VALUE) == 0) {
                flowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1 = new kotlinx.coroutines.flow.FlowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1(this, continuation);
            } else {
                flowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1.label -= int.MIN_VALUE;
            }
        } else {
            flowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1 = new kotlinx.coroutines.flow.FlowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1(this, continuation);
        }
        java.lang.object obj = flowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.Flow flow = this.$this_takeWhile$inlined;
            kotlinx.coroutines.flow.FlowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1 flowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$12 = new kotlinx.coroutines.flow.FlowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1(this.$predicate$inlined, flowCollector);
            try {
                flowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1.L$0 = flowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$12;
                flowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1.label = 1;
                if (flow.collect(flowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$12, flowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } catch (kotlinx.coroutines.flow.internal.AbortFlowException e) {
                e = e;
                flowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1 = flowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$12;
                kotlinx.coroutines.flow.internal.FlowExceptions_commonKt.checkOwnership(e, flowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1);
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            flowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1 = (kotlinx.coroutines.flow.FlowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1) flowKt__LimitKt$takeWhile$$inlined$unsafeFlow$1$1.L$0;
            try {
                kotlin.ResultKt.throwOnFailure(obj);
            } catch (kotlinx.coroutines.flow.internal.AbortFlowException e2) {
                e = e2;
                kotlinx.coroutines.flow.internal.FlowExceptions_commonKt.checkOwnership(e, flowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1);
            }
        }
        return kotlin.Unit.INSTANCE;
    }
}

