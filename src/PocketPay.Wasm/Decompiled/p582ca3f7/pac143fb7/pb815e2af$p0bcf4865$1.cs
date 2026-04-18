namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p582ca3f7.pac143fb7.pb815e2af", m533f = "EmployeesUseCaseImpl.kt", m534i = {}, m535l = {38}, m536m = "isSelectedEmployeeWithPin", m537n = {}, m538s = {})
readonly class pb815e2af$p0bcf4865$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f0acca69a;
    int f60bd04eb;
    java.lang.object fb4a88417;
    int fd2d45311;
    int fd304ba20;
    java.lang.object fdfae5752;
    readonly p582ca3f7.pac143fb7.pb815e2af this$0;

    pb815e2af$p0bcf4865$1(p582ca3f7.pac143fb7.pb815e2af pb815e2afVar, kotlin.coroutines.Continuation<? super p582ca3f7.pac143fb7.pb815e2af$p0bcf4865$1> continuation) {
        super(continuation);
        this.this$0 = pb815e2afVar;
    }

    public static java.lang.object NMiJvUFtYmDrIXSF(p582ca3f7.pac143fb7.pb815e2af pb815e2afVar, kotlin.coroutines.Continuation continuation) {
        return pb815e2afVar.isSelectedEmployeeWithPin(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return NMiJvUFtYmDrIXSF(this.this$0, this);
    }
}

