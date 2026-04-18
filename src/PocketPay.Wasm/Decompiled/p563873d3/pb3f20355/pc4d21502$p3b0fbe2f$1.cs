namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p563873d3.pb3f20355.pc4d21502", m533f = "RegistrationRepositoryImpl.kt", m534i = {}, m535l = {23}, m536m = "getRegisteredUser", m537n = {}, m538s = {})
readonly class pc4d21502$p3b0fbe2f$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f2cf208f1;
    java.lang.object f7c8ec6ad;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p563873d3.pb3f20355.pc4d21502 this$0;

    pc4d21502$p3b0fbe2f$1(p563873d3.pb3f20355.pc4d21502 pc4d21502Var, kotlin.coroutines.Continuation<? super p563873d3.pb3f20355.pc4d21502$p3b0fbe2f$1> continuation) {
        super(continuation);
        this.this$0 = pc4d21502Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getRegisteredUser(null, null, null, this);
    }
}

