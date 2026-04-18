namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pac143fb7.pf9731f05", m533f = "InventoryGroupUseCaseImpl.kt", m534i = {0}, m535l = {19, 20}, m536m = "getPrevInventoryGroups", m537n = {"this"}, m538s = {"L$0"})
readonly class pf9731f05$p8b00cf46$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f77c52e8e;
    java.lang.object f9e9ea23f;
    java.lang.object fb4a88417;
    int fba41f7dd;
    int fd304ba20;
    readonly p7a1eabc3.pac143fb7.pf9731f05 this$0;

    pf9731f05$p8b00cf46$1(p7a1eabc3.pac143fb7.pf9731f05 pf9731f05Var, kotlin.coroutines.Continuation<? super p7a1eabc3.pac143fb7.pf9731f05$p8b00cf46$1> continuation) {
        super(continuation);
        this.this$0 = pf9731f05Var;
    }

    public static java.lang.object TwCkFLOPLQyzxsVd(p7a1eabc3.pac143fb7.pf9731f05 pf9731f05Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pf9731f05Var.getPrevInventoryGroups(str, continuation);
    }

    public static void TwCkFLOPLQyzxsVd(p7a1eabc3.pac143fb7.pf9731f05 pf9731f05Var, java.lang.string str, kotlin.coroutines.Continuation continuation, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TwCkFLOPLQyzxsVd(p7a1eabc3.pac143fb7.pf9731f05 pf9731f05Var, java.lang.string str, kotlin.coroutines.Continuation continuation, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TwCkFLOPLQyzxsVd(p7a1eabc3.pac143fb7.pf9731f05 pf9731f05Var, java.lang.string str, kotlin.coroutines.Continuation continuation, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return TwCkFLOPLQyzxsVd(this.this$0, null, this);
    }
}

