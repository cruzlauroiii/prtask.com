namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.p1e11b989.pc2e6b85a", m533f = "ReceiptDbRepositoryImpl.kt", m534i = {0}, m535l = {97}, m536m = "getSellReceipts", m537n = {"this"}, m538s = {"L$0"})
readonly class pc2e6b85a$pe1497a56$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f10f26b45;
    int f27957321;
    int f5160fe91;
    java.lang.object f64c27a64;
    int faff135c1;
    int fb43c1054;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fedb9c406;
    readonly p8d777f38.pb3f20355.p1e11b989.pc2e6b85a this$0;

    pc2e6b85a$pe1497a56$1(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.p1e11b989.pc2e6b85a$pe1497a56$1> continuation) {
        super(continuation);
        this.this$0 = pc2e6b85aVar;
    }

    public static java.lang.object YYRWqnjCBrBXRVwW(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, int i, int i2, kotlin.coroutines.Continuation continuation) {
        return pc2e6b85aVar.getSellReceipts(i, i2, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return YYRWqnjCBrBXRVwW(this.this$0, 0, 0, this);
    }
}

