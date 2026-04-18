namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ReduceKt$reduce$2", m533f = "Reduce.kt", m534i = {}, m535l = {25}, m536m = "emit", m537n = {}, m538s = {})
readonly class FlowKt__ReduceKt$reduce$2$emit$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.FlowKt__ReduceKt$reduce$2<T> this$0;

    FlowKt__ReduceKt$reduce$2$emit$1(kotlinx.coroutines.flow.FlowKt__ReduceKt$reduce$2<T> flowKt__ReduceKt$reduce$2, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__ReduceKt$reduce$2$emit$1> continuation) {
        super(continuation);
        this.this$0 = flowKt__ReduceKt$reduce$2;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

