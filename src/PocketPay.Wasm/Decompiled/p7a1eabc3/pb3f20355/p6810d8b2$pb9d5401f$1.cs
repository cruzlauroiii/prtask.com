namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pb3f20355.p6810d8b2", m533f = "InventoryRepositoryImpl.kt", m534i = {0, 1, 2}, m535l = {47, 50, 49}, m536m = "getAllCommodities", m537n = {"this", "this", "this"}, m538s = {"L$0", "L$0", "L$0"})
readonly class p6810d8b2$pb9d5401f$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object f1fe447d4;
    int f8df791d3;
    int f91307afb;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p7a1eabc3.pb3f20355.p6810d8b2 this$0;

    p6810d8b2$pb9d5401f$1(p7a1eabc3.pb3f20355.p6810d8b2 p6810d8b2Var, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p6810d8b2$pb9d5401f$1> continuation) {
        super(continuation);
        this.this$0 = p6810d8b2Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getAllCommodities(this);
    }
}

