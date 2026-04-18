namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.SubscribedSharedFlow", m533f = "Share.kt", m534i = {}, m535l = {409}, m536m = "collect", m537n = {}, m538s = {})
readonly class SubscribedSharedFlow$collect$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.SubscribedSharedFlow<T> this$0;

    SubscribedSharedFlow$collect$1(kotlinx.coroutines.flow.SubscribedSharedFlow<T> subscribedSharedFlow, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.SubscribedSharedFlow$collect$1> continuation) {
        super(continuation);
        this.this$0 = subscribedSharedFlow;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.collect(null, this);
    }
}

