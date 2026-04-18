namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.p5105272e", m533f = "AttestationTapOnPhoneRepositoryImpl.kt", m534i = {}, m535l = {22}, m536m = "initAttestation", m537n = {}, m538s = {})
readonly class p5105272e$p4434d349$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object f8b7f03e3;
    int fafe70777;
    java.lang.object fb4a88417;
    java.lang.object fc637682f;
    int fd304ba20;
    readonly p83f5c3ad.pb3f20355.p5105272e this$0;

    p5105272e$p4434d349$1(p83f5c3ad.pb3f20355.p5105272e p5105272eVar, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.p5105272e$p4434d349$1> continuation) {
        super(continuation);
        this.this$0 = p5105272eVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.initAttestation(this);
    }
}

