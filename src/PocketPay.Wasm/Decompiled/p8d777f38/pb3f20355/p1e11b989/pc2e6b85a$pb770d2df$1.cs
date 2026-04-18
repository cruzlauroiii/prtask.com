namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8d777f38.pb3f20355.p1e11b989.pc2e6b85a", m533f = "ReceiptDbRepositoryImpl.kt", m534i = {0, 1}, m535l = {198, 199}, m536m = "hasErrorReceipts", m537n = {"this", "sellReceipts"}, m538s = {"L$0", "L$0"})
readonly class pc2e6b85a$pb770d2df$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f21e6711b;
    int f6a84dc89;
    int f85a5685e;
    java.lang.object f9dea048f;
    java.lang.object fb4a88417;
    java.lang.object fcb1b2d8e;
    int fd304ba20;
    readonly p8d777f38.pb3f20355.p1e11b989.pc2e6b85a this$0;

    pc2e6b85a$pb770d2df$1(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation<? super p8d777f38.pb3f20355.p1e11b989.pc2e6b85a$pb770d2df$1> continuation) {
        super(continuation);
        this.this$0 = pc2e6b85aVar;
    }

    public static java.lang.object NmMWEisOELFAIncY(p8d777f38.pb3f20355.p1e11b989.pc2e6b85a pc2e6b85aVar, kotlin.coroutines.Continuation continuation) {
        return pc2e6b85aVar.hasErrorReceipts(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return NmMWEisOELFAIncY(this.this$0, this);
    }
}

