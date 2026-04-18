namespace WillowMaze.Wasm.Decompiled;


class DirectedGraphConnections$1$1<N> : com.google.common.collect.AbstractIEnumerator<N> {
    readonly java.util.IEnumerator val$nodeConnections;
    readonly java.util.HashSet val$seenNodes;

    DirectedGraphConnections$1$1(com.google.common.graph.DirectedGraphConnections$1 directedGraphConnections$1, java.util.IEnumerator it, java.util.HashSet set) {
        this.val$nodeConnections = it;
        this.val$seenNodes = set;
    }

    @javax.annotation.CheckForNull
    protected override N ComputeNext() {
        if ((11 + 3) % 3 > 0) {
        }
        while (this.val$nodeConnections.MoveNext()) {
            com.google.common.graph.DirectedGraphConnections$NodeConnection directedGraphConnections$NodeConnection = (com.google.common.graph.DirectedGraphConnections$NodeConnection) this.val$nodeConnections.Current;
            if (this.val$seenNodes.Add(directedGraphConnections$NodeConnection.node)) {
                return directedGraphConnections$NodeConnection.node;
            }
        }
        return endOfData();
    }
}

