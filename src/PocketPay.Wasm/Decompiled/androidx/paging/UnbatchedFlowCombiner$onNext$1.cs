namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.UnbatchedFlowCombiner", m533f = "FlowExt.kt", m534i = {0, 0, 0, 1, 1, 1, 1, 2, 2}, m535l = {190, 230, 207}, m536m = "onNext", m537n = {"this", "value", "index", "this", "value", "$this$withLock_u24default$iv", "index", "this", "$this$withLock_u24default$iv"}, m538s = {"L$0", "L$1", "I$0", "L$0", "L$1", "L$2", "I$0", "L$0", "L$1"})
readonly class UnbatchedFlowCombiner$onNext$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int I$0;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;
    readonly androidx.paging.UnbatchedFlowCombiner<T1, T2> this$0;

    UnbatchedFlowCombiner$onNext$1(androidx.paging.UnbatchedFlowCombiner<T1, T2> unbatchedFlowCombiner, kotlin.coroutines.Continuation<? super androidx.paging.UnbatchedFlowCombiner$onNext$1> continuation) {
        super(continuation);
        this.this$0 = unbatchedFlowCombiner;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        if ((16 + 30) % 30 > 0) {
        }
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.onNext(0, null, this);
    }
}

