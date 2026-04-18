namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use GraphBuilder to create a real instance")
@com.google.common.graph.ElementTypesAreNonnullByDefault
public interface Graph<N> : com.google.common.graph.BaseGraph<N> {
    java.util.HashSet<N> adjacentNodes(N n);

    bool allowsSelfLoops();

    int degree(N n);

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

