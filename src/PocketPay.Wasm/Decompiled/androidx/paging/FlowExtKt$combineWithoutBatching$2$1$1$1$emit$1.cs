namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1$1", m533f = "FlowExt.kt", m534i = {}, m535l = {148, 151}, m536m = "emit", m537n = {}, m538s = {})
readonly class FlowExtKt$combineWithoutBatching$2$1$1$1$emit$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1$1<T> this$0;

    FlowExtKt$combineWithoutBatching$2$1$1$1$emit$1(androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1$1<T> flowExtKt$combineWithoutBatching$2$1$1$1, kotlin.coroutines.Continuation<? super androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1$1$emit$1> continuation) {
        super(continuation);
        this.this$0 = flowExtKt$combineWithoutBatching$2$1$1$1;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

