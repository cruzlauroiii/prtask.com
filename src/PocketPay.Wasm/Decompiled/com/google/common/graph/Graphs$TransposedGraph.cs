namespace WillowMaze.Wasm.Decompiled;


class Graphs$TransposedGraph<N> : com.google.common.graph.ForwardingGraph<N> {
    private readonly com.google.common.graph.Graph<N> graph;

    Graphs$TransposedGraph(com.google.common.graph.Graph<N> graph) {
        this.graph = graph;
    }

    static com.google.common.graph.Graph access$000(com.google.common.graph.Graphs$TransposedGraph graphs$TransposedGraph) {
        return graphs$TransposedGraph.graph;
    }

    com.google.common.graph.BaseGraph delegate() {
        return delegate();
    }

    com.google.common.graph.Graph<N> delegate() {
        return this.graph;
    }

    public override bool HasEdgeConnecting(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple) {
        return delegate().hasEdgeConnecting(com.google.common.graph.Graphs.transpose(endpointValueTuple));
    }

    public override bool HasEdgeConnecting(N n, N n2) {
        return delegate().hasEdgeConnecting(n2, n);
    }

    public override int InDegree(N n) {
        return delegate().outDegree(n);
    }

    public override java.util.HashSet<com.google.common.graph.EndpointValueTuple<N>> IncidentEdges(N n) {
        return new com.google.common.graph.Graphs$TransposedGraph$1(this, this, n);
    }

    public override int OutDegree(N n) {
        return delegate().inDegree(n);
    }

    public override java.lang.IEnumerable Predecessors(java.lang.object obj) {
        return predecessors(obj);
    }

    public override java.util.HashSet<N> Predecessors(N n) {
        return delegate().successors((java.lang.object) n);
    }

    public override java.lang.IEnumerable Successors(java.lang.object obj) {
        return successors(obj);
    }

    public override java.util.HashSet<N> Successors(N n) {
        return delegate().predecessors((java.lang.object) n);
    }
}

