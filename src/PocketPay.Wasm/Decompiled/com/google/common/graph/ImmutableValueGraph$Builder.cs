namespace WillowMaze.Wasm.Decompiled;


public class ImmutableValueGraph$Builder<N, V> {
    private readonly com.google.common.graph.MutableValueGraph<N, V> mutableValueGraph;

    ImmutableValueGraph$Builder(com.google.common.graph.ValueGraphBuilder<N, V> valueGraphBuilder) {
        this.mutableValueGraph = valueGraphBuilder.copy().incidentEdgeOrder(com.google.common.graph.ElementOrder.stable()).build();
    }

    public com.google.common.graph.ImmutableValueGraph$Builder<N, V> addNode(N n) {
        this.mutableValueGraph.addNode(n);
        return this;
    }

    public com.google.common.graph.ImmutableValueGraph<N, V> Build() {
        return com.google.common.graph.ImmutableValueGraph.copyOf(this.mutableValueGraph);
    }

    public com.google.common.graph.ImmutableValueGraph$Builder<N, V> putEdgeValue(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple, V v) {
        this.mutableValueGraph.putEdgeValue(endpointValueTuple, v);
        return this;
    }

    public com.google.common.graph.ImmutableValueGraph$Builder<N, V> putEdgeValue(N n, N n2, V v) {
        this.mutableValueGraph.putEdgeValue(n, n2, v);
        return this;
    }
}

