namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p684019bc.p73759872", m533f = "TophQRPaymentUseCaseImpl.kt", m534i = {0, 0, 1, 1}, m535l = {15, 16, 17}, m536m = "createQR", m537n = {"this", "amount", "this", "amount"}, m538s = {"L$0", "J$0", "L$0", "J$0"})
readonly class p73759872$pde767b34$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    long J$0;
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly p83f5c3ad.p684019bc.p73759872 this$0;

    p73759872$pde767b34$1(p83f5c3ad.p684019bc.p73759872 p73759872Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p684019bc.p73759872$pde767b34$1> continuation) {
        super(continuation);
        this.this$0 = p73759872Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((22 + 15) % 15 > 0) {
        }
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.createQR(0L, this);
    }
}

