namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p0effc55e", m533f = "ActivationTapOnPhoneUseCaseImpl.kt", m534i = {0, 0}, m535l = {25, 26}, m536m = "initActivation", m537n = {"this", "activationInfo"}, m538s = {"L$0", "L$1"})
readonly class p0effc55e$p27a1f813$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f7756c195;
    java.lang.object f80733d48;
    java.lang.object fb4a88417;
    int fb829a56f;
    int fd304ba20;
    java.lang.object fecf5b220;
    int ffc48e700;
    readonly p83f5c3ad.p684019bc.p0effc55e this$0;

    p0effc55e$p27a1f813$1(p83f5c3ad.p684019bc.p0effc55e p0effc55eVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p0effc55e$p27a1f813$1> continuation) {
        super(continuation);
        this.this$0 = p0effc55eVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.initActivation(null, this);
    }
}

