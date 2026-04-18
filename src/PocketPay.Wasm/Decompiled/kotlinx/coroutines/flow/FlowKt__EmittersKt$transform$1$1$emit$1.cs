namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__EmittersKt$transform$1$1", m533f = "Emitters.kt", m534i = {}, m535l = {42}, m536m = "emit", m537n = {}, m538s = {})
public readonly class FlowKt__EmittersKt$transform$1$1$emit$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.FlowKt__EmittersKt$transform$1$1<T> this$0;

    public FlowKt__EmittersKt$transform$1$1$emit$1(kotlinx.coroutines.flow.FlowKt__EmittersKt$transform$1$1<T> flowKt__EmittersKt$transform$1$1, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__EmittersKt$transform$1$1$emit$1> continuation) {
        super(continuation);
        this.this$0 = flowKt__EmittersKt$transform$1$1;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

