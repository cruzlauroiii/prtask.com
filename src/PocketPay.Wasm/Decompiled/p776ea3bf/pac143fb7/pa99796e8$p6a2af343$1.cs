namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p776ea3bf.pac143fb7.pa99796e8", m533f = "IntegrationTophAuthUseCaseImpl.kt", m534i = {0, 1}, m535l = {48, 49}, m536m = "loginWithToken", m537n = {"this", "this"}, m538s = {"L$0", "L$0"})
readonly class pa99796e8$p6a2af343$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f2458f749;
    java.lang.object f2637a283;
    java.lang.object f31f98731;
    java.lang.object f42b87a8a;
    int faf56e6e9;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p776ea3bf.pac143fb7.pa99796e8 this$0;

    pa99796e8$p6a2af343$1(p776ea3bf.pac143fb7.pa99796e8 pa99796e8Var, kotlin.coroutines.Continuation<? super p776ea3bf.pac143fb7.pa99796e8$p6a2af343$1> continuation) {
        super(continuation);
        this.this$0 = pa99796e8Var;
    }

    public static java.lang.object CuFcjHJjJTyYuJLv(p776ea3bf.pac143fb7.pa99796e8 pa99796e8Var, kotlin.coroutines.Continuation continuation) {
        return p776ea3bf.pac143fb7.pa99796e8.m5718a856(pa99796e8Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return CuFcjHJjJTyYuJLv(this.this$0, this);
    }
}

