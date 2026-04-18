namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p22516072", m533f = "TophReceiptUseCaseImpl.kt", m534i = {0, 0, 0}, m535l = {28, 29}, m536m = "getReceiptLink", m537n = {"this", "receipt", "rrn"}, m538s = {"L$0", "L$1", "L$2"})
readonly class p22516072$pca754add$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f0194027a;
    int f5135a315;
    java.lang.object f6fa2e695;
    java.lang.object f78539fa0;
    java.lang.object f9586c9f0;
    java.lang.object fb4a88417;
    int fd304ba20;
    readonly p83f5c3ad.p684019bc.p22516072 this$0;

    p22516072$pca754add$1(p83f5c3ad.p684019bc.p22516072 p22516072Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p22516072$pca754add$1> continuation) {
        super(continuation);
        this.this$0 = p22516072Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getReceiptLink(null, null, this);
    }
}

