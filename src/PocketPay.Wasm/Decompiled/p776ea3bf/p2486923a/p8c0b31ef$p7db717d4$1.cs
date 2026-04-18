namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p776ea3bf.p2486923a.p8c0b31ef", m533f = "IntegrationAuthobjectModel.kt", m534i = {0}, m535l = {179, 180}, m536m = "startPayment", m537n = {"this"}, m538s = {"L$0"})
readonly class p8c0b31ef$p7db717d4$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f91f78a43;
    int f9f340be3;
    java.lang.object fb4a88417;
    int fc46ad9e7;
    java.lang.object fcb02ac82;
    int fd304ba20;
    int fd926f804;
    java.lang.object fe58638b4;
    java.lang.object fec126e43;
    readonly p776ea3bf.p2486923a.p8c0b31ef this$0;

    p8c0b31ef$p7db717d4$1(p776ea3bf.p2486923a.p8c0b31ef p8c0b31efVar, kotlin.coroutines.Continuation<? super p776ea3bf.p2486923a.p8c0b31ef$p7db717d4$1> continuation) {
        super(continuation);
        this.this$0 = p8c0b31efVar;
    }

    public static java.lang.object ZbsTxgPFJvXjUTBy(p776ea3bf.p2486923a.p8c0b31ef p8c0b31efVar, kotlin.coroutines.Continuation continuation) {
        return p776ea3bf.p2486923a.p8c0b31ef.mfc0096b6(p8c0b31efVar, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return ZbsTxgPFJvXjUTBy(this.this$0, this);
    }
}

