namespace WillowMaze.Wasm.Decompiled;


class AbstractNetwork$1$1$1<E, N> : com.google.common.base.Function<E, com.google.common.graph.EndpointValueTuple<N>> {
    readonly com.google.common.graph.AbstractNetwork$1$1 this$2;

    AbstractNetwork$1$1$1(com.google.common.graph.AbstractNetwork$1$1 abstractNetwork$1$1) {
        this.this$2 = abstractNetwork$1$1;
    }

    public override com.google.common.graph.EndpointValueTuple<N> Apply(E e) {
        return this.this$2.this$1.this$0.incidentNodes(e);
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return apply(obj);
    }
}

