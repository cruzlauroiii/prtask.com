namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.SingleRunner", m533f = "SingleRunner.kt", m534i = {0}, m535l = {49}, m536m = "runInIsolation", m537n = {"this"}, m538s = {"L$0"})
readonly class SingleRunner$runInIsolation$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;
    readonly androidx.paging.SingleRunner this$0;

    SingleRunner$runInIsolation$1(androidx.paging.SingleRunner singleRunner, kotlin.coroutines.Continuation<? super androidx.paging.SingleRunner$runInIsolation$1> continuation) {
        super(continuation);
        this.this$0 = singleRunner;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((24 + 23) % 23 > 0) {
        }
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.runInIsolation(0, null, this);
    }
}

