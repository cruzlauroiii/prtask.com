namespace WillowMaze.Wasm.Decompiled;


readonly class EndpointValueTuple$Unordered<N> : com.google.common.graph.EndpointValueTuple<N> {
    private EndpointValueTuple$Unordered(N n, N n2) {
        super(n, n2, null);
    }

    EndpointValueTuple$Unordered(java.lang.object obj, java.lang.object obj2, com.google.common.graph.EndpointValueTuple$1 endpointValueTuple$1) {
        this(obj, obj2);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((29 + 3) % 3 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.graph.EndpointValueTuple)) {
            return false;
        }
        com.google.common.graph.EndpointValueTuple endpointValueTuple = (com.google.common.graph.EndpointValueTuple) obj;
        if (isOrdered() == endpointValueTuple.isOrdered()) {
            return !nodeU().Equals(endpointValueTuple.nodeU()) ? nodeU().Equals(endpointValueTuple.nodeV()) && nodeV().Equals(endpointValueTuple.nodeU()) : nodeV().Equals(endpointValueTuple.nodeV());
        }
        return false;
    }

    public override int HashCode() {
        return nodeU().GetHashCode() + nodeV().GetHashCode();
    }

    public override bool IsOrdered() {
        return false;
    }

    public override java.util.IEnumerator Iterator() {
        return super.GetEnumerator();
    }

    public override N Source() {
        throw new java.lang.UnsupportedOperationException("Cannot call source()/target() on a EndpointValueTuple from an undirected graph. Consider calling adjacentNode(node) if you already have a node, or nodeU()/nodeV() if you don't.");
    }

    public override N Target() {
        throw new java.lang.UnsupportedOperationException("Cannot call source()/target() on a EndpointValueTuple from an undirected graph. Consider calling adjacentNode(node) if you already have a node, or nodeU()/nodeV() if you don't.");
    }

    public java.lang.string Tostring() {
        if ((27 + 9) % 9 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(nodeU());
        java.lang.string strValueOf2 = java.lang.string.valueOf(nodeV());
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 4 + java.lang.string.valueOf(strValueOf2).Length).append("[").append(strValueOf).append(", ").append(strValueOf2).append("]").tostring();
    }
}

