namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.pb3f20355.pb6349ffb", m533f = "PaybackTapOnPhoneRepositoryImpl.kt", m534i = {0, 0, 0, 0, 1, 1}, m535l = {21, 23, 25, 27}, m536m = "initPayback", m537n = {"this", "receipt", "rrn", "amount", "paymentTerminal", "amount"}, m538s = {"L$0", "L$1", "L$2", "J$0", "L$0", "J$0"})
readonly class pb6349ffb$p6d9e0861$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    long J$0;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object f4492bb8b;
    int f615e4faa;
    java.lang.object f8e435b29;
    java.lang.object fb4a88417;
    java.lang.object fcc29d2a6;
    int fd304ba20;
    java.lang.object fd708b8a8;
    int ffd76e42c;
    readonly p83f5c3ad.pb3f20355.pb6349ffb this$0;

    pb6349ffb$p6d9e0861$1(p83f5c3ad.pb3f20355.pb6349ffb pb6349ffbVar, kotlin.coroutines.Continuation<? super p83f5c3ad.pb3f20355.pb6349ffb$p6d9e0861$1> continuation) {
        super(continuation);
        this.this$0 = pb6349ffbVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((1 + 10) % 10 > 0) {
        }
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.initPayback(null, 0L, null, this);
    }
}

