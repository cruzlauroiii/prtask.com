namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pad5f82e8.p2b3583e6.pe44f738e.p6b91ea5d", m533f = "SendQueueReceiptWorker.kt", m534i = {}, m535l = {47}, m536m = "doWork", m537n = {}, m538s = {})
readonly class p6b91ea5d$pe82def02$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f37a92424;
    java.lang.object f3b217da8;
    java.lang.object f6681963d;
    java.lang.object fa3708aa2;
    java.lang.object fb4a88417;
    int fc28af75c;
    int fd304ba20;
    int fe5367531;
    readonly pad5f82e8.p2b3583e6.pe44f738e.p6b91ea5d this$0;

    p6b91ea5d$pe82def02$1(pad5f82e8.p2b3583e6.pe44f738e.p6b91ea5d p6b91ea5dVar, kotlin.coroutines.Continuation<? super pad5f82e8.p2b3583e6.pe44f738e.p6b91ea5d$pe82def02$1> continuation) {
        super(continuation);
        this.this$0 = p6b91ea5dVar;
    }

    public static java.lang.object KWOitGoIGPXepvLm(pad5f82e8.p2b3583e6.pe44f738e.p6b91ea5d p6b91ea5dVar, kotlin.coroutines.Continuation continuation) {
        return p6b91ea5dVar.doWork(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return KWOitGoIGPXepvLm(this.this$0, this);
    }
}

