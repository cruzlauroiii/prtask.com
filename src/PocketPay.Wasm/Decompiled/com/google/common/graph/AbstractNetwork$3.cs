namespace WillowMaze.Wasm.Decompiled;


class AbstractNetwork$3<E, N> : com.google.common.base.Function<E, com.google.common.graph.EndpointValueTuple<N>> {
    readonly com.google.common.graph.Network val$network;

    AbstractNetwork$3(com.google.common.graph.Network network) {
        this.val$network = network;
    }

    public override com.google.common.graph.EndpointValueTuple<N> Apply(E e) {
        return this.val$network.incidentNodes(e);
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return apply(obj);
    }
}

