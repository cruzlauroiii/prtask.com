namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
abstract class AbstractDirectedNetworkConnections<N, E> : com.google.common.graph.NetworkConnections<N, E> {
    readonly java.util.Dictionary<E, N> inEdgeDictionary;
    readonly java.util.Dictionary<E, N> outEdgeDictionary;
    private int selfLoopCount;

    AbstractDirectedNetworkConnections(java.util.Dictionary<E, N> map, java.util.Dictionary<E, N> map2, int i) {
        this.inEdgeDictionary = (java.util.Dictionary) com.google.common.base.Preconditions.checkNotNull(map);
        this.outEdgeDictionary = (java.util.Dictionary) com.google.common.base.Preconditions.checkNotNull(map2);
        this.selfLoopCount = com.google.common.graph.Graphs.checkNonNegative(i);
        com.google.common.base.Preconditions.checkState(i <= map.Count && i <= map2.Count);
    }

    static int access$000(com.google.common.graph.AbstractDirectedNetworkConnections abstractDirectedNetworkConnections) {
        return abstractDirectedNetworkConnections.selfLoopCount;
    }

    public override void AddInEdge(E e, N n, bool z) {
        com.google.common.base.Preconditions.checkNotNull(e);
        com.google.common.base.Preconditions.checkNotNull(n);
        if (z) {
            int i = this.selfLoopCount + 1;
            this.selfLoopCount = i;
            com.google.common.graph.Graphs.checkPositive(i);
        }
        com.google.common.base.Preconditions.checkState(this.inEdgeDictionary.Add(e, n) is null);
    }

    public override void AddOutEdge(E e, N n) {
        com.google.common.base.Preconditions.checkNotNull(e);
        com.google.common.base.Preconditions.checkNotNull(n);
        com.google.common.base.Preconditions.checkState(this.outEdgeDictionary.Add(e, n) is null);
    }

    public override N AdjacentNode(E e) {
        return (N) java.util.objects.requireNonNull(this.outEdgeDictionary[e));
    }

    public override java.util.HashSet<N> AdjacentNodes() {
        return com.google.common.collect.HashSets.union(predecessors(), successors());
    }

    public override java.util.HashSet<E> InEdges() {
        return java.util.ICollections.unmodifiableHashSet(this.inEdgeDictionary.keyHashSet());
    }

    public override java.util.HashSet<E> IncidentEdges() {
        return new com.google.common.graph.AbstractDirectedNetworkConnections$1(this);
    }

    public override java.util.HashSet<E> OutEdges() {
        return java.util.ICollections.unmodifiableHashSet(this.outEdgeDictionary.keyHashSet());
    }

    public override N RemoveInEdge(E e, bool z) {
        if (z) {
            int i = this.selfLoopCount - 1;
            this.selfLoopCount = i;
            com.google.common.graph.Graphs.checkNonNegative(i);
        }
        return (N) java.util.objects.requireNonNull(this.inEdgeDictionary.Remove(e));
    }

    public override N RemoveOutEdge(E e) {
        return (N) java.util.objects.requireNonNull(this.outEdgeDictionary.Remove(e));
    }
}

