namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pad5f82e8.pac143fb7.p1e11b989.p75adeb22", m533f = "SendReceiptUseCaseImpl.kt", m534i = {0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3}, m535l = {146, 152, 155, 161}, m536m = "saveQueueReceiptToDb", m537n = {"this", "receipt", "fromClassName", "this", "receipt", "fromClassName", "this", "receipt", "fromClassName", "this", "receipt", "fromClassName"}, m538s = {"L$0", "L$1", "L$2", "L$0", "L$1", "L$2", "L$0", "L$1", "L$2", "L$0", "L$1", "L$2"})
readonly class p75adeb22$p812699ae$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object f1935edf3;
    java.lang.object f437764f5;
    int f64ab1022;
    java.lang.object f9b833289;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly pad5f82e8.pac143fb7.p1e11b989.p75adeb22 this$0;

    p75adeb22$p812699ae$1(pad5f82e8.pac143fb7.p1e11b989.p75adeb22 p75adeb22Var, kotlin.coroutines.Continuation<? super pad5f82e8.pac143fb7.p1e11b989.p75adeb22$p812699ae$1> continuation) {
        super(continuation);
        this.this$0 = p75adeb22Var;
    }

    public static java.lang.object PnCmPViAeBukMDFj(pad5f82e8.pac143fb7.p1e11b989.p75adeb22 p75adeb22Var, pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation continuation) {
        return p75adeb22Var.saveQueueReceiptToDb(p9ded6185Var, str, str2, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return PnCmPViAeBukMDFj(this.this$0, null, null, null, this);
    }
}

