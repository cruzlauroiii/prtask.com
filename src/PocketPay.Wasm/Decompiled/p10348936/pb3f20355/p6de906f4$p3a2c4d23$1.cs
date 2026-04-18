namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p10348936.pb3f20355.p6de906f4", m533f = "InventorizationConsoleRepositoryImpl.kt", m534i = {0, 0}, m535l = {21, 20}, m536m = "saveInventorization", m537n = {"this", "inventorization"}, m538s = {"L$0", "L$1"})
readonly class p6de906f4$p3a2c4d23$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f2e1b1eac;
    int f5b11dd57;
    java.lang.object f97ddb020;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fd79df9b0;
    java.lang.object fe584a52a;
    java.lang.object fec72e6fd;
    int ffd76bdcb;
    readonly p10348936.pb3f20355.p6de906f4 this$0;

    p6de906f4$p3a2c4d23$1(p10348936.pb3f20355.p6de906f4 p6de906f4Var, kotlin.coroutines.Continuation<? super p10348936.pb3f20355.p6de906f4$p3a2c4d23$1> continuation) {
        super(continuation);
        this.this$0 = p6de906f4Var;
    }

    public static java.lang.object CEGbkcLWpeHHEkno(p10348936.pb3f20355.p6de906f4 p6de906f4Var, p10348936.pf5e638cc.p0690dac5 p0690dac5Var, kotlin.coroutines.Continuation continuation) {
        return p6de906f4Var.saveInventorization(p0690dac5Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return CEGbkcLWpeHHEkno(this.this$0, null, this);
    }
}

