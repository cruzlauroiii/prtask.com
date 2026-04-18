namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pb3f20355.p6810d8b2", m533f = "InventoryRepositoryImpl.kt", m534i = {0, 0, 1, 1, 2}, m535l = {57, 60, 59}, m536m = "getAllCommoditiesByQuery", m537n = {"this", "query", "this", "query", "this"}, m538s = {"L$0", "L$1", "L$0", "L$1", "L$0"})
readonly class p6810d8b2$pcb122795$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object f56eb5d87;
    int f9ad9aadf;
    java.lang.object fb4a88417;
    int fca9cc5fa;
    int fd304ba20;
    readonly p7a1eabc3.pb3f20355.p6810d8b2 this$0;

    p6810d8b2$pcb122795$1(p7a1eabc3.pb3f20355.p6810d8b2 p6810d8b2Var, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p6810d8b2$pcb122795$1> continuation) {
        super(continuation);
        this.this$0 = p6810d8b2Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getAllCommoditiesByQuery(null, this);
    }
}

