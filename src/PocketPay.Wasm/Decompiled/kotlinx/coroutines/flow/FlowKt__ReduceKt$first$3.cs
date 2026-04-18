namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ReduceKt", m533f = "Reduce.kt", m534i = {0, 0, 0}, m535l = {183}, m536m = "first", m537n = {"predicate", "result", "collector$iv"}, m538s = {"L$0", "L$1", "L$2"})
readonly class FlowKt__ReduceKt$first$3<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;

    FlowKt__ReduceKt$first$3(kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__ReduceKt$first$3> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.flow.FlowKt.first(null, null, this);
    }
}

