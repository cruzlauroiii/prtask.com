namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p02f2220c", m533f = "TophPaymentSellUseCaseImpl.kt", m534i = {0, 0, 1, 1}, m535l = {31, 32, 33}, m536m = "startContactless", m537n = {"this", "paymentTransaction", "this", "paymentTransaction"}, m538s = {"L$0", "L$1", "L$0", "L$1"})
readonly class p02f2220c$p99f0cdc5$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f7326373b;
    int f823f2784;
    java.lang.object f98057db4;
    int fb3dfd927;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p83f5c3ad.p684019bc.p02f2220c this$0;

    p02f2220c$p99f0cdc5$1(p83f5c3ad.p684019bc.p02f2220c p02f2220cVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p02f2220c$p99f0cdc5$1> continuation) {
        super(continuation);
        this.this$0 = p02f2220cVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.startContactless(null, this);
    }
}

