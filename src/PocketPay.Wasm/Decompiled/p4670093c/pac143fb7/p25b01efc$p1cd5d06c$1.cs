namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.pac143fb7.p25b01efc", m533f = "PaybackReceiptUseCaseImpl.kt", m534i = {0}, m535l = {206}, m536m = "getQuantityPaybackPositionByUuid", m537n = {"uuid"}, m538s = {"L$0"})
readonly class p25b01efc$p1cd5d06c$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f3b4d2e55;
    java.lang.object f40327d0b;
    int f5fd83504;
    java.lang.object fa560fe84;
    java.lang.object fa75ffc1e;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p4670093c.pac143fb7.p25b01efc this$0;

    p25b01efc$p1cd5d06c$1(p4670093c.pac143fb7.p25b01efc p25b01efcVar, kotlin.coroutines.Continuation<? super p4670093c.pac143fb7.p25b01efc$p1cd5d06c$1> continuation) {
        super(continuation);
        this.this$0 = p25b01efcVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getQuantityPaybackPositionByUuid(null, this);
    }
}

