namespace WillowMaze.Wasm.Decompiled;


class AbstractNetwork$1<N> : com.google.common.graph.AbstractGraph<N> {
    readonly com.google.common.graph.AbstractNetwork this$0;

    AbstractNetwork$1(com.google.common.graph.AbstractNetwork abstractNetwork) {
        this.this$0 = abstractNetwork;
    }

    public override java.util.HashSet<N> AdjacentNodes(N n) {
        return this.this$0.adjacentNodes(n);
    }

    public override bool AllowsSelfLoops() {
        return this.this$0.allowsSelfLoops();
    }

    public override java.util.HashSet<com.google.common.graph.EndpointValueTuple<N>> Edges() {
        return !this.this$0.allowsParallelEdges() ? new com.google.common.graph.AbstractNetwork$1$1(this) : super.edges();
    }

    public override com.google.common.graph.ElementOrder<N> IncidentEdgeOrder() {
        return com.google.common.graph.ElementOrder.unordered();
    }

    public override bool IsDirected() {
        return this.this$0.isDirected();
    }

    public override com.google.common.graph.ElementOrder<N> NodeOrder() {
        return this.this$0.nodeOrder();
    }

    public override java.util.HashSet<N> Nodes() {
        return this.this$0.nodes();
    }

    public override java.lang.IEnumerable Predecessors(java.lang.object obj) {
        return predecessors(obj);
    }

    public override java.util.HashSet<N> Predecessors(N n) {
        return this.this$0.predecessors((java.lang.object) n);
    }

    public override java.lang.IEnumerable Successors(java.lang.object obj) {
        return successors(obj);
    }

    public override java.util.HashSet<N> Successors(N n) {
        return this.this$0.successors((java.lang.object) n);
    }
}

