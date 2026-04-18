namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.pac143fb7.p25b01efc", m533f = "PaybackReceiptUseCaseImpl.kt", m534i = {0, 0, 1, 1, 1, 2, 2, 2}, m535l = {93, 94, 96, 101, 103}, m536m = "addPositionToReceipt", m537n = {"this", "position", "this", "position", "positionsForPayback", "this", "position", "paybackPositions"}, m538s = {"L$0", "L$1", "L$0", "L$1", "L$2", "L$0", "L$1", "L$2"})
readonly class p25b01efc$p234facb0$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object f093d74ac;
    java.lang.object f167f46e0;
    int f2bada3ec;
    int f36edc8be;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fd7636758;
    java.lang.object fe7b7b3b5;
    readonly p4670093c.pac143fb7.p25b01efc this$0;

    p25b01efc$p234facb0$1(p4670093c.pac143fb7.p25b01efc p25b01efcVar, kotlin.coroutines.Continuation<? super p4670093c.pac143fb7.p25b01efc$p234facb0$1> continuation) {
        super(continuation);
        this.this$0 = p25b01efcVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.addPositionToReceipt(null, this);
    }
}

