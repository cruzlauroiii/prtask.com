namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.p1e11b989.pc2e6b85a", m533f = "ReceiptDbRepositoryImpl.kt", m534i = {0}, m535l = {44, 49}, m536m = "savePaybackReceipt", m537n = {"this"}, m538s = {"L$0"})
readonly class pc2e6b85a$p159ed487$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f09af7cf7;
    java.lang.object f1de6d13d;
    java.lang.object f335c9a6c;
    java.lang.object f7614b80e;
    int fb277e619;
    int fb29a6167;
    java.lang.object fb4a88417;
    java.lang.object fd18ed217;
    int fd304ba20;
    int fe39fe785;
    readonly p8d777f38.pb3f20355.p1e11b989.pc2e6b85a this$0;

    pc2e6b85a$p159ed487$1(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.p1e11b989.pc2e6b85a$p159ed487$1> continuation) {
        super(continuation);
        this.this$0 = pc2e6b85aVar;
    }

    public static java.lang.object RYFvSCxYxgKMtiTI(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return pc2e6b85aVar.savePaybackReceipt(p18cf5223Var, str, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return rYFvSCxYxgKMtiTI(this.this$0, null, null, this);
    }
}

