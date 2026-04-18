namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.p06ad009f", m533f = "ActivationTapOnPhoneRepositoryImpl.kt", m534i = {}, m535l = {61, 63}, m536m = "initActivation", m537n = {}, m538s = {})
readonly class p06ad009f$p27a1f813$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object f017c7d1d;
    java.lang.object f399ab37e;
    java.lang.object f88c50d00;
    int f8f1945da;
    int fa1c8e854;
    java.lang.object fb4a88417;
    int fd304ba20;
    java.lang.object fe391d043;
    int ffc126ac9;
    readonly p83f5c3ad.pb3f20355.p06ad009f this$0;

    p06ad009f$p27a1f813$1(p83f5c3ad.pb3f20355.p06ad009f p06ad009fVar, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.p06ad009f$p27a1f813$1> continuation) {
        super(continuation);
        this.this$0 = p06ad009fVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.initActivation(null, this);
    }
}

