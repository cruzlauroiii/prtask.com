namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p0effc55e", m533f = "ActivationTapOnPhoneUseCaseImpl.kt", m534i = {0, 0, 1}, m535l = {57, 58}, m536m = "confirmRegWithOtp", m537n = {"this", "otp", "this"}, m538s = {"L$0", "L$1", "L$0"})
readonly class p0effc55e$pbb5eb0ce$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object f1707dba2;
    java.lang.object f36e1fa31;
    java.lang.object fb4a88417;
    int fc694f147;
    int fd304ba20;
    java.lang.object ff191f62d;
    readonly p83f5c3ad.p684019bc.p0effc55e this$0;

    p0effc55e$pbb5eb0ce$1(p83f5c3ad.p684019bc.p0effc55e p0effc55eVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p0effc55e$pbb5eb0ce$1> continuation) {
        super(continuation);
        this.this$0 = p0effc55eVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.confirmRegWithOtp(null, this);
    }
}

