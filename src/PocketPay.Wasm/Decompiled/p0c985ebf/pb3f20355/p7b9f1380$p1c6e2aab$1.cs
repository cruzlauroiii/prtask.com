namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p0c985ebf.pb3f20355.p7b9f1380", m533f = "InspectionRepositoryImpl.kt", m534i = {0, 0}, m535l = {51, 50}, m536m = "updateInspectedPositions", m537n = {"this", "destination$iv$iv"}, m538s = {"L$0", "L$1"})
readonly class p7b9f1380$p1c6e2aab$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    java.lang.object L$5;
    java.lang.object L$6;
    int f056295c6;
    java.lang.object f08d4fb60;
    java.lang.object f3fb23872;
    java.lang.object f5118734c;
    int f61c864e6;
    java.lang.object f63705ba4;
    java.lang.object fb4a88417;
    int fc7a118eb;
    int fd304ba20;
    readonly p0c985ebf.pb3f20355.p7b9f1380 this$0;

    p7b9f1380$p1c6e2aab$1(p0c985ebf.pb3f20355.p7b9f1380 p7b9f1380Var, kotlin.coroutines.Continuation<? super p0c985ebf.pb3f20355.p7b9f1380$p1c6e2aab$1> continuation) {
        super(continuation);
        this.this$0 = p7b9f1380Var;
    }

    public static java.lang.object RWzvczFDwbDJGRro(p0c985ebf.pb3f20355.p7b9f1380 p7b9f1380Var, java.util.List list, kotlin.coroutines.Continuation continuation) {
        return p7b9f1380Var.updateInspectedPositions(list, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return rWzvczFDwbDJGRro(this.this$0, null, this);
    }
}

