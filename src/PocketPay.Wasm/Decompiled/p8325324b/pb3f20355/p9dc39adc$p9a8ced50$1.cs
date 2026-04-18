namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8325324b.pb3f20355.p9dc39adc", m533f = "SellReceiptRepositoryImpl.kt", m534i = {0}, m535l = {146, 145}, m536m = "setReceiptClientPhone", m537n = {"phone"}, m538s = {"L$0"})
readonly class p9dc39adc$p9a8ced50$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object f3963ccf3;
    int f54bb554a;
    java.lang.object fae388735;
    java.lang.object fb4a88417;
    java.lang.object fbc852dd3;
    int fd304ba20;
    readonly p8325324b.pb3f20355.p9dc39adc this$0;

    p9dc39adc$p9a8ced50$1(p8325324b.pb3f20355.p9dc39adc p9dc39adcVar, kotlin.coroutines.Continuation<? super p8325324b.pb3f20355.p9dc39adc$p9a8ced50$1> continuation) {
        super(continuation);
        this.this$0 = p9dc39adcVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.setReceiptClientPhone(null, this);
    }
}

