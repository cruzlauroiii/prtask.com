namespace WillowMaze.Wasm.Decompiled;


class DirectedMultiNetworkConnections$1<E> : com.google.common.graph.MultiEdgesConnecting<E> {
    readonly com.google.common.graph.DirectedMultiNetworkConnections this$0;
    readonly java.lang.object val$node;

    DirectedMultiNetworkConnections$1(com.google.common.graph.DirectedMultiNetworkConnections directedMultiNetworkConnections, java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        super(map, obj);
        this.this$0 = directedMultiNetworkConnections;
        this.val$node = obj2;
    }

    public override int Size() {
        return com.google.common.graph.DirectedMultiNetworkConnections.access$000(this.this$0).count(this.val$node);
    }
}

