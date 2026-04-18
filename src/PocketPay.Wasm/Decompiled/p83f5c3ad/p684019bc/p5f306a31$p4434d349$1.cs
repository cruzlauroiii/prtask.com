namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p5f306a31", m533f = "AttestationTapOnPhoneUseCaseImpl.kt", m534i = {0, 0, 1, 1, 2}, m535l = {19, 20, 23, 24}, m536m = "initAttestation", m537n = {"this", "onTophAction", "this", "onTophAction", "onTophAction"}, m538s = {"L$0", "L$1", "L$0", "L$1", "L$0"})
readonly class p5f306a31$p4434d349$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object f0ed7b4b5;
    int f1216ebcc;
    int f2ec9f684;
    java.lang.object f40b1b9a8;
    int face38cad;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fd4d4e874;
    java.lang.object ff93983f7;
    readonly p83f5c3ad.p684019bc.p5f306a31 this$0;

    p5f306a31$p4434d349$1(p83f5c3ad.p684019bc.p5f306a31 p5f306a31Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p5f306a31$p4434d349$1> continuation) {
        super(continuation);
        this.this$0 = p5f306a31Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.initAttestation(null, this);
    }
}

