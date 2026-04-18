namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.pf12fa78c", m533f = "TophReceiptRepositoryImpl.kt", m534i = {0, 0, 0}, m535l = {53, 53}, m536m = "getTransactionFromHistory", m537n = {"this", "terminal", "receipt"}, m538s = {"L$0", "L$1", "L$2"})
readonly class pf12fa78c$p5bba670d$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f395f688f;
    int f44fe6f54;
    java.lang.object f84263955;
    java.lang.object f9e13df5f;
    int fa97aad0c;
    java.lang.object fb3a06f13;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p83f5c3ad.pb3f20355.pf12fa78c this$0;

    pf12fa78c$p5bba670d$1(p83f5c3ad.pb3f20355.pf12fa78c pf12fa78cVar, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.pf12fa78c$p5bba670d$1> continuation) {
        super(continuation);
        this.this$0 = pf12fa78cVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getTransactionFromHistory(null, null, null, this);
    }
}

