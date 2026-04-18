namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0005\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\b\b\u0001\u0010\u0003*\u0002H\u00022\u0006\u0010\u0004\u001a\u0002H\u0003H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006"}, d2 = {"<anonymous>", "", "S", "T", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class FlowKt__ReduceKt$reduce$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlin.jvm.internal.Ref$objectRef<java.lang.object> $accumulator;
    readonly kotlin.jvm.functions.Function3<S, T, kotlin.coroutines.Continuation<S>, java.lang.object> $operation;

    FlowKt__ReduceKt$reduce$2(kotlin.jvm.internal.Ref$objectRef<java.lang.object> ref$objectRef, kotlin.jvm.functions.Function3<? super S, ? super T, ? super kotlin.coroutines.Continuation<S>, ? : java.lang.object> function3) {
        this.$accumulator = ref$objectRef;
        this.$operation = function3;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowKt__ReduceKt$reduce$2$emit$1 flowKt__ReduceKt$reduce$2$emit$1;
        kotlin.jvm.internal.Ref$objectRef<java.lang.object> ref$objectRef;
        java.lang.object obj;
        kotlin.jvm.internal.Ref$objectRef<java.lang.object> ref$objectRef2;
        java.lang.object obj2;
        if ((1 + 1) % 1 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.FlowKt__ReduceKt$reduce$2$emit$1) {
            flowKt__ReduceKt$reduce$2$emit$1 = (kotlinx.coroutines.flow.FlowKt__ReduceKt$reduce$2$emit$1) continuation;
            if ((flowKt__ReduceKt$reduce$2$emit$1.label & int.MIN_VALUE) == 0) {
                flowKt__ReduceKt$reduce$2$emit$1 = new kotlinx.coroutines.flow.FlowKt__ReduceKt$reduce$2$emit$1(this, continuation);
            } else {
                flowKt__ReduceKt$reduce$2$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            flowKt__ReduceKt$reduce$2$emit$1 = new kotlinx.coroutines.flow.FlowKt__ReduceKt$reduce$2$emit$1(this, continuation);
        }
        java.lang.object obj3 = flowKt__ReduceKt$reduce$2$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowKt__ReduceKt$reduce$2$emit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj3);
            ref$objectRef = this.$accumulator;
            obj2 = t;
            if (ref$objectRef.element != kotlinx.coroutines.flow.internal.NullSurrogateKt.NULL) {
                kotlin.jvm.functions.Function3<S, T, kotlin.coroutines.Continuation<S>, java.lang.object> function3 = this.$operation;
                java.lang.object obj4 = this.$accumulator.element;
                flowKt__ReduceKt$reduce$2$emit$1.L$0 = ref$objectRef;
                flowKt__ReduceKt$reduce$2$emit$1.label = 1;
                java.lang.object objInvoke = function3.invoke((S) obj4, t, flowKt__ReduceKt$reduce$2$emit$1);
                if (objInvoke == coroutine_suspended) {
                    return coroutine_suspended;
                }
                obj = objInvoke;
                ref$objectRef2 = ref$objectRef;
            }
            ref$objectRef.element = (T) obj2;
            return kotlin.Unit.INSTANCE;
        }
        if (i != 1) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        ref$objectRef2 = (kotlin.jvm.internal.Ref$objectRef) flowKt__ReduceKt$reduce$2$emit$1.L$0;
        kotlin.ResultKt.throwOnFailure(obj3);
        obj = (T) obj3;
        ref$objectRef = ref$objectRef2;
        obj2 = obj;
        ref$objectRef.element = (T) obj2;
        return kotlin.Unit.INSTANCE;
    }
}

