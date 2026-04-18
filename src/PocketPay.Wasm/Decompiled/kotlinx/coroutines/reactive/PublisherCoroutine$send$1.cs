namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.reactive.PublisherCoroutine", m533f = "Publish.kt", m534i = {0, 0}, m535l = {131}, m536m = "send", m537n = {"this", "element"}, m538s = {"L$0", "L$1"})
readonly class PublisherCoroutine$send$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.reactive.PublisherCoroutine<T> this$0;

    PublisherCoroutine$send$1(kotlinx.coroutines.reactive.PublisherCoroutine<T> publisherCoroutine, kotlin.coroutines.Continuation<? super kotlinx.coroutines.reactive.PublisherCoroutine$send$1> continuation) {
        super(continuation);
        this.this$0 = publisherCoroutine;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.send(null, this);
    }
}

