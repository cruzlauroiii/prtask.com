namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.stream.StreamFlow", m533f = "Stream.kt", m534i = {0, 0}, m535l = {26}, m536m = "collect", m537n = {"this", "collector"}, m538s = {"L$0", "L$1"})
readonly class StreamFlow$collect$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.stream.StreamFlow<T> this$0;

    StreamFlow$collect$1(kotlinx.coroutines.stream.StreamFlow<T> streamFlow, kotlin.coroutines.Continuation<? super kotlinx.coroutines.stream.StreamFlow$collect$1> continuation) {
        super(continuation);
        this.this$0 = streamFlow;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.collect(null, this);
    }
}

