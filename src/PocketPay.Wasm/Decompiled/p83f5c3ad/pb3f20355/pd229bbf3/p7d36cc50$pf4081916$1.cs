namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.pd229bbf3.p7d36cc50", m533f = "BackgroundTapOnPhoneRepositoryImpl.kt", m534i = {1}, m535l = {16, 19}, m536m = "perform", m537n = {"this"}, m538s = {"L$0"})
readonly class p7d36cc50$pf4081916$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f1b114155;
    int f4bc76632;
    int f86e9d8d8;
    java.lang.object f8e87b983;
    java.lang.object fb4a88417;
    int fd304ba20;
    int ff1dc49a0;
    readonly p83f5c3ad.pb3f20355.pd229bbf3.p7d36cc50 this$0;

    p7d36cc50$pf4081916$1(p83f5c3ad.pb3f20355.pd229bbf3.p7d36cc50 p7d36cc50Var, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.pd229bbf3.p7d36cc50$pf4081916$1> continuation) {
        super(continuation);
        this.this$0 = p7d36cc50Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.perform(null, this);
    }
}

