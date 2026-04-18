namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.pb3f20355.p9149ef5d", m533f = "PaybackReceiptRepositoryImpl.kt", m534i = {}, m535l = {294, 293}, m536m = "addPaymentToReceipt", m537n = {}, m538s = {})
readonly class p9149ef5d$p89f84f65$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f06e3f852;
    int f0ee60d40;
    int f4669ac1b;
    int f47284674;
    java.lang.object f782df21f;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p4670093c.pb3f20355.p9149ef5d this$0;

    p9149ef5d$p89f84f65$1(p4670093c.pb3f20355.p9149ef5d p9149ef5dVar, kotlin.coroutines.Continuation<? super p4670093c.pb3f20355.p9149ef5d$p89f84f65$1> continuation) {
        super(continuation);
        this.this$0 = p9149ef5dVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.addPaymentToReceipt(null, this);
    }
}

