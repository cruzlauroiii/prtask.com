namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p51825bb4", m533f = "TophAuthUseCaseImpl.kt", m534i = {0, 1}, m535l = {25, 27, 31}, m536m = "getStartScreen", m537n = {"this", "this"}, m538s = {"L$0", "L$0"})
readonly class p51825bb4$pe872ce79$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f77bc3167;
    int f8cbb634a;
    int f8df51947;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fe3e86c2b;
    java.lang.object fe6e4b2bf;
    readonly p83f5c3ad.p684019bc.p51825bb4 this$0;

    p51825bb4$pe872ce79$1(p83f5c3ad.p684019bc.p51825bb4 p51825bb4Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p51825bb4$pe872ce79$1> continuation) {
        super(continuation);
        this.this$0 = p51825bb4Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getStartScreen(this);
    }
}

