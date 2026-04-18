namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p4670093c.p2486923a.p365a4a97.pbb51da1f", m533f = "PaybackPositionsobjectModel.kt", m534i = {}, m535l = {137}, m536m = "hasComboTophPayment", m537n = {}, m538s = {})
readonly class pbb51da1f$p7429a4b7$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f0b56b4a3;
    int f7e49d48b;
    java.lang.object fa8945c77;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fdca6b337;
    readonly p4670093c.p2486923a.p365a4a97.pbb51da1f this$0;

    pbb51da1f$p7429a4b7$1(p4670093c.p2486923a.p365a4a97.pbb51da1f pbb51da1fVar, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.p365a4a97.pbb51da1f$p7429a4b7$1> continuation) {
        super(continuation);
        this.this$0 = pbb51da1fVar;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        return p4670093c.p2486923a.p365a4a97.pbb51da1f.m966168f4(this.this$0, this);
    }
}

