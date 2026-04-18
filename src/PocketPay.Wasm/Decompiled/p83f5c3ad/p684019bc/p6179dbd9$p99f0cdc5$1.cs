namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p6179dbd9", m533f = "PaybackTapOnPhoneUseCaseImpl.kt", m534i = {0, 0, 1, 1}, m535l = {28, 29, 30}, m536m = "startContactless", m537n = {"this", "tophPayback", "this", "tophPayback"}, m538s = {"L$0", "L$1", "L$0", "L$1"})
readonly class p6179dbd9$p99f0cdc5$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f2150741f;
    java.lang.object f905edea1;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fe03d5f77;
    readonly p83f5c3ad.p684019bc.p6179dbd9 this$0;

    p6179dbd9$p99f0cdc5$1(p83f5c3ad.p684019bc.p6179dbd9 p6179dbd9Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p6179dbd9$p99f0cdc5$1> continuation) {
        super(continuation);
        this.this$0 = p6179dbd9Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.startContactless(null, this);
    }
}

