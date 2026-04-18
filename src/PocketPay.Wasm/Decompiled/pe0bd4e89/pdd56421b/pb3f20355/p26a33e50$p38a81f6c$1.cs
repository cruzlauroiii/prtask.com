namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pe0bd4e89.pdd56421b.pb3f20355.p26a33e50", m533f = "AdvanceReceiptRepositoryImpl.kt", m534i = {}, m535l = {35}, m536m = "deleteAdvanceReceipt", m537n = {}, m538s = {})
readonly class p26a33e50$p38a81f6c$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f211b8de4;
    int f3be526fb;
    java.lang.object f4b07e14d;
    java.lang.object f5d7d69c3;
    java.lang.object f86538e39;
    int f993de8b0;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fe2478c29;
    readonly pe0bd4e89.pdd56421b.pb3f20355.p26a33e50 this$0;

    p26a33e50$p38a81f6c$1(pe0bd4e89.pdd56421b.pb3f20355.p26a33e50 p26a33e50Var, kotlin.coroutines.Continuation<? super pe0bd4e89.pdd56421b.pb3f20355.p26a33e50$p38a81f6c$1> continuation) {
        super(continuation);
        this.this$0 = p26a33e50Var;
    }

    public static java.lang.object PGotfxmdTpYeHlik(pe0bd4e89.pdd56421b.pb3f20355.p26a33e50 p26a33e50Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return p26a33e50Var.deleteAdvanceReceipt(str, continuation);
    }

    public static void PGotfxmdTpYeHlik(pe0bd4e89.pdd56421b.pb3f20355.p26a33e50 p26a33e50Var, java.lang.string str, kotlin.coroutines.Continuation continuation, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PGotfxmdTpYeHlik(pe0bd4e89.pdd56421b.pb3f20355.p26a33e50 p26a33e50Var, java.lang.string str, kotlin.coroutines.Continuation continuation, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PGotfxmdTpYeHlik(pe0bd4e89.pdd56421b.pb3f20355.p26a33e50 p26a33e50Var, java.lang.string str, kotlin.coroutines.Continuation continuation, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return pGotfxmdTpYeHlik(this.this$0, null, this);
    }
}

