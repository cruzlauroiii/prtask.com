namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p582ca3f7.pb3f20355.pf205d848", m533f = "EmployeesRemoteRepositoryImpl.kt", m534i = {}, m535l = {16}, m536m = "getEmployeeGrant", m537n = {}, m538s = {})
readonly class pf205d848$p7fcf6e7f$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f0c80a696;
    int f2b2dd092;
    java.lang.object f54581985;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p582ca3f7.pb3f20355.pf205d848 this$0;

    pf205d848$p7fcf6e7f$1(p582ca3f7.pb3f20355.pf205d848 pf205d848Var, kotlin.coroutines.Continuation<? super p582ca3f7.pb3f20355.pf205d848$p7fcf6e7f$1> continuation) {
        super(continuation);
        this.this$0 = pf205d848Var;
    }

    public static java.lang.object LfjDiRRTflJakkKc(p582ca3f7.pb3f20355.pf205d848 pf205d848Var, java.lang.string str, pad5f82e8.p07214c67.pfa547353.pf8c8b903 pf8c8b903Var, kotlin.coroutines.Continuation continuation) {
        return pf205d848Var.getEmployeeGrant(str, pf8c8b903Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return lfjDiRRTflJakkKc(this.this$0, null, null, this);
    }
}

