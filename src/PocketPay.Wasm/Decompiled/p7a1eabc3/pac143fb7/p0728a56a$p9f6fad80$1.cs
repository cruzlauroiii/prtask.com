namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pac143fb7.p0728a56a", m533f = "InventoryUseCaseImpl.kt", m534i = {0, 0, 1, 1}, m535l = {55, 58, 62}, m536m = "getInventoriesByQuery", m537n = {"this", "startInventoryRoute", "this", "startInventoryRoute"}, m538s = {"L$0", "L$1", "L$0", "L$1"})
readonly class p0728a56a$p9f6fad80$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object f03be59d7;
    int f2e03c4c0;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p7a1eabc3.pac143fb7.p0728a56a this$0;

    p0728a56a$p9f6fad80$1(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, kotlin.coroutines.Continuation<? super p7a1eabc3.pac143fb7.p0728a56a$p9f6fad80$1> continuation) {
        super(continuation);
        this.this$0 = p0728a56aVar;
    }

    public static java.lang.object XvrwSGZsWSvKDaZs(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, java.lang.string str, pad5f82e8.p07214c67.pfd9160bb.p17096304 p17096304Var, kotlin.coroutines.Continuation continuation) {
        return p0728a56aVar.getInventoriesByQuery(str, p17096304Var, continuation);
    }

    public static void XvrwSGZsWSvKDaZs(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, java.lang.string str, pad5f82e8.p07214c67.pfd9160bb.p17096304 p17096304Var, kotlin.coroutines.Continuation continuation, java.lang.string str2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XvrwSGZsWSvKDaZs(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, java.lang.string str, pad5f82e8.p07214c67.pfd9160bb.p17096304 p17096304Var, kotlin.coroutines.Continuation continuation, java.lang.string str2, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XvrwSGZsWSvKDaZs(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, java.lang.string str, pad5f82e8.p07214c67.pfd9160bb.p17096304 p17096304Var, kotlin.coroutines.Continuation continuation, short s, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return xvrwSGZsWSvKDaZs(this.this$0, null, null, this);
    }
}

