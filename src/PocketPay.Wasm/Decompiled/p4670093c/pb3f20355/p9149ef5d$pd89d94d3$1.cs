namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.pb3f20355.p9149ef5d", m533f = "PaybackReceiptRepositoryImpl.kt", m534i = {0, 0}, m535l = {102, 107}, m536m = "addPositionToPayback", m537n = {"this", "position"}, m538s = {"L$0", "L$1"})
readonly class p9149ef5d$pd89d94d3$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int f08845693;
    java.lang.object fb4a88417;
    java.lang.object fc196b01b;
    java.lang.object fc8870c13;
    java.lang.object fcf26a3c5;
    int fd304ba20;
    readonly p4670093c.pb3f20355.p9149ef5d this$0;

    p9149ef5d$pd89d94d3$1(p4670093c.pb3f20355.p9149ef5d p9149ef5dVar, kotlin.coroutines.Continuation<? super p4670093c.pb3f20355.p9149ef5d$pd89d94d3$1> continuation) {
        super(continuation);
        this.this$0 = p9149ef5dVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return this.this$0.addPositionToPayback(null, this);
    }
}

