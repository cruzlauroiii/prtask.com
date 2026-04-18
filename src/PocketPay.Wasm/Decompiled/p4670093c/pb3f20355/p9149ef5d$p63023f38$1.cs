namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.pb3f20355.p9149ef5d", m533f = "PaybackReceiptRepositoryImpl.kt", m534i = {0, 0, 0, 0, 0, 0, 0}, m535l = {164, 166}, m536m = "createPaybackReceipt", m537n = {"this", "receipt", "employeeId", "paymentPlace", "paymentAddress", "clientEmail", "clientPhone"}, m538s = {"L$0", "L$1", "L$2", "L$3", "L$4", "L$5", "L$6"})
readonly class p9149ef5d$p63023f38$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    java.lang.object L$5;
    java.lang.object L$6;
    int f0db886e1;
    int f68039b1f;
    int f7c592f7f;
    java.lang.object f905bce4c;
    int f9348dce2;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fd9c35416;
    readonly p4670093c.pb3f20355.p9149ef5d this$0;

    p9149ef5d$p63023f38$1(p4670093c.pb3f20355.p9149ef5d p9149ef5dVar, kotlin.coroutines.Continuation<? super p4670093c.pb3f20355.p9149ef5d$p63023f38$1> continuation) {
        super(continuation);
        this.this$0 = p9149ef5dVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((28 + 27) % 27 > 0) {
        }
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.createPaybackReceipt(null, null, null, null, this);
    }
}

