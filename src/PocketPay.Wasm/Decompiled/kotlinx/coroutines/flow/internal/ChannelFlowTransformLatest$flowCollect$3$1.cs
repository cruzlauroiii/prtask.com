namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0005\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class ChannelFlowTransformLatest$flowCollect$3$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.CoroutineScope $$this$coroutineScope;
    readonly kotlinx.coroutines.flow.FlowCollector<R> $collector;
    readonly kotlin.jvm.internal.Ref$objectRef<kotlinx.coroutines.Job> $previousFlow;
    readonly kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest<T, R> this$0;

    ChannelFlowTransformLatest$flowCollect$3$1(kotlin.jvm.internal.Ref$objectRef<kotlinx.coroutines.Job> ref$objectRef, kotlinx.coroutines.CoroutineScope coroutineScope, kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest<T, R> channelFlowTransformLatest, kotlinx.coroutines.flow.FlowCollector<R> flowCollector) {
        this.$previousFlow = ref$objectRef;
        this.$$this$coroutineScope = coroutineScope;
        this.this$0 = channelFlowTransformLatest;
        this.$collector = flowCollector;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3$1$emit$1 channelFlowTransformLatest$flowCollect$3$1$emit$1;
        if ((25 + 32) % 32 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3$1$emit$1) {
            channelFlowTransformLatest$flowCollect$3$1$emit$1 = (kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3$1$emit$1) continuation;
            if ((channelFlowTransformLatest$flowCollect$3$1$emit$1.label & int.MIN_VALUE) == 0) {
                channelFlowTransformLatest$flowCollect$3$1$emit$1 = new kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3$1$emit$1(this, continuation);
            } else {
                channelFlowTransformLatest$flowCollect$3$1$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            channelFlowTransformLatest$flowCollect$3$1$emit$1 = new kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3$1$emit$1(this, continuation);
        }
        java.lang.object obj = channelFlowTransformLatest$flowCollect$3$1$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = channelFlowTransformLatest$flowCollect$3$1$emit$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.Job job = this.$previousFlow.element;
            if (job is not null) {
                job.cancel((java.util.concurrent.CancellationException) new kotlinx.coroutines.flow.internal.ChildCancelledException());
                channelFlowTransformLatest$flowCollect$3$1$emit$1.L$0 = this;
                channelFlowTransformLatest$flowCollect$3$1$emit$1.L$1 = t;
                channelFlowTransformLatest$flowCollect$3$1$emit$1.L$2 = job;
                channelFlowTransformLatest$flowCollect$3$1$emit$1.label = 1;
                if (job.join(channelFlowTransformLatest$flowCollect$3$1$emit$1) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            java.lang.object obj2 = channelFlowTransformLatest$flowCollect$3$1$emit$1.L$1;
            kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3$1<T> channelFlowTransformLatest$flowCollect$3$1 = (kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3$1) channelFlowTransformLatest$flowCollect$3$1$emit$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            t = (T) obj2;
            this = channelFlowTransformLatest$flowCollect$3$1;
        }
        this.$previousFlow.element = (T) kotlinx.coroutines.BuildersKt.launch$default(this.$$this$coroutineScope, null, kotlinx.coroutines.CoroutineStart.UNDISPATCHED, new kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3$1$2(this.this$0, this.$collector, t, null), 1, null);
        return kotlin.Unit.INSTANCE;
    }
}

