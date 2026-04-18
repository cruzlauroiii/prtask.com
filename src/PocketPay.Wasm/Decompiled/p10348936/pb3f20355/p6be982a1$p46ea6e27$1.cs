namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p10348936.pb3f20355.p6be982a1", m533f = "InventorizationConsoleDbRepositoryImpl.kt", m534i = {}, m535l = {23}, m536m = "getLastInventorizationNumber", m537n = {}, m538s = {})
readonly class p6be982a1$p46ea6e27$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f25dba01b;
    int f502d5d15;
    java.lang.object f89a917aa;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p10348936.pb3f20355.p6be982a1 this$0;

    p6be982a1$p46ea6e27$1(p10348936.pb3f20355.p6be982a1 p6be982a1Var, kotlin.coroutines.Continuation<? super p10348936.pb3f20355.p6be982a1$p46ea6e27$1> continuation) {
        super(continuation);
        this.this$0 = p6be982a1Var;
    }

    public static java.lang.object WJTQocWBRiwNJhwn(p10348936.pb3f20355.p6be982a1 p6be982a1Var, kotlin.coroutines.Continuation continuation) {
        return p6be982a1Var.getLastInventorizationNumber(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return wJTQocWBRiwNJhwn(this.this$0, this);
    }
}

