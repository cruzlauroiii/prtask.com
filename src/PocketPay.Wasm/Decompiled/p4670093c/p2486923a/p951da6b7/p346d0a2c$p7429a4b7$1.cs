namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.p2486923a.p951da6b7.p346d0a2c", m533f = "PaybackReceiptDetailobjectModel.kt", m534i = {}, m535l = {129}, m536m = "hasComboTophPayment", m537n = {}, m538s = {})
readonly class p346d0a2c$p7429a4b7$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object fa447fc54;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fe7982c09;
    readonly p4670093c.p2486923a.p951da6b7.p346d0a2c this$0;

    p346d0a2c$p7429a4b7$1(p4670093c.p2486923a.p951da6b7.p346d0a2c p346d0a2cVar, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.p951da6b7.p346d0a2c$p7429a4b7$1> continuation) {
        super(continuation);
        this.this$0 = p346d0a2cVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return p4670093c.p2486923a.p951da6b7.p346d0a2c.m966168f4(this.this$0, this);
    }
}

