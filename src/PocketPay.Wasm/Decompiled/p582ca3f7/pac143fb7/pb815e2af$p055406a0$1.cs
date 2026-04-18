namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p582ca3f7.pac143fb7.pb815e2af", m533f = "EmployeesUseCaseImpl.kt", m534i = {0, 0, 1}, m535l = {33, 34, 35}, m536m = "applyEmployee", m537n = {"this", "employee", "this"}, m538s = {"L$0", "L$1", "L$0"})
readonly class pb815e2af$p055406a0$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f0fd4be9f;
    int f166443f4;
    java.lang.object f36da4704;
    java.lang.object f3bb2bf3b;
    java.lang.object f50fb0ddb;
    java.lang.object fb4a88417;
    java.lang.object fb61a9bf7;
    int fb959acd1;
    int fd304ba20;
    readonly p582ca3f7.pac143fb7.pb815e2af this$0;

    pb815e2af$p055406a0$1(p582ca3f7.pac143fb7.pb815e2af pb815e2afVar, kotlin.coroutines.Continuation<? super p582ca3f7.pac143fb7.pb815e2af$p055406a0$1> continuation) {
        super(continuation);
        this.this$0 = pb815e2afVar;
    }

    public static java.lang.object IPcfwiAKAfuvvUKB(p582ca3f7.pac143fb7.pb815e2af pb815e2afVar, pad5f82e8.p07214c67.pfa547353.pf8c8b903 pf8c8b903Var, kotlin.coroutines.Continuation continuation) {
        return pb815e2afVar.applyEmployee(pf8c8b903Var, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return IPcfwiAKAfuvvUKB(this.this$0, null, this);
    }
}

