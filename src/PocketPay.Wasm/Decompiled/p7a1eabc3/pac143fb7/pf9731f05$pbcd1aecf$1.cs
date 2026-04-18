namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pac143fb7.pf9731f05", m533f = "InventoryGroupUseCaseImpl.kt", m534i = {}, m535l = {46}, m536m = "getGroupParentName", m537n = {}, m538s = {})
readonly class pf9731f05$pbcd1aecf$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f0787cff6;
    int f2af58fc4;
    java.lang.object f6cf062aa;
    int faea0485b;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p7a1eabc3.pac143fb7.pf9731f05 this$0;

    pf9731f05$pbcd1aecf$1(p7a1eabc3.pac143fb7.pf9731f05 pf9731f05Var, kotlin.coroutines.Continuation<? super p7a1eabc3.pac143fb7.pf9731f05$pbcd1aecf$1> continuation) {
        super(continuation);
        this.this$0 = pf9731f05Var;
    }

    public static java.lang.object KjOAAawULwiFzqhV(p7a1eabc3.pac143fb7.pf9731f05 pf9731f05Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pf9731f05Var.getGroupParentName(str, continuation);
    }

    public static void KjOAAawULwiFzqhV(p7a1eabc3.pac143fb7.pf9731f05 pf9731f05Var, java.lang.string str, kotlin.coroutines.Continuation continuation, byte b, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KjOAAawULwiFzqhV(p7a1eabc3.pac143fb7.pf9731f05 pf9731f05Var, java.lang.string str, kotlin.coroutines.Continuation continuation, char c, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KjOAAawULwiFzqhV(p7a1eabc3.pac143fb7.pf9731f05 pf9731f05Var, java.lang.string str, kotlin.coroutines.Continuation continuation, java.lang.string str2, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return KjOAAawULwiFzqhV(this.this$0, null, this);
    }
}

