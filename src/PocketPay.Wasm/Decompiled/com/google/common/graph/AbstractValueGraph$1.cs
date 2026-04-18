namespace WillowMaze.Wasm.Decompiled;


class AbstractValueGraph$1<N> : com.google.common.graph.AbstractGraph<N> {
    readonly com.google.common.graph.AbstractValueGraph this$0;

    AbstractValueGraph$1(com.google.common.graph.AbstractValueGraph abstractValueGraph) {
        this.this$0 = abstractValueGraph;
    }

    public override java.util.HashSet<N> AdjacentNodes(N n) {
        return this.this$0.adjacentNodes(n);
    }

    public override bool AllowsSelfLoops() {
        return this.this$0.allowsSelfLoops();
    }

    public override int Degree(N n) {
        return this.this$0.degree(n);
    }

    public override java.util.HashSet<com.google.common.graph.EndpointValueTuple<N>> Edges() {
        return this.this$0.edges();
    }

    public override int InDegree(N n) {
        return this.this$0.inDegree(n);
    }

    public override com.google.common.graph.ElementOrder<N> IncidentEdgeOrder() {
        return this.this$0.incidentEdgeOrder();
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

    public override int OutDegree(N n) {
        return this.this$0.outDegree(n);
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

