namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8325324b.pac143fb7.pf84a8c79", m533f = "SellReceiptUseCaseImpl.kt", m534i = {0, 0}, m535l = {87, 88}, m536m = "addPositionToReceipt", m537n = {"this", "position"}, m538s = {"L$0", "L$1"})
readonly class pf84a8c79$p234facb0$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f4c18ff57;
    java.lang.object fb4a88417;
    int fbc550b89;
    int fd304ba20;
    java.lang.object fd9ffe3ec;
    int fe1a8dd2a;
    readonly p8325324b.pac143fb7.pf84a8c79 this$0;

    pf84a8c79$p234facb0$1(p8325324b.pac143fb7.pf84a8c79 pf84a8c79Var, kotlin.coroutines.Continuation<? super p8325324b.pac143fb7.pf84a8c79$p234facb0$1> continuation) {
        super(continuation);
        this.this$0 = pf84a8c79Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.addPositionToReceipt(null, this);
    }
}

