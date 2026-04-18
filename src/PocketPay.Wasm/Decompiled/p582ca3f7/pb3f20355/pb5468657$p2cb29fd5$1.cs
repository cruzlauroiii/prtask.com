namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p582ca3f7.pb3f20355.pb5468657", m533f = "EmployeesDbRepositoryImpl.kt", m534i = {}, m535l = {12}, m536m = "getSelectedEmployee", m537n = {}, m538s = {})
readonly class pb5468657$p2cb29fd5$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f5f0ee378;
    java.lang.object f703eb5c4;
    java.lang.object f72fe2b37;
    java.lang.object fb4a88417;
    int fc72935ca;
    int fd304ba20;
    java.lang.object fdc600f32;
    readonly p582ca3f7.pb3f20355.pb5468657 this$0;

    pb5468657$p2cb29fd5$1(p582ca3f7.pb3f20355.pb5468657 pb5468657Var, kotlin.coroutines.Continuation<? super p582ca3f7.pb3f20355.pb5468657$p2cb29fd5$1> continuation) {
        super(continuation);
        this.this$0 = pb5468657Var;
    }

    public static java.lang.object DzmWSlRdFVxbuXJW(p582ca3f7.pb3f20355.pb5468657 pb5468657Var, kotlin.coroutines.Continuation continuation) {
        return pb5468657Var.getSelectedEmployee(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return DzmWSlRdFVxbuXJW(this.this$0, this);
    }
}

