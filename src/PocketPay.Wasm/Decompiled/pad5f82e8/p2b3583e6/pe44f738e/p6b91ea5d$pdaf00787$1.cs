namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pad5f82e8.p2b3583e6.pe44f738e.p6b91ea5d", m533f = "SendQueueReceiptWorker.kt", m534i = {0, 1, 2}, m535l = {56, 59, 60}, m536m = "sendQueueReceipts", m537n = {"this", "this", "this"}, m538s = {"L$0", "L$0", "L$0"})
readonly class p6b91ea5d$pdaf00787$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f5dbfba2b;
    java.lang.object f9d3f17e0;
    int fa8dbb7e5;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fdc3797dd;
    java.lang.object fec1c9c30;
    readonly pad5f82e8.p2b3583e6.pe44f738e.p6b91ea5d this$0;

    p6b91ea5d$pdaf00787$1(pad5f82e8.p2b3583e6.pe44f738e.p6b91ea5d p6b91ea5dVar, kotlin.coroutines.Continuation<? super pad5f82e8.p2b3583e6.pe44f738e.p6b91ea5d$pdaf00787$1> continuation) {
        super(continuation);
        this.this$0 = p6b91ea5dVar;
    }

    public static java.lang.object QABeZlvoBnIoSSwl(pad5f82e8.p2b3583e6.pe44f738e.p6b91ea5d p6b91ea5dVar, kotlin.coroutines.Continuation continuation) {
        return pad5f82e8.p2b3583e6.pe44f738e.p6b91ea5d.m7600fd38(p6b91ea5dVar, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return QABeZlvoBnIoSSwl(this.this$0, this);
    }
}

