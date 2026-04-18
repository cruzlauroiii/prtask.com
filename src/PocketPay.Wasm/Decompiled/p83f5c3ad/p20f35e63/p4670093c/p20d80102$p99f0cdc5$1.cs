namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p83f5c3ad.p20f35e63.p4670093c.p20d80102", m533f = "TophRefund.kt", m534i = {}, m535l = {36}, m536m = "startContactless", m537n = {}, m538s = {})
readonly class p20d80102$p99f0cdc5$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object f2fb507a3;
    int f48155314;
    int f7f28dea5;
    java.lang.object f8f4b654b;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fef4ae157;
    readonly p83f5c3ad.p20f35e63.p4670093c.p20d80102 this$0;

    p20d80102$p99f0cdc5$1(p83f5c3ad.p20f35e63.p4670093c.p20d80102 p20d80102Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p20f35e63.p4670093c.p20d80102$p99f0cdc5$1> continuation) {
        super(continuation);
        this.this$0 = p20d80102Var;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.startContactless(this);
    }
}

