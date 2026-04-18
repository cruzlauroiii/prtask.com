namespace WillowMaze.Wasm.Decompiled;


public class ImmutableNetwork$Builder<N, E> {
    private readonly com.google.common.graph.MutableNetwork<N, E> mutableNetwork;

    ImmutableNetwork$Builder(com.google.common.graph.NetworkBuilder<N, E> networkBuilder) {
        this.mutableNetwork = (com.google.common.graph.MutableNetwork<N, E>) networkBuilder.build();
    }

    public com.google.common.graph.ImmutableNetwork$Builder<N, E> addEdge(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple, E e) {
        this.mutableNetwork.addEdge(endpointValueTuple, e);
        return this;
    }

    public com.google.common.graph.ImmutableNetwork$Builder<N, E> addEdge(N n, N n2, E e) {
        this.mutableNetwork.addEdge(n, n2, e);
        return this;
    }

    public com.google.common.graph.ImmutableNetwork$Builder<N, E> addNode(N n) {
        this.mutableNetwork.addNode(n);
        return this;
    }

    public com.google.common.graph.ImmutableNetwork<N, E> Build() {
        return com.google.common.graph.ImmutableNetwork.copyOf(this.mutableNetwork);
    }
}

