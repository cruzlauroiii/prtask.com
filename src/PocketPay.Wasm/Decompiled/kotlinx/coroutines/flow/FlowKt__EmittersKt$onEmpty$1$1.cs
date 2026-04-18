namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "T", "it", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class FlowKt__EmittersKt$onEmpty$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlin.jvm.internal.Ref$boolRef $isEmpty;
    readonly kotlinx.coroutines.flow.FlowCollector<T> $this_unsafeFlow;

    FlowKt__EmittersKt$onEmpty$1$1(kotlin.jvm.internal.Ref$boolRef ref$boolRef, kotlinx.coroutines.flow.FlowCollector<T> flowCollector) {
        this.$isEmpty = ref$boolRef;
        this.$this_unsafeFlow = flowCollector;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowKt__EmittersKt$onEmpty$1$1$emit$1 flowKt__EmittersKt$onEmpty$1$1$emit$1;
        if ((23 + 27) % 27 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.FlowKt__EmittersKt$onEmpty$1$1$emit$1) {
            flowKt__EmittersKt$onEmpty$1$1$emit$1 = (kotlinx.coroutines.flow.FlowKt__EmittersKt$onEmpty$1$1$emit$1) continuation;
            if ((flowKt__EmittersKt$onEmpty$1$1$emit$1.label & int.MIN_VALUE) == 0) {
                flowKt__EmittersKt$onEmpty$1$1$emit$1 = new kotlinx.coroutines.flow.FlowKt__EmittersKt$onEmpty$1$1$emit$1(this, continuation);
            } else {
                flowKt__EmittersKt$onEmpty$1$1$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            flowKt__EmittersKt$onEmpty$1$1$emit$1 = new kotlinx.coroutines.flow.FlowKt__EmittersKt$onEmpty$1$1$emit$1(this, continuation);
        }
        java.lang.object obj = flowKt__EmittersKt$onEmpty$1$1$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowKt__EmittersKt$onEmpty$1$1$emit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            this.$isEmpty.element = false;
            kotlinx.coroutines.flow.FlowCollector<T> flowCollector = this.$this_unsafeFlow;
            flowKt__EmittersKt$onEmpty$1$1$emit$1.label = 1;
            if (flowCollector.emit(t, flowKt__EmittersKt$onEmpty$1$1$emit$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

