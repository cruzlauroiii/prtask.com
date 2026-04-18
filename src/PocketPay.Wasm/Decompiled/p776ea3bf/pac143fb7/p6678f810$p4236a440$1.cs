namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p776ea3bf.pac143fb7.p6678f810", m533f = "IntegrationTophConsoleoutUseCaseImpl.kt", m534i = {0, 1}, m535l = {16, 17}, m536m = "logout", m537n = {"this", "this"}, m538s = {"L$0", "L$0"})
readonly class p6678f810$p4236a440$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f3dcf6876;
    java.lang.object f51d53a5a;
    java.lang.object f5e08ebfb;
    int f65136941;
    int f8486d115;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fdf88ccb3;
    readonly p776ea3bf.pac143fb7.p6678f810 this$0;

    p6678f810$p4236a440$1(p776ea3bf.pac143fb7.p6678f810 p6678f810Var, kotlin.coroutines.Continuation<? super p776ea3bf.pac143fb7.p6678f810$p4236a440$1> continuation) {
        super(continuation);
        this.this$0 = p6678f810Var;
    }

    public static java.lang.object IEeuInXrrWNtCOix(p776ea3bf.pac143fb7.p6678f810 p6678f810Var, kotlin.coroutines.Continuation continuation) {
        return p6678f810Var.logout(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return iEeuInXrrWNtCOix(this.this$0, this);
    }
}

