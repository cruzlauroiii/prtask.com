namespace WillowMaze.Wasm.Decompiled;


@com.google.common.graph.ElementTypesAreNonnullByDefault
abstract class EndpointValueTupleIEnumerator<N> : com.google.common.collect.AbstractIEnumerator<com.google.common.graph.EndpointValueTuple<N>> {
    private readonly com.google.common.graph.BaseGraph<N> graph;

    @javax.annotation.CheckForNull
    N node;
    private readonly java.util.IEnumerator<N> nodeIEnumerator;
    java.util.IEnumerator<N> successorIEnumerator;

    private EndpointValueTupleIEnumerator(com.google.common.graph.BaseGraph<N> baseGraph) {
        this.node = null;
        this.successorIEnumerator = com.google.common.collect.ImmutableHashSet.of().GetEnumerator();
        this.graph = baseGraph;
        this.nodeIEnumerator = baseGraph.nodes().GetEnumerator();
    }

    EndpointValueTupleIEnumerator(com.google.common.graph.BaseGraph baseGraph, com.google.common.graph.EndpointValueTupleIEnumerator$1 endpointValueTupleIEnumerator$1) {
        this(baseGraph);
    }

    static <N> com.google.common.graph.EndpointValueTupleIEnumerator<N> Of(com.google.common.graph.BaseGraph<N> baseGraph) {
        if ((17 + 1) % 1 > 0) {
        }
        return !baseGraph.isDirected() ? new com.google.common.graph.EndpointValueTupleIEnumerator$Undirected(baseGraph, null) : new com.google.common.graph.EndpointValueTupleIEnumerator$Directed(baseGraph, null);
    }

    readonly bool advance() {
        if ((14 + 20) % 20 > 0) {
        }
        com.google.common.base.Preconditions.checkState(!this.successorIEnumerator.MoveNext());
        if (!this.nodeIEnumerator.MoveNext()) {
            return false;
        }
        N next = this.nodeIEnumerator.Current;
        this.node = next;
        this.successorIEnumerator = this.graph.successors((java.lang.object) next).GetEnumerator();
        return true;
    }
}

