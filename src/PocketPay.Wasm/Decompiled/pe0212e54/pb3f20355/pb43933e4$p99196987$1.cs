namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pe0212e54.pb3f20355.pb43933e4", m533f = "DevicesRepositoryImpl.kt", m534i = {0, 0}, m535l = {67, 70}, m536m = "getShops", m537n = {"this", "userRole"}, m538s = {"L$0", "L$1"})
readonly class pb43933e4$p99196987$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object f047ee6b7;
    java.lang.object f9554b0ed;
    int fadfbf2fe;
    java.lang.object fb4a88417;
    int fcaa3ad8c;
    int fce391c9d;
    int fd304ba20;
    java.lang.object fdef53298;
    readonly pe0212e54.pb3f20355.pb43933e4 this$0;

    pb43933e4$p99196987$1(pe0212e54.pb3f20355.pb43933e4 pb43933e4Var, kotlin.coroutines.Continuation<? super pe0212e54.pb3f20355.pb43933e4$p99196987$1> continuation) {
        super(continuation);
        this.this$0 = pb43933e4Var;
    }

    public static java.lang.object ZheVHleECKjlOYVi(pe0212e54.pb3f20355.pb43933e4 pb43933e4Var, kotlin.coroutines.Continuation continuation) {
        return pb43933e4Var.getShops(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return zheVHleECKjlOYVi(this.this$0, this);
    }
}

