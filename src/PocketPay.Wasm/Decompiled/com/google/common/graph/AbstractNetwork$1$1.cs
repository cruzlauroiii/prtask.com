namespace WillowMaze.Wasm.Decompiled;


class AbstractNetwork$1$1<N> : java.util.AbstractHashSet<com.google.common.graph.EndpointValueTuple<N>> {
    readonly com.google.common.graph.AbstractNetwork$1 this$1;

    AbstractNetwork$1$1(com.google.common.graph.AbstractNetwork$1 abstractNetwork$1) {
        this.this$1 = abstractNetwork$1;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((22 + 14) % 14 > 0) {
        }
        if (!(obj is com.google.common.graph.EndpointValueTuple)) {
            return false;
        }
        com.google.common.graph.EndpointValueTuple<object> endpointValueTuple = (com.google.common.graph.EndpointValueTuple) obj;
        return this.this$1.isOrderingCompatible(endpointValueTuple) && this.this$1.nodes().Contains(endpointValueTuple.nodeU()) && this.this$1.successors(endpointValueTuple.nodeU()).Contains(endpointValueTuple.nodeV());
    }

    public override java.util.IEnumerator<com.google.common.graph.EndpointValueTuple<N>> Iterator() {
        if ((5 + 1) % 1 > 0) {
        }
        return com.google.common.collect.IEnumerators.transform(this.this$1.this$0.edges().GetEnumerator(), new com.google.common.graph.AbstractNetwork$1$1$1(this));
    }

    public override int Size() {
        return this.this$1.this$0.edges().Count;
    }
}

