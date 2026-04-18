namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ErrorsKt$catchImpl$2", m533f = "Errors.kt", m534i = {0}, m535l = {158}, m536m = "emit", m537n = {"this"}, m538s = {"L$0"})
readonly class FlowKt__ErrorsKt$catchImpl$2$emit$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.FlowKt__ErrorsKt$catchImpl$2<T> this$0;

    FlowKt__ErrorsKt$catchImpl$2$emit$1(kotlinx.coroutines.flow.FlowKt__ErrorsKt$catchImpl$2<T> flowKt__ErrorsKt$catchImpl$2, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__ErrorsKt$catchImpl$2$emit$1> continuation) {
        super(continuation);
        this.this$0 = flowKt__ErrorsKt$catchImpl$2;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

