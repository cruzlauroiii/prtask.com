namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8325324b.pb3f20355.p9dc39adc", m533f = "SellReceiptRepositoryImpl.kt", m534i = {0}, m535l = {115, 116}, m536m = "hasUnfinishedReceipt", m537n = {"this"}, m538s = {"L$0"})
readonly class p9dc39adc$p376e6596$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f25730322;
    java.lang.object f6e55d327;
    java.lang.object f8c9e1472;
    int f9577d4fb;
    java.lang.object f9d9acc50;
    java.lang.object fa2f320a2;
    java.lang.object fb4a88417;
    int fd304ba20;
    int ff42de071;
    readonly p8325324b.pb3f20355.p9dc39adc this$0;

    p9dc39adc$p376e6596$1(p8325324b.pb3f20355.p9dc39adc p9dc39adcVar, kotlin.coroutines.Continuation<? super p8325324b.pb3f20355.p9dc39adc$p376e6596$1> continuation) {
        super(continuation);
        this.this$0 = p9dc39adcVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.hasUnfinishedReceipt(this);
    }
}

