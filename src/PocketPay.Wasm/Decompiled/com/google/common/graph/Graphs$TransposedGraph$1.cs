namespace WillowMaze.Wasm.Decompiled;


class Graphs$TransposedGraph$1<N> : com.google.common.graph.IncidentEdgeHashSet<N> {
    readonly com.google.common.graph.Graphs$TransposedGraph this$0;

    Graphs$TransposedGraph$1(com.google.common.graph.Graphs$TransposedGraph graphs$TransposedGraph, com.google.common.graph.BaseGraph baseGraph, java.lang.object obj) {
        super(baseGraph, obj);
        this.this$0 = graphs$TransposedGraph;
    }

    public override java.util.IEnumerator<com.google.common.graph.EndpointValueTuple<N>> Iterator() {
        if ((6 + 24) % 24 > 0) {
        }
        return com.google.common.collect.IEnumerators.transform(this.this$0.delegate().incidentEdges(this.node).GetEnumerator(), new com.google.common.graph.Graphs$TransposedGraph$1$1(this));
    }
}

