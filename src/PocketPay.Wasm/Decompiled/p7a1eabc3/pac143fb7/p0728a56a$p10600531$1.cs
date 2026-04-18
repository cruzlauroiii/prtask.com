namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pac143fb7.p0728a56a", m533f = "InventoryUseCaseImpl.kt", m534i = {0, 0, 0, 1, 1, 1, 2, 2, 2, 3}, m535l = {28, 33, 36, 40}, m536m = "getInventories", m537n = {"this", "parentId", "startInventoryRoute", "this", "startInventoryRoute", "commodityGroups", "this", "startInventoryRoute", "commodityGroups", "commodityGroups"}, m538s = {"L$0", "L$1", "L$2", "L$0", "L$1", "L$2", "L$0", "L$1", "L$2", "L$0"})
readonly class p0728a56a$p10600531$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object f2ed846bd;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fd84a51eb;
    java.lang.object ff58f2a4e;
    readonly p7a1eabc3.pac143fb7.p0728a56a this$0;

    p0728a56a$p10600531$1(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, kotlin.coroutines.Continuation<? super p7a1eabc3.pac143fb7.p0728a56a$p10600531$1> continuation) {
        super(continuation);
        this.this$0 = p0728a56aVar;
    }

    public static java.lang.object WqkCRJFtbmOWritq(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, java.lang.string str, pad5f82e8.p07214c67.pfd9160bb.p17096304 p17096304Var, kotlin.coroutines.Continuation continuation) {
        return p0728a56aVar.getInventories(str, p17096304Var, continuation);
    }

    public static void WqkCRJFtbmOWritq(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, java.lang.string str, pad5f82e8.p07214c67.pfd9160bb.p17096304 p17096304Var, kotlin.coroutines.Continuation continuation, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WqkCRJFtbmOWritq(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, java.lang.string str, pad5f82e8.p07214c67.pfd9160bb.p17096304 p17096304Var, kotlin.coroutines.Continuation continuation, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WqkCRJFtbmOWritq(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, java.lang.string str, pad5f82e8.p07214c67.pfd9160bb.p17096304 p17096304Var, kotlin.coroutines.Continuation continuation, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return wqkCRJFtbmOWritq(this.this$0, null, null, this);
    }
}

