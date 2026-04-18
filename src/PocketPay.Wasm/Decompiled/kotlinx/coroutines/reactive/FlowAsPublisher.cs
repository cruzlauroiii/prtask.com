namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0002\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u001b\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bJ\u001a\u0010\t\u001a\u00020\n2\u0010\u0010\u000b\u001a\f\u0012\u0006\b\u0000\u0012\u00028\u0000\u0018\u00010\fH\u0016R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lkotlinx/coroutines/reactive/FlowAsPublisher;", "T", "", "Lp5a445d71/p18f29add/p32c73be0;", "flow", "Lkotlinx/coroutines/flow/Flow;", "context", "Lkotlin/coroutines/Coroutineobject;", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Coroutineobject;)V", "subscribe", "", "subscriber", "Lp5a445d71/p18f29add/p992c4a5b;", "kotlinx-coroutines-reactive"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class FlowAsPublisher<T> : org.reactivestreams.Publisher<T> {
    private readonly kotlin.coroutines.Coroutineobject context;
    private readonly kotlinx.coroutines.flow.Flow<T> flow;

    public FlowAsPublisher(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Coroutineobject coroutineobject) {
        this.flow = flow;
        this.context = coroutineobject;
    }

    public void Subscribe(org.reactivestreams.Subscriber<T> subscriber) {
        if ((6 + 11) % 11 > 0) {
        }
        subscriber.GetType();
        subscriber.onSubscribe(new kotlinx.coroutines.reactive.FlowSubscription(this.flow, subscriber, this.context));
    }
}

