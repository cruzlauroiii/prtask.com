namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pb3f20355.p28f1bfa1", m533f = "MeasureRepositoryImpl.kt", m534i = {}, m535l = {24}, m536m = "getMeasuresFromServer", m537n = {}, m538s = {})
readonly class p28f1bfa1$p95db2393$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f28b78438;
    java.lang.object f4bfebfef;
    int f65f7951b;
    java.lang.object f78c71e00;
    java.lang.object fb4a88417;
    int fb8edef65;
    int fcfb4a45c;
    int fd304ba20;
    readonly p7a1eabc3.pb3f20355.p28f1bfa1 this$0;

    p28f1bfa1$p95db2393$1(p7a1eabc3.pb3f20355.p28f1bfa1 p28f1bfa1Var, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p28f1bfa1$p95db2393$1> continuation) {
        super(continuation);
        this.this$0 = p28f1bfa1Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return p7a1eabc3.pb3f20355.p28f1bfa1.m5c801a53(this.this$0, this);
    }
}

