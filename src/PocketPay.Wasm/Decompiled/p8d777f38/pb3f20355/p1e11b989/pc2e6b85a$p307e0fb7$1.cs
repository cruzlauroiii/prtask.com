namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.p1e11b989.pc2e6b85a", m533f = "ReceiptDbRepositoryImpl.kt", m534i = {0}, m535l = {66}, m536m = "getSellReceipt", m537n = {"this"}, m538s = {"L$0"})
readonly class pc2e6b85a$p307e0fb7$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f0f8fa49d;
    int f5843ac7e;
    java.lang.object f58d45f75;
    java.lang.object f629a1c22;
    int fb0cbff8c;
    java.lang.object fb4a88417;
    int fc928f001;
    int fcff6e29c;
    int fd304ba20;
    readonly p8d777f38.pb3f20355.p1e11b989.pc2e6b85a this$0;

    pc2e6b85a$p307e0fb7$1(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.p1e11b989.pc2e6b85a$p307e0fb7$1> continuation) {
        super(continuation);
        this.this$0 = pc2e6b85aVar;
    }

    public static java.lang.object YoLbZZZVIrNCdHMo(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pc2e6b85aVar.getSellReceipt(str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return YoLbZZZVIrNCdHMo(this.this$0, null, this);
    }
}

