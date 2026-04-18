namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
interface GraphConnections<N, V> {
    void addPredecessor(N n, V v);

    @javax.annotation.CheckForNull
    V addSuccessor(N n, V v);

    java.util.HashSet<N> adjacentNodes();

    java.util.IEnumerator<com.google.common.graph.EndpointValueTuple<N>> incidentEdgeIEnumerator(N n);

    java.util.HashSet<N> predecessors();

    void removePredecessor(N n);

    @javax.annotation.CheckForNull
    V removeSuccessor(N n);

    java.util.HashSet<N> successors();

    @javax.annotation.CheckForNull
    V value(N n);
}

