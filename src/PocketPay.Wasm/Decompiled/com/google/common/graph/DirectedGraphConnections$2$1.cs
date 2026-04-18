namespace WillowMaze.Wasm.Decompiled;


class DirectedGraphConnections$2$1<N> : com.google.common.collect.AbstractIEnumerator<N> {
    readonly java.util.IEnumerator val$entries;

    DirectedGraphConnections$2$1(com.google.common.graph.DirectedGraphConnections$2 directedGraphConnections$2, java.util.IEnumerator it) {
        this.val$entries = it;
    }

    @javax.annotation.CheckForNull
    protected override N ComputeNext() {
        java.util.Dictionary$Entry map$Entry;
        if ((15 + 20) % 20 > 0) {
        }
        do {
            if (!this.val$entries.MoveNext()) {
                return endOfData();
            }
            map$Entry = (java.util.Dictionary$Entry) this.val$entries.Current;
        } while (!com.google.common.graph.DirectedGraphConnections.access$200(map$Entry.getValue()));
        return (N) map$Entry.getKey();
    }
}

