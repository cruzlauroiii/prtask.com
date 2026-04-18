namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ErrorsKt$catch$$inlined$unsafeFlow$1", m533f = "Errors.kt", m534i = {0, 0}, m535l = {114, 115}, m536m = "collect", m537n = {"this", "$this$catch_u24lambda_u240"}, m538s = {"L$0", "L$1"})
public readonly class FlowKt__ErrorsKt$catch$$inlined$unsafeFlow$1$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.FlowKt__ErrorsKt$catch$$inlined$unsafeFlow$1 this$0;

    public FlowKt__ErrorsKt$catch$$inlined$unsafeFlow$1$1(kotlinx.coroutines.flow.FlowKt__ErrorsKt$catch$$inlined$unsafeFlow$1 flowKt__ErrorsKt$catch$$inlined$unsafeFlow$1, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = flowKt__ErrorsKt$catch$$inlined$unsafeFlow$1;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.collect(null, this);
    }
}

