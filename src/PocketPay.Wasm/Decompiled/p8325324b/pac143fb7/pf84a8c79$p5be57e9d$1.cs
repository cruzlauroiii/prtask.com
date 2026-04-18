namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8325324b.pac143fb7.pf84a8c79", m533f = "SellReceiptUseCaseImpl.kt", m534i = {0}, m535l = {112, 113}, m536m = "removeAllPositionsFromReceipt", m537n = {"this"}, m538s = {"L$0"})
readonly class pf84a8c79$p5be57e9d$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f40fe2fd0;
    int f42c69bb4;
    java.lang.object f532b5cd3;
    java.lang.object f91a1c96c;
    int faa98a9db;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fe99f9269;
    readonly p8325324b.pac143fb7.pf84a8c79 this$0;

    pf84a8c79$p5be57e9d$1(p8325324b.pac143fb7.pf84a8c79 pf84a8c79Var, kotlin.coroutines.Continuation<? super p8325324b.pac143fb7.pf84a8c79$p5be57e9d$1> continuation) {
        super(continuation);
        this.this$0 = pf84a8c79Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.removeAllPositionsFromReceipt(this);
    }
}

