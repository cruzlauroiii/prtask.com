namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__LimitKt", m533f = "Limit.kt", m534i = {0}, m535l = {136}, m536m = "collectWhile", m537n = {"collector"}, m538s = {"L$0"})
readonly class FlowKt__LimitKt$collectWhile$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;

    FlowKt__LimitKt$collectWhile$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__LimitKt$collectWhile$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.flow.FlowKt__LimitKt.collectWhile(null, null, this);
    }
}

