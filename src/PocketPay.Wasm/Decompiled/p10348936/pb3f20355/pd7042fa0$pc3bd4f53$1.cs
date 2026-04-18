namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p10348936.pb3f20355.pd7042fa0", m533f = "CurrentInventorizationDbRepositoryImpl.kt", m534i = {}, m535l = {19}, m536m = "getCurrentInventorization", m537n = {}, m538s = {})
readonly class pd7042fa0$pc3bd4f53$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f0fb4dafd;
    java.lang.object f33db9154;
    java.lang.object fa4136753;
    int fa5efa2b2;
    int fb0900537;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p10348936.pb3f20355.pd7042fa0 this$0;

    pd7042fa0$pc3bd4f53$1(p10348936.pb3f20355.pd7042fa0 pd7042fa0Var, kotlin.coroutines.Continuation<? super p10348936.pb3f20355.pd7042fa0$pc3bd4f53$1> continuation) {
        super(continuation);
        this.this$0 = pd7042fa0Var;
    }

    public static java.lang.object GJyoZHKuApqOdTLp(p10348936.pb3f20355.pd7042fa0 pd7042fa0Var, kotlin.coroutines.Continuation continuation) {
        return pd7042fa0Var.getCurrentInventorization(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return gJyoZHKuApqOdTLp(this.this$0, this);
    }
}

