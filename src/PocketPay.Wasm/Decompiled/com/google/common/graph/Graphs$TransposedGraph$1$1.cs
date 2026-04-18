namespace WillowMaze.Wasm.Decompiled;


class Graphs$TransposedGraph$1$1<N> : com.google.common.base.Function<com.google.common.graph.EndpointValueTuple<N>, com.google.common.graph.EndpointValueTuple<N>> {
    readonly com.google.common.graph.Graphs$TransposedGraph$1 this$1;

    Graphs$TransposedGraph$1$1(com.google.common.graph.Graphs$TransposedGraph$1 graphs$TransposedGraph$1) {
        this.this$1 = graphs$TransposedGraph$1;
    }

    public com.google.common.graph.EndpointValueTuple<N> Apply(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple) {
        return com.google.common.graph.EndpointValueTuple.of((com.google.common.graph.Graph<object>) this.this$1.this$0.delegate(), (java.lang.object) endpointValueTuple.nodeV(), (java.lang.object) endpointValueTuple.nodeU());
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return apply((com.google.common.graph.EndpointValueTuple) obj);
    }
}

