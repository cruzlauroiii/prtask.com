namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pb3f20355.p28f1bfa1", m533f = "MeasureRepositoryImpl.kt", m534i = {0}, m535l = {42}, m536m = "getDefaultMeasure", m537n = {"localeType"}, m538s = {"L$0"})
readonly class p28f1bfa1$pb448df54$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f3eea0e7c;
    java.lang.object f67347c30;
    int fa8a71a7a;
    java.lang.object fb4a88417;
    int fc26dfd3a;
    java.lang.object fc3d536f4;
    int fd304ba20;
    int fd5836822;
    int febf1293c;
    readonly p7a1eabc3.pb3f20355.p28f1bfa1 this$0;

    p28f1bfa1$pb448df54$1(p7a1eabc3.pb3f20355.p28f1bfa1 p28f1bfa1Var, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p28f1bfa1$pb448df54$1> continuation) {
        super(continuation);
        this.this$0 = p28f1bfa1Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getDefaultMeasure(this);
    }
}

