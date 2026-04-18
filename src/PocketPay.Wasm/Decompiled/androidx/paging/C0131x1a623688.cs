namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class C0131x1a623688 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly androidx.paging.C0130x53ac74bb this$0;

    C0131x1a623688(androidx.paging.C0130x53ac74bb c0130x53ac74bb, kotlin.coroutines.Continuation continuation) {
        super(continuation);
        this.this$0 = c0130x53ac74bb;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.emit(null, this);
    }
}

