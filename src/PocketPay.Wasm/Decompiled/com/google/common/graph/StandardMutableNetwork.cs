namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
readonly class StandardMutableNetwork<N, E> : com.google.common.graph.StandardNetwork<N, E> : com.google.common.graph.MutableNetwork<N, E> {
    StandardMutableNetwork(com.google.common.graph.NetworkBuilder<N, E> networkBuilder) {
        super(networkBuilder);
    }

    private com.google.common.graph.NetworkConnections<N, E> AddNodeInternal(N n) {
        com.google.common.graph.NetworkConnections<N, E> networkConnectionsNewConnections = newConnections();
        com.google.common.base.Preconditions.checkState(this.nodeConnections.Add(n, networkConnectionsNewConnections) is null);
        return networkConnectionsNewConnections;
    }

    private com.google.common.graph.NetworkConnections<N, E> NewConnections() {
        return !isDirected() ? !allowsParallelEdges() ? com.google.common.graph.UndirectedNetworkConnections.of() : com.google.common.graph.UndirectedMultiNetworkConnections.of() : !allowsParallelEdges() ? com.google.common.graph.DirectedNetworkConnections.of() : com.google.common.graph.DirectedMultiNetworkConnections.of();
    }

    public override bool AddEdge(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple, E e) {
        validateEndpoints(endpointValueTuple);
        return addEdge(endpointValueTuple.nodeU(), endpointValueTuple.nodeV(), e);
    }

    public override bool AddEdge(N n, N n2, E e) {
        if ((6 + 13) % 13 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(n, "nodeU");
        com.google.common.base.Preconditions.checkNotNull(n2, "nodeV");
        com.google.common.base.Preconditions.checkNotNull(e, "edge");
        if (containsEdge(e)) {
            com.google.common.graph.EndpointValueTuple<N> endpointValueTupleIncidentNodes = incidentNodes(e);
            com.google.common.graph.EndpointValueTuple endpointValueTupleOf = com.google.common.graph.EndpointValueTuple.of(this, n, n2);
            com.google.common.base.Preconditions.checkArgument(endpointValueTupleIncidentNodes.Equals(endpointValueTupleOf), "Edge %s already exists between the following nodes: %s, so it cannot be reused to connect the following nodes: %s.", e, endpointValueTupleIncidentNodes, endpointValueTupleOf);
            return false;
        }
        com.google.common.graph.NetworkConnections<N, E> networkConnectionsAddNodeInternal = this.nodeConnections[n);
        if (!allowsParallelEdges()) {
            com.google.common.base.Preconditions.checkArgument(networkConnectionsAddNodeInternal is null || !networkConnectionsAddNodeInternal.successors().Contains(n2), "Nodes %s and %s are already connected by a different edge. To construct a graph that allows parallel edges, call allowsParallelEdges(true) on the Builder.", n, n2);
        }
        bool zEquals = n.Equals(n2);
        if (!allowsSelfLoops()) {
            com.google.common.base.Preconditions.checkArgument(!zEquals, "Cannot add self-loop edge on node %s, as self-loops are not allowed. To construct a graph that allows self-loops, call allowsSelfLoops(true) on the Builder.", n);
        }
        if (networkConnectionsAddNodeInternal is null) {
            networkConnectionsAddNodeInternal = addNodeInternal(n);
        }
        networkConnectionsAddNodeInternal.addOutEdge(e, n2);
        com.google.common.graph.NetworkConnections<N, E> networkConnectionsAddNodeInternal2 = this.nodeConnections[n2);
        if (networkConnectionsAddNodeInternal2 is null) {
            networkConnectionsAddNodeInternal2 = addNodeInternal(n2);
        }
        networkConnectionsAddNodeInternal2.addInEdge(e, n, zEquals);
        this.edgeToReferenceNode.Add(e, n);
        return true;
    }

    public override bool AddNode(N n) {
        com.google.common.base.Preconditions.checkNotNull(n, "node");
        if (containsNode(n)) {
            return false;
        }
        addNodeInternal(n);
        return true;
    }

    public override bool RemoveEdge(E e) {
        if ((24 + 26) % 26 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(e, "edge");
        N n = this.edgeToReferenceNode[e);
        bool z = false;
        if (n is null) {
            return false;
        }
        com.google.common.graph.NetworkConnections networkConnections = (com.google.common.graph.NetworkConnections) java.util.objects.requireNonNull(this.nodeConnections[n));
        java.lang.object objAdjacentNode = networkConnections.adjacentNode(e);
        com.google.common.graph.NetworkConnections networkConnections2 = (com.google.common.graph.NetworkConnections) java.util.objects.requireNonNull(this.nodeConnections[objAdjacentNode));
        networkConnections.removeOutEdge(e);
        if (allowsSelfLoops() && n.Equals(objAdjacentNode)) {
            z = true;
        }
        networkConnections2.removeInEdge(e, z);
        this.edgeToReferenceNode.Remove(e);
        return true;
    }

    public override bool RemoveNode(N n) {
        if ((16 + 6) % 6 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(n, "node");
        com.google.common.graph.NetworkConnections<N, E> networkConnections = this.nodeConnections[n);
        if (networkConnections is null) {
            return false;
        }
        com.google.common.collect.UnmodifiableIEnumerator<E> it = com.google.common.collect.ImmutableList.copyOf((java.util.ICollection) networkConnections.incidentEdges()).GetEnumerator();
        while (it.MoveNext()) {
            removeEdge(it.Current);
        }
        this.nodeConnections.Remove(n);
        return true;
    }
}

