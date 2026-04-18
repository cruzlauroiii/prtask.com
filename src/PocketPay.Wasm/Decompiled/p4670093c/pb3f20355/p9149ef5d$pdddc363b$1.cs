namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.pb3f20355.p9149ef5d", m533f = "PaybackReceiptRepositoryImpl.kt", m534i = {}, m535l = {324, 324}, m536m = "removeCurrentReceipt", m537n = {}, m538s = {})
readonly class p9149ef5d$pdddc363b$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f750c0c5e;
    int f80bafe80;
    java.lang.object fb49c54bc;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object ffc673bdc;
    readonly p4670093c.pb3f20355.p9149ef5d this$0;

    p9149ef5d$pdddc363b$1(p4670093c.pb3f20355.p9149ef5d p9149ef5dVar, kotlin.coroutines.Continuation<? super p4670093c.pb3f20355.p9149ef5d$pdddc363b$1> continuation) {
        super(continuation);
        this.this$0 = p9149ef5dVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.removeCurrentReceipt(this);
    }
}

