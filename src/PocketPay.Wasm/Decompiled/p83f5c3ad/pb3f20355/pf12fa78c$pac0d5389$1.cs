namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.pf12fa78c", m533f = "TophReceiptRepositoryImpl.kt", m534i = {0, 0, 0, 0, 1}, m535l = {27, 28, 29}, m536m = "sendReceiptToEmail", m537n = {"this", "receipt", "email", "rrn", "email"}, m538s = {"L$0", "L$1", "L$2", "L$3", "L$0"})
readonly class pf12fa78c$pac0d5389$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object f70b6ef4f;
    int f7426cb72;
    java.lang.object fb4a88417;
    int fcedfa094;
    int fd304ba20;
    readonly p83f5c3ad.pb3f20355.pf12fa78c this$0;

    pf12fa78c$pac0d5389$1(p83f5c3ad.pb3f20355.pf12fa78c pf12fa78cVar, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.pf12fa78c$pac0d5389$1> continuation) {
        super(continuation);
        this.this$0 = pf12fa78cVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.sendReceiptToEmail(null, null, null, this);
    }
}

