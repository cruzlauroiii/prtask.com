namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pad5f82e8.pac143fb7.pc1c16452.p50c3d063", m533f = "MarketDataUseCaseImpl.kt", m534i = {0}, m535l = {38, 39}, m536m = "updateDeviceInfo", m537n = {"this"}, m538s = {"L$0"})
readonly class p50c3d063$p2ad2d5b1$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f2d17a645;
    java.lang.object f804da015;
    java.lang.object fa384d2b3;
    java.lang.object fb4a88417;
    java.lang.object fc929ab85;
    int fd304ba20;
    readonly pad5f82e8.pac143fb7.pc1c16452.p50c3d063 this$0;

    p50c3d063$p2ad2d5b1$1(pad5f82e8.pac143fb7.pc1c16452.p50c3d063 p50c3d063Var, kotlin.coroutines.Continuation<? super pad5f82e8.pac143fb7.pc1c16452.p50c3d063$p2ad2d5b1$1> continuation) {
        super(continuation);
        this.this$0 = p50c3d063Var;
    }

    public static java.lang.object PxRdhckEEPLbKKvQ(pad5f82e8.pac143fb7.pc1c16452.p50c3d063 p50c3d063Var, kotlin.coroutines.Continuation continuation) {
        return p50c3d063Var.updateDeviceInfo(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return pxRdhckEEPLbKKvQ(this.this$0, this);
    }
}

