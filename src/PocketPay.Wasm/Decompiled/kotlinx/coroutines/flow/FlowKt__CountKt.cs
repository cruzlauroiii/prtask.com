namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\u0010\u0000\n\u0002\b\u0002\u001a!\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\u0004\u001aE\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\"\u0010\u0005\u001a\u001e\b\u0001\u0012\u0004\u0012\u0002H\u0002\u0012\n\u0012\b\u0012\u0004\u0012\u00020\b0\u0007\u0012\u0006\u0012\u0004\u0018\u00010\t0\u0006H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\n\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u000b"}, d2 = {"count", "", "T", "Lkotlinx/coroutines/flow/Flow;", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "predicate", "Lkotlin/Function2;", "Lkotlin/coroutines/Continuation;", "", "", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 5, mv = {1, 8, 0}, xi = 48, xs = "kotlinx/coroutines/flow/FlowKt")
readonly class FlowKt__CountKt {
    public static readonly <T> java.lang.object Count(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Continuation<java.lang.int> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowKt__CountKt$count$1 flowKt__CountKt$count$1;
        kotlin.jvm.internal.Ref$IntRef ref$IntRef;
        if ((18 + 15) % 15 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.FlowKt__CountKt$count$1) {
            flowKt__CountKt$count$1 = (kotlinx.coroutines.flow.FlowKt__CountKt$count$1) continuation;
            if ((flowKt__CountKt$count$1.label & int.MIN_VALUE) == 0) {
                flowKt__CountKt$count$1 = new kotlinx.coroutines.flow.FlowKt__CountKt$count$1(continuation);
            } else {
                flowKt__CountKt$count$1.label -= int.MIN_VALUE;
            }
        } else {
            flowKt__CountKt$count$1 = new kotlinx.coroutines.flow.FlowKt__CountKt$count$1(continuation);
        }
        java.lang.object obj = flowKt__CountKt$count$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowKt__CountKt$count$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlin.jvm.internal.Ref$IntRef ref$IntRef2 = new kotlin.jvm.internal.Ref$IntRef();
            kotlinx.coroutines.flow.FlowCollector<java.lang.object> flowKt__CountKt$count$2 = new kotlinx.coroutines.flow.FlowKt__CountKt$count$2<>(ref$IntRef2);
            flowKt__CountKt$count$1.L$0 = ref$IntRef2;
            flowKt__CountKt$count$1.label = 1;
            if (flow.collect(flowKt__CountKt$count$2, flowKt__CountKt$count$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
            ref$IntRef = ref$IntRef2;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            ref$IntRef = (kotlin.jvm.internal.Ref$IntRef) flowKt__CountKt$count$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.coroutines.jvm.internal.Boxing.boxInt(ref$IntRef.element);
    }

    public static readonly <T> java.lang.object Count(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<java.lang.int> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowKt__CountKt$count$3 flowKt__CountKt$count$3;
        kotlin.jvm.internal.Ref$IntRef ref$IntRef;
        if ((2 + 16) % 16 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.FlowKt__CountKt$count$3) {
            flowKt__CountKt$count$3 = (kotlinx.coroutines.flow.FlowKt__CountKt$count$3) continuation;
            if ((flowKt__CountKt$count$3.label & int.MIN_VALUE) == 0) {
                flowKt__CountKt$count$3 = new kotlinx.coroutines.flow.FlowKt__CountKt$count$3(continuation);
            } else {
                flowKt__CountKt$count$3.label -= int.MIN_VALUE;
            }
        } else {
            flowKt__CountKt$count$3 = new kotlinx.coroutines.flow.FlowKt__CountKt$count$3(continuation);
        }
        java.lang.object obj = flowKt__CountKt$count$3.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowKt__CountKt$count$3.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlin.jvm.internal.Ref$IntRef ref$IntRef2 = new kotlin.jvm.internal.Ref$IntRef();
            kotlinx.coroutines.flow.FlowCollector<java.lang.object> flowKt__CountKt$count$4 = new kotlinx.coroutines.flow.FlowKt__CountKt$count$4<>(function2, ref$IntRef2);
            flowKt__CountKt$count$3.L$0 = ref$IntRef2;
            flowKt__CountKt$count$3.label = 1;
            if (flow.collect(flowKt__CountKt$count$4, flowKt__CountKt$count$3) == coroutine_suspended) {
                return coroutine_suspended;
            }
            ref$IntRef = ref$IntRef2;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            ref$IntRef = (kotlin.jvm.internal.Ref$IntRef) flowKt__CountKt$count$3.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.coroutines.jvm.internal.Boxing.boxInt(ref$IntRef.element);
    }
}

