namespace WillowMaze.Wasm.Decompiled;


class DirectedGraphConnections$3<N> : java.util.AbstractHashSet<N> {
    readonly com.google.common.graph.DirectedGraphConnections this$0;

    DirectedGraphConnections$3(com.google.common.graph.DirectedGraphConnections directedGraphConnections) {
        this.this$0 = directedGraphConnections;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.graph.DirectedGraphConnections.access$400(com.google.common.graph.DirectedGraphConnections.access$100(this.this$0)[obj));
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<N> Iterator() {
        if ((1 + 32) % 32 > 0) {
        }
        return com.google.common.graph.DirectedGraphConnections.access$000(this.this$0) is not null ? new com.google.common.graph.DirectedGraphConnections$3$2(this, com.google.common.graph.DirectedGraphConnections.access$000(this.this$0).GetEnumerator()) : new com.google.common.graph.DirectedGraphConnections$3$1(this, com.google.common.graph.DirectedGraphConnections.access$100(this.this$0).entryHashSet().GetEnumerator());
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override int Size() {
        return com.google.common.graph.DirectedGraphConnections.access$500(this.this$0);
    }
}

