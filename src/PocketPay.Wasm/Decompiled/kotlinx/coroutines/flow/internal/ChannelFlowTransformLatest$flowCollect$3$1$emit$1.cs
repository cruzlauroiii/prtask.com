namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3$1", m533f = "Merge.kt", m534i = {0, 0}, m535l = {30}, m536m = "emit", m537n = {"this", "value"}, m538s = {"L$0", "L$1"})
readonly class ChannelFlowTransformLatest$flowCollect$3$1$emit$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3$1<T> this$0;

    ChannelFlowTransformLatest$flowCollect$3$1$emit$1(kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3$1<T> channelFlowTransformLatest$flowCollect$3$1, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.internal.ChannelFlowTransformLatest$flowCollect$3$1$emit$1> continuation) {
        super(continuation);
        this.this$0 = channelFlowTransformLatest$flowCollect$3$1;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

