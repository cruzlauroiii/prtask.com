namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.p1e11b989.pc2e6b85a", m533f = "ReceiptDbRepositoryImpl.kt", m534i = {0}, m535l = {71}, m536m = "getPaybackReceipt", m537n = {"this"}, m538s = {"L$0"})
readonly class pc2e6b85a$p9b63e6e8$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f2d24bee2;
    int f2f62904c;
    int f69551c12;
    java.lang.object f94259b6b;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fe02b4185;
    readonly p8d777f38.pb3f20355.p1e11b989.pc2e6b85a this$0;

    pc2e6b85a$p9b63e6e8$1(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.p1e11b989.pc2e6b85a$p9b63e6e8$1> continuation) {
        super(continuation);
        this.this$0 = pc2e6b85aVar;
    }

    public static java.lang.object RDJjuWvgLhJpfGYx(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pc2e6b85aVar.getPaybackReceipt(str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return RDJjuWvgLhJpfGYx(this.this$0, null, this);
    }
}

