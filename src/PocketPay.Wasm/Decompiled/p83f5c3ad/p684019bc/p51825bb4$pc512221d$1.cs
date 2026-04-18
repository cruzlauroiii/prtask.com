namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p51825bb4", m533f = "TophAuthUseCaseImpl.kt", m534i = {0}, m535l = {38, 39}, m536m = "logoutIfNeeded", m537n = {"this"}, m538s = {"L$0"})
readonly class p51825bb4$pc512221d$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f496c9743;
    int f9190dbe8;
    java.lang.object fb4a88417;
    java.lang.object fb9ee389d;
    int fd304ba20;
    int fec390965;
    readonly p83f5c3ad.p684019bc.p51825bb4 this$0;

    p51825bb4$pc512221d$1(p83f5c3ad.p684019bc.p51825bb4 p51825bb4Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p51825bb4$pc512221d$1> continuation) {
        super(continuation);
        this.this$0 = p51825bb4Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.logoutIfNeeded(this);
    }
}

