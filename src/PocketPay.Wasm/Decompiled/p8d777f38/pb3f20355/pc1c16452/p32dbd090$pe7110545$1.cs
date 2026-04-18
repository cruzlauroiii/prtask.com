namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.pc1c16452.p32dbd090", m533f = "MarketDataRepositoryImpl.kt", m534i = {}, m535l = {47}, m536m = "getToken", m537n = {}, m538s = {})
readonly class p32dbd090$pe7110545$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f03ec282e;
    int f26a20ba7;
    int f6e3600f7;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fd7e433c0;
    int fe37fdff5;
    readonly p8d777f38.pb3f20355.pc1c16452.p32dbd090 this$0;

    p32dbd090$pe7110545$1(p8d777f38.pb3f20355.pc1c16452.p32dbd090 p32dbd090Var, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.pc1c16452.p32dbd090$pe7110545$1> continuation) {
        super(continuation);
        this.this$0 = p32dbd090Var;
    }

    public static java.lang.object PfASRiEqvEzAFlNM(p8d777f38.pb3f20355.pc1c16452.p32dbd090 p32dbd090Var, kotlin.coroutines.Continuation continuation) {
        return p32dbd090Var.getToken(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return PfASRiEqvEzAFlNM(this.this$0, this);
    }
}

