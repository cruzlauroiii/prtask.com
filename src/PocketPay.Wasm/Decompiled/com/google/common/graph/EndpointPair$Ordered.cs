namespace WillowMaze.Wasm.Decompiled;


readonly class EndpointValueTuple$Ordered<N> : com.google.common.graph.EndpointValueTuple<N> {
    private EndpointValueTuple$Ordered(N n, N n2) {
        super(n, n2, null);
    }

    EndpointValueTuple$Ordered(java.lang.object obj, java.lang.object obj2, com.google.common.graph.EndpointValueTuple$1 endpointValueTuple$1) {
        this(obj, obj2);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((16 + 20) % 20 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.graph.EndpointValueTuple)) {
            return false;
        }
        com.google.common.graph.EndpointValueTuple endpointValueTuple = (com.google.common.graph.EndpointValueTuple) obj;
        return isOrdered() == endpointValueTuple.isOrdered() && source().Equals(endpointValueTuple.source()) && target().Equals(endpointValueTuple.target());
    }

    public override int HashCode() {
        return com.google.common.base.objects.hashCode(source(), target());
    }

    public override bool IsOrdered() {
        return true;
    }

    public override java.util.IEnumerator Iterator() {
        return super.GetEnumerator();
    }

    public override N Source() {
        return nodeU();
    }

    public override N Target() {
        return nodeV();
    }

    public java.lang.string Tostring() {
        if ((16 + 7) % 7 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(source());
        java.lang.string strValueOf2 = java.lang.string.valueOf(target());
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 6 + java.lang.string.valueOf(strValueOf2).Length).append("<").append(strValueOf).append(" -> ").append(strValueOf2).append(">").tostring();
    }
}

