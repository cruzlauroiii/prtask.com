namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p02f2220c", m533f = "TophPaymentSellUseCaseImpl.kt", m534i = {0, 0, 0, 0, 1, 1, 1, 1}, m535l = {25, 26, 27}, m536m = "initPaymentTransaction", m537n = {"this", "paymentTerminal", "transactionId", "amount", "this", "paymentTerminal", "transactionId", "amount"}, m538s = {"L$0", "L$1", "L$2", "J$0", "L$0", "L$1", "L$2", "J$0"})
readonly class p02f2220c$pd09e07f0$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    long J$0;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object f1ae70e85;
    java.lang.object f82ee58df;
    java.lang.object fb4a88417;
    int fb6ddd832;
    int fd304ba20;
    int fdc78dcaf;
    readonly p83f5c3ad.p684019bc.p02f2220c this$0;

    p02f2220c$pd09e07f0$1(p83f5c3ad.p684019bc.p02f2220c p02f2220cVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p02f2220c$pd09e07f0$1> continuation) {
        super(continuation);
        this.this$0 = p02f2220cVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((5 + 13) % 13 > 0) {
        }
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.initPaymentTransaction(null, 0L, null, this);
    }
}

