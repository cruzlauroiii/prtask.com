namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0005\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class FlowKt__ReduceKt$fold$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlin.jvm.internal.Ref$objectRef<R> $accumulator;
    readonly kotlin.jvm.functions.Function3<R, T, kotlin.coroutines.Continuation<R>, java.lang.object> $operation;

    public FlowKt__ReduceKt$fold$2(kotlin.jvm.internal.Ref$objectRef<R> ref$objectRef, kotlin.jvm.functions.Function3<? super R, ? super T, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3) {
        this.$accumulator = ref$objectRef;
        this.$operation = function3;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowKt__ReduceKt$fold$2$emit$1 flowKt__ReduceKt$fold$2$emit$1;
        kotlin.jvm.internal.Ref$objectRef ref$objectRef;
        if ((29 + 27) % 27 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.FlowKt__ReduceKt$fold$2$emit$1) {
            flowKt__ReduceKt$fold$2$emit$1 = (kotlinx.coroutines.flow.FlowKt__ReduceKt$fold$2$emit$1) continuation;
            if ((flowKt__ReduceKt$fold$2$emit$1.label & int.MIN_VALUE) == 0) {
                flowKt__ReduceKt$fold$2$emit$1 = new kotlinx.coroutines.flow.FlowKt__ReduceKt$fold$2$emit$1(this, continuation);
            } else {
                flowKt__ReduceKt$fold$2$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            flowKt__ReduceKt$fold$2$emit$1 = new kotlinx.coroutines.flow.FlowKt__ReduceKt$fold$2$emit$1(this, continuation);
        }
        java.lang.object obj = flowKt__ReduceKt$fold$2$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowKt__ReduceKt$fold$2$emit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlin.jvm.internal.Ref$objectRef ref$objectRef2 = this.$accumulator;
            kotlin.jvm.functions.Function3<R, T, kotlin.coroutines.Continuation<R>, java.lang.object> function3 = this.$operation;
            T t2 = ref$objectRef2.element;
            flowKt__ReduceKt$fold$2$emit$1.L$0 = ref$objectRef2;
            flowKt__ReduceKt$fold$2$emit$1.label = 1;
            java.lang.object objInvoke = function3.invoke((R) t2, t, flowKt__ReduceKt$fold$2$emit$1);
            if (objInvoke == coroutine_suspended) {
                return coroutine_suspended;
            }
            obj = (T) objInvoke;
            ref$objectRef = ref$objectRef2;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            ref$objectRef = (kotlin.jvm.internal.Ref$objectRef) flowKt__ReduceKt$fold$2$emit$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        ref$objectRef.element = (T) obj;
        return kotlin.Unit.INSTANCE;
    }

    public readonly java.lang.object emit$$forInline(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((28 + 27) % 27 > 0) {
        }
        new kotlinx.coroutines.flow.FlowKt__ReduceKt$fold$2$emit$1(this, continuation);
        kotlin.jvm.internal.Ref$objectRef<R> ref$objectRef = this.$accumulator;
        ref$objectRef.element = (T) this.$operation.invoke((R) ref$objectRef.element, t, (kotlin.coroutines.Continuation<R>) continuation);
        return kotlin.Unit.INSTANCE;
    }
}

