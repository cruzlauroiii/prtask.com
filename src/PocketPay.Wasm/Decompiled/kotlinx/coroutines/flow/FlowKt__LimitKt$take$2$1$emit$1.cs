namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__LimitKt$take$2$1", m533f = "Limit.kt", m534i = {}, m535l = {61, 63}, m536m = "emit", m537n = {}, m538s = {})
readonly class FlowKt__LimitKt$take$2$1$emit$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.FlowKt__LimitKt$take$2$1<T> this$0;

    FlowKt__LimitKt$take$2$1$emit$1(kotlinx.coroutines.flow.FlowKt__LimitKt$take$2$1<T> flowKt__LimitKt$take$2$1, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__LimitKt$take$2$1$emit$1> continuation) {
        super(continuation);
        this.this$0 = flowKt__LimitKt$take$2$1;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

