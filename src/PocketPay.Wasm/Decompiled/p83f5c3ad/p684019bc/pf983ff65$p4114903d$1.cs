namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.pf983ff65", m533f = "InitTapOnPhoneUseCaseImpl.kt", m534i = {0}, m535l = {27, 29}, m536m = "launchTapOnPhone", m537n = {"this"}, m538s = {"L$0"})
readonly class pf983ff65$p4114903d$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f2e9ba5bd;
    java.lang.object fa4f576ff;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p83f5c3ad.p684019bc.pf983ff65 this$0;

    pf983ff65$p4114903d$1(p83f5c3ad.p684019bc.pf983ff65 pf983ff65Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.pf983ff65$p4114903d$1> continuation) {
        super(continuation);
        this.this$0 = pf983ff65Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return p83f5c3ad.p684019bc.pf983ff65.m07c3cae2(this.this$0, this);
    }
}

