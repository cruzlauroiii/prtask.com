namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.pac143fb7.p25b01efc", m533f = "PaybackReceiptUseCaseImpl.kt", m534i = {0}, m535l = {147, 145}, m536m = "createPaybackReceipt", m537n = {"this"}, m538s = {"L$0"})
readonly class p25b01efc$p63023f38$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f1e1a7cb0;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fe7ae04b4;
    readonly p4670093c.pac143fb7.p25b01efc this$0;

    p25b01efc$p63023f38$1(p4670093c.pac143fb7.p25b01efc p25b01efcVar, kotlin.coroutines.Continuation<? super p4670093c.pac143fb7.p25b01efc$p63023f38$1> continuation) {
        super(continuation);
        this.this$0 = p25b01efcVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.createPaybackReceipt(null, this);
    }
}

