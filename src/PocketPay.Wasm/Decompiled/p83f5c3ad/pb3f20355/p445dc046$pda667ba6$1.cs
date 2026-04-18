namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.p445dc046", m533f = "TophBatchRepositoryImpl.kt", m534i = {}, m535l = {32, 33, 35}, m536m = "closeBatch", m537n = {}, m538s = {})
readonly class p445dc046$pda667ba6$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f4e063917;
    java.lang.object fb4a88417;
    java.lang.object fb8a0d09d;
    java.lang.object fba6f5f23;
    int fbc250fd5;
    java.lang.object fccb27fcf;
    int fd304ba20;
    java.lang.object ff2ca2bd5;
    readonly p83f5c3ad.pb3f20355.p445dc046 this$0;

    p445dc046$pda667ba6$1(p83f5c3ad.pb3f20355.p445dc046 p445dc046Var, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.p445dc046$pda667ba6$1> continuation) {
        super(continuation);
        this.this$0 = p445dc046Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.closeBatch(this);
    }
}

