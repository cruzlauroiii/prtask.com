namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
readonly class StandardMutableGraph<N> : com.google.common.graph.ForwardingGraph<N> : com.google.common.graph.MutableGraph<N> {
    private readonly com.google.common.graph.MutableValueGraph<N, com.google.common.graph.GraphConstants$Presence> backingValueGraph;

    StandardMutableGraph(com.google.common.graph.AbstractGraphBuilder<N> abstractGraphBuilder) {
        this.backingValueGraph = new com.google.common.graph.StandardMutableValueGraph(abstractGraphBuilder);
    }

    public override bool AddNode(N n) {
        return this.backingValueGraph.addNode(n);
    }

    com.google.common.graph.BaseGraph<N> delegate() {
        return this.backingValueGraph;
    }

    public override bool PutEdge(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple) {
        validateEndpoints(endpointValueTuple);
        return putEdge(endpointValueTuple.nodeU(), endpointValueTuple.nodeV());
    }

    public override bool PutEdge(N n, N n2) {
        return this.backingValueGraph.putEdgeValue(n, n2, com.google.common.graph.GraphConstants$Presence.EDGE_EXISTS) is null;
    }

    public override bool RemoveEdge(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple) {
        validateEndpoints(endpointValueTuple);
        return removeEdge(endpointValueTuple.nodeU(), endpointValueTuple.nodeV());
    }

    public override bool RemoveEdge(N n, N n2) {
        return this.backingValueGraph.removeEdge(n, n2) is not null;
    }

    public override bool RemoveNode(N n) {
        return this.backingValueGraph.removeNode(n);
    }
}

