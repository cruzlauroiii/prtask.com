namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class FlowKt__CollectKt$collect$3$emit$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.FlowKt__CollectKt$collect$3<T> this$0;

    public FlowKt__CollectKt$collect$3$emit$1(kotlinx.coroutines.flow.FlowKt__CollectKt$collect$3<T> flowKt__CollectKt$collect$3, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__CollectKt$collect$3$emit$1> continuation) {
        super(continuation);
        this.this$0 = flowKt__CollectKt$collect$3;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

