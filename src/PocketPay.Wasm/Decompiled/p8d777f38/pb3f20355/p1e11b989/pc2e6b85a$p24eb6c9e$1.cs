namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.p1e11b989.pc2e6b85a", m533f = "ReceiptDbRepositoryImpl.kt", m534i = {0, 1}, m535l = {81, 82}, m536m = "getNotSuccessReceiptsUuids", m537n = {"this", "notSuccessSellReceipts"}, m538s = {"L$0", "L$0"})
readonly class pc2e6b85a$p24eb6c9e$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f1ffbd7f4;
    int f33eb67fd;
    java.lang.object f4868b769;
    int f7e8cfe7f;
    int fa3b2842e;
    java.lang.object fb1ec5a27;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p8d777f38.pb3f20355.p1e11b989.pc2e6b85a this$0;

    pc2e6b85a$p24eb6c9e$1(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.p1e11b989.pc2e6b85a$p24eb6c9e$1> continuation) {
        super(continuation);
        this.this$0 = pc2e6b85aVar;
    }

    public static java.lang.object PFWtVZoCtjXwLeMp(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation continuation) {
        return pc2e6b85aVar.getNotSuccessReceiptsUuids(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return PFWtVZoCtjXwLeMp(this.this$0, this);
    }
}

