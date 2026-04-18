namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p1f946a21", m533f = "NfcTapOnPhoneUseCaseImpl.kt", m534i = {0, 0}, m535l = {31, 32}, m536m = "calibrateNfc", m537n = {"this", "terminal"}, m538s = {"L$0", "L$1"})
readonly class p1f946a21$p8b4c9bdf$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f27eda162;
    int f57ec6e3a;
    java.lang.object fae2f8eea;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fe5579044;
    readonly p83f5c3ad.p684019bc.p1f946a21 this$0;

    p1f946a21$p8b4c9bdf$1(p83f5c3ad.p684019bc.p1f946a21 p1f946a21Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p1f946a21$p8b4c9bdf$1> continuation) {
        super(continuation);
        this.this$0 = p1f946a21Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.calibrateNfc(null, this);
    }
}

