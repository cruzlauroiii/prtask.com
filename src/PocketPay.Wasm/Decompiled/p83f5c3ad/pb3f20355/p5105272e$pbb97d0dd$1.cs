namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.p5105272e", m533f = "AttestationTapOnPhoneRepositoryImpl.kt", m534i = {0, 1}, m535l = {27, 27}, m536m = "confirmAttestation", m537n = {"this", "this"}, m538s = {"L$0", "L$0"})
readonly class p5105272e$pbb97d0dd$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f667b149f;
    int fa5287b5b;
    java.lang.object fb4a88417;
    java.lang.object fb6f8bc54;
    int fc131137b;
    int fd304ba20;
    java.lang.object fdbbb4b32;
    java.lang.object fe1768182;
    java.lang.object ffa7347f6;
    readonly p83f5c3ad.pb3f20355.p5105272e this$0;

    p5105272e$pbb97d0dd$1(p83f5c3ad.pb3f20355.p5105272e p5105272eVar, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.p5105272e$pbb97d0dd$1> continuation) {
        super(continuation);
        this.this$0 = p5105272eVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.confirmAttestation(null, this);
    }
}

