namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p404c086a", m533f = "BalanceTapOnPhoneUseCaseImpl.kt", m534i = {0, 0, 1, 1}, m535l = {25, 26, 27}, m536m = "startContactless", m537n = {"this", "balanceTransaction", "this", "balanceTransaction"}, m538s = {"L$0", "L$1", "L$0", "L$1"})
readonly class p404c086a$p99f0cdc5$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f0ec0e334;
    java.lang.object f498662e3;
    int f9ae522a1;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object ffab0dc0c;
    readonly p83f5c3ad.p684019bc.p404c086a this$0;

    p404c086a$p99f0cdc5$1(p83f5c3ad.p684019bc.p404c086a p404c086aVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p404c086a$p99f0cdc5$1> continuation) {
        super(continuation);
        this.this$0 = p404c086aVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.startContactless(null, this);
    }
}

