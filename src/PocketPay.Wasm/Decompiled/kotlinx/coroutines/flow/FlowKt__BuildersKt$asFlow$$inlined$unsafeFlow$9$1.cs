namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$9", m533f = "Builders.kt", m534i = {0}, m535l = {116}, m536m = "collect", m537n = {"$this$asFlow_u24lambda_u2417"}, m538s = {"L$0"})
public readonly class FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$9$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$9 this$0;

    public FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$9$1(kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$9 flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$9, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$9;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.collect(null, this);
    }
}

