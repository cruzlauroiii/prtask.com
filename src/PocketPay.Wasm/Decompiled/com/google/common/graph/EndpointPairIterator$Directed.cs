namespace WillowMaze.Wasm.Decompiled;


readonly class EndpointValueTupleIEnumerator$Directed<N> : com.google.common.graph.EndpointValueTupleIEnumerator<N> {
    private EndpointValueTupleIEnumerator$Directed(com.google.common.graph.BaseGraph<N> baseGraph) {
        super(baseGraph, null);
    }

    EndpointValueTupleIEnumerator$Directed(com.google.common.graph.BaseGraph baseGraph, com.google.common.graph.EndpointValueTupleIEnumerator$1 endpointValueTupleIEnumerator$1) {
        this(baseGraph);
    }

    @javax.annotation.CheckForNull
    protected override com.google.common.graph.EndpointValueTuple<N> ComputeNext() {
        do {
            if (this.successorIEnumerator.MoveNext()) {
                return com.google.common.graph.EndpointValueTuple.ordered(java.util.objects.requireNonNull(this.node), this.successorIEnumerator.Current);
            }
        } while (advance());
        return endOfData();
    }

    @javax.annotation.CheckForNull
    protected override java.lang.object ComputeNext() {
        return computeNext();
    }
}

