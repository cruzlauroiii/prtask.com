namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p94a08da1.p1c8ed567", m533f = "TophTokenUseCaseImpl.kt", m534i = {0, 1}, m535l = {14, 16}, m536m = "getTopTokenByPhone", m537n = {"this", "tokenResult"}, m538s = {"L$0", "L$0"})
readonly class p1c8ed567$pc9971b9d$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f1f406e6e;
    java.lang.object f3228c3d5;
    int f3bb67c74;
    int f410c395e;
    int f63234530;
    java.lang.object f97b6c43c;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p83f5c3ad.p684019bc.p94a08da1.p1c8ed567 this$0;

    p1c8ed567$pc9971b9d$1(p83f5c3ad.p684019bc.p94a08da1.p1c8ed567 p1c8ed567Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p94a08da1.p1c8ed567$pc9971b9d$1> continuation) {
        super(continuation);
        this.this$0 = p1c8ed567Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getTopTokenByPhone(this);
    }
}

