namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p563873d3.pb3f20355.pc4d21502", m533f = "RegistrationRepositoryImpl.kt", m534i = {}, m535l = {33}, m536m = "registerAccount", m537n = {}, m538s = {})
readonly class pc4d21502$pc12ca245$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f0983c93d;
    int f39430066;
    int f39972815;
    java.lang.object f3c0e2f5e;
    java.lang.object f8ee5e562;
    java.lang.object fa7575a16;
    java.lang.object fb4a88417;
    int fc775488a;
    int fd304ba20;
    java.lang.object ff91924a7;
    readonly p563873d3.pb3f20355.pc4d21502 this$0;

    pc4d21502$pc12ca245$1(p563873d3.pb3f20355.pc4d21502 pc4d21502Var, kotlin.coroutines.Continuation<? super p563873d3.pb3f20355.pc4d21502$pc12ca245$1> continuation) {
        super(continuation);
        this.this$0 = pc4d21502Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.registerAccount(null, this);
    }
}

