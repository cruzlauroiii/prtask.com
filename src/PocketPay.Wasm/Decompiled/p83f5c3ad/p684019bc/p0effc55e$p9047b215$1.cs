namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p0effc55e", m533f = "ActivationTapOnPhoneUseCaseImpl.kt", m534i = {0, 0, 1}, m535l = {30, 33, 35}, m536m = "initActivationWithToken", m537n = {"this", "token", "this"}, m538s = {"L$0", "L$1", "L$0"})
readonly class p0effc55e$p9047b215$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f039d009a;
    java.lang.object f097846f5;
    java.lang.object f248ff7dd;
    int f3dc62f0f;
    java.lang.object f624dc8e6;
    int f68eac790;
    int f900fb944;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object ff7618dde;
    readonly p83f5c3ad.p684019bc.p0effc55e this$0;

    p0effc55e$p9047b215$1(p83f5c3ad.p684019bc.p0effc55e p0effc55eVar, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p0effc55e$p9047b215$1> continuation) {
        super(continuation);
        this.this$0 = p0effc55eVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.initActivationWithToken(null, this);
    }
}

