namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8325324b.pb3f20355.p9dc39adc", m533f = "SellReceiptRepositoryImpl.kt", m534i = {}, m535l = {128}, m536m = "getNoteReceipt", m537n = {}, m538s = {})
readonly class p9dc39adc$p518c0d58$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f6e939afd;
    java.lang.object f7f1c6d38;
    java.lang.object f9e769fde;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fec9a2f36;
    readonly p8325324b.pb3f20355.p9dc39adc this$0;

    p9dc39adc$p518c0d58$1(p8325324b.pb3f20355.p9dc39adc p9dc39adcVar, kotlin.coroutines.Continuation<? super p8325324b.pb3f20355.p9dc39adc$p518c0d58$1> continuation) {
        super(continuation);
        this.this$0 = p9dc39adcVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getNoteReceipt(this);
    }
}

