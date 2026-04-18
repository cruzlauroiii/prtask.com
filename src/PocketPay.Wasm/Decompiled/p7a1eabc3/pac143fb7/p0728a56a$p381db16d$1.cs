namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pac143fb7.p0728a56a", m533f = "InventoryUseCaseImpl.kt", m534i = {0}, m535l = {83}, m536m = "getRemainingInventories", m537n = {"addedPositions"}, m538s = {"L$0"})
readonly class p0728a56a$p381db16d$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object f3d588dde;
    java.lang.object f4794f4a3;
    int f5673f0f5;
    java.lang.object fb2f52e02;
    java.lang.object fb4a88417;
    int fc818adb3;
    int fcc7ee22e;
    int fd304ba20;
    readonly p7a1eabc3.pac143fb7.p0728a56a this$0;

    p0728a56a$p381db16d$1(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, kotlin.coroutines.Continuation<? super p7a1eabc3.pac143fb7.p0728a56a$p381db16d$1> continuation) {
        super(continuation);
        this.this$0 = p0728a56aVar;
    }

    public static java.lang.object YNsQCZxlEvYNXPLG(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, java.util.List list, kotlin.coroutines.Continuation continuation) {
        return p0728a56aVar.getRemainingInventories(list, continuation);
    }

    public static void YNsQCZxlEvYNXPLG(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, java.util.List list, kotlin.coroutines.Continuation continuation, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YNsQCZxlEvYNXPLG(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, java.util.List list, kotlin.coroutines.Continuation continuation, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YNsQCZxlEvYNXPLG(p7a1eabc3.pac143fb7.p0728a56a p0728a56aVar, java.util.List list, kotlin.coroutines.Continuation continuation, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return YNsQCZxlEvYNXPLG(this.this$0, null, this);
    }
}

