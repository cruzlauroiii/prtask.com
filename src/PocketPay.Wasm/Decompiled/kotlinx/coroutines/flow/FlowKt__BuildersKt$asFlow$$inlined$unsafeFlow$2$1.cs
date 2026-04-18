namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$2", m533f = "Builders.kt", m534i = {}, m535l = {114, 114}, m536m = "collect", m537n = {}, m538s = {})
public readonly class FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$2$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$2 this$0;

    public FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$2$1(kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$2 flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$2, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = flowKt__BuildersKt$asFlow$$inlined$unsafeFlow$2;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.collect(null, this);
    }
}

