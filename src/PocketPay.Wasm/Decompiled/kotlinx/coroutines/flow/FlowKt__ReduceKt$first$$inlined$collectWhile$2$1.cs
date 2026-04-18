namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ReduceKt$first$$inlined$collectWhile$2", m533f = "Reduce.kt", m534i = {0, 0}, m535l = {142}, m536m = "emit", m537n = {"this", "it"}, m538s = {"L$0", "L$1"})
public readonly class FlowKt__ReduceKt$first$$inlined$collectWhile$2$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.FlowKt__ReduceKt$first$$inlined$collectWhile$2 this$0;

    public FlowKt__ReduceKt$first$$inlined$collectWhile$2$1(kotlinx.coroutines.flow.FlowKt__ReduceKt$first$$inlined$collectWhile$2 flowKt__ReduceKt$first$$inlined$collectWhile$2, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = flowKt__ReduceKt$first$$inlined$collectWhile$2;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

