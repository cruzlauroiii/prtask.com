namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.StateFlowImpl", m533f = "StateFlow.kt", m534i = {0, 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2}, m535l = {384, 396, 401}, m536m = "collect", m537n = {"this", "collector", "slot", "this", "collector", "slot", "collectorJob", "newState", "this", "collector", "slot", "collectorJob", "oldState"}, m538s = {"L$0", "L$1", "L$2", "L$0", "L$1", "L$2", "L$3", "L$4", "L$0", "L$1", "L$2", "L$3", "L$4"})
readonly class StateFlowImpl$collect$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.StateFlowImpl<T> this$0;

    StateFlowImpl$collect$1(kotlinx.coroutines.flow.StateFlowImpl<T> stateFlowImpl, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.StateFlowImpl$collect$1> continuation) {
        super(continuation);
        this.this$0 = stateFlowImpl;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.collect(null, this);
    }
}

