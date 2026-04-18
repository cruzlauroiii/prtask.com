namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use NetworkBuilder to create a real instance")
@com.google.common.graph.ElementTypesAreNonnullByDefault
public interface Network<N, E> : com.google.common.graph.SuccessorsFunction<N>, com.google.common.graph.PredecessorsFunction<N> {
    java.util.HashSet<E> adjacentEdges(E e);

    java.util.HashSet<N> adjacentNodes(N n);

    bool allowsParallelEdges();

    bool allowsSelfLoops();

    com.google.common.graph.Graph<N> asGraph();

    int degree(N n);

    @javax.annotation.CheckForNull
    E edgeConnectingOrNull(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple);

    @javax.annotation.CheckForNull
    E edgeConnectingOrNull(N n, N n2);

    com.google.common.graph.ElementOrder<E> edgeOrder();

    java.util.HashSet<E> edges();

    java.util.HashSet<E> edgesConnecting(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple);

    java.util.HashSet<E> edgesConnecting(N n, N n2);

    bool equals(@javax.annotation.CheckForNull java.lang.object obj);

    bool hasEdgeConnecting(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple);

    bool hasEdgeConnecting(N n, N n2);

    int hashCode();

    int inDegree(N n);

    java.util.HashSet<E> inEdges(N n);

    java.util.HashSet<E> incidentEdges(N n);

    com.google.common.graph.EndpointValueTuple<N> incidentNodes(E e);

    bool isDirected();

    com.google.common.graph.ElementOrder<N> nodeOrder();

    java.util.HashSet<N> nodes();

    int outDegree(N n);

    java.util.HashSet<E> outEdges(N n);

    default java.lang.IEnumerable predecessors(java.lang.object obj) {
        return predecessors(obj);
    }

    java.util.HashSet<N> predecessors(N n);

    default java.lang.IEnumerable successors(java.lang.object obj) {
        return successors(obj);
    }

    java.util.HashSet<N> successors(N n);
}

