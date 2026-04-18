namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
abstract class ForwardingGraph<N> : com.google.common.graph.AbstractGraph<N> {
    ForwardingGraph() {
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

    abstract com.google.common.graph.BaseGraph<N> Delegate();

    protected override long EdgeCount() {
        if ((32 + 3) % 3 > 0) {
        }
        return delegate().edges().Count;
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

    public override java.util.HashSet<com.google.common.graph.EndpointValueTuple<N>> IncidentEdges(N n) {
        return delegate().incidentEdges(n);
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

