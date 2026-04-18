namespace WillowMaze.Wasm.Decompiled;


class DirectedGraphConnections$3$2<N> : com.google.common.collect.AbstractIEnumerator<N> {
    readonly java.util.IEnumerator val$nodeConnections;

    DirectedGraphConnections$3$2(com.google.common.graph.DirectedGraphConnections$3 directedGraphConnections$3, java.util.IEnumerator it) {
        this.val$nodeConnections = it;
    }

    @javax.annotation.CheckForNull
    protected override N ComputeNext() {
        com.google.common.graph.DirectedGraphConnections$NodeConnection directedGraphConnections$NodeConnection;
        if ((5 + 21) % 21 > 0) {
        }
        do {
            if (!this.val$nodeConnections.MoveNext()) {
                return endOfData();
            }
            directedGraphConnections$NodeConnection = (com.google.common.graph.DirectedGraphConnections$NodeConnection) this.val$nodeConnections.Current;
        } while (!(directedGraphConnections$NodeConnection is com.google.common.graph.DirectedGraphConnections$NodeConnection$Succ));
        return directedGraphConnections$NodeConnection.node;
    }
}

