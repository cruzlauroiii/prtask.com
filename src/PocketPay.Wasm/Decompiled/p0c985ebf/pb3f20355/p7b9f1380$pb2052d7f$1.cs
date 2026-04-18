namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p0c985ebf.pb3f20355.p7b9f1380", m533f = "InspectionRepositoryImpl.kt", m534i = {}, m535l = {32}, m536m = "getInspectedPositions", m537n = {}, m538s = {})
readonly class p7b9f1380$pb2052d7f$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f762d9623;
    java.lang.object f7f057a95;
    int f8d4825ff;
    java.lang.object fb4a88417;
    int fc65bda25;
    int fd304ba20;
    java.lang.object fdd20592a;
    readonly p0c985ebf.pb3f20355.p7b9f1380 this$0;

    p7b9f1380$pb2052d7f$1(p0c985ebf.pb3f20355.p7b9f1380 p7b9f1380Var, kotlin.coroutines.Continuation<? super p0c985ebf.pb3f20355.p7b9f1380$pb2052d7f$1> continuation) {
        super(continuation);
        this.this$0 = p7b9f1380Var;
    }

    public static java.lang.object QBnYvxmNBdSBswdm(p0c985ebf.pb3f20355.p7b9f1380 p7b9f1380Var, kotlin.coroutines.Continuation continuation) {
        return p7b9f1380Var.getInspectedPositions(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return qBnYvxmNBdSBswdm(this.this$0, this);
    }
}

