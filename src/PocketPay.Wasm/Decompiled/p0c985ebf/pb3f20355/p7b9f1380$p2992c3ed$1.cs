namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p0c985ebf.pb3f20355.p7b9f1380", m533f = "InspectionRepositoryImpl.kt", m534i = {}, m535l = {63, 62}, m536m = "addPositionToInspect", m537n = {}, m538s = {})
readonly class p7b9f1380$p2992c3ed$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f0755f35b;
    int f42566e61;
    int f47382884;
    int f70d9dca6;
    java.lang.object f7703ed2d;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object ff3b943dc;
    readonly p0c985ebf.pb3f20355.p7b9f1380 this$0;

    p7b9f1380$p2992c3ed$1(p0c985ebf.pb3f20355.p7b9f1380 p7b9f1380Var, kotlin.coroutines.Continuation<? super p0c985ebf.pb3f20355.p7b9f1380$p2992c3ed$1> continuation) {
        super(continuation);
        this.this$0 = p7b9f1380Var;
    }

    public static java.lang.object CVZRAigueelJDFBM(p0c985ebf.pb3f20355.p7b9f1380 p7b9f1380Var, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation continuation) {
        return p7b9f1380Var.addPositionToInspect(pd031d465Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return CVZRAigueelJDFBM(this.this$0, null, this);
    }
}

