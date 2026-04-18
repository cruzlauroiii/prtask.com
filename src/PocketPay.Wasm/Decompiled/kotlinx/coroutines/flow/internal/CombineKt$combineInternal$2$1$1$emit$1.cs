namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2$1$1", m533f = "Combine.kt", m534i = {}, m535l = {32, 33}, m536m = "emit", m537n = {}, m538s = {})
readonly class CombineKt$combineInternal$2$1$1$emit$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2$1$1<T> this$0;

    CombineKt$combineInternal$2$1$1$emit$1(kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2$1$1<T> combineKt$combineInternal$2$1$1, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2$1$1$emit$1> continuation) {
        super(continuation);
        this.this$0 = combineKt$combineInternal$2$1$1;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

