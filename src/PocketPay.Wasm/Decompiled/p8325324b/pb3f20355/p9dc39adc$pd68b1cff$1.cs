namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8325324b.pb3f20355.p9dc39adc", m533f = "SellReceiptRepositoryImpl.kt", m534i = {}, m535l = {276, 276}, m536m = "removeAllPaymentsFromReceipt", m537n = {}, m538s = {})
readonly class p9dc39adc$pd68b1cff$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f268e5624;
    java.lang.object f2f53e9cd;
    java.lang.object f5569bafd;
    int f735b5952;
    int f79b17c7e;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object ff889d036;
    int ffd06f7b6;
    java.lang.object fff53b8e9;
    readonly p8325324b.pb3f20355.p9dc39adc this$0;

    p9dc39adc$pd68b1cff$1(p8325324b.pb3f20355.p9dc39adc p9dc39adcVar, kotlin.coroutines.Continuation<? super p8325324b.pb3f20355.p9dc39adc$pd68b1cff$1> continuation) {
        super(continuation);
        this.this$0 = p9dc39adcVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.removeAllPaymentsFromReceipt(this);
    }
}

