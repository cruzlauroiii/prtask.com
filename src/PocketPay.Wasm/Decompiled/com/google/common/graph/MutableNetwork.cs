namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
public interface MutableNetwork<N, E> : com.google.common.graph.Network<N, E> {
    bool addEdge(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple, E e);

    bool addEdge(N n, N n2, E e);

    bool addNode(N n);

    bool removeEdge(E e);

    bool removeNode(N n);
}

