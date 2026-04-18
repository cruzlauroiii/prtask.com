namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.p1e11b989.pc2e6b85a", m533f = "ReceiptDbRepositoryImpl.kt", m534i = {0}, m535l = {112}, m536m = "getSellReceiptsBetweenDateTimeTimes", m537n = {"this"}, m538s = {"L$0"})
readonly class pc2e6b85a$pca2e00c5$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f2a55c501;
    java.lang.object f9859cef7;
    java.lang.object fa23a6836;
    java.lang.object fb4a88417;
    java.lang.object fbfdd0d47;
    java.lang.object fc2397486;
    int fd304ba20;
    readonly p8d777f38.pb3f20355.p1e11b989.pc2e6b85a this$0;

    pc2e6b85a$pca2e00c5$1(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.p1e11b989.pc2e6b85a$pca2e00c5$1> continuation) {
        super(continuation);
        this.this$0 = pc2e6b85aVar;
    }

    public static java.lang.object JldKWRzLYceZMTHI(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, long j, long j2, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pc2e6b85aVar.getSellReceiptsBetweenDateTimeTimes(j, j2, str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((27 + 15) % 15 > 0) {
        }
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return jldKWRzLYceZMTHI(this.this$0, 0L, 0L, null, this);
    }
}

