namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p6179dbd9", m533f = "PaybackTapOnPhoneUseCaseImpl.kt", m534i = {0, 0, 1, 1}, m535l = {34, 35, 36}, m536m = "makePayback", m537n = {"this", "tophPayback", "this", "tophPayback"}, m538s = {"L$0", "L$1", "L$0", "L$1"})
readonly class p6179dbd9$p078de3ac$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object fa1c98c17;
    java.lang.object fb4a88417;
    int fc2bfdf32;
    int fd304ba20;
    int ff41125fa;
    readonly p83f5c3ad.p684019bc.p6179dbd9 this$0;

    p6179dbd9$p078de3ac$1(p83f5c3ad.p684019bc.p6179dbd9 p6179dbd9Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p6179dbd9$p078de3ac$1> continuation) {
        super(continuation);
        this.this$0 = p6179dbd9Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.makePayback(null, this);
    }
}

