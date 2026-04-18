namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p563873d3.pac143fb7.p0d905613", m533f = "RegistrationUseCaseImpl.kt", m534i = {0, 1, 1, 1}, m535l = {27, 45}, m536m = "updateRegistrationUserData", m537n = {"this", "this", "user", "$this$updateRegistrationUserData_u24lambda_u243"}, m538s = {"L$0", "L$0", "L$1", "L$2"})
readonly class p0d905613$p9701991b$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f37f49f1a;
    int f7dd5b224;
    int f7e1e6375;
    java.lang.object f860aa54e;
    java.lang.object f8c43b914;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fdabb425f;
    java.lang.object fe1d534bc;
    readonly p563873d3.pac143fb7.p0d905613 this$0;

    p0d905613$p9701991b$1(p563873d3.pac143fb7.p0d905613 p0d905613Var, kotlin.coroutines.Continuation<? super p563873d3.pac143fb7.p0d905613$p9701991b$1> continuation) {
        super(continuation);
        this.this$0 = p0d905613Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.updateRegistrationUserData(this);
    }
}

