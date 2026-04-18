namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.p1e11b989.pc2e6b85a", m533f = "ReceiptDbRepositoryImpl.kt", m534i = {0}, m535l = {77}, m536m = "getPaybackReceiptsBySellReceiptUuid", m537n = {"this"}, m538s = {"L$0"})
readonly class pc2e6b85a$p79269a24$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f00c7a112;
    java.lang.object f518f1b2d;
    java.lang.object f8782d0f8;
    int fb10b0952;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fd31ffa05;
    readonly p8d777f38.pb3f20355.p1e11b989.pc2e6b85a this$0;

    pc2e6b85a$p79269a24$1(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.p1e11b989.pc2e6b85a$p79269a24$1> continuation) {
        super(continuation);
        this.this$0 = pc2e6b85aVar;
    }

    public static java.lang.object XUKGxkJQITSuGoGz(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pc2e6b85aVar.getPaybackReceiptsBySellReceiptUuid(str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return XUKGxkJQITSuGoGz(this.this$0, null, this);
    }
}

