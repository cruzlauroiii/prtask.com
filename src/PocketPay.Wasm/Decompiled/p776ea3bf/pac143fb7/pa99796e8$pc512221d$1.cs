namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p776ea3bf.pac143fb7.pa99796e8", m533f = "IntegrationTophAuthUseCaseImpl.kt", m534i = {0}, m535l = {36, 37}, m536m = "logoutIfNeeded", m537n = {"$this$logoutIfNeeded_u24lambda_u240"}, m538s = {"L$0"})
readonly class pa99796e8$pc512221d$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f266c6c53;
    java.lang.object f2d0ca258;
    java.lang.object f3f2a9b2d;
    int f55113d80;
    int f7715c8a0;
    java.lang.object f78e838af;
    int f9652a56b;
    int fa8db7508;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p776ea3bf.pac143fb7.pa99796e8 this$0;

    pa99796e8$pc512221d$1(p776ea3bf.pac143fb7.pa99796e8 pa99796e8Var, kotlin.coroutines.Continuation<? super p776ea3bf.pac143fb7.pa99796e8$pc512221d$1> continuation) {
        super(continuation);
        this.this$0 = pa99796e8Var;
    }

    public static java.lang.object BEtcxYidqTytWWji(p776ea3bf.pac143fb7.pa99796e8 pa99796e8Var, kotlin.coroutines.Continuation continuation) {
        return p776ea3bf.pac143fb7.pa99796e8.m5a40e61c(pa99796e8Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return bEtcxYidqTytWWji(this.this$0, this);
    }
}

