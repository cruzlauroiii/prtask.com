namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.pf12fa78c", m533f = "TophReceiptRepositoryImpl.kt", m534i = {0, 1}, m535l = {71, 74}, m536m = "getTransactionById", m537n = {"receipt", "receipt"}, m538s = {"L$0", "L$0"})
readonly class pf12fa78c$p6b9817f1$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f3a7337a0;
    java.lang.object fb4a88417;
    int fb8d96001;
    java.lang.object fbd688175;
    int fd304ba20;
    readonly p83f5c3ad.pb3f20355.pf12fa78c this$0;

    pf12fa78c$p6b9817f1$1(p83f5c3ad.pb3f20355.pf12fa78c pf12fa78cVar, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.pf12fa78c$p6b9817f1$1> continuation) {
        super(continuation);
        this.this$0 = pf12fa78cVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return p83f5c3ad.pb3f20355.pf12fa78c.mb6236ae3(this.this$0, null, null, this);
    }
}

