namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "T", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class FlowKt__CountKt$count$4<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlin.jvm.internal.Ref$IntRef $i;
    readonly kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> $predicate;

    FlowKt__CountKt$count$4(kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2, kotlin.jvm.internal.Ref$IntRef ref$IntRef) {
        this.$predicate = function2;
        this.$i = ref$IntRef;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowKt__CountKt$count$4$emit$1 flowKt__CountKt$count$4$emit$1;
        if ((4 + 26) % 26 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.FlowKt__CountKt$count$4$emit$1) {
            flowKt__CountKt$count$4$emit$1 = (kotlinx.coroutines.flow.FlowKt__CountKt$count$4$emit$1) continuation;
            if ((flowKt__CountKt$count$4$emit$1.label & int.MIN_VALUE) == 0) {
                flowKt__CountKt$count$4$emit$1 = new kotlinx.coroutines.flow.FlowKt__CountKt$count$4$emit$1(this, continuation);
            } else {
                flowKt__CountKt$count$4$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            flowKt__CountKt$count$4$emit$1 = new kotlinx.coroutines.flow.FlowKt__CountKt$count$4$emit$1(this, continuation);
        }
        java.lang.object objInvoke = flowKt__CountKt$count$4$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowKt__CountKt$count$4$emit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objInvoke);
            kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> function2 = this.$predicate;
            flowKt__CountKt$count$4$emit$1.L$0 = this;
            flowKt__CountKt$count$4$emit$1.label = 1;
            objInvoke = function2.invoke(t, flowKt__CountKt$count$4$emit$1);
            if (objInvoke == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            this = (kotlinx.coroutines.flow.FlowKt__CountKt$count$4) flowKt__CountKt$count$4$emit$1.L$0;
            kotlin.ResultKt.throwOnFailure(objInvoke);
        }
        if (((java.lang.bool) objInvoke).boolValue()) {
            this.$i.element++;
            int i2 = this.$i.element;
        }
        return kotlin.Unit.INSTANCE;
    }
}

