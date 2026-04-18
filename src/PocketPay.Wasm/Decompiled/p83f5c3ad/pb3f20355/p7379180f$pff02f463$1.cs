namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.p7379180f", m533f = "NfcTapOnPhoneRepositoryImpl.kt", m534i = {}, m535l = {69, 70}, m536m = "getNfcCalibrationCoordinates", m537n = {}, m538s = {})
readonly class p7379180f$pff02f463$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f8fcf2768;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fdc6e2983;
    readonly p83f5c3ad.pb3f20355.p7379180f this$0;

    p7379180f$pff02f463$1(p83f5c3ad.pb3f20355.p7379180f p7379180fVar, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.p7379180f$pff02f463$1> continuation) {
        super(continuation);
        this.this$0 = p7379180fVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return p83f5c3ad.pb3f20355.p7379180f.me290bebc(this.this$0, this);
    }
}

