namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p0c985ebf.pb3f20355.p7b9f1380", m533f = "InspectionRepositoryImpl.kt", m534i = {}, m535l = {45, 44}, m536m = "updateInspectedPosition", m537n = {}, m538s = {})
readonly class p7b9f1380$p5b6ce138$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f002a7f6b;
    java.lang.object f40ef7837;
    int f4e465e7f;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fe1e4f903;
    java.lang.object fea9cd164;
    readonly p0c985ebf.pb3f20355.p7b9f1380 this$0;

    p7b9f1380$p5b6ce138$1(p0c985ebf.pb3f20355.p7b9f1380 p7b9f1380Var, kotlin.coroutines.Continuation<? super p0c985ebf.pb3f20355.p7b9f1380$p5b6ce138$1> continuation) {
        super(continuation);
        this.this$0 = p7b9f1380Var;
    }

    public static java.lang.object HCynIzQbKwPaDesU(p0c985ebf.pb3f20355.p7b9f1380 p7b9f1380Var, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation continuation) {
        return p7b9f1380Var.updateInspectedPosition(pd031d465Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return hCynIzQbKwPaDesU(this.this$0, null, this);
    }
}

