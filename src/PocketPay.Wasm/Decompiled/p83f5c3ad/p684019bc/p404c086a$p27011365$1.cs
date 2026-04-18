namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p404c086a", m533f = "BalanceTapOnPhoneUseCaseImpl.kt", m534i = {0, 0, 0, 1, 1, 1}, m535l = {19, 20, 21}, m536m = "initBalanceInquiry", m537n = {"this", "paymentTerminal", "transactionId", "this", "paymentTerminal", "transactionId"}, m538s = {"L$0", "L$1", "L$2", "L$0", "L$1", "L$2"})
readonly class p404c086a$p27011365$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f102d3ba0;
    java.lang.object f29dd74fe;
    java.lang.object f74be7c1a;
    int f8e9c22dd;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fdca1bbf4;
    java.lang.object feb891f47;
    readonly p83f5c3ad.p684019bc.p404c086a this$0;

    p404c086a$p27011365$1(p83f5c3ad.p684019bc.p404c086a p404c086aVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p404c086a$p27011365$1> continuation) {
        super(continuation);
        this.this$0 = p404c086aVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.initBalanceInquiry(null, null, this);
    }
}

