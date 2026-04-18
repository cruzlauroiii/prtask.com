namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8325324b.pb3f20355.p9dc39adc", m533f = "SellReceiptRepositoryImpl.kt", m534i = {}, m535l = {227, 226}, m536m = "removePositionFromReceipt", m537n = {}, m538s = {})
readonly class p9dc39adc$pc5336464$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f3542c3e4;
    int f3a026d8f;
    java.lang.object f7fae4fa7;
    int f813244cc;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fe0821efe;
    readonly p8325324b.pb3f20355.p9dc39adc this$0;

    p9dc39adc$pc5336464$1(p8325324b.pb3f20355.p9dc39adc p9dc39adcVar, kotlin.coroutines.Continuation<? super p8325324b.pb3f20355.p9dc39adc$pc5336464$1> continuation) {
        super(continuation);
        this.this$0 = p9dc39adcVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.removePositionFromReceipt(null, this);
    }
}

