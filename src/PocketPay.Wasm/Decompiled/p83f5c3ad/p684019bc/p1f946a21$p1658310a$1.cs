namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p1f946a21", m533f = "NfcTapOnPhoneUseCaseImpl.kt", m534i = {0}, m535l = {45, 46}, m536m = "getShowedNfcCalibrationCoordinates", m537n = {"this"}, m538s = {"L$0"})
readonly class p1f946a21$p1658310a$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f00c797f6;
    int f555a4321;
    int f5ac79ad3;
    java.lang.object fb4a88417;
    java.lang.object fc90792b3;
    int fd304ba20;
    int fd5e28fe9;
    int ff7249ac3;
    readonly p83f5c3ad.p684019bc.p1f946a21 this$0;

    p1f946a21$p1658310a$1(p83f5c3ad.p684019bc.p1f946a21 p1f946a21Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p1f946a21$p1658310a$1> continuation) {
        super(continuation);
        this.this$0 = p1f946a21Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getShowedNfcCalibrationCoordinates(this);
    }
}

