namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pb3f20355.p28f1bfa1", m533f = "MeasureRepositoryImpl.kt", m534i = {0}, m535l = {18, 20}, m536m = "replaceMeasures", m537n = {"this"}, m538s = {"L$0"})
readonly class p28f1bfa1$pb34f48c2$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f43bc1931;
    int f55077856;
    int f6a8d11fb;
    java.lang.object fb4a88417;
    java.lang.object fba9ca18b;
    int fc02e2c56;
    int fd304ba20;
    readonly p7a1eabc3.pb3f20355.p28f1bfa1 this$0;

    p28f1bfa1$pb34f48c2$1(p7a1eabc3.pb3f20355.p28f1bfa1 p28f1bfa1Var, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p28f1bfa1$pb34f48c2$1> continuation) {
        super(continuation);
        this.this$0 = p28f1bfa1Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.replaceMeasures(this);
    }
}

