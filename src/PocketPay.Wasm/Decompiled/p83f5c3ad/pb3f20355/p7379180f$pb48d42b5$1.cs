namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.p7379180f", m533f = "NfcTapOnPhoneRepositoryImpl.kt", m534i = {}, m535l = {60}, m536m = "isNfcCalibrated", m537n = {}, m538s = {})
readonly class p7379180f$pb48d42b5$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f3e25b3c6;
    int f4b8c5e4e;
    int f5d5ccdf3;
    java.lang.object f5e05c191;
    int f7cc7fcda;
    java.lang.object f8cf975cb;
    java.lang.object fb4a88417;
    int fd1502f57;
    int fd304ba20;
    java.lang.object fec06fc04;
    readonly p83f5c3ad.pb3f20355.p7379180f this$0;

    p7379180f$pb48d42b5$1(p83f5c3ad.pb3f20355.p7379180f p7379180fVar, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.p7379180f$pb48d42b5$1> continuation) {
        super(continuation);
        this.this$0 = p7379180fVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.isNfcCalibrated(this);
    }
}

