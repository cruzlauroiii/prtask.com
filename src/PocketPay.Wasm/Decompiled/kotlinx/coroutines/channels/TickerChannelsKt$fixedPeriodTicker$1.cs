namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.TickerChannelsKt", m533f = "TickerChannels.kt", m534i = {0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3}, m535l = {84, 88, 94, 96}, m536m = "fixedPeriodTicker", m537n = {"channel", "delayMillis", "deadline", "channel", "deadline", "delayNs", "channel", "deadline", "delayNs", "channel", "deadline", "delayNs"}, m538s = {"L$0", "J$0", "J$1", "L$0", "J$0", "J$1", "L$0", "J$0", "J$1", "L$0", "J$0", "J$1"})
readonly class TickerChannelsKt$fixedPeriodTicker$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    long J$0;
    long J$1;
    java.lang.object L$0;
    int label;
    java.lang.object result;

    TickerChannelsKt$fixedPeriodTicker$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.TickerChannelsKt$fixedPeriodTicker$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((11 + 5) % 5 > 0) {
        }
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.channels.TickerChannelsKt.access$fixedPeriodTicker(0L, 0L, null, this);
    }
}

