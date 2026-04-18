namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.p1e11b989.pc2e6b85a", m533f = "ReceiptDbRepositoryImpl.kt", m534i = {0}, m535l = {193}, m536m = "getQueueReceipts", m537n = {"this"}, m538s = {"L$0"})
readonly class pc2e6b85a$pec1e6910$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f3bd4c101;
    int f531881b4;
    int f6fadb437;
    java.lang.object f80b65b17;
    java.lang.object f9d5414b1;
    int fb30a8c5c;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object ff35a5923;
    readonly p8d777f38.pb3f20355.p1e11b989.pc2e6b85a this$0;

    pc2e6b85a$pec1e6910$1(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.p1e11b989.pc2e6b85a$pec1e6910$1> continuation) {
        super(continuation);
        this.this$0 = pc2e6b85aVar;
    }

    public static java.lang.object KQFdMfUWZiFZqhon(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation continuation) {
        return pc2e6b85aVar.getQueueReceipts(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return kQFdMfUWZiFZqhon(this.this$0, this);
    }
}

