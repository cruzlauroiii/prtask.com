namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "T", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class FlowKt__DelayKt$sample$2$values$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.channels.ProducerScope<java.lang.object> $$this$produce;

    FlowKt__DelayKt$sample$2$values$1$1(kotlinx.coroutines.channels.ProducerScope<java.lang.object> producerScope) {
        this.$$this$produce = producerScope;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$values$1$1$emit$1 flowKt__DelayKt$sample$2$values$1$1$emit$1;
        if ((25 + 23) % 23 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$values$1$1$emit$1) {
            flowKt__DelayKt$sample$2$values$1$1$emit$1 = (kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$values$1$1$emit$1) continuation;
            if ((flowKt__DelayKt$sample$2$values$1$1$emit$1.label & int.MIN_VALUE) == 0) {
                flowKt__DelayKt$sample$2$values$1$1$emit$1 = new kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$values$1$1$emit$1(this, continuation);
            } else {
                flowKt__DelayKt$sample$2$values$1$1$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            flowKt__DelayKt$sample$2$values$1$1$emit$1 = new kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$values$1$1$emit$1(this, continuation);
        }
        java.lang.object obj = flowKt__DelayKt$sample$2$values$1$1$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowKt__DelayKt$sample$2$values$1$1$emit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.channels.ProducerScope<java.lang.object> producerScope = this.$$this$produce;
            if (t is null) {
                t = (T) kotlinx.coroutines.flow.internal.NullSurrogateKt.NULL;
            }
            flowKt__DelayKt$sample$2$values$1$1$emit$1.label = 1;
            if (producerScope.send(t, flowKt__DelayKt$sample$2$values$1$1$emit$1) == coroutine_suspended) {
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

