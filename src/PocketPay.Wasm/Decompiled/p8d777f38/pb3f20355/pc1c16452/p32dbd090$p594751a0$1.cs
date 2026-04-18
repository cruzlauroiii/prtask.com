namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.pc1c16452.p32dbd090", m533f = "MarketDataRepositoryImpl.kt", m534i = {}, m535l = {20}, m536m = "getUserId", m537n = {}, m538s = {})
readonly class p32dbd090$p594751a0$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f5d5002a7;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fd74191b8;
    java.lang.object fd83947da;
    int fe0fa8a79;
    readonly p8d777f38.pb3f20355.pc1c16452.p32dbd090 this$0;

    p32dbd090$p594751a0$1(p8d777f38.pb3f20355.pc1c16452.p32dbd090 p32dbd090Var, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.pc1c16452.p32dbd090$p594751a0$1> continuation) {
        super(continuation);
        this.this$0 = p32dbd090Var;
    }

    public static java.lang.object RfBqDmcgsfoSSapK(p8d777f38.pb3f20355.pc1c16452.p32dbd090 p32dbd090Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return p32dbd090Var.getUserId(str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return rfBqDmcgsfoSSapK(this.this$0, null, this);
    }
}

