namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p776ea3bf.pac143fb7.pa99796e8", m533f = "IntegrationTophAuthUseCaseImpl.kt", m534i = {0, 1}, m535l = {24, 26, 30}, m536m = "getStartScreen", m537n = {"this", "this"}, m538s = {"L$0", "L$0"})
readonly class pa99796e8$pe872ce79$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f019f77d3;
    int f06284e97;
    int f30df2091;
    java.lang.object f889af089;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fd515c081;
    java.lang.object fd924ce2e;
    readonly p776ea3bf.pac143fb7.pa99796e8 this$0;

    pa99796e8$pe872ce79$1(p776ea3bf.pac143fb7.pa99796e8 pa99796e8Var, kotlin.coroutines.Continuation<? super p776ea3bf.pac143fb7.pa99796e8$pe872ce79$1> continuation) {
        super(continuation);
        this.this$0 = pa99796e8Var;
    }

    public static java.lang.object VHfBNjzXekxjGLiM(p776ea3bf.pac143fb7.pa99796e8 pa99796e8Var, kotlin.coroutines.Continuation continuation) {
        return pa99796e8Var.getStartScreen(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return VHfBNjzXekxjGLiM(this.this$0, this);
    }
}

