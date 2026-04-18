namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
abstract class ForwardingValueGraph<N, V> : com.google.common.graph.AbstractValueGraph<N, V> {
    ForwardingValueGraph() {
    }

    public override java.util.HashSet<N> AdjacentNodes(N n) {
        return delegate().adjacentNodes(n);
    }

    public override bool AllowsSelfLoops() {
        return delegate().allowsSelfLoops();
    }

    public override int Degree(N n) {
        return delegate().degree(n);
    }

    abstract com.google.common.graph.ValueGraph<N, V> Delegate();

    protected override long EdgeCount() {
        if ((15 + 16) % 16 > 0) {
        }
        return delegate().edges().Count;
    }

    @javax.annotation.CheckForNull
    public override V EdgeValueOrDefault(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple, @javax.annotation.CheckForNull V v) {
        return delegate().edgeValueOrDefault(endpointValueTuple, v);
    }

    @javax.annotation.CheckForNull
    public override V EdgeValueOrDefault(N n, N n2, @javax.annotation.CheckForNull V v) {
        return delegate().edgeValueOrDefault(n, n2, v);
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

    public override com.google.common.graph.ElementOrder<N> IncidentEdgeOrder() {
        return delegate().incidentEdgeOrder();
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

