namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p582ca3f7.pb3f20355.pf7a08972", m533f = "EmployeesRepositoryImpl.kt", m534i = {}, m535l = {34}, m536m = "getSelectedEmployee", m537n = {}, m538s = {})
readonly class pf7a08972$p2cb29fd5$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f6a3b1f62;
    int f9551de2e;
    java.lang.object fb4a88417;
    int fb962da4d;
    int fd304ba20;
    java.lang.object fdf004b3a;
    java.lang.object fdf6fea76;
    int ff3c17b0e;
    readonly p582ca3f7.pb3f20355.pf7a08972 this$0;

    pf7a08972$p2cb29fd5$1(p582ca3f7.pb3f20355.pf7a08972 pf7a08972Var, kotlin.coroutines.Continuation<? super p582ca3f7.pb3f20355.pf7a08972$p2cb29fd5$1> continuation) {
        super(continuation);
        this.this$0 = pf7a08972Var;
    }

    public static java.lang.object WifHdRjTxgMVHpHm(p582ca3f7.pb3f20355.pf7a08972 pf7a08972Var, kotlin.coroutines.Continuation continuation) {
        return pf7a08972Var.getSelectedEmployee(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return WifHdRjTxgMVHpHm(this.this$0, this);
    }
}

