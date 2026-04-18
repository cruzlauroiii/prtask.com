namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.pb3f20355.p9149ef5d", m533f = "PaybackReceiptRepositoryImpl.kt", m534i = {0}, m535l = {271, 279}, m536m = "openSinglePaymentIfNeeded", m537n = {"this"}, m538s = {"L$0"})
readonly class p9149ef5d$pc3eb4d56$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f072560de;
    java.lang.object f5778216b;
    int f659261c7;
    int fa74c5bad;
    java.lang.object fac9a6333;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fdf959c7e;
    readonly p4670093c.pb3f20355.p9149ef5d this$0;

    p9149ef5d$pc3eb4d56$1(p4670093c.pb3f20355.p9149ef5d p9149ef5dVar, kotlin.coroutines.Continuation<? super p4670093c.pb3f20355.p9149ef5d$pc3eb4d56$1> continuation) {
        super(continuation);
        this.this$0 = p9149ef5dVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.openSinglePaymentIfNeeded(this);
    }
}

