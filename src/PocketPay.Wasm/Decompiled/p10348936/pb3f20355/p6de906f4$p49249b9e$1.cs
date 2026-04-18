namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p10348936.pb3f20355.p6de906f4", m533f = "InventorizationConsoleRepositoryImpl.kt", m534i = {}, m535l = {27}, m536m = "getInventorizations", m537n = {}, m538s = {})
readonly class p6de906f4$p49249b9e$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f70bfa94c;
    java.lang.object fb4a88417;
    java.lang.object fbe6f6115;
    int fd304ba20;
    java.lang.object fdb9ff9ef;
    readonly p10348936.pb3f20355.p6de906f4 this$0;

    p6de906f4$p49249b9e$1(p10348936.pb3f20355.p6de906f4 p6de906f4Var, kotlin.coroutines.Continuation<? super p10348936.pb3f20355.p6de906f4$p49249b9e$1> continuation) {
        super(continuation);
        this.this$0 = p6de906f4Var;
    }

    public static java.lang.object YNEMwEczxRROxpso(p10348936.pb3f20355.p6de906f4 p6de906f4Var, kotlin.coroutines.Continuation continuation) {
        return p6de906f4Var.getInventorizations(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return YNEMwEczxRROxpso(this.this$0, this);
    }
}

