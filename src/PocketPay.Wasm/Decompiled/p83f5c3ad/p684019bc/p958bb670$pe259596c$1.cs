namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p958bb670", m533f = "ConsoleoutTapOnPhoneUseCaseImpl.kt", m534i = {0}, m535l = {21}, m536m = "resetActivation", m537n = {"this"}, m538s = {"L$0"})
readonly class p958bb670$pe259596c$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f05e0857f;
    int f431e995d;
    java.lang.object f4f769fac;
    int faadf3966;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p83f5c3ad.p684019bc.p958bb670 this$0;

    p958bb670$pe259596c$1(p83f5c3ad.p684019bc.p958bb670 p958bb670Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p958bb670$pe259596c$1> continuation) {
        super(continuation);
        this.this$0 = p958bb670Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return p83f5c3ad.p684019bc.p958bb670.mcfad4dbf(this.this$0, this);
    }
}

