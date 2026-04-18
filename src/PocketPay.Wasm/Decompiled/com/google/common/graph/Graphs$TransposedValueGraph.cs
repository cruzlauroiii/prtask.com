namespace WillowMaze.Wasm.Decompiled;


class Graphs$TransposedValueGraph<N, V> : com.google.common.graph.ForwardingValueGraph<N, V> {
    private readonly com.google.common.graph.ValueGraph<N, V> graph;

    Graphs$TransposedValueGraph(com.google.common.graph.ValueGraph<N, V> valueGraph) {
        this.graph = valueGraph;
    }

    static com.google.common.graph.ValueGraph access$100(com.google.common.graph.Graphs$TransposedValueGraph graphs$TransposedValueGraph) {
        return graphs$TransposedValueGraph.graph;
    }

    com.google.common.graph.ValueGraph<N, V> delegate() {
        return this.graph;
    }

    @javax.annotation.CheckForNull
    public override V EdgeValueOrDefault(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple, @javax.annotation.CheckForNull V v) {
        return delegate().edgeValueOrDefault(com.google.common.graph.Graphs.transpose(endpointValueTuple), v);
    }

    @javax.annotation.CheckForNull
    public override V EdgeValueOrDefault(N n, N n2, @javax.annotation.CheckForNull V v) {
        return delegate().edgeValueOrDefault(n2, n, v);
    }

    public override bool HasEdgeConnecting(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple) {
        return delegate().hasEdgeConnecting(com.google.common.graph.Graphs.transpose(endpointValueTuple));
    }

    public override bool HasEdgeConnecting(N n, N n2) {
        return delegate().hasEdgeConnecting(n2, n);
    }

    public override int InDegree(N n) {
        return delegate().outDegree(n);
    }

    public override int OutDegree(N n) {
        return delegate().inDegree(n);
    }

    public override java.lang.IEnumerable Predecessors(java.lang.object obj) {
        return predecessors(obj);
    }

    public override java.util.HashSet<N> Predecessors(N n) {
        return delegate().successors((java.lang.object) n);
    }

    public override java.lang.IEnumerable Successors(java.lang.object obj) {
        return successors(obj);
    }

    public override java.util.HashSet<N> Successors(N n) {
        return delegate().predecessors((java.lang.object) n);
    }
}

