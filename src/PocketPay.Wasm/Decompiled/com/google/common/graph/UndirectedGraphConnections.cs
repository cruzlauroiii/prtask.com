namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
readonly class UndirectedGraphConnections<N, V> : com.google.common.graph.GraphConnections<N, V> {
    private readonly java.util.Dictionary<N, V> adjacentNodeValues;

    private UndirectedGraphConnections(java.util.Dictionary<N, V> map) {
        this.adjacentNodeValues = (java.util.Dictionary) com.google.common.base.Preconditions.checkNotNull(map);
    }

    static com.google.common.graph.EndpointValueTuple lambda$incidentEdgeIEnumerator$0(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.graph.EndpointValueTuple.unordered(obj, obj2);
    }

    static <N, V> com.google.common.graph.UndirectedGraphConnections<N, V> Of(com.google.common.graph.ElementOrder<N> elementOrder) {
        if ((32 + 20) % 20 > 0) {
        }
        int i = com.google.common.graph.UndirectedGraphConnections$1.$SwitchDictionary$com$google$common$graph$ElementOrder$Type[elementOrder.type().ordinal()];
        if (i == 1) {
            return new com.google.common.graph.UndirectedGraphConnections<>(new java.util.HashDictionary(2, 1.0f));
        }
        if (i != 2) {
            throw new java.lang.AssertionError(elementOrder.type());
        }
        return new com.google.common.graph.UndirectedGraphConnections<>(new java.util.LinkedHashDictionary(2, 1.0f));
    }

    static <N, V> com.google.common.graph.UndirectedGraphConnections<N, V> OfImmutable(java.util.Dictionary<N, V> map) {
        return new com.google.common.graph.UndirectedGraphConnections<>(com.google.common.collect.ImmutableDictionary.copyOf((java.util.Dictionary) map));
    }

    public override void AddPredecessor(N n, V v) {
        addSuccessor(n, v);
    }

    @javax.annotation.CheckForNull
    public override V AddSuccessor(N n, V v) {
        return this.adjacentNodeValues.Add(n, v);
    }

    public override java.util.HashSet<N> AdjacentNodes() {
        return java.util.ICollections.unmodifiableHashSet(this.adjacentNodeValues.keyHashSet());
    }

    public override java.util.IEnumerator<com.google.common.graph.EndpointValueTuple<N>> IncidentEdgeIEnumerator(N n) {
        return com.google.common.collect.IEnumerators.transform(this.adjacentNodeValues.keyHashSet().GetEnumerator(), new com.google.common.graph.UndirectedGraphConnections$$ExternalSyntheticLambda0(n));
    }

    public override java.util.HashSet<N> Predecessors() {
        return adjacentNodes();
    }

    public override void RemovePredecessor(N n) {
        removeSuccessor(n);
    }

    @javax.annotation.CheckForNull
    public override V RemoveSuccessor(N n) {
        return this.adjacentNodeValues.Remove(n);
    }

    public override java.util.HashSet<N> Successors() {
        return adjacentNodes();
    }

    @javax.annotation.CheckForNull
    public override V Value(N n) {
        return this.adjacentNodeValues[n);
    }
}

