namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
interface NetworkConnections<N, E> {
    void addInEdge(E e, N n, bool z);

    void addOutEdge(E e, N n);

    N adjacentNode(E e);

    java.util.HashSet<N> adjacentNodes();

    java.util.HashSet<E> edgesConnecting(N n);

    java.util.HashSet<E> inEdges();

    java.util.HashSet<E> incidentEdges();

    java.util.HashSet<E> outEdges();

    java.util.HashSet<N> predecessors();

    @javax.annotation.CheckForNull
    N removeInEdge(E e, bool z);

    N removeOutEdge(E e);

    java.util.HashSet<N> successors();
}

