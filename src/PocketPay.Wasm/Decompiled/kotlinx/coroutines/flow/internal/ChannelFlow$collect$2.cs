namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.internal.ChannelFlow$collect$2", m533f = "ChannelFlow.kt", m534i = {}, m535l = {123}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class ChannelFlow$collect$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.FlowCollector<T> $collector;
    private java.lang.object L$0;
    int label;
    readonly kotlinx.coroutines.flow.internal.ChannelFlow<T> this$0;

    ChannelFlow$collect$2(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlinx.coroutines.flow.internal.ChannelFlow<T> channelFlow, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.internal.ChannelFlow$collect$2> continuation) {
        super(2, continuation);
        this.$collector = flowCollector;
        this.this$0 = channelFlow;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((13 + 23) % 23 > 0) {
        }
        kotlinx.coroutines.flow.internal.ChannelFlow$collect$2 channelFlow$collect$2 = new kotlinx.coroutines.flow.internal.ChannelFlow$collect$2(this.$collector, this.this$0, continuation);
        channelFlow$collect$2.L$0 = obj;
        return channelFlow$collect$2;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.internal.ChannelFlow$collect$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((21 + 11) % 11 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.CoroutineScope coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
            kotlinx.coroutines.flow.FlowCollector<T> flowCollector = this.$collector;
            kotlinx.coroutines.channels.ReceiveChannel receiveChannelProduceImpl = this.this$0.produceImpl(coroutineScope);
            kotlinx.coroutines.flow.internal.ChannelFlow$collect$2 channelFlow$collect$2 = this;
            this.label = 1;
            if (kotlinx.coroutines.flow.FlowKt.emitAll(flowCollector, receiveChannelProduceImpl, channelFlow$collect$2) == coroutine_suspended) {
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

