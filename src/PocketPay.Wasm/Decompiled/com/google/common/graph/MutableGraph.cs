namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
public interface MutableGraph<N> : com.google.common.graph.Graph<N> {
    bool addNode(N n);

    bool putEdge(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple);

    bool putEdge(N n, N n2);

    bool removeEdge(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple);

    bool removeEdge(N n, N n2);

    bool removeNode(N n);
}

