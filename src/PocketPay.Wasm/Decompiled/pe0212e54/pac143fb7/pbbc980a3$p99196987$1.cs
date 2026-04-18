namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pe0212e54.pac143fb7.pbbc980a3", m533f = "DevicesUseCaseImpl.kt", m534i = {0}, m535l = {51}, m536m = "getShops", m537n = {"this"}, m538s = {"L$0"})
readonly class pbbc980a3$p99196987$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f154c731e;
    int f522457ae;
    java.lang.object f5306c6fd;
    java.lang.object fb4a88417;
    java.lang.object fb6754294;
    int fd304ba20;
    java.lang.object fea3d5e0d;
    int ff1610f2a;
    readonly pe0212e54.pac143fb7.pbbc980a3 this$0;

    pbbc980a3$p99196987$1(pe0212e54.pac143fb7.pbbc980a3 pbbc980a3Var, kotlin.coroutines.Continuation<? super pe0212e54.pac143fb7.pbbc980a3$p99196987$1> continuation) {
        super(continuation);
        this.this$0 = pbbc980a3Var;
    }

    public static java.lang.object ApRHyUYTYAiZjMAN(pe0212e54.pac143fb7.pbbc980a3 pbbc980a3Var, kotlin.coroutines.Continuation continuation) {
        return pbbc980a3Var.getShops(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return apRHyUYTYAiZjMAN(this.this$0, this);
    }
}

