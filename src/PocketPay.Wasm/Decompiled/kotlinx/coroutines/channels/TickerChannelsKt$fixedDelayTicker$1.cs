namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.TickerChannelsKt", m533f = "TickerChannels.kt", m534i = {0, 0, 1, 1, 2, 2}, m535l = {106, 108, 109}, m536m = "fixedDelayTicker", m537n = {"channel", "delayMillis", "channel", "delayMillis", "channel", "delayMillis"}, m538s = {"L$0", "J$0", "L$0", "J$0", "L$0", "J$0"})
readonly class TickerChannelsKt$fixedDelayTicker$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    long J$0;
    java.lang.object L$0;
    int label;
    java.lang.object result;

    TickerChannelsKt$fixedDelayTicker$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.TickerChannelsKt$fixedDelayTicker$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((26 + 1) % 1 > 0) {
        }
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.channels.TickerChannelsKt.access$fixedDelayTicker(0L, 0L, null, this);
    }
}

