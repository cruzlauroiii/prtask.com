namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.SimpleProducerScopeImpl", m533f = "SimpleChannelFlow.kt", m534i = {0, 0}, m535l = {101}, m536m = "awaitClose", m537n = {"block", "job"}, m538s = {"L$0", "L$1"})
readonly class SimpleProducerScopeImpl$awaitClose$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly androidx.paging.SimpleProducerScopeImpl<T> this$0;

    SimpleProducerScopeImpl$awaitClose$1(androidx.paging.SimpleProducerScopeImpl<T> simpleProducerScopeImpl, kotlin.coroutines.Continuation<? super androidx.paging.SimpleProducerScopeImpl$awaitClose$1> continuation) {
        super(continuation);
        this.this$0 = simpleProducerScopeImpl;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.awaitClose(null, this);
    }
}

