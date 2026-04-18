namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pb3f20355.p6810d8b2", m533f = "InventoryRepositoryImpl.kt", m534i = {0}, m535l = {174, 175}, m536m = "clearInventories", m537n = {"this"}, m538s = {"L$0"})
readonly class p6810d8b2$p536798aa$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f2c6bf935;
    java.lang.object f421160ed;
    int f748004b2;
    java.lang.object f8827047f;
    java.lang.object faa23c258;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fd41e5c2b;
    int fd5290acc;
    int fe22822f3;
    readonly p7a1eabc3.pb3f20355.p6810d8b2 this$0;

    p6810d8b2$p536798aa$1(p7a1eabc3.pb3f20355.p6810d8b2 p6810d8b2Var, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p6810d8b2$p536798aa$1> continuation) {
        super(continuation);
        this.this$0 = p6810d8b2Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.clearInventories(this);
    }
}

