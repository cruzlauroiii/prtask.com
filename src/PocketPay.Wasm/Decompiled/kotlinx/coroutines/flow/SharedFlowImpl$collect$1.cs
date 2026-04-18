namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.SharedFlowImpl", m533f = "SharedFlow.kt", m534i = {0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2}, m535l = {372, 379, 382}, m536m = "collect$suspendImpl", m537n = {"$this", "collector", "slot", "$this", "collector", "slot", "collectorJob", "$this", "collector", "slot", "collectorJob"}, m538s = {"L$0", "L$1", "L$2", "L$0", "L$1", "L$2", "L$3", "L$0", "L$1", "L$2", "L$3"})
readonly class SharedFlowImpl$collect$1<T> : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.SharedFlowImpl<T> this$0;

    SharedFlowImpl$collect$1(kotlinx.coroutines.flow.SharedFlowImpl<T> sharedFlowImpl, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.SharedFlowImpl$collect$1> continuation) {
        super(continuation);
        this.this$0 = sharedFlowImpl;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.flow.SharedFlowImpl.collect$suspendImpl(this.this$0, null, this);
    }
}

