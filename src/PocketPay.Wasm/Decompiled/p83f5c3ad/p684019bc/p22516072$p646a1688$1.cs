namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p22516072", m533f = "TophReceiptUseCaseImpl.kt", m534i = {0, 0, 0}, m535l = {35, 36}, m536m = "getPaymentTransaction", m537n = {"this", "receipt", "rrn"}, m538s = {"L$0", "L$1", "L$2"})
readonly class p22516072$p646a1688$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object f544d4753;
    int fadb7a309;
    java.lang.object faecd73f9;
    java.lang.object fb4a88417;
    java.lang.object fbb4537e8;
    int fd304ba20;
    int ffb518749;
    readonly p83f5c3ad.p684019bc.p22516072 this$0;

    p22516072$p646a1688$1(p83f5c3ad.p684019bc.p22516072 p22516072Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p22516072$p646a1688$1> continuation) {
        super(continuation);
        this.this$0 = p22516072Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getPaymentTransaction(null, null, this);
    }
}

