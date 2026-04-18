namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.pb3f20355.pf38d8cc7", m533f = "SellReceiptsPagingSource.kt", m534i = {0, 0, 0, 0, 1, 1, 1}, m535l = {17, 24}, m536m = "load", m537n = {"this", "params", "pageIndex", "offset", "params", "receiptNumber", "pageIndex"}, m538s = {"L$0", "L$1", "I$0", "I$1", "L$0", "L$1", "I$0"})
readonly class pf38d8cc7$pec4d1eb3$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int I$0;
    int I$1;
    java.lang.object L$0;
    java.lang.object L$1;
    int f5ea983ad;
    int f8bddd6c2;
    int fb4670876;
    java.lang.object fb4a88417;
    java.lang.object fbcb3a395;
    int fcf9fabd9;
    int fd304ba20;
    java.lang.object ff4e27089;
    readonly p4670093c.pb3f20355.pf38d8cc7 this$0;

    pf38d8cc7$pec4d1eb3$1(p4670093c.pb3f20355.pf38d8cc7 pf38d8cc7Var, kotlin.coroutines.Continuation<? super p4670093c.pb3f20355.pf38d8cc7$pec4d1eb3$1> continuation) {
        super(continuation);
        this.this$0 = pf38d8cc7Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.load(null, this);
    }
}

