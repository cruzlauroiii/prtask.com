namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8325324b.pb3f20355.p9dc39adc", m533f = "SellReceiptRepositoryImpl.kt", m534i = {}, m535l = {121}, m536m = "hasUnfinishedReceiptByDeviceId", m537n = {}, m538s = {})
readonly class p9dc39adc$p63bfe3f4$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f535b0979;
    int f62d1b9dd;
    int f66b71057;
    java.lang.object f9c886113;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object feb66cf58;
    int ffb5e2f97;
    readonly p8325324b.pb3f20355.p9dc39adc this$0;

    p9dc39adc$p63bfe3f4$1(p8325324b.pb3f20355.p9dc39adc p9dc39adcVar, kotlin.coroutines.Continuation<? super p8325324b.pb3f20355.p9dc39adc$p63bfe3f4$1> continuation) {
        super(continuation);
        this.this$0 = p9dc39adcVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return p8325324b.pb3f20355.p9dc39adc.m983b4fc6(this.this$0, null, this);
    }
}

