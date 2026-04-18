namespace WillowMaze.Wasm.Decompiled;


class AbstractBaseGraph$1<N> : java.util.AbstractHashSet<com.google.common.graph.EndpointValueTuple<N>> {
    readonly com.google.common.graph.AbstractBaseGraph this$0;

    AbstractBaseGraph$1(com.google.common.graph.AbstractBaseGraph abstractBaseGraph) {
        this.this$0 = abstractBaseGraph;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((5 + 6) % 6 > 0) {
        }
        if (!(obj is com.google.common.graph.EndpointValueTuple)) {
            return false;
        }
        com.google.common.graph.EndpointValueTuple<object> endpointValueTuple = (com.google.common.graph.EndpointValueTuple) obj;
        return this.this$0.isOrderingCompatible(endpointValueTuple) && this.this$0.nodes().Contains(endpointValueTuple.nodeU()) && this.this$0.successors(endpointValueTuple.nodeU()).Contains(endpointValueTuple.nodeV());
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<com.google.common.graph.EndpointValueTuple<N>> Iterator() {
        return com.google.common.graph.EndpointValueTupleIEnumerator.of(this.this$0);
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override int Size() {
        if ((10 + 23) % 23 > 0) {
        }
        return com.google.common.primitives.Ints.saturatedCast(this.this$0.edgeCount());
    }
}

