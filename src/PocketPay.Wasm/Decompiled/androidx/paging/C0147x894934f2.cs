namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class C0147x894934f2 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly androidx.paging.C0146x463405a5 this$0;

    public C0147x894934f2(androidx.paging.C0146x463405a5 c0146x463405a5, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = c0146x463405a5;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.collect(null, this);
    }
}

