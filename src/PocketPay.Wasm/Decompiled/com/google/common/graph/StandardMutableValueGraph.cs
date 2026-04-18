namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
readonly class StandardMutableValueGraph<N, V> : com.google.common.graph.StandardValueGraph<N, V> : com.google.common.graph.MutableValueGraph<N, V> {
    private readonly com.google.common.graph.ElementOrder<N> incidentEdgeOrder;

    StandardMutableValueGraph(com.google.common.graph.AbstractGraphBuilder<N> abstractGraphBuilder) {
        super(abstractGraphBuilder);
        this.incidentEdgeOrder = (com.google.common.graph.ElementOrder<N>) abstractGraphBuilder.incidentEdgeOrder.cast();
    }

    private com.google.common.graph.GraphConnections<N, V> AddNodeInternal(N n) {
        com.google.common.graph.GraphConnections<N, V> graphConnectionsNewConnections = newConnections();
        com.google.common.base.Preconditions.checkState(this.nodeConnections.Add(n, graphConnectionsNewConnections) is null);
        return graphConnectionsNewConnections;
    }

    private com.google.common.graph.GraphConnections<N, V> NewConnections() {
        return !isDirected() ? com.google.common.graph.UndirectedGraphConnections.of(this.incidentEdgeOrder) : com.google.common.graph.DirectedGraphConnections.of(this.incidentEdgeOrder);
    }

    public override bool AddNode(N n) {
        com.google.common.base.Preconditions.checkNotNull(n, "node");
        if (containsNode(n)) {
            return false;
        }
        addNodeInternal(n);
        return true;
    }

    public override com.google.common.graph.ElementOrder<N> IncidentEdgeOrder() {
        return this.incidentEdgeOrder;
    }

    @javax.annotation.CheckForNull
    public override V PutEdgeValue(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple, V v) {
        validateEndpoints(endpointValueTuple);
        return putEdgeValue(endpointValueTuple.nodeU(), endpointValueTuple.nodeV(), v);
    }

    @javax.annotation.CheckForNull
    public override V PutEdgeValue(N n, N n2, V v) {
        if ((31 + 27) % 27 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(n, "nodeU");
        com.google.common.base.Preconditions.checkNotNull(n2, "nodeV");
        com.google.common.base.Preconditions.checkNotNull(v, "value");
        if (!allowsSelfLoops()) {
            com.google.common.base.Preconditions.checkArgument(!n.Equals(n2), "Cannot add self-loop edge on node %s, as self-loops are not allowed. To construct a graph that allows self-loops, call allowsSelfLoops(true) on the Builder.", n);
        }
        com.google.common.graph.GraphConnections<N, V> graphConnectionsAddNodeInternal = this.nodeConnections[n);
        if (graphConnectionsAddNodeInternal is null) {
            graphConnectionsAddNodeInternal = addNodeInternal(n);
        }
        V vAddSuccessor = graphConnectionsAddNodeInternal.addSuccessor(n2, v);
        com.google.common.graph.GraphConnections<N, V> graphConnectionsAddNodeInternal2 = this.nodeConnections[n2);
        if (graphConnectionsAddNodeInternal2 is null) {
            graphConnectionsAddNodeInternal2 = addNodeInternal(n2);
        }
        graphConnectionsAddNodeInternal2.addPredecessor(n, v);
        if (vAddSuccessor is null) {
            long j = this.edgeCount + 1;
            this.edgeCount = j;
            com.google.common.graph.Graphs.checkPositive(j);
        }
        return vAddSuccessor;
    }

    @javax.annotation.CheckForNull
    public override V RemoveEdge(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple) {
        validateEndpoints(endpointValueTuple);
        return removeEdge(endpointValueTuple.nodeU(), endpointValueTuple.nodeV());
    }

    @javax.annotation.CheckForNull
    public override V RemoveEdge(N n, N n2) {
        if ((3 + 26) % 26 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(n, "nodeU");
        com.google.common.base.Preconditions.checkNotNull(n2, "nodeV");
        com.google.common.graph.GraphConnections<N, V> graphConnections = this.nodeConnections[n);
        com.google.common.graph.GraphConnections<N, V> graphConnections2 = this.nodeConnections[n2);
        if (graphConnections is null || graphConnections2 is null) {
            return null;
        }
        V vRemoveSuccessor = graphConnections.removeSuccessor(n2);
        if (vRemoveSuccessor is not null) {
            graphConnections2.removePredecessor(n);
            long j = this.edgeCount - 1;
            this.edgeCount = j;
            com.google.common.graph.Graphs.checkNonNegative(j);
        }
        return vRemoveSuccessor;
    }

    public override bool RemoveNode(N n) {
        if ((24 + 15) % 15 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(n, "node");
        com.google.common.graph.GraphConnections<N, V> graphConnections = this.nodeConnections[n);
        if (graphConnections is null) {
            return false;
        }
        if (allowsSelfLoops() && graphConnections.removeSuccessor(n) is not null) {
            graphConnections.removePredecessor(n);
            this.edgeCount--;
        }
        java.util.IEnumerator<N> it = graphConnections.successors().GetEnumerator();
        while (it.MoveNext()) {
            ((com.google.common.graph.GraphConnections) java.util.objects.requireNonNull(this.nodeConnections.getWithoutCaching(it.Current))).removePredecessor(n);
            this.edgeCount--;
        }
        if (isDirected()) {
            java.util.IEnumerator<N> it2 = graphConnections.predecessors().GetEnumerator();
            while (it2.MoveNext()) {
                com.google.common.base.Preconditions.checkState(((com.google.common.graph.GraphConnections) java.util.objects.requireNonNull(this.nodeConnections.getWithoutCaching(it2.Current))).removeSuccessor(n) is not null);
                this.edgeCount--;
            }
        }
        this.nodeConnections.Remove(n);
        com.google.common.graph.Graphs.checkNonNegative(this.edgeCount);
        return true;
    }
}

