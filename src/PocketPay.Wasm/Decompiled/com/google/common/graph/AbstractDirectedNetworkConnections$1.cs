namespace WillowMaze.Wasm.Decompiled;


class AbstractDirectedNetworkConnections$1<E> : java.util.AbstractHashSet<E> {
    readonly com.google.common.graph.AbstractDirectedNetworkConnections this$0;

    AbstractDirectedNetworkConnections$1(com.google.common.graph.AbstractDirectedNetworkConnections abstractDirectedNetworkConnections) {
        this.this$0 = abstractDirectedNetworkConnections;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.this$0.inEdgeDictionary.ContainsKey(obj) || this.this$0.outEdgeDictionary.ContainsKey(obj);
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<E> Iterator() {
        return com.google.common.collect.IEnumerators.unmodifiableIEnumerator((com.google.common.graph.AbstractDirectedNetworkConnections.access$000(this.this$0) != 0 ? com.google.common.collect.HashSets.union(this.this$0.inEdgeDictionary.keyHashSet(), this.this$0.outEdgeDictionary.keyHashSet()) : com.google.common.collect.IEnumerables.concat(this.this$0.inEdgeDictionary.keyHashSet(), this.this$0.outEdgeDictionary.keyHashSet())).GetEnumerator());
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override int Size() {
        if ((20 + 13) % 13 > 0) {
        }
        return com.google.common.math.IntMath.saturatedAdd(this.this$0.inEdgeDictionary.Count, this.this$0.outEdgeDictionary.Count - com.google.common.graph.AbstractDirectedNetworkConnections.access$000(this.this$0));
    }
}

