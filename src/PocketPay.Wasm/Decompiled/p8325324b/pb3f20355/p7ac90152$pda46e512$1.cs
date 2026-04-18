namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p8325324b.pb3f20355.p7ac90152", m533f = "SellReceiptDbRepositoryImpl.kt", m534i = {0, 0, 0}, m535l = {119, 121}, m536m = "setLastSellPosition", m537n = {"this", "name", "price"}, m538s = {"L$0", "L$1", "L$2"})
readonly class p7ac90152$pda46e512$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f04a24b4d;
    int f754bf3f8;
    java.lang.object f7917fd3a;
    java.lang.object f7a9ecd33;
    java.lang.object f9f285508;
    java.lang.object fa97aa6ed;
    java.lang.object fb4a88417;
    int fbfe3f7b5;
    int fd304ba20;
    int fee7056e2;
    readonly p8325324b.pb3f20355.p7ac90152 this$0;

    p7ac90152$pda46e512$1(p8325324b.pb3f20355.p7ac90152 p7ac90152Var, kotlin.coroutines.Continuation<? super p8325324b.pb3f20355.p7ac90152$pda46e512$1> continuation) {
        super(continuation);
        this.this$0 = p7ac90152Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.setLastSellPosition(null, null, null, this);
    }
}

