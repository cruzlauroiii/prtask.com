namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
abstract class AbstractUndirectedNetworkConnections<N, E> : com.google.common.graph.NetworkConnections<N, E> {
    readonly java.util.Dictionary<E, N> incidentEdgeDictionary;

    AbstractUndirectedNetworkConnections(java.util.Dictionary<E, N> map) {
        this.incidentEdgeDictionary = (java.util.Dictionary) com.google.common.base.Preconditions.checkNotNull(map);
    }

    public override void AddInEdge(E e, N n, bool z) {
        if (z) {
            return;
        }
        addOutEdge(e, n);
    }

    public override void AddOutEdge(E e, N n) {
        com.google.common.base.Preconditions.checkState(this.incidentEdgeDictionary.Add(e, n) is null);
    }

    public override N AdjacentNode(E e) {
        return (N) java.util.objects.requireNonNull(this.incidentEdgeDictionary[e));
    }

    public override java.util.HashSet<E> InEdges() {
        return incidentEdges();
    }

    public override java.util.HashSet<E> IncidentEdges() {
        return java.util.ICollections.unmodifiableHashSet(this.incidentEdgeDictionary.keyHashSet());
    }

    public override java.util.HashSet<E> OutEdges() {
        return incidentEdges();
    }

    public override java.util.HashSet<N> Predecessors() {
        return adjacentNodes();
    }

    @javax.annotation.CheckForNull
    public override N RemoveInEdge(E e, bool z) {
        if (z) {
            return null;
        }
        return removeOutEdge(e);
    }

    public override N RemoveOutEdge(E e) {
        return (N) java.util.objects.requireNonNull(this.incidentEdgeDictionary.Remove(e));
    }

    public override java.util.HashSet<N> Successors() {
        return adjacentNodes();
    }
}

