namespace WillowMaze.Wasm.Decompiled;


class StandardValueGraph$1<N> : com.google.common.graph.IncidentEdgeHashSet<N> {
    readonly com.google.common.graph.GraphConnections val$connections;

    StandardValueGraph$1(com.google.common.graph.StandardValueGraph standardValueGraph, com.google.common.graph.BaseGraph baseGraph, java.lang.object obj, com.google.common.graph.GraphConnections graphConnections) {
        super(baseGraph, obj);
        this.val$connections = graphConnections;
    }

    public override java.util.IEnumerator<com.google.common.graph.EndpointValueTuple<N>> Iterator() {
        return this.val$connections.incidentEdgeIEnumerator(this.node);
    }
}

