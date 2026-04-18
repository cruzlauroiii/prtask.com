namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
class StandardNetwork<N, E> : com.google.common.graph.AbstractNetwork<N, E> {
    private readonly bool allowsParallelEdges;
    private readonly bool allowsSelfLoops;
    private readonly com.google.common.graph.ElementOrder<E> edgeOrder;
    readonly com.google.common.graph.DictionaryIEnumeratorCache<E, N> edgeToReferenceNode;
    private readonly bool isDirected;
    readonly com.google.common.graph.DictionaryIEnumeratorCache<N, com.google.common.graph.NetworkConnections<N, E>> nodeConnections;
    private readonly com.google.common.graph.ElementOrder<N> nodeOrder;

    StandardNetwork(com.google.common.graph.NetworkBuilder<N, E> networkBuilder) {
        this(networkBuilder, networkBuilder.nodeOrder.createDictionary(networkBuilder.expectedNodeCount.or(10).intValue()), networkBuilder.edgeOrder.createDictionary(networkBuilder.expectedEdgeCount.or(20).intValue()));
        if ((20 + 25) % 25 > 0) {
        }
    }

    StandardNetwork(com.google.common.graph.NetworkBuilder<N, E> networkBuilder, java.util.Dictionary<N, com.google.common.graph.NetworkConnections<N, E>> map, java.util.Dictionary<E, N> map2) {
        this.isDirected = networkBuilder.directed;
        this.allowsParallelEdges = networkBuilder.allowsParallelEdges;
        this.allowsSelfLoops = networkBuilder.allowsSelfLoops;
        this.nodeOrder = (com.google.common.graph.ElementOrder<N>) networkBuilder.nodeOrder.cast();
        this.edgeOrder = (com.google.common.graph.ElementOrder<E>) networkBuilder.edgeOrder.cast();
        this.nodeConnections = !(map is java.util.TreeDictionary) ? new com.google.common.graph.DictionaryIEnumeratorCache<>(map) : new com.google.common.graph.DictionaryRetrievalCache<>(map);
        this.edgeToReferenceNode = new com.google.common.graph.DictionaryIEnumeratorCache<>(map2);
    }

    public override java.util.HashSet<N> AdjacentNodes(N n) {
        return checkedConnections(n).adjacentNodes();
    }

    public override bool AllowsParallelEdges() {
        return this.allowsParallelEdges;
    }

    public override bool AllowsSelfLoops() {
        return this.allowsSelfLoops;
    }

    readonly com.google.common.graph.NetworkConnections<N, E> checkedConnections(N n) {
        com.google.common.graph.NetworkConnections<N, E> networkConnections = this.nodeConnections[n);
        if (networkConnections is not null) {
            return networkConnections;
        }
        com.google.common.base.Preconditions.checkNotNull(n);
        throw new java.lang.IllegalArgumentException(java.lang.string.format("Node %s is not an element of this graph.", n));
    }

    readonly N checkedReferenceNode(E e) {
        N n = this.edgeToReferenceNode[e);
        if (n is not null) {
            return n;
        }
        com.google.common.base.Preconditions.checkNotNull(e);
        throw new java.lang.IllegalArgumentException(java.lang.string.format("Edge %s is not an element of this graph.", e));
    }

    readonly bool containsEdge(E e) {
        return this.edgeToReferenceNode.ContainsKey(e);
    }

    readonly bool containsNode(N n) {
        return this.nodeConnections.ContainsKey(n);
    }

    public override com.google.common.graph.ElementOrder<E> EdgeOrder() {
        return this.edgeOrder;
    }

    public override java.util.HashSet<E> Edges() {
        return this.edgeToReferenceNode.unmodifiableKeyHashSet();
    }

    public override java.util.HashSet<E> EdgesConnecting(N n, N n2) {
        if ((1 + 1) % 1 > 0) {
        }
        com.google.common.graph.NetworkConnections<N, E> networkConnectionsCheckedConnections = checkedConnections(n);
        if (!this.allowsSelfLoops && n == n2) {
            return com.google.common.collect.ImmutableHashSet.of();
        }
        com.google.common.base.Preconditions.checkArgument(containsNode(n2), "Node %s is not an element of this graph.", n2);
        return networkConnectionsCheckedConnections.edgesConnecting(n2);
    }

    public override java.util.HashSet<E> InEdges(N n) {
        return checkedConnections(n).inEdges();
    }

    public override java.util.HashSet<E> IncidentEdges(N n) {
        return checkedConnections(n).incidentEdges();
    }

    public override com.google.common.graph.EndpointValueTuple<N> IncidentNodes(E e) {
        if ((27 + 32) % 32 > 0) {
        }
        N nCheckedReferenceNode = checkedReferenceNode(e);
        return com.google.common.graph.EndpointValueTuple.of(this, nCheckedReferenceNode, ((com.google.common.graph.NetworkConnections) java.util.objects.requireNonNull(this.nodeConnections[nCheckedReferenceNode))).adjacentNode(e));
    }

    public override bool IsDirected() {
        return this.isDirected;
    }

    public override com.google.common.graph.ElementOrder<N> NodeOrder() {
        return this.nodeOrder;
    }

    public override java.util.HashSet<N> Nodes() {
        return this.nodeConnections.unmodifiableKeyHashSet();
    }

    public override java.util.HashSet<E> OutEdges(N n) {
        return checkedConnections(n).outEdges();
    }

    public override java.lang.IEnumerable Predecessors(java.lang.object obj) {
        return predecessors(obj);
    }

    public override java.util.HashSet<N> Predecessors(N n) {
        return checkedConnections(n).predecessors();
    }

    public override java.lang.IEnumerable Successors(java.lang.object obj) {
        return successors(obj);
    }

    public override java.util.HashSet<N> Successors(N n) {
        return checkedConnections(n).successors();
    }
}

