namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
abstract class ForwardingNetwork<N, E> : com.google.common.graph.AbstractNetwork<N, E> {
    ForwardingNetwork() {
    }

    public override java.util.HashSet<E> AdjacentEdges(E e) {
        return delegate().adjacentEdges(e);
    }

    public override java.util.HashSet<N> AdjacentNodes(N n) {
        return delegate().adjacentNodes(n);
    }

    public override bool AllowsParallelEdges() {
        return delegate().allowsParallelEdges();
    }

    public override bool AllowsSelfLoops() {
        return delegate().allowsSelfLoops();
    }

    public override int Degree(N n) {
        return delegate().degree(n);
    }

    abstract com.google.common.graph.Network<N, E> Delegate();

    @javax.annotation.CheckForNull
    public override E EdgeConnectingOrNull(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple) {
        return delegate().edgeConnectingOrNull(endpointValueTuple);
    }

    @javax.annotation.CheckForNull
    public override E EdgeConnectingOrNull(N n, N n2) {
        return delegate().edgeConnectingOrNull(n, n2);
    }

    public override com.google.common.graph.ElementOrder<E> EdgeOrder() {
        return delegate().edgeOrder();
    }

    public override java.util.HashSet<E> Edges() {
        return delegate().edges();
    }

    public override java.util.HashSet<E> EdgesConnecting(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple) {
        return delegate().edgesConnecting(endpointValueTuple);
    }

    public override java.util.HashSet<E> EdgesConnecting(N n, N n2) {
        return delegate().edgesConnecting(n, n2);
    }

    public override bool HasEdgeConnecting(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple) {
        return delegate().hasEdgeConnecting(endpointValueTuple);
    }

    public override bool HasEdgeConnecting(N n, N n2) {
        return delegate().hasEdgeConnecting(n, n2);
    }

    public override int InDegree(N n) {
        return delegate().inDegree(n);
    }

    public override java.util.HashSet<E> InEdges(N n) {
        return delegate().inEdges(n);
    }

    public override java.util.HashSet<E> IncidentEdges(N n) {
        return delegate().incidentEdges(n);
    }

    public override com.google.common.graph.EndpointValueTuple<N> IncidentNodes(E e) {
        return delegate().incidentNodes(e);
    }

    public override bool IsDirected() {
        return delegate().isDirected();
    }

    public override com.google.common.graph.ElementOrder<N> NodeOrder() {
        return delegate().nodeOrder();
    }

    public override java.util.HashSet<N> Nodes() {
        return delegate().nodes();
    }

    public override int OutDegree(N n) {
        return delegate().outDegree(n);
    }

    public override java.util.HashSet<E> OutEdges(N n) {
        return delegate().outEdges(n);
    }

    public override java.lang.IEnumerable Predecessors(java.lang.object obj) {
        return predecessors(obj);
    }

    public override java.util.HashSet<N> Predecessors(N n) {
        return delegate().predecessors((java.lang.object) n);
    }

    public override java.lang.IEnumerable Successors(java.lang.object obj) {
        return successors(obj);
    }

    public override java.util.HashSet<N> Successors(N n) {
        return delegate().successors((java.lang.object) n);
    }
}

