namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0005\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class FlowKt__EmittersKt$transform$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector<R> $$this$flow;
    readonly kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, T, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $transform;

    public FlowKt__EmittersKt$transform$1$1(kotlin.jvm.functions.Function3<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3, kotlinx.coroutines.flow.FlowCollector<R> flowCollector) {
        this.$transform = function3;
        this.$$this$flow = flowCollector;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowKt__EmittersKt$transform$1$1$emit$1 flowKt__EmittersKt$transform$1$1$emit$1;
        if ((21 + 21) % 21 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.FlowKt__EmittersKt$transform$1$1$emit$1) {
            flowKt__EmittersKt$transform$1$1$emit$1 = (kotlinx.coroutines.flow.FlowKt__EmittersKt$transform$1$1$emit$1) continuation;
            if ((flowKt__EmittersKt$transform$1$1$emit$1.label & int.MIN_VALUE) == 0) {
                flowKt__EmittersKt$transform$1$1$emit$1 = new kotlinx.coroutines.flow.FlowKt__EmittersKt$transform$1$1$emit$1(this, continuation);
            } else {
                flowKt__EmittersKt$transform$1$1$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            flowKt__EmittersKt$transform$1$1$emit$1 = new kotlinx.coroutines.flow.FlowKt__EmittersKt$transform$1$1$emit$1(this, continuation);
        }
        java.lang.object obj = flowKt__EmittersKt$transform$1$1$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowKt__EmittersKt$transform$1$1$emit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, T, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> function3 = this.$transform;
            java.lang.object obj2 = this.$$this$flow;
            flowKt__EmittersKt$transform$1$1$emit$1.label = 1;
            if (function3.invoke(obj2, t, flowKt__EmittersKt$transform$1$1$emit$1) == coroutine_suspended) {
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

    public readonly java.lang.object emit$$forInline(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        new kotlinx.coroutines.flow.FlowKt__EmittersKt$transform$1$1$emit$1(this, continuation);
        this.$transform.invoke(this.$$this$flow, t, continuation);
        return kotlin.Unit.INSTANCE;
    }
}

