namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8325324b.pb3f20355.p9dc39adc", m533f = "SellReceiptRepositoryImpl.kt", m534i = {0, 0, 0}, m535l = {209, 210}, m536m = "replacePosition", m537n = {"this", "oldPosition", "newPosition"}, m538s = {"L$0", "L$1", "L$2"})
readonly class p9dc39adc$pb7ecc47b$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f739b0a9f;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fd3e77306;
    java.lang.object fe56c9c62;
    int ff91fa04d;
    int ffb0eb732;
    readonly p8325324b.pb3f20355.p9dc39adc this$0;

    p9dc39adc$pb7ecc47b$1(p8325324b.pb3f20355.p9dc39adc p9dc39adcVar, kotlin.coroutines.Continuation<? super p8325324b.pb3f20355.p9dc39adc$pb7ecc47b$1> continuation) {
        super(continuation);
        this.this$0 = p9dc39adcVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.replacePosition(null, null, this);
    }
}

