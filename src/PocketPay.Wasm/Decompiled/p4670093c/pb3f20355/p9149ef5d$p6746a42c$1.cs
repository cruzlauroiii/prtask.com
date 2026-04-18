namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.pb3f20355.p9149ef5d", m533f = "PaybackReceiptRepositoryImpl.kt", m534i = {0}, m535l = {248, 247}, m536m = "setPaymentAddress", m537n = {"paymentAddress"}, m538s = {"L$0"})
readonly class p9149ef5d$p6746a42c$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object fae20390d;
    java.lang.object fb4a88417;
    int fbf41fd6b;
    int fd304ba20;
    int fe7510de9;
    int ffce6e8fe;
    readonly p4670093c.pb3f20355.p9149ef5d this$0;

    p9149ef5d$p6746a42c$1(p4670093c.pb3f20355.p9149ef5d p9149ef5dVar, kotlin.coroutines.Continuation<? super p4670093c.pb3f20355.p9149ef5d$p6746a42c$1> continuation) {
        super(continuation);
        this.this$0 = p9149ef5dVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.setPaymentAddress(null, this);
    }
}

