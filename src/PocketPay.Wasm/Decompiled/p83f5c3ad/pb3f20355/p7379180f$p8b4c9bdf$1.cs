namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.p7379180f", m533f = "NfcTapOnPhoneRepositoryImpl.kt", m534i = {}, m535l = {55}, m536m = "calibrateNfc", m537n = {}, m538s = {})
readonly class p7379180f$p8b4c9bdf$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f11cb03c5;
    java.lang.object f3d65d094;
    java.lang.object fb3994de4;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fd3e320b7;
    int fdb7ca2b5;
    readonly p83f5c3ad.pb3f20355.p7379180f this$0;

    p7379180f$p8b4c9bdf$1(p83f5c3ad.pb3f20355.p7379180f p7379180fVar, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.p7379180f$p8b4c9bdf$1> continuation) {
        super(continuation);
        this.this$0 = p7379180fVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.calibrateNfc(null, this);
    }
}

