namespace WillowMaze.Wasm.Decompiled;


class Graphs$TransposedNetwork<N, E> : com.google.common.graph.ForwardingNetwork<N, E> {
    private readonly com.google.common.graph.Network<N, E> network;

    Graphs$TransposedNetwork(com.google.common.graph.Network<N, E> network) {
        this.network = network;
    }

    static com.google.common.graph.Network access$200(com.google.common.graph.Graphs$TransposedNetwork graphs$TransposedNetwork) {
        return graphs$TransposedNetwork.network;
    }

    com.google.common.graph.Network<N, E> delegate() {
        return this.network;
    }

    @javax.annotation.CheckForNull
    public override E EdgeConnectingOrNull(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple) {
        return delegate().edgeConnectingOrNull(com.google.common.graph.Graphs.transpose(endpointValueTuple));
    }

    @javax.annotation.CheckForNull
    public override E EdgeConnectingOrNull(N n, N n2) {
        return delegate().edgeConnectingOrNull(n2, n);
    }

    public override java.util.HashSet<E> EdgesConnecting(com.google.common.graph.EndpointValueTuple<N> endpointValueTuple) {
        return delegate().edgesConnecting(com.google.common.graph.Graphs.transpose(endpointValueTuple));
    }

    public override java.util.HashSet<E> EdgesConnecting(N n, N n2) {
        return delegate().edgesConnecting(n2, n);
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

    public override java.util.HashSet<E> InEdges(N n) {
        return delegate().outEdges(n);
    }

    public override com.google.common.graph.EndpointValueTuple<N> IncidentNodes(E e) {
        com.google.common.graph.EndpointValueTuple<N> endpointValueTupleIncidentNodes = delegate().incidentNodes(e);
        return com.google.common.graph.EndpointValueTuple.of((com.google.common.graph.Network<object, object>) this.network, (java.lang.object) endpointValueTupleIncidentNodes.nodeV(), (java.lang.object) endpointValueTupleIncidentNodes.nodeU());
    }

    public override int OutDegree(N n) {
        return delegate().inDegree(n);
    }

    public override java.util.HashSet<E> OutEdges(N n) {
        return delegate().inEdges(n);
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

