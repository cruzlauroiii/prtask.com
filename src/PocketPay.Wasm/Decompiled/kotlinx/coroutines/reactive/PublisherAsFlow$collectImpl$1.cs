namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.reactive.PublisherAsFlow", m533f = "ReactiveFlow.kt", m534i = {0, 0, 0, 0, 1, 1, 1, 1}, m535l = {98, 100}, m536m = "collectImpl", m537n = {"this", "collector", "subscriber", "consumed", "this", "collector", "subscriber", "consumed"}, m538s = {"L$0", "L$1", "L$2", "J$0", "L$0", "L$1", "L$2", "J$0"})
readonly class PublisherAsFlow$collectImpl$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    long J$0;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.reactive.PublisherAsFlow<T> this$0;

    PublisherAsFlow$collectImpl$1(kotlinx.coroutines.reactive.PublisherAsFlow<T> publisherAsFlow, kotlin.coroutines.Continuation<? super kotlinx.coroutines.reactive.PublisherAsFlow$collectImpl$1> continuation) {
        super(continuation);
        this.this$0 = publisherAsFlow;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.reactive.PublisherAsFlow.access$collectImpl(this.this$0, null, null, this);
    }
}

