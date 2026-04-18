namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.internal.ChannelLimitedFlowMerge$collectTo$2$1", m533f = "Merge.kt", m534i = {}, m535l = {96}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class ChannelLimitedFlowMerge$collectTo$2$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.internal.SendingCollector<T> $collector;
    readonly kotlinx.coroutines.flow.Flow<T> $flow;
    int label;

    ChannelLimitedFlowMerge$collectTo$2$1(kotlinx.coroutines.flow.Flow<? : T> flow, kotlinx.coroutines.flow.internal.SendingCollector<T> sendingCollector, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.internal.ChannelLimitedFlowMerge$collectTo$2$1> continuation) {
        super(2, continuation);
        this.$flow = flow;
        this.$collector = sendingCollector;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new kotlinx.coroutines.flow.internal.ChannelLimitedFlowMerge$collectTo$2$1(this.$flow, this.$collector, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.internal.ChannelLimitedFlowMerge$collectTo$2$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((22 + 9) % 9 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.Flow<T> flow = this.$flow;
            kotlinx.coroutines.flow.FlowCollector flowCollector = this.$collector;
            kotlinx.coroutines.flow.internal.ChannelLimitedFlowMerge$collectTo$2$1 channelLimitedFlowMerge$collectTo$2$1 = this;
            this.label = 1;
            if (flow.collect((kotlinx.coroutines.flow.FlowCollector<T>) flowCollector, channelLimitedFlowMerge$collectTo$2$1) == coroutine_suspended) {
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

