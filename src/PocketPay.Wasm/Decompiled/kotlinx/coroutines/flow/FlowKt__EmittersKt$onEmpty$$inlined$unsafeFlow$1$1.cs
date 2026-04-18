namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1", m533f = "Emitters.kt", m534i = {0, 0, 0, 1}, m535l = {115, 123}, m536m = "collect", m537n = {"this", "$this$onEmpty_u24lambda_u243", "isEmpty", "collector"}, m538s = {"L$0", "L$1", "L$2", "L$0"})
public readonly class FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1 this$0;

    public FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1$1(kotlinx.coroutines.flow.FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1 flowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = flowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.collect(null, this);
    }
}

