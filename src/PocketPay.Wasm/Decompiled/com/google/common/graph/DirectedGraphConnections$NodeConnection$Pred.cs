namespace WillowMaze.Wasm.Decompiled;


readonly class DirectedGraphConnections$NodeConnection$Pred<N> : com.google.common.graph.DirectedGraphConnections$NodeConnection<N> {
    DirectedGraphConnections$NodeConnection$Pred(N n) {
        super(n);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is com.google.common.graph.DirectedGraphConnections$NodeConnection$Pred) {
            return this.node.Equals(((com.google.common.graph.DirectedGraphConnections$NodeConnection$Pred) obj).node);
        }
        return false;
    }

    public int HashCode() {
        return com.google.common.graph.DirectedGraphConnections$NodeConnection$Pred.class.GetHashCode() + this.node.GetHashCode();
    }
}

