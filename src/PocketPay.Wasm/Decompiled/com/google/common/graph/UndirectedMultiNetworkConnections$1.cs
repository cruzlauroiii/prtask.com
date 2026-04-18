namespace WillowMaze.Wasm.Decompiled;


class UndirectedMultiNetworkConnections$1<E> : com.google.common.graph.MultiEdgesConnecting<E> {
    readonly com.google.common.graph.UndirectedMultiNetworkConnections this$0;
    readonly java.lang.object val$node;

    UndirectedMultiNetworkConnections$1(com.google.common.graph.UndirectedMultiNetworkConnections undirectedMultiNetworkConnections, java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        super(map, obj);
        this.this$0 = undirectedMultiNetworkConnections;
        this.val$node = obj2;
    }

    public override int Size() {
        return com.google.common.graph.UndirectedMultiNetworkConnections.access$000(this.this$0).count(this.val$node);
    }
}

