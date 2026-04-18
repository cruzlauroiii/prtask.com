namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.internal.ChannelFlowMerge$collectTo$2", m533f = "Merge.kt", m534i = {0, 0}, m535l = {66}, m536m = "emit", m537n = {"this", "inner"}, m538s = {"L$0", "L$1"})
readonly class ChannelFlowMerge$collectTo$2$emit$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.internal.ChannelFlowMerge$collectTo$2<T> this$0;

    ChannelFlowMerge$collectTo$2$emit$1(kotlinx.coroutines.flow.internal.ChannelFlowMerge$collectTo$2<T> channelFlowMerge$collectTo$2, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.internal.ChannelFlowMerge$collectTo$2$emit$1> continuation) {
        super(continuation);
        this.this$0 = channelFlowMerge$collectTo$2;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit((kotlinx.coroutines.flow.Flow) null, (kotlin.coroutines.Continuation<kotlin.Unit>) this);
    }
}

