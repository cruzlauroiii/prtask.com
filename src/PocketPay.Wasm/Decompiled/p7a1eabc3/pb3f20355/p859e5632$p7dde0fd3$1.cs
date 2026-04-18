namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pb3f20355.p859e5632", m533f = "TaxRepositoryImpl.kt", m534i = {0}, m535l = {18, 20}, m536m = "replaceTaxes", m537n = {"this"}, m538s = {"L$0"})
readonly class p859e5632$p7dde0fd3$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f17695a23;
    int f29772d29;
    java.lang.object f37c47a92;
    int f484b7a29;
    int f5423fa35;
    java.lang.object f5a6e74bc;
    java.lang.object f6bd4f07b;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p7a1eabc3.pb3f20355.p859e5632 this$0;

    p859e5632$p7dde0fd3$1(p7a1eabc3.pb3f20355.p859e5632 p859e5632Var, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p859e5632$p7dde0fd3$1> continuation) {
        super(continuation);
        this.this$0 = p859e5632Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.replaceTaxes(this);
    }
}

