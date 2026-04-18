namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p6179dbd9", m533f = "PaybackTapOnPhoneUseCaseImpl.kt", m534i = {0, 0, 0, 0, 1, 1, 1, 1}, m535l = {22, 23, 24}, m536m = "initPayback", m537n = {"this", "receipt", "rrn", "amount", "this", "receipt", "rrn", "amount"}, m538s = {"L$0", "L$1", "L$2", "J$0", "L$0", "L$1", "L$2", "J$0"})
readonly class p6179dbd9$p6d9e0861$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    long J$0;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object f3900a9b2;
    int f5d03a112;
    java.lang.object f6d8d9aaa;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object ffd644262;
    readonly p83f5c3ad.p684019bc.p6179dbd9 this$0;

    p6179dbd9$p6d9e0861$1(p83f5c3ad.p684019bc.p6179dbd9 p6179dbd9Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p6179dbd9$p6d9e0861$1> continuation) {
        super(continuation);
        this.this$0 = p6179dbd9Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((21 + 2) % 2 > 0) {
        }
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.initPayback(null, 0L, null, this);
    }
}

