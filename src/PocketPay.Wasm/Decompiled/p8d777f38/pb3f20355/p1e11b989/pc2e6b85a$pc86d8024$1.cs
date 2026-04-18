namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.p1e11b989.pc2e6b85a", m533f = "ReceiptDbRepositoryImpl.kt", m534i = {0}, m535l = {169, 176}, m536m = "saveQueuePaybackReceipt", m537n = {"this"}, m538s = {"L$0"})
readonly class pc2e6b85a$pc86d8024$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f45b17109;
    java.lang.object f53792c43;
    int fa84dc419;
    java.lang.object fb424167a;
    java.lang.object fb4a88417;
    java.lang.object fbf8a68e6;
    int fce9efbe2;
    int fd304ba20;
    int ff4683f1d;
    readonly p8d777f38.pb3f20355.p1e11b989.pc2e6b85a this$0;

    pc2e6b85a$pc86d8024$1(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.p1e11b989.pc2e6b85a$pc86d8024$1> continuation) {
        super(continuation);
        this.this$0 = pc2e6b85aVar;
    }

    public static java.lang.object ABQEWdPRQWYRRtPR(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pc2e6b85aVar.saveQueuePaybackReceipt(p18cf5223Var, str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return aBQEWdPRQWYRRtPR(this.this$0, null, null, this);
    }
}

