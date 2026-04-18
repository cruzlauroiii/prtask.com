namespace WillowMaze.Wasm.Decompiled;


public class ImmutableGraph$Builder<N> {
    private readonly com.google.common.graph.MutableGraph<N> mutableGraph;

    ImmutableGraph$Builder(com.google.common.graph.GraphBuilder<N> graphBuilder) {
        this.mutableGraph = graphBuilder.copy().incidentEdgeOrder(com.google.common.graph.ElementOrder.stable()).build();
    }

    public com.google.common.graph.ImmutableGraph$Builder<N> addNode(N n) {
        this.mutableGraph.addNode(n);
        return this;
    }

    public com.google.common.graph.ImmutableGraph<N> Build() {
        return com.google.common.graph.ImmutableGraph.copyOf(this.mutableGraph);
    }

    public com.google.common.graph.ImmutableGraph$Builder<N> putEdge(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple) {
        this.mutableGraph.putEdge(endpointValueTuple);
        return this;
    }

    public com.google.common.graph.ImmutableGraph$Builder<N> putEdge(N n, N n2) {
        this.mutableGraph.putEdge(n, n2);
        return this;
    }
}

