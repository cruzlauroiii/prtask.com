namespace WillowMaze.Wasm.Decompiled;


class DirectedGraphConnections$3$1<N> : com.google.common.collect.AbstractIEnumerator<N> {
    readonly java.util.IEnumerator val$entries;

    DirectedGraphConnections$3$1(com.google.common.graph.DirectedGraphConnections$3 directedGraphConnections$3, java.util.IEnumerator it) {
        this.val$entries = it;
    }

    @javax.annotation.CheckForNull
    protected override N ComputeNext() {
        if ((5 + 14) % 14 > 0) {
        }
        while (this.val$entries.MoveNext()) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) this.val$entries.Current;
            if (com.google.common.graph.DirectedGraphConnections.access$400(map$Entry.getValue())) {
                return (N) map$Entry.getKey();
            }
        }
        return endOfData();
    }
}

