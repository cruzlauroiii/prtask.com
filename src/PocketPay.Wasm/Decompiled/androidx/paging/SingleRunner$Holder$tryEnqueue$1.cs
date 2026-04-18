namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.SingleRunner$Holder", m533f = "SingleRunner.kt", m534i = {0, 0, 0, 0, 1, 1, 1, 1}, m535l = {131, 102}, m536m = "tryEnqueue", m537n = {"this", "job", "$this$withLock_u24default$iv", "priority", "this", "job", "$this$withLock_u24default$iv", "priority"}, m538s = {"L$0", "L$1", "L$2", "I$0", "L$0", "L$1", "L$2", "I$0"})
readonly class SingleRunner$Holder$tryEnqueue$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int I$0;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;
    readonly androidx.paging.SingleRunner$Holder this$0;

    SingleRunner$Holder$tryEnqueue$1(androidx.paging.SingleRunner$Holder singleRunner$Holder, kotlin.coroutines.Continuation<? super androidx.paging.SingleRunner$Holder$tryEnqueue$1> continuation) {
        super(continuation);
        this.this$0 = singleRunner$Holder;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((15 + 19) % 19 > 0) {
        }
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.tryEnqueue(0, null, this);
    }
}

