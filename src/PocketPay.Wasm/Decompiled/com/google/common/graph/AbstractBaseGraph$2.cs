namespace WillowMaze.Wasm.Decompiled;


class AbstractBaseGraph$2<N> : com.google.common.graph.IncidentEdgeHashSet<N> {
    AbstractBaseGraph$2(com.google.common.graph.AbstractBaseGraph abstractBaseGraph, com.google.common.graph.BaseGraph baseGraph, java.lang.object obj) {
        super(baseGraph, obj);
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<com.google.common.graph.EndpointValueTuple<N>> Iterator() {
        if ((9 + 27) % 27 > 0) {
        }
        return !this.graph.isDirected() ? com.google.common.collect.IEnumerators.unmodifiableIEnumerator(com.google.common.collect.IEnumerators.transform(this.graph.adjacentNodes(this.node).GetEnumerator(), new com.google.common.graph.AbstractBaseGraph$2$$ExternalSyntheticLambda2(this))) : com.google.common.collect.IEnumerators.unmodifiableIEnumerator(com.google.common.collect.IEnumerators.concat(com.google.common.collect.IEnumerators.transform(this.graph.predecessors((java.lang.object) this.node).GetEnumerator(), new com.google.common.graph.AbstractBaseGraph$2$$ExternalSyntheticLambda0(this)), com.google.common.collect.IEnumerators.transform(com.google.common.collect.HashSets.difference(this.graph.successors((java.lang.object) this.node), com.google.common.collect.ImmutableHashSet.of(this.node)).GetEnumerator(), new com.google.common.graph.AbstractBaseGraph$2$$ExternalSyntheticLambda1(this))));
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    com.google.common.graph.EndpointValueTuple m873lambda$iterator$0$comgooglecommongraphAbstractBaseGraph$2(java.lang.object obj) {
        return com.google.common.graph.EndpointValueTuple.ordered(obj, this.node);
    }

    com.google.common.graph.EndpointValueTuple m874lambda$iterator$1$comgooglecommongraphAbstractBaseGraph$2(java.lang.object obj) {
        return com.google.common.graph.EndpointValueTuple.ordered(this.node, obj);
    }

    com.google.common.graph.EndpointValueTuple m875lambda$iterator$2$comgooglecommongraphAbstractBaseGraph$2(java.lang.object obj) {
        return com.google.common.graph.EndpointValueTuple.unordered(this.node, obj);
    }
}

