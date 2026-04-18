namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p51825bb4", m533f = "TophAuthUseCaseImpl.kt", m534i = {0, 1}, m535l = {55, 56}, m536m = "loginWithToken", m537n = {"this", "this"}, m538s = {"L$0", "L$0"})
readonly class p51825bb4$p6a2af343$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f016483c6;
    java.lang.object f0b093cbd;
    java.lang.object fb4a88417;
    java.lang.object fc204accd;
    int fd304ba20;
    readonly p83f5c3ad.p684019bc.p51825bb4 this$0;

    p51825bb4$p6a2af343$1(p83f5c3ad.p684019bc.p51825bb4 p51825bb4Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p51825bb4$p6a2af343$1> continuation) {
        super(continuation);
        this.this$0 = p51825bb4Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return p83f5c3ad.p684019bc.p51825bb4.m5718a856(this.this$0, this);
    }
}

