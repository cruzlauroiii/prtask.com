namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.pb3f20355.p9149ef5d", m533f = "PaybackReceiptRepositoryImpl.kt", m534i = {0, 1}, m535l = {195, 196}, m536m = "getCurrentPaybackReceipt", m537n = {"this", "receiptFromDb"}, m538s = {"L$0", "L$0"})
readonly class p9149ef5d$p194f5207$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f329ea4bd;
    java.lang.object f347eadda;
    java.lang.object f55d0fbde;
    int f8c37067b;
    java.lang.object fa7f7695a;
    int faf3e38e8;
    java.lang.object fb4a88417;
    int fc57357dd;
    int fd304ba20;
    java.lang.object fe0a6d842;
    readonly p4670093c.pb3f20355.p9149ef5d this$0;

    p9149ef5d$p194f5207$1(p4670093c.pb3f20355.p9149ef5d p9149ef5dVar, kotlin.coroutines.Continuation<? super p4670093c.pb3f20355.p9149ef5d$p194f5207$1> continuation) {
        super(continuation);
        this.this$0 = p9149ef5dVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getCurrentPaybackReceipt(this);
    }
}

