namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p1f946a21", m533f = "NfcTapOnPhoneUseCaseImpl.kt", m534i = {0}, m535l = {38, 39}, m536m = "isNfcCalibrated", m537n = {"this"}, m538s = {"L$0"})
readonly class p1f946a21$pb48d42b5$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f242755d6;
    int f4b6bf716;
    java.lang.object f5657a330;
    java.lang.object f79f55a8f;
    java.lang.object f84ea99d5;
    java.lang.object f8e4dd7c5;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p83f5c3ad.p684019bc.p1f946a21 this$0;

    p1f946a21$pb48d42b5$1(p83f5c3ad.p684019bc.p1f946a21 p1f946a21Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p1f946a21$pb48d42b5$1> continuation) {
        super(continuation);
        this.this$0 = p1f946a21Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.isNfcCalibrated(this);
    }
}

