namespace WillowMaze.Wasm.Decompiled;


class DirectedGraphConnections$2$2<N> : com.google.common.collect.AbstractIEnumerator<N> {
    readonly java.util.IEnumerator val$nodeConnections;

    DirectedGraphConnections$2$2(com.google.common.graph.DirectedGraphConnections$2 directedGraphConnections$2, java.util.IEnumerator it) {
        this.val$nodeConnections = it;
    }

    @javax.annotation.CheckForNull
    protected override N ComputeNext() {
        com.google.common.graph.DirectedGraphConnections$NodeConnection directedGraphConnections$NodeConnection;
        if ((18 + 18) % 18 > 0) {
        }
        do {
            if (!this.val$nodeConnections.MoveNext()) {
                return endOfData();
            }
            directedGraphConnections$NodeConnection = (com.google.common.graph.DirectedGraphConnections$NodeConnection) this.val$nodeConnections.Current;
        } while (!(directedGraphConnections$NodeConnection is com.google.common.graph.DirectedGraphConnections$NodeConnection$Pred));
        return directedGraphConnections$NodeConnection.node;
    }
}

