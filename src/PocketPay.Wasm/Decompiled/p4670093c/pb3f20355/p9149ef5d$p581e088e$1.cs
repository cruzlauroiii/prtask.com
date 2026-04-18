namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.pb3f20355.p9149ef5d", m533f = "PaybackReceiptRepositoryImpl.kt", m534i = {0}, m535l = {237, 236}, m536m = "setShouldPrintReceipt", m537n = {"shouldPrintReceipt"}, m538s = {"Z$0"})
readonly class p9149ef5d$p581e088e$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    bool Z$0;
    int f3b4e1ca3;
    java.lang.object fa344f00f;
    int fa44495d2;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p4670093c.pb3f20355.p9149ef5d this$0;

    p9149ef5d$p581e088e$1(p4670093c.pb3f20355.p9149ef5d p9149ef5dVar, kotlin.coroutines.Continuation<? super p4670093c.pb3f20355.p9149ef5d$p581e088e$1> continuation) {
        super(continuation);
        this.this$0 = p9149ef5dVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.setShouldPrintReceipt(false, this);
    }
}

