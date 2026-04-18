namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p1f946a21", m533f = "NfcTapOnPhoneUseCaseImpl.kt", m534i = {0, 0, 0}, m535l = {55, 56}, m536m = "setNfcCalibrationCoordinates", m537n = {"this", "terminal", "coordinates"}, m538s = {"L$0", "L$1", "L$2"})
readonly class p1f946a21$p89cd2ac7$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object f3752bc76;
    int f4c30f292;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fd43e50d7;
    java.lang.object fdc48654c;
    int fe464cc55;
    readonly p83f5c3ad.p684019bc.p1f946a21 this$0;

    p1f946a21$p89cd2ac7$1(p83f5c3ad.p684019bc.p1f946a21 p1f946a21Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p1f946a21$p89cd2ac7$1> continuation) {
        super(continuation);
        this.this$0 = p1f946a21Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.setNfcCalibrationCoordinates(null, null, this);
    }
}

