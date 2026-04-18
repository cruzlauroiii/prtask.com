namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p10348936.pac143fb7.p64fa2b57", m533f = "CurrentInventorizationUseCaseImpl.kt", m534i = {0}, m535l = {27, 28}, m536m = "saveCurrentInventorization", m537n = {"this"}, m538s = {"L$0"})
readonly class p64fa2b57$p9a25d975$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f6b6ebfd7;
    int f806c52da;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p10348936.pac143fb7.p64fa2b57 this$0;

    p64fa2b57$p9a25d975$1(p10348936.pac143fb7.p64fa2b57 p64fa2b57Var, kotlin.coroutines.Continuation<? super p10348936.pac143fb7.p64fa2b57$p9a25d975$1> continuation) {
        super(continuation);
        this.this$0 = p64fa2b57Var;
    }

    public static java.lang.object UmcRbcqxojpdbqZS(p10348936.pac143fb7.p64fa2b57 p64fa2b57Var, p10348936.pf5e638cc.p0690dac5 p0690dac5Var, kotlin.coroutines.Continuation continuation) {
        return p64fa2b57Var.saveCurrentInventorization(p0690dac5Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return umcRbcqxojpdbqZS(this.this$0, null, this);
    }
}

