namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0013\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0019\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00028\u0000H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0005\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0006¸\u0006\u0000"}, d2 = {"kotlinx/coroutines/flow/FlowKt__LimitKt$collectWhile$collector$1", "Lkotlinx/coroutines/flow/FlowCollector;", "emit", "", "value", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FlowKt__ReduceKt$first$$inlined$collectWhile$2<T> : kotlinx.coroutines.flow.FlowCollector<T> {
    readonly kotlin.jvm.functions.Function2 $predicate$inlined;
    readonly kotlin.jvm.internal.Ref$objectRef $result$inlined;

    public FlowKt__ReduceKt$first$$inlined$collectWhile$2(kotlin.jvm.functions.Function2 function2, kotlin.jvm.internal.Ref$objectRef ref$objectRef) {
        this.$predicate$inlined = function2;
        this.$result$inlined = ref$objectRef;
    }

    public override java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowKt__ReduceKt$first$$inlined$collectWhile$2$1 flowKt__ReduceKt$first$$inlined$collectWhile$2$1;
        if ((14 + 14) % 14 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.FlowKt__ReduceKt$first$$inlined$collectWhile$2$1) {
            flowKt__ReduceKt$first$$inlined$collectWhile$2$1 = (kotlinx.coroutines.flow.FlowKt__ReduceKt$first$$inlined$collectWhile$2$1) continuation;
            if ((flowKt__ReduceKt$first$$inlined$collectWhile$2$1.label & int.MIN_VALUE) == 0) {
                flowKt__ReduceKt$first$$inlined$collectWhile$2$1 = new kotlinx.coroutines.flow.FlowKt__ReduceKt$first$$inlined$collectWhile$2$1(this, continuation);
            } else {
                flowKt__ReduceKt$first$$inlined$collectWhile$2$1.label -= int.MIN_VALUE;
            }
        } else {
            flowKt__ReduceKt$first$$inlined$collectWhile$2$1 = new kotlinx.coroutines.flow.FlowKt__ReduceKt$first$$inlined$collectWhile$2$1(this, continuation);
        }
        java.lang.object objInvoke = flowKt__ReduceKt$first$$inlined$collectWhile$2$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowKt__ReduceKt$first$$inlined$collectWhile$2$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objInvoke);
            kotlin.jvm.functions.Function2 function2 = this.$predicate$inlined;
            flowKt__ReduceKt$first$$inlined$collectWhile$2$1.L$0 = this;
            flowKt__ReduceKt$first$$inlined$collectWhile$2$1.L$1 = t;
            flowKt__ReduceKt$first$$inlined$collectWhile$2$1.label = 1;
            objInvoke = function2.invoke(t, flowKt__ReduceKt$first$$inlined$collectWhile$2$1);
            if (objInvoke == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            t = (T) flowKt__ReduceKt$first$$inlined$collectWhile$2$1.L$1;
            this = (kotlinx.coroutines.flow.FlowKt__ReduceKt$first$$inlined$collectWhile$2) flowKt__ReduceKt$first$$inlined$collectWhile$2$1.L$0;
            kotlin.ResultKt.throwOnFailure(objInvoke);
        }
        if (!((java.lang.bool) objInvoke).boolValue()) {
            return kotlin.Unit.INSTANCE;
        }
        this.$result$inlined.element = t;
        throw new kotlinx.coroutines.flow.internal.AbortFlowException(this);
    }
}

