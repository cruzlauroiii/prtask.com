namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.p881039ed", m533f = "BalanceTapOnPhoneRepositoryImpl.kt", m534i = {}, m535l = {27}, m536m = "getBalance", m537n = {}, m538s = {})
readonly class p881039ed$p3bbf95c6$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f0d2eded5;
    int f1f33db67;
    int f2c322447;
    java.lang.object f2f8aaa9e;
    int f5529c111;
    java.lang.object f8f8f96bc;
    int fa2db55be;
    java.lang.object fb4a88417;
    java.lang.object fc508c637;
    int fd304ba20;
    readonly p83f5c3ad.pb3f20355.p881039ed this$0;

    p881039ed$p3bbf95c6$1(p83f5c3ad.pb3f20355.p881039ed p881039edVar, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.p881039ed$p3bbf95c6$1> continuation) {
        super(continuation);
        this.this$0 = p881039edVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.getBalance(null, this);
    }
}

