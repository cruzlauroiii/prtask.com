namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pb3f20355.p6810d8b2", m533f = "InventoryRepositoryImpl.kt", m534i = {0}, m535l = {110, 115}, m536m = "editCommodity", m537n = {"this"}, m538s = {"L$0"})
readonly class p6810d8b2$p240f065d$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f1fdcef73;
    java.lang.object f326e7935;
    java.lang.object f437351e7;
    java.lang.object f49a52547;
    int fb20b3c0d;
    int fb2a9d2c7;
    java.lang.object fb4a88417;
    int fc34362a2;
    int fd304ba20;
    readonly p7a1eabc3.pb3f20355.p6810d8b2 this$0;

    p6810d8b2$p240f065d$1(p7a1eabc3.pb3f20355.p6810d8b2 p6810d8b2Var, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p6810d8b2$p240f065d$1> continuation) {
        super(continuation);
        this.this$0 = p6810d8b2Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.editCommodity(null, this);
    }
}

