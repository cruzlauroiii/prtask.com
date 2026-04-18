namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p0c985ebf.pb3f20355.p7b9f1380", m533f = "InspectionRepositoryImpl.kt", m534i = {0}, m535l = {20, 23}, m536m = "getInspectionReceipt", m537n = {"this"}, m538s = {"L$0"})
readonly class p7b9f1380$pe667df07$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object f2781fbc5;
    java.lang.object f9921e918;
    int f9d9997fd;
    java.lang.object fb4a88417;
    java.lang.object fb5a68007;
    int fd304ba20;
    java.lang.object fe86ff590;
    readonly p0c985ebf.pb3f20355.p7b9f1380 this$0;

    p7b9f1380$pe667df07$1(p0c985ebf.pb3f20355.p7b9f1380 p7b9f1380Var, kotlin.coroutines.Continuation<? super p0c985ebf.pb3f20355.p7b9f1380$pe667df07$1> continuation) {
        super(continuation);
        this.this$0 = p7b9f1380Var;
    }

    public static java.lang.object LqfZXzzuBQceBOch(p0c985ebf.pb3f20355.p7b9f1380 p7b9f1380Var, kotlin.coroutines.Continuation continuation) {
        return p7b9f1380Var.getInspectionReceipt(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return lqfZXzzuBQceBOch(this.this$0, this);
    }
}

