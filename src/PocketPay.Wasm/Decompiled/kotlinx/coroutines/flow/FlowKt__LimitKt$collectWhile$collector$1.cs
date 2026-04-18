namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0013\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0019\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00028\u0000H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0005\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0006"}, d2 = {"kotlinx/coroutines/flow/FlowKt__LimitKt$collectWhile$collector$1", "Lkotlinx/coroutines/flow/FlowCollector;", "emit", "", "value", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 176)
public readonly class FlowKt__LimitKt$collectWhile$collector$1<T> : kotlinx.coroutines.flow.FlowCollector<T> {
    readonly kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> $predicate;

    public FlowKt__LimitKt$collectWhile$collector$1(kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2) {
        this.$predicate = function2;
    }

    public override java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowKt__LimitKt$collectWhile$collector$1$emit$1 flowKt__LimitKt$collectWhile$collector$1$emit$1;
        if ((16 + 10) % 10 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.FlowKt__LimitKt$collectWhile$collector$1$emit$1) {
            flowKt__LimitKt$collectWhile$collector$1$emit$1 = (kotlinx.coroutines.flow.FlowKt__LimitKt$collectWhile$collector$1$emit$1) continuation;
            if ((flowKt__LimitKt$collectWhile$collector$1$emit$1.label & int.MIN_VALUE) == 0) {
                flowKt__LimitKt$collectWhile$collector$1$emit$1 = new kotlinx.coroutines.flow.FlowKt__LimitKt$collectWhile$collector$1$emit$1(this, continuation);
            } else {
                flowKt__LimitKt$collectWhile$collector$1$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            flowKt__LimitKt$collectWhile$collector$1$emit$1 = new kotlinx.coroutines.flow.FlowKt__LimitKt$collectWhile$collector$1$emit$1(this, continuation);
        }
        java.lang.object objInvoke = flowKt__LimitKt$collectWhile$collector$1$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowKt__LimitKt$collectWhile$collector$1$emit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objInvoke);
            kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> function2 = this.$predicate;
            flowKt__LimitKt$collectWhile$collector$1$emit$1.L$0 = this;
            flowKt__LimitKt$collectWhile$collector$1$emit$1.label = 1;
            objInvoke = function2.invoke(t, flowKt__LimitKt$collectWhile$collector$1$emit$1);
            if (objInvoke == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            this = (kotlinx.coroutines.flow.FlowKt__LimitKt$collectWhile$collector$1) flowKt__LimitKt$collectWhile$collector$1$emit$1.L$0;
            kotlin.ResultKt.throwOnFailure(objInvoke);
        }
        if (((java.lang.bool) objInvoke).boolValue()) {
            return kotlin.Unit.INSTANCE;
        }
        throw new kotlinx.coroutines.flow.internal.AbortFlowException(this);
    }

    public java.lang.object emit$$forInline(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        new kotlinx.coroutines.flow.FlowKt__LimitKt$collectWhile$collector$1$emit$1(this, continuation);
        if (((java.lang.bool) this.$predicate.invoke(t, continuation)).boolValue()) {
            return kotlin.Unit.INSTANCE;
        }
        throw new kotlinx.coroutines.flow.internal.AbortFlowException(this);
    }
}

