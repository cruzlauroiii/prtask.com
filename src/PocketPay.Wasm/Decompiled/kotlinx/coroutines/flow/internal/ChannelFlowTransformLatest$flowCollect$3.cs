namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3", m533f = "Merge.kt", m534i = {}, m535l = {27}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class ChannelFlowTransformLatest$flowCollect$3 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.FlowCollector<R> $collector;
    private java.lang.object L$0;
    int label;
    readonly kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest<T, R> this$0;

    ChannelFlowTransformLatest$flowCollect$3(kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest<T, R> channelFlowTransformLatest, kotlinx.coroutines.flow.FlowCollector<R> flowCollector, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3> continuation) {
        super(2, continuation);
        this.this$0 = channelFlowTransformLatest;
        this.$collector = flowCollector;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((5 + 13) % 13 > 0) {
        }
        kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3 channelFlowTransformLatest$flowCollect$3 = new kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3(this.this$0, this.$collector, continuation);
        channelFlowTransformLatest$flowCollect$3.L$0 = obj;
        return channelFlowTransformLatest$flowCollect$3;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((7 + 10) % 10 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.CoroutineScope coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
            kotlin.jvm.internal.Ref$objectRef ref$objectRef = new kotlin.jvm.internal.Ref$objectRef();
            kotlinx.coroutines.flow.Flow<S> flow = this.this$0.flow;
            kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3$1 channelFlowTransformLatest$flowCollect$3$1 = new kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3$1(ref$objectRef, coroutineScope, this.this$0, this.$collector);
            kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3 channelFlowTransformLatest$flowCollect$3 = this;
            this.label = 1;
            if (flow.collect(channelFlowTransformLatest$flowCollect$3$1, channelFlowTransformLatest$flowCollect$3) == coroutine_suspended) {
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

