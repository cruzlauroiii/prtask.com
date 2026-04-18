namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pac143fb7.pf9731f05", m533f = "InventoryGroupUseCaseImpl.kt", m534i = {}, m535l = {13}, m536m = "getNextInventoryGroups", m537n = {}, m538s = {})
readonly class pf9731f05$p42332568$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f0f5f1825;
    java.lang.object f17e5e213;
    int f37a97830;
    int f9cc36fa0;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fdc8c0d05;
    readonly p7a1eabc3.pac143fb7.pf9731f05 this$0;

    pf9731f05$p42332568$1(p7a1eabc3.pac143fb7.pf9731f05 pf9731f05Var, kotlin.coroutines.Continuation<? super p7a1eabc3.pac143fb7.pf9731f05$p42332568$1> continuation) {
        super(continuation);
        this.this$0 = pf9731f05Var;
    }

    public static java.lang.object SkVjzUlBnzdXQDRx(p7a1eabc3.pac143fb7.pf9731f05 pf9731f05Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pf9731f05Var.getNextInventoryGroups(str, continuation);
    }

    public static void SkVjzUlBnzdXQDRx(p7a1eabc3.pac143fb7.pf9731f05 pf9731f05Var, java.lang.string str, kotlin.coroutines.Continuation continuation, byte b, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SkVjzUlBnzdXQDRx(p7a1eabc3.pac143fb7.pf9731f05 pf9731f05Var, java.lang.string str, kotlin.coroutines.Continuation continuation, java.lang.string str2, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SkVjzUlBnzdXQDRx(p7a1eabc3.pac143fb7.pf9731f05 pf9731f05Var, java.lang.string str, kotlin.coroutines.Continuation continuation, bool z, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return skVjzUlBnzdXQDRx(this.this$0, null, this);
    }
}

