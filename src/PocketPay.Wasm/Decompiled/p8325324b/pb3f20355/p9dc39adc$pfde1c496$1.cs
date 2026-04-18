namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8325324b.pb3f20355.p9dc39adc", m533f = "SellReceiptRepositoryImpl.kt", m534i = {}, m535l = {182, 181}, m536m = "clearReceiptDiscount", m537n = {}, m538s = {})
readonly class p9dc39adc$pfde1c496$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f1a3be496;
    java.lang.object f278dd135;
    java.lang.object f52794e29;
    java.lang.object f7b3d067b;
    int f7ff12bb1;
    int f94a2949a;
    java.lang.object fb4a88417;
    java.lang.object fc62f57f7;
    int fd304ba20;
    int fd865e55a;
    readonly p8325324b.pb3f20355.p9dc39adc this$0;

    p9dc39adc$pfde1c496$1(p8325324b.pb3f20355.p9dc39adc p9dc39adcVar, kotlin.coroutines.Continuation<? super p8325324b.pb3f20355.p9dc39adc$pfde1c496$1> continuation) {
        super(continuation);
        this.this$0 = p9dc39adcVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.clearReceiptDiscount(this);
    }
}

