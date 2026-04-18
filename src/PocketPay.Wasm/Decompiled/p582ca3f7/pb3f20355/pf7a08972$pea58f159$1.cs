namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p582ca3f7.pb3f20355.pf7a08972", m533f = "EmployeesRepositoryImpl.kt", m534i = {}, m535l = {28, 26}, m536m = "getSelectedEmployeeGrant", m537n = {}, m538s = {})
readonly class pf7a08972$pea58f159$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object f305abe8a;
    java.lang.object f352ca7f9;
    java.lang.object f639a6495;
    int f8478166a;
    int f9bfebc5f;
    java.lang.object fb4a88417;
    java.lang.object fbc6bf775;
    int fd304ba20;
    readonly p582ca3f7.pb3f20355.pf7a08972 this$0;

    pf7a08972$pea58f159$1(p582ca3f7.pb3f20355.pf7a08972 pf7a08972Var, kotlin.coroutines.Continuation<? super p582ca3f7.pb3f20355.pf7a08972$pea58f159$1> continuation) {
        super(continuation);
        this.this$0 = pf7a08972Var;
    }

    public static java.lang.object LPqYBdzpDDxPFtWL(p582ca3f7.pb3f20355.pf7a08972 pf7a08972Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pf7a08972Var.getSelectedEmployeeGrant(str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return LPqYBdzpDDxPFtWL(this.this$0, null, this);
    }
}

