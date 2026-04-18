namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8325324b.pb3f20355.p9dc39adc", m533f = "SellReceiptRepositoryImpl.kt", m534i = {0, 1, 1}, m535l = {56, 57, 58, 60}, m536m = "openOrEditSellReceipt", m537n = {"this", "this", "deviceId"}, m538s = {"L$0", "L$0", "L$1"})
readonly class p9dc39adc$pd1dc819f$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f268a5acc;
    int f37f1d1ac;
    java.lang.object f3d518dfc;
    java.lang.object f82f9329a;
    int fabab0795;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fedfa7562;
    int fee778c2f;
    readonly p8325324b.pb3f20355.p9dc39adc this$0;

    p9dc39adc$pd1dc819f$1(p8325324b.pb3f20355.p9dc39adc p9dc39adcVar, kotlin.coroutines.Continuation<? super p8325324b.pb3f20355.p9dc39adc$pd1dc819f$1> continuation) {
        super(continuation);
        this.this$0 = p9dc39adcVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.openOrEditSellReceipt(this);
    }
}

