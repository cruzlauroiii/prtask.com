namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p1e11b989.p9acb4454.pb3f20355.p79dd8558", m533f = "ReceiptStatusServerRepositoryImpl.kt", m534i = {}, m535l = {26}, m536m = "getReceipts", m537n = {}, m538s = {})
readonly class p79dd8558$pbf619c3e$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f04882789;
    int f23d441c5;
    java.lang.object f584cc2e8;
    int f613bd3b1;
    int f909497a5;
    java.lang.object f97cb59bb;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object ffe449395;
    readonly p1e11b989.p9acb4454.pb3f20355.p79dd8558 this$0;

    p79dd8558$pbf619c3e$1(p1e11b989.p9acb4454.pb3f20355.p79dd8558 p79dd8558Var, kotlin.coroutines.Continuation<? super p1e11b989.p9acb4454.pb3f20355.p79dd8558$pbf619c3e$1> continuation) {
        super(continuation);
        this.this$0 = p79dd8558Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((26 + 19) % 19 > 0) {
        }
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getReceipts(null, 0, 0, 0L, 0L, null, null, null, null, this);
    }
}

