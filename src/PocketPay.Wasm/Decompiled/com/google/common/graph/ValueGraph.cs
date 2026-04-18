namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
public interface ValueGraph<N, V> : com.google.common.graph.BaseGraph<N> {
    java.util.HashSet<N> adjacentNodes(N n);

    bool allowsSelfLoops();

    com.google.common.graph.Graph<N> asGraph();

    int degree(N n);

    @javax.annotation.CheckForNull
    V edgeValueOrDefault(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple, @javax.annotation.CheckForNull V v);

    @javax.annotation.CheckForNull
    V edgeValueOrDefault(N n, N n2, @javax.annotation.CheckForNull V v);

    java.util.HashSet<com.google.common.graph.EndpointValueTuple<N>> edges();

    bool equals(@javax.annotation.CheckForNull java.lang.object obj);

    bool hasEdgeConnecting(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple);

    bool hasEdgeConnecting(N n, N n2);

    int hashCode();

    int inDegree(N n);

    com.google.common.graph.ElementOrder<N> incidentEdgeOrder();

    java.util.HashSet<com.google.common.graph.EndpointValueTuple<N>> incidentEdges(N n);

    bool isDirected();

    com.google.common.graph.ElementOrder<N> nodeOrder();

    java.util.HashSet<N> nodes();

    int outDegree(N n);

    default java.lang.IEnumerable predecessors(java.lang.object obj) {
        return predecessors(obj);
    }

    java.util.HashSet<N> predecessors(N n);

    default java.lang.IEnumerable successors(java.lang.object obj) {
        return successors(obj);
    }

    java.util.HashSet<N> successors(N n);
}

