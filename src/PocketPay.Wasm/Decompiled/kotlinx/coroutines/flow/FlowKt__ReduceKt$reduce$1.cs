namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ReduceKt", m533f = "Reduce.kt", m534i = {0}, m535l = {22}, m536m = "reduce", m537n = {"accumulator"}, m538s = {"L$0"})
readonly class FlowKt__ReduceKt$reduce$1<S, T : S> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;

    FlowKt__ReduceKt$reduce$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__ReduceKt$reduce$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.flow.FlowKt.reduce(null, null, this);
    }
}

