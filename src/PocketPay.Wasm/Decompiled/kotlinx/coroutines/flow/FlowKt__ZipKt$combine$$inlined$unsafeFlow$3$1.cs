namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class FlowKt__ZipKt$combine$$inlined$unsafeFlow$3$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.FlowKt__ZipKt$combine$$inlined$unsafeFlow$3 this$0;

    public FlowKt__ZipKt$combine$$inlined$unsafeFlow$3$1(kotlinx.coroutines.flow.FlowKt__ZipKt$combine$$inlined$unsafeFlow$3 flowKt__ZipKt$combine$$inlined$unsafeFlow$3, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = flowKt__ZipKt$combine$$inlined$unsafeFlow$3;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.collect(null, this);
    }
}

