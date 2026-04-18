namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.AbstractFlow", m533f = "Flow.kt", m534i = {0}, m535l = {230}, m536m = "collect", m537n = {"safeCollector"}, m538s = {"L$0"})
readonly class AbstractFlow$collect$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.AbstractFlow<T> this$0;

    AbstractFlow$collect$1(kotlinx.coroutines.flow.AbstractFlow<T> abstractFlow, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.AbstractFlow$collect$1> continuation) {
        super(continuation);
        this.this$0 = abstractFlow;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.collect(null, this);
    }
}

