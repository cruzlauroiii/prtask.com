namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p5f306a31", m533f = "AttestationTapOnPhoneUseCaseImpl.kt", m534i = {0, 1, 2}, m535l = {39, 40, 41, 43}, m536m = "runAttestation", m537n = {"this", "this", "this"}, m538s = {"L$0", "L$0", "L$0"})
readonly class p5f306a31$p1e284e26$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int f0070321a;
    int f09721a80;
    int f243093b7;
    java.lang.object f24d73f7a;
    java.lang.object fb4a88417;
    java.lang.object fbe08c946;
    int fd304ba20;
    int fdfbaa413;
    java.lang.object ff5bc60aa;
    readonly p83f5c3ad.p684019bc.p5f306a31 this$0;

    p5f306a31$p1e284e26$1(p83f5c3ad.p684019bc.p5f306a31 p5f306a31Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p5f306a31$p1e284e26$1> continuation) {
        super(continuation);
        this.this$0 = p5f306a31Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.runAttestation(this);
    }
}

