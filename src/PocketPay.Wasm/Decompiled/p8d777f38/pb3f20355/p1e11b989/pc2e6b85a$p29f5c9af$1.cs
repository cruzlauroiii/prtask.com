namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.p1e11b989.pc2e6b85a", m533f = "ReceiptDbRepositoryImpl.kt", m534i = {0, 0, 1, 1, 1}, m535l = {87, 88, 93}, m536m = "updateReceiptsStatus", m537n = {"this", "fiscalizationReceipts", "this", "fiscalizationReceipts", "notSuccessSellReceipts"}, m538s = {"L$0", "L$1", "L$0", "L$1", "L$2"})
readonly class pc2e6b85a$p29f5c9af$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f5ba10cf6;
    int f6e6a5ff7;
    java.lang.object f75ccb313;
    java.lang.object f9ce2ae77;
    int fa7a87cd5;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p8d777f38.pb3f20355.p1e11b989.pc2e6b85a this$0;

    pc2e6b85a$p29f5c9af$1(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.p1e11b989.pc2e6b85a$p29f5c9af$1> continuation) {
        super(continuation);
        this.this$0 = pc2e6b85aVar;
    }

    public static java.lang.object NXljYCEsVfUeDvwP(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, java.util.List list, kotlin.coroutines.Continuation continuation) {
        return pc2e6b85aVar.updateReceiptsStatus(list, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return nXljYCEsVfUeDvwP(this.this$0, null, this);
    }
}

