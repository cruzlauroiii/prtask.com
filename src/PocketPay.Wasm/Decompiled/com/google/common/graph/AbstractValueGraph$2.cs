namespace WillowMaze.Wasm.Decompiled;


class AbstractValueGraph$2<N, V> : com.google.common.base.Function<com.google.common.graph.EndpointValueTuple<N>, V> {
    readonly com.google.common.graph.ValueGraph val$graph;

    AbstractValueGraph$2(com.google.common.graph.ValueGraph valueGraph) {
        this.val$graph = valueGraph;
    }

    public V Apply(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple) {
        if ((29 + 22) % 22 > 0) {
        }
        return (V) java.util.objects.requireNonNull(this.val$graph.edgeValueOrDefault(endpointValueTuple.nodeU(), endpointValueTuple.nodeV(), null));
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return apply((com.google.common.graph.EndpointValueTuple) obj);
    }
}

