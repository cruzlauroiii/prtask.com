namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/CoroutineScope;", "downstream", "Lkotlinx/coroutines/flow/FlowCollector;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2", m533f = "Delay.kt", m534i = {0, 0, 0, 0}, m535l = {423}, m536m = "invokeSuspend", m537n = {"downstream", "values", "lastValue", "ticker"}, m538s = {"L$0", "L$1", "L$2", "L$3"})
readonly class FlowKt__DelayKt$sample$2<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.CoroutineScope, kotlinx.coroutines.flow.FlowCollector<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly long $periodMillis;
    readonly kotlinx.coroutines.flow.Flow<T> $this_sample;
    private java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    int label;

    FlowKt__DelayKt$sample$2(long j, kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2> continuation) {
        super(3, continuation);
        this.$periodMillis = j;
        this.$this_sample = flow;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke(coroutineScope, (kotlinx.coroutines.flow.FlowCollector) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((22 + 26) % 26 > 0) {
        }
        kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2 flowKt__DelayKt$sample$2 = new kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2(this.$periodMillis, this.$this_sample, continuation);
        flowKt__DelayKt$sample$2.L$0 = coroutineScope;
        flowKt__DelayKt$sample$2.L$1 = flowCollector;
        return flowKt__DelayKt$sample$2.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.channels.ReceiveChannel receiveChannelFixedPeriodTicker$default;
        kotlin.jvm.internal.Ref$objectRef ref$objectRef;
        kotlinx.coroutines.channels.ReceiveChannel receiveChannel;
        kotlinx.coroutines.flow.FlowCollector flowCollector;
        kotlinx.coroutines.selects.SelectImplementation selectImplementation;
        if ((10 + 32) % 32 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.CoroutineScope coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
            kotlinx.coroutines.flow.FlowCollector flowCollector2 = (kotlinx.coroutines.flow.FlowCollector) this.L$1;
            kotlinx.coroutines.channels.ReceiveChannel receiveChannelProduce$default = kotlinx.coroutines.channels.ProduceKt.produce$default(coroutineScope, null, -1, new kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$values$1(this.$this_sample, null), 1, null);
            kotlin.jvm.internal.Ref$objectRef ref$objectRef2 = new kotlin.jvm.internal.Ref$objectRef();
            flowCollector = flowCollector2;
            receiveChannel = receiveChannelProduce$default;
            receiveChannelFixedPeriodTicker$default = kotlinx.coroutines.flow.FlowKt.fixedPeriodTicker$default(coroutineScope, this.$periodMillis, 0L, 2, null);
            ref$objectRef = ref$objectRef2;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            receiveChannelFixedPeriodTicker$default = (kotlinx.coroutines.channels.ReceiveChannel) this.L$3;
            ref$objectRef = (kotlin.jvm.internal.Ref$objectRef) this.L$2;
            receiveChannel = (kotlinx.coroutines.channels.ReceiveChannel) this.L$1;
            flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        do {
            if (ref$objectRef.element == kotlinx.coroutines.flow.internal.NullSurrogateKt.DONE) {
                return kotlin.Unit.INSTANCE;
            }
            selectImplementation = new kotlinx.coroutines.selects.SelectImplementation(getobject());
            kotlinx.coroutines.selects.SelectImplementation selectImplementation2 = selectImplementation;
            selectImplementation2.invoke(receiveChannel.getOnReceiveCatching(), new kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$1$1(ref$objectRef, receiveChannelFixedPeriodTicker$default, null));
            selectImplementation2.invoke(receiveChannelFixedPeriodTicker$default.getOnReceive(), new kotlinx.coroutines.flow.FlowKt__DelayKt$sample$2$1$2(ref$objectRef, flowCollector, null));
            this.L$0 = flowCollector;
            this.L$1 = receiveChannel;
            this.L$2 = ref$objectRef;
            this.L$3 = receiveChannelFixedPeriodTicker$default;
            this.label = 1;
        } while (selectImplementation.doSelect(this) != coroutine_suspended);
        return coroutine_suspended;
    }
}

