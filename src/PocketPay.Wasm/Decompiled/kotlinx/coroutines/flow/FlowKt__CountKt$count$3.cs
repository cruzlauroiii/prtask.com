namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__CountKt", m533f = "Count.kt", m534i = {0}, m535l = {29}, m536m = "count", m537n = {"i"}, m538s = {"L$0"})
readonly class FlowKt__CountKt$count$3<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;

    FlowKt__CountKt$count$3(kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__CountKt$count$3> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.flow.FlowKt.count(null, null, this);
    }
}

