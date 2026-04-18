namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pad5f82e8.pac143fb7.p1e11b989.pa9d1cbf7.p68ef3c5f", m533f = "QueueReceiptUseCaseImpl.kt", m534i = {0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2}, m535l = {32, 50, 52}, m536m = "sendReceipt", m537n = {"this", "queueReceipt", "fromClassName", "this", "queueReceipt", "fromClassName", "$this$sendReceipt_u24lambda_u240", "this", "queueReceipt", "fromClassName", "$this$sendReceipt_u24lambda_u240"}, m538s = {"L$0", "L$1", "L$2", "L$0", "L$1", "L$2", "L$3", "L$0", "L$1", "L$2", "L$3"})
readonly class p68ef3c5f$p807ee7c0$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    int f1a47e4f8;
    java.lang.object f99b45df6;
    java.lang.object fa3479e3f;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fd4867866;
    java.lang.object ff88adb46;
    readonly pad5f82e8.pac143fb7.p1e11b989.pa9d1cbf7.p68ef3c5f this$0;

    p68ef3c5f$p807ee7c0$1(pad5f82e8.pac143fb7.p1e11b989.pa9d1cbf7.p68ef3c5f p68ef3c5fVar, kotlin.coroutines.Continuation<? super pad5f82e8.pac143fb7.p1e11b989.pa9d1cbf7.p68ef3c5f$p807ee7c0$1> continuation) {
        super(continuation);
        this.this$0 = p68ef3c5fVar;
    }

    public static java.lang.object McZbsFEaEKmOtrBq(pad5f82e8.pac143fb7.p1e11b989.pa9d1cbf7.p68ef3c5f p68ef3c5fVar, pad5f82e8.p07214c67.p1e11b989.p93478e59 p93478e59Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return p68ef3c5fVar.sendReceipt(p93478e59Var, str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return McZbsFEaEKmOtrBq(this.this$0, null, null, this);
    }
}

