namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pac143fb7.p0728a56a", m533f = "InventoryUseCaseImpl.kt", m534i = {0, 1}, m535l = {73, 74}, m536m = "getAllInventories", m537n = {"this", "commodityGroups"}, m538s = {"L$0", "L$0"})
readonly class p0728a56a$p3d3a5dfa$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object f02165395;
    java.lang.object f0c26f720;
    java.lang.object f0f8fc1a2;
    java.lang.object f1c77c49c;
    int f38e60deb;
    int f9aa18fa3;
    int fabe427b5;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p7a1eabc3.pac143fb7.p0728a56a this$0;

    p0728a56a$p3d3a5dfa$1(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, kotlin.coroutines.Continuation<? super p7a1eabc3.pac143fb7.p0728a56a$p3d3a5dfa$1> continuation) {
        super(continuation);
        this.this$0 = p0728a56aVar;
    }

    public static java.lang.object PsONIBSzAJlDHmxk(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, kotlin.coroutines.Continuation continuation) {
        return p0728a56aVar.getAllInventories(continuation);
    }

    public static void PsONIBSzAJlDHmxk(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, kotlin.coroutines.Continuation continuation, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PsONIBSzAJlDHmxk(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, kotlin.coroutines.Continuation continuation, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PsONIBSzAJlDHmxk(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, kotlin.coroutines.Continuation continuation, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return psONIBSzAJlDHmxk(this.this$0, this);
    }
}

