namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p02f2220c", m533f = "TophPaymentSellUseCaseImpl.kt", m534i = {0, 0, 1, 1}, m535l = {37, 38, 39}, m536m = "onlineApproval", m537n = {"this", "paymentTransaction", "this", "paymentTransaction"}, m538s = {"L$0", "L$1", "L$0", "L$1"})
readonly class p02f2220c$pfa99fdf9$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object f14a69a24;
    java.lang.object f362160e7;
    int f895f74f1;
    java.lang.object fa213cc22;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p83f5c3ad.p684019bc.p02f2220c this$0;

    p02f2220c$pfa99fdf9$1(p83f5c3ad.p684019bc.p02f2220c p02f2220cVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p02f2220c$pfa99fdf9$1> continuation) {
        super(continuation);
        this.this$0 = p02f2220cVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.onlineApproval(null, this);
    }
}

