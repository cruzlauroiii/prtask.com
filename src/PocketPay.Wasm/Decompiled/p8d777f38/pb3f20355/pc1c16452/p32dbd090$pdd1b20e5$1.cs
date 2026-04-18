namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.pc1c16452.p32dbd090", m533f = "MarketDataRepositoryImpl.kt", m534i = {}, m535l = {29}, m536m = "getShopUUid", m537n = {}, m538s = {})
readonly class p32dbd090$pdd1b20e5$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f047020df;
    java.lang.object f1d4f9a60;
    java.lang.object f504e7ff8;
    java.lang.object f54bff59d;
    int f7dde8e28;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p8d777f38.pb3f20355.pc1c16452.p32dbd090 this$0;

    p32dbd090$pdd1b20e5$1(p8d777f38.pb3f20355.pc1c16452.p32dbd090 p32dbd090Var, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.pc1c16452.p32dbd090$pdd1b20e5$1> continuation) {
        super(continuation);
        this.this$0 = p32dbd090Var;
    }

    public static java.lang.object YvgQSSyLqtKQhefe(p8d777f38.pb3f20355.pc1c16452.p32dbd090 p32dbd090Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return p32dbd090Var.getShopUUid(str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return yvgQSSyLqtKQhefe(this.this$0, null, this);
    }
}

