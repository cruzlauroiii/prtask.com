namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.p445dc046", m533f = "TophBatchRepositoryImpl.kt", m534i = {0, 1}, m535l = {19, 20}, m536m = "getCurrentBatchInfo", m537n = {"this", "this"}, m538s = {"L$0", "L$0"})
readonly class p445dc046$pad31ed54$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f1be5b1c9;
    java.lang.object f369a1a9c;
    java.lang.object f48cb1277;
    int f771b8447;
    int f9c377758;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fe74b7323;
    readonly p83f5c3ad.pb3f20355.p445dc046 this$0;

    p445dc046$pad31ed54$1(p83f5c3ad.pb3f20355.p445dc046 p445dc046Var, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.p445dc046$pad31ed54$1> continuation) {
        super(continuation);
        this.this$0 = p445dc046Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getCurrentBatchInfo(this);
    }
}

