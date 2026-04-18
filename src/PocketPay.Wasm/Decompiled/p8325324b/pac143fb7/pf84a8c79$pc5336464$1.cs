namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8325324b.pac143fb7.pf84a8c79", m533f = "SellReceiptUseCaseImpl.kt", m534i = {0, 0}, m535l = {107, 108}, m536m = "removePositionFromReceipt", m537n = {"this", "position"}, m538s = {"L$0", "L$1"})
readonly class pf84a8c79$pc5336464$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f252ca3b8;
    java.lang.object fb4a88417;
    java.lang.object fb8425f32;
    int fd304ba20;
    readonly p8325324b.pac143fb7.pf84a8c79 this$0;

    pf84a8c79$pc5336464$1(p8325324b.pac143fb7.pf84a8c79 pf84a8c79Var, kotlin.coroutines.Continuation<? super p8325324b.pac143fb7.pf84a8c79$pc5336464$1> continuation) {
        super(continuation);
        this.this$0 = pf84a8c79Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.removePositionFromReceipt(null, this);
    }
}

