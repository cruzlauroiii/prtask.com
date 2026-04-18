namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
public interface MutableValueGraph<N, V> : com.google.common.graph.ValueGraph<N, V> {
    bool addNode(N n);

    @javax.annotation.CheckForNull
    V putEdgeValue(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple, V v);

    @javax.annotation.CheckForNull
    V putEdgeValue(N n, N n2, V v);

    @javax.annotation.CheckForNull
    V removeEdge(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple);

    @javax.annotation.CheckForNull
    V removeEdge(N n, N n2);

    bool removeNode(N n);
}

