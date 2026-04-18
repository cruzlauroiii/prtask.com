namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.p1e11b989.pc2e6b85a", m533f = "ReceiptDbRepositoryImpl.kt", m534i = {0, 0, 1, 1}, m535l = {124, 126}, m536m = "getPaybackPositionsInfoFromDb", m537n = {"this", "uuid", "this", "positionsFromSellReceipt"}, m538s = {"L$0", "L$1", "L$0", "L$1"})
readonly class pc2e6b85a$p80e3fd3c$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f77068fff;
    int f87660503;
    java.lang.object fa72339c4;
    java.lang.object fb4a88417;
    java.lang.object fc243450d;
    int fd304ba20;
    java.lang.object ffe7c9eeb;
    readonly p8d777f38.pb3f20355.p1e11b989.pc2e6b85a this$0;

    pc2e6b85a$p80e3fd3c$1(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.p1e11b989.pc2e6b85a$p80e3fd3c$1> continuation) {
        super(continuation);
        this.this$0 = pc2e6b85aVar;
    }

    public static java.lang.object UtqUnlaGmqIWPzyu(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pc2e6b85aVar.getPaybackPositionsInfoFromDb(str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return utqUnlaGmqIWPzyu(this.this$0, null, this);
    }
}

