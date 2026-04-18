namespace WillowMaze.Wasm.Decompiled;


readonly class DirectedGraphConnections$NodeConnection$Succ<N> : com.google.common.graph.DirectedGraphConnections$NodeConnection<N> {
    DirectedGraphConnections$NodeConnection$Succ(N n) {
        super(n);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is com.google.common.graph.DirectedGraphConnections$NodeConnection$Succ) {
            return this.node.Equals(((com.google.common.graph.DirectedGraphConnections$NodeConnection$Succ) obj).node);
        }
        return false;
    }

    public int HashCode() {
        return com.google.common.graph.DirectedGraphConnections$NodeConnection$Succ.class.GetHashCode() + this.node.GetHashCode();
    }
}

