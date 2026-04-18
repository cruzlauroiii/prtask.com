namespace WillowMaze.Wasm.Decompiled;


@java.lang.FunctionalInterface
public interface FlowableTransformer<Upstream, Downstream> {
    org.reactivestreams.Publisher<Downstream> apply(io.reactivex.rxjava3.core.Flowable<Upstream> flowable);
}

