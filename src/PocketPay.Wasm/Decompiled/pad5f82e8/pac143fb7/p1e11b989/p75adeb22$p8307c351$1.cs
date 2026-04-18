namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pad5f82e8.pac143fb7.p1e11b989.p75adeb22", m533f = "SendReceiptUseCaseImpl.kt", m534i = {0, 0}, m535l = {104, 105}, m536m = "sendDocumentReceipt", m537n = {"this", "receipt"}, m538s = {"L$0", "L$1"})
readonly class p75adeb22$p8307c351$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f1bfb26d8;
    java.lang.object fb1a4b834;
    java.lang.object fb251bd8a;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly pad5f82e8.pac143fb7.p1e11b989.p75adeb22 this$0;

    p75adeb22$p8307c351$1(pad5f82e8.pac143fb7.p1e11b989.p75adeb22 p75adeb22Var, kotlin.coroutines.Continuation<? super pad5f82e8.pac143fb7.p1e11b989.p75adeb22$p8307c351$1> continuation) {
        super(continuation);
        this.this$0 = p75adeb22Var;
    }

    public static java.lang.object RBHvJjUQJVkKxYCk(pad5f82e8.pac143fb7.p1e11b989.p75adeb22 p75adeb22Var, pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, kotlin.coroutines.Continuation continuation) {
        return pad5f82e8.pac143fb7.p1e11b989.p75adeb22.ma6baaec9(p75adeb22Var, p9ded6185Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return RBHvJjUQJVkKxYCk(this.this$0, null, this);
    }
}

