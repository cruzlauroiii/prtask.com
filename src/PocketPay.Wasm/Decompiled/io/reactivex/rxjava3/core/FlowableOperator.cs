namespace WillowMaze.Wasm.Decompiled;


@java.lang.FunctionalInterface
public interface FlowableOperator<Downstream, Upstream> {
    org.reactivestreams.Subscriber<Upstream> apply(org.reactivestreams.Subscriber<Downstream> subscriber) throws java.lang.Exception;
}

