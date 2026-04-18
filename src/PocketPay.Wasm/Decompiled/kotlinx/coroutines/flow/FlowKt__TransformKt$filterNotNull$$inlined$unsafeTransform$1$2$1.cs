namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__TransformKt$filterNotNull$$inlined$unsafeTransform$1$2", m533f = "Transform.kt", m534i = {}, m535l = {223}, m536m = "emit", m537n = {}, m538s = {})
public readonly class FlowKt__TransformKt$filterNotNull$$inlined$unsafeTransform$1$2$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.FlowKt__TransformKt$filterNotNull$$inlined$unsafeTransform$1$2 this$0;

    public FlowKt__TransformKt$filterNotNull$$inlined$unsafeTransform$1$2$1(kotlinx.coroutines.flow.FlowKt__TransformKt$filterNotNull$$inlined$unsafeTransform$1$2 flowKt__TransformKt$filterNotNull$$inlined$unsafeTransform$1$2, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = flowKt__TransformKt$filterNotNull$$inlined$unsafeTransform$1$2;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

