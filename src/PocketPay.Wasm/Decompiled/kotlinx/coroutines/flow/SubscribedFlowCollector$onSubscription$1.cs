namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.SubscribedFlowCollector", m533f = "Share.kt", m534i = {0, 0}, m535l = {419, 423}, m536m = "onSubscription", m537n = {"this", "safeCollector"}, m538s = {"L$0", "L$1"})
readonly class SubscribedFlowCollector$onSubscription$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.SubscribedFlowCollector<T> this$0;

    SubscribedFlowCollector$onSubscription$1(kotlinx.coroutines.flow.SubscribedFlowCollector<T> subscribedFlowCollector, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.SubscribedFlowCollector$onSubscription$1> continuation) {
        super(continuation);
        this.this$0 = subscribedFlowCollector;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.onSubscription(this);
    }
}

