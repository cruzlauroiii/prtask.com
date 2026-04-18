namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pe0bd4e89.pdd56421b.pac143fb7.p8ef3302e", m533f = "AdvanceReceiptUseCaseImpl.kt", m534i = {0}, m535l = {35, 37}, m536m = "getAdvanceReceiptsByQuery", m537n = {"query"}, m538s = {"L$0"})
readonly class p8ef3302e$pd4f1088a$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f27b2790b;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object ffd05ec32;
    readonly pe0bd4e89.pdd56421b.pac143fb7.p8ef3302e this$0;

    p8ef3302e$pd4f1088a$1(pe0bd4e89.pdd56421b.pac143fb7.p8ef3302e p8ef3302eVar, kotlin.coroutines.Continuation<? super pe0bd4e89.pdd56421b.pac143fb7.p8ef3302e$pd4f1088a$1> continuation) {
        super(continuation);
        this.this$0 = p8ef3302eVar;
    }

    public static java.lang.object SIGntaGESrTAWLnv(pe0bd4e89.pdd56421b.pac143fb7.p8ef3302e p8ef3302eVar, java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation continuation) {
        return p8ef3302eVar.getAdvanceReceiptsByQuery(str, str2, continuation);
    }

    public static void SIGntaGESrTAWLnv(pe0bd4e89.pdd56421b.pac143fb7.p8ef3302e p8ef3302eVar, java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation continuation, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SIGntaGESrTAWLnv(pe0bd4e89.pdd56421b.pac143fb7.p8ef3302e p8ef3302eVar, java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation continuation, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SIGntaGESrTAWLnv(pe0bd4e89.pdd56421b.pac143fb7.p8ef3302e p8ef3302eVar, java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation continuation, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return sIGntaGESrTAWLnv(this.this$0, null, null, this);
    }
}

