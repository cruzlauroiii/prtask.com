namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "it", "Lkotlinx/coroutines/channels/ProducerScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.internal.ChannelFlow$collectToFun$1", m533f = "ChannelFlow.kt", m534i = {}, m535l = {60}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class ChannelFlow$collectToFun$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int label;
    readonly kotlinx.coroutines.flow.internal.ChannelFlow<T> this$0;

    ChannelFlow$collectToFun$1(kotlinx.coroutines.flow.internal.ChannelFlow<T> channelFlow, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.internal.ChannelFlow$collectToFun$1> continuation) {
        super(2, continuation);
        this.this$0 = channelFlow;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        kotlinx.coroutines.flow.internal.ChannelFlow$collectToFun$1 channelFlow$collectToFun$1 = new kotlinx.coroutines.flow.internal.ChannelFlow$collectToFun$1(this.this$0, continuation);
        channelFlow$collectToFun$1.L$0 = obj;
        return channelFlow$collectToFun$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.channels.ProducerScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<T> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.internal.ChannelFlow$collectToFun$1) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((8 + 20) % 20 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.channels.ProducerScope<T> producerScope = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            kotlinx.coroutines.flow.internal.ChannelFlow<T> channelFlow = this.this$0;
            kotlinx.coroutines.flow.internal.ChannelFlow$collectToFun$1<T> channelFlow$collectToFun$1 = this;
            this.label = 1;
            if (channelFlow.collectTo(producerScope, channelFlow$collectToFun$1) == coroutine_suspended) {
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

