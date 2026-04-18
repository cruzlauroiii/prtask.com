namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p7a1eabc3.pb3f20355.p859e5632", m533f = "TaxRepositoryImpl.kt", m534i = {}, m535l = {24}, m536m = "getTaxesFromServer", m537n = {}, m538s = {})
readonly class p859e5632$p1c1e502d$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f13ef8f1a;
    java.lang.object f250ed0c1;
    int f2f5e312a;
    int f3873cf67;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p7a1eabc3.pb3f20355.p859e5632 this$0;

    p859e5632$p1c1e502d$1(p7a1eabc3.pb3f20355.p859e5632 p859e5632Var, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p859e5632$p1c1e502d$1> continuation) {
        super(continuation);
        this.this$0 = p859e5632Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return p7a1eabc3.pb3f20355.p859e5632.m64dfc900(this.this$0, this);
    }
}

