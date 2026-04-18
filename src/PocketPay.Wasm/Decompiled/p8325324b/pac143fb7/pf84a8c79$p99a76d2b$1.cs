namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8325324b.pac143fb7.pf84a8c79", m533f = "SellReceiptUseCaseImpl.kt", m534i = {}, m535l = {42, 42}, m536m = "getLastFastSellPosition", m537n = {}, m538s = {})
readonly class pf84a8c79$p99a76d2b$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f179cf239;
    java.lang.object f42bf3887;
    java.lang.object f8ed57dfa;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fd949eb81;
    readonly p8325324b.pac143fb7.pf84a8c79 this$0;

    pf84a8c79$p99a76d2b$1(p8325324b.pac143fb7.pf84a8c79 pf84a8c79Var, kotlin.coroutines.Continuation<? super p8325324b.pac143fb7.pf84a8c79$p99a76d2b$1> continuation) {
        super(continuation);
        this.this$0 = pf84a8c79Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getLastFastSellPosition(this);
    }
}

