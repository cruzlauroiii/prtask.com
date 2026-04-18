namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.DistinctFlowImpl$collect$2", m533f = "Distinct.kt", m534i = {}, m535l = {77}, m536m = "emit", m537n = {}, m538s = {})
readonly class DistinctFlowImpl$collect$2$emit$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.DistinctFlowImpl$collect$2<T> this$0;

    DistinctFlowImpl$collect$2$emit$1(kotlinx.coroutines.flow.DistinctFlowImpl$collect$2<T> distinctFlowImpl$collect$2, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.DistinctFlowImpl$collect$2$emit$1> continuation) {
        super(continuation);
        this.this$0 = distinctFlowImpl$collect$2;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

