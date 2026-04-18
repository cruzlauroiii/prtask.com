namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.pb3f20355.p9149ef5d", m533f = "PaybackReceiptRepositoryImpl.kt", m534i = {0}, m535l = {229, 228}, m536m = "setPaymentType", m537n = {"paymentType"}, m538s = {"L$0"})
readonly class p9149ef5d$pb35f541c$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object f0b51a9fa;
    int f14ec9093;
    int f2bba4e3b;
    java.lang.object f64e094df;
    java.lang.object f9827c9d0;
    java.lang.object fb4a88417;
    int fc439bf7f;
    int fd304ba20;
    java.lang.object ffdca2357;
    readonly p4670093c.pb3f20355.p9149ef5d this$0;

    p9149ef5d$pb35f541c$1(p4670093c.pb3f20355.p9149ef5d p9149ef5dVar, kotlin.coroutines.Continuation<? super p4670093c.pb3f20355.p9149ef5d$pb35f541c$1> continuation) {
        super(continuation);
        this.this$0 = p9149ef5dVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.setPaymentType(null, this);
    }
}

