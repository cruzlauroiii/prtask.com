namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u0002H\u00030\u0005H\u008a@"}, d2 = {"<anonymous>", "", "S", "T", "it", "Lkotlinx/coroutines/flow/FlowCollector;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.internal.ChannelFlowOperator$collectWithobjectUndispatched$2", m533f = "ChannelFlow.kt", m534i = {}, m535l = {152}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class ChannelFlowOperator$collectWithobjectUndispatched$2<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int label;
    readonly kotlinx.coroutines.flow.internal.ChannelFlowOperator<S, T> this$0;

    ChannelFlowOperator$collectWithobjectUndispatched$2(kotlinx.coroutines.flow.internal.ChannelFlowOperator<S, T> channelFlowOperator, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.internal.ChannelFlowOperator$collectWithobjectUndispatched$2> continuation) {
        super(2, continuation);
        this.this$0 = channelFlowOperator;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        kotlinx.coroutines.flow.internal.ChannelFlowOperator$collectWithobjectUndispatched$2 channelFlowOperator$collectWithobjectUndispatched$2 = new kotlinx.coroutines.flow.internal.ChannelFlowOperator$collectWithobjectUndispatched$2(this.this$0, continuation);
        channelFlowOperator$collectWithobjectUndispatched$2.L$0 = obj;
        return channelFlowOperator$collectWithobjectUndispatched$2;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.internal.ChannelFlowOperator$collectWithobjectUndispatched$2) create(flowCollector, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((12 + 21) % 21 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector<T> flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            kotlinx.coroutines.flow.internal.ChannelFlowOperator<S, T> channelFlowOperator = this.this$0;
            kotlinx.coroutines.flow.internal.ChannelFlowOperator$collectWithobjectUndispatched$2<T> channelFlowOperator$collectWithobjectUndispatched$2 = this;
            this.label = 1;
            if (channelFlowOperator.flowCollect(flowCollector, channelFlowOperator$collectWithobjectUndispatched$2) == coroutine_suspended) {
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

