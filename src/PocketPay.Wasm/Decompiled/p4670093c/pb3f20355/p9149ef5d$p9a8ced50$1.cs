namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.pb3f20355.p9149ef5d", m533f = "PaybackReceiptRepositoryImpl.kt", m534i = {0}, m535l = {220, 219}, m536m = "setReceiptClientPhone", m537n = {"phone"}, m538s = {"L$0"})
readonly class p9149ef5d$p9a8ced50$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f4ec54c2e;
    java.lang.object faac54875;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object ff6460249;
    int ffb3d84c4;
    readonly p4670093c.pb3f20355.p9149ef5d this$0;

    p9149ef5d$p9a8ced50$1(p4670093c.pb3f20355.p9149ef5d p9149ef5dVar, kotlin.coroutines.Continuation<? super p4670093c.pb3f20355.p9149ef5d$p9a8ced50$1> continuation) {
        super(continuation);
        this.this$0 = p9149ef5dVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.setReceiptClientPhone(null, this);
    }
}

