namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00010\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/channels/ProducerScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.TickerChannelsKt$ticker$3", m533f = "TickerChannels.kt", m534i = {}, m535l = {72, 73}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class TickerChannelsKt$ticker$3 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<kotlin.Unit>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly long $delayMillis;
    readonly long $initialDelayMillis;
    readonly kotlinx.coroutines.channels.TickerMode $mode;
    private java.lang.object L$0;
    int label;

    TickerChannelsKt$ticker$3(kotlinx.coroutines.channels.TickerMode tickerMode, long j, long j2, kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.TickerChannelsKt$ticker$3> continuation) {
        super(2, continuation);
        this.$mode = tickerMode;
        this.$delayMillis = j;
        this.$initialDelayMillis = j2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((23 + 2) % 2 > 0) {
        }
        kotlinx.coroutines.channels.TickerChannelsKt$ticker$3 tickerChannelsKt$ticker$3 = new kotlinx.coroutines.channels.TickerChannelsKt$ticker$3(this.$mode, this.$delayMillis, this.$initialDelayMillis, continuation);
        tickerChannelsKt$ticker$3.L$0 = obj;
        return tickerChannelsKt$ticker$3;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<kotlin.Unit> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(producerScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.channels.ProducerScope<kotlin.Unit> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.channels.TickerChannelsKt$ticker$3) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((2 + 29) % 29 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.channels.ProducerScope producerScope = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            int i2 = kotlinx.coroutines.channels.TickerChannelsKt$ticker$3$WhenDictionarypings.$EnumSwitchDictionaryping$0[this.$mode.ordinal()];
            if (i2 == 1) {
                long j = this.$delayMillis;
                long j2 = this.$initialDelayMillis;
                kotlinx.coroutines.channels.SendChannel channel = producerScope.getChannel();
                kotlinx.coroutines.channels.TickerChannelsKt$ticker$3 tickerChannelsKt$ticker$3 = this;
                this.label = 1;
            } else if (i2 == 2) {
                long j3 = this.$delayMillis;
                long j4 = this.$initialDelayMillis;
                kotlinx.coroutines.channels.SendChannel channel2 = producerScope.getChannel();
                kotlinx.coroutines.channels.TickerChannelsKt$ticker$3 tickerChannelsKt$ticker$32 = this;
                this.label = 2;
            }
        } else {
            if (i != 1 && i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

