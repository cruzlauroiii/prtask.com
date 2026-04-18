namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.p1e11b989.pc2e6b85a", m533f = "ReceiptDbRepositoryImpl.kt", m534i = {0, 1}, m535l = {320, 321, 322}, m536m = "clearSellReceipts", m537n = {"this", "this"}, m538s = {"L$0", "L$0"})
readonly class pc2e6b85a$pe7b38761$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f51d204e9;
    int f68625182;
    int f84353a64;
    java.lang.object fb4a88417;
    java.lang.object fbeb609c8;
    int fd304ba20;
    int ffdc994e1;
    readonly p8d777f38.pb3f20355.p1e11b989.pc2e6b85a this$0;

    pc2e6b85a$pe7b38761$1(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.p1e11b989.pc2e6b85a$pe7b38761$1> continuation) {
        super(continuation);
        this.this$0 = pc2e6b85aVar;
    }

    public static java.lang.object LQPKEMJlmhFVyYkW(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation continuation) {
        return pc2e6b85aVar.clearSellReceipts(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return LQPKEMJlmhFVyYkW(this.this$0, this);
    }
}

