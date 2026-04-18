namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p0c985ebf.pb3f20355.p7b9f1380", m533f = "InspectionRepositoryImpl.kt", m534i = {0, 1}, m535l = {76, 82}, m536m = "getCurrentInspection", m537n = {"this", "defaultInspection"}, m538s = {"L$0", "L$0"})
readonly class p7b9f1380$p21677e51$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f3c4da4df;
    java.lang.object f3f458de9;
    java.lang.object fa9c84032;
    java.lang.object fb4a88417;
    java.lang.object fbea928bb;
    int fc0b0a591;
    int fd304ba20;
    readonly p0c985ebf.pb3f20355.p7b9f1380 this$0;

    p7b9f1380$p21677e51$1(p0c985ebf.pb3f20355.p7b9f1380 p7b9f1380Var, kotlin.coroutines.Continuation<? super p0c985ebf.pb3f20355.p7b9f1380$p21677e51$1> continuation) {
        super(continuation);
        this.this$0 = p7b9f1380Var;
    }

    public static java.lang.object JspPaByErzviNARw(p0c985ebf.pb3f20355.p7b9f1380 p7b9f1380Var, kotlin.coroutines.Continuation continuation) {
        return p0c985ebf.pb3f20355.p7b9f1380.mfa780334(p7b9f1380Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return JspPaByErzviNARw(this.this$0, this);
    }
}

